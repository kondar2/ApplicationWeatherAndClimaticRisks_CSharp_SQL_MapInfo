using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using ExcelDataReader;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace ForMap
{
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
        }
        

       



        private void create_map_Click(object sender, EventArgs e)
            {
            Process.Start(@".\Connect.MBX");
           
            }

        private void Import_Data_Click(object sender, EventArgs e)
        {
            OpenFileDialog ope = new OpenFileDialog();
            ope.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (ope.ShowDialog() == DialogResult.Cancel)
                return;

            FileStream stream = new FileStream(ope.FileName, FileMode.Open);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet result = excelReader.AsDataSet();

            DataClasses1DataContext conn = new DataClasses1DataContext();

            Dictionary<string, string> parse = new Dictionary<string, string>();
            Dictionary<string, int> yavl = new Dictionary<string, int>();

            string connectionString1 = @"Data Source=.\SQLEXPRESS;Initial Catalog=КлимРиски_18-12-13;Integrated Security=True";
            string sqlExpression1 = "SELECT  [ИДСубъекта] ,[НазСубъекта] FROM Субъекты_РФ";
            string sqlExpression2 = "SELECT  [Номер_Явления], [Название_Опасного_Явления] FROM Список_Опасных_Явлений";

            using (SqlConnection connection = new SqlConnection(connectionString1))
            {
                
                    SqlCommand command = new SqlCommand(sqlExpression1, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        if (!parse.ContainsKey(reader[1].ToString()))
                        {
                            parse.Add(reader[1].ToString(), reader[0].ToString());
                        }
                        }
                    }
                    
                    SqlCommand command1 = new SqlCommand(sqlExpression2, connection);
                    
                    using (SqlDataReader reader1 = command1.ExecuteReader())
                    {
                        while (reader1.Read())
                        {
                            if (!yavl.ContainsKey(reader1[1].ToString()))
                            {
                                yavl.Add(reader1[1].ToString(), Convert.ToInt32(reader1[0]));
                            }
                        }
                    }
                    
            }


            foreach (DataTable table in result.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    var asd = " ";
                    int asd1 = 0;


                    if (!parse.TryGetValue(dr[7].ToString(), out asd))
                    {
                        asd = "";
                    };
                    
                    if (!yavl.TryGetValue(dr[5].ToString(), out asd1))
                    {
                        asd1 = 0;
                    };
                    
                    Опасные_Явления_test2 addtable = new Опасные_Явления_test2()
                    {

                         Дата_Начала = Convert.ToDateTime(dr[1]),
                         Дата_Окончания = Convert.ToDateTime(dr[2]),
                        КоличествоОЯ = (dr[3] is DBNull) ? 0 : Convert.ToInt32(dr[3]),
                        Заблаговременность = Convert.ToString(dr[4]),

                        Интенсивность_явления = Convert.ToInt32(dr[6]),

                        Дополнение = Convert.ToString(dr[8]),
                        
                        ИДСубъекта = asd.ToString(),
                        
                        Номер_Явления = asd1,

                        Номер = (dr[0] is DBNull) ? 0 : Convert.ToDouble(dr[0])

                    };

                    conn.Опасные_Явления_test2.InsertOnSubmit(addtable);
                }

            }

            

            conn.SubmitChanges();


            
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=КлимРиски_18-12-13;Integrated Security=True";
            string sqlExpression = "INSERT INTO Опасные_Явления SELECT [Номер], [Дата_Начала], [Дата_Окончания], [КоличествоОЯ], [Заблаговременность], [Номер_Явления], [Интенсивность_явления], [ИДСубъекта], [Дополнение] FROM Опасные_Явления_test2; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // добавление
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();

                sqlExpression = "TRUNCATE TABLE [dbo].[Опасные_Явления_test2];";
                command.CommandText = sqlExpression;
                number = command.ExecuteNonQuery();
            }

          

            excelReader.Close();
            stream.Close();

            MessageBox.Show("Загрузка успешно завершена");


        }

        /*
        private void список_опасных_явленийBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.опасные_ЯвленияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }
        */

            
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Список_опасных_явлений". При необходимости она может быть перемещена или удалена.
            this.опасные_ЯвленияTableAdapter.Fill(this.dataSet2.Опасные_Явления);

        }
        

        private void New_row_Click(object sender, EventArgs e)
        {
            опасные_ЯвленияBindingSource.AddNew();
        }

        /*
        private void button4_Click(object sender, EventArgs e)
        {
            список_опасных_явленийBindingSource.EndEdit();
            список_опасных_явленийTableAdapter.Update(dataSet1);
        }
        */

        private void ray1_Click(object sender, EventArgs e)
        {

            string pathStoreProceduresFile1 = @".\all.sql";
            
            string pathStoreProceduresFile_drop = @".\DropCheb.sql";
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=КлимРиски_18-12-13;Integrated Security=True";

            runSqlScriptFile_all(pathStoreProceduresFile_drop, connectionString);
            runSqlScriptFile(pathStoreProceduresFile1, connectionString);
            
            
        }

       

        private bool runSqlScriptFile(string pathStoreProceduresFile, string connectionString)
        {
            
                string script = File.ReadAllText(pathStoreProceduresFile, Encoding.Default);

                // split script on GO command
                System.Collections.Generic.IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                         RegexOptions.Multiline | RegexOptions.IgnoreCase);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (string commandString in commandStrings)
                    {
                        if (commandString.Trim() != "")
                        {
                            using (var command = new SqlCommand(commandString, connection))
                            {

                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (SqlException ex)
                                {
                                    string spError = commandString.Length > 100 ? commandString.Substring(0, 100) + " ...\n..." : commandString;
                                    MessageBox.Show(string.Format("Please check the SqlServer script.\nFile: {0} \nLine: {1} \nError: {2} \nSQL Command: \n{3}", pathStoreProceduresFile, ex.LineNumber, ex.Message, spError), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return false;
                                }

                            }
                        }
                    }
                    connection.Close();
                }
            MessageBox.Show("Районирование успешно выполнено");
            return true;
           
        }

        private bool runSqlScriptFile_all(string pathStoreProceduresFile, string connectionString)
        {

            string script = File.ReadAllText(pathStoreProceduresFile, Encoding.Default);

            // split script on GO command
            System.Collections.Generic.IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        using (var command = new SqlCommand(commandString, connection))
                        {

                            try
                            {
                                command.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                string spError = commandString.Length > 100 ? commandString.Substring(0, 100) + " ...\n..." : commandString;
                                MessageBox.Show(string.Format("Please check the SqlServer script.\nFile: {0} \nLine: {1} \nError: {2} \nSQL Command: \n{3}", pathStoreProceduresFile, ex.LineNumber, ex.Message, spError), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }

                        }
                    }
                }
                connection.Close();
            }
            
            return true;

        }

        private void ray2_Click(object sender, EventArgs e)
        {
            string pathStoreProceduresFile1 = @".\all_soc.sql";

            string pathStoreProceduresFile_drop = @".\DropCheb.sql";
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=КлимРиски_18-12-13;Integrated Security=True";

            runSqlScriptFile_all(pathStoreProceduresFile_drop, connectionString);
            runSqlScriptFile(pathStoreProceduresFile1, connectionString);

        }

        private void Save_row_Click(object sender, EventArgs e)
        {
            опасные_ЯвленияBindingSource.EndEdit();
            опасные_ЯвленияTableAdapter.Update(dataSet2);
        }

        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.Опасные_Явления". При необходимости она может быть перемещена или удалена.
            this.опасные_ЯвленияTableAdapter.Fill(this.dataSet2.Опасные_Явления);

        }
        */
    }
}
       
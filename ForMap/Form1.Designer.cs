namespace ForMap
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label номерLabel;
            System.Windows.Forms.Label дата_НачалаLabel;
            System.Windows.Forms.Label дата_ОкончанияLabel;
            System.Windows.Forms.Label количествоОЯLabel;
            System.Windows.Forms.Label заблаговременностьLabel;
            System.Windows.Forms.Label номер_ЯвленияLabel;
            System.Windows.Forms.Label интенсивность_явленияLabel;
            System.Windows.Forms.Label иДСубъектаLabel;
            System.Windows.Forms.Label дополнениеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.create_map = new System.Windows.Forms.Button();
            this.Import_Data = new System.Windows.Forms.Button();
            this.New_row = new System.Windows.Forms.Button();
            this.Save_row = new System.Windows.Forms.Button();
            this.ray1 = new System.Windows.Forms.Button();
            this.ray2 = new System.Windows.Forms.Button();
            this.dataSet2 = new ForMap.DataSet2();
            this.опасные_ЯвленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.опасные_ЯвленияTableAdapter = new ForMap.DataSet2TableAdapters.Опасные_ЯвленияTableAdapter();
            this.tableAdapterManager = new ForMap.DataSet2TableAdapters.TableAdapterManager();
            this.опасные_ЯвленияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерTextBox = new System.Windows.Forms.TextBox();
            this.дата_НачалаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_ОкончанияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.количествоОЯTextBox = new System.Windows.Forms.TextBox();
            this.заблаговременностьTextBox = new System.Windows.Forms.TextBox();
            this.номер_ЯвленияTextBox = new System.Windows.Forms.TextBox();
            this.интенсивность_явленияTextBox = new System.Windows.Forms.TextBox();
            this.иДСубъектаTextBox = new System.Windows.Forms.TextBox();
            this.дополнениеTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            номерLabel = new System.Windows.Forms.Label();
            дата_НачалаLabel = new System.Windows.Forms.Label();
            дата_ОкончанияLabel = new System.Windows.Forms.Label();
            количествоОЯLabel = new System.Windows.Forms.Label();
            заблаговременностьLabel = new System.Windows.Forms.Label();
            номер_ЯвленияLabel = new System.Windows.Forms.Label();
            интенсивность_явленияLabel = new System.Windows.Forms.Label();
            иДСубъектаLabel = new System.Windows.Forms.Label();
            дополнениеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.опасные_ЯвленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.опасные_ЯвленияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(725, 429);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(181, 47);
            label1.TabIndex = 26;
            label1.Text = "Районирование по индексу погодно-климатических рисков для экономик субъектов РФ ";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(725, 505);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(171, 55);
            label2.TabIndex = 27;
            label2.Text = "Районирование по индексу социального погодно-климатического риска";
            // 
            // номерLabel
            // 
            номерLabel.AutoSize = true;
            номерLabel.Location = new System.Drawing.Point(27, 428);
            номерLabel.Name = "номерLabel";
            номерLabel.Size = new System.Drawing.Size(44, 13);
            номерLabel.TabIndex = 27;
            номерLabel.Text = "Номер:";
            // 
            // дата_НачалаLabel
            // 
            дата_НачалаLabel.AutoSize = true;
            дата_НачалаLabel.Location = new System.Drawing.Point(27, 455);
            дата_НачалаLabel.Name = "дата_НачалаLabel";
            дата_НачалаLabel.Size = new System.Drawing.Size(76, 13);
            дата_НачалаLabel.TabIndex = 29;
            дата_НачалаLabel.Text = "Дата Начала:";
            // 
            // дата_ОкончанияLabel
            // 
            дата_ОкончанияLabel.AutoSize = true;
            дата_ОкончанияLabel.Location = new System.Drawing.Point(27, 481);
            дата_ОкончанияLabel.Name = "дата_ОкончанияLabel";
            дата_ОкончанияLabel.Size = new System.Drawing.Size(94, 13);
            дата_ОкончанияLabel.TabIndex = 31;
            дата_ОкончанияLabel.Text = "Дата Окончания:";
            // 
            // количествоОЯLabel
            // 
            количествоОЯLabel.AutoSize = true;
            количествоОЯLabel.Location = new System.Drawing.Point(27, 506);
            количествоОЯLabel.Name = "количествоОЯLabel";
            количествоОЯLabel.Size = new System.Drawing.Size(88, 13);
            количествоОЯLabel.TabIndex = 33;
            количествоОЯLabel.Text = "Количество ОЯ:";
            // 
            // заблаговременностьLabel
            // 
            заблаговременностьLabel.AutoSize = true;
            заблаговременностьLabel.Location = new System.Drawing.Point(27, 532);
            заблаговременностьLabel.Name = "заблаговременностьLabel";
            заблаговременностьLabel.Size = new System.Drawing.Size(119, 13);
            заблаговременностьLabel.TabIndex = 35;
            заблаговременностьLabel.Text = "Заблаговременность:";
            // 
            // номер_ЯвленияLabel
            // 
            номер_ЯвленияLabel.AutoSize = true;
            номер_ЯвленияLabel.Location = new System.Drawing.Point(27, 558);
            номер_ЯвленияLabel.Name = "номер_ЯвленияLabel";
            номер_ЯвленияLabel.Size = new System.Drawing.Size(91, 13);
            номер_ЯвленияLabel.TabIndex = 37;
            номер_ЯвленияLabel.Text = "Номер Явления:";
            // 
            // интенсивность_явленияLabel
            // 
            интенсивность_явленияLabel.AutoSize = true;
            интенсивность_явленияLabel.Location = new System.Drawing.Point(27, 584);
            интенсивность_явленияLabel.Name = "интенсивность_явленияLabel";
            интенсивность_явленияLabel.Size = new System.Drawing.Size(133, 13);
            интенсивность_явленияLabel.TabIndex = 39;
            интенсивность_явленияLabel.Text = "Интенсивность явления:";
            // 
            // иДСубъектаLabel
            // 
            иДСубъектаLabel.AutoSize = true;
            иДСубъектаLabel.Location = new System.Drawing.Point(27, 610);
            иДСубъектаLabel.Name = "иДСубъектаLabel";
            иДСубъектаLabel.Size = new System.Drawing.Size(75, 13);
            иДСубъектаLabel.TabIndex = 41;
            иДСубъектаLabel.Text = "ИДСубъекта:";
            // 
            // дополнениеLabel
            // 
            дополнениеLabel.AutoSize = true;
            дополнениеLabel.Location = new System.Drawing.Point(27, 636);
            дополнениеLabel.Name = "дополнениеLabel";
            дополнениеLabel.Size = new System.Drawing.Size(73, 13);
            дополнениеLabel.TabIndex = 43;
            дополнениеLabel.Text = "Дополнение:";
            // 
            // create_map
            // 
            this.create_map.Location = new System.Drawing.Point(810, 600);
            this.create_map.Name = "create_map";
            this.create_map.Size = new System.Drawing.Size(131, 49);
            this.create_map.TabIndex = 0;
            this.create_map.Text = "Создать карту";
            this.create_map.UseVisualStyleBackColor = true;
            this.create_map.Click += new System.EventHandler(this.create_map_Click);
            // 
            // Import_Data
            // 
            this.Import_Data.Location = new System.Drawing.Point(505, 506);
            this.Import_Data.Name = "Import_Data";
            this.Import_Data.Size = new System.Drawing.Size(118, 23);
            this.Import_Data.TabIndex = 1;
            this.Import_Data.Text = "Импорт Данных";
            this.Import_Data.UseVisualStyleBackColor = true;
            this.Import_Data.Click += new System.EventHandler(this.Import_Data_Click);
            // 
            // New_row
            // 
            this.New_row.Location = new System.Drawing.Point(391, 506);
            this.New_row.Name = "New_row";
            this.New_row.Size = new System.Drawing.Size(96, 23);
            this.New_row.TabIndex = 22;
            this.New_row.Text = "Новая запись";
            this.New_row.UseVisualStyleBackColor = true;
            this.New_row.Click += new System.EventHandler(this.New_row_Click);
            // 
            // Save_row
            // 
            this.Save_row.Location = new System.Drawing.Point(391, 542);
            this.Save_row.Name = "Save_row";
            this.Save_row.Size = new System.Drawing.Size(96, 23);
            this.Save_row.TabIndex = 23;
            this.Save_row.Text = "Сохранить";
            this.Save_row.UseVisualStyleBackColor = true;
            this.Save_row.Click += new System.EventHandler(this.Save_row_Click);
            // 
            // ray1
            // 
            this.ray1.Location = new System.Drawing.Point(922, 432);
            this.ray1.Name = "ray1";
            this.ray1.Size = new System.Drawing.Size(105, 38);
            this.ray1.TabIndex = 24;
            this.ray1.Text = "Выполнить районирование";
            this.ray1.UseVisualStyleBackColor = true;
            this.ray1.Click += new System.EventHandler(this.ray1_Click);
            // 
            // ray2
            // 
            this.ray2.Location = new System.Drawing.Point(922, 505);
            this.ray2.Name = "ray2";
            this.ray2.Size = new System.Drawing.Size(105, 38);
            this.ray2.TabIndex = 25;
            this.ray2.Text = "Выполнить районирование";
            this.ray2.UseVisualStyleBackColor = true;
            this.ray2.Click += new System.EventHandler(this.ray2_Click);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // опасные_ЯвленияBindingSource
            // 
            this.опасные_ЯвленияBindingSource.DataMember = "Опасные_Явления";
            this.опасные_ЯвленияBindingSource.DataSource = this.dataSet2;
            // 
            // опасные_ЯвленияTableAdapter
            // 
            this.опасные_ЯвленияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ForMap.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВРПTableAdapter = null;
            this.tableAdapterManager.Опасные_Явления_В_ОтрасляхTableAdapter = null;
            this.tableAdapterManager.Опасные_ЯвленияTableAdapter = null;
            this.tableAdapterManager.Разделы_ЭкономикиTableAdapter = null;
            this.tableAdapterManager.Список_Опасных_ЯвленийTableAdapter = null;
            this.tableAdapterManager.Субъекты_РФTableAdapter = null;
            this.tableAdapterManager.Субъекты_СведенияTableAdapter = null;
            this.tableAdapterManager.Субъекты_соответствиеОЯTableAdapter = null;
            this.tableAdapterManager.ФакторыСоцРискаTableAdapter = null;
            this.tableAdapterManager.ФакторыСоцРискаЗначенияTableAdapter = null;
            // 
            // опасные_ЯвленияDataGridView
            // 
            this.опасные_ЯвленияDataGridView.AutoGenerateColumns = false;
            this.опасные_ЯвленияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.опасные_ЯвленияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.опасные_ЯвленияDataGridView.DataSource = this.опасные_ЯвленияBindingSource;
            this.опасные_ЯвленияDataGridView.Location = new System.Drawing.Point(4, 28);
            this.опасные_ЯвленияDataGridView.Name = "опасные_ЯвленияDataGridView";
            this.опасные_ЯвленияDataGridView.Size = new System.Drawing.Size(1047, 362);
            this.опасные_ЯвленияDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn10.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Дата_Начала";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дата_Начала";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Дата_Окончания";
            this.dataGridViewTextBoxColumn12.HeaderText = "Дата_Окончания";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "КоличествоОЯ";
            this.dataGridViewTextBoxColumn13.HeaderText = "КоличествоОЯ";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Заблаговременность";
            this.dataGridViewTextBoxColumn14.HeaderText = "Заблаговременность";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Номер_Явления";
            this.dataGridViewTextBoxColumn15.HeaderText = "Номер_Явления";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Интенсивность_явления";
            this.dataGridViewTextBoxColumn16.HeaderText = "Интенсивность_явления";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ИДСубъекта";
            this.dataGridViewTextBoxColumn17.HeaderText = "ИДСубъекта";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Дополнение";
            this.dataGridViewTextBoxColumn18.HeaderText = "Дополнение";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // номерTextBox
            // 
            this.номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.опасные_ЯвленияBindingSource, "Номер", true));
            this.номерTextBox.Location = new System.Drawing.Point(166, 425);
            this.номерTextBox.Name = "номерTextBox";
            this.номерTextBox.Size = new System.Drawing.Size(200, 20);
            this.номерTextBox.TabIndex = 28;
            // 
            // дата_НачалаDateTimePicker
            // 
            this.дата_НачалаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.опасные_ЯвленияBindingSource, "Дата_Начала", true));
            this.дата_НачалаDateTimePicker.Location = new System.Drawing.Point(166, 451);
            this.дата_НачалаDateTimePicker.Name = "дата_НачалаDateTimePicker";
            this.дата_НачалаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_НачалаDateTimePicker.TabIndex = 30;
            // 
            // дата_ОкончанияDateTimePicker
            // 
            this.дата_ОкончанияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.опасные_ЯвленияBindingSource, "Дата_Окончания", true));
            this.дата_ОкончанияDateTimePicker.Location = new System.Drawing.Point(166, 477);
            this.дата_ОкончанияDateTimePicker.Name = "дата_ОкончанияDateTimePicker";
            this.дата_ОкончанияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_ОкончанияDateTimePicker.TabIndex = 32;
            // 
            // количествоОЯTextBox
            // 
            this.количествоОЯTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.опасные_ЯвленияBindingSource, "КоличествоОЯ", true));
            this.количествоОЯTextBox.Location = new System.Drawing.Point(166, 503);
            this.количествоОЯTextBox.Name = "количествоОЯTextBox";
            this.количествоОЯTextBox.Size = new System.Drawing.Size(200, 20);
            this.количествоОЯTextBox.TabIndex = 34;
            // 
            // заблаговременностьTextBox
            // 
            this.заблаговременностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.опасные_ЯвленияBindingSource, "Заблаговременность", true));
            this.заблаговременностьTextBox.Location = new System.Drawing.Point(166, 529);
            this.заблаговременностьTextBox.Name = "заблаговременностьTextBox";
            this.заблаговременностьTextBox.Size = new System.Drawing.Size(200, 20);
            this.заблаговременностьTextBox.TabIndex = 36;
            // 
            // номер_ЯвленияTextBox
            // 
            this.номер_ЯвленияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.опасные_ЯвленияBindingSource, "Номер_Явления", true));
            this.номер_ЯвленияTextBox.Location = new System.Drawing.Point(166, 555);
            this.номер_ЯвленияTextBox.Name = "номер_ЯвленияTextBox";
            this.номер_ЯвленияTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_ЯвленияTextBox.TabIndex = 38;
            // 
            // интенсивность_явленияTextBox
            // 
            this.интенсивность_явленияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.опасные_ЯвленияBindingSource, "Интенсивность_явления", true));
            this.интенсивность_явленияTextBox.Location = new System.Drawing.Point(166, 581);
            this.интенсивность_явленияTextBox.Name = "интенсивность_явленияTextBox";
            this.интенсивность_явленияTextBox.Size = new System.Drawing.Size(200, 20);
            this.интенсивность_явленияTextBox.TabIndex = 40;
            // 
            // иДСубъектаTextBox
            // 
            this.иДСубъектаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.опасные_ЯвленияBindingSource, "ИДСубъекта", true));
            this.иДСубъектаTextBox.Location = new System.Drawing.Point(166, 607);
            this.иДСубъектаTextBox.Name = "иДСубъектаTextBox";
            this.иДСубъектаTextBox.Size = new System.Drawing.Size(200, 20);
            this.иДСубъектаTextBox.TabIndex = 42;
            // 
            // дополнениеTextBox
            // 
            this.дополнениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.опасные_ЯвленияBindingSource, "Дополнение", true));
            this.дополнениеTextBox.Location = new System.Drawing.Point(166, 633);
            this.дополнениеTextBox.Name = "дополнениеTextBox";
            this.дополнениеTextBox.Size = new System.Drawing.Size(200, 20);
            this.дополнениеTextBox.TabIndex = 44;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(100, 23);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.опасные_ЯвленияBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(1063, 25);
            this.bindingNavigator2.TabIndex = 45;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 689);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(номерLabel);
            this.Controls.Add(this.номерTextBox);
            this.Controls.Add(дата_НачалаLabel);
            this.Controls.Add(this.дата_НачалаDateTimePicker);
            this.Controls.Add(дата_ОкончанияLabel);
            this.Controls.Add(this.дата_ОкончанияDateTimePicker);
            this.Controls.Add(количествоОЯLabel);
            this.Controls.Add(this.количествоОЯTextBox);
            this.Controls.Add(заблаговременностьLabel);
            this.Controls.Add(this.заблаговременностьTextBox);
            this.Controls.Add(номер_ЯвленияLabel);
            this.Controls.Add(this.номер_ЯвленияTextBox);
            this.Controls.Add(интенсивность_явленияLabel);
            this.Controls.Add(this.интенсивность_явленияTextBox);
            this.Controls.Add(иДСубъектаLabel);
            this.Controls.Add(this.иДСубъектаTextBox);
            this.Controls.Add(дополнениеLabel);
            this.Controls.Add(this.дополнениеTextBox);
            this.Controls.Add(this.опасные_ЯвленияDataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.ray2);
            this.Controls.Add(this.ray1);
            this.Controls.Add(this.Save_row);
            this.Controls.Add(this.New_row);
            this.Controls.Add(this.Import_Data);
            this.Controls.Add(this.create_map);
            this.Name = "Form1";
            this.Text = "Map creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.опасные_ЯвленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.опасные_ЯвленияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_map;
        private System.Windows.Forms.Button Import_Data;
        private System.Windows.Forms.Button New_row;
        private System.Windows.Forms.Button Save_row;
        private System.Windows.Forms.Button ray1;
        private System.Windows.Forms.Button ray2;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource опасные_ЯвленияBindingSource;
        private DataSet2TableAdapters.Опасные_ЯвленияTableAdapter опасные_ЯвленияTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView опасные_ЯвленияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.TextBox номерTextBox;
        private System.Windows.Forms.DateTimePicker дата_НачалаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_ОкончанияDateTimePicker;
        private System.Windows.Forms.TextBox количествоОЯTextBox;
        private System.Windows.Forms.TextBox заблаговременностьTextBox;
        private System.Windows.Forms.TextBox номер_ЯвленияTextBox;
        private System.Windows.Forms.TextBox интенсивность_явленияTextBox;
        private System.Windows.Forms.TextBox иДСубъектаTextBox;
        private System.Windows.Forms.TextBox дополнениеTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
    }
}


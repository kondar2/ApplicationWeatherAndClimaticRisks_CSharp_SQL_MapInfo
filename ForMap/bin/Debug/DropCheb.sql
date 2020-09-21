/*
DROP TABLE [dbo].[Pemp]
DROP TABLE [dbo].[Pemp1]
DROP TABLE [dbo].[Pemp2]
DROP TABLE [dbo].[Pemp3]
DROP TABLE [dbo].[Pemp4]
DROP TABLE [dbo].[Pemp5]
DROP PROCEDURE [dbo].[DIFFcurs]
DROP PROCEDURE [dbo].[DIFFcurs1]
DROP PROCEDURE [dbo].[DIFFcurs2]
DROP PROCEDURE [dbo].[DIFFcurs3]
*/

if object_id('Pemp', 'Table') is not null drop Table Pemp
if object_id('Pemp1', 'Table') is not null drop Table Pemp1
if object_id('Pemp2', 'Table') is not null drop Table Pemp2
if object_id('Pemp3', 'Table') is not null drop Table Pemp3
if object_id('Pemp4', 'Table') is not null drop Table Pemp4
if object_id('Pemp5', 'Table') is not null drop Table Pemp5
if object_id('DIFFcurs', 'Procedure') is not null drop Procedure DIFFcurs
if object_id('DIFFcurs1', 'Procedure') is not null drop Procedure DIFFcurs1
if object_id('DIFFcurs2', 'Procedure') is not null drop Procedure DIFFcurs2
if object_id('DIFFcurs3', 'Procedure') is not null drop Procedure DIFFcurs3
if object_id('TestProc', 'Procedure') is not null drop Procedure TestProc
if object_id('TestProc2', 'Procedure') is not null drop Procedure TestProc2

if object_id('Pemp_main', 'Table') is not null drop Table Pemp_main
if object_id('Pempm1', 'Table') is not null drop Table Pempm1
if object_id('Soc_table', 'Table') is not null drop Table Soc_table


if object_id('Cheb_PK', 'Table') is not null drop Table Cheb_PK
if object_id('Pemp_Result', 'Table') is not null drop Table Pemp_Result
if object_id('Pempm', 'Table') is not null drop Table Pempm

if object_id('Pemp33', 'Table') is not null drop Table Pemp33
if object_id('Pempm3', 'Table') is not null drop Table Pempm3
if object_id('Pempm5', 'Table') is not null drop Table Pempm5
if object_id('Pempm7', 'Table') is not null drop Table Pempm7
if object_id('Pempm9', 'Table') is not null drop Table Pempm9
if object_id('Pempm11', 'Table') is not null drop Table Pempm11

if object_id('Create_Pemp', 'Procedure') is not null drop Procedure Create_Pemp
if object_id('Calc_F1', 'Procedure') is not null drop Procedure Calc_F1
if object_id('Cheb_alg', 'Procedure') is not null drop Procedure Cheb_alg
if object_id('Cheb_alg1', 'Procedure') is not null drop Procedure Cheb_alg1
if object_id('Cheb_Delitel', 'Procedure') is not null drop Procedure Cheb_Delitel
if object_id('Cheb_Summ_Group', 'Procedure') is not null drop Procedure Cheb_Summ_Group
if object_id('Conut_el_groups', 'Procedure') is not null drop Procedure Conut_el_groups
if object_id('For_map', 'Procedure') is not null drop Procedure For_map
if object_id('For_map1', 'Procedure') is not null drop Procedure For_map1
if object_id('For_map2', 'Procedure') is not null drop Procedure For_map2
if object_id('Numeration', 'Procedure') is not null drop Procedure Numeration
if object_id('Vich_F2', 'Procedure') is not null drop Procedure Vich_F2
if object_id('Vich_Result', 'Procedure') is not null drop Procedure Vich_Result

/*
DROP PROCEDURE IF EXISTS [dbo].[Calc_F1]
DROP PROCEDURE IF EXISTS [dbo].[Cheb_alg]
DROP PROCEDURE IF EXISTS [dbo].[Cheb_alg1]

DROP PROCEDURE IF EXISTS [dbo].[Cheb_Delitel]

DROP PROCEDURE IF EXISTS [dbo].[Cheb_Summ_Group]

DROP PROCEDURE IF EXISTS [dbo].[Conut_el_groups]

DROP PROCEDURE IF EXISTS [dbo].[For_map]
DROP PROCEDURE IF EXISTS [dbo].[For_map1]
DROP PROCEDURE IF EXISTS [dbo].[For_map2]

DROP PROCEDURE IF EXISTS [dbo].[Numeration]
DROP PROCEDURE IF EXISTS [dbo].[Vich_F2]
DROP PROCEDURE IF EXISTS [dbo].[Vich_Result]
*/
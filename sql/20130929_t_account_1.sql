/*
   2013年9月29日17:36:24
   User: sa
   Server: R400
   Database: haimen
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
EXECUTE sp_rename N'dbo.t_account.applicant', N'Tmp_maker_5', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.t_account.Tmp_maker_5', N'maker', 'COLUMN' 
GO
COMMIT
select Has_Perms_By_Name(N'dbo.t_account', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.t_account', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.t_account', 'Object', 'CONTROL') as Contr_Per 
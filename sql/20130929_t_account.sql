/*
   2013年9月29日10:50:37
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
ALTER TABLE dbo.t_account ADD
	project_id bigint NULL
GO
COMMIT
select Has_Perms_By_Name(N'dbo.t_account', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.t_account', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.t_account', 'Object', 'CONTROL') as Contr_Per 
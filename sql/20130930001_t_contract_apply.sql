/*
   2013年9月30日8:49:28
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
CREATE TABLE dbo.t_contract_apply
	(
	id bigint NOT NULL IDENTITY (1, 1),
	contract_id bigint NOT NULL,
	apply_date datetime NOT NULL,
	money decimal(18, 4) NOT NULL,
	memo nvarchar(250) NOT NULL,
	status bigint NOT NULL,
	created_date datetime NOT NULL,
	updated_date datetime NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.t_contract_apply ADD CONSTRAINT
	PK_t_contract_apply PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.t_contract_apply', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.t_contract_apply', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.t_contract_apply', 'Object', 'CONTROL') as Contr_Per 
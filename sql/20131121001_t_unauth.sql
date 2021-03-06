USE [haimen]
GO
/****** Object:  Table [dbo].[t_unauth]    Script Date: 11/21/2013 10:07:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_unauth](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[company_id] [bigint] NOT NULL,
	[companydetail_id] [bigint] NOT NULL,
	[input] [nvarchar](1) COLLATE Chinese_PRC_CI_AS NULL,
	[output] [nvarchar](1) COLLATE Chinese_PRC_CI_AS NULL,
	[money] [decimal](18, 2) NOT NULL,
	[memo] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[created_date] [datetime] NOT NULL,
	[updated_date] [datetime] NOT NULL,
	[deleted] [bigint] NULL,
	[signed_date] [datetime] NOT NULL,
 CONSTRAINT [PK_t_unauth] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

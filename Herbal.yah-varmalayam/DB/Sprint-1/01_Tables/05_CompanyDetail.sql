
/****** Object:  Table [dbo].[CompanyDetail]    Script Date: 10/10/2020 16:28:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](300) NULL,
	[AuthorisedDealer] [nvarchar](300) NULL,
	[PrimaryContactNumber] [bigint] NOT NULL,
	[SecondaryContactNumber] [bigint] NULL,
	[PrimaryEmailAddress] [nvarchar](150) NOT NULL,
	[WebSite] [nvarchar](150) NULL,
	[CompanyAddress] [nvarchar](max) NOT NULL,
	[GSTINNumber] [nvarchar](200) NULL,
	[GSTINCertifiedBy] [nvarchar](200) NULL,
	[Note] [nvarchar](200) NULL,
	[RevisedNote] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CompanyDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[CompanyDetail]  WITH CHECK ADD  CONSTRAINT [FK_CompanyDetail_AppUser] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[CompanyDetail] CHECK CONSTRAINT [FK_CompanyDetail_AppUser]
GO

ALTER TABLE [dbo].[CompanyDetail]  WITH CHECK ADD  CONSTRAINT [FK_CompanyDetail_AppUser1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[CompanyDetail] CHECK CONSTRAINT [FK_CompanyDetail_AppUser1]
GO



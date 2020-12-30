
/****** Object:  Table [dbo].[PaymentType]    Script Date: 10/11/2020 12:22:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PaymentType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PaymentTypeName] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PaymentType]  WITH CHECK ADD  CONSTRAINT [FK_PaymentType_AppUser] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[PaymentType] CHECK CONSTRAINT [FK_PaymentType_AppUser]
GO

ALTER TABLE [dbo].[PaymentType]  WITH CHECK ADD  CONSTRAINT [FK_PaymentType_AppUser1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[PaymentType] CHECK CONSTRAINT [FK_PaymentType_AppUser1]
GO




/****** Object:  Table [dbo].[PurchaseHeader]    Script Date: 10/10/2020 23:09:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseHeader](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseCode] [nvarchar](50) NOT NULL,
	[ClientName] [nvarchar](150) NULL,
	[ClientMobileNumber] [bigint] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[PurchaseDate] [datetime] NOT NULL,
	[TotalGrossAmount] [decimal](18, 2) NOT NULL,
	[TotalDiscount] [decimal](18, 2) NOT NULL,
	[TotalTaxAmount] [decimal](18, 2) NULL,
	[TotalNetAmount] [decimal](18, 2) NOT NULL,
	[AmountPaid] [decimal](18, 2) NOT NULL,
	[DueAmount] [decimal](18, 2) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PurchaseHeader] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PurchaseHeader]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseHeader_AppUser] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[PurchaseHeader] CHECK CONSTRAINT [FK_PurchaseHeader_AppUser]
GO

ALTER TABLE [dbo].[PurchaseHeader]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseHeader_AppUser1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[PurchaseHeader] CHECK CONSTRAINT [FK_PurchaseHeader_AppUser1]
GO



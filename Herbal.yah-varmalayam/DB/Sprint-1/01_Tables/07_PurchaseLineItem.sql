﻿

/****** Object:  Table [dbo].[PurchaseLineItem]    Script Date: 10/10/2020 22:49:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseLineItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseLineItemCode] [nvarchar](50) NULL,
	[PurchaseId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[PurchaseAmount] [decimal](18, 2) NOT NULL,
	[Discount] [decimal](18, 2) NULL,
	[GrossAmount] [decimal](18, 2) NOT NULL,
	[CGST] [decimal](18, 2) NULL,
	[SGST] [decimal](18, 2) NULL,
	[IGST] [decimal](18, 2) NULL,
	[TotalTax] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NOT NULL,
	[SellingPrice] [decimal](18, 2) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PurchaseLineItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PurchaseLineItem]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseLineItem_PurchaseHeader1] FOREIGN KEY([PurchaseId])
REFERENCES [dbo].[PurchaseHeader] ([Id])
GO

ALTER TABLE [dbo].[PurchaseLineItem] CHECK CONSTRAINT [FK_PurchaseLineItem_PurchaseHeader1]
GO


ALTER TABLE [dbo].[PurchaseLineItem]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseLineItems_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[PurchaseLineItem] CHECK CONSTRAINT [FK_PurchaseLineItems_Product]
GO

ALTER TABLE [dbo].[PurchaseLineItem]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseLineItem_AppUser] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[PurchaseLineItem] CHECK CONSTRAINT [FK_PurchaseLineItem_AppUser]
GO

ALTER TABLE [dbo].[PurchaseLineItem]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseLineItem_AppUser1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[PurchaseLineItem] CHECK CONSTRAINT [FK_PurchaseLineItem_AppUser1]
GO
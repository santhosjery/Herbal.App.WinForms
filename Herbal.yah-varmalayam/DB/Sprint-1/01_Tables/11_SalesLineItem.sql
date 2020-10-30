

/****** Object:  Table [dbo].[SalesLineItem]    Script Date: 10/30/2020 14:27:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesLineItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleseLineItemCode] [nvarchar](50) NULL,
	[SalesId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[SalesAmount] [decimal](18, 2) NOT NULL,
	[Discount] [decimal](18, 2) NULL,
	[GrossAmount] [decimal](18, 2) NOT NULL,
	[CGST] [decimal](18, 2) NULL,
	[SGST] [decimal](18, 2) NULL,
	[IGST] [decimal](18, 2) NULL,
	[TotalTax] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_SalesLineItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SalesLineItem]  WITH CHECK ADD  CONSTRAINT [FK_SalesLineItem_AppUser] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[SalesLineItem] CHECK CONSTRAINT [FK_SalesLineItem_AppUser]
GO

ALTER TABLE [dbo].[SalesLineItem]  WITH CHECK ADD  CONSTRAINT [FK_SalesLineItem_AppUser1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[SalesLineItem] CHECK CONSTRAINT [FK_SalesLineItem_AppUser1]
GO

ALTER TABLE [dbo].[SalesLineItem]  WITH CHECK ADD  CONSTRAINT [FK_SalesLineItem_SalesHeader] FOREIGN KEY([SalesId])
REFERENCES [dbo].[SalesHeader] ([Id])
GO

ALTER TABLE [dbo].[SalesLineItem] CHECK CONSTRAINT [FK_SalesLineItem_SalesHeader]
GO

ALTER TABLE [dbo].[SalesLineItem]  WITH CHECK ADD  CONSTRAINT [FK_SalesLineItems_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO

ALTER TABLE [dbo].[SalesLineItem] CHECK CONSTRAINT [FK_SalesLineItems_Product]
GO



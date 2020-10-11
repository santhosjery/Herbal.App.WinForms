
/****** Object:  Table [dbo].[StockDetail]    Script Date: 10/11/2020 14:03:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StockDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[TotalPurchaseQuantity] [decimal](18, 2) NULL,
	[TotalSalesQuantity] [decimal](18, 2) NULL,
	[AvilableQuantity] [decimal](18, 2) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_StockDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[StockDetail]  WITH CHECK ADD  CONSTRAINT [FK_StockDetail_AppUser] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[StockDetail] CHECK CONSTRAINT [FK_StockDetail_AppUser]
GO

ALTER TABLE [dbo].[StockDetail]  WITH CHECK ADD  CONSTRAINT [FK_StockDetail_AppUser1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[StockDetail] CHECK CONSTRAINT [FK_StockDetail_AppUser1]
GO

ALTER TABLE [dbo].[StockDetail]  WITH CHECK ADD  CONSTRAINT [FK_StockDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO

ALTER TABLE [dbo].[StockDetail] CHECK CONSTRAINT [FK_StockDetail_Product]
GO




/****** Object:  Table [dbo].[SalesHeader]    Script Date: 10/30/2020 14:12:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SalesHeader](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SalesCode] [nvarchar](50) NOT NULL,
	[CustomerName] [nvarchar](150) NULL,
	[CustomerMobileNumber] [bigint] NULL,
	[PaymentTypeId] [int] NULL,
	[SalesDate] [datetime] NOT NULL,
	[TotalSalesAmount] [decimal](18, 2) NOT NULL,
	[TotalDiscount] [decimal](18, 2) NOT NULL,
	[TotalGrossAmount] [decimal](18, 2) NOT NULL,
	[TotalTaxAmount] [decimal](18, 2) NULL,
	[TotalNetAmount] [decimal](18, 2) NOT NULL,
	[AmountPaid] [decimal](18, 2) NOT NULL,
	[DueAmount] [decimal](18, 2) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_SalesHeader] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SalesHeader]  WITH CHECK ADD  CONSTRAINT [FK_SalesHeader_AppUser] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[SalesHeader] CHECK CONSTRAINT [FK_SalesHeader_AppUser]
GO

ALTER TABLE [dbo].[SalesHeader]  WITH CHECK ADD  CONSTRAINT [FK_SalesHeader_AppUser1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[SalesHeader] CHECK CONSTRAINT [FK_SalesHeader_AppUser1]
GO

ALTER TABLE [dbo].[SalesHeader]  WITH CHECK ADD  CONSTRAINT [FK_SalesHeader_PaymentType] FOREIGN KEY([PaymentTypeId])
REFERENCES [dbo].[PaymentType] ([Id])
GO

ALTER TABLE [dbo].[SalesHeader] CHECK CONSTRAINT [FK_SalesHeader_PaymentType]
GO



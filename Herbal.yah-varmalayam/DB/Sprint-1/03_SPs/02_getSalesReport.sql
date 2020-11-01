
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Santhosh N
-- Create date: 01/11/2020
-- Description:	To bringing the values for sales report
-- =============================================
--EXEC getSalesReport
CREATE PROCEDURE [getSalesReport]
	@SalesCode nvarchar(50) = null,
	@SalesId int = null,
	@StartDate datetime = null,
	@EndDate datetime = null,
	@ProductId int =null
AS
BEGIN
	SET NOCOUNT ON;

	If(isnull(@StartDate, '') = '')
	Begin
		Select @StartDate = min(ph.SalesDate) from SalesHeader as ph
	End

	If(isnull(@EndDate, '') = '')
	Begin
		Select @EndDate = max(ph.SalesDate) from SalesHeader as ph
	End

	Set @SalesCode = IIF(Isnull(@SalesCode,'') = '','',@SalesCode);

	Declare @tempSalesList Table(
		[SalesId] int NOT NULL,
		[SalesCode] [nvarchar](50) NOT NULL,
		[CustomerName] [nvarchar](150) NULL,
		[CustomerMobileNumber] [bigint] NULL,
		[ProductId] [int] NOT NULL,
		[ProductName] [nvarchar](150) NULL,
		[ScaleId] [int] NOT NULL,
		[ScaleName] [nvarchar](50) NULL,
		[PaymentTypeId] [int] NULL,
		[PaymentTypeName] [nvarchar](50) NULL,
		[SalesDate] [datetime] NOT NULL,
		[Quantity] [decimal](18, 2) NOT NULL,
		[SalesAmount] [decimal](18, 2) NOT NULL,
		[Discount] [decimal](18, 2) NULL,
		[GrossAmount] [decimal](18, 2) NOT NULL,
		[CGST] [decimal](18, 2) NULL,
		[SGST] [decimal](18, 2) NULL,
		[IGST] [decimal](18, 2) NULL,
		[TotalTax] [decimal](18, 2) NULL,
		[NetAmount] [decimal](18, 2) NOT NULL
	);

	Insert into @tempSalesList
	Select 
		ph.Id,
		ph.SalesCode,
		ph.CustomerName,
		ph.CustomerMobileNumber,
		pr.Id,
		pr.ProductName,
		scl.Id,
		scl.ScaleName,
		ph.PaymentTypeId,
		pt.PaymentTypeName,
		ph.SalesDate,
		pli.Quantity,
		pli.SalesAmount,
		pli.Discount,
		pli.GrossAmount,
		pli.CGST,
		pli.SGST,
		pli.IGST,
		pli.TotalTax,
		pli.NetAmount
	  from SalesHeader as ph
	Join SalesLineItem as pli on ph.Id = pli.SalesId
	Join Product as pr on pr.Id = pli.ProductId
	Join Scale as scl on scl.Id = pr.ScaleId
	Left Join PaymentType as pt on pt.Id = ph.PaymentTypeId
	Where (ph.SalesDate >= @StartDate and ph.SalesDate <= @EndDate)
		  and (@SalesCode = '' or ph.SalesCode = @SalesCode)
		  and (@SalesId is null or ph.Id = @SalesId)
		  and (@ProductId is null or pli.ProductId = @ProductId)
	Order By ph.Id Desc

	Select * from @tempSalesList;

END
GO

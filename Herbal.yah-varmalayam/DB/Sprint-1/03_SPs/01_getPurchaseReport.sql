
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Santhosh N
-- Create date: 31/10/2020
-- Description:	To bringing the values for purchase report
-- =============================================
--EXEC getPurchaseReport
CREATE PROCEDURE [getPurchaseReport]
	@PurchaseCode nvarchar(50) = null,
	@PurchaseId int = null,
	@StartDate datetime = null,
	@EndDate datetime = null,
	@ProductId int =null
AS
BEGIN
	SET NOCOUNT ON;

	If(isnull(@StartDate, '') = '')
	Begin
		Select @StartDate = min(ph.PurchaseDate) from PurchaseHeader as ph
	End

	If(isnull(@EndDate, '') = '')
	Begin
		Select @EndDate = max(ph.PurchaseDate) from PurchaseHeader as ph
	End

	Set @PurchaseCode = IIF(Isnull(@PurchaseCode,'') = '','',@PurchaseCode);

	Declare @tempPurchaseList Table(
		[PurchaseId] int NOT NULL,
		[PurchaseCode] [nvarchar](50) NOT NULL,
		[ClientName] [nvarchar](150) NULL,
		[ClientMobileNumber] [bigint] NULL,
		[PaymentTypeId] [int] NULL,
		[PaymentTypeName] [nvarchar](50) NULL,
		[PurchaseDate] [datetime] NOT NULL,
		[Quantity] [decimal](18, 2) NOT NULL,
		[PurchaseAmount] [decimal](18, 2) NOT NULL,
		[Discount] [decimal](18, 2) NULL,
		[GrossAmount] [decimal](18, 2) NOT NULL,
		[CGST] [decimal](18, 2) NULL,
		[SGST] [decimal](18, 2) NULL,
		[IGST] [decimal](18, 2) NULL,
		[TotalTax] [decimal](18, 2) NULL,
		[NetAmount] [decimal](18, 2) NOT NULL
	);

	Insert into @tempPurchaseList
	Select 
		ph.Id,
		ph.PurchaseCode,
		ph.ClientName,
		ph.ClientMobileNumber,
		ph.PaymentTypeId,
		pt.PaymentTypeName,
		ph.PurchaseDate,
		pli.Quantity,
		pli.PurchaseAmount,
		pli.Discount,
		pli.GrossAmount,
		pli.CGST,
		pli.SGST,
		pli.IGST,
		pli.TotalTax,
		pli.NetAmount
	  from PurchaseHeader as ph
	Join PurchaseLineItem as pli on ph.Id = pli.PurchaseId
	Left Join PaymentType as pt on pt.Id = ph.PaymentTypeId
	Where (ph.PurchaseDate >= @StartDate and ph.PurchaseDate <= @EndDate)
		  and (@PurchaseCode = '' or ph.PurchaseCode = @PurchaseCode)
		  and (@PurchaseId is null or ph.Id = @PurchaseId)
		  and (@ProductId is null or pli.ProductId = @ProductId)
	Order By ph.Id Desc

	Select * from @tempPurchaseList;

END
GO

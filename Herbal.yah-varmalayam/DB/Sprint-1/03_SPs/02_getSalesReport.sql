-- =============================================      
-- Author:  Santhosh N      
-- Create date: 01/11/2020      
-- Description: To bringing the values for sales report      
-- =============================================      
--EXEC getSalesReport   @SalesId = 6    
CREATE PROCEDURE [dbo].[getSalesReport]      
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
  [CustomerMobileNumbers] [Varchar](50),    
  [CustomerGSTIN] [Varchar](50),  
  [CustomerAddress] [Varchar](2000),  
  [ProductId] [int] NOT NULL,      
  [ProductCode] [nvarchar](50) NOT NULL,     
  [ProductName] [nvarchar](150) NULL,      
  [PackQuantity] [nvarchar](50) NULL,      
  [PaymentTypeId] [int] NULL,      
  [PaymentTypeName] [nvarchar](50) NULL,      
  [SalesDate] [datetime] NOT NULL,      
  [Quantity] [decimal](18, 2) NOT NULL,      
  [SalesAmount] [decimal](18, 2) NOT NULL,      
  [GrossAmount] [decimal](18, 2) NOT NULL,      
  [GST] [decimal](18, 2) NULL,      
  [NetAmount] [decimal](18, 2) NOT NULL,    
  [TotalDiscount] [decimal](18, 2) NOT NULL      
 );      
      
 Insert into @tempSalesList      
 Select       
  sh.Id,      
  sh.SalesCode,    
  Isnull(sh.CustomerName, '-'),      
  concat('Ph.No.: ',sh.CustomerMobileNumbers),      
  concat('GSTIN: ',sh.CustomerGSTIN),  
  Isnull(sh.CustomerAddress, '-'),  
  pr.Id,      
  pr.ProductCode,      
  pr.ProductName,      
  pr.PackQuantity,    
  sh.PaymentTypeId,      
  pt.PaymentTypeName,      
  sh.SalesDate,      
  sli.Quantity,      
  sli.SalesAmount,      
  sli.GrossAmount,      
  sli.GST,      
  sli.NetAmount,    
  sh.TotalDiscount    
   from SalesHeader as sh      
 Join SalesLineItem as sli on sh.Id = sli.SalesId      
 Join Product as pr on pr.Id = sli.ProductId      
 Left Join PaymentType as pt on pt.Id = sh.PaymentTypeId      
 Where (sh.SalesDate >= @StartDate and sh.SalesDate <= @EndDate)      
    and (@SalesCode = '' or sh.SalesCode = @SalesCode)      
    and (@SalesId is null or sh.Id = @SalesId)      
    and (@ProductId is null or sli.ProductId = @ProductId)      
 Order By sh.Id Desc      
      
 Select * from @tempSalesList;      
      
END 
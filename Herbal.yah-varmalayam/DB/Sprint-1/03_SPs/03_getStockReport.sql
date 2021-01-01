-- =============================================  
-- Author:  Santhosh N  
-- Create date: 01/11/2020  
-- Description: To bringing the values for stock report  
-- =============================================  
--EXEC getStockReport @SortBy='ProductName', @SortByDirection = 'Asc'  
CREATE PROCEDURE [dbo].[getStockReport]  
 @ProductId int =null,  
 @SortBy varchar(50) = null,  
 @SortByDirection varchar(50) = null  
AS  
BEGIN  
 SET NOCOUNT ON;  
  
 Declare @tempStockList Table(  
  [StockId] int NOT NULL,  
  [ProductId] [int] NOT NULL,  
  [ProductCode] [nvarchar](50) NULL,  
  [ProductName] [nvarchar](150) NULL,  
  [TotalPurchaseQuantity] [decimal](18, 2) NULL,  
  [TotalSalesQuantity] [decimal](18, 2) NULL,  
  [AvilableQuantity] [decimal](18, 2) NULL,  
  [TotalPurchaseAmount] [decimal](18, 2) NULL,  
  [TotalSalesAmount] [decimal](18, 2) NULL,  
  [TotalAvilableSalesAmount] [decimal](18, 2) NULL  
 );  
  
 If(Isnull(@SortByDirection,'') = '')  
 Begin  
  Set @SortByDirection = 'desc'  
 End  
  
 If(Isnull(@SortBy,'') = '')  
 Begin  
  Set @SortBy = 'ProductName'  
 End  
  
 Insert into @tempStockList  
 Select   
  std.Id,  
  pr.Id,  
  pr.ProductCode,  
  pr.ProductName,  
  std.TotalPurchaseQuantity,  
  std.TotalSalesQuantity,  
  std.AvilableQuantity,  
  (select sum(pil.NetAmount) from PurchaseLineItem as pil Where pil.ProductId = std.ProductId and pil.IsActive = 1) as 'TotalPurchaseAmount',  
  (select sum(sil.NetAmount) from SalesLineItem as sil Where sil.ProductId = std.ProductId and std.IsActive = 1) as 'TotalSalesAmount',  
  (std.AvilableQuantity * pr.SellingPrice) as 'TotalAvilableSalesAmount'  
   from StockDetail as std  
   Join Product as pr on pr.Id = std.ProductId  
 Where (@ProductId is null or std.ProductId = @ProductId);  
  
 Select * from @tempStockList as tsd  
 Order by   
  Case When @SortBy = 'TotalPurchaseQuantity' and @SortByDirection = 'asc' then tsd.TotalPurchaseQuantity End ,  
  Case When @SortBy = 'TotalPurchaseQuantity' and @SortByDirection = 'desc' then tsd.TotalPurchaseQuantity End DESC,  
  
  Case When @SortBy = 'TotalSalesQuantity' and @SortByDirection = 'asc' then tsd.TotalSalesQuantity End ,  
  Case When @SortBy = 'TotalSalesQuantity' and @SortByDirection = 'desc' then tsd.TotalSalesQuantity End DESC,  
  
  Case When @SortBy = 'AvilableQuantity' and @SortByDirection = 'asc' then tsd.AvilableQuantity End ,  
  Case When @SortBy = 'AvilableQuantity' and @SortByDirection = 'desc' then tsd.AvilableQuantity End DESC,  
  
  Case When @SortBy = 'TotalPurchaseAmount' and @SortByDirection = 'asc' then tsd.TotalPurchaseAmount End ,  
  Case When @SortBy = 'TotalPurchaseAmount' and @SortByDirection = 'desc' then tsd.TotalPurchaseAmount End DESC,  
  
  Case When @SortBy = 'TotalSalesAmount' and @SortByDirection = 'asc' then tsd.TotalSalesAmount End ,  
  Case When @SortBy = 'TotalSalesAmount' and @SortByDirection = 'desc' then tsd.TotalSalesAmount End DESC,  
  
  Case When @SortBy = 'ProductName' and @SortByDirection = 'asc' then tsd.ProductName End ,  
  Case When @SortBy = 'ProductName' and @SortByDirection = 'desc' then tsd.ProductName End DESC  
  
  
END  
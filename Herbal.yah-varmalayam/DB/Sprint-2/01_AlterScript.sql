Alter table SalesHeader drop column CustomerMobileNumber
GO
Alter table SalesHeader Add [CustomerMobileNumbers] [Varchar](50)
GO
Alter table SalesHeader Add [CustomerGSTIN] [Varchar](50)
GO
Alter table SalesHeader Add [CustomerAddress] [nVarchar](2000)
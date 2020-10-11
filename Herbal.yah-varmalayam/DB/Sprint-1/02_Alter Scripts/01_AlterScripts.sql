
GO
--Insert into AccessRole as avilable roles
Insert into [AccessRole]([RoleName],[IsActive],[CreatedOn])
	Values('Admin',1,getDate())
GO
Insert into [AccessRole]([RoleName],[IsActive],[CreatedOn])
	Values('Employee',1,getDate())
GO
--Insert into AppUser as starting User.
Insert Into [AppUser]([AccessRoleId],[UserName],[Password],[MobileNumber],[IsActive],[CreatedOn])
Values(1,'admin','admin','12332434534',1,getDate())
Go

--Insert Company Detail
Insert into [CompanyDetail]([CompanyName],[Description],[AuthorisedDealer],[PrimaryContactNumber],[SecondaryContactNumber],
				[PrimaryEmailAddress],[WebSite],[CompanyAddress],[GSTINNumber],
				[GSTINCertifiedBy],[Note],[RevisedNote],
				[IsActive],[CreatedOn],[CreatedBy])
Values('YAH HERBALS','SIDDHA, AYURVEDA & UNANI MEDICINES','IMPCOPS Limited Authorised Dealer','9787331747','9791454535',
				'www.yahvarmalayam.com','yahherbals@gmail.com','No. 178, Ilango Nagar, Avarampalayam Road, Ganapathy, Coimbatore - 641006.','33AOPPN3112F2Z7',
				'GMP Certified', 'Goods Once sold cannot be taken back or exchanged','LIST OF PREPARED MEDICINES REVISED SELLING PRICE AND MRP WITH EFFECT FROM 01.05.2020',
				1,GetDate(),1)

GO
--Insert into PaymentType
Insert into PaymentType([PaymentTypeName],[IsActive],[CreatedOn],[CreatedBy])
	Values ('Cash',1,Getdate(),1)
GO
Insert into PaymentType([PaymentTypeName],[IsActive],[CreatedOn],[CreatedBy])
	Values ('Card',1,Getdate(),1)
GO
GO
Insert into PaymentType([PaymentTypeName],[IsActive],[CreatedOn],[CreatedBy])
	Values ('GPay',1,Getdate(),1)
GO
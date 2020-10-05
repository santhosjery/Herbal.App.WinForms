
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
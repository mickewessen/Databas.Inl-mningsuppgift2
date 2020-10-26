CREATE TABLE Errand(
	[Id] int not null identity(1,1) primary key,
	[Description] nvarchar(500) not null,
	[CreationTime] datetime not null,
	[CustomerFirstName] nvarchar(50) not null,
	[CustomerLastName] nvarchar(50) not null,
	[CustomerEmail] nvarchar(50) not null,
	[CustomerPhonenumber] int null,
	[Status] nvarchar(20) not null,
	[Category] nvarchar(20) not null,
	[Createdby] nvarchar(50) not null
)
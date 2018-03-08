CREATE TABLE [dbo].[Users]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Username] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL
)

Insert into [Users] values('male', 'male')
Insert into Users values('female', 'female')
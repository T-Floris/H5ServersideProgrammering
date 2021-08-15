CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1, 1), 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL
)

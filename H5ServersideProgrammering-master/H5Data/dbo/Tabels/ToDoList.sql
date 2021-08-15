CREATE TABLE [dbo].[ToDoList]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1, 1), 
    [Titel] NVARCHAR(MAX) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [User] NVARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Addresses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Street] NVARCHAR(50) NOT NULL, 
    [Number] INT NOT NULL, 
    [NumberAddition] NVARCHAR(5) NULL, 
    [PostalCode] NVARCHAR(10) NOT NULL, 
    [City] NVARCHAR(25) NOT NULL, 
    [Country] NVARCHAR(25) NOT NULL
)

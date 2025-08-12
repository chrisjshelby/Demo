CREATE TABLE [dbo].[Contact]
(
	[id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [firstName] VARCHAR(50) NOT NULL, 
    [lastName] VARCHAR(50) NOT NULL, 
    [emailAddress] VARCHAR(50) NOT NULL
)
CREATE TABLE [dbo].[Contact_Phone]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [contact_id] INT NOT NULL, 
    [phone] NCHAR(10) NOT NULL, 
    [type] NCHAR(10) NULL DEFAULT 'main', 
    CONSTRAINT [FK_Contact_Phone_to_Contact] FOREIGN KEY (contact_id) REFERENCES Contact(id), 
    CONSTRAINT [CK_Contact_Phone_Type] CHECK (Type IN ('main', 'alternate'))
)

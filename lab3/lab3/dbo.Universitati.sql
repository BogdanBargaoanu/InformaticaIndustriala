CREATE TABLE [dbo].[Universitati]
(
	[Id] INT NOT NULL , 
    [NameUniv] TEXT NOT NULL, 
    [City] TEXT NOT NULL, 
    [Code] INT NOT NULL, 
    CONSTRAINT [PK_Universitati] PRIMARY KEY ([Code])
)

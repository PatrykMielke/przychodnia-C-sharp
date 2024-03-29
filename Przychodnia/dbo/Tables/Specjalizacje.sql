CREATE TABLE [dbo].[Specjalizacje] (
    [id_specjalizacja] INT          IDENTITY (1, 1) NOT NULL,
    [nazwa]            VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Specjalizacje] PRIMARY KEY CLUSTERED ([id_specjalizacja] ASC)
);


CREATE TABLE [dbo].[Lekarze] (
    [id_lekarz]             INT          IDENTITY (1, 1) NOT NULL,
    [imie]                  VARCHAR (50) NOT NULL,
    [nazwisko]              VARCHAR (50) NOT NULL,
    [rok_rozpoczecia_pracy] INT          NOT NULL,
    CONSTRAINT [PK_Lekarze] PRIMARY KEY CLUSTERED ([id_lekarz] ASC)
);


CREATE TABLE [dbo].[SpecjalizacjeLekarzy] (
    [id_specjalizacja_lekarz] INT IDENTITY (1, 1) NOT NULL,
    [id_lekarz]               INT NOT NULL,
    [id_specjalizacja]        INT NULL,
    CONSTRAINT [PK_SpecjalizacjeLekarzy] PRIMARY KEY CLUSTERED ([id_specjalizacja_lekarz] ASC)
);


CREATE TABLE [dbo].[Pacjenci] (
    [id_pacjent]         INT          IDENTITY (1, 1) NOT NULL,
    [imie]               VARCHAR (50) NOT NULL,
    [nazwisko]           VARCHAR (50) NOT NULL,
    [pesel]              BIGINT       NOT NULL,
    [data_urodzenia]     DATE         NOT NULL,
    [adres_zamieszkania] VARCHAR (50) NOT NULL,
    [telefon]            INT          NOT NULL,
    [adres_email]        VARCHAR (80) NOT NULL,
    CONSTRAINT [PK_Pacjenci] PRIMARY KEY CLUSTERED ([id_pacjent] ASC)
);
CREATE TABLE [dbo].[Gabinety] (
    [id_gabinet] INT          IDENTITY (1, 1) NOT NULL,
    [nazwa]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Gabinety] PRIMARY KEY CLUSTERED ([id_gabinet] ASC)
);


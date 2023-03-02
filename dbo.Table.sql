CREATE TABLE [dbo].[pessoas]
(
	[id_Contato] INT NOT NULL PRIMARY KEY UNIQUE IDENTITY,
	[Nome] NVARCHAR(100) NULL,
	[Companhia] NVARCHAR(100) NULL,
	[Telefone] NVARCHAR(100) NULL,
	[Email] NVARCHAR(100) NULL,
	[Cliente] BIT NULL,
	[Ultimo_contato] NVARCHAR(100) NULL,
);

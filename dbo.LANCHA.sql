USE [BDPierBoatApp]
GO

/****** Objeto: Table [dbo].[LANCHA] Data do Script: 02/04/2024 01:08:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LANCHA] (
    [ID]         UNIQUEIDENTIFIER NOT NULL,
    [NOME]       NVARCHAR (100)   NOT NULL,
    [TELEFONE]   NVARCHAR (11)    NOT NULL,
    [DATA]       DATE             NOT NULL,
    [PERIODO]    INT              NOT NULL,
    [OBSERVACAO] NVARCHAR (500)   NOT NULL
);



﻿CREATE TABLE [dbo].[PresupuestosDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [PresupuestoId]          UNIQUEIDENTIFIER NOT NULL,
    [TituloId]               UNIQUEIDENTIFIER NOT NULL,
    [Cantidad]               INT              NULL,
    [Precio]                 MONEY            NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_PresupuestosDetalle] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_PresupuestosDetalle_Titulos] FOREIGN KEY (TituloId) REFERENCES Titulos(Id), 
    CONSTRAINT [FK_PresupuestosDetalle_Sucursales] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id)
);


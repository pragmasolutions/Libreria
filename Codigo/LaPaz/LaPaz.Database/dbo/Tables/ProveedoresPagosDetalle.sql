﻿CREATE TABLE [dbo].[ProveedoresPagosDetalle]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ProveedorPagoId] UNIQUEIDENTIFIER NOT NULL, 
    [ProveedorCuentaCorrienteId] UNIQUEIDENTIFIER NOT NULL,
	[ProveedorConsignacionId] UNIQUEIDENTIFIER NOT NULL, 
    [MontoPagado] MONEY NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    CONSTRAINT [FK_ProveedorPagoDetalle_ProveedorPago] FOREIGN KEY (ProveedorPagoId) REFERENCES ProveedoresPagos(Id), 
	CONSTRAINT [FK_ProveedorPagoDetalle_ProveedorCuentaCorrienteId] FOREIGN KEY (ProveedorCuentaCorrienteId) REFERENCES ProveedoresCuentasCorriente(Id), 
    CONSTRAINT [FK_ProveedorPagoDetalle_ProveedorConsignacion] FOREIGN KEY (ProveedorConsignacionId) REFERENCES TitulosConsignacionesRendidas(Id), 
    CONSTRAINT [FK_ProveedorPagoDetalle_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ProveedorPagoDetalle_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_ProveedorPagoDetalle_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id),
    CONSTRAINT [FK_ProveedorPagoDetalle_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
)

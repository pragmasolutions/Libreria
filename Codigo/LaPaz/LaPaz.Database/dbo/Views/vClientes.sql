﻿CREATE VIEW dbo.vClientes
AS
SELECT     dbo.Clientes.Id, dbo.Clientes.Cuenta, dbo.Clientes.Denominacion, dbo.Clientes.Domicilio, dbo.Clientes.DomicilioDoc, dbo.Clientes.Telefono, 
                      dbo.Clientes.Celular, dbo.Clientes.Fax, dbo.Clientes.Cuit, dbo.Clientes.Mail, dbo.Clientes.VendedorId, dbo.Clientes.ProvinciaId, 
                      dbo.Clientes.LocalidadId, dbo.Clientes.CondicionVentaId, dbo.Clientes.FechaNacimiento, dbo.Clientes.PagoLocal, dbo.Clientes.ZonaId, 
                      dbo.Clientes.TipoDocumentoId, dbo.Clientes.CondicionIvaId, dbo.Clientes.Contacto, dbo.Clientes.ProfesionId, dbo.Clientes.EspecialidadId, 
                      dbo.Clientes.EstadoClienteId, dbo.Clientes.AceptaConsig, dbo.Clientes.Imagen, dbo.Clientes.Comentarios, dbo.Clientes.FechaAlta, 
                      dbo.Clientes.OperadorAltaId, dbo.Clientes.FechaModificacion, dbo.Clientes.OperadorModificacionId, dbo.Clientes.Activo, 
                      dbo.Provincias.Nombre AS ProvinciaNombre, dbo.Clientes.Temp, dbo.Localidades.Nombre AS cLoca
FROM         dbo.Clientes LEFT OUTER JOIN
                      dbo.Localidades ON dbo.Clientes.LocalidadId = dbo.Localidades.Id LEFT OUTER JOIN
                      dbo.Provincias ON dbo.Clientes.ProvinciaId = dbo.Provincias.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[24] 4[10] 2[48] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 216
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 25
         End
         Begin Table = "Provincias"
            Begin Extent = 
               Top = 6
               Left = 271
               Bottom = 121
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Localidades"
            Begin Extent = 
               Top = 130
               Left = 271
               Bottom = 238
               Right = 465
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 35
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
  ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'    Begin ColumnWidths = 11
         Column = 4305
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientes';


'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ClientesMovimiento
    Public Property Id As Integer
    Public Property IdCliente As System.Guid
    Public Property IdTipoComprobante As Nullable(Of Integer)
    Public Property IdComprobante As Nullable(Of System.Guid)
    Public Property Concepto As String
    Public Property Debe As Nullable(Of Decimal)
    Public Property Haber As Nullable(Of Decimal)
    Public Property Observaciones As String
    Public Property FechaGeneracion As Nullable(Of Date)
    Public Property FechaAlta As Nullable(Of Date)
    Public Property SucursalAltaId As Nullable(Of Integer)
    Public Property OperadorAltaId As Nullable(Of System.Guid)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property SucursalModificacionId As Nullable(Of Integer)
    Public Property OperadorModificacionId As Nullable(Of System.Guid)

End Class
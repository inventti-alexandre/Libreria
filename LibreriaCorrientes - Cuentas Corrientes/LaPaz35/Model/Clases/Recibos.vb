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

Partial Public Class Recibos
    Public Property Id As System.Guid
    Public Property SucursalCompId As Nullable(Of Integer)
    Public Property Tipo As String
    Public Property PuntoVenta As Nullable(Of Integer)
    Public Property Numero As String
    Public Property FechaAnulacion As Nullable(Of Date)
    Public Property FechaPago As Nullable(Of Date)
    Public Property Total As Nullable(Of Decimal)
    Public Property CobradorId As Nullable(Of Integer)
    Public Property OperadorAuId As Nullable(Of System.Guid)
    Public Property OperadorAltaId As Nullable(Of System.Guid)
    Public Property FechaAlta As Nullable(Of Date)
    Public Property SucursalAltaId As Nullable(Of Integer)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property SucursalModificacionId As Nullable(Of Integer)
    Public Property OperadorModificacionId As Nullable(Of System.Guid)

End Class

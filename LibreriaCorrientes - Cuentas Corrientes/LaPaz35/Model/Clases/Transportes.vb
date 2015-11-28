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

Partial Public Class Transportes
    Public Property Id As System.Guid
    Public Property Nombre As String
    Public Property Abreviatura As String
    Public Property ProvinciaId As Nullable(Of Decimal)
    Public Property LocalidadId As Nullable(Of Decimal)
    Public Property Direccion As String
    Public Property TelPart As String
    Public Property TelCel As String
    Public Property Fax As String
    Public Property OperadorAltaId As Nullable(Of System.Guid)
    Public Property SucursalAltaId As Nullable(Of Integer)
    Public Property FechaAlta As Nullable(Of Date)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property OperadorModificacionId As Nullable(Of System.Guid)
    Public Property SucursalModificacionId As Nullable(Of Integer)
    Public Property codant As Nullable(Of Integer)

    Public Overridable Property ProveedoresBultos As ICollection(Of ProveedoresBultos) = New HashSet(Of ProveedoresBultos)

End Class
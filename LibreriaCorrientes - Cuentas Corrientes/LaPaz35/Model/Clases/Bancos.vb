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

Partial Public Class Bancos
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property NombreCorto As String
    Public Property SucursalId As Integer
    Public Property ProvinciaId As Nullable(Of Integer)
    Public Property LocalidadId As Nullable(Of Integer)
    Public Property Domicilio As String
    Public Property Contacto As String
    Public Property TE1 As String
    Public Property TE2 As String
    Public Property FechaAlta As Nullable(Of Date)
    Public Property OperadorAltaId As Nullable(Of System.Guid)
    Public Property SucursalAltaId As Nullable(Of Integer)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property OperadorModificacionId As Nullable(Of System.Guid)
    Public Property SucursalModificacionId As Nullable(Of Integer)

    Public Overridable Property ChequesTerceros As ICollection(Of ChequesTerceros) = New HashSet(Of ChequesTerceros)

End Class
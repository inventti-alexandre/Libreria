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

Partial Public Class Vales
    Public Property Id As System.Guid
    Public Property CajaId As Nullable(Of System.Guid)
    Public Property MutualId As Nullable(Of Integer)
    Public Property NroVale As String
    Public Property Fecha As Nullable(Of Date)
    Public Property Importe As Nullable(Of Decimal)
    Public Property OperadorCajaId As Nullable(Of System.Guid)
    Public Property sTipo As Nullable(Of Integer)
    Public Property sSuc As Nullable(Of Integer)
    Public Property sId As String
    Public Property sFecha As Nullable(Of Date)
    Public Property sComprob As String
    Public Property FechaAlta As Nullable(Of Date)
    Public Property SucursalAltaId As Nullable(Of Integer)
    Public Property OperadorAltaId As Nullable(Of System.Guid)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property SucursalModificacionId As Nullable(Of Integer)
    Public Property OperadorModificacionId As Nullable(Of System.Guid)
    Public Property OperadorAutoriza As Nullable(Of System.Guid)

    Public Overridable Property Mutuales As Mutuales

End Class

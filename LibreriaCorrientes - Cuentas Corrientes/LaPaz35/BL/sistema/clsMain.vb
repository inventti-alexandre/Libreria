Imports System.Data.SqlClient

Public Class clsMain
    Public ReadOnly Property getConn As SqlConnection
        Get
            Return clsVariableSesion.Instancia.getConn
        End Get
    End Property
    Public ReadOnly Property gettrn As SqlTransaction
        Get
            Return clsVariableSesion.Instancia.getTrn
        End Get
    End Property
    Public Sub IniciarTrn()
        clsVariableSesion.Instancia.IniciarTrn()
    End Sub
End Class

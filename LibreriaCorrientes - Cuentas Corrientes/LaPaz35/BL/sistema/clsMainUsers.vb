Imports System.Data.SqlClient

Public Class clsMainUsers
    Public ReadOnly Property getConnUsers As SqlConnection
        Get
            Return clsVariableSesionUsers.Instancia.getConn
        End Get
    End Property
    Public ReadOnly Property gettrnUsers As SqlTransaction
        Get
            Return clsVariableSesionUsers.Instancia.getTrn
        End Get
    End Property
    Public Sub IniciarTrnUsers()
        clsVariableSesionUsers.Instancia.IniciarTrn()
    End Sub
End Class

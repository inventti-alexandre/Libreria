﻿Imports System.Data.SqlClient

Public Class clsVariableSesionUsers

    Private Shared _Instancia As clsVariableSesionUsers
    Private _conn As SqlConnection, _trn As SqlTransaction
    Private Shared _DbDomain As String
    Private Shared _DbUser As String
    Private Shared _DbPass As String
    Private Shared _Db As String

#Region "Conexion"
    Public Sub New()
        _conn = New SqlConnection
        Try
            '    _conn.ConnectionString = "server=" & _DbDomain & ";" _
            '& " persist security info=False;database=" & _Db & ";logging=True;" _
            '& "password=" & _DbPass & ";" _
            '& "user id=" & _DbUser & ";connect timeout=150;default command timeout=160;" _
            '& "Pooling=false;Connection Lifetime=1; Max Pool Size=1;Allow User Variables=True;allow zero datetime=yes"


            ' _conn.ConnectionString = "data source=.;initial catalog=LCorrientes;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"
            '_conn.ConnectionString = "data source=.;initial catalog=lapaz;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"


            '_conn.ConnectionString = "Data Source=10.1.4.10\SERVERCTES\Administrador,1433;Initial Catalog=lapazUsers;user id=userctacte;password=ap_sys"

            '_conn.ConnectionString = "Data Source=SERVERLCORRIENT;Initial Catalog=LCorrientes;user id=pragma;password=ap_sys"
            
            'Liberria
            _conn.ConnectionString = "Data Source=SERVERLCORRIENT;Initial Catalog=LCorrientes;user id=pragma;password=ap_sys"

            'ElVecinito
            '_conn.ConnectionString = "Data Source=.;Initial Catalog=LCorrientes;user id=pragma;password=ap_sys"

            'ElVecinitoNnuevo
            ' _conn.ConnectionString = "Data Source=ELVECINITO\.,1433;Initial Catalog=lapazUsers;user id=userctacte;password=ap_sys"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared WriteOnly Property DbDomain As String
        Set(ByVal value As String)
            _DbDomain = value
        End Set
    End Property
    Public Shared WriteOnly Property DbUser As String
        Set(ByVal value As String)
            _DbUser = value
        End Set
    End Property
    Public Shared WriteOnly Property DbPass As String
        Set(ByVal value As String)
            _DbPass = value
        End Set
    End Property
    Public Shared WriteOnly Property Db As String
        Set(ByVal value As String)
            _Db = value
        End Set
    End Property
    Public Shared Property Instancia() As clsVariableSesionUsers
        Get
            If _Instancia Is Nothing Then
                _Instancia = New clsVariableSesionUsers
            End If
            Return _Instancia
        End Get
        Set(ByVal value As clsVariableSesionUsers)
            _Instancia = value
        End Set
    End Property
    Public Property getConn() As SqlConnection
        Get
            Return _conn
        End Get
        Set(ByVal value As SqlConnection)
            _conn = value
        End Set
    End Property
    Public Sub IniciarTrn()
        Try
            _trn = getConn.BeginTransaction
        Catch ex As Exception
            _trn.Rollback()
            _trn = getConn.BeginTransaction
        End Try

    End Sub
    Public ReadOnly Property getTrn As SqlTransaction
        Get
            Return _trn
        End Get
    End Property
#End Region

#Region "Variable Sesion"
    Private _Usuario As users
    Public Property Usuario As users
        Get
            If _Usuario Is Nothing Then
                _Usuario = New users
            End If
            Return _Usuario
        End Get
        Set(ByVal value As users)
            _Usuario = value

        End Set
    End Property

#End Region
End Class

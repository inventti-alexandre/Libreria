Public Class clsUsuariosLaPaz
    Inherits clsMain
#Region "PropiedadesLa Paz"

#Region "OperadorSucursal"

    Private _operadorSucursal As OperadorSucursal
    Public Property OperadorSucursal() As OperadorSucursal
        Get
            If _operadorSucursal Is Nothing Then
                _operadorSucursal = New OperadorSucursal
            End If
            Return _operadorSucursal
        End Get
        Set(ByVal value As OperadorSucursal)
            _operadorSucursal = value
        End Set
    End Property

    Private _lstOperadoresSucursal As List(Of OperadorSucursal)
    Public Property LstOperadoresSucursal() As List(Of OperadorSucursal)
        Get
            If _lstOperadoresSucursal Is Nothing Then
                _lstOperadoresSucursal = New List(Of OperadorSucursal)
            End If
            Return _lstOperadoresSucursal
        End Get
        Set(ByVal value As List(Of OperadorSucursal))
            _lstOperadoresSucursal = value
        End Set
    End Property
#End Region



#End Region

#Region "FuncionesLaPaz"

#Region "OperadorSucursal"

    Public Sub FillListOperadorSucursalBySuc(ByVal sucursal As Integer)
        LstOperadoresSucursal = OperadorSucursal.FillListBySucursal(sucursal, getConn)
    End Sub

    Public Sub FillListOperadorSucursalByOperador(ByVal operador As Guid)
        LstOperadoresSucursal = OperadorSucursal.FillListByOperadorId(operador, getConn)
    End Sub
#End Region


#End Region


End Class

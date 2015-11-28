Public Class clsUsuariosUsers
    Inherits clsMainUsers

#Region "PropiedadesLAPAZUsers"

#Region "Roles"
    Private _rol As rolesCtaCte
    Public Property Rol() As rolesCtaCte
        Get
            If _rol Is Nothing Then
                _rol = New rolesCtaCte
            End If
            Return _rol
        End Get
        Set(ByVal value As rolesCtaCte)
            _rol = value
        End Set
    End Property

    Private _lstRoles As List(Of rolesCtaCte)
    Public Property LstRoles() As List(Of rolesCtaCte)
        Get
            If _lstRoles Is Nothing Then
                _lstRoles = New List(Of rolesCtaCte)
            End If
            Return _lstRoles
        End Get
        Set(ByVal value As List(Of rolesCtaCte))
            _lstRoles = value
        End Set
    End Property
#End Region

#Region "Users"

    Private _users As users
    Public Property User() As users
        Get
            If _users Is Nothing Then
                _users = New users
            End If
            Return _users
        End Get
        Set(ByVal value As users)
            _users = value
        End Set
    End Property

    Private _lstUsers As List(Of users)
    Public Property LstUsers() As List(Of users)
        Get
            If _lstUsers Is Nothing Then
                _lstUsers = New List(Of users)
            End If
            Return _lstUsers
        End Get
        Set(ByVal value As List(Of users))
            _lstUsers = value
        End Set
    End Property

#End Region

#Region "ComentariosClientes"

    Private _comCliente As ComentariosClientes
    Public Property ComCliente() As ComentariosClientes
        Get
            If _comCliente Is Nothing Then
                _comCliente = New ComentariosClientes
            End If
            Return _comCliente
        End Get
        Set(ByVal value As ComentariosClientes)
            _comCliente = value
        End Set
    End Property

    Private _lstComCliente As List(Of ComentariosClientes)
    Public Property LstComCliente() As List(Of ComentariosClientes)
        Get
            If _lstComCliente Is Nothing Then
                _lstComCliente = New List(Of ComentariosClientes)
            End If
            Return _lstComCliente
        End Get
        Set(ByVal value As List(Of ComentariosClientes))
            _lstComCliente = value
        End Set
    End Property


#End Region

#Region "Comentario"
    Private _comentario As Comentarios
    Public Property Comentario() As Comentarios
        Get
            If _comentario Is Nothing Then
                _comentario = New Comentarios
            End If
            Return _comentario
        End Get
        Set(ByVal value As Comentarios)
            _comentario = value
        End Set
    End Property

    Private _lstCometarios As List(Of Comentarios)
    Public Property LstComentarios() As List(Of Comentarios)
        Get
            If _lstCometarios Is Nothing Then
                _lstCometarios = New List(Of Comentarios)
            End If
            Return _lstCometarios
        End Get
        Set(ByVal value As List(Of Comentarios))
            _lstCometarios = value
        End Set
    End Property

#End Region

    '#Region "ClientesCuentaCorrienteBackup"
    '    Private _ccc As ClientesCuentasCorrienteBackupUsers
    '    Public Property CCC() As ClientesCuentasCorrienteBackupUsers
    '        Get
    '            If _ccc Is Nothing Then
    '                _ccc = New ClientesCuentasCorrienteBackupUsers
    '            End If
    '            Return _ccc
    '        End Get
    '        Set(ByVal value As ClientesCuentasCorrienteBackupUsers)
    '            _ccc = value
    '        End Set
    '    End Property

    '    Private _lstCCc As List(Of ClientesCuentasCorrienteBackupUsers)
    '    Public Property lstCCC() As List(Of ClientesCuentasCorrienteBackupUsers)
    '        Get
    '            If _lstCCc Is Nothing Then
    '                _lstCCc = New List(Of ClientesCuentasCorrienteBackupUsers)
    '            End If
    '            Return _lstCCc
    '        End Get
    '        Set(ByVal value As List(Of ClientesCuentasCorrienteBackupUsers))
    '            _lstCCc = value
    '        End Set
    '    End Property

    '#End Region

    '#Region "RecibosDetalle"
    '    Private _reciboDetalle As RecibosDetalleUsers
    '    Public Property ReciboDetalle() As RecibosDetalleUsers
    '        Get
    '            If _reciboDetalle Is Nothing Then
    '                _reciboDetalle = New RecibosDetalleUsers
    '            End If
    '            Return _reciboDetalle
    '        End Get
    '        Set(ByVal value As RecibosDetalleUsers)
    '            _reciboDetalle = value
    '        End Set
    '    End Property

    '#End Region

    '#Region "ClientesCuentasCorrientes"
    '    Private _clientesCuentaCorriente As ClientesCuentasCorrienteUsers
    '    Public Property clientescuentacorrienteUsers() As ClientesCuentasCorrienteUsers
    '        Get
    '            If _clientesCuentaCorriente Is Nothing Then
    '                _clientesCuentaCorriente = New ClientesCuentasCorrienteUsers
    '            End If
    '            Return _clientesCuentaCorriente
    '        End Get
    '        Set(ByVal value As ClientesCuentasCorrienteUsers)
    '            _clientesCuentaCorriente = value
    '        End Set
    '    End Property

    '    Private _lstClientesCuentasCorrienteUser As List(Of ClientesCuentasCorrienteUsers)
    '    Public Property LstClientesCuentasCorrientesUser() As List(Of ClientesCuentasCorrienteUsers)
    '        Get
    '            If _lstClientesCuentasCorrienteUser Is Nothing Then
    '                _lstClientesCuentasCorrienteUser = New List(Of ClientesCuentasCorrienteUsers)
    '            End If
    '            Return _lstClientesCuentasCorrienteUser
    '        End Get
    '        Set(ByVal value As List(Of ClientesCuentasCorrienteUsers))
    '            _lstClientesCuentasCorrienteUser = value
    '        End Set
    '    End Property


    '#End Region

#Region "Cliente"

    Private _lstCliente As List(Of Clientes)
    Public Property LstCliente() As List(Of Clientes)
        Get
            Return _lstCliente
        End Get
        Set(ByVal value As List(Of Clientes))
            _lstCliente = value
        End Set
    End Property

    Private _cliente As Clientes
    Public Property Cliente() As Clientes
        Get
            If _cliente Is Nothing Then
                _cliente = New Clientes
            End If
            Return _cliente
        End Get
        Set(ByVal value As Clientes)
            _cliente = value
        End Set
    End Property

#End Region

#Region "Email"
    Private _email As Email
    Public Property Email() As Email
        Get
            If _email Is Nothing Then
                _email = New Email()
            End If
            Return _email
        End Get
        Set(ByVal value As Email)
            _email = value
        End Set
    End Property

    Private _LstEmail As List(Of Email)
    Public Property LstEmail() As List(Of Email)
        Get
            If _LstEmail Is Nothing Then
                _LstEmail = New List(Of Email)
            End If
            Return _LstEmail
        End Get
        Set(ByVal value As List(Of Email))
            _LstEmail = value
        End Set
    End Property
#End Region

#Region "Mail"
    Private _lstMail As DataTable
    Public Property LstMail() As DataTable
        Get
            If _lstMail Is Nothing Then
                _lstMail = New DataTable
            End If
            Return _lstMail
        End Get
        Set(ByVal value As DataTable)
            _lstMail = value
        End Set
    End Property
#End Region
#End Region

#Region "FuncionesLaPazUsers"

#Region "Roles"
    Public Sub FillListRoles()
        LstRoles = Rol.FillList(getConnUsers)
    End Sub
#End Region

#Region "Users"

    Public Sub FillListUsers()
        LstUsers = User.FillList(getConnUsers)
    End Sub

    Public Sub FillUserById(ByVal id As Integer)
        LstUsers = User.FillListById(id, getConnUsers)
    End Sub

    Public Sub GuardarUser()
        User.Insert(getConnUsers, gettrnUsers)
    End Sub
    Public Sub Actualizaruser()
        User.update(getConnUsers, gettrnUsers)
    End Sub

#End Region

#Region "ComentariosCliente"

    Public Sub FillComentariosClientesByCliente(ByVal cliente As Guid)
        LstComCliente = ComCliente.FillListByCliente(cliente, getConnUsers)
    End Sub
    Public Sub FillComentariosClientesByComentario(ByVal comentario As Guid)
        LstComCliente = ComCliente.FillListByComentario(comentario, getConnUsers)
    End Sub

    Public Sub FillUltimoComentarioByCliente(ByVal cliente As Guid)
        LstComCliente = ComCliente.FillUltimoByCliente(cliente, getConnUsers)
    End Sub
    Public Sub InsertComentarioCliente()
        ComCliente.Insert(getConnUsers, gettrnUsers)
    End Sub

    Public Sub GuardarComentarioCliente()
        ComCliente.Update(getConnUsers, gettrnUsers)
    End Sub
#End Region

#Region "Comentarios"

    Public Sub InsertComentario()
        Comentario.Insert(getConnUsers, gettrnUsers)
    End Sub

    Public Sub FillComentarioById(ByVal id As Guid)
        LstComentarios = Comentario.FillListByID(id, getConnUsers)
    End Sub

    Public Sub GuardarComentario()
        Comentario.Update(getConnUsers, gettrnUsers)
    End Sub
#End Region

    '#Region "ClientesCuentasCorrienteBackup"
    '    Public Sub GuardarClienteCuentaCorrienteBackup()
    '        CCC.Insert(getConnUsers, gettrnUsers)
    '    End Sub

    '#End Region
    
#Region "RecibosDetalle"
    'Public Sub GuardarReciboDetalle()
    '    ReciboDetalle.Insert(getConnUsers, gettrnUsers)
    'End Sub
#End Region

    '#Region "ClientesCuentasCorriente"
    '    Public Sub FillListClienteCuentasCorrientes()
    '        LstClientesCuentasCorrientesUser = clientescuentacorrienteUsers.FillList(getConnUsers)
    '    End Sub

    '    Public Sub FillListCCCByCliente(ByVal cliente As Guid)
    '        LstClientesCuentasCorrientesUser = clientescuentacorrienteUsers.FillListByCliente(cliente, getConnUsers)
    '    End Sub
    '    Public Sub FillListCCCByClienteTodas(ByVal cliente As Guid)
    '        LstClientesCuentasCorrientesUser = clientescuentacorrienteUsers.FillListByClienteTodas(cliente, getConnUsers)
    '    End Sub

    '    Public Sub FillListCCCByVenta(ByVal venta As Guid)
    '        LstClientesCuentasCorrientesUser = clientescuentacorrienteUsers.FillListByVenta(venta, getConnUsers)
    '    End Sub

    '    Public Sub FillListCCCById(ByVal Id As System.Guid)
    '        LstClientesCuentasCorrientesUser = clientescuentacorrienteUsers.FillListById(Id, getConnUsers)
    '    End Sub

    '    Public Sub GuardarClienteCuentaCorriente()
    '        clientescuentacorrienteUsers.InsertUpdate(getConnUsers, gettrnUsers)
    '    End Sub

    '    Public Sub GuardarClienteCuentaCorrienteBack()
    '        clientescuentacorrienteUsers.InsertUpdateBack(getConnUsers, gettrnUsers)
    '    End Sub

    '    Public Sub ActualizarClienteCuentaCorriente()
    '        clientescuentacorrienteUsers.Update(getConnUsers, gettrnUsers)
    '    End Sub
    '    Public Function ContarClienteCuentaCorriente() As Integer
    '        Dim count As Integer = clientescuentacorrienteUsers.Count(getConnUsers)
    '        Return count
    '    End Function

    '#End Region

#Region "Cliente"
    Public Sub FillClienteById(clienteid As Guid)
        LstCliente = Cliente.FillClienteByID(clienteid, getConnUsers)
        If LstCliente.Count > 0 Then
            Cliente = LstCliente.First
        Else
            Cliente = New Clientes
        End If

    End Sub

    Public Function NuevoSaldo(cliente As Clientes)
        If cliente.InsertUpdate(getConnUsers, gettrnUsers) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ActualizarSaldo(cliente As Clientes)
        If cliente.Update(getConnUsers, gettrnUsers) Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region "Mail"

    Public Function FillClienteConMail() As DataTable
        LstMail = Cliente.FillClienteConMail(getConnUsers)
        Return LstMail
    End Function
#End Region

#Region "Email"
    Public Function NuevoEmail(mail As Email)
        If Email.Insert(getConnUsers, gettrnUsers) Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#End Region

End Class

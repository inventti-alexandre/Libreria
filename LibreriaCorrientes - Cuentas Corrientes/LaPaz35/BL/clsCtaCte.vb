Public Class clsCtaCte
    Inherits clsMain

#Region "Propiedades"
#Region "Clientes"
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

    Private _LstCliente As List(Of Clientes)
    Public Property Lstcliente() As List(Of Clientes)
        Get
            If _LstCliente Is Nothing Then
                _LstCliente = New List(Of Clientes)
            End If
            Return _LstCliente
        End Get
        Set(ByVal value As List(Of Clientes))
            _LstCliente = value
        End Set
    End Property
#End Region

#Region "ClientesCuentasCorrientes"
    Private _clienteCuentasCorriente As ClientesCuentasCorriente
    Public Property ClienteCuentasCorriente() As ClientesCuentasCorriente
        Get
            If _clienteCuentasCorriente Is Nothing Then
                _clienteCuentasCorriente = New ClientesCuentasCorriente
            End If
            Return _clienteCuentasCorriente
        End Get
        Set(ByVal value As ClientesCuentasCorriente)
            _clienteCuentasCorriente = value
        End Set
    End Property

    Private _lstClienteCuentasCorriente As List(Of ClientesCuentasCorriente)
    Public Property LstClienteCuentasCorriente() As List(Of ClientesCuentasCorriente)
        Get
            If _lstClienteCuentasCorriente Is Nothing Then
                _lstClienteCuentasCorriente = New List(Of ClientesCuentasCorriente)
            End If
            Return _lstClienteCuentasCorriente
        End Get
        Set(ByVal value As List(Of ClientesCuentasCorriente))
            _lstClienteCuentasCorriente = value
        End Set
    End Property


#End Region

#Region "Ventas"
    Private _venta As Ventas
    Public Property Venta() As Ventas
        Get
            If _venta Is Nothing Then
                _venta = New Ventas
            End If
            Return _venta
        End Get
        Set(ByVal value As Ventas)
            _venta = value
        End Set
    End Property

    Private _lstVentas As List(Of Ventas)
    Public Property LstVentas() As List(Of Ventas)
        Get
            If _lstVentas Is Nothing Then
                _lstVentas = New List(Of Ventas)
            End If
            Return _lstVentas
        End Get
        Set(ByVal value As List(Of Ventas))
            _lstVentas = value
        End Set
    End Property


#End Region

#Region "VentasDetalle"
    Private _ventaDetalle As VentasDetalle
    Public Property VentasDetalle() As VentasDetalle
        Get
            If _ventaDetalle Is Nothing Then
                _ventaDetalle = New VentasDetalle
            End If
            Return _ventaDetalle
        End Get
        Set(ByVal value As VentasDetalle)
            _ventaDetalle = value
        End Set
    End Property

    Private _lstVentasDetalle As List(Of VentasDetalle)
    Public Property LstVentaDetalle() As List(Of VentasDetalle)
        Get
            If _lstVentasDetalle Is Nothing Then
                _lstVentasDetalle = New List(Of VentasDetalle)
            End If
            Return _lstVentasDetalle
        End Get
        Set(ByVal value As List(Of VentasDetalle))
            _lstVentasDetalle = value
        End Set
    End Property


#End Region

#Region "ClientesMovimiento"

    Private _clienteMovimiento As ClientesMovimiento
    Public Property ClienteMovimiento() As ClientesMovimiento
        Get
            If _clienteMovimiento Is Nothing Then
                _clienteMovimiento = New ClientesMovimiento
            End If
            Return _clienteMovimiento
        End Get
        Set(ByVal value As ClientesMovimiento)
            _clienteMovimiento = value
        End Set
    End Property

    Private _lstClienteMovimiento As List(Of ClientesMovimiento)
    Public Property LstClienteMovimiento() As List(Of ClientesMovimiento)
        Get
            If _lstClienteMovimiento Is Nothing Then
                _lstClienteMovimiento = New List(Of ClientesMovimiento)
            End If
            Return _lstClienteMovimiento
        End Get
        Set(ByVal value As List(Of ClientesMovimiento))
            _lstClienteMovimiento = value
        End Set
    End Property
#End Region

#Region "Recibos"
    Private _recibo As Recibos
    Public Property Recibo() As Recibos
        Get
            If _recibo Is Nothing Then
                _recibo = New Recibos
            End If
            Return _recibo
        End Get
        Set(ByVal value As Recibos)
            _recibo = value
        End Set
    End Property

    Private _lstRecibos As List(Of Recibos)
    Public Property LstRecibos() As List(Of Recibos)
        Get
            If _lstRecibos Is Nothing Then
                _lstRecibos = New List(Of Recibos)
            End If
            Return _lstRecibos
        End Get
        Set(ByVal value As List(Of Recibos))
            _lstRecibos = value
        End Set
    End Property

#End Region

#Region "RecibosDetalle"

    Private _reciboDetalle As RecibosDetalle
    Public Property RecibosDetalle() As RecibosDetalle
        Get
            If _reciboDetalle Is Nothing Then
                _reciboDetalle = New RecibosDetalle
            End If
            Return _reciboDetalle
        End Get
        Set(ByVal value As RecibosDetalle)
            _reciboDetalle = value
        End Set
    End Property

    Private _lstreciboDetalle As List(Of RecibosDetalle)
    Public Property LstReciboDetalle() As List(Of RecibosDetalle)
        Get
            If _lstreciboDetalle Is Nothing Then
                _lstreciboDetalle = New List(Of RecibosDetalle)
            End If
            Return _lstreciboDetalle
        End Get
        Set(ByVal value As List(Of RecibosDetalle))
            _lstreciboDetalle = value
        End Set
    End Property

#End Region

#Region "CajasMovimientos"
    Private _cajaMovimiento As CajasMovimientos
    Public Property CajaMovimiento() As CajasMovimientos
        Get
            If _cajaMovimiento Is Nothing Then
                _cajaMovimiento = New CajasMovimientos
            End If
            Return _cajaMovimiento
        End Get
        Set(ByVal value As CajasMovimientos)
            _cajaMovimiento = value
        End Set
    End Property

    Private _lstCajasMovimientos As List(Of CajasMovimientos)
    Public Property LstCajasMovimientos() As List(Of CajasMovimientos)
        Get
            If _lstCajasMovimientos Is Nothing Then
                _lstCajasMovimientos = New List(Of CajasMovimientos)
            End If
            Return _lstCajasMovimientos
        End Get
        Set(ByVal value As List(Of CajasMovimientos))
            _lstCajasMovimientos = value
        End Set
    End Property


#End Region

#Region "Tarjetas"

    Private _tarjetas As Tarjetas
    Public Property Tarjetas() As Tarjetas
        Get
            If _tarjetas Is Nothing Then
                _tarjetas = New Tarjetas
            End If
            Return _tarjetas
        End Get
        Set(ByVal value As Tarjetas)
            _tarjetas = value
        End Set
    End Property

    Private _lstTarjetas As List(Of Tarjetas)
    Public Property LstTarjetas() As List(Of Tarjetas)
        Get
            If _lstTarjetas Is Nothing Then
                _lstTarjetas = New List(Of Tarjetas)
            End If
            Return _lstTarjetas
        End Get
        Set(ByVal value As List(Of Tarjetas))
            _lstTarjetas = value
        End Set
    End Property

#End Region

#Region "Bancos"

    Private _banco As Bancos
    Public Property Banco() As Bancos
        Get
            If _banco Is Nothing Then
                _banco = New Bancos
            End If
            Return _banco
        End Get
        Set(ByVal value As Bancos)
            _banco = value
        End Set
    End Property

    Private _lstBancos As List(Of Bancos)
    Public Property LstBancos() As List(Of Bancos)
        Get
            If _lstBancos Is Nothing Then
                _lstBancos = New List(Of Bancos)
            End If
            Return _lstBancos
        End Get
        Set(ByVal value As List(Of Bancos))
            _lstBancos = value
        End Set
    End Property

    Private _cuenta As Cuentas
    Public Property Cuenta() As Cuentas
        Get
            If _cuenta Is Nothing Then
                _cuenta = New Cuentas
            End If
            Return _cuenta
        End Get
        Set(ByVal value As Cuentas)
            _cuenta = value
        End Set
    End Property
    Private _lstCuentas As List(Of Cuentas)
    Public Property LstCuentas() As List(Of Cuentas)
        Get
            If _lstCuentas Is Nothing Then
                _lstCuentas = New List(Of Cuentas)
            End If
            Return _lstCuentas
        End Get
        Set(ByVal value As List(Of Cuentas))
            _lstCuentas = value
        End Set
    End Property


#End Region

#Region "Cajas"
    Private _caja As Cajas
    Public Property Caja() As Cajas
        Get
            If _caja Is Nothing Then
                _caja = New Cajas
            End If
            Return _caja
        End Get
        Set(ByVal value As Cajas)
            _caja = value
        End Set
    End Property

    Private _lstCaja As List(Of Cajas)
    Public Property LstCajas() As List(Of Cajas)
        Get
            If _lstCaja Is Nothing Then
                _lstCaja = New List(Of Cajas)
            End If
            Return _lstCaja
        End Get
        Set(ByVal value As List(Of Cajas))
            _lstCaja = value
        End Set
    End Property

#End Region

#Region "ChequesTerceros"

    Private _cheque As ChequesTerceros
    Public Property Cheque() As ChequesTerceros
        Get
            If _cheque Is Nothing Then
                _cheque = New ChequesTerceros
            End If
            Return _cheque
        End Get
        Set(ByVal value As ChequesTerceros)
            _cheque = value
        End Set
    End Property

    Private _lstCheque As List(Of ChequesTerceros)
    Public Property LstCheques() As List(Of ChequesTerceros)
        Get
            If _lstCheque Is Nothing Then
                _lstCheque = New List(Of ChequesTerceros)
            End If
            Return _lstCheque
        End Get
        Set(ByVal value As List(Of ChequesTerceros))
            _lstCheque = value
        End Set
    End Property

    Private _deposito As CuentasMovimientos
    Public Property Depostio() As CuentasMovimientos
        Get
            If _deposito Is Nothing Then
                _deposito = New CuentasMovimientos
            End If
            Return _deposito
        End Get
        Set(ByVal value As CuentasMovimientos)
            _deposito = value
        End Set
    End Property

    Private _lstDeposito As List(Of CuentasMovimientos)
    Public Property LstDepositos() As List(Of CuentasMovimientos)
        Get
            If _lstDeposito Is Nothing Then
                _lstDeposito = New List(Of CuentasMovimientos)
            End If
            Return _lstDeposito
        End Get
        Set(ByVal value As List(Of CuentasMovimientos))
            _lstDeposito = value
        End Set
    End Property
#End Region

#Region "MovimientosTarjetas"

    Private _tarjetasMov As TarjetasMovimientos
    Public Property TarjetasMov() As TarjetasMovimientos
        Get
            If _tarjetasMov Is Nothing Then
                _tarjetasMov = New TarjetasMovimientos
            End If
            Return _tarjetasMov
        End Get
        Set(ByVal value As TarjetasMovimientos)
            _tarjetasMov = value
        End Set
    End Property

    Private _lstTarjetasMov As List(Of TarjetasMovimientos)
    Public Property LstTarjetasMov() As List(Of TarjetasMovimientos)
        Get
            If _lstTarjetasMov Is Nothing Then
                _lstTarjetasMov = New List(Of TarjetasMovimientos)
            End If
            Return _lstTarjetasMov
        End Get
        Set(ByVal value As List(Of TarjetasMovimientos))
            _lstTarjetasMov = value
        End Set
    End Property


#End Region

#End Region

#Region "Funciones"

#Region "Clientes"
    Public Sub FillListClientes()
        Lstcliente = Cliente.FillList(getConn)
    End Sub

    Public Sub FillByCliente(ByRef cuit As String)
        Lstcliente = Cliente.FillListByCliente(cuit, getConn)
    End Sub

    Public Sub FillClienteById(ByRef id As Guid)
        Lstcliente = Cliente.FillListById(id, getConn)
    End Sub
#End Region

#Region "ClientesCuentasCorriente"
    Public Sub FillListClienteCuentasCorrientes()
        LstClienteCuentasCorriente = ClienteCuentasCorriente.FillList(getConn)
    End Sub

    Public Sub FillListCCCByCliente(ByVal cliente As Guid)
        LstClienteCuentasCorriente = ClienteCuentasCorriente.FillListByCliente(cliente, getConn)
    End Sub

    Public Sub FillListCCCByClienteTodas(ByVal cliente As Guid)
        LstClienteCuentasCorriente = ClienteCuentasCorriente.FillListByClienteTodas(cliente, getConn)
    End Sub

    Public Sub FillListCCCUltimaByCliente(ByVal cliente As Guid)
        LstClienteCuentasCorriente = ClienteCuentasCorriente.FillListUltimaByCliente(cliente, getConn)
    End Sub

    Public Sub FillListCCCByVenta(ByVal venta As Guid)
        LstClienteCuentasCorriente = ClienteCuentasCorriente.FillListByVenta(venta, getConn)
    End Sub

    Public Sub FillListCCCById(ByVal Id As System.Guid)
        LstClienteCuentasCorriente = ClienteCuentasCorriente.FillListById(Id, getConn)
    End Sub

    Public Sub GuardarClienteCuentaCorriente()
        ClienteCuentasCorriente.Update(getConn, gettrn)
    End Sub

    Public Function ContarClienteCuentaCorriente() As Integer
        Dim count As Integer = ClienteCuentasCorriente.count(getConn)
        Return count
    End Function

    Public Sub FillUltimos(ByVal cantidad As Integer)
        LstClienteCuentasCorriente = ClienteCuentasCorriente.CargarUltimos(getConn, cantidad)
    End Sub
#End Region

#Region "Ventas"
    Public Sub FillVentasByCte(ByVal cliente As Guid)
        LstVentas = Venta.FillListByCliente(cliente, getConn)
    End Sub

    Public Sub FillVentasById(ByVal id As Guid)
        LstVentas = Venta.FillListById(id, getConn)
    End Sub

    Public Sub GuardarVenta()
        Venta.Update(getConn, gettrn)
    End Sub
#End Region

#Region "ClientesMovimiento"
    Public Sub FillClienteMovimientoByCliente(ByRef cliente As Guid)
        LstClienteMovimiento = ClienteMovimiento.FillListByCliente(cliente, getConn)
    End Sub

    Public Sub FillClienteMovimientoByVenta(ByRef venta As Guid)
        LstClienteMovimiento = ClienteMovimiento.FillListByVenta(venta, getConn)
    End Sub

    Public Sub GuardarClienteMovimiento()
        ClienteMovimiento.Insert(getConn, gettrn)
    End Sub

#End Region

#Region "Recibos"

    Public Sub FillRecibosByComprobante(ByVal comprobante As Guid)
        LstRecibos = Recibo.FillListByComprobante(comprobante, getConn)
    End Sub
    Public Sub FillListRecibos()
        LstRecibos = Recibo.FillList(getConn)
    End Sub

    Public Sub FillListRecibosByCliente(ByVal clienteid As Guid)
        LstRecibos = Recibo.FillListByCliente(getConn, clienteid)
    End Sub

    Public Sub FillUltimoNumeroRecibo()
        LstRecibos = Recibo.FillListUltimoNumeroComprobante(getConn)
    End Sub
    Public Sub GuardarRecibo()
        Recibo.Id = Recibo.Insert(getConn, gettrn)
    End Sub
#End Region

#Region "RecibosDetalle"
    Public Sub FillReciboDetalleById(ByVal Reciboid As Guid)
        LstReciboDetalle = RecibosDetalle.FillListByReciboId(Reciboid, getConn)
    End Sub

    Public Sub FillReciboDetalleByCliente(ByVal idccc As Guid)
        LstReciboDetalle = RecibosDetalle.FillListByIdCCC(idccc, getConn)
    End Sub

    Public Sub FillRecibosDetalleByVenta(ByVal venta As Guid)
        LstReciboDetalle = RecibosDetalle.FillListByVenta2(venta, getConn)
    End Sub

    Public Sub GuardarReciboDetalle()
        RecibosDetalle.Insert(getConn, gettrn)
    End Sub
#End Region

#Region "Cajas Movimientos"
    Public Sub FillCajasMovimientosByComprobante(ByVal comprobante As Guid)
        LstCajasMovimientos = CajaMovimiento.FillListByComprobante(comprobante, getConn)
    End Sub

    Public Sub FillCajasMovimientosByIdComprobante(ByVal comprobante As Guid)
        LstCajasMovimientos = CajaMovimiento.FillListByIdComprobante(comprobante, getConn)
    End Sub

    Public Sub GuardarCajaMovimiento()
        CajaMovimiento.Insert(getConn, gettrn)
    End Sub
#End Region

#Region "VentasDetalle"
    Public Sub FillVentasDetalleByVenta(ByVal ventaid As Guid)
        LstVentaDetalle = VentasDetalle.FillListByVenta(ventaid, getConn)
    End Sub
#End Region

#Region "Tarjetas"
    Public Sub FillListTarjetas()
        LstTarjetas = Tarjetas.FillList(getConn)
    End Sub
#End Region

#Region "Bancos"

    Public Sub FillListBancos()
        LstBancos = Banco.FillList(getConn)
    End Sub
#End Region

#Region "Cajas"
    Public Sub FillUltimaCaja(ByVal operadorid As Guid)
        LstCajas = Caja.FillListUltimaCaja(getConn, operadorid)
    End Sub

    Public Sub GuardarCaja()
        Caja.Update(getConn, gettrn)
    End Sub
#End Region

#Region "ChequesTerceros"
    Public Sub GuardarCheque()
        Cheque.Insert(getConn, gettrn)
    End Sub
#End Region

#Region "Cuentas"
    Public Sub FillListCuentas()
        LstCuentas = Cuenta.FillList(getConn)
    End Sub
#End Region
#Region "CuentasMovimientos"

    Public Sub GuardarDeposito()
        Depostio.Insert(getConn, gettrn)
    End Sub
#End Region
#Region "TarjetasMovimmientos"
    Public Sub FillListUltimoIntTarjeta()
        LstTarjetasMov = TarjetasMov.FillListUltimoInt(getConn)
    End Sub

    Public Sub GuardarTarjetaMov()
        TarjetasMov.Insert(getConn, gettrn)
    End Sub
#End Region
#End Region



End Class

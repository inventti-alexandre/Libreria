Public Class frmDetalleRecibo
    Dim cls As New clsCtaCte
    Dim bgsRecibosDetalle As New BindingSource


    Public Sub New(ByVal reciboId As Guid)
        InitializeComponent()

        If reciboId <> System.Guid.Empty Then
            cls.FillReciboDetalleById(reciboId)
            bgsRecibosDetalle.DataSource = cls.LstReciboDetalle
            cls.FillCajasMovimientosByComprobante(reciboId)
            lblIntereses.Text = "Intereses cobrados = " & (cls.LstCajasMovimientos.First.Recargo).ToString
        End If
    End Sub

    Private Sub frmDetalleRecibo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvDetalleRecibo.AutoGenerateColumns = False
        dgvDetalleRecibo.DataSource = bgsRecibosDetalle

    End Sub

    Private Sub lblCliente_Click(sender As Object, e As EventArgs) Handles lblIntereses.Click

    End Sub
End Class
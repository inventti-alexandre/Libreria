Imports System.Data.SqlClient

Public Class FrmMailsEnviados

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        PoblarReporte()
    End Sub

    Private Sub PoblarReporte()

        Dim Reporte As New MailsEnviados
        Dim da As New SqlDataAdapter

        'Dim conne As New SqlConnection("data source=EQUIPO-SIL;initial catalog=lapaz;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        'Dim conne As New SqlConnection("Data Source=10.1.4.10\SERVERCTES\Administrador,1433;Initial Catalog=lapaz;user id=userctacte;password=ap_sys")
        Dim conne As New SqlConnection("Data Source=10.1.4.11;Initial Catalog=LCorrientes;user id=pragma;password=ap_sys")

        If (dtpFecha.Value.ToShortDateString() <> "01/01/2014") Then
            da = New SqlDataAdapter("lpu_sp_EnvioMailsFecha", conne)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@fecha", dtpFecha.Value)

        Else
            da = New SqlDataAdapter("lpu_sp_EnvioMails", conne)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@dni", txtDNi.Text)
            da.SelectCommand.Parameters.AddWithValue("@denominacion", txtNombre.Text)

        End If
        
        Dim dt As New DataTable
        da.Fill(dt)
        Reporte.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = Reporte

    End Sub
End Class
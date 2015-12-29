Imports System.Data.SqlClient

Public Class FrmInformeDeudasPorMonto

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        PoblarReporte()
    End Sub

    Private Sub PoblarReporte()

        ' Dim montodesde As String = Format(txtMontoDesde.Text, "yyyyMMdd")
        '  Dim fechahasta As String = Format(dtpHasta.Value, "yyyyMMdd")
        Dim Reporte As New crInformeDeudasPorMonto

        'Dim conne As New SqlConnection("data source=EQUIPO-SIL;initial catalog=lapaz;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        'Dim conne As New SqlConnection("Data Source=10.1.4.10\SERVERCTES\Administrador,1433;Initial Catalog=lapaz;user id=userctacte;password=ap_sys")
        Dim conne As New SqlConnection("Data Source=10.1.4.11;Initial Catalog=LCorrientes;user id=pragma;password=ap_sys")

        Dim da As New SqlDataAdapter("ClientesCuentaCorrienteVencidaMonto", conne)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@montodesde", txtMontoDesde.Text)
        da.SelectCommand.Parameters.AddWithValue("@montohasta", txtMontoHasta.Text)

        Dim dt As New DataTable
        da.Fill(dt)
        Reporte.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = Reporte

    End Sub
End Class
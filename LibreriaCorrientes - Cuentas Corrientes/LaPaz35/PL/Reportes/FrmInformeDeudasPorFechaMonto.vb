Imports System.Data.SqlClient

Public Class FrmInformeDeudasPorFechaMonto

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        PoblarReporte()
    End Sub

    Private Sub PoblarReporte()

        Dim fechadesde As String = Format(dtpDesde.Value, "yyyyMMdd")
        Dim fechahasta As String = Format(dtpHasta.Value, "yyyyMMdd")
        Dim Reporte As New crInformeDeudasPorFechaMonto

        'Dim conne As New SqlConnection("data source=EQUIPO-SIL;initial catalog=lapaz;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        'Dim conne As New SqlConnection("Data Source=10.1.4.10\SERVERCTES\Administrador,1433;Initial Catalog=lapaz;user id=userctacte;password=ap_sys")

        Dim conne As New SqlConnection("Data Source=10.1.4.10\SQLEXPRESSPRAGMA;Initial Catalog=LCorrientes;user id=pragma;password=ap_sys")

        Dim da As New SqlDataAdapter("ClientesCuentaCorrienteVencidaFechaMonto", conne)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@fechadesde", fechadesde)
        da.SelectCommand.Parameters.AddWithValue("@fechahasta", fechahasta)
        da.SelectCommand.Parameters.AddWithValue("@montodesde", txtMontoDesde.Text)
        da.SelectCommand.Parameters.AddWithValue("@montohasta", txtMontoHasta.Text)

        Dim dt As New DataTable
        da.Fill(dt)
        Reporte.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = Reporte

    End Sub
End Class
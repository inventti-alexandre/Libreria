Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class FrmInfClientesDeudoresFiltros


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        PoblarReporte()
   End Sub

    Private Sub PoblarReporte()

        Dim fechadesde As String = Format(dtpDesde.Value, "yyyyMMdd")
        Dim fechahasta As String = Format(dtpHasta.Value, "yyyyMMdd")
        Dim Reporte As New crInformeDeudasPorFecha

        'Dim conne As New SqlConnection("data source=EQUIPO-SIL;initial catalog=lapaz;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        Dim conne As New SqlConnection("Data Source=10.1.4.11\.;Initial Catalog=LCorrientes;user id=pragma;password=ap_sys")

        Dim da As New SqlDataAdapter("ClientesCuentaCorrienteVencida", conne)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@fechadesde", fechadesde)
        da.SelectCommand.Parameters.AddWithValue("@fechahasta", fechahasta)

        Dim dt As New DataTable
        da.Fill(dt)
        Reporte.SetDataSource(dt)

       CrystalReportViewer1.ReportSource = Reporte
    
    End Sub
     
  End Class
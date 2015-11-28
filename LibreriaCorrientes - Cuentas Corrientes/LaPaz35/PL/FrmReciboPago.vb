Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class FrmReciboPago

    Public Sub New(ByVal ReciboNro As String, ByVal ClienteNombre As String, ByVal ClienteDomicilio As String, ByVal ClienteDni As String, ByVal MontoTexto As String, ByVal Concepto As String, ByVal Total As Decimal,
                   ByVal Metodo As String)

        ' This call is required by the designer.
        InitializeComponent()
        'Dim rpt As LocalReport = Me.ReportViewer1.LocalReport
        'rpt.ReportPath = Application.StartupPath & "\PL\Reportes\ReportReciboPago.rdlc"

        ' Add any initialization after the InitializeComponent() call.
        Dim Recibo As New Microsoft.Reporting.WinForms.ReportParameter("ReciboNro", ReciboNro)
        Dim Fecha As New ReportParameter("Fecha", Now.ToString)
        Dim Nombre As New ReportParameter("ClienteNombre", ClienteNombre)
        If ClienteDomicilio Is Nothing Then
            ClienteDomicilio = " "
        End If
        Dim Domicilio As New ReportParameter("ClienteDomicilio", ClienteDomicilio)


        Dim DNI As New ReportParameter("ClienteDNI", ClienteDni)
        Dim Monto As New ReportParameter("MontoTexto", MontoTexto)
        Dim Concep As New ReportParameter("Concepto", Concepto)
        Dim Tot As New ReportParameter("Total", Total)
        Dim metodopago As New ReportParameter("Metodo", Metodo)


        Me.ReportViewer1.LocalReport.SetParameters(Recibo)
        Me.ReportViewer1.LocalReport.SetParameters(Fecha)
        Me.ReportViewer1.LocalReport.SetParameters(Nombre)
        Me.ReportViewer1.LocalReport.SetParameters(Domicilio)
        Me.ReportViewer1.LocalReport.SetParameters(DNI)
        Me.ReportViewer1.LocalReport.SetParameters(Monto)
        Me.ReportViewer1.LocalReport.SetParameters(Concep)
        Me.ReportViewer1.LocalReport.SetParameters(Tot)
        Me.ReportViewer1.LocalReport.SetParameters(metodopago)

        Me.ReportViewer1.RefreshReport()


    End Sub
    Private Sub FrmReciboPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.ReportViewer1.RefreshReport()
        'Dim rpt As LocalReport = Me.ReportViewer1.LocalReport
        'rpt.ReportPath = Application.StartupPath & "\..\..\ReportReciboPago.rdlc"
        'Using cls As New ReportUtils
        '    cls.Print(rpt)
        'End Using
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms


Public Class ReportUtils
    Implements IDisposable

    Private currentPageIndex As Integer
    Private tmpFileName As String = String.Empty
    Private streamList As List(Of Stream)

    Enum Orientation
        Landscape
        Portrait
    End Enum

    ''' <summary> 
    ''' Add the Stream to the list 
    ''' </summary> 
    Private Function CreateStream(ByVal name As String, _
                                  ByVal fileNameExtension As String, _
                                  ByVal encoding As Encoding, _
                                  ByVal mimeType As String, _
                                  ByVal willSeek As Boolean) As Stream

        tmpFileName = My.Computer.FileSystem.GetTempFileName()

        Dim s As New FileStream(tmpFileName, FileMode.Create)
        streamList.Add(s)
        Return s

    End Function


    ''' <summary> 
    ''' Exports the file to the list of Streams 
    ''' </summary> 
    Private Sub ExportToStream(ByVal report As LocalReport, ByVal Orientation As Orientation)

        Dim deviceInfo As New StringBuilder
        With deviceInfo
            .Append("<deviceinfo>")
            .Append(" <outputformat>EMF</outputformat>")

            If Orientation = ReportUtils.Orientation.Portrait Then
                .Append(" <pagewidth>8.5in</pagewidth>")
                .Append(" <pageheight>11.5in</pageheight>")
            Else
                .Append(" <pagewidth>11.5in</pagewidth>")
                .Append(" <pageheight>8.5in</pageheight>")
            End If

            .Append(" <margintop>0.3in</margintop>")
            .Append(" <marginleft>0.3in</marginleft>")
            .Append(" <marginright>0.3in</marginright>")
            .Append(" <marginbottom>0.3in</marginbottom>")
            .Append("</deviceinfo>")
        End With

        Dim warnings() As Warning = Nothing
        report.Render("Image", deviceInfo.ToString, _
                         AddressOf CreateStream, warnings)

        For Each s As Stream In streamList
            s.Position = 0
        Next
        deviceInfo = Nothing

    End Sub


    '''<summary> 
    ''' When the PrintDocument is printing, draw the right page from the list 
    '''</summary> 
    Private Sub PrintPage(ByVal sender As Object, _
                                                   ByVal ev As PrintPageEventArgs)

        Using pageImage As New Metafile(streamList(currentPageIndex))
            currentPageIndex += 1

            ev.Graphics.DrawImage(pageImage, ev.PageBounds)
            ev.HasMorePages = (currentPageIndex < streamList.Count)
        End Using

    End Sub


    '''<summary> 
    ''' Prints the report without preview 
    '''</summary> 
    '''<param name="report">Report Name </param> 
    Public Sub Print(ByVal report As LocalReport, ByVal Orientation As Orientation)

        streamList = New List(Of Stream)

        ' Exports the file to a list of Streams 
        Call ExportToStream(report, Orientation)

        If streamList IsNot Nothing AndAlso streamList.Count > 0 Then

            ' Start the printing process 
            Using printDoc As New PrintDocument()

                If Not printDoc.PrinterSettings.IsValid Then
                    Dim msg As String = "Printer is not available or is not valid!"
                    Throw New ArgumentException(msg)
                End If

                AddHandler printDoc.PrintPage, AddressOf PrintPage
                If Orientation = ReportUtils.Orientation.Portrait Then
                    printDoc.DefaultPageSettings.Landscape = False
                Else
                    printDoc.DefaultPageSettings.Landscape = True
                End If

                printDoc.Print()
            End Using

        End If

    End Sub

    '''<summary> 
    ''' Prints the report without preview
    '''</summary> 
    '''<param name="report">Report Name</param> 
    Public Sub Print(ByVal report As LocalReport)
        Print(report, Orientation.Portrait)
    End Sub


    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        Try

            If streamList IsNot Nothing Then
                For Each s As Stream In streamList
                    s.Close()
                Next
                streamList.Clear()
                streamList = Nothing
            End If

            If tmpFileName <> String.Empty AndAlso _
                              IO.File.Exists(tmpFileName) Then
                IO.File.Delete(tmpFileName)
            End If
            tmpFileName = String.Empty

        Catch ex As Exception : End Try
    End Sub

End Class

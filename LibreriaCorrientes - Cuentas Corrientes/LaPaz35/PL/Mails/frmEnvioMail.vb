Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Text

Namespace PL.Mails

    Public Class frmEnvioMail
        '  Dim Inicio As Integer = -30
        ' Dim Fin As Integer = 3
        Dim clsUser As New clsUsuariosUsers

        Private Sub frmEnvioMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            '    If Now.DayOfWeek = 5 Then
            '        MsgBox("Vie5nes")
            '        End If
            Dim dt As New DataTable
            dt = clsUser.FillClienteConMail()
            dgvMails.DataSource = dt

        End Sub
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
            Dim cls As New EnvioMail
            cls.Enviar()
        End Sub

        'Private Sub EnviarDatos(ByVal dt As DataTable)

        '    For Each o As DataRow In dt.Rows
        '        EnvioMail(o.Item(5), o.Item(3), o.Item(4))
        '        MsgBox("El Mensaje ha sido Enviado")
        '    Next
        'End Sub

        'Public Sub EnvioMail(ByVal para As String, ByVal saldo As String, ByVal fecha As String)
        '    Dim Mail As New MailMessage
        '    Dim smtp As New SmtpClient
        '    Dim saldoint As Decimal = saldo
        '    saldoint = Decimal.Round(saldoint, 2)
        '    Mail.From = New MailAddress("silviaeaguilar@hotmail.com", "Silvia Aguilar")
        '    ' Mail.To.Add("delapazangelina@hotmail.com")
        '    Mail.To.Add("silviaeaguilar@gmail.com")
        '    'Mail.To.Add(para)
        '    Mail.Subject = ("Librería de Corrientes")


        '    ' Creamos la vista para clientes que sólo pueden acceder a texto plano...
        '    Dim text As String = "Estimado Cliente nos contactammos para recordarle su cuota de $" & saldoint.ToString()
        '    text = text & " esta próxima a vencer el día: " & fecha & " , por lo que solicitamos tenga a bien abonar a la brevedad."
        '    text = text & "Ante cualquier duda o sugerencia, apreciaremos se comunique con nuestro Departamento de Cobranzas a los teléfonos "
        '    text = text & "0379 -4437234 / 0362 - 154-903906. "
        '    text = text & "Sin otro particular, saludamos a Ud. muy atentamente."
        '    text = text & "Departamento de Cobranzas - Librería de Corrientes ."
        '    Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(text, Encoding.UTF8, MediaTypeNames.Text.Plain)

        '    ' Ahora creamos la vista para clientes que  pueden mostrar contenido HTML...
        '    Dim html As String = ""
        '    html = "<table  style='width: 650px;'><tr><td><div><img src='cid:superior' /></div>"
        '    html = html & "<blockquote>Estimado Clientes: </br></br> Nos contactamos para recordarle que su cuota de $" & saldoint.ToString()
        '    html = html & " está próxima a vencer el día: " & fecha & ", por lo que solicitamos tenga a bien abonar a la brevedad. </br>"
        '    html = html & "Ante cualquier duda o sugerencia, apreciaremos se comunique con nuestro Departamento de Cobranzas a los teléfonos "
        '    html = html & "0379 -4437234 / 0362 - 154-903906. </br> " & "</blockquote>"
        '    html = html & "<blockquote>Sin otro particular, saludamos a Ud. muy atentamente. </br></blockquote>"
        '    html = html & "<h4><p align='right'>Departamento de Cobranzas - Librería de Corrientes .</p> </h4></br>"
        '    html = html & "<div align='right'><img src='cid:imagen' /></div>"
        '    'html = html & "<img src='cid:imagen' />"
        '    html = html & "</br><p><strong><font size=2>Si a la recepción de este e-mail, esta situación se hubiese regularizado, le pedimos disculpas y solicitamos no tener en cuenta el mismo</font></strong></p></br>"
        '    html = html & "<div align='right'><img src='cid:inferior' /></div></td></tr></table>"
        '    Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html)

        '    'Creamos el recurso a incrustar. Observad que el ID que le asignamos (arbitrario) está referenciado desde el código HTML como origen
        '    'de la imagen (resaltado en amarillo)...

        '    'Dim superior As LinkedResource = New LinkedResource("D:\superior.jpg", MediaTypeNames.Image.Jpeg)
        '    Dim superior As LinkedResource = New LinkedResource("C:\temp\superior.jpg")
        '    superior.ContentId = "superior"

        '    Dim img As LinkedResource = New LinkedResource("C:\temp\nuevologo.jpg", MediaTypeNames.Image.Jpeg)
        '    img.ContentId = "imagen"

        '    Dim inferior As LinkedResource = New LinkedResource("C:\temp\inferior.jpg", MediaTypeNames.Image.Jpeg)
        '    inferior.ContentId = "inferior"

        '    ' Lo incrustamos en la vista HTML...


        '    htmlView.LinkedResources.Add(superior)
        '    htmlView.LinkedResources.Add(img)
        '    htmlView.LinkedResources.Add(inferior)
        '    'Por último, vinculamos ambas vistas al mensaje...

        '    Mail.AlternateViews.Add(plainView)
        '    Mail.AlternateViews.Add(htmlView)

        '    Dim s As New SmtpClient("Smtp.live.com")
        '    s.Port = 587
        '    s.EnableSsl = True
        '    s.Credentials = New System.Net.NetworkCredential("silviaeaguilar@hotmail.com", "30644647sil()")
        '    s.Send(Mail)
        'End Sub


        'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        '    Dim cls As New EnvioMail
        '    cls.Enviar(2, 3)
        '    ' EnviarDatos(dgvMails.DataSource)
        '    'Try
        '    '    Mail.From = New MailAddress("silviaeaguilar@hotmail.com", "Silvia Aguilar")
        '    '    Mail.To.Add("silviaeaguilar@hotmail.com,santiacevedo@gmail.com,santiacevedo@hotmail.com")
        '    '    Mail.Subject = ("Prueba de mail libreia de la paz")
        '    '    Mail.Body = ("Envio de saldo")
        '    '    Dim s As New SmtpClient("Smtp.live.com")
        '    '    s.Port = 587
        '    '    s.EnableSsl = True
        '    '    s.Credentials = New System.Net.NetworkCredential("silviaeaguilar@hotmail.com", "30644647sil()")
        '    '    s.Send(Mail)
        '    '    MsgBox("El Mensaje ha sido Enviado")
        '    'Catch ex As Exception
        '    'End Try

        '    'EnvioMail("silviaeaguilar@gmail.com", "300,24")
        'End Sub
    End Class


End Namespace
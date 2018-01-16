Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Text
Public Class EnvioMail

    Public Sub Enviar()

        Dim clsUser As New clsUsuariosUsers
        Dim dt As New DataTable
        dt = clsUser.FillClienteConMail()
        'dgvMails.DataSource = dt

        EnviarDatos(dt)
    End Sub
    Public Sub EnviarPrueba()
        EnvioMailPrueba()
    End Sub
    Private Sub EnviarDatos(ByVal dt As DataTable)
        'EnvioMailPrueba()
        For Each o As DataRow In dt.Rows
            EnvioMail(o.Item(5), o.Item(3), o.Item(4), o.Item(0))
            GuardarMail(o.Item(6), o.Item(3), o.Item(5), o.Item(4))
        Next
       
    End Sub

    Private Sub GuardarMail(ByVal cliente As System.Guid, saldo As Decimal, email As String, vencimiento As DateTime)
        Dim clsuser As New clsUsuariosUsers
        clsuser.Email = New Email()
        With clsuser.Email
            .ClienteId = cliente
            .FechaEmail = Now
            .Saldo = saldo
            .Email = email
            .FechaVencimiento = vencimiento
        End With
        Try
            clsuser.IniciarTrnUsers()
            clsuser.NuevoEmail(clsuser.Email)
            clsuser.gettrnUsers.Commit()

        Catch ex As Exception
            clsuser.gettrnUsers.Rollback()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub EnvioMail(ByVal para As String, ByVal saldo As String, ByVal fecha As String, ByVal denominacion As String)
        Dim Mail As New MailMessage
        Dim smtp As New SmtpClient
        Dim saldoint As Decimal = saldo
        saldoint = Decimal.Round(saldoint, 2)
        ' Mail.From = New MailAddress("administracion@libreriactes.com.ar", "LIBRERIA DE CORRIENTES")
        Mail.From = New MailAddress("libreriadecorrientes@outlook.com", "LIBRERIA DE CORRIENTES")
        'Mail.To.Add("delapazangelina@hotmail.com")
        'Mail.To.Add("silviaeaguilar@gmail.com")
        'Mail.To.Add("santiacevedo@gmail.com")
        Mail.To.Add(para)
        Mail.Subject = ("Librería de Corrientes")


        ' Creamos la vista para clientes que sólo pueden acceder a texto plano...
        Dim text As String = "Estimado Cliente nos contactamos para recordarle que su cuota de $" & saldoint.ToString()
        text = text & " en efectivo esta próxima a vencer el día: " & fecha & " , por lo que solicitamos tenga a bien abonar a la brevedad."
        text = text & "Ante cualquier duda o sugerencia, apreciaremos se comunique con nuestro Departamento de Cobranzas a los teléfonos "
        text = text & "0379 -4437234 / 0379 - 4438732. "
        text = text & "Sin otro particular, saludamos a Ud. muy atentamente."
        text = text & "Departamento de Cobranzas - Librería de Corrientes ."
        Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(text, Encoding.UTF8, MediaTypeNames.Text.Plain)

        ' Ahora creamos la vista para clientes que  pueden mostrar contenido HTML...
        Dim html As String = ""
        'html = "<table  style='width: 650px;'><tr><td><div><img src='cid:superior' /></div>"
        html = "<table  style='width: 650px;'><tr><td><div><img src='cid:imagen' /></div>"
        html = html & "<blockquote>Estimado Cliente " & denominacion & ": </br></br>"
        html = html & "Nos contactamos para recordarle que su cuota de $" & saldoint.ToString()
        html = html & " en efectivo está próxima a vencer el día: " & fecha & ", por lo que solicitamos tenga a bien abonar a la brevedad. </br>"
        html = html & "Ante cualquier duda o sugerencia, apreciaremos se comunique con nuestro Departamento de Cobranzas a los teléfonos "
        html = html & "0379 -4437234 / 0379 - 4438732. </br> " & "</blockquote>"
        html = html & "<blockquote>Sin otro particular, saludamos a Ud. muy atentamente. </br></blockquote>"
        html = html & "<h4><p align='right'>Departamento de Cobranzas - Librería de Corrientes .</p> </h4></br>"
        'html = html & "<div align='right'><img src='cid:imagen' /></div>"
        html = html & "<blockquote></br><p><strong><font size=2>Si a la recepción de este e-mail, esta situación se hubiese regularizado, le pedimos disculpas y solicitamos no tener en cuenta el mismo</font></strong></p></br></blockquote>"
        'html = html & "<div align='right'><img src='cid:inferior' /></div></td></tr></table>"
        html = html & "</td></tr></table>"
        Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html)

        'Creamos el recurso a incrustar. Observad que el ID que le asignamos (arbitrario) está referenciado desde el código HTML como origen
        'de la imagen (resaltado en amarillo).
        Dim superior As LinkedResource = New LinkedResource("C:\temp\superior.jpg")
        superior.ContentId = "superior"

        Dim img As LinkedResource = New LinkedResource("C:\temp\nuevologo.jpg", MediaTypeNames.Image.Jpeg)
        img.ContentId = "imagen"

        Dim inferior As LinkedResource = New LinkedResource("C:\temp\inferior.jpg", MediaTypeNames.Image.Jpeg)
        inferior.ContentId = "inferior"

        ' Lo incrustamos en la vista HTML...


        htmlView.LinkedResources.Add(superior)
        htmlView.LinkedResources.Add(img)
        'htmlView.LinkedResources.Add(inferior)
        'Por último, vinculamos ambas vistas al mensaje...

        Mail.AlternateViews.Add(plainView)
        Mail.AlternateViews.Add(htmlView)


        Dim s As New SmtpClient("smtp-mail.outlook.com")
        s.Port = 587
        s.EnableSsl = True
        s.Credentials = New System.Net.NetworkCredential("libreriadecorrientes@outlook.com", "mendoza597")
        'Dim s As New SmtpClient("smtp.libreriactes.com.ar")
        's.Port = 465
        's.EnableSsl = True
        's.Credentials = New System.Net.NetworkCredential("administracion@libreriactes.com.ar", "mendoza597")
        s.Send(Mail)
    End Sub

    Public Sub EnvioMailPrueba()
        Dim Mail As New MailMessage
        Dim smtp As New SmtpClient
        Dim saldoint As Decimal = 0
        saldoint = Decimal.Round(saldoint, 2)
        ' Mail.From = New MailAddress("administracion@libreriactes.com.ar", "LIBRERIA DE CORRIENTES")
        Mail.From = New MailAddress("silviaeaguilar@gmail.com", "TIMERS EMAILS")
        'Mail.To.Add("delapazangelina@hotmail.com")
        Mail.To.Add("silviaeaguilar@gmail.com")
        'Mail.To.Add("santiacevedo@gmail.com")
        'Mail.To.Add(para)
        Mail.Subject = ("Librería de Corrientes")


        ' Creamos la vista para clientes que sólo pueden acceder a texto plano...
        Dim text As String = "Estimado Cliente nos contactamos para recordarle que su cuota de $" & saldoint.ToString()
        text = text & " en efectivo esta próxima a vencer el día:  , por lo que solicitamos tenga a bien abonar a la brevedad."
        text = text & "Ante cualquier duda o sugerencia, apreciaremos se comunique con nuestro Departamento de Cobranzas a los teléfonos "
        text = text & "0379 -4437234 / 0379 - 4438732. "
        text = text & "Sin otro particular, saludamos a Ud. muy atentamente."
        text = text & "Departamento de Cobranzas - Librería de Corrientes ."
        Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(text, Encoding.UTF8, MediaTypeNames.Text.Plain)

        ' Ahora creamos la vista para clientes que  pueden mostrar contenido HTML...
        Dim html As String = ""
        'html = "<table  style='width: 650px;'><tr><td><div><img src='cid:superior' /></div>"
        html = "<table  style='width: 650px;'><tr><td><div><img src='cid:imagen' /></div>"
        html = html & "<blockquote>Estimado Cliente : </br></br>"
        html = html & "Nos contactamos para recordarle que su cuota de $" & saldoint.ToString()
        html = html & " en efectivo está próxima a vencer el día: , por lo que solicitamos tenga a bien abonar a la brevedad. </br>"
        html = html & "Ante cualquier duda o sugerencia, apreciaremos se comunique con nuestro Departamento de Cobranzas a los teléfonos "
        html = html & "0379 -4437234 / 0379 - 4438732. </br></blockquote>"
        html = html & "<blockquote>Sin otro particular, saludamos a Ud. muy atentamente. </br></blockquote>"
        html = html & "<h4><p align='right'>Departamento de Cobranzas - Librería de Corrientes .</p> </h4></br>"
        'html = html & "<div align='right'><img src='cid:imagen' /></div>"
        html = html & "<blockquote></br><p><strong><font size=2>Si a la recepción de este e-mail, esta situación se hubiese regularizado, le pedimos disculpas y solicitamos no tener en cuenta el mismo</font></strong></p></br></blockquote>"
        'html = html & "<div align='right'><img src='cid:inferior' /></div></td></tr></table>"
        html = html & "</td></tr></table>"
        Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html)

        'Creamos el recurso a incrustar. Observad que el ID que le asignamos (arbitrario) está referenciado desde el código HTML como origen
        'de la imagen (resaltado en amarillo).
        Dim superior As LinkedResource = New LinkedResource("C:\temp\superior.jpg")
        superior.ContentId = "superior"

        Dim img As LinkedResource = New LinkedResource("C:\temp\nuevologo.jpg", MediaTypeNames.Image.Jpeg)
        img.ContentId = "imagen"

        Dim inferior As LinkedResource = New LinkedResource("C:\temp\inferior.jpg", MediaTypeNames.Image.Jpeg)
        inferior.ContentId = "inferior"

        ' Lo incrustamos en la vista HTML...


        htmlView.LinkedResources.Add(superior)
        htmlView.LinkedResources.Add(img)
        'htmlView.LinkedResources.Add(inferior)
        'Por último, vinculamos ambas vistas al mensaje...

        Mail.AlternateViews.Add(plainView)
        Mail.AlternateViews.Add(htmlView)


        Dim s As New SmtpClient("smtp.gmail.com")
        s.Port = 587
        s.EnableSsl = True
        s.Credentials = New System.Net.NetworkCredential("silviaeaguilar@gmail.com", "merceafull")
        'Dim s As New SmtpClient("smtp.libreriactes.com.ar")
        's.Port = 465
        's.EnableSsl = True
        's.Credentials = New System.Net.NetworkCredential("administracion@libreriactes.com.ar", "mendoza597")
        s.Send(Mail)
    End Sub
End Class

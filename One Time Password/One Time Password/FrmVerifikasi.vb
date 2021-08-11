Imports System.Net.Mail
Imports System.Text
Public Class FrmVerifikasi
    Dim otp As Integer
    Dim time As Integer
    Dim rd As New Random
    Dim strotp As String = ""
    Const length As Integer = 6
    Sub SentEmail()
        Dim smtpserver As New SmtpClient
        Dim email As New MailMessage

        time = 60
        Timer1.Start()
        Timer1.Interval = 1000
        smtpserver.UseDefaultCredentials = False
        smtpserver.Credentials = New Net.NetworkCredential("kevinsoon8991@gmail.com", "kxkptkpvohbarwta")
        'smtpserver.Credentials = New Net.NetworkCredential("kevinsoon8991@yahoo.com", "scunnbqebzyfjnzk")
        smtpserver.EnableSsl = True
        smtpserver.DeliveryMethod = SmtpDeliveryMethod.Network
        smtpserver.Host = "smtp.gmail.com"
        'smtpserver.Port = 25
        smtpserver.Port = 587
        'smtpserver.Port = 465
        email.From = New MailAddress("kevinsoon8991@gmail.com")
        email.To.Add(txtemail.Text)
        email.Subject = "Verification Code"

        'Randomize()
        'otp = Int(Rnd() * 1000000) + 1
        strotp = ""
        For i As Integer = 0 To length - 1
            If i = 0 Then
                strotp &= rd.Next(1, 9)
            Else
                strotp &= rd.Next(0, 9)
            End If
        Next
        otp = CInt(strotp)
        email.Body = "Below is your verification code: " & vbCrLf & otp

        Try
            smtpserver.Send(email)
            MessageBox.Show("Verification Code sent success")
        Catch ex As SmtpException
            MessageBox.Show("Verification Code sent failed, please check your internet connection")
        End Try

    End Sub
    Function code() As Integer
        Dim number As Integer
        Randomize()
        number = Int(Rnd() * 10000) + 1
        Return number
    End Function

    Private Sub FrmVerifikasi_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmlogin.Close()
    End Sub

    Private Sub FrmVerifikasi_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtemail.Text = IIf(cCurrentId = "itadmin", "kevinsoon8991@yahoo.com", email)
    End Sub

    Private Sub btnverify_Click(sender As System.Object, e As System.EventArgs) Handles btnverify.Click
        If txtemail.Text = "" Or txtotp.Text = "" Then Exit Sub
        If time <= 0 Or CInt(txtotp.Text) <> otp Then
            MessageBox.Show("Invalid OTP")
        ElseIf CInt(txtotp.Text) = otp And time > 0 Then
            MessageBox.Show("Verification Success")
            txttimeotp.Text = 0
            Timer1.Stop()
            txtotp.Clear()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        time -= 1
        txttimeotp.Text = time
        If time <= 0 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub btnrequest_Click(sender As System.Object, e As System.EventArgs) Handles btnrequest.Click
        SentEmail()
    End Sub

    Private Sub btnsend_Click(sender As System.Object, e As System.EventArgs) Handles btnsend.Click
        SentEmail()
    End Sub
End Class
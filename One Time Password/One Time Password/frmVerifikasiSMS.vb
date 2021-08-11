Imports System.Net
Imports System.IO
Public Class frmVerifikasiSMS
    Dim otp As Integer
    Dim time As Integer
    Dim rd As New Random
    Dim strotp As String = ""
    Const length As Integer = 6
    Sub SendSMS()
        Dim userid As String = "itadmin_api"
        Dim password As String = "UltimatE!7"

        time = 60
        Timer1.Start()
        Timer1.Interval = 1000
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
        Dim pesan As String = "Below is your verification code: " & vbCrLf & otp
        Dim nohp As String = txtnohp.Text


        Dim url As String = "https://api.nusasms.com/api/v3/sendsms/plain?"
        url &= "user=" & userid & "&password=" & password & "&SMSText=" & pesan & "&GSM=" & txtnohp.Text
        url &= "&output=json" & "&otp=Y"

        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"

        Dim response As WebResponse = request.GetResponse
        Dim datastream As Stream = response.GetResponseStream
        Dim reader As New StreamReader(datastream)
        Dim responseFromServer As String = reader.ReadToEnd()
        Try

            MessageBox.Show(responseFromServer)
        Catch ex As Exception
            MessageBox.Show(TryCast(response, HttpWebResponse).StatusDescription.ToString)
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


    Private Sub btnverify_Click(sender As System.Object, e As System.EventArgs) Handles btnverify.Click
        If txtnohp.Text = "" Or txtotp.Text = "" Then Exit Sub
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
        SendSMS()
    End Sub

    Private Sub btnsend_Click(sender As System.Object, e As System.EventArgs) Handles btnsend.Click
        SendSMS()
    End Sub

    Private Sub frmVerifikasiSMS_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtnohp.Text = "6281397623642"
    End Sub
End Class
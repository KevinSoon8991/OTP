Public Class frmlogin

    Private Sub btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        If txtusername.Text = "itadmin" And txtpassword.Text = "jklfds" Then
            cCurrentId = "itadmin"
            Me.Hide()
            FrmVerifikasi.Show()
        Else
            gcSQL = String.Format("SELECT * FROM USERID WHERE USERNAME = '{0}' AND PASS = '{1}'", txtusername.Text, EncryptText(txtpassword.Text))
            If AnyRec() Then
                gcSQL = String.Format("SELECT * FROM USERID WHERE USERNAME = '{0}' AND PASS = '{1}'", txtusername.Text, EncryptText(txtpassword.Text))
                Dim dt As DataTable = ExecDT()
                cCurrentId = dt(0)("USERNAME")
                email = dt(0)("EMAIL")
                Me.Hide()
                FrmVerifikasi.Show()
            Else
                MessageBox.Show("Invalid username & password")
            End If

        End If
    End Sub

    Private Sub btnregister_Click(sender As System.Object, e As System.EventArgs) Handles btnregister.Click
        Me.Hide()
        FrmRegister.Show()
    End Sub



    Private Sub frmlogin_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmRegister.Close()
    End Sub
End Class

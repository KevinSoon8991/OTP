Public Class FrmRegister

    Sub ClearData()
        txtusername.Clear()
        txtpass.Clear()
        txtrepass.Clear()
        txtemail.Clear()
    End Sub


    Private Sub FrmRegister_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        OpenConn()
    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        If txtpass.Text <> txtrepass.Text Then
            MessageBox.Show("Password value didn't match")
        Else
            gcSQL = String.Format("INSERT INTO USERID (USERNAME, PASS, EMAIL) VALUES ('{0}', '{1}', '{2}')", txtusername.Text, EncryptText(txtpass.Text), txtemail.Text)
            ExecSQL()
            MessageBox.Show("Data saved successfully")
            ClearData()
        End If
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        ClearData()
    End Sub

    Private Sub btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        Me.Hide()
        frmlogin.Show()

    End Sub
End Class
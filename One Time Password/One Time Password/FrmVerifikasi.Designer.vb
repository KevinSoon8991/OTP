<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerifikasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtotp = New System.Windows.Forms.TextBox()
        Me.btnverify = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttimeotp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnrequest = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter OTP :"
        '
        'txtotp
        '
        Me.txtotp.Location = New System.Drawing.Point(92, 44)
        Me.txtotp.Name = "txtotp"
        Me.txtotp.Size = New System.Drawing.Size(146, 20)
        Me.txtotp.TabIndex = 1
        '
        'btnverify
        '
        Me.btnverify.Location = New System.Drawing.Point(234, 100)
        Me.btnverify.Name = "btnverify"
        Me.btnverify.Size = New System.Drawing.Size(75, 23)
        Me.btnverify.TabIndex = 2
        Me.btnverify.Text = "Verify"
        Me.btnverify.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "OTP valid for"
        '
        'txttimeotp
        '
        Me.txttimeotp.AutoSize = True
        Me.txttimeotp.Location = New System.Drawing.Point(82, 74)
        Me.txttimeotp.Name = "txttimeotp"
        Me.txttimeotp.Size = New System.Drawing.Size(13, 13)
        Me.txttimeotp.TabIndex = 4
        Me.txttimeotp.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "second (s)"
        '
        'Timer1
        '
        '
        'btnrequest
        '
        Me.btnrequest.Location = New System.Drawing.Point(125, 100)
        Me.btnrequest.Name = "btnrequest"
        Me.btnrequest.Size = New System.Drawing.Size(93, 23)
        Me.btnrequest.TabIndex = 6
        Me.btnrequest.Text = "Request OTP"
        Me.btnrequest.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Didn't receive OTP ?"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(92, 15)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(146, 20)
        Me.txtemail.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email Adress :"
        '
        'btnsend
        '
        Me.btnsend.Location = New System.Drawing.Point(251, 13)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(75, 47)
        Me.btnsend.TabIndex = 10
        Me.btnsend.Text = "Send Verification Code"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'FrmVerifikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 147)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnrequest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttimeotp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnverify)
        Me.Controls.Add(Me.txtotp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmVerifikasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVerifikasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtotp As System.Windows.Forms.TextBox
    Friend WithEvents btnverify As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttimeotp As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnrequest As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnsend As System.Windows.Forms.Button
End Class

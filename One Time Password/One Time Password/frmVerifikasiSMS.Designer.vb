<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerifikasiSMS
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnrequest = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttimeotp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnverify = New System.Windows.Forms.Button()
        Me.txtotp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnsend
        '
        Me.btnsend.Location = New System.Drawing.Point(250, 4)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(75, 47)
        Me.btnsend.TabIndex = 21
        Me.btnsend.Text = "Send Verification Code"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(91, 6)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(146, 21)
        Me.txtnohp.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "No. Hp :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Didn't receive OTP ?"
        '
        'btnrequest
        '
        Me.btnrequest.Location = New System.Drawing.Point(124, 91)
        Me.btnrequest.Name = "btnrequest"
        Me.btnrequest.Size = New System.Drawing.Size(93, 23)
        Me.btnrequest.TabIndex = 17
        Me.btnrequest.Text = "Request OTP"
        Me.btnrequest.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "second (s)"
        '
        'txttimeotp
        '
        Me.txttimeotp.AutoSize = True
        Me.txttimeotp.Location = New System.Drawing.Point(81, 65)
        Me.txttimeotp.Name = "txttimeotp"
        Me.txttimeotp.Size = New System.Drawing.Size(13, 13)
        Me.txttimeotp.TabIndex = 15
        Me.txttimeotp.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "OTP valid for"
        '
        'btnverify
        '
        Me.btnverify.Location = New System.Drawing.Point(233, 91)
        Me.btnverify.Name = "btnverify"
        Me.btnverify.Size = New System.Drawing.Size(75, 23)
        Me.btnverify.TabIndex = 13
        Me.btnverify.Text = "Verify"
        Me.btnverify.UseVisualStyleBackColor = True
        '
        'txtotp
        '
        Me.txtotp.Location = New System.Drawing.Point(91, 35)
        Me.txtotp.Name = "txtotp"
        Me.txtotp.Size = New System.Drawing.Size(146, 21)
        Me.txtotp.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Enter OTP :"
        '
        'Timer1
        '
        '
        'frmVerifikasiSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 135)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnrequest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttimeotp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnverify)
        Me.Controls.Add(Me.txtotp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVerifikasiSMS"
        Me.Text = "frmVerifikasiSMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsend As System.Windows.Forms.Button
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnrequest As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttimeotp As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnverify As System.Windows.Forms.Button
    Friend WithEvents txtotp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

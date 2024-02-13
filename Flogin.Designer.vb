<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flogin
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
        Me.FloginBackground = New System.Windows.Forms.PictureBox()
        Me.BtnLogin = New System.Windows.Forms.Label()
        Me.TboxPassword = New System.Windows.Forms.TextBox()
        Me.TboxUsername = New System.Windows.Forms.TextBox()
        Me.BtnSignUp = New System.Windows.Forms.Label()
        CType(Me.FloginBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FloginBackground
        '
        Me.FloginBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FloginBackground.Image = Global.roosterTacticaltoe.My.Resources.Resources.ROOSTER_TIC_TAC_TOE_Login
        Me.FloginBackground.Location = New System.Drawing.Point(0, 0)
        Me.FloginBackground.Name = "FloginBackground"
        Me.FloginBackground.Size = New System.Drawing.Size(800, 450)
        Me.FloginBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FloginBackground.TabIndex = 0
        Me.FloginBackground.TabStop = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.BtnLogin.Font = New System.Drawing.Font("SF UI Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(485, 327)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(197, 36)
        Me.BtnLogin.TabIndex = 1
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TboxPassword
        '
        Me.TboxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.TboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TboxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TboxPassword.Location = New System.Drawing.Point(275, 281)
        Me.TboxPassword.Name = "TboxPassword"
        Me.TboxPassword.Size = New System.Drawing.Size(397, 22)
        Me.TboxPassword.TabIndex = 2
        Me.TboxPassword.Tag = "Password"
        Me.TboxPassword.UseSystemPasswordChar = True
        '
        'TboxUsername
        '
        Me.TboxUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.TboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TboxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TboxUsername.Location = New System.Drawing.Point(275, 223)
        Me.TboxUsername.Name = "TboxUsername"
        Me.TboxUsername.Size = New System.Drawing.Size(397, 22)
        Me.TboxUsername.TabIndex = 3
        Me.TboxUsername.Tag = "Username"
        '
        'BtnSignUp
        '
        Me.BtnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.BtnSignUp.Font = New System.Drawing.Font("SF UI Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignUp.Location = New System.Drawing.Point(271, 327)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(145, 36)
        Me.BtnSignUp.TabIndex = 4
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Flogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.TboxUsername)
        Me.Controls.Add(Me.TboxPassword)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.FloginBackground)
        Me.Name = "Flogin"
        CType(Me.FloginBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FloginBackground As PictureBox
    Friend WithEvents BtnLogin As Label
    Friend WithEvents TboxPassword As TextBox
    Friend WithEvents TboxUsername As TextBox
    Friend WithEvents BtnSignUp As Label
End Class

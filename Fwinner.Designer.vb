<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fwinner
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
        Me.PboxWinner = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblWinner = New System.Windows.Forms.Label()
        CType(Me.PboxWinner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PboxWinner
        '
        Me.PboxWinner.BackColor = System.Drawing.Color.Transparent
        Me.PboxWinner.Location = New System.Drawing.Point(316, 111)
        Me.PboxWinner.Name = "PboxWinner"
        Me.PboxWinner.Size = New System.Drawing.Size(208, 265)
        Me.PboxWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxWinner.TabIndex = 0
        Me.PboxWinner.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(319, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Winner!!!"
        '
        'LblWinner
        '
        Me.LblWinner.AutoSize = True
        Me.LblWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWinner.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblWinner.Location = New System.Drawing.Point(319, 60)
        Me.LblWinner.Name = "LblWinner"
        Me.LblWinner.Size = New System.Drawing.Size(0, 39)
        Me.LblWinner.TabIndex = 2
        '
        'Fwinner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.roosterTacticaltoe.My.Resources.Resources.BackgroundWinner
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.LblWinner)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PboxWinner)
        Me.Name = "Fwinner"
        Me.Text = "Fwinner"
        CType(Me.PboxWinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PboxWinner As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblWinner As Label
End Class

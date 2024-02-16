<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMainmenu
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
        Me.Btn1player = New System.Windows.Forms.Button()
        Me.Btn2Player = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn1player
        '
        Me.Btn1player.Location = New System.Drawing.Point(267, 179)
        Me.Btn1player.Name = "Btn1player"
        Me.Btn1player.Size = New System.Drawing.Size(293, 53)
        Me.Btn1player.TabIndex = 0
        Me.Btn1player.Text = "1 player"
        Me.Btn1player.UseVisualStyleBackColor = True
        '
        'Btn2Player
        '
        Me.Btn2Player.Location = New System.Drawing.Point(267, 341)
        Me.Btn2Player.Name = "Btn2Player"
        Me.Btn2Player.Size = New System.Drawing.Size(293, 53)
        Me.Btn2Player.TabIndex = 1
        Me.Btn2Player.Text = "2 players"
        Me.Btn2Player.UseVisualStyleBackColor = True
        '
        'FMainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.roosterTacticaltoe.My.Resources.Resources.BackgroundMenu
        Me.ClientSize = New System.Drawing.Size(844, 501)
        Me.Controls.Add(Me.Btn2Player)
        Me.Controls.Add(Me.Btn1player)
        Me.Name = "FMainmenu"
        Me.Text = "FMainmenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn1player As Button
    Friend WithEvents Btn2Player As Button
End Class

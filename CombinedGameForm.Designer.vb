<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CombinedGameForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.attack1 = New System.Windows.Forms.Label()
        Me.attack2 = New System.Windows.Forms.Label()
        Me.attack3 = New System.Windows.Forms.Label()
        Me.attack4 = New System.Windows.Forms.Label()
        Me.narration = New System.Windows.Forms.Label()
        Me.friendFighterImage = New System.Windows.Forms.PictureBox()
        Me.enemyFighterImage = New System.Windows.Forms.PictureBox()
        Me.levelPlayer = New System.Windows.Forms.Label()
        Me.levelEnemy = New System.Windows.Forms.Label()
        CType(Me.friendFighterImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemyFighterImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'attack1
        '
        Me.attack1.AutoSize = True
        Me.attack1.Location = New System.Drawing.Point(220, 9)
        Me.attack1.Name = "attack1"
        Me.attack1.Size = New System.Drawing.Size(39, 13)
        Me.attack1.TabIndex = 13
        Me.attack1.Text = "Label2"
        '
        'attack2
        '
        Me.attack2.AutoSize = True
        Me.attack2.Location = New System.Drawing.Point(265, 9)
        Me.attack2.Name = "attack2"
        Me.attack2.Size = New System.Drawing.Size(39, 13)
        Me.attack2.TabIndex = 14
        Me.attack2.Text = "Label3"
        '
        'attack3
        '
        Me.attack3.AutoSize = True
        Me.attack3.Location = New System.Drawing.Point(310, 9)
        Me.attack3.Name = "attack3"
        Me.attack3.Size = New System.Drawing.Size(39, 13)
        Me.attack3.TabIndex = 15
        Me.attack3.Text = "Label4"
        '
        'attack4
        '
        Me.attack4.AutoSize = True
        Me.attack4.Location = New System.Drawing.Point(355, 9)
        Me.attack4.Name = "attack4"
        Me.attack4.Size = New System.Drawing.Size(39, 13)
        Me.attack4.TabIndex = 16
        Me.attack4.Text = "Label5"
        '
        'narration
        '
        Me.narration.AutoSize = True
        Me.narration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.narration.Location = New System.Drawing.Point(157, 4)
        Me.narration.Name = "narration"
        Me.narration.Size = New System.Drawing.Size(57, 20)
        Me.narration.TabIndex = 17
        Me.narration.Text = "Label5"
        '
        'friendFighterImage
        '
        Me.friendFighterImage.Location = New System.Drawing.Point(112, 272)
        Me.friendFighterImage.Name = "friendFighterImage"
        Me.friendFighterImage.Size = New System.Drawing.Size(64, 64)
        Me.friendFighterImage.TabIndex = 18
        Me.friendFighterImage.TabStop = False
        '
        'enemyFighterImage
        '
        Me.enemyFighterImage.Location = New System.Drawing.Point(462, 272)
        Me.enemyFighterImage.Name = "enemyFighterImage"
        Me.enemyFighterImage.Size = New System.Drawing.Size(64, 64)
        Me.enemyFighterImage.TabIndex = 19
        Me.enemyFighterImage.TabStop = False
        '
        'levelPlayer
        '
        Me.levelPlayer.AutoSize = True
        Me.levelPlayer.Location = New System.Drawing.Point(14, 102)
        Me.levelPlayer.Name = "levelPlayer"
        Me.levelPlayer.Size = New System.Drawing.Size(29, 13)
        Me.levelPlayer.TabIndex = 20
        Me.levelPlayer.Text = "level"
        '
        'levelEnemy
        '
        Me.levelEnemy.AutoSize = True
        Me.levelEnemy.Location = New System.Drawing.Point(599, 102)
        Me.levelEnemy.Name = "levelEnemy"
        Me.levelEnemy.Size = New System.Drawing.Size(29, 13)
        Me.levelEnemy.TabIndex = 21
        Me.levelEnemy.Text = "level"
        '
        'CombinedGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TestOfGameModeBattleTest.My.Resources.Resources.DeForest
        Me.ClientSize = New System.Drawing.Size(640, 360)
        Me.Controls.Add(Me.levelEnemy)
        Me.Controls.Add(Me.levelPlayer)
        Me.Controls.Add(Me.enemyFighterImage)
        Me.Controls.Add(Me.friendFighterImage)
        Me.Controls.Add(Me.narration)
        Me.Controls.Add(Me.attack4)
        Me.Controls.Add(Me.attack3)
        Me.Controls.Add(Me.attack2)
        Me.Controls.Add(Me.attack1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CombinedGameForm"
        Me.Text = "CombinedGameForm"
        CType(Me.friendFighterImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemyFighterImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents attack1 As Label
    Friend WithEvents attack2 As Label
    Friend WithEvents attack3 As Label
    Friend WithEvents attack4 As Label
    Friend WithEvents narration As Label
    Friend WithEvents friendFighterImage As PictureBox
    Friend WithEvents enemyFighterImage As PictureBox
    Friend WithEvents levelPlayer As Label
    Friend WithEvents levelEnemy As Label
End Class

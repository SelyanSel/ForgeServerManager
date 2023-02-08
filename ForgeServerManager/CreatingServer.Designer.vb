<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatingServer
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreatingServer))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ProgressIndicator1 = New Guna.UI2.WinForms.Guna2ProgressIndicator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TaskBarProgress1 = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        Me.Guna2ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 100
        Me.Guna2BorderlessForm1.BorderRadius = 15
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.ForgeServerManager.My.Resources.Resources.passing_by_background
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(375, 23)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(510, 360)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-6, -3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(905, 52)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.ForgeServerManager.My.Resources.Resources.logo
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(17, 12)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(28, 28)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 0
        Me.Guna2PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Roboto", 16.75!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 56)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Please wait, we are making your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "awesome server!"
        '
        'Guna2ProgressIndicator1
        '
        Me.Guna2ProgressIndicator1.AutoStart = True
        Me.Guna2ProgressIndicator1.Location = New System.Drawing.Point(11, 331)
        Me.Guna2ProgressIndicator1.Name = "Guna2ProgressIndicator1"
        Me.Guna2ProgressIndicator1.Size = New System.Drawing.Size(28, 34)
        Me.Guna2ProgressIndicator1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Initializing..."
        '
        'Guna2TaskBarProgress1
        '
        Me.Guna2TaskBarProgress1.TargetForm = Me
        '
        'Guna2ProgressBar1
        '
        Me.Guna2ProgressBar1.BorderRadius = 5
        Me.Guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2ProgressBar1.Location = New System.Drawing.Point(12, 309)
        Me.Guna2ProgressBar1.Name = "Guna2ProgressBar1"
        Me.Guna2ProgressBar1.ProgressColor = System.Drawing.SystemColors.MenuHighlight
        Me.Guna2ProgressBar1.ProgressColor2 = System.Drawing.SystemColors.MenuHighlight
        Me.Guna2ProgressBar1.Size = New System.Drawing.Size(387, 16)
        Me.Guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.Guna2ProgressBar1.TabIndex = 6
        Me.Guna2ProgressBar1.Text = "Guna2ProgressBar1"
        Me.Guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Timer1
        '
        '
        'CreatingServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(881, 377)
        Me.Controls.Add(Me.Guna2ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ProgressIndicator1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreatingServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreatingServer"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2ProgressIndicator1 As Guna.UI2.WinForms.Guna2ProgressIndicator
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TaskBarProgress1 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents Guna2ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Timer1 As Timer
End Class

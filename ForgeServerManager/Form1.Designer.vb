<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ThanksText = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Chip1 = New Guna.UI2.WinForms.Guna2Chip()
        Me.AppContainer = New System.Windows.Forms.Panel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AppContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 100
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.ThanksText)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-7, -5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1209, 49)
        Me.Guna2Panel1.TabIndex = 0
        '
        'ThanksText
        '
        Me.ThanksText.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.ThanksText, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ThanksText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ThanksText.Location = New System.Drawing.Point(933, 20)
        Me.ThanksText.Name = "ThanksText"
        Me.ThanksText.Size = New System.Drawing.Size(52, 13)
        Me.ThanksText.TabIndex = 1
        Me.ThanksText.Text = "Thanks ;)"
        Me.ThanksText.Visible = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.ForgeServerManager.My.Resources.Resources.coffee
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(991, 12)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(142, 28)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Buy me a coffee!"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1149, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(53, 46)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.ForgeServerManager.My.Resources.Resources.logo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(17, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Guna2Transition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 1.0!
        Me.Guna2Transition1.DefaultAnimation = Animation2
        Me.Guna2Transition1.TimeStep = 0.1!
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(7, 571)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "© ForgeServerManager 2023 by Xp3rtA. This program is not affiliated in any way to" &
    " Forge."
        '
        'Guna2Chip1
        '
        Me.Guna2Chip1.AutoRoundedCorners = True
        Me.Guna2Chip1.BorderRadius = 14
        Me.Guna2Chip1.BorderThickness = 0
        Me.Guna2Transition1.SetDecoration(Me.Guna2Chip1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Chip1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Guna2Chip1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.Guna2Chip1.ForeColor = System.Drawing.Color.White
        Me.Guna2Chip1.Location = New System.Drawing.Point(865, 551)
        Me.Guna2Chip1.Name = "Guna2Chip1"
        Me.Guna2Chip1.Size = New System.Drawing.Size(318, 30)
        Me.Guna2Chip1.TabIndex = 2
        Me.Guna2Chip1.Text = "Error(s) occured. Click here to see."
        Me.Guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Chip1.TextOffset = New System.Drawing.Point(5, -1)
        Me.Guna2Chip1.Visible = False
        '
        'AppContainer
        '
        Me.AppContainer.Controls.Add(Me.Guna2Button5)
        Me.AppContainer.Controls.Add(Me.WebBrowser1)
        Me.AppContainer.Controls.Add(Me.Guna2Button4)
        Me.AppContainer.Controls.Add(Me.Guna2Button3)
        Me.AppContainer.Controls.Add(Me.Guna2Button2)
        Me.AppContainer.Controls.Add(Me.Label2)
        Me.Guna2Transition1.SetDecoration(Me.AppContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.AppContainer.Location = New System.Drawing.Point(-7, 41)
        Me.AppContainer.Name = "AppContainer"
        Me.AppContainer.Size = New System.Drawing.Size(1202, 504)
        Me.AppContainer.TabIndex = 3
        Me.AppContainer.Visible = False
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Image = Global.ForgeServerManager.My.Resources.Resources.settings
        Me.Guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.Location = New System.Drawing.Point(1011, 20)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(157, 28)
        Me.Guna2Button4.TabIndex = 4
        Me.Guna2Button4.Text = "Application Settings"
        Me.Guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Image = Global.ForgeServerManager.My.Resources.Resources.check
        Me.Guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.Location = New System.Drawing.Point(699, 20)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(125, 28)
        Me.Guna2Button3.TabIndex = 3
        Me.Guna2Button3.Text = "Launch Server"
        Me.Guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = Global.ForgeServerManager.My.Resources.Resources.settings
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(833, 20)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(168, 28)
        Me.Guna2Button2.TabIndex = 2
        Me.Guna2Button2.Text = "Edit Server Properties"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "localhost:25565"
        '
        'WebBrowser1
        '
        Me.Guna2Transition1.SetDecoration(Me.WebBrowser1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.WebBrowser1.Location = New System.Drawing.Point(34, 67)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1134, 372)
        Me.WebBrowser1.TabIndex = 5
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Animated = True
        Me.Guna2Button5.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.Location = New System.Drawing.Point(34, 454)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(70, 28)
        Me.Guna2Button5.TabIndex = 6
        Me.Guna2Button5.Text = "Go Back"
        Me.Guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1195, 593)
        Me.Controls.Add(Me.AppContainer)
        Me.Controls.Add(Me.Guna2Chip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forge Server Manager"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AppContainer.ResumeLayout(False)
        Me.AppContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ThanksText As Label
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Chip1 As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents AppContainer As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServerPath
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServerPath))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2TextBox23 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(51, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Forge Server Manager"
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
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 5
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(358, -2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(37, 37)
        Me.Guna2ControlBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(61, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 57)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hello and welcome!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To begin editing your server, we need" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a bit of information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2Button4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Guna2Button3)
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Guna2TextBox23)
        Me.Guna2Transition1.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(12, 266)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 286)
        Me.Panel1.TabIndex = 5
        Me.Panel1.Visible = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(106, 376)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(175, 32)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "Continue >>>"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        Me.Guna2Transition1.TimeStep = 0.1!
        '
        'Guna2TextBox23
        '
        Me.Guna2TextBox23.BorderRadius = 5
        Me.Guna2TextBox23.BorderThickness = 0
        Me.Guna2TextBox23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.Guna2TextBox23, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2TextBox23.DefaultText = ""
        Me.Guna2TextBox23.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox23.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox23.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox23.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox23.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2TextBox23.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox23.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Guna2TextBox23.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox23.Location = New System.Drawing.Point(17, 45)
        Me.Guna2TextBox23.Name = "Guna2TextBox23"
        Me.Guna2TextBox23.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox23.PlaceholderText = "C:\..."
        Me.Guna2TextBox23.ReadOnly = True
        Me.Guna2TextBox23.SelectedText = ""
        Me.Guna2TextBox23.Size = New System.Drawing.Size(288, 31)
        Me.Guna2TextBox23.TabIndex = 80
        Me.Guna2TextBox23.TextOffset = New System.Drawing.Point(-1, 1)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Server Path"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(311, 45)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(45, 31)
        Me.Guna2Button2.TabIndex = 81
        Me.Guna2Button2.Text = "..."
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.Enabled = False
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(83, 181)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(193, 36)
        Me.Guna2Button3.TabIndex = 82
        Me.Guna2Button3.Text = "Validate"
        Me.Guna2Button3.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(111, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 20)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Roboto", 12.75!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Username"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderRadius = 5
        Me.Guna2TextBox1.BorderThickness = 0
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(17, 111)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "AstroCookie69"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(339, 31)
        Me.Guna2TextBox1.TabIndex = 85
        Me.Guna2TextBox1.TextOffset = New System.Drawing.Point(-1, 1)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Roboto", 8.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(100, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 14)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "(not required)"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'Guna2Button4
        '
        Me.Guna2Button4.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(83, 227)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(193, 36)
        Me.Guna2Button4.TabIndex = 87
        Me.Guna2Button4.Text = "No server? Create one!"
        Me.Guna2Button4.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.ForgeServerManager.My.Resources.Resources.logo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(285, 56)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(69, 77)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.ForgeServerManager.My.Resources.Resources.up_background
        Me.PictureBox1.Location = New System.Drawing.Point(-18, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(430, 385)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ServerPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ServerPath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ServerPath"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2TextBox23 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
End Class

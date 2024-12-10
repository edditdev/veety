<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class veety_page
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(veety_page))
        Me.InfoBox1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RegistredUsersPreview = New System.Windows.Forms.Label()
        Me.InfoBox2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoggingUserPreview = New System.Windows.Forms.Label()
        Me.InfoBox3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HostedServerPreview = New System.Windows.Forms.Label()
        Me.Rg_Counter = New System.Windows.Forms.Timer(Me.components)
        Me.ColorAnimation = New Guna.UI2.WinForms.Guna2ColorTransition(Me.components)
        Me.ColorAnimationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ShowAnimation = New Guna.UI2.WinForms.Guna2Transition()
        Me.InfoBox4 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InfectedComputersPreview = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InfoBox5 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.L_Counter = New System.Windows.Forms.Timer(Me.components)
        Me.ShowingAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.S_Counter = New System.Windows.Forms.Timer(Me.components)
        Me.I_Counter = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InfoBox1.SuspendLayout()
        Me.InfoBox2.SuspendLayout()
        Me.InfoBox3.SuspendLayout()
        Me.InfoBox4.SuspendLayout()
        Me.InfoBox5.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InfoBox1
        '
        Me.InfoBox1.BackColor = System.Drawing.Color.Transparent
        Me.InfoBox1.Controls.Add(Me.PictureBox3)
        Me.InfoBox1.Controls.Add(Me.Label1)
        Me.InfoBox1.Controls.Add(Me.RegistredUsersPreview)
        Me.InfoBox1.Controls.Add(Me.PictureBox1)
        Me.ShowAnimation.SetDecoration(Me.InfoBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.InfoBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.InfoBox1.Location = New System.Drawing.Point(12, 12)
        Me.InfoBox1.Name = "InfoBox1"
        Me.InfoBox1.Radius = 5
        Me.InfoBox1.ShadowColor = System.Drawing.Color.CornflowerBlue
        Me.InfoBox1.ShadowDepth = 12
        Me.InfoBox1.ShadowShift = 12
        Me.InfoBox1.Size = New System.Drawing.Size(280, 163)
        Me.InfoBox1.TabIndex = 0
        Me.InfoBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.ShowAnimation.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(34, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Registrations in veety"
        '
        'RegistredUsersPreview
        '
        Me.RegistredUsersPreview.AutoSize = True
        Me.RegistredUsersPreview.BackColor = System.Drawing.Color.Transparent
        Me.ShowAnimation.SetDecoration(Me.RegistredUsersPreview, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.RegistredUsersPreview.Font = New System.Drawing.Font("Segoe UI Historic", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RegistredUsersPreview.ForeColor = System.Drawing.Color.White
        Me.RegistredUsersPreview.Location = New System.Drawing.Point(27, 46)
        Me.RegistredUsersPreview.Name = "RegistredUsersPreview"
        Me.RegistredUsersPreview.Size = New System.Drawing.Size(96, 51)
        Me.RegistredUsersPreview.TabIndex = 3
        Me.RegistredUsersPreview.Text = "N/A"
        '
        'InfoBox2
        '
        Me.InfoBox2.BackColor = System.Drawing.Color.Transparent
        Me.InfoBox2.Controls.Add(Me.PictureBox4)
        Me.InfoBox2.Controls.Add(Me.Label2)
        Me.InfoBox2.Controls.Add(Me.LoggingUserPreview)
        Me.InfoBox2.Controls.Add(Me.PictureBox2)
        Me.ShowAnimation.SetDecoration(Me.InfoBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.InfoBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.InfoBox2.Location = New System.Drawing.Point(298, 12)
        Me.InfoBox2.Name = "InfoBox2"
        Me.InfoBox2.Radius = 5
        Me.InfoBox2.ShadowColor = System.Drawing.Color.CornflowerBlue
        Me.InfoBox2.ShadowDepth = 12
        Me.InfoBox2.ShadowShift = 12
        Me.InfoBox2.Size = New System.Drawing.Size(280, 163)
        Me.InfoBox2.TabIndex = 1
        Me.InfoBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.ShowAnimation.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(34, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Logins in veety"
        '
        'LoggingUserPreview
        '
        Me.LoggingUserPreview.AutoSize = True
        Me.LoggingUserPreview.BackColor = System.Drawing.Color.Transparent
        Me.ShowAnimation.SetDecoration(Me.LoggingUserPreview, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoggingUserPreview.Font = New System.Drawing.Font("Segoe UI Historic", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LoggingUserPreview.ForeColor = System.Drawing.Color.White
        Me.LoggingUserPreview.Location = New System.Drawing.Point(27, 46)
        Me.LoggingUserPreview.Name = "LoggingUserPreview"
        Me.LoggingUserPreview.Size = New System.Drawing.Size(96, 51)
        Me.LoggingUserPreview.TabIndex = 5
        Me.LoggingUserPreview.Text = "N/A"
        '
        'InfoBox3
        '
        Me.InfoBox3.BackColor = System.Drawing.Color.Transparent
        Me.InfoBox3.Controls.Add(Me.PictureBox7)
        Me.InfoBox3.Controls.Add(Me.Label3)
        Me.InfoBox3.Controls.Add(Me.HostedServerPreview)
        Me.InfoBox3.Controls.Add(Me.PictureBox5)
        Me.ShowAnimation.SetDecoration(Me.InfoBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.InfoBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.InfoBox3.Location = New System.Drawing.Point(584, 12)
        Me.InfoBox3.Name = "InfoBox3"
        Me.InfoBox3.Radius = 5
        Me.InfoBox3.ShadowColor = System.Drawing.Color.CornflowerBlue
        Me.InfoBox3.ShadowDepth = 12
        Me.InfoBox3.ShadowShift = 12
        Me.InfoBox3.Size = New System.Drawing.Size(280, 163)
        Me.InfoBox3.TabIndex = 2
        Me.InfoBox3.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.ShowAnimation.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(34, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Hosted servers"
        '
        'HostedServerPreview
        '
        Me.HostedServerPreview.AutoSize = True
        Me.HostedServerPreview.BackColor = System.Drawing.Color.Transparent
        Me.ShowAnimation.SetDecoration(Me.HostedServerPreview, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HostedServerPreview.Font = New System.Drawing.Font("Segoe UI Historic", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.HostedServerPreview.ForeColor = System.Drawing.Color.White
        Me.HostedServerPreview.Location = New System.Drawing.Point(27, 46)
        Me.HostedServerPreview.Name = "HostedServerPreview"
        Me.HostedServerPreview.Size = New System.Drawing.Size(96, 51)
        Me.HostedServerPreview.TabIndex = 8
        Me.HostedServerPreview.Text = "N/A"
        '
        'Rg_Counter
        '
        Me.Rg_Counter.Interval = 60
        '
        'ColorAnimation
        '
        Me.ColorAnimation.AutoTransition = True
        Me.ColorAnimation.ColorArray = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.CornflowerBlue}
        Me.ColorAnimation.EndColor = System.Drawing.Color.White
        Me.ColorAnimation.StartColor = System.Drawing.Color.White
        '
        'ColorAnimationTimer
        '
        Me.ColorAnimationTimer.Enabled = True
        Me.ColorAnimationTimer.Interval = 10
        '
        'ShowAnimation
        '
        Me.ShowAnimation.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.ShowAnimation.Cursor = Nothing
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
        Me.ShowAnimation.DefaultAnimation = Animation1
        '
        'InfoBox4
        '
        Me.InfoBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoBox4.BackColor = System.Drawing.Color.Transparent
        Me.InfoBox4.Controls.Add(Me.PictureBox8)
        Me.InfoBox4.Controls.Add(Me.Label5)
        Me.InfoBox4.Controls.Add(Me.InfectedComputersPreview)
        Me.InfoBox4.Controls.Add(Me.PictureBox6)
        Me.ShowAnimation.SetDecoration(Me.InfoBox4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.InfoBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.InfoBox4.Location = New System.Drawing.Point(870, 12)
        Me.InfoBox4.Name = "InfoBox4"
        Me.InfoBox4.Radius = 5
        Me.InfoBox4.ShadowColor = System.Drawing.Color.CornflowerBlue
        Me.InfoBox4.ShadowDepth = 12
        Me.InfoBox4.ShadowShift = 12
        Me.InfoBox4.Size = New System.Drawing.Size(347, 163)
        Me.InfoBox4.TabIndex = 3
        Me.InfoBox4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.ShowAnimation.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(34, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Infected computers"
        '
        'InfectedComputersPreview
        '
        Me.InfectedComputersPreview.AutoSize = True
        Me.InfectedComputersPreview.BackColor = System.Drawing.Color.Transparent
        Me.ShowAnimation.SetDecoration(Me.InfectedComputersPreview, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.InfectedComputersPreview.Font = New System.Drawing.Font("Segoe UI Historic", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.InfectedComputersPreview.ForeColor = System.Drawing.Color.White
        Me.InfectedComputersPreview.Location = New System.Drawing.Point(27, 46)
        Me.InfectedComputersPreview.Name = "InfectedComputersPreview"
        Me.InfectedComputersPreview.Size = New System.Drawing.Size(96, 51)
        Me.InfectedComputersPreview.TabIndex = 8
        Me.InfectedComputersPreview.Text = "N/A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.ShowAnimation.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(12, 667)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 14)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "VEETY | 2018-2024 All rights reserved."
        '
        'InfoBox5
        '
        Me.InfoBox5.BackColor = System.Drawing.Color.Transparent
        Me.InfoBox5.Controls.Add(Me.Label9)
        Me.InfoBox5.Controls.Add(Me.Guna2Panel1)
        Me.ShowAnimation.SetDecoration(Me.InfoBox5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.InfoBox5.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.InfoBox5.Location = New System.Drawing.Point(12, 181)
        Me.InfoBox5.Name = "InfoBox5"
        Me.InfoBox5.Radius = 5
        Me.InfoBox5.ShadowColor = System.Drawing.Color.CornflowerBlue
        Me.InfoBox5.ShadowDepth = 12
        Me.InfoBox5.ShadowShift = 12
        Me.InfoBox5.Size = New System.Drawing.Size(599, 458)
        Me.InfoBox5.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ShowAnimation.SetDecoration(Me.Label9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SlateGray
        Me.Label9.Location = New System.Drawing.Point(23, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(552, 374)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.ShowAnimation.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 11)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(575, 42)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ShowAnimation.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label6.Location = New System.Drawing.Point(8, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "LATEST CHANGELOG"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.ShowAnimation.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 11)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(575, 42)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ShowAnimation.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label7.Location = New System.Drawing.Point(8, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "NEWS IN VEETY"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label8)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Panel2)
        Me.ShowAnimation.SetDecoration(Me.Guna2ShadowPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(618, 181)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 5
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2ShadowPanel1.ShadowDepth = 12
        Me.Guna2ShadowPanel1.ShadowShift = 12
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(599, 458)
        Me.Guna2ShadowPanel1.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ShowAnimation.SetDecoration(Me.Label8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.SlateGray
        Me.Label8.Location = New System.Drawing.Point(23, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(552, 374)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "We are back with updates" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New UI Design"
        '
        'L_Counter
        '
        '
        'ShowingAnimation
        '
        Me.ShowingAnimation.Enabled = True
        '
        'S_Counter
        '
        Me.S_Counter.Interval = 70
        '
        'I_Counter
        '
        Me.I_Counter.Interval = 90
        '
        'PictureBox9
        '
        Me.ShowAnimation.SetDecoration(Me.PictureBox9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox9.Image = Global.veety.My.Resources.Resources.Webpage
        Me.PictureBox9.Location = New System.Drawing.Point(1163, 654)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 15
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.ShowAnimation.SetDecoration(Me.PictureBox10, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox10.Image = Global.veety.My.Resources.Resources.Discord
        Me.PictureBox10.Location = New System.Drawing.Point(1193, 654)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 14
        Me.PictureBox10.TabStop = False
        '
        'PictureBox8
        '
        Me.ShowAnimation.SetDecoration(Me.PictureBox8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox8.Image = Global.veety.My.Resources.Resources.Coronavirus
        Me.PictureBox8.Location = New System.Drawing.Point(290, 30)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 12
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ShowAnimation.SetDecoration(Me.PictureBox6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(18, 17)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(307, 128)
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.ShowAnimation.SetDecoration(Me.PictureBox7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox7.Image = Global.veety.My.Resources.Resources.Switch_Host
        Me.PictureBox7.Location = New System.Drawing.Point(227, 30)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 11
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ShowAnimation.SetDecoration(Me.PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(18, 17)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(244, 128)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.ShowAnimation.SetDecoration(Me.PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox4.Image = Global.veety.My.Resources.Resources.Login
        Me.PictureBox4.Location = New System.Drawing.Point(227, 30)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ShowAnimation.SetDecoration(Me.PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(244, 128)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.ShowAnimation.SetDecoration(Me.PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox3.Image = Global.veety.My.Resources.Resources.Group
        Me.PictureBox3.Location = New System.Drawing.Point(227, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ShowAnimation.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.veety.My.Resources.Resources.p11
        Me.PictureBox1.Location = New System.Drawing.Point(18, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 128)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'veety_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1229, 690)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.InfoBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.InfoBox4)
        Me.Controls.Add(Me.InfoBox3)
        Me.Controls.Add(Me.InfoBox2)
        Me.Controls.Add(Me.InfoBox1)
        Me.ShowAnimation.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "veety_page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "veety_page"
        Me.InfoBox1.ResumeLayout(False)
        Me.InfoBox1.PerformLayout()
        Me.InfoBox2.ResumeLayout(False)
        Me.InfoBox2.PerformLayout()
        Me.InfoBox3.ResumeLayout(False)
        Me.InfoBox3.PerformLayout()
        Me.InfoBox4.ResumeLayout(False)
        Me.InfoBox4.PerformLayout()
        Me.InfoBox5.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InfoBox1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents RegistredUsersPreview As Label
    Friend WithEvents InfoBox2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents InfoBox3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Rg_Counter As Timer
    Friend WithEvents ColorAnimation As Guna.UI2.WinForms.Guna2ColorTransition
    Friend WithEvents ColorAnimationTimer As Timer
    Friend WithEvents ShowAnimation As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LoggingUserPreview As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents L_Counter As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HostedServerPreview As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents InfoBox4 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents InfectedComputersPreview As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents ShowingAnimation As Timer
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents InfoBox5 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents S_Counter As Timer
    Friend WithEvents I_Counter As Timer
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class

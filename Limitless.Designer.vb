<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.TitleBarIcon = New System.Windows.Forms.Panel()
        Me.MinimizeButton = New System.Windows.Forms.Panel()
        Me.MinimizeText = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.MainMenuPanel = New System.Windows.Forms.Panel()
        Me.MainMenuBar = New System.Windows.Forms.Panel()
        Me.NullButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.OptionsButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.UpdatePanel = New System.Windows.Forms.Panel()
        Me.UpdateAvaBox = New System.Windows.Forms.TextBox()
        Me.UpdateCurBox = New System.Windows.Forms.TextBox()
        Me.UpdateInstallButton = New System.Windows.Forms.Button()
        Me.UpdateAvaText = New System.Windows.Forms.Label()
        Me.UpdateCurText = New System.Windows.Forms.Label()
        Me.UpdateSubText = New System.Windows.Forms.Label()
        Me.UpdateTitleText = New System.Windows.Forms.Label()
        Me.WelcomePanel = New System.Windows.Forms.Panel()
        Me.WelcomeImage11 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage10 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage09 = New System.Windows.Forms.PictureBox()
        Me.WelcomeLogo = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage06 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage07 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage08 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage00 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage01 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage02 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage03 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage04 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage05 = New System.Windows.Forms.PictureBox()
        Me.FooterPanel = New System.Windows.Forms.Panel()
        Me.MenuTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.TitleBarPanel.SuspendLayout()
        Me.MinimizeButton.SuspendLayout()
        Me.CloseButton.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.MainMenuPanel.SuspendLayout()
        Me.MainMenuBar.SuspendLayout()
        Me.UpdatePanel.SuspendLayout()
        Me.WelcomePanel.SuspendLayout()
        CType(Me.WelcomeImage11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage09, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage08, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage05, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TitleLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TitleLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TitleLabel.Location = New System.Drawing.Point(549, 7)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(268, 13)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Limitless [ALPHA v#.#.#.####]"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleBarPanel
        '
        Me.TitleBarPanel.BackColor = System.Drawing.Color.DarkBlue
        Me.TitleBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TitleBarPanel.Controls.Add(Me.TitleBarIcon)
        Me.TitleBarPanel.Controls.Add(Me.MinimizeButton)
        Me.TitleBarPanel.Controls.Add(Me.CloseButton)
        Me.TitleBarPanel.Controls.Add(Me.TitleLabel)
        Me.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarPanel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TitleBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.TitleBarPanel.Name = "TitleBarPanel"
        Me.TitleBarPanel.Size = New System.Drawing.Size(1366, 30)
        Me.TitleBarPanel.TabIndex = 1
        '
        'TitleBarIcon
        '
        Me.TitleBarIcon.BackgroundImage = CType(resources.GetObject("TitleBarIcon.BackgroundImage"), System.Drawing.Image)
        Me.TitleBarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitleBarIcon.Location = New System.Drawing.Point(-25, 0)
        Me.TitleBarIcon.Name = "TitleBarIcon"
        Me.TitleBarIcon.Size = New System.Drawing.Size(147, 25)
        Me.TitleBarIcon.TabIndex = 3
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.MinimizeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MinimizeButton.Controls.Add(Me.MinimizeText)
        Me.MinimizeButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.MinimizeButton.Location = New System.Drawing.Point(1314, 4)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(20, 17)
        Me.MinimizeButton.TabIndex = 2
        '
        'MinimizeText
        '
        Me.MinimizeText.AutoSize = True
        Me.MinimizeText.BackColor = System.Drawing.Color.DarkBlue
        Me.MinimizeText.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MinimizeText.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.MinimizeText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MinimizeText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MinimizeText.Location = New System.Drawing.Point(0, 0)
        Me.MinimizeText.Name = "MinimizeText"
        Me.MinimizeText.Size = New System.Drawing.Size(17, 15)
        Me.MinimizeText.TabIndex = 0
        Me.MinimizeText.Text = "_"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButton.Controls.Add(Me.CloseText)
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CloseButton.Location = New System.Drawing.Point(1339, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 17)
        Me.CloseButton.TabIndex = 1
        '
        'CloseText
        '
        Me.CloseText.AutoSize = True
        Me.CloseText.BackColor = System.Drawing.Color.DarkBlue
        Me.CloseText.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CloseText.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CloseText.ForeColor = System.Drawing.Color.Gainsboro
        Me.CloseText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CloseText.Location = New System.Drawing.Point(0, 0)
        Me.CloseText.Name = "CloseText"
        Me.CloseText.Size = New System.Drawing.Size(17, 15)
        Me.CloseText.TabIndex = 1
        Me.CloseText.Text = "X"
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BackgroundPanel.Controls.Add(Me.MainMenuPanel)
        Me.BackgroundPanel.Controls.Add(Me.FooterPanel)
        Me.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundPanel.Location = New System.Drawing.Point(0, 30)
        Me.BackgroundPanel.Name = "BackgroundPanel"
        Me.BackgroundPanel.Size = New System.Drawing.Size(1366, 738)
        Me.BackgroundPanel.TabIndex = 2
        '
        'MainMenuPanel
        '
        Me.MainMenuPanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuPanel.Controls.Add(Me.MainMenuBar)
        Me.MainMenuPanel.Controls.Add(Me.UpdatePanel)
        Me.MainMenuPanel.Controls.Add(Me.WelcomePanel)
        Me.MainMenuPanel.Location = New System.Drawing.Point(15, 11)
        Me.MainMenuPanel.Name = "MainMenuPanel"
        Me.MainMenuPanel.Size = New System.Drawing.Size(1332, 673)
        Me.MainMenuPanel.TabIndex = 0
        '
        'MainMenuBar
        '
        Me.MainMenuBar.BackColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuBar.BackgroundImage = CType(resources.GetObject("MainMenuBar.BackgroundImage"), System.Drawing.Image)
        Me.MainMenuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainMenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainMenuBar.Controls.Add(Me.NullButton)
        Me.MainMenuBar.Controls.Add(Me.SaveButton)
        Me.MainMenuBar.Controls.Add(Me.ExitButton)
        Me.MainMenuBar.Controls.Add(Me.UpdateButton)
        Me.MainMenuBar.Controls.Add(Me.AboutButton)
        Me.MainMenuBar.Controls.Add(Me.OptionsButton)
        Me.MainMenuBar.Controls.Add(Me.EditButton)
        Me.MainMenuBar.Controls.Add(Me.LoadButton)
        Me.MainMenuBar.Controls.Add(Me.StartButton)
        Me.MainMenuBar.Controls.Add(Me.BackButton)
        Me.MainMenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuBar.Name = "MainMenuBar"
        Me.MainMenuBar.Size = New System.Drawing.Size(63, 673)
        Me.MainMenuBar.TabIndex = 1
        '
        'NullButton
        '
        Me.NullButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.NullButton.BackgroundImage = CType(resources.GetObject("NullButton.BackgroundImage"), System.Drawing.Image)
        Me.NullButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NullButton.Enabled = False
        Me.NullButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NullButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.NullButton.Location = New System.Drawing.Point(10, 285)
        Me.NullButton.Name = "NullButton"
        Me.NullButton.Size = New System.Drawing.Size(40, 40)
        Me.NullButton.TabIndex = 5
        Me.MenuTips.SetToolTip(Me.NullButton, "No Function")
        Me.NullButton.UseVisualStyleBackColor = False
        Me.NullButton.Visible = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.SaveButton.BackgroundImage = CType(resources.GetObject("SaveButton.BackgroundImage"), System.Drawing.Image)
        Me.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveButton.Enabled = False
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.SaveButton.Location = New System.Drawing.Point(10, 350)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(40, 40)
        Me.SaveButton.TabIndex = 4
        Me.MenuTips.SetToolTip(Me.SaveButton, "Save Your Game")
        Me.SaveButton.UseVisualStyleBackColor = False
        Me.SaveButton.Visible = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ExitButton.Location = New System.Drawing.Point(10, 610)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(40, 40)
        Me.ExitButton.TabIndex = 9
        Me.MenuTips.SetToolTip(Me.ExitButton, "Exit The Game")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.UpdateButton.BackgroundImage = CType(resources.GetObject("UpdateButton.BackgroundImage"), System.Drawing.Image)
        Me.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.Control
        Me.UpdateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UpdateButton.Location = New System.Drawing.Point(10, 480)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(40, 40)
        Me.UpdateButton.TabIndex = 7
        Me.MenuTips.SetToolTip(Me.UpdateButton, "Check For Updates")
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'AboutButton
        '
        Me.AboutButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.AboutButton.BackgroundImage = CType(resources.GetObject("AboutButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.AboutButton.ForeColor = System.Drawing.SystemColors.Control
        Me.AboutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutButton.Location = New System.Drawing.Point(10, 545)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(40, 40)
        Me.AboutButton.TabIndex = 8
        Me.MenuTips.SetToolTip(Me.AboutButton, "About Limitless")
        Me.AboutButton.UseVisualStyleBackColor = False
        '
        'OptionsButton
        '
        Me.OptionsButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.OptionsButton.BackgroundImage = CType(resources.GetObject("OptionsButton.BackgroundImage"), System.Drawing.Image)
        Me.OptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OptionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.OptionsButton.ForeColor = System.Drawing.SystemColors.Control
        Me.OptionsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OptionsButton.Location = New System.Drawing.Point(10, 415)
        Me.OptionsButton.Name = "OptionsButton"
        Me.OptionsButton.Size = New System.Drawing.Size(40, 40)
        Me.OptionsButton.TabIndex = 3
        Me.MenuTips.SetToolTip(Me.OptionsButton, "Options Menu")
        Me.OptionsButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.EditButton.BackgroundImage = CType(resources.GetObject("EditButton.BackgroundImage"), System.Drawing.Image)
        Me.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditButton.Enabled = False
        Me.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditButton.ForeColor = System.Drawing.SystemColors.Control
        Me.EditButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EditButton.Location = New System.Drawing.Point(10, 220)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(40, 40)
        Me.EditButton.TabIndex = 2
        Me.MenuTips.SetToolTip(Me.EditButton, "Limitless Editor")
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'LoadButton
        '
        Me.LoadButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.LoadButton.BackgroundImage = CType(resources.GetObject("LoadButton.BackgroundImage"), System.Drawing.Image)
        Me.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoadButton.Enabled = False
        Me.LoadButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.LoadButton.ForeColor = System.Drawing.SystemColors.Control
        Me.LoadButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LoadButton.Location = New System.Drawing.Point(10, 155)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(40, 40)
        Me.LoadButton.TabIndex = 1
        Me.MenuTips.SetToolTip(Me.LoadButton, "Load Saved Game")
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'StartButton
        '
        Me.StartButton.AccessibleDescription = ""
        Me.StartButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.StartButton.BackgroundImage = CType(resources.GetObject("StartButton.BackgroundImage"), System.Drawing.Image)
        Me.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.StartButton.ForeColor = System.Drawing.SystemColors.Control
        Me.StartButton.Location = New System.Drawing.Point(10, 90)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(40, 40)
        Me.StartButton.TabIndex = 0
        Me.MenuTips.SetToolTip(Me.StartButton, "Start a New Game")
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.BackButton.ForeColor = System.Drawing.SystemColors.Control
        Me.BackButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BackButton.Location = New System.Drawing.Point(10, 25)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(40, 40)
        Me.BackButton.TabIndex = 6
        Me.MenuTips.SetToolTip(Me.BackButton, "Back To Main Menu")
        Me.BackButton.UseVisualStyleBackColor = False
        Me.BackButton.Visible = False
        '
        'UpdatePanel
        '
        Me.UpdatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UpdatePanel.Controls.Add(Me.UpdateAvaBox)
        Me.UpdatePanel.Controls.Add(Me.UpdateCurBox)
        Me.UpdatePanel.Controls.Add(Me.UpdateInstallButton)
        Me.UpdatePanel.Controls.Add(Me.UpdateAvaText)
        Me.UpdatePanel.Controls.Add(Me.UpdateCurText)
        Me.UpdatePanel.Controls.Add(Me.UpdateSubText)
        Me.UpdatePanel.Controls.Add(Me.UpdateTitleText)
        Me.UpdatePanel.Location = New System.Drawing.Point(75, 10)
        Me.UpdatePanel.Name = "UpdatePanel"
        Me.UpdatePanel.Size = New System.Drawing.Size(1240, 650)
        Me.UpdatePanel.TabIndex = 10
        Me.UpdatePanel.Visible = False
        '
        'UpdateAvaBox
        '
        Me.UpdateAvaBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.UpdateAvaBox.ForeColor = System.Drawing.SystemColors.Window
        Me.UpdateAvaBox.Location = New System.Drawing.Point(655, 255)
        Me.UpdateAvaBox.Name = "UpdateAvaBox"
        Me.UpdateAvaBox.ReadOnly = True
        Me.UpdateAvaBox.Size = New System.Drawing.Size(150, 20)
        Me.UpdateAvaBox.TabIndex = 6
        Me.UpdateAvaBox.TabStop = False
        '
        'UpdateCurBox
        '
        Me.UpdateCurBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.UpdateCurBox.ForeColor = System.Drawing.SystemColors.Window
        Me.UpdateCurBox.Location = New System.Drawing.Point(655, 205)
        Me.UpdateCurBox.Name = "UpdateCurBox"
        Me.UpdateCurBox.ReadOnly = True
        Me.UpdateCurBox.Size = New System.Drawing.Size(150, 20)
        Me.UpdateCurBox.TabIndex = 5
        Me.UpdateCurBox.TabStop = False
        '
        'UpdateInstallButton
        '
        Me.UpdateInstallButton.Enabled = False
        Me.UpdateInstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateInstallButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.UpdateInstallButton.Location = New System.Drawing.Point(565, 360)
        Me.UpdateInstallButton.Name = "UpdateInstallButton"
        Me.UpdateInstallButton.Size = New System.Drawing.Size(150, 23)
        Me.UpdateInstallButton.TabIndex = 4
        Me.UpdateInstallButton.Text = "Install Update"
        Me.UpdateInstallButton.UseVisualStyleBackColor = True
        '
        'UpdateAvaText
        '
        Me.UpdateAvaText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UpdateAvaText.Location = New System.Drawing.Point(460, 260)
        Me.UpdateAvaText.Name = "UpdateAvaText"
        Me.UpdateAvaText.Size = New System.Drawing.Size(160, 13)
        Me.UpdateAvaText.TabIndex = 3
        Me.UpdateAvaText.Text = "Available Version:"
        Me.UpdateAvaText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UpdateCurText
        '
        Me.UpdateCurText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UpdateCurText.Location = New System.Drawing.Point(460, 210)
        Me.UpdateCurText.Name = "UpdateCurText"
        Me.UpdateCurText.Size = New System.Drawing.Size(160, 13)
        Me.UpdateCurText.TabIndex = 2
        Me.UpdateCurText.Text = "Installed Version:"
        Me.UpdateCurText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UpdateSubText
        '
        Me.UpdateSubText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UpdateSubText.Location = New System.Drawing.Point(3, 110)
        Me.UpdateSubText.Name = "UpdateSubText"
        Me.UpdateSubText.Size = New System.Drawing.Size(1234, 13)
        Me.UpdateSubText.TabIndex = 1
        Me.UpdateSubText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpdateTitleText
        '
        Me.UpdateTitleText.Font = New System.Drawing.Font("Lucida Console", 24.0!, System.Drawing.FontStyle.Bold)
        Me.UpdateTitleText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UpdateTitleText.Location = New System.Drawing.Point(0, 0)
        Me.UpdateTitleText.Name = "UpdateTitleText"
        Me.UpdateTitleText.Size = New System.Drawing.Size(1234, 32)
        Me.UpdateTitleText.TabIndex = 0
        Me.UpdateTitleText.Text = "Check For Updates"
        Me.UpdateTitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WelcomePanel
        '
        Me.WelcomePanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.WelcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.WelcomePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage11)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage10)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage09)
        Me.WelcomePanel.Controls.Add(Me.WelcomeLogo)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage06)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage07)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage08)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage00)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage01)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage02)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage03)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage04)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage05)
        Me.WelcomePanel.Location = New System.Drawing.Point(75, 10)
        Me.WelcomePanel.Name = "WelcomePanel"
        Me.WelcomePanel.Size = New System.Drawing.Size(1240, 650)
        Me.WelcomePanel.TabIndex = 2
        '
        'WelcomeImage11
        '
        Me.WelcomeImage11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage11.Location = New System.Drawing.Point(744, 443)
        Me.WelcomeImage11.Name = "WelcomeImage11"
        Me.WelcomeImage11.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage11.TabIndex = 11
        Me.WelcomeImage11.TabStop = False
        Me.WelcomeImage11.Visible = False
        '
        'WelcomeImage10
        '
        Me.WelcomeImage10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage10.Location = New System.Drawing.Point(395, 443)
        Me.WelcomeImage10.Name = "WelcomeImage10"
        Me.WelcomeImage10.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage10.TabIndex = 10
        Me.WelcomeImage10.TabStop = False
        Me.WelcomeImage10.Visible = False
        '
        'WelcomeImage09
        '
        Me.WelcomeImage09.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage09.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage09.Location = New System.Drawing.Point(44, 443)
        Me.WelcomeImage09.Name = "WelcomeImage09"
        Me.WelcomeImage09.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage09.TabIndex = 9
        Me.WelcomeImage09.TabStop = False
        Me.WelcomeImage09.Visible = False
        '
        'WelcomeLogo
        '
        Me.WelcomeLogo.BackgroundImage = CType(resources.GetObject("WelcomeLogo.BackgroundImage"), System.Drawing.Image)
        Me.WelcomeLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.WelcomeLogo.Location = New System.Drawing.Point(304, 3)
        Me.WelcomeLogo.Name = "WelcomeLogo"
        Me.WelcomeLogo.Size = New System.Drawing.Size(590, 100)
        Me.WelcomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WelcomeLogo.TabIndex = 12
        Me.WelcomeLogo.TabStop = False
        '
        'WelcomeImage06
        '
        Me.WelcomeImage06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage06.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage06.Location = New System.Drawing.Point(109, 333)
        Me.WelcomeImage06.Name = "WelcomeImage06"
        Me.WelcomeImage06.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage06.TabIndex = 6
        Me.WelcomeImage06.TabStop = False
        Me.WelcomeImage06.Visible = False
        '
        'WelcomeImage07
        '
        Me.WelcomeImage07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage07.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage07.Location = New System.Drawing.Point(459, 333)
        Me.WelcomeImage07.Name = "WelcomeImage07"
        Me.WelcomeImage07.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage07.TabIndex = 7
        Me.WelcomeImage07.TabStop = False
        Me.WelcomeImage07.Visible = False
        '
        'WelcomeImage08
        '
        Me.WelcomeImage08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage08.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage08.Location = New System.Drawing.Point(809, 333)
        Me.WelcomeImage08.Name = "WelcomeImage08"
        Me.WelcomeImage08.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage08.TabIndex = 8
        Me.WelcomeImage08.TabStop = False
        Me.WelcomeImage08.Visible = False
        '
        'WelcomeImage00
        '
        Me.WelcomeImage00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage00.Location = New System.Drawing.Point(174, 223)
        Me.WelcomeImage00.Name = "WelcomeImage00"
        Me.WelcomeImage00.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage00.TabIndex = 0
        Me.WelcomeImage00.TabStop = False
        Me.WelcomeImage00.Visible = False
        '
        'WelcomeImage01
        '
        Me.WelcomeImage01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage01.Location = New System.Drawing.Point(524, 223)
        Me.WelcomeImage01.Name = "WelcomeImage01"
        Me.WelcomeImage01.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage01.TabIndex = 1
        Me.WelcomeImage01.TabStop = False
        Me.WelcomeImage01.Visible = False
        '
        'WelcomeImage02
        '
        Me.WelcomeImage02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage02.Location = New System.Drawing.Point(874, 223)
        Me.WelcomeImage02.Name = "WelcomeImage02"
        Me.WelcomeImage02.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage02.TabIndex = 2
        Me.WelcomeImage02.TabStop = False
        Me.WelcomeImage02.Visible = False
        '
        'WelcomeImage03
        '
        Me.WelcomeImage03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage03.Location = New System.Drawing.Point(239, 113)
        Me.WelcomeImage03.Name = "WelcomeImage03"
        Me.WelcomeImage03.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage03.TabIndex = 3
        Me.WelcomeImage03.TabStop = False
        Me.WelcomeImage03.Visible = False
        '
        'WelcomeImage04
        '
        Me.WelcomeImage04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage04.Location = New System.Drawing.Point(589, 113)
        Me.WelcomeImage04.Name = "WelcomeImage04"
        Me.WelcomeImage04.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage04.TabIndex = 4
        Me.WelcomeImage04.TabStop = False
        Me.WelcomeImage04.Visible = False
        '
        'WelcomeImage05
        '
        Me.WelcomeImage05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WelcomeImage05.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WelcomeImage05.Location = New System.Drawing.Point(939, 113)
        Me.WelcomeImage05.Name = "WelcomeImage05"
        Me.WelcomeImage05.Size = New System.Drawing.Size(200, 200)
        Me.WelcomeImage05.TabIndex = 5
        Me.WelcomeImage05.TabStop = False
        Me.WelcomeImage05.Visible = False
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.FooterPanel.Location = New System.Drawing.Point(15, 684)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(1332, 35)
        Me.FooterPanel.TabIndex = 1
        '
        'MainWindow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Limitless"
        Me.TitleBarPanel.ResumeLayout(False)
        Me.TitleBarPanel.PerformLayout()
        Me.MinimizeButton.ResumeLayout(False)
        Me.MinimizeButton.PerformLayout()
        Me.CloseButton.ResumeLayout(False)
        Me.CloseButton.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.MainMenuPanel.ResumeLayout(False)
        Me.MainMenuBar.ResumeLayout(False)
        Me.UpdatePanel.ResumeLayout(False)
        Me.UpdatePanel.PerformLayout()
        Me.WelcomePanel.ResumeLayout(False)
        CType(Me.WelcomeImage11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage09, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage08, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage05, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84



    Friend WithEvents TitleLabel As Label
    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents MinimizeButton As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents MinimizeText As Label
    Friend WithEvents CloseText As Label
    Friend WithEvents TitleBarIcon As Panel
    Friend WithEvents MainMenuPanel As Panel
    Friend WithEvents FooterPanel As Panel
    Friend WithEvents MainMenuBar As Panel
    Friend WithEvents WelcomePanel As Panel
    Friend WithEvents WelcomeImage00 As PictureBox
    Friend WithEvents WelcomeImage01 As PictureBox
    Friend WithEvents WelcomeImage02 As PictureBox
    Friend WithEvents WelcomeImage04 As PictureBox
    Friend WithEvents WelcomeImage03 As PictureBox
    Friend WithEvents StartButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents LoadButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents OptionsButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents MenuTips As ToolTip
    Friend WithEvents UpdatePanel As Panel
    Friend WithEvents UpdateSubText As Label
    Friend WithEvents UpdateTitleText As Label
    Friend WithEvents UpdateAvaText As Label
    Friend WithEvents UpdateCurText As Label
    Friend WithEvents UpdateInstallButton As Button
    Friend WithEvents UpdateAvaBox As TextBox
    Friend WithEvents UpdateCurBox As TextBox
    Friend WithEvents WelcomeImage06 As PictureBox
    Friend WithEvents WelcomeImage05 As PictureBox
    Friend WithEvents WelcomeImage10 As PictureBox
    Friend WithEvents WelcomeImage07 As PictureBox
    Friend WithEvents WelcomeImage08 As PictureBox
    Friend WithEvents WelcomeImage09 As PictureBox
    Friend WithEvents WelcomeImage11 As PictureBox
    Friend WithEvents WelcomeLogo As PictureBox
    Friend WithEvents BackButton As Button
    Friend WithEvents NullButton As Button
End Class

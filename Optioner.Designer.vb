<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Optioner
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
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.OptionsPanel = New System.Windows.Forms.Panel()
        Me.OptionsDeleteButton = New System.Windows.Forms.Button()
        Me.OptionsMainPanel = New System.Windows.Forms.Panel()
        Me.SoundsPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DBPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MusicPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColorsPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AvatarPanel = New System.Windows.Forms.Panel()
        Me.AvatarText = New System.Windows.Forms.Label()
        Me.AvatarImage = New System.Windows.Forms.PictureBox()
        Me.DimText = New System.Windows.Forms.Label()
        Me.DimLabel = New System.Windows.Forms.Label()
        Me.SoundsText = New System.Windows.Forms.Label()
        Me.MusicText = New System.Windows.Forms.Label()
        Me.DBText = New System.Windows.Forms.Label()
        Me.ColorText = New System.Windows.Forms.Label()
        Me.VersionText = New System.Windows.Forms.Label()
        Me.SystemText = New System.Windows.Forms.Label()
        Me.SoundsLabel = New System.Windows.Forms.Label()
        Me.MusicLabel = New System.Windows.Forms.Label()
        Me.DBLabel = New System.Windows.Forms.Label()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.SystemLabel = New System.Windows.Forms.Label()
        Me.OptionsRenameButton = New System.Windows.Forms.Button()
        Me.OptionSelectText = New System.Windows.Forms.Label()
        Me.OptionsList = New System.Windows.Forms.ListBox()
        Me.OptionsItemText = New System.Windows.Forms.Label()
        Me.OptionsFileText = New System.Windows.Forms.Label()
        Me.OptionsDrop = New System.Windows.Forms.ComboBox()
        Me.OptionsAddButton = New System.Windows.Forms.Button()
        Me.OptionsRefreshButton = New System.Windows.Forms.Button()
        Me.OptionerBackButton = New System.Windows.Forms.Button()
        Me.TitleBarPanel.SuspendLayout()
        Me.CloseButton.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.OptionsPanel.SuspendLayout()
        Me.OptionsMainPanel.SuspendLayout()
        Me.SoundsPanel.SuspendLayout()
        Me.DBPanel.SuspendLayout()
        Me.MusicPanel.SuspendLayout()
        Me.ColorsPanel.SuspendLayout()
        Me.AvatarPanel.SuspendLayout()
        CType(Me.AvatarImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleBarPanel
        '
        Me.TitleBarPanel.BackColor = System.Drawing.Color.DarkBlue
        Me.TitleBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TitleBarPanel.Controls.Add(Me.CloseButton)
        Me.TitleBarPanel.Controls.Add(Me.TitleLabel)
        Me.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarPanel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TitleBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.TitleBarPanel.Name = "TitleBarPanel"
        Me.TitleBarPanel.Size = New System.Drawing.Size(800, 30)
        Me.TitleBarPanel.TabIndex = 5
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButton.Controls.Add(Me.CloseText)
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CloseButton.Location = New System.Drawing.Point(772, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 17)
        Me.CloseButton.TabIndex = 2
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
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TitleLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TitleLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TitleLabel.Location = New System.Drawing.Point(0, 3)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(800, 20)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Limitless Options"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BackgroundPanel.Controls.Add(Me.OptionsPanel)
        Me.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundPanel.Location = New System.Drawing.Point(0, 30)
        Me.BackgroundPanel.Name = "BackgroundPanel"
        Me.BackgroundPanel.Size = New System.Drawing.Size(800, 570)
        Me.BackgroundPanel.TabIndex = 6
        '
        'OptionsPanel
        '
        Me.OptionsPanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.OptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OptionsPanel.Controls.Add(Me.OptionsDeleteButton)
        Me.OptionsPanel.Controls.Add(Me.OptionsMainPanel)
        Me.OptionsPanel.Controls.Add(Me.OptionsRenameButton)
        Me.OptionsPanel.Controls.Add(Me.OptionSelectText)
        Me.OptionsPanel.Controls.Add(Me.OptionsList)
        Me.OptionsPanel.Controls.Add(Me.OptionsItemText)
        Me.OptionsPanel.Controls.Add(Me.OptionsFileText)
        Me.OptionsPanel.Controls.Add(Me.OptionsDrop)
        Me.OptionsPanel.Controls.Add(Me.OptionsAddButton)
        Me.OptionsPanel.Controls.Add(Me.OptionsRefreshButton)
        Me.OptionsPanel.Controls.Add(Me.OptionerBackButton)
        Me.OptionsPanel.Location = New System.Drawing.Point(10, 9)
        Me.OptionsPanel.Name = "OptionsPanel"
        Me.OptionsPanel.Size = New System.Drawing.Size(776, 544)
        Me.OptionsPanel.TabIndex = 11
        '
        'OptionsDeleteButton
        '
        Me.OptionsDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsDeleteButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.OptionsDeleteButton.Location = New System.Drawing.Point(523, 503)
        Me.OptionsDeleteButton.Name = "OptionsDeleteButton"
        Me.OptionsDeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.OptionsDeleteButton.TabIndex = 44
        Me.OptionsDeleteButton.Text = "Delete"
        Me.OptionsDeleteButton.UseVisualStyleBackColor = True
        '
        'OptionsMainPanel
        '
        Me.OptionsMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OptionsMainPanel.Controls.Add(Me.SoundsPanel)
        Me.OptionsMainPanel.Controls.Add(Me.DBPanel)
        Me.OptionsMainPanel.Controls.Add(Me.MusicPanel)
        Me.OptionsMainPanel.Controls.Add(Me.ColorsPanel)
        Me.OptionsMainPanel.Controls.Add(Me.AvatarPanel)
        Me.OptionsMainPanel.Controls.Add(Me.SoundsText)
        Me.OptionsMainPanel.Controls.Add(Me.MusicText)
        Me.OptionsMainPanel.Controls.Add(Me.DBText)
        Me.OptionsMainPanel.Controls.Add(Me.ColorText)
        Me.OptionsMainPanel.Controls.Add(Me.VersionText)
        Me.OptionsMainPanel.Controls.Add(Me.SystemText)
        Me.OptionsMainPanel.Controls.Add(Me.SoundsLabel)
        Me.OptionsMainPanel.Controls.Add(Me.MusicLabel)
        Me.OptionsMainPanel.Controls.Add(Me.DBLabel)
        Me.OptionsMainPanel.Controls.Add(Me.ColorLabel)
        Me.OptionsMainPanel.Controls.Add(Me.VersionLabel)
        Me.OptionsMainPanel.Controls.Add(Me.SystemLabel)
        Me.OptionsMainPanel.Location = New System.Drawing.Point(6, 45)
        Me.OptionsMainPanel.Name = "OptionsMainPanel"
        Me.OptionsMainPanel.Size = New System.Drawing.Size(416, 441)
        Me.OptionsMainPanel.TabIndex = 43
        '
        'SoundsPanel
        '
        Me.SoundsPanel.Controls.Add(Me.Label1)
        Me.SoundsPanel.Location = New System.Drawing.Point(8, 7)
        Me.SoundsPanel.Name = "SoundsPanel"
        Me.SoundsPanel.Size = New System.Drawing.Size(398, 423)
        Me.SoundsPanel.TabIndex = 5
        Me.SoundsPanel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sounds"
        '
        'DBPanel
        '
        Me.DBPanel.Controls.Add(Me.Label3)
        Me.DBPanel.Location = New System.Drawing.Point(8, 7)
        Me.DBPanel.Name = "DBPanel"
        Me.DBPanel.Size = New System.Drawing.Size(398, 423)
        Me.DBPanel.TabIndex = 3
        Me.DBPanel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DB"
        '
        'MusicPanel
        '
        Me.MusicPanel.Controls.Add(Me.Label2)
        Me.MusicPanel.Location = New System.Drawing.Point(8, 7)
        Me.MusicPanel.Name = "MusicPanel"
        Me.MusicPanel.Size = New System.Drawing.Size(398, 423)
        Me.MusicPanel.TabIndex = 4
        Me.MusicPanel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Music"
        '
        'ColorsPanel
        '
        Me.ColorsPanel.Controls.Add(Me.Label4)
        Me.ColorsPanel.Location = New System.Drawing.Point(8, 7)
        Me.ColorsPanel.Name = "ColorsPanel"
        Me.ColorsPanel.Size = New System.Drawing.Size(398, 423)
        Me.ColorsPanel.TabIndex = 2
        Me.ColorsPanel.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Colors"
        '
        'AvatarPanel
        '
        Me.AvatarPanel.Controls.Add(Me.AvatarText)
        Me.AvatarPanel.Controls.Add(Me.AvatarImage)
        Me.AvatarPanel.Controls.Add(Me.DimText)
        Me.AvatarPanel.Controls.Add(Me.DimLabel)
        Me.AvatarPanel.Location = New System.Drawing.Point(8, 7)
        Me.AvatarPanel.Name = "AvatarPanel"
        Me.AvatarPanel.Size = New System.Drawing.Size(398, 423)
        Me.AvatarPanel.TabIndex = 0
        Me.AvatarPanel.Visible = False
        '
        'AvatarText
        '
        Me.AvatarText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AvatarText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AvatarText.Location = New System.Drawing.Point(40, 280)
        Me.AvatarText.Name = "AvatarText"
        Me.AvatarText.Size = New System.Drawing.Size(319, 21)
        Me.AvatarText.TabIndex = 40
        Me.AvatarText.Text = "Select an Avatar"
        Me.AvatarText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AvatarImage
        '
        Me.AvatarImage.BackgroundImage = Global.Limitless.My.Resources.Resources._empty_
        Me.AvatarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AvatarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AvatarImage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AvatarImage.Location = New System.Drawing.Point(99, 40)
        Me.AvatarImage.Name = "AvatarImage"
        Me.AvatarImage.Size = New System.Drawing.Size(200, 200)
        Me.AvatarImage.TabIndex = 4
        Me.AvatarImage.TabStop = False
        '
        'DimText
        '
        Me.DimText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DimText.Location = New System.Drawing.Point(204, 330)
        Me.DimText.Name = "DimText"
        Me.DimText.Size = New System.Drawing.Size(155, 21)
        Me.DimText.TabIndex = 42
        Me.DimText.Text = "000 x 000 pixels"
        Me.DimText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DimText.Visible = False
        '
        'DimLabel
        '
        Me.DimLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DimLabel.Location = New System.Drawing.Point(40, 330)
        Me.DimLabel.Name = "DimLabel"
        Me.DimLabel.Size = New System.Drawing.Size(155, 21)
        Me.DimLabel.TabIndex = 41
        Me.DimLabel.Text = "Image Dimensions:"
        Me.DimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DimLabel.Visible = False
        '
        'SoundsText
        '
        Me.SoundsText.Location = New System.Drawing.Point(206, 305)
        Me.SoundsText.Name = "SoundsText"
        Me.SoundsText.Size = New System.Drawing.Size(193, 18)
        Me.SoundsText.TabIndex = 17
        Me.SoundsText.Text = "ON"
        Me.SoundsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MusicText
        '
        Me.MusicText.Location = New System.Drawing.Point(206, 270)
        Me.MusicText.Name = "MusicText"
        Me.MusicText.Size = New System.Drawing.Size(193, 18)
        Me.MusicText.TabIndex = 16
        Me.MusicText.Text = "ON"
        Me.MusicText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DBText
        '
        Me.DBText.Location = New System.Drawing.Point(206, 235)
        Me.DBText.Name = "DBText"
        Me.DBText.Size = New System.Drawing.Size(193, 18)
        Me.DBText.TabIndex = 15
        Me.DBText.Text = "DEFAULT"
        Me.DBText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ColorText
        '
        Me.ColorText.Location = New System.Drawing.Point(206, 200)
        Me.ColorText.Name = "ColorText"
        Me.ColorText.Size = New System.Drawing.Size(193, 18)
        Me.ColorText.TabIndex = 14
        Me.ColorText.Text = "MODE"
        Me.ColorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VersionText
        '
        Me.VersionText.Location = New System.Drawing.Point(206, 163)
        Me.VersionText.Name = "VersionText"
        Me.VersionText.Size = New System.Drawing.Size(193, 18)
        Me.VersionText.TabIndex = 13
        Me.VersionText.Text = "0.0.000.000"
        Me.VersionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SystemText
        '
        Me.SystemText.Location = New System.Drawing.Point(206, 130)
        Me.SystemText.Name = "SystemText"
        Me.SystemText.Size = New System.Drawing.Size(193, 18)
        Me.SystemText.TabIndex = 12
        Me.SystemText.Text = "PCNAME"
        Me.SystemText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SoundsLabel
        '
        Me.SoundsLabel.Location = New System.Drawing.Point(104, 305)
        Me.SoundsLabel.Name = "SoundsLabel"
        Me.SoundsLabel.Size = New System.Drawing.Size(96, 18)
        Me.SoundsLabel.TabIndex = 11
        Me.SoundsLabel.Text = "Sounds:"
        Me.SoundsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MusicLabel
        '
        Me.MusicLabel.Location = New System.Drawing.Point(107, 270)
        Me.MusicLabel.Name = "MusicLabel"
        Me.MusicLabel.Size = New System.Drawing.Size(93, 18)
        Me.MusicLabel.TabIndex = 10
        Me.MusicLabel.Text = "Music:"
        Me.MusicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DBLabel
        '
        Me.DBLabel.Location = New System.Drawing.Point(64, 235)
        Me.DBLabel.Name = "DBLabel"
        Me.DBLabel.Size = New System.Drawing.Size(136, 18)
        Me.DBLabel.TabIndex = 9
        Me.DBLabel.Text = "Active Database:"
        Me.DBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ColorLabel
        '
        Me.ColorLabel.Location = New System.Drawing.Point(104, 200)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(96, 18)
        Me.ColorLabel.TabIndex = 8
        Me.ColorLabel.Text = "Color Mode:"
        Me.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VersionLabel
        '
        Me.VersionLabel.Location = New System.Drawing.Point(89, 165)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(111, 18)
        Me.VersionLabel.TabIndex = 7
        Me.VersionLabel.Text = "Game Version:  "
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SystemLabel
        '
        Me.SystemLabel.Location = New System.Drawing.Point(89, 130)
        Me.SystemLabel.Name = "SystemLabel"
        Me.SystemLabel.Size = New System.Drawing.Size(111, 18)
        Me.SystemLabel.TabIndex = 6
        Me.SystemLabel.Text = "System Name:"
        Me.SystemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OptionsRenameButton
        '
        Me.OptionsRenameButton.Enabled = False
        Me.OptionsRenameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsRenameButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.OptionsRenameButton.Location = New System.Drawing.Point(604, 503)
        Me.OptionsRenameButton.Name = "OptionsRenameButton"
        Me.OptionsRenameButton.Size = New System.Drawing.Size(75, 23)
        Me.OptionsRenameButton.TabIndex = 43
        Me.OptionsRenameButton.Text = "Rename"
        Me.OptionsRenameButton.UseVisualStyleBackColor = True
        '
        'OptionSelectText
        '
        Me.OptionSelectText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OptionSelectText.Location = New System.Drawing.Point(3, 5)
        Me.OptionSelectText.Name = "OptionSelectText"
        Me.OptionSelectText.Size = New System.Drawing.Size(147, 21)
        Me.OptionSelectText.TabIndex = 42
        Me.OptionSelectText.Text = "Option Selection:"
        Me.OptionSelectText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OptionsList
        '
        Me.OptionsList.BackColor = System.Drawing.SystemColors.ControlText
        Me.OptionsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OptionsList.ForeColor = System.Drawing.SystemColors.Control
        Me.OptionsList.FormattingEnabled = True
        Me.OptionsList.Location = New System.Drawing.Point(442, 46)
        Me.OptionsList.Name = "OptionsList"
        Me.OptionsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.OptionsList.Size = New System.Drawing.Size(319, 405)
        Me.OptionsList.Sorted = True
        Me.OptionsList.TabIndex = 41
        '
        'OptionsItemText
        '
        Me.OptionsItemText.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsItemText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OptionsItemText.Location = New System.Drawing.Point(442, 5)
        Me.OptionsItemText.Name = "OptionsItemText"
        Me.OptionsItemText.Size = New System.Drawing.Size(317, 21)
        Me.OptionsItemText.TabIndex = 40
        Me.OptionsItemText.Text = "[Items] In [ItemDir]"
        Me.OptionsItemText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OptionsFileText
        '
        Me.OptionsFileText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OptionsFileText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OptionsFileText.Location = New System.Drawing.Point(442, 465)
        Me.OptionsFileText.Name = "OptionsFileText"
        Me.OptionsFileText.Size = New System.Drawing.Size(319, 21)
        Me.OptionsFileText.TabIndex = 39
        Me.OptionsFileText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OptionsDrop
        '
        Me.OptionsDrop.BackColor = System.Drawing.SystemColors.ControlText
        Me.OptionsDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OptionsDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsDrop.ForeColor = System.Drawing.SystemColors.Control
        Me.OptionsDrop.FormattingEnabled = True
        Me.OptionsDrop.Location = New System.Drawing.Point(150, 5)
        Me.OptionsDrop.Name = "OptionsDrop"
        Me.OptionsDrop.Size = New System.Drawing.Size(272, 21)
        Me.OptionsDrop.TabIndex = 37
        '
        'OptionsAddButton
        '
        Me.OptionsAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsAddButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.OptionsAddButton.Location = New System.Drawing.Point(443, 503)
        Me.OptionsAddButton.Name = "OptionsAddButton"
        Me.OptionsAddButton.Size = New System.Drawing.Size(75, 23)
        Me.OptionsAddButton.TabIndex = 36
        Me.OptionsAddButton.Text = "Add"
        Me.OptionsAddButton.UseVisualStyleBackColor = True
        '
        'OptionsRefreshButton
        '
        Me.OptionsRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsRefreshButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.OptionsRefreshButton.Location = New System.Drawing.Point(684, 503)
        Me.OptionsRefreshButton.Name = "OptionsRefreshButton"
        Me.OptionsRefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.OptionsRefreshButton.TabIndex = 33
        Me.OptionsRefreshButton.Text = "Refresh"
        Me.OptionsRefreshButton.UseVisualStyleBackColor = True
        '
        'OptionerBackButton
        '
        Me.OptionerBackButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.OptionerBackButton.BackgroundImage = Global.Limitless.My.Resources.Resources.back
        Me.OptionerBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OptionerBackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OptionerBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptionerBackButton.ForeColor = System.Drawing.SystemColors.Control
        Me.OptionerBackButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OptionerBackButton.Location = New System.Drawing.Point(3, 489)
        Me.OptionerBackButton.Name = "OptionerBackButton"
        Me.OptionerBackButton.Size = New System.Drawing.Size(50, 50)
        Me.OptionerBackButton.TabIndex = 32
        Me.OptionerBackButton.UseVisualStyleBackColor = False
        '
        'Optioner
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Optioner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Limitless Options"
        Me.TitleBarPanel.ResumeLayout(False)
        Me.CloseButton.ResumeLayout(False)
        Me.CloseButton.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.OptionsPanel.ResumeLayout(False)
        Me.OptionsMainPanel.ResumeLayout(False)
        Me.SoundsPanel.ResumeLayout(False)
        Me.SoundsPanel.PerformLayout()
        Me.DBPanel.ResumeLayout(False)
        Me.DBPanel.PerformLayout()
        Me.MusicPanel.ResumeLayout(False)
        Me.MusicPanel.PerformLayout()
        Me.ColorsPanel.ResumeLayout(False)
        Me.ColorsPanel.PerformLayout()
        Me.AvatarPanel.ResumeLayout(False)
        CType(Me.AvatarImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents CloseText As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents OptionsPanel As Panel
    Friend WithEvents OptionerBackButton As Button
    Friend WithEvents OptionsAddButton As Button
    Friend WithEvents OptionsRefreshButton As Button
    Friend WithEvents OptionsDrop As ComboBox
    Friend WithEvents OptionsFileText As Label
    Friend WithEvents OptionsItemText As Label
    Friend WithEvents OptionsList As ListBox
    Friend WithEvents OptionsMainPanel As Panel
    Friend WithEvents OptionSelectText As Label
    Friend WithEvents AvatarPanel As Panel
    Friend WithEvents ColorsPanel As Panel
    Friend WithEvents MusicPanel As Panel
    Friend WithEvents DBPanel As Panel
    Friend WithEvents SoundsPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AvatarImage As PictureBox
    Friend WithEvents OptionsRenameButton As Button
    Friend WithEvents DimText As Label
    Friend WithEvents DimLabel As Label
    Friend WithEvents AvatarText As Label
    Friend WithEvents OptionsDeleteButton As Button
    Friend WithEvents SoundsText As Label
    Friend WithEvents MusicText As Label
    Friend WithEvents DBText As Label
    Friend WithEvents ColorText As Label
    Friend WithEvents VersionText As Label
    Friend WithEvents SystemText As Label
    Friend WithEvents SoundsLabel As Label
    Friend WithEvents MusicLabel As Label
    Friend WithEvents DBLabel As Label
    Friend WithEvents ColorLabel As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents SystemLabel As Label
End Class

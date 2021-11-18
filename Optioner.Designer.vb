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
        Me.OptionsMainPanel = New System.Windows.Forms.Panel()
        Me.AvatarPanel = New System.Windows.Forms.Panel()
        Me.AvaDeleteButton = New System.Windows.Forms.Button()
        Me.AvaRenameButton = New System.Windows.Forms.Button()
        Me.DimText = New System.Windows.Forms.Label()
        Me.DimLabel = New System.Windows.Forms.Label()
        Me.AvatarText = New System.Windows.Forms.Label()
        Me.AvatarImage = New System.Windows.Forms.PictureBox()
        Me.SoundsPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MusicPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DBPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorsPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OptionSelectText = New System.Windows.Forms.Label()
        Me.OptionList = New System.Windows.Forms.ListBox()
        Me.OptionsItemText = New System.Windows.Forms.Label()
        Me.OptionsFileText = New System.Windows.Forms.Label()
        Me.OptionsDrop = New System.Windows.Forms.ComboBox()
        Me.OptionAddButton = New System.Windows.Forms.Button()
        Me.OptionRefreshButton = New System.Windows.Forms.Button()
        Me.OptionerBackButton = New System.Windows.Forms.Button()
        Me.TitleBarPanel.SuspendLayout()
        Me.CloseButton.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.OptionsPanel.SuspendLayout()
        Me.OptionsMainPanel.SuspendLayout()
        Me.AvatarPanel.SuspendLayout()
        CType(Me.AvatarImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SoundsPanel.SuspendLayout()
        Me.MusicPanel.SuspendLayout()
        Me.DBPanel.SuspendLayout()
        Me.ColorsPanel.SuspendLayout()
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
        Me.OptionsPanel.Controls.Add(Me.OptionsMainPanel)
        Me.OptionsPanel.Controls.Add(Me.OptionSelectText)
        Me.OptionsPanel.Controls.Add(Me.OptionList)
        Me.OptionsPanel.Controls.Add(Me.OptionsItemText)
        Me.OptionsPanel.Controls.Add(Me.OptionsFileText)
        Me.OptionsPanel.Controls.Add(Me.OptionsDrop)
        Me.OptionsPanel.Controls.Add(Me.OptionAddButton)
        Me.OptionsPanel.Controls.Add(Me.OptionRefreshButton)
        Me.OptionsPanel.Controls.Add(Me.OptionerBackButton)
        Me.OptionsPanel.Location = New System.Drawing.Point(10, 9)
        Me.OptionsPanel.Name = "OptionsPanel"
        Me.OptionsPanel.Size = New System.Drawing.Size(776, 544)
        Me.OptionsPanel.TabIndex = 11
        '
        'OptionsMainPanel
        '
        Me.OptionsMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OptionsMainPanel.Controls.Add(Me.AvatarPanel)
        Me.OptionsMainPanel.Controls.Add(Me.SoundsPanel)
        Me.OptionsMainPanel.Controls.Add(Me.MusicPanel)
        Me.OptionsMainPanel.Controls.Add(Me.DBPanel)
        Me.OptionsMainPanel.Controls.Add(Me.ColorsPanel)
        Me.OptionsMainPanel.Location = New System.Drawing.Point(6, 45)
        Me.OptionsMainPanel.Name = "OptionsMainPanel"
        Me.OptionsMainPanel.Size = New System.Drawing.Size(416, 441)
        Me.OptionsMainPanel.TabIndex = 43
        '
        'AvatarPanel
        '
        Me.AvatarPanel.Controls.Add(Me.AvaDeleteButton)
        Me.AvatarPanel.Controls.Add(Me.AvaRenameButton)
        Me.AvatarPanel.Controls.Add(Me.DimText)
        Me.AvatarPanel.Controls.Add(Me.DimLabel)
        Me.AvatarPanel.Controls.Add(Me.AvatarText)
        Me.AvatarPanel.Controls.Add(Me.AvatarImage)
        Me.AvatarPanel.Location = New System.Drawing.Point(8, 7)
        Me.AvatarPanel.Name = "AvatarPanel"
        Me.AvatarPanel.Size = New System.Drawing.Size(398, 423)
        Me.AvatarPanel.TabIndex = 0
        Me.AvatarPanel.Visible = False
        '
        'AvaDeleteButton
        '
        Me.AvaDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AvaDeleteButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.AvaDeleteButton.Location = New System.Drawing.Point(207, 357)
        Me.AvaDeleteButton.Name = "AvaDeleteButton"
        Me.AvaDeleteButton.Size = New System.Drawing.Size(150, 23)
        Me.AvaDeleteButton.TabIndex = 44
        Me.AvaDeleteButton.Text = "Delete Avatar"
        Me.AvaDeleteButton.UseVisualStyleBackColor = True
        '
        'AvaRenameButton
        '
        Me.AvaRenameButton.Enabled = False
        Me.AvaRenameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AvaRenameButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.AvaRenameButton.Location = New System.Drawing.Point(40, 357)
        Me.AvaRenameButton.Name = "AvaRenameButton"
        Me.AvaRenameButton.Size = New System.Drawing.Size(150, 23)
        Me.AvaRenameButton.TabIndex = 43
        Me.AvaRenameButton.Text = "Rename Avatar"
        Me.AvaRenameButton.UseVisualStyleBackColor = True
        '
        'DimText
        '
        Me.DimText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DimText.Location = New System.Drawing.Point(204, 306)
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
        Me.DimLabel.Location = New System.Drawing.Point(40, 306)
        Me.DimLabel.Name = "DimLabel"
        Me.DimLabel.Size = New System.Drawing.Size(155, 21)
        Me.DimLabel.TabIndex = 41
        Me.DimLabel.Text = "Image Dimensions:"
        Me.DimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DimLabel.Visible = False
        '
        'AvatarText
        '
        Me.AvatarText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AvatarText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AvatarText.Location = New System.Drawing.Point(40, 250)
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
        Me.AvatarImage.Location = New System.Drawing.Point(99, 20)
        Me.AvatarImage.Name = "AvatarImage"
        Me.AvatarImage.Size = New System.Drawing.Size(200, 200)
        Me.AvatarImage.TabIndex = 4
        Me.AvatarImage.TabStop = False
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
        'OptionList
        '
        Me.OptionList.BackColor = System.Drawing.SystemColors.ControlText
        Me.OptionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OptionList.ForeColor = System.Drawing.SystemColors.Control
        Me.OptionList.FormattingEnabled = True
        Me.OptionList.Location = New System.Drawing.Point(442, 46)
        Me.OptionList.Name = "OptionList"
        Me.OptionList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.OptionList.Size = New System.Drawing.Size(319, 405)
        Me.OptionList.Sorted = True
        Me.OptionList.TabIndex = 41
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
        'OptionAddButton
        '
        Me.OptionAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionAddButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.OptionAddButton.Location = New System.Drawing.Point(443, 503)
        Me.OptionAddButton.Name = "OptionAddButton"
        Me.OptionAddButton.Size = New System.Drawing.Size(150, 23)
        Me.OptionAddButton.TabIndex = 36
        Me.OptionAddButton.Text = "Import File"
        Me.OptionAddButton.UseVisualStyleBackColor = True
        '
        'OptionRefreshButton
        '
        Me.OptionRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionRefreshButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.OptionRefreshButton.Location = New System.Drawing.Point(611, 503)
        Me.OptionRefreshButton.Name = "OptionRefreshButton"
        Me.OptionRefreshButton.Size = New System.Drawing.Size(150, 23)
        Me.OptionRefreshButton.TabIndex = 33
        Me.OptionRefreshButton.Text = "Refresh List"
        Me.OptionRefreshButton.UseVisualStyleBackColor = True
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
        Me.AvatarPanel.ResumeLayout(False)
        CType(Me.AvatarImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SoundsPanel.ResumeLayout(False)
        Me.SoundsPanel.PerformLayout()
        Me.MusicPanel.ResumeLayout(False)
        Me.MusicPanel.PerformLayout()
        Me.DBPanel.ResumeLayout(False)
        Me.DBPanel.PerformLayout()
        Me.ColorsPanel.ResumeLayout(False)
        Me.ColorsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents CloseText As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents OptionsPanel As Panel
    Friend WithEvents OptionerBackButton As Button
    Friend WithEvents OptionAddButton As Button
    Friend WithEvents OptionRefreshButton As Button
    Friend WithEvents OptionsDrop As ComboBox
    Friend WithEvents OptionsFileText As Label
    Friend WithEvents OptionsItemText As Label
    Friend WithEvents OptionList As ListBox
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
    Friend WithEvents AvaRenameButton As Button
    Friend WithEvents DimText As Label
    Friend WithEvents DimLabel As Label
    Friend WithEvents AvatarText As Label
    Friend WithEvents AvaDeleteButton As Button
End Class

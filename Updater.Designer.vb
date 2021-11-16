<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Updater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Updater))
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.UpdatePanel = New System.Windows.Forms.Panel()
        Me.UpdaterBackButton = New System.Windows.Forms.Button()
        Me.DBUpdateButton = New System.Windows.Forms.Button()
        Me.OnlineDBBox = New System.Windows.Forms.TextBox()
        Me.OnlineDBText = New System.Windows.Forms.Label()
        Me.SelectDBDrop = New System.Windows.Forms.ComboBox()
        Me.SelectDBText = New System.Windows.Forms.Label()
        Me.InstallDBBox = New System.Windows.Forms.TextBox()
        Me.InstallDBText = New System.Windows.Forms.Label()
        Me.DBStatusText = New System.Windows.Forms.Label()
        Me.AvailGameBox = New System.Windows.Forms.TextBox()
        Me.InstallGameBox = New System.Windows.Forms.TextBox()
        Me.GameUpdateButton = New System.Windows.Forms.Button()
        Me.AvailGameText = New System.Windows.Forms.Label()
        Me.InstallGameText = New System.Windows.Forms.Label()
        Me.GameStatusText = New System.Windows.Forms.Label()
        Me.TitleBarPanel.SuspendLayout()
        Me.CloseButton.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.UpdatePanel.SuspendLayout()
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
        Me.TitleBarPanel.TabIndex = 4
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
        Me.TitleLabel.Text = "Check For Updates"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BackgroundPanel.Controls.Add(Me.UpdatePanel)
        Me.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundPanel.Location = New System.Drawing.Point(0, 30)
        Me.BackgroundPanel.Name = "BackgroundPanel"
        Me.BackgroundPanel.Size = New System.Drawing.Size(800, 570)
        Me.BackgroundPanel.TabIndex = 5
        '
        'UpdatePanel
        '
        Me.UpdatePanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.UpdatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UpdatePanel.Controls.Add(Me.UpdaterBackButton)
        Me.UpdatePanel.Controls.Add(Me.DBUpdateButton)
        Me.UpdatePanel.Controls.Add(Me.OnlineDBBox)
        Me.UpdatePanel.Controls.Add(Me.OnlineDBText)
        Me.UpdatePanel.Controls.Add(Me.SelectDBDrop)
        Me.UpdatePanel.Controls.Add(Me.SelectDBText)
        Me.UpdatePanel.Controls.Add(Me.InstallDBBox)
        Me.UpdatePanel.Controls.Add(Me.InstallDBText)
        Me.UpdatePanel.Controls.Add(Me.DBStatusText)
        Me.UpdatePanel.Controls.Add(Me.AvailGameBox)
        Me.UpdatePanel.Controls.Add(Me.InstallGameBox)
        Me.UpdatePanel.Controls.Add(Me.GameUpdateButton)
        Me.UpdatePanel.Controls.Add(Me.AvailGameText)
        Me.UpdatePanel.Controls.Add(Me.InstallGameText)
        Me.UpdatePanel.Controls.Add(Me.GameStatusText)
        Me.UpdatePanel.Location = New System.Drawing.Point(10, 9)
        Me.UpdatePanel.Name = "UpdatePanel"
        Me.UpdatePanel.Size = New System.Drawing.Size(776, 544)
        Me.UpdatePanel.TabIndex = 11
        '
        'UpdaterBackButton
        '
        Me.UpdaterBackButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.UpdaterBackButton.BackgroundImage = Global.Limitless.My.Resources.Resources.back
        Me.UpdaterBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdaterBackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdaterBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdaterBackButton.ForeColor = System.Drawing.SystemColors.Control
        Me.UpdaterBackButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UpdaterBackButton.Location = New System.Drawing.Point(3, 489)
        Me.UpdaterBackButton.Name = "UpdaterBackButton"
        Me.UpdaterBackButton.Size = New System.Drawing.Size(50, 50)
        Me.UpdaterBackButton.TabIndex = 32
        Me.UpdaterBackButton.UseVisualStyleBackColor = False
        '
        'DBUpdateButton
        '
        Me.DBUpdateButton.Enabled = False
        Me.DBUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DBUpdateButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.DBUpdateButton.Location = New System.Drawing.Point(312, 495)
        Me.DBUpdateButton.Name = "DBUpdateButton"
        Me.DBUpdateButton.Size = New System.Drawing.Size(150, 23)
        Me.DBUpdateButton.TabIndex = 20
        Me.DBUpdateButton.Text = "Update Database"
        Me.DBUpdateButton.UseVisualStyleBackColor = True
        '
        'OnlineDBBox
        '
        Me.OnlineDBBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.OnlineDBBox.ForeColor = System.Drawing.SystemColors.Window
        Me.OnlineDBBox.Location = New System.Drawing.Point(406, 435)
        Me.OnlineDBBox.Name = "OnlineDBBox"
        Me.OnlineDBBox.ReadOnly = True
        Me.OnlineDBBox.Size = New System.Drawing.Size(150, 20)
        Me.OnlineDBBox.TabIndex = 19
        Me.OnlineDBBox.TabStop = False
        '
        'OnlineDBText
        '
        Me.OnlineDBText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OnlineDBText.Location = New System.Drawing.Point(145, 438)
        Me.OnlineDBText.Name = "OnlineDBText"
        Me.OnlineDBText.Size = New System.Drawing.Size(226, 13)
        Me.OnlineDBText.TabIndex = 18
        Me.OnlineDBText.Text = "Online Database Version:"
        Me.OnlineDBText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SelectDBDrop
        '
        Me.SelectDBDrop.BackColor = System.Drawing.SystemColors.ControlText
        Me.SelectDBDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectDBDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectDBDrop.ForeColor = System.Drawing.SystemColors.Control
        Me.SelectDBDrop.FormattingEnabled = True
        Me.SelectDBDrop.Location = New System.Drawing.Point(406, 309)
        Me.SelectDBDrop.Name = "SelectDBDrop"
        Me.SelectDBDrop.Size = New System.Drawing.Size(150, 21)
        Me.SelectDBDrop.TabIndex = 17
        '
        'SelectDBText
        '
        Me.SelectDBText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SelectDBText.Location = New System.Drawing.Point(142, 318)
        Me.SelectDBText.Name = "SelectDBText"
        Me.SelectDBText.Size = New System.Drawing.Size(229, 13)
        Me.SelectDBText.TabIndex = 16
        Me.SelectDBText.Text = "Selected Database:"
        Me.SelectDBText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InstallDBBox
        '
        Me.InstallDBBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.InstallDBBox.ForeColor = System.Drawing.SystemColors.Window
        Me.InstallDBBox.Location = New System.Drawing.Point(406, 375)
        Me.InstallDBBox.Name = "InstallDBBox"
        Me.InstallDBBox.ReadOnly = True
        Me.InstallDBBox.Size = New System.Drawing.Size(150, 20)
        Me.InstallDBBox.TabIndex = 15
        Me.InstallDBBox.TabStop = False
        '
        'InstallDBText
        '
        Me.InstallDBText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.InstallDBText.Location = New System.Drawing.Point(142, 378)
        Me.InstallDBText.Name = "InstallDBText"
        Me.InstallDBText.Size = New System.Drawing.Size(229, 13)
        Me.InstallDBText.TabIndex = 14
        Me.InstallDBText.Text = "Installed Database Version:"
        Me.InstallDBText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DBStatusText
        '
        Me.DBStatusText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DBStatusText.Location = New System.Drawing.Point(0, 255)
        Me.DBStatusText.Name = "DBStatusText"
        Me.DBStatusText.Size = New System.Drawing.Size(775, 21)
        Me.DBStatusText.TabIndex = 13
        Me.DBStatusText.Text = "Database Version"
        Me.DBStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AvailGameBox
        '
        Me.AvailGameBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.AvailGameBox.ForeColor = System.Drawing.SystemColors.Window
        Me.AvailGameBox.Location = New System.Drawing.Point(406, 135)
        Me.AvailGameBox.Name = "AvailGameBox"
        Me.AvailGameBox.ReadOnly = True
        Me.AvailGameBox.Size = New System.Drawing.Size(150, 20)
        Me.AvailGameBox.TabIndex = 12
        Me.AvailGameBox.TabStop = False
        '
        'InstallGameBox
        '
        Me.InstallGameBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.InstallGameBox.ForeColor = System.Drawing.SystemColors.Window
        Me.InstallGameBox.Location = New System.Drawing.Point(406, 75)
        Me.InstallGameBox.Name = "InstallGameBox"
        Me.InstallGameBox.ReadOnly = True
        Me.InstallGameBox.Size = New System.Drawing.Size(150, 20)
        Me.InstallGameBox.TabIndex = 11
        Me.InstallGameBox.TabStop = False
        '
        'GameUpdateButton
        '
        Me.GameUpdateButton.Enabled = False
        Me.GameUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameUpdateButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.GameUpdateButton.Location = New System.Drawing.Point(312, 195)
        Me.GameUpdateButton.Name = "GameUpdateButton"
        Me.GameUpdateButton.Size = New System.Drawing.Size(150, 23)
        Me.GameUpdateButton.TabIndex = 10
        Me.GameUpdateButton.Text = "Install Game Update"
        Me.GameUpdateButton.UseVisualStyleBackColor = True
        '
        'AvailGameText
        '
        Me.AvailGameText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AvailGameText.Location = New System.Drawing.Point(145, 138)
        Me.AvailGameText.Name = "AvailGameText"
        Me.AvailGameText.Size = New System.Drawing.Size(226, 13)
        Me.AvailGameText.TabIndex = 9
        Me.AvailGameText.Text = "Available Game Version:"
        Me.AvailGameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InstallGameText
        '
        Me.InstallGameText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.InstallGameText.Location = New System.Drawing.Point(142, 78)
        Me.InstallGameText.Name = "InstallGameText"
        Me.InstallGameText.Size = New System.Drawing.Size(229, 13)
        Me.InstallGameText.TabIndex = 8
        Me.InstallGameText.Text = "Installed Game Version:"
        Me.InstallGameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GameStatusText
        '
        Me.GameStatusText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GameStatusText.Location = New System.Drawing.Point(0, 15)
        Me.GameStatusText.Name = "GameStatusText"
        Me.GameStatusText.Size = New System.Drawing.Size(775, 21)
        Me.GameStatusText.TabIndex = 7
        Me.GameStatusText.Text = "Game Version"
        Me.GameStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Updater
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Updater"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Check For Updates"
        Me.TitleBarPanel.ResumeLayout(False)
        Me.CloseButton.ResumeLayout(False)
        Me.CloseButton.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.UpdatePanel.ResumeLayout(False)
        Me.UpdatePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents CloseText As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents UpdatePanel As Panel
    Friend WithEvents AvailGameBox As TextBox
    Friend WithEvents InstallGameBox As TextBox
    Friend WithEvents GameUpdateButton As Button
    Friend WithEvents AvailGameText As Label
    Friend WithEvents InstallGameText As Label
    Friend WithEvents GameStatusText As Label
    Friend WithEvents DBUpdateButton As Button
    Friend WithEvents OnlineDBBox As TextBox
    Friend WithEvents OnlineDBText As Label
    Friend WithEvents SelectDBDrop As ComboBox
    Friend WithEvents SelectDBText As Label
    Friend WithEvents InstallDBBox As TextBox
    Friend WithEvents InstallDBText As Label
    Friend WithEvents DBStatusText As Label
    Friend WithEvents UpdaterBackButton As Button
End Class

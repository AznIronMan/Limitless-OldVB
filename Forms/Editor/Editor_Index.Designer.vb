<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor_Index
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor_Index))
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.EditorPanel = New System.Windows.Forms.Panel()
        Me.IndexCancelButton = New System.Windows.Forms.Button()
        Me.IndexSaveButton = New System.Windows.Forms.Button()
        Me.AvailLabel = New System.Windows.Forms.Label()
        Me.AvailCheck = New System.Windows.Forms.CheckBox()
        Me.DescText = New System.Windows.Forms.TextBox()
        Me.DescLabel = New System.Windows.Forms.Label()
        Me.CatLabel = New System.Windows.Forms.Label()
        Me.CatText = New System.Windows.Forms.TextBox()
        Me.LowText = New System.Windows.Forms.Label()
        Me.TitleBarPanel.SuspendLayout()
        Me.CloseButton.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.EditorPanel.SuspendLayout()
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
        Me.TitleBarPanel.Size = New System.Drawing.Size(500, 30)
        Me.TitleBarPanel.TabIndex = 7
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButton.Controls.Add(Me.CloseText)
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CloseButton.Location = New System.Drawing.Point(472, 4)
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
        Me.TitleLabel.Size = New System.Drawing.Size(492, 20)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Limitless Categories Editor"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BackgroundPanel.Controls.Add(Me.EditorPanel)
        Me.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundPanel.Location = New System.Drawing.Point(0, 30)
        Me.BackgroundPanel.Name = "BackgroundPanel"
        Me.BackgroundPanel.Size = New System.Drawing.Size(500, 270)
        Me.BackgroundPanel.TabIndex = 8
        '
        'EditorPanel
        '
        Me.EditorPanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.EditorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EditorPanel.Controls.Add(Me.IndexCancelButton)
        Me.EditorPanel.Controls.Add(Me.IndexSaveButton)
        Me.EditorPanel.Controls.Add(Me.AvailLabel)
        Me.EditorPanel.Controls.Add(Me.AvailCheck)
        Me.EditorPanel.Controls.Add(Me.DescText)
        Me.EditorPanel.Controls.Add(Me.DescLabel)
        Me.EditorPanel.Controls.Add(Me.CatLabel)
        Me.EditorPanel.Controls.Add(Me.CatText)
        Me.EditorPanel.Controls.Add(Me.LowText)
        Me.EditorPanel.Location = New System.Drawing.Point(10, 9)
        Me.EditorPanel.Name = "EditorPanel"
        Me.EditorPanel.Size = New System.Drawing.Size(476, 247)
        Me.EditorPanel.TabIndex = 11
        '
        'IndexCancelButton
        '
        Me.IndexCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IndexCancelButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.IndexCancelButton.Location = New System.Drawing.Point(245, 173)
        Me.IndexCancelButton.Name = "IndexCancelButton"
        Me.IndexCancelButton.Size = New System.Drawing.Size(125, 23)
        Me.IndexCancelButton.TabIndex = 118
        Me.IndexCancelButton.Text = "Cancel"
        Me.IndexCancelButton.UseVisualStyleBackColor = True
        '
        'IndexSaveButton
        '
        Me.IndexSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IndexSaveButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.IndexSaveButton.Location = New System.Drawing.Point(105, 173)
        Me.IndexSaveButton.Name = "IndexSaveButton"
        Me.IndexSaveButton.Size = New System.Drawing.Size(125, 23)
        Me.IndexSaveButton.TabIndex = 117
        Me.IndexSaveButton.Text = "Save Changes"
        Me.IndexSaveButton.UseVisualStyleBackColor = True
        '
        'AvailLabel
        '
        Me.AvailLabel.Location = New System.Drawing.Point(2, 140)
        Me.AvailLabel.Name = "AvailLabel"
        Me.AvailLabel.Size = New System.Drawing.Size(128, 23)
        Me.AvailLabel.TabIndex = 116
        Me.AvailLabel.Text = "Availability:"
        Me.AvailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AvailCheck
        '
        Me.AvailCheck.AutoSize = True
        Me.AvailCheck.Location = New System.Drawing.Point(136, 144)
        Me.AvailCheck.Name = "AvailCheck"
        Me.AvailCheck.Size = New System.Drawing.Size(178, 17)
        Me.AvailCheck.TabIndex = 115
        Me.AvailCheck.Text = "Mod Maker Mode Only"
        Me.AvailCheck.UseVisualStyleBackColor = True
        '
        'DescText
        '
        Me.DescText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DescText.ForeColor = System.Drawing.SystemColors.Window
        Me.DescText.Location = New System.Drawing.Point(136, 52)
        Me.DescText.MaxLength = 200
        Me.DescText.Multiline = True
        Me.DescText.Name = "DescText"
        Me.DescText.Size = New System.Drawing.Size(326, 78)
        Me.DescText.TabIndex = 114
        '
        'DescLabel
        '
        Me.DescLabel.Location = New System.Drawing.Point(2, 50)
        Me.DescLabel.Name = "DescLabel"
        Me.DescLabel.Size = New System.Drawing.Size(128, 23)
        Me.DescLabel.TabIndex = 113
        Me.DescLabel.Text = "Description:"
        Me.DescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CatLabel
        '
        Me.CatLabel.Location = New System.Drawing.Point(2, 15)
        Me.CatLabel.Name = "CatLabel"
        Me.CatLabel.Size = New System.Drawing.Size(128, 23)
        Me.CatLabel.TabIndex = 112
        Me.CatLabel.Text = "Category Name:"
        Me.CatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CatText
        '
        Me.CatText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CatText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CatText.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CatText.ForeColor = System.Drawing.SystemColors.Window
        Me.CatText.Location = New System.Drawing.Point(136, 20)
        Me.CatText.Name = "CatText"
        Me.CatText.ReadOnly = True
        Me.CatText.Size = New System.Drawing.Size(326, 13)
        Me.CatText.TabIndex = 111
        Me.CatText.TabStop = False
        '
        'LowText
        '
        Me.LowText.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowText.Location = New System.Drawing.Point(-1, 207)
        Me.LowText.Name = "LowText"
        Me.LowText.Size = New System.Drawing.Size(476, 36)
        Me.LowText.TabIndex = 109
        Me.LowText.Text = "All edits will be merely cosmetic." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "They will not change game play."
        Me.LowText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Editor_Index
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Editor_Index"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Categories Editor"
        Me.TitleBarPanel.ResumeLayout(False)
        Me.CloseButton.ResumeLayout(False)
        Me.CloseButton.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.EditorPanel.ResumeLayout(False)
        Me.EditorPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents CloseText As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents EditorPanel As Panel
    Friend WithEvents LowText As Label
    Friend WithEvents CatText As TextBox
    Friend WithEvents AvailLabel As Label
    Friend WithEvents AvailCheck As CheckBox
    Friend WithEvents DescText As TextBox
    Friend WithEvents DescLabel As Label
    Friend WithEvents CatLabel As Label
    Friend WithEvents IndexCancelButton As Button
    Friend WithEvents IndexSaveButton As Button
End Class

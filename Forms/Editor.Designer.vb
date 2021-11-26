<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.EditorPanel = New System.Windows.Forms.Panel()
        Me.EditorFilterText = New System.Windows.Forms.TextBox()
        Me.EditorDescText = New System.Windows.Forms.Label()
        Me.EditorLowText = New System.Windows.Forms.Label()
        Me.EditorSearchButton = New System.Windows.Forms.Button()
        Me.EditorEditButton = New System.Windows.Forms.Button()
        Me.EditorClearButton = New System.Windows.Forms.Button()
        Me.EditorSelectButton = New System.Windows.Forms.Button()
        Me.EditorMultiButton = New System.Windows.Forms.Button()
        Me.EditorFilterButton = New System.Windows.Forms.Button()
        Me.EditorImportButton = New System.Windows.Forms.Button()
        Me.EditorDeleteButton = New System.Windows.Forms.Button()
        Me.EditorCopyButton = New System.Windows.Forms.Button()
        Me.EditorCountText = New System.Windows.Forms.Label()
        Me.EditorAddButton = New System.Windows.Forms.Button()
        Me.EditorDBText = New System.Windows.Forms.Label()
        Me.EditorDBLabel = New System.Windows.Forms.Label()
        Me.EditorDrop = New System.Windows.Forms.ComboBox()
        Me.EditorList = New System.Windows.Forms.ListBox()
        Me.EditorCatText = New System.Windows.Forms.Label()
        Me.EditorBackButton = New System.Windows.Forms.Button()
        Me.mmmCheck = New System.Windows.Forms.CheckBox()
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
        Me.TitleBarPanel.Size = New System.Drawing.Size(800, 30)
        Me.TitleBarPanel.TabIndex = 6
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
        Me.TitleLabel.Size = New System.Drawing.Size(798, 20)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Limitless Editor"
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
        Me.BackgroundPanel.Size = New System.Drawing.Size(800, 570)
        Me.BackgroundPanel.TabIndex = 7
        '
        'EditorPanel
        '
        Me.EditorPanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.EditorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EditorPanel.Controls.Add(Me.mmmCheck)
        Me.EditorPanel.Controls.Add(Me.EditorFilterText)
        Me.EditorPanel.Controls.Add(Me.EditorDescText)
        Me.EditorPanel.Controls.Add(Me.EditorLowText)
        Me.EditorPanel.Controls.Add(Me.EditorSearchButton)
        Me.EditorPanel.Controls.Add(Me.EditorEditButton)
        Me.EditorPanel.Controls.Add(Me.EditorClearButton)
        Me.EditorPanel.Controls.Add(Me.EditorSelectButton)
        Me.EditorPanel.Controls.Add(Me.EditorMultiButton)
        Me.EditorPanel.Controls.Add(Me.EditorFilterButton)
        Me.EditorPanel.Controls.Add(Me.EditorImportButton)
        Me.EditorPanel.Controls.Add(Me.EditorDeleteButton)
        Me.EditorPanel.Controls.Add(Me.EditorCopyButton)
        Me.EditorPanel.Controls.Add(Me.EditorCountText)
        Me.EditorPanel.Controls.Add(Me.EditorAddButton)
        Me.EditorPanel.Controls.Add(Me.EditorDBText)
        Me.EditorPanel.Controls.Add(Me.EditorDBLabel)
        Me.EditorPanel.Controls.Add(Me.EditorDrop)
        Me.EditorPanel.Controls.Add(Me.EditorList)
        Me.EditorPanel.Controls.Add(Me.EditorCatText)
        Me.EditorPanel.Controls.Add(Me.EditorBackButton)
        Me.EditorPanel.Location = New System.Drawing.Point(10, 9)
        Me.EditorPanel.Name = "EditorPanel"
        Me.EditorPanel.Size = New System.Drawing.Size(776, 547)
        Me.EditorPanel.TabIndex = 11
        '
        'EditorFilterText
        '
        Me.EditorFilterText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EditorFilterText.ForeColor = System.Drawing.SystemColors.Window
        Me.EditorFilterText.Location = New System.Drawing.Point(334, 31)
        Me.EditorFilterText.Name = "EditorFilterText"
        Me.EditorFilterText.Size = New System.Drawing.Size(319, 20)
        Me.EditorFilterText.TabIndex = 110
        '
        'EditorDescText
        '
        Me.EditorDescText.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorDescText.Location = New System.Drawing.Point(3, 78)
        Me.EditorDescText.Name = "EditorDescText"
        Me.EditorDescText.Size = New System.Drawing.Size(325, 50)
        Me.EditorDescText.TabIndex = 109
        Me.EditorDescText.Text = "Description"
        Me.EditorDescText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditorLowText
        '
        Me.EditorLowText.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorLowText.Location = New System.Drawing.Point(331, 489)
        Me.EditorLowText.Name = "EditorLowText"
        Me.EditorLowText.Size = New System.Drawing.Size(430, 50)
        Me.EditorLowText.TabIndex = 108
        Me.EditorLowText.Text = "Select a Category in the upper left drop down." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double-click an item in list to" &
    " edit that item."
        Me.EditorLowText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditorSearchButton
        '
        Me.EditorSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorSearchButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditorSearchButton.Location = New System.Drawing.Point(102, 335)
        Me.EditorSearchButton.Name = "EditorSearchButton"
        Me.EditorSearchButton.Size = New System.Drawing.Size(127, 23)
        Me.EditorSearchButton.TabIndex = 107
        Me.EditorSearchButton.Text = "Search Criteria"
        Me.EditorSearchButton.UseVisualStyleBackColor = True
        '
        'EditorEditButton
        '
        Me.EditorEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorEditButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditorEditButton.Location = New System.Drawing.Point(102, 175)
        Me.EditorEditButton.Name = "EditorEditButton"
        Me.EditorEditButton.Size = New System.Drawing.Size(127, 23)
        Me.EditorEditButton.TabIndex = 106
        Me.EditorEditButton.Text = "Edit Item"
        Me.EditorEditButton.UseVisualStyleBackColor = True
        '
        'EditorClearButton
        '
        Me.EditorClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorClearButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditorClearButton.Location = New System.Drawing.Point(102, 455)
        Me.EditorClearButton.Name = "EditorClearButton"
        Me.EditorClearButton.Size = New System.Drawing.Size(127, 23)
        Me.EditorClearButton.TabIndex = 105
        Me.EditorClearButton.Text = "Clear Selection"
        Me.EditorClearButton.UseVisualStyleBackColor = True
        '
        'EditorSelectButton
        '
        Me.EditorSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorSelectButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditorSelectButton.Location = New System.Drawing.Point(102, 415)
        Me.EditorSelectButton.Name = "EditorSelectButton"
        Me.EditorSelectButton.Size = New System.Drawing.Size(127, 23)
        Me.EditorSelectButton.TabIndex = 104
        Me.EditorSelectButton.Text = "Select All"
        Me.EditorSelectButton.UseVisualStyleBackColor = True
        '
        'EditorMultiButton
        '
        Me.EditorMultiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorMultiButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditorMultiButton.Location = New System.Drawing.Point(102, 375)
        Me.EditorMultiButton.Name = "EditorMultiButton"
        Me.EditorMultiButton.Size = New System.Drawing.Size(127, 23)
        Me.EditorMultiButton.TabIndex = 103
        Me.EditorMultiButton.Text = "Switch To Multi"
        Me.EditorMultiButton.UseVisualStyleBackColor = True
        '
        'EditorFilterButton
        '
        Me.EditorFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorFilterButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditorFilterButton.Location = New System.Drawing.Point(655, 31)
        Me.EditorFilterButton.Name = "EditorFilterButton"
        Me.EditorFilterButton.Size = New System.Drawing.Size(106, 21)
        Me.EditorFilterButton.TabIndex = 102
        Me.EditorFilterButton.Text = "Filter List"
        Me.EditorFilterButton.UseVisualStyleBackColor = True
        '
        'EditorImportButton
        '
        Me.EditorImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorImportButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditorImportButton.Location = New System.Drawing.Point(102, 295)
        Me.EditorImportButton.Name = "EditorImportButton"
        Me.EditorImportButton.Size = New System.Drawing.Size(127, 23)
        Me.EditorImportButton.TabIndex = 100
        Me.EditorImportButton.Text = "Import Item"
        Me.EditorImportButton.UseVisualStyleBackColor = True
        '
        'EditorDeleteButton
        '
        Me.EditorDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorDeleteButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditorDeleteButton.Location = New System.Drawing.Point(102, 255)
        Me.EditorDeleteButton.Name = "EditorDeleteButton"
        Me.EditorDeleteButton.Size = New System.Drawing.Size(127, 23)
        Me.EditorDeleteButton.TabIndex = 99
        Me.EditorDeleteButton.Text = "Delete Item"
        Me.EditorDeleteButton.UseVisualStyleBackColor = True
        '
        'EditorCopyButton
        '
        Me.EditorCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorCopyButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditorCopyButton.Location = New System.Drawing.Point(102, 215)
        Me.EditorCopyButton.Name = "EditorCopyButton"
        Me.EditorCopyButton.Size = New System.Drawing.Size(127, 23)
        Me.EditorCopyButton.TabIndex = 98
        Me.EditorCopyButton.Text = "Copy Item"
        Me.EditorCopyButton.UseVisualStyleBackColor = True
        '
        'EditorCountText
        '
        Me.EditorCountText.Location = New System.Drawing.Point(3, 55)
        Me.EditorCountText.Name = "EditorCountText"
        Me.EditorCountText.Size = New System.Drawing.Size(325, 23)
        Me.EditorCountText.TabIndex = 97
        Me.EditorCountText.Text = "#"
        Me.EditorCountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditorAddButton
        '
        Me.EditorAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorAddButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.EditorAddButton.Location = New System.Drawing.Point(102, 135)
        Me.EditorAddButton.Name = "EditorAddButton"
        Me.EditorAddButton.Size = New System.Drawing.Size(127, 23)
        Me.EditorAddButton.TabIndex = 96
        Me.EditorAddButton.Text = "Add Item"
        Me.EditorAddButton.UseVisualStyleBackColor = True
        '
        'EditorDBText
        '
        Me.EditorDBText.Location = New System.Drawing.Point(147, 5)
        Me.EditorDBText.Name = "EditorDBText"
        Me.EditorDBText.Size = New System.Drawing.Size(181, 23)
        Me.EditorDBText.TabIndex = 95
        Me.EditorDBText.Text = "FILENAME"
        Me.EditorDBText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EditorDBLabel
        '
        Me.EditorDBLabel.Location = New System.Drawing.Point(3, 5)
        Me.EditorDBLabel.Name = "EditorDBLabel"
        Me.EditorDBLabel.Size = New System.Drawing.Size(143, 23)
        Me.EditorDBLabel.TabIndex = 83
        Me.EditorDBLabel.Text = "Active Database:"
        Me.EditorDBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EditorDrop
        '
        Me.EditorDrop.BackColor = System.Drawing.SystemColors.ControlText
        Me.EditorDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EditorDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorDrop.ForeColor = System.Drawing.SystemColors.Control
        Me.EditorDrop.FormattingEnabled = True
        Me.EditorDrop.Location = New System.Drawing.Point(3, 31)
        Me.EditorDrop.Name = "EditorDrop"
        Me.EditorDrop.Size = New System.Drawing.Size(325, 21)
        Me.EditorDrop.TabIndex = 44
        '
        'EditorList
        '
        Me.EditorList.BackColor = System.Drawing.SystemColors.ControlText
        Me.EditorList.ForeColor = System.Drawing.SystemColors.Control
        Me.EditorList.FormattingEnabled = True
        Me.EditorList.Location = New System.Drawing.Point(334, 57)
        Me.EditorList.Name = "EditorList"
        Me.EditorList.Size = New System.Drawing.Size(427, 420)
        Me.EditorList.Sorted = True
        Me.EditorList.TabIndex = 43
        '
        'EditorCatText
        '
        Me.EditorCatText.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorCatText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EditorCatText.Location = New System.Drawing.Point(336, 5)
        Me.EditorCatText.Name = "EditorCatText"
        Me.EditorCatText.Size = New System.Drawing.Size(425, 21)
        Me.EditorCatText.TabIndex = 42
        Me.EditorCatText.Text = "Category Name"
        Me.EditorCatText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditorBackButton
        '
        Me.EditorBackButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.EditorBackButton.BackgroundImage = Global.Limitless.My.Resources.Resources.back
        Me.EditorBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditorBackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditorBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditorBackButton.ForeColor = System.Drawing.SystemColors.Control
        Me.EditorBackButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EditorBackButton.Location = New System.Drawing.Point(3, 489)
        Me.EditorBackButton.Name = "EditorBackButton"
        Me.EditorBackButton.Size = New System.Drawing.Size(50, 50)
        Me.EditorBackButton.TabIndex = 32
        Me.EditorBackButton.UseVisualStyleBackColor = False
        '
        'mmmCheck
        '
        Me.mmmCheck.AutoSize = True
        Me.mmmCheck.Location = New System.Drawing.Point(102, 505)
        Me.mmmCheck.Name = "mmmCheck"
        Me.mmmCheck.Size = New System.Drawing.Size(138, 17)
        Me.mmmCheck.TabIndex = 111
        Me.mmmCheck.Text = "Mod Maker Mode"
        Me.mmmCheck.UseVisualStyleBackColor = True
        '
        'Editor
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
        Me.Name = "Editor"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Limitless Editor"
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
    Friend WithEvents EditorBackButton As Button
    Friend WithEvents EditorList As ListBox
    Friend WithEvents EditorCatText As Label
    Friend WithEvents EditorDrop As ComboBox
    Friend WithEvents EditorDBLabel As Label
    Friend WithEvents EditorDBText As Label
    Friend WithEvents EditorCountText As Label
    Friend WithEvents EditorAddButton As Button
    Friend WithEvents EditorImportButton As Button
    Friend WithEvents EditorDeleteButton As Button
    Friend WithEvents EditorCopyButton As Button
    Friend WithEvents EditorSearchButton As Button
    Friend WithEvents EditorEditButton As Button
    Friend WithEvents EditorClearButton As Button
    Friend WithEvents EditorSelectButton As Button
    Friend WithEvents EditorMultiButton As Button
    Friend WithEvents EditorFilterButton As Button
    Friend WithEvents EditorLowText As Label
    Friend WithEvents EditorDescText As Label
    Friend WithEvents EditorFilterText As TextBox
    Friend WithEvents mmmCheck As CheckBox
End Class

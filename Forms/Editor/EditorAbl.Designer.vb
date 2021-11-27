<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorAbl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorAbl))
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.EditorPanel = New System.Windows.Forms.Panel()
        Me.MultiLabel = New System.Windows.Forms.Label()
        Me.Prof3Button = New System.Windows.Forms.Button()
        Me.Prof2Button = New System.Windows.Forms.Button()
        Me.Prof3Drop = New System.Windows.Forms.ComboBox()
        Me.Prof2Drop = New System.Windows.Forms.ComboBox()
        Me.Prof1Drop = New System.Windows.Forms.ComboBox()
        Me.Prof3Text = New System.Windows.Forms.TextBox()
        Me.Prof2Text = New System.Windows.Forms.TextBox()
        Me.Prof1Text = New System.Windows.Forms.TextBox()
        Me.ProfLabel = New System.Windows.Forms.Label()
        Me.EffList = New System.Windows.Forms.ListBox()
        Me.EffLabel = New System.Windows.Forms.Label()
        Me.ElemDrop = New System.Windows.Forms.ComboBox()
        Me.ElemLabel = New System.Windows.Forms.Label()
        Me.Impact3Button = New System.Windows.Forms.Button()
        Me.Impact2Button = New System.Windows.Forms.Button()
        Me.Impact3Drop = New System.Windows.Forms.ComboBox()
        Me.Impact2Drop = New System.Windows.Forms.ComboBox()
        Me.Impact1Drop = New System.Windows.Forms.ComboBox()
        Me.Impact3Text = New System.Windows.Forms.TextBox()
        Me.Impact2Text = New System.Windows.Forms.TextBox()
        Me.Impact1Text = New System.Windows.Forms.TextBox()
        Me.ImpactLabel = New System.Windows.Forms.Label()
        Me.AllCheck = New System.Windows.Forms.CheckBox()
        Me.MultiCheck = New System.Windows.Forms.CheckBox()
        Me.EnemyCheck = New System.Windows.Forms.CheckBox()
        Me.AllyCheck = New System.Windows.Forms.CheckBox()
        Me.SelfCheck = New System.Windows.Forms.CheckBox()
        Me.Cost3Button = New System.Windows.Forms.Button()
        Me.Cost2Button = New System.Windows.Forms.Button()
        Me.Cost3Drop = New System.Windows.Forms.ComboBox()
        Me.Cost2Drop = New System.Windows.Forms.ComboBox()
        Me.Cost1Drop = New System.Windows.Forms.ComboBox()
        Me.TargetLabel = New System.Windows.Forms.Label()
        Me.Cost3Text = New System.Windows.Forms.TextBox()
        Me.Cost2Text = New System.Windows.Forms.TextBox()
        Me.Cost1Text = New System.Windows.Forms.TextBox()
        Me.CostLabel = New System.Windows.Forms.Label()
        Me.TypeDrop = New System.Windows.Forms.ComboBox()
        Me.AblCancelButton = New System.Windows.Forms.Button()
        Me.AblSaveButton = New System.Windows.Forms.Button()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.DescText = New System.Windows.Forms.TextBox()
        Me.DescLabel = New System.Windows.Forms.Label()
        Me.AblLabel = New System.Windows.Forms.Label()
        Me.AblText = New System.Windows.Forms.TextBox()
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
        Me.TitleBarPanel.Size = New System.Drawing.Size(1000, 30)
        Me.TitleBarPanel.TabIndex = 8
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButton.Controls.Add(Me.CloseText)
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CloseButton.Location = New System.Drawing.Point(972, 4)
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
        Me.TitleLabel.Size = New System.Drawing.Size(998, 20)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Limitless Abilities Editor"
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
        Me.BackgroundPanel.Size = New System.Drawing.Size(1000, 470)
        Me.BackgroundPanel.TabIndex = 9
        '
        'EditorPanel
        '
        Me.EditorPanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.EditorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EditorPanel.Controls.Add(Me.MultiLabel)
        Me.EditorPanel.Controls.Add(Me.Prof3Button)
        Me.EditorPanel.Controls.Add(Me.Prof2Button)
        Me.EditorPanel.Controls.Add(Me.Prof3Drop)
        Me.EditorPanel.Controls.Add(Me.Prof2Drop)
        Me.EditorPanel.Controls.Add(Me.Prof1Drop)
        Me.EditorPanel.Controls.Add(Me.Prof3Text)
        Me.EditorPanel.Controls.Add(Me.Prof2Text)
        Me.EditorPanel.Controls.Add(Me.Prof1Text)
        Me.EditorPanel.Controls.Add(Me.ProfLabel)
        Me.EditorPanel.Controls.Add(Me.EffList)
        Me.EditorPanel.Controls.Add(Me.EffLabel)
        Me.EditorPanel.Controls.Add(Me.ElemDrop)
        Me.EditorPanel.Controls.Add(Me.ElemLabel)
        Me.EditorPanel.Controls.Add(Me.Impact3Button)
        Me.EditorPanel.Controls.Add(Me.Impact2Button)
        Me.EditorPanel.Controls.Add(Me.Impact3Drop)
        Me.EditorPanel.Controls.Add(Me.Impact2Drop)
        Me.EditorPanel.Controls.Add(Me.Impact1Drop)
        Me.EditorPanel.Controls.Add(Me.Impact3Text)
        Me.EditorPanel.Controls.Add(Me.Impact2Text)
        Me.EditorPanel.Controls.Add(Me.Impact1Text)
        Me.EditorPanel.Controls.Add(Me.ImpactLabel)
        Me.EditorPanel.Controls.Add(Me.AllCheck)
        Me.EditorPanel.Controls.Add(Me.MultiCheck)
        Me.EditorPanel.Controls.Add(Me.EnemyCheck)
        Me.EditorPanel.Controls.Add(Me.AllyCheck)
        Me.EditorPanel.Controls.Add(Me.SelfCheck)
        Me.EditorPanel.Controls.Add(Me.Cost3Button)
        Me.EditorPanel.Controls.Add(Me.Cost2Button)
        Me.EditorPanel.Controls.Add(Me.Cost3Drop)
        Me.EditorPanel.Controls.Add(Me.Cost2Drop)
        Me.EditorPanel.Controls.Add(Me.Cost1Drop)
        Me.EditorPanel.Controls.Add(Me.TargetLabel)
        Me.EditorPanel.Controls.Add(Me.Cost3Text)
        Me.EditorPanel.Controls.Add(Me.Cost2Text)
        Me.EditorPanel.Controls.Add(Me.Cost1Text)
        Me.EditorPanel.Controls.Add(Me.CostLabel)
        Me.EditorPanel.Controls.Add(Me.TypeDrop)
        Me.EditorPanel.Controls.Add(Me.AblCancelButton)
        Me.EditorPanel.Controls.Add(Me.AblSaveButton)
        Me.EditorPanel.Controls.Add(Me.TypeLabel)
        Me.EditorPanel.Controls.Add(Me.DescText)
        Me.EditorPanel.Controls.Add(Me.DescLabel)
        Me.EditorPanel.Controls.Add(Me.AblLabel)
        Me.EditorPanel.Controls.Add(Me.AblText)
        Me.EditorPanel.Location = New System.Drawing.Point(10, 9)
        Me.EditorPanel.Name = "EditorPanel"
        Me.EditorPanel.Size = New System.Drawing.Size(976, 447)
        Me.EditorPanel.TabIndex = 11
        '
        'MultiLabel
        '
        Me.MultiLabel.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiLabel.Location = New System.Drawing.Point(625, 196)
        Me.MultiLabel.Name = "MultiLabel"
        Me.MultiLabel.Size = New System.Drawing.Size(326, 23)
        Me.MultiLabel.TabIndex = 160
        Me.MultiLabel.Text = "Multiple Select Allowed"
        Me.MultiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Prof3Button
        '
        Me.Prof3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Prof3Button.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.Prof3Button.Location = New System.Drawing.Point(600, 280)
        Me.Prof3Button.Name = "Prof3Button"
        Me.Prof3Button.Size = New System.Drawing.Size(20, 20)
        Me.Prof3Button.TabIndex = 159
        Me.Prof3Button.Text = "+"
        Me.Prof3Button.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Prof3Button.UseVisualStyleBackColor = True
        '
        'Prof2Button
        '
        Me.Prof2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Prof2Button.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.Prof2Button.Location = New System.Drawing.Point(600, 254)
        Me.Prof2Button.Name = "Prof2Button"
        Me.Prof2Button.Size = New System.Drawing.Size(20, 20)
        Me.Prof2Button.TabIndex = 158
        Me.Prof2Button.Text = "+"
        Me.Prof2Button.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Prof2Button.UseVisualStyleBackColor = True
        '
        'Prof3Drop
        '
        Me.Prof3Drop.BackColor = System.Drawing.SystemColors.ControlText
        Me.Prof3Drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Prof3Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Prof3Drop.ForeColor = System.Drawing.SystemColors.Control
        Me.Prof3Drop.FormattingEnabled = True
        Me.Prof3Drop.Location = New System.Drawing.Point(712, 280)
        Me.Prof3Drop.Name = "Prof3Drop"
        Me.Prof3Drop.Size = New System.Drawing.Size(239, 21)
        Me.Prof3Drop.TabIndex = 157
        '
        'Prof2Drop
        '
        Me.Prof2Drop.BackColor = System.Drawing.SystemColors.ControlText
        Me.Prof2Drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Prof2Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Prof2Drop.ForeColor = System.Drawing.SystemColors.Control
        Me.Prof2Drop.FormattingEnabled = True
        Me.Prof2Drop.Location = New System.Drawing.Point(712, 254)
        Me.Prof2Drop.Name = "Prof2Drop"
        Me.Prof2Drop.Size = New System.Drawing.Size(239, 21)
        Me.Prof2Drop.TabIndex = 156
        '
        'Prof1Drop
        '
        Me.Prof1Drop.BackColor = System.Drawing.SystemColors.ControlText
        Me.Prof1Drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Prof1Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Prof1Drop.ForeColor = System.Drawing.SystemColors.Control
        Me.Prof1Drop.FormattingEnabled = True
        Me.Prof1Drop.Location = New System.Drawing.Point(712, 228)
        Me.Prof1Drop.Name = "Prof1Drop"
        Me.Prof1Drop.Size = New System.Drawing.Size(239, 21)
        Me.Prof1Drop.TabIndex = 155
        '
        'Prof3Text
        '
        Me.Prof3Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Prof3Text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Prof3Text.ForeColor = System.Drawing.SystemColors.Window
        Me.Prof3Text.Location = New System.Drawing.Point(626, 280)
        Me.Prof3Text.MaxLength = 5
        Me.Prof3Text.Name = "Prof3Text"
        Me.Prof3Text.ReadOnly = True
        Me.Prof3Text.Size = New System.Drawing.Size(80, 20)
        Me.Prof3Text.TabIndex = 154
        Me.Prof3Text.TabStop = False
        Me.Prof3Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Prof2Text
        '
        Me.Prof2Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Prof2Text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Prof2Text.ForeColor = System.Drawing.SystemColors.Window
        Me.Prof2Text.Location = New System.Drawing.Point(626, 254)
        Me.Prof2Text.MaxLength = 5
        Me.Prof2Text.Name = "Prof2Text"
        Me.Prof2Text.ReadOnly = True
        Me.Prof2Text.Size = New System.Drawing.Size(80, 20)
        Me.Prof2Text.TabIndex = 153
        Me.Prof2Text.TabStop = False
        Me.Prof2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Prof1Text
        '
        Me.Prof1Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Prof1Text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Prof1Text.ForeColor = System.Drawing.SystemColors.Window
        Me.Prof1Text.Location = New System.Drawing.Point(625, 228)
        Me.Prof1Text.MaxLength = 5
        Me.Prof1Text.Name = "Prof1Text"
        Me.Prof1Text.ReadOnly = True
        Me.Prof1Text.Size = New System.Drawing.Size(80, 20)
        Me.Prof1Text.TabIndex = 152
        Me.Prof1Text.TabStop = False
        Me.Prof1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProfLabel
        '
        Me.ProfLabel.Location = New System.Drawing.Point(491, 216)
        Me.ProfLabel.Name = "ProfLabel"
        Me.ProfLabel.Size = New System.Drawing.Size(128, 32)
        Me.ProfLabel.TabIndex = 151
        Me.ProfLabel.Text = "Proficiencies Required:"
        Me.ProfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EffList
        '
        Me.EffList.BackColor = System.Drawing.SystemColors.ControlText
        Me.EffList.ForeColor = System.Drawing.SystemColors.Control
        Me.EffList.FormattingEnabled = True
        Me.EffList.Location = New System.Drawing.Point(625, 50)
        Me.EffList.Name = "EffList"
        Me.EffList.Size = New System.Drawing.Size(326, 147)
        Me.EffList.Sorted = True
        Me.EffList.TabIndex = 150
        '
        'EffLabel
        '
        Me.EffLabel.Location = New System.Drawing.Point(491, 50)
        Me.EffLabel.Name = "EffLabel"
        Me.EffLabel.Size = New System.Drawing.Size(128, 23)
        Me.EffLabel.TabIndex = 149
        Me.EffLabel.Text = "Added Effects:"
        Me.EffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ElemDrop
        '
        Me.ElemDrop.BackColor = System.Drawing.SystemColors.ControlText
        Me.ElemDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ElemDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ElemDrop.ForeColor = System.Drawing.SystemColors.Control
        Me.ElemDrop.FormattingEnabled = True
        Me.ElemDrop.Location = New System.Drawing.Point(626, 14)
        Me.ElemDrop.Name = "ElemDrop"
        Me.ElemDrop.Size = New System.Drawing.Size(325, 21)
        Me.ElemDrop.TabIndex = 148
        '
        'ElemLabel
        '
        Me.ElemLabel.Location = New System.Drawing.Point(491, 14)
        Me.ElemLabel.Name = "ElemLabel"
        Me.ElemLabel.Size = New System.Drawing.Size(128, 23)
        Me.ElemLabel.TabIndex = 147
        Me.ElemLabel.Text = "Element Type:"
        Me.ElemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Impact3Button
        '
        Me.Impact3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Impact3Button.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.Impact3Button.Location = New System.Drawing.Point(111, 352)
        Me.Impact3Button.Name = "Impact3Button"
        Me.Impact3Button.Size = New System.Drawing.Size(20, 20)
        Me.Impact3Button.TabIndex = 146
        Me.Impact3Button.Text = "+"
        Me.Impact3Button.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Impact3Button.UseVisualStyleBackColor = True
        '
        'Impact2Button
        '
        Me.Impact2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Impact2Button.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.Impact2Button.Location = New System.Drawing.Point(111, 326)
        Me.Impact2Button.Name = "Impact2Button"
        Me.Impact2Button.Size = New System.Drawing.Size(20, 20)
        Me.Impact2Button.TabIndex = 145
        Me.Impact2Button.Text = "+"
        Me.Impact2Button.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Impact2Button.UseVisualStyleBackColor = True
        '
        'Impact3Drop
        '
        Me.Impact3Drop.BackColor = System.Drawing.SystemColors.ControlText
        Me.Impact3Drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Impact3Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Impact3Drop.ForeColor = System.Drawing.SystemColors.Control
        Me.Impact3Drop.FormattingEnabled = True
        Me.Impact3Drop.Location = New System.Drawing.Point(223, 352)
        Me.Impact3Drop.Name = "Impact3Drop"
        Me.Impact3Drop.Size = New System.Drawing.Size(239, 21)
        Me.Impact3Drop.TabIndex = 144
        '
        'Impact2Drop
        '
        Me.Impact2Drop.BackColor = System.Drawing.SystemColors.ControlText
        Me.Impact2Drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Impact2Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Impact2Drop.ForeColor = System.Drawing.SystemColors.Control
        Me.Impact2Drop.FormattingEnabled = True
        Me.Impact2Drop.Location = New System.Drawing.Point(223, 326)
        Me.Impact2Drop.Name = "Impact2Drop"
        Me.Impact2Drop.Size = New System.Drawing.Size(239, 21)
        Me.Impact2Drop.TabIndex = 143
        '
        'Impact1Drop
        '
        Me.Impact1Drop.BackColor = System.Drawing.SystemColors.ControlText
        Me.Impact1Drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Impact1Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Impact1Drop.ForeColor = System.Drawing.SystemColors.Control
        Me.Impact1Drop.FormattingEnabled = True
        Me.Impact1Drop.Location = New System.Drawing.Point(223, 300)
        Me.Impact1Drop.Name = "Impact1Drop"
        Me.Impact1Drop.Size = New System.Drawing.Size(239, 21)
        Me.Impact1Drop.TabIndex = 142
        '
        'Impact3Text
        '
        Me.Impact3Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Impact3Text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Impact3Text.ForeColor = System.Drawing.SystemColors.Window
        Me.Impact3Text.Location = New System.Drawing.Point(137, 352)
        Me.Impact3Text.MaxLength = 5
        Me.Impact3Text.Name = "Impact3Text"
        Me.Impact3Text.ReadOnly = True
        Me.Impact3Text.Size = New System.Drawing.Size(80, 20)
        Me.Impact3Text.TabIndex = 141
        Me.Impact3Text.TabStop = False
        Me.Impact3Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Impact2Text
        '
        Me.Impact2Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Impact2Text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Impact2Text.ForeColor = System.Drawing.SystemColors.Window
        Me.Impact2Text.Location = New System.Drawing.Point(137, 326)
        Me.Impact2Text.MaxLength = 5
        Me.Impact2Text.Name = "Impact2Text"
        Me.Impact2Text.ReadOnly = True
        Me.Impact2Text.Size = New System.Drawing.Size(80, 20)
        Me.Impact2Text.TabIndex = 140
        Me.Impact2Text.TabStop = False
        Me.Impact2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Impact1Text
        '
        Me.Impact1Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Impact1Text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Impact1Text.ForeColor = System.Drawing.SystemColors.Window
        Me.Impact1Text.Location = New System.Drawing.Point(136, 300)
        Me.Impact1Text.MaxLength = 5
        Me.Impact1Text.Name = "Impact1Text"
        Me.Impact1Text.ReadOnly = True
        Me.Impact1Text.Size = New System.Drawing.Size(80, 20)
        Me.Impact1Text.TabIndex = 139
        Me.Impact1Text.TabStop = False
        Me.Impact1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImpactLabel
        '
        Me.ImpactLabel.Location = New System.Drawing.Point(3, 300)
        Me.ImpactLabel.Name = "ImpactLabel"
        Me.ImpactLabel.Size = New System.Drawing.Size(128, 23)
        Me.ImpactLabel.TabIndex = 138
        Me.ImpactLabel.Text = "Ability Impact:"
        Me.ImpactLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AllCheck
        '
        Me.AllCheck.AutoSize = True
        Me.AllCheck.Location = New System.Drawing.Point(409, 269)
        Me.AllCheck.Name = "AllCheck"
        Me.AllCheck.Size = New System.Drawing.Size(50, 17)
        Me.AllCheck.TabIndex = 137
        Me.AllCheck.Text = "All"
        Me.AllCheck.UseVisualStyleBackColor = True
        '
        'MultiCheck
        '
        Me.MultiCheck.AutoSize = True
        Me.MultiCheck.Location = New System.Drawing.Point(337, 269)
        Me.MultiCheck.Name = "MultiCheck"
        Me.MultiCheck.Size = New System.Drawing.Size(66, 17)
        Me.MultiCheck.TabIndex = 136
        Me.MultiCheck.Text = "Multi"
        Me.MultiCheck.UseVisualStyleBackColor = True
        '
        'EnemyCheck
        '
        Me.EnemyCheck.AutoSize = True
        Me.EnemyCheck.Location = New System.Drawing.Point(265, 269)
        Me.EnemyCheck.Name = "EnemyCheck"
        Me.EnemyCheck.Size = New System.Drawing.Size(66, 17)
        Me.EnemyCheck.TabIndex = 135
        Me.EnemyCheck.Text = "Enemy"
        Me.EnemyCheck.UseVisualStyleBackColor = True
        '
        'AllyCheck
        '
        Me.AllyCheck.AutoSize = True
        Me.AllyCheck.Location = New System.Drawing.Point(201, 269)
        Me.AllyCheck.Name = "AllyCheck"
        Me.AllyCheck.Size = New System.Drawing.Size(58, 17)
        Me.AllyCheck.TabIndex = 134
        Me.AllyCheck.Text = "Ally"
        Me.AllyCheck.UseVisualStyleBackColor = True
        '
        'SelfCheck
        '
        Me.SelfCheck.AutoSize = True
        Me.SelfCheck.Location = New System.Drawing.Point(137, 269)
        Me.SelfCheck.Name = "SelfCheck"
        Me.SelfCheck.Size = New System.Drawing.Size(58, 17)
        Me.SelfCheck.TabIndex = 133
        Me.SelfCheck.Text = "Self"
        Me.SelfCheck.UseVisualStyleBackColor = True
        '
        'Cost3Button
        '
        Me.Cost3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cost3Button.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.Cost3Button.Location = New System.Drawing.Point(111, 227)
        Me.Cost3Button.Name = "Cost3Button"
        Me.Cost3Button.Size = New System.Drawing.Size(20, 20)
        Me.Cost3Button.TabIndex = 132
        Me.Cost3Button.Text = "+"
        Me.Cost3Button.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cost3Button.UseVisualStyleBackColor = True
        '
        'Cost2Button
        '
        Me.Cost2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cost2Button.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.Cost2Button.Location = New System.Drawing.Point(111, 201)
        Me.Cost2Button.Name = "Cost2Button"
        Me.Cost2Button.Size = New System.Drawing.Size(20, 20)
        Me.Cost2Button.TabIndex = 131
        Me.Cost2Button.Text = "+"
        Me.Cost2Button.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cost2Button.UseVisualStyleBackColor = True
        '
        'Cost3Drop
        '
        Me.Cost3Drop.BackColor = System.Drawing.SystemColors.ControlText
        Me.Cost3Drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cost3Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cost3Drop.ForeColor = System.Drawing.SystemColors.Control
        Me.Cost3Drop.FormattingEnabled = True
        Me.Cost3Drop.Location = New System.Drawing.Point(223, 227)
        Me.Cost3Drop.Name = "Cost3Drop"
        Me.Cost3Drop.Size = New System.Drawing.Size(239, 21)
        Me.Cost3Drop.TabIndex = 130
        '
        'Cost2Drop
        '
        Me.Cost2Drop.BackColor = System.Drawing.SystemColors.ControlText
        Me.Cost2Drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cost2Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cost2Drop.ForeColor = System.Drawing.SystemColors.Control
        Me.Cost2Drop.FormattingEnabled = True
        Me.Cost2Drop.Location = New System.Drawing.Point(223, 201)
        Me.Cost2Drop.Name = "Cost2Drop"
        Me.Cost2Drop.Size = New System.Drawing.Size(239, 21)
        Me.Cost2Drop.TabIndex = 129
        '
        'Cost1Drop
        '
        Me.Cost1Drop.BackColor = System.Drawing.SystemColors.ControlText
        Me.Cost1Drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cost1Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cost1Drop.ForeColor = System.Drawing.SystemColors.Control
        Me.Cost1Drop.FormattingEnabled = True
        Me.Cost1Drop.Location = New System.Drawing.Point(223, 175)
        Me.Cost1Drop.Name = "Cost1Drop"
        Me.Cost1Drop.Size = New System.Drawing.Size(239, 21)
        Me.Cost1Drop.TabIndex = 128
        '
        'TargetLabel
        '
        Me.TargetLabel.Location = New System.Drawing.Point(3, 265)
        Me.TargetLabel.Name = "TargetLabel"
        Me.TargetLabel.Size = New System.Drawing.Size(128, 23)
        Me.TargetLabel.TabIndex = 127
        Me.TargetLabel.Text = "Target Type:"
        Me.TargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cost3Text
        '
        Me.Cost3Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cost3Text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cost3Text.ForeColor = System.Drawing.SystemColors.Window
        Me.Cost3Text.Location = New System.Drawing.Point(137, 227)
        Me.Cost3Text.MaxLength = 5
        Me.Cost3Text.Name = "Cost3Text"
        Me.Cost3Text.ReadOnly = True
        Me.Cost3Text.Size = New System.Drawing.Size(80, 20)
        Me.Cost3Text.TabIndex = 125
        Me.Cost3Text.TabStop = False
        Me.Cost3Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cost2Text
        '
        Me.Cost2Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cost2Text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cost2Text.ForeColor = System.Drawing.SystemColors.Window
        Me.Cost2Text.Location = New System.Drawing.Point(137, 201)
        Me.Cost2Text.MaxLength = 5
        Me.Cost2Text.Name = "Cost2Text"
        Me.Cost2Text.ReadOnly = True
        Me.Cost2Text.Size = New System.Drawing.Size(80, 20)
        Me.Cost2Text.TabIndex = 123
        Me.Cost2Text.TabStop = False
        Me.Cost2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cost1Text
        '
        Me.Cost1Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cost1Text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cost1Text.ForeColor = System.Drawing.SystemColors.Window
        Me.Cost1Text.Location = New System.Drawing.Point(136, 175)
        Me.Cost1Text.MaxLength = 5
        Me.Cost1Text.Name = "Cost1Text"
        Me.Cost1Text.ReadOnly = True
        Me.Cost1Text.Size = New System.Drawing.Size(80, 20)
        Me.Cost1Text.TabIndex = 121
        Me.Cost1Text.TabStop = False
        Me.Cost1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostLabel
        '
        Me.CostLabel.Location = New System.Drawing.Point(3, 175)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(128, 23)
        Me.CostLabel.TabIndex = 120
        Me.CostLabel.Text = "Ability Cost:"
        Me.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TypeDrop
        '
        Me.TypeDrop.BackColor = System.Drawing.SystemColors.ControlText
        Me.TypeDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TypeDrop.ForeColor = System.Drawing.SystemColors.Control
        Me.TypeDrop.FormattingEnabled = True
        Me.TypeDrop.Location = New System.Drawing.Point(137, 140)
        Me.TypeDrop.Name = "TypeDrop"
        Me.TypeDrop.Size = New System.Drawing.Size(325, 21)
        Me.TypeDrop.TabIndex = 119
        '
        'AblCancelButton
        '
        Me.AblCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AblCancelButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.AblCancelButton.Location = New System.Drawing.Point(494, 405)
        Me.AblCancelButton.Name = "AblCancelButton"
        Me.AblCancelButton.Size = New System.Drawing.Size(125, 23)
        Me.AblCancelButton.TabIndex = 118
        Me.AblCancelButton.Text = "Cancel"
        Me.AblCancelButton.UseVisualStyleBackColor = True
        '
        'AblSaveButton
        '
        Me.AblSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AblSaveButton.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.AblSaveButton.Location = New System.Drawing.Point(354, 405)
        Me.AblSaveButton.Name = "AblSaveButton"
        Me.AblSaveButton.Size = New System.Drawing.Size(125, 23)
        Me.AblSaveButton.TabIndex = 117
        Me.AblSaveButton.Text = "Save Changes"
        Me.AblSaveButton.UseVisualStyleBackColor = True
        '
        'TypeLabel
        '
        Me.TypeLabel.Location = New System.Drawing.Point(2, 140)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(128, 23)
        Me.TypeLabel.TabIndex = 116
        Me.TypeLabel.Text = "Ability Type:"
        Me.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'AblLabel
        '
        Me.AblLabel.Location = New System.Drawing.Point(2, 15)
        Me.AblLabel.Name = "AblLabel"
        Me.AblLabel.Size = New System.Drawing.Size(128, 23)
        Me.AblLabel.TabIndex = 112
        Me.AblLabel.Text = "Ability Name:"
        Me.AblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AblText
        '
        Me.AblText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AblText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AblText.ForeColor = System.Drawing.SystemColors.Window
        Me.AblText.Location = New System.Drawing.Point(136, 17)
        Me.AblText.Name = "AblText"
        Me.AblText.ReadOnly = True
        Me.AblText.Size = New System.Drawing.Size(326, 20)
        Me.AblText.TabIndex = 111
        Me.AblText.TabStop = False
        '
        'EditorAbl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditorAbl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Abilites Editor"
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
    Friend WithEvents AblCancelButton As Button
    Friend WithEvents AblSaveButton As Button
    Friend WithEvents TypeLabel As Label
    Friend WithEvents DescText As TextBox
    Friend WithEvents DescLabel As Label
    Friend WithEvents AblLabel As Label
    Friend WithEvents AblText As TextBox
    Friend WithEvents Cost3Text As TextBox
    Friend WithEvents Cost2Text As TextBox
    Friend WithEvents Cost1Text As TextBox
    Friend WithEvents CostLabel As Label
    Friend WithEvents TypeDrop As ComboBox
    Friend WithEvents EffLabel As Label
    Friend WithEvents ElemDrop As ComboBox
    Friend WithEvents ElemLabel As Label
    Friend WithEvents Impact3Button As Button
    Friend WithEvents Impact2Button As Button
    Friend WithEvents Impact3Drop As ComboBox
    Friend WithEvents Impact2Drop As ComboBox
    Friend WithEvents Impact1Drop As ComboBox
    Friend WithEvents Impact3Text As TextBox
    Friend WithEvents Impact2Text As TextBox
    Friend WithEvents Impact1Text As TextBox
    Friend WithEvents ImpactLabel As Label
    Friend WithEvents AllCheck As CheckBox
    Friend WithEvents MultiCheck As CheckBox
    Friend WithEvents EnemyCheck As CheckBox
    Friend WithEvents AllyCheck As CheckBox
    Friend WithEvents SelfCheck As CheckBox
    Friend WithEvents Cost3Button As Button
    Friend WithEvents Cost2Button As Button
    Friend WithEvents Cost3Drop As ComboBox
    Friend WithEvents Cost2Drop As ComboBox
    Friend WithEvents Cost1Drop As ComboBox
    Friend WithEvents TargetLabel As Label
    Friend WithEvents Prof3Button As Button
    Friend WithEvents Prof2Button As Button
    Friend WithEvents Prof3Drop As ComboBox
    Friend WithEvents Prof2Drop As ComboBox
    Friend WithEvents Prof1Drop As ComboBox
    Friend WithEvents Prof3Text As TextBox
    Friend WithEvents Prof2Text As TextBox
    Friend WithEvents Prof1Text As TextBox
    Friend WithEvents ProfLabel As Label
    Friend WithEvents EffList As ListBox
    Friend WithEvents MultiLabel As Label
End Class

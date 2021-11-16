<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Abouter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Abouter))
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.AboutPanel = New System.Windows.Forms.Panel()
        Me.AboutBackButton = New System.Windows.Forms.Button()
        Me.AboutLicButton = New System.Windows.Forms.Button()
        Me.AboutReadButton = New System.Windows.Forms.Button()
        Me.AboutEMButton = New System.Windows.Forms.Button()
        Me.AboutRDButton = New System.Windows.Forms.Button()
        Me.AboutWBButton = New System.Windows.Forms.Button()
        Me.AboutTWButton = New System.Windows.Forms.Button()
        Me.AboutPPButton = New System.Windows.Forms.Button()
        Me.AboutPTButton = New System.Windows.Forms.Button()
        Me.AboutBSButton = New System.Windows.Forms.Button()
        Me.AboutYTButton = New System.Windows.Forms.Button()
        Me.AboutDCButton = New System.Windows.Forms.Button()
        Me.AboutFBButton = New System.Windows.Forms.Button()
        Me.AboutText = New System.Windows.Forms.TextBox()
        Me.MenuTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.TitleBarPanel.SuspendLayout()
        Me.CloseButton.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.AboutPanel.SuspendLayout()
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
        Me.TitleBarPanel.TabIndex = 3
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
        Me.TitleLabel.Text = "About Limitless"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BackgroundPanel.Controls.Add(Me.AboutPanel)
        Me.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundPanel.Location = New System.Drawing.Point(0, 30)
        Me.BackgroundPanel.Name = "BackgroundPanel"
        Me.BackgroundPanel.Size = New System.Drawing.Size(800, 570)
        Me.BackgroundPanel.TabIndex = 4
        '
        'AboutPanel
        '
        Me.AboutPanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.AboutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AboutPanel.Controls.Add(Me.AboutBackButton)
        Me.AboutPanel.Controls.Add(Me.AboutLicButton)
        Me.AboutPanel.Controls.Add(Me.AboutReadButton)
        Me.AboutPanel.Controls.Add(Me.AboutEMButton)
        Me.AboutPanel.Controls.Add(Me.AboutRDButton)
        Me.AboutPanel.Controls.Add(Me.AboutWBButton)
        Me.AboutPanel.Controls.Add(Me.AboutTWButton)
        Me.AboutPanel.Controls.Add(Me.AboutPPButton)
        Me.AboutPanel.Controls.Add(Me.AboutPTButton)
        Me.AboutPanel.Controls.Add(Me.AboutBSButton)
        Me.AboutPanel.Controls.Add(Me.AboutYTButton)
        Me.AboutPanel.Controls.Add(Me.AboutDCButton)
        Me.AboutPanel.Controls.Add(Me.AboutFBButton)
        Me.AboutPanel.Controls.Add(Me.AboutText)
        Me.AboutPanel.Location = New System.Drawing.Point(10, 9)
        Me.AboutPanel.Name = "AboutPanel"
        Me.AboutPanel.Size = New System.Drawing.Size(776, 544)
        Me.AboutPanel.TabIndex = 11
        Me.MenuTips.SetToolTip(Me.AboutPanel, "Back To Main Menu")
        '
        'AboutBackButton
        '
        Me.AboutBackButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.AboutBackButton.BackgroundImage = Global.Limitless.My.Resources.Resources.back
        Me.AboutBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutBackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutBackButton.ForeColor = System.Drawing.SystemColors.Control
        Me.AboutBackButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutBackButton.Location = New System.Drawing.Point(35, 470)
        Me.AboutBackButton.Name = "AboutBackButton"
        Me.AboutBackButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutBackButton.TabIndex = 31
        Me.MenuTips.SetToolTip(Me.AboutBackButton, "View The ReadMe!")
        Me.AboutBackButton.UseVisualStyleBackColor = False
        '
        'AboutLicButton
        '
        Me.AboutLicButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutLicButton.BackgroundImage = CType(resources.GetObject("AboutLicButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutLicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutLicButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutLicButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutLicButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutLicButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutLicButton.Location = New System.Drawing.Point(687, 470)
        Me.AboutLicButton.Name = "AboutLicButton"
        Me.AboutLicButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutLicButton.TabIndex = 30
        Me.MenuTips.SetToolTip(Me.AboutLicButton, "View the License Information")
        Me.AboutLicButton.UseVisualStyleBackColor = False
        '
        'AboutReadButton
        '
        Me.AboutReadButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutReadButton.BackgroundImage = CType(resources.GetObject("AboutReadButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutReadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutReadButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutReadButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutReadButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutReadButton.Location = New System.Drawing.Point(631, 470)
        Me.AboutReadButton.Name = "AboutReadButton"
        Me.AboutReadButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutReadButton.TabIndex = 29
        Me.MenuTips.SetToolTip(Me.AboutReadButton, "View The ReadMe!")
        Me.AboutReadButton.UseVisualStyleBackColor = False
        '
        'AboutEMButton
        '
        Me.AboutEMButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutEMButton.BackgroundImage = CType(resources.GetObject("AboutEMButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutEMButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutEMButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutEMButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutEMButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutEMButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutEMButton.Location = New System.Drawing.Point(576, 470)
        Me.AboutEMButton.Name = "AboutEMButton"
        Me.AboutEMButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutEMButton.TabIndex = 28
        Me.MenuTips.SetToolTip(Me.AboutEMButton, "Contact Us via E-Mail!")
        Me.AboutEMButton.UseVisualStyleBackColor = False
        '
        'AboutRDButton
        '
        Me.AboutRDButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutRDButton.BackgroundImage = CType(resources.GetObject("AboutRDButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutRDButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutRDButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutRDButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutRDButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutRDButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutRDButton.Location = New System.Drawing.Point(362, 470)
        Me.AboutRDButton.Name = "AboutRDButton"
        Me.AboutRDButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutRDButton.TabIndex = 27
        Me.MenuTips.SetToolTip(Me.AboutRDButton, "Join Us on Reddit!")
        Me.AboutRDButton.UseVisualStyleBackColor = False
        '
        'AboutWBButton
        '
        Me.AboutWBButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutWBButton.BackgroundImage = CType(resources.GetObject("AboutWBButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutWBButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutWBButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutWBButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutWBButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutWBButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutWBButton.Location = New System.Drawing.Point(91, 470)
        Me.AboutWBButton.Name = "AboutWBButton"
        Me.AboutWBButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutWBButton.TabIndex = 26
        Me.MenuTips.SetToolTip(Me.AboutWBButton, "Visit Us on the Web!")
        Me.AboutWBButton.UseVisualStyleBackColor = False
        '
        'AboutTWButton
        '
        Me.AboutTWButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutTWButton.BackgroundImage = CType(resources.GetObject("AboutTWButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutTWButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutTWButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutTWButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutTWButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutTWButton.Location = New System.Drawing.Point(199, 470)
        Me.AboutTWButton.Name = "AboutTWButton"
        Me.AboutTWButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutTWButton.TabIndex = 25
        Me.MenuTips.SetToolTip(Me.AboutTWButton, "Follow Us on Twitter!")
        Me.AboutTWButton.UseVisualStyleBackColor = False
        '
        'AboutPPButton
        '
        Me.AboutPPButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutPPButton.BackgroundImage = CType(resources.GetObject("AboutPPButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutPPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutPPButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutPPButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutPPButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutPPButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutPPButton.Location = New System.Drawing.Point(469, 470)
        Me.AboutPPButton.Name = "AboutPPButton"
        Me.AboutPPButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutPPButton.TabIndex = 24
        Me.MenuTips.SetToolTip(Me.AboutPPButton, "Support Us Through PayPal!")
        Me.AboutPPButton.UseVisualStyleBackColor = False
        '
        'AboutPTButton
        '
        Me.AboutPTButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutPTButton.BackgroundImage = CType(resources.GetObject("AboutPTButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutPTButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutPTButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutPTButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutPTButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutPTButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutPTButton.Location = New System.Drawing.Point(415, 470)
        Me.AboutPTButton.Name = "AboutPTButton"
        Me.AboutPTButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutPTButton.TabIndex = 23
        Me.MenuTips.SetToolTip(Me.AboutPTButton, "Become a Patreon!")
        Me.AboutPTButton.UseVisualStyleBackColor = False
        '
        'AboutBSButton
        '
        Me.AboutBSButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutBSButton.BackgroundImage = CType(resources.GetObject("AboutBSButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutBSButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutBSButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutBSButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutBSButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutBSButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutBSButton.Location = New System.Drawing.Point(523, 470)
        Me.AboutBSButton.Name = "AboutBSButton"
        Me.AboutBSButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutBSButton.TabIndex = 22
        Me.MenuTips.SetToolTip(Me.AboutBSButton, "Check Out Cool Music from Bensound.com!")
        Me.AboutBSButton.UseVisualStyleBackColor = False
        '
        'AboutYTButton
        '
        Me.AboutYTButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutYTButton.BackgroundImage = CType(resources.GetObject("AboutYTButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutYTButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutYTButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutYTButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutYTButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutYTButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutYTButton.Location = New System.Drawing.Point(308, 470)
        Me.AboutYTButton.Name = "AboutYTButton"
        Me.AboutYTButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutYTButton.TabIndex = 21
        Me.MenuTips.SetToolTip(Me.AboutYTButton, "Subscribe to Us on YouTube!")
        Me.AboutYTButton.UseVisualStyleBackColor = False
        '
        'AboutDCButton
        '
        Me.AboutDCButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutDCButton.BackgroundImage = CType(resources.GetObject("AboutDCButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutDCButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutDCButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutDCButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutDCButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutDCButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AboutDCButton.Location = New System.Drawing.Point(253, 470)
        Me.AboutDCButton.Name = "AboutDCButton"
        Me.AboutDCButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutDCButton.TabIndex = 20
        Me.MenuTips.SetToolTip(Me.AboutDCButton, "Join Us On Discord!")
        Me.AboutDCButton.UseVisualStyleBackColor = False
        '
        'AboutFBButton
        '
        Me.AboutFBButton.BackColor = System.Drawing.SystemColors.Control
        Me.AboutFBButton.BackgroundImage = CType(resources.GetObject("AboutFBButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutFBButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutFBButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutFBButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutFBButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutFBButton.Location = New System.Drawing.Point(145, 470)
        Me.AboutFBButton.Name = "AboutFBButton"
        Me.AboutFBButton.Size = New System.Drawing.Size(50, 50)
        Me.AboutFBButton.TabIndex = 19
        Me.MenuTips.SetToolTip(Me.AboutFBButton, "Like Us On Facebook!")
        Me.AboutFBButton.UseVisualStyleBackColor = False
        '
        'AboutText
        '
        Me.AboutText.BackColor = System.Drawing.SystemColors.ControlText
        Me.AboutText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AboutText.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AboutText.ForeColor = System.Drawing.SystemColors.Control
        Me.AboutText.Location = New System.Drawing.Point(37, 20)
        Me.AboutText.Multiline = True
        Me.AboutText.Name = "AboutText"
        Me.AboutText.ReadOnly = True
        Me.AboutText.Size = New System.Drawing.Size(700, 420)
        Me.AboutText.TabIndex = 2
        Me.AboutText.TabStop = False
        '
        'Abouter
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
        Me.Name = "Abouter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About Limitless"
        Me.TitleBarPanel.ResumeLayout(False)
        Me.CloseButton.ResumeLayout(False)
        Me.CloseButton.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.AboutPanel.ResumeLayout(False)
        Me.AboutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents CloseText As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents AboutPanel As Panel
    Friend WithEvents AboutText As TextBox
    Friend WithEvents AboutLicButton As Button
    Friend WithEvents AboutReadButton As Button
    Friend WithEvents AboutEMButton As Button
    Friend WithEvents AboutRDButton As Button
    Friend WithEvents AboutWBButton As Button
    Friend WithEvents AboutTWButton As Button
    Friend WithEvents AboutPPButton As Button
    Friend WithEvents AboutPTButton As Button
    Friend WithEvents AboutBSButton As Button
    Friend WithEvents AboutYTButton As Button
    Friend WithEvents AboutDCButton As Button
    Friend WithEvents AboutFBButton As Button
    Friend WithEvents MenuTips As ToolTip
    Friend WithEvents AboutBackButton As Button
End Class

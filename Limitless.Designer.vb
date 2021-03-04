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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.TitleBarIcon = New System.Windows.Forms.Panel()
        Me.MinimizeButton = New System.Windows.Forms.Panel()
        Me.MinimizeText = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.FooterPanel = New System.Windows.Forms.Panel()
        Me.MainMenuPanel = New System.Windows.Forms.Panel()
        Me.WelcomePanel = New System.Windows.Forms.Panel()
        Me.WelcomeImage0 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage1 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage2 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage4 = New System.Windows.Forms.PictureBox()
        Me.WelcomeImage3 = New System.Windows.Forms.PictureBox()
        Me.MainMenuBar = New System.Windows.Forms.Panel()
        Me.TitleLogo = New System.Windows.Forms.PictureBox()
        Me.TitleBarPanel.SuspendLayout()
        Me.MinimizeButton.SuspendLayout()
        Me.CloseButton.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.MainMenuPanel.SuspendLayout()
        Me.WelcomePanel.SuspendLayout()
        CType(Me.WelcomeImage0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeImage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        resources.ApplyResources(Me.TitleLabel, "TitleLabel")
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TitleLabel.Name = "TitleLabel"
        '
        'TitleBarPanel
        '
        Me.TitleBarPanel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TitleBarPanel.Controls.Add(Me.TitleBarIcon)
        Me.TitleBarPanel.Controls.Add(Me.MinimizeButton)
        Me.TitleBarPanel.Controls.Add(Me.CloseButton)
        Me.TitleBarPanel.Controls.Add(Me.TitleLabel)
        resources.ApplyResources(Me.TitleBarPanel, "TitleBarPanel")
        Me.TitleBarPanel.Name = "TitleBarPanel"
        '
        'TitleBarIcon
        '
        Me.TitleBarIcon.BackgroundImage = Global.Limitless.My.Resources.Resources.logo
        resources.ApplyResources(Me.TitleBarIcon, "TitleBarIcon")
        Me.TitleBarIcon.Name = "TitleBarIcon"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.MinimizeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MinimizeButton.Controls.Add(Me.MinimizeText)
        Me.MinimizeButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        resources.ApplyResources(Me.MinimizeButton, "MinimizeButton")
        Me.MinimizeButton.Name = "MinimizeButton"
        '
        'MinimizeText
        '
        resources.ApplyResources(Me.MinimizeText, "MinimizeText")
        Me.MinimizeText.BackColor = System.Drawing.SystemColors.WindowText
        Me.MinimizeText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.MinimizeText.Name = "MinimizeText"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButton.Controls.Add(Me.CloseText)
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        resources.ApplyResources(Me.CloseButton, "CloseButton")
        Me.CloseButton.Name = "CloseButton"
        '
        'CloseText
        '
        resources.ApplyResources(Me.CloseText, "CloseText")
        Me.CloseText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CloseText.Name = "CloseText"
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BackgroundPanel.Controls.Add(Me.FooterPanel)
        Me.BackgroundPanel.Controls.Add(Me.MainMenuPanel)
        resources.ApplyResources(Me.BackgroundPanel, "BackgroundPanel")
        Me.BackgroundPanel.Name = "BackgroundPanel"
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.FooterPanel, "FooterPanel")
        Me.FooterPanel.Name = "FooterPanel"
        '
        'MainMenuPanel
        '
        Me.MainMenuPanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuPanel.Controls.Add(Me.WelcomePanel)
        Me.MainMenuPanel.Controls.Add(Me.MainMenuBar)
        Me.MainMenuPanel.Controls.Add(Me.TitleLogo)
        resources.ApplyResources(Me.MainMenuPanel, "MainMenuPanel")
        Me.MainMenuPanel.Name = "MainMenuPanel"
        '
        'WelcomePanel
        '
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage0)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage1)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage2)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage4)
        Me.WelcomePanel.Controls.Add(Me.WelcomeImage3)
        resources.ApplyResources(Me.WelcomePanel, "WelcomePanel")
        Me.WelcomePanel.Name = "WelcomePanel"
        '
        'WelcomeImage0
        '
        resources.ApplyResources(Me.WelcomeImage0, "WelcomeImage0")
        Me.WelcomeImage0.Name = "WelcomeImage0"
        Me.WelcomeImage0.TabStop = False
        '
        'WelcomeImage1
        '
        resources.ApplyResources(Me.WelcomeImage1, "WelcomeImage1")
        Me.WelcomeImage1.Name = "WelcomeImage1"
        Me.WelcomeImage1.TabStop = False
        '
        'WelcomeImage2
        '
        resources.ApplyResources(Me.WelcomeImage2, "WelcomeImage2")
        Me.WelcomeImage2.Name = "WelcomeImage2"
        Me.WelcomeImage2.TabStop = False
        '
        'WelcomeImage4
        '
        resources.ApplyResources(Me.WelcomeImage4, "WelcomeImage4")
        Me.WelcomeImage4.Name = "WelcomeImage4"
        Me.WelcomeImage4.TabStop = False
        '
        'WelcomeImage3
        '
        resources.ApplyResources(Me.WelcomeImage3, "WelcomeImage3")
        Me.WelcomeImage3.Name = "WelcomeImage3"
        Me.WelcomeImage3.TabStop = False
        '
        'MainMenuBar
        '
        resources.ApplyResources(Me.MainMenuBar, "MainMenuBar")
        Me.MainMenuBar.Name = "MainMenuBar"
        '
        'TitleLogo
        '
        Me.TitleLogo.BackgroundImage = Global.Limitless.My.Resources.Resources.logo
        resources.ApplyResources(Me.TitleLogo, "TitleLogo")
        Me.TitleLogo.Name = "TitleLogo"
        Me.TitleLogo.TabStop = False
        '
        'MainWindow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.TitleBarPanel.ResumeLayout(False)
        Me.TitleBarPanel.PerformLayout()
        Me.MinimizeButton.ResumeLayout(False)
        Me.MinimizeButton.PerformLayout()
        Me.CloseButton.ResumeLayout(False)
        Me.CloseButton.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.MainMenuPanel.ResumeLayout(False)
        Me.WelcomePanel.ResumeLayout(False)
        CType(Me.WelcomeImage0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeImage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleLogo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TitleLogo As PictureBox
    Friend WithEvents FooterPanel As Panel
    Friend WithEvents MainMenuBar As Panel
    Friend WithEvents WelcomePanel As Panel
    Friend WithEvents WelcomeImage0 As PictureBox
    Friend WithEvents WelcomeImage1 As PictureBox
    Friend WithEvents WelcomeImage2 As PictureBox
    Friend WithEvents WelcomeImage4 As PictureBox
    Friend WithEvents WelcomeImage3 As PictureBox
End Class

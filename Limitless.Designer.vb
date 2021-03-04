<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LimitlessForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LimitlessForm))
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.titlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'titlePanel
        '
        Me.titlePanel.BackColor = System.Drawing.SystemColors.ControlText
        Me.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.titlePanel.Controls.Add(Me.titleLabel)
        Me.titlePanel.ForeColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.titlePanel, "titlePanel")
        Me.titlePanel.Name = "titlePanel"
        '
        'titleLabel
        '
        resources.ApplyResources(Me.titleLabel, "titleLabel")
        Me.titleLabel.Name = "titleLabel"
        '
        'LimitlessForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.titlePanel)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.Limitless.My.Resources.Resources.icon
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LimitlessForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.titlePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84

    'This makes the form draggable anywhere you mousedown and drag
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)

        If m.Msg = WM_NCHITTEST AndAlso m.Result = HTCLIENT Then
            m.Result = HTCAPTION
        End If
    End Sub

    Friend WithEvents titlePanel As Panel
    Friend WithEvents titleLabel As Label

End Class

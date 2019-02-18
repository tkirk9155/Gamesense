<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventViewer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lstArgb = New System.Windows.Forms.ListBox()
        Me.lstFadeDuration = New System.Windows.Forms.ListBox()
        Me.lstDuration = New System.Windows.Forms.ListBox()
        Me.lblColor = New System.Windows.Forms.TextBox()
        Me.lblDuration = New System.Windows.Forms.TextBox()
        Me.lblFadeDuration = New System.Windows.Forms.TextBox()
        Me.lstColor = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstArgb
        '
        Me.lstArgb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstArgb.FormattingEnabled = True
        Me.lstArgb.Location = New System.Drawing.Point(0, 20)
        Me.lstArgb.Margin = New System.Windows.Forms.Padding(0)
        Me.lstArgb.Name = "lstArgb"
        Me.lstArgb.Size = New System.Drawing.Size(127, 342)
        Me.lstArgb.TabIndex = 0
        '
        'lstFadeDuration
        '
        Me.lstFadeDuration.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstFadeDuration.FormattingEnabled = True
        Me.lstFadeDuration.Location = New System.Drawing.Point(261, 20)
        Me.lstFadeDuration.Margin = New System.Windows.Forms.Padding(0)
        Me.lstFadeDuration.Name = "lstFadeDuration"
        Me.lstFadeDuration.Size = New System.Drawing.Size(97, 342)
        Me.lstFadeDuration.TabIndex = 1
        '
        'lstDuration
        '
        Me.lstDuration.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstDuration.FormattingEnabled = True
        Me.lstDuration.Location = New System.Drawing.Point(164, 20)
        Me.lstDuration.Margin = New System.Windows.Forms.Padding(0)
        Me.lstDuration.Name = "lstDuration"
        Me.lstDuration.Size = New System.Drawing.Size(97, 342)
        Me.lstDuration.TabIndex = 2
        '
        'lblColor
        '
        Me.lblColor.Location = New System.Drawing.Point(0, 0)
        Me.lblColor.Margin = New System.Windows.Forms.Padding(0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(164, 20)
        Me.lblColor.TabIndex = 3
        Me.lblColor.Text = "Color"
        Me.lblColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDuration
        '
        Me.lblDuration.Location = New System.Drawing.Point(164, 0)
        Me.lblDuration.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(97, 20)
        Me.lblDuration.TabIndex = 3
        Me.lblDuration.Text = "Duration (ms)"
        '
        'lblFadeDuration
        '
        Me.lblFadeDuration.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFadeDuration.Location = New System.Drawing.Point(261, 0)
        Me.lblFadeDuration.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFadeDuration.Name = "lblFadeDuration"
        Me.lblFadeDuration.Size = New System.Drawing.Size(97, 20)
        Me.lblFadeDuration.TabIndex = 3
        Me.lblFadeDuration.Text = "Fade duration (ms)"
        '
        'lstColor
        '
        Me.lstColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstColor.FormattingEnabled = True
        Me.lstColor.Location = New System.Drawing.Point(127, 20)
        Me.lstColor.Margin = New System.Windows.Forms.Padding(0)
        Me.lstColor.Name = "lstColor"
        Me.lstColor.Size = New System.Drawing.Size(37, 342)
        Me.lstColor.TabIndex = 4
        '
        'EventViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstColor)
        Me.Controls.Add(Me.lblFadeDuration)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lstDuration)
        Me.Controls.Add(Me.lstFadeDuration)
        Me.Controls.Add(Me.lstArgb)
        Me.Name = "EventViewer"
        Me.Size = New System.Drawing.Size(358, 367)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstArgb As ListBox
    Friend WithEvents lstFadeDuration As ListBox
    Friend WithEvents lstDuration As ListBox
    Friend WithEvents lblColor As TextBox
    Friend WithEvents lblDuration As TextBox
    Friend WithEvents lblFadeDuration As TextBox
    Friend WithEvents lstColor As ListBox
End Class

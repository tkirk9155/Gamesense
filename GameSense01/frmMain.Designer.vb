<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.colorDialog = New System.Windows.Forms.ColorDialog()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblColorPicker = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.NumericUpDown()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblMilliseconds = New System.Windows.Forms.Label()
        Me.lblFadeDuration = New System.Windows.Forms.Label()
        Me.lblFadeMilsec = New System.Windows.Forms.Label()
        Me.txtFadeDuration = New System.Windows.Forms.NumericUpDown()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabZone1 = New System.Windows.Forms.TabPage()
        Me.tabZone2 = New System.Windows.Forms.TabPage()
        Me.tabZone3 = New System.Windows.Forms.TabPage()
        Me.tabZone4 = New System.Windows.Forms.TabPage()
        Me.tabZone5 = New System.Windows.Forms.TabPage()
        CType(Me.txtDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFadeDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEdit.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'colorDialog
        '
        Me.colorDialog.AnyColor = True
        Me.colorDialog.Color = System.Drawing.Color.Transparent
        Me.colorDialog.FullOpen = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(12, 378)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 31)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(248, 378)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 31)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(76, 39)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(39, 15)
        Me.lblColor.TabIndex = 2
        Me.lblColor.Text = "Color:"
        '
        'lblColorPicker
        '
        Me.lblColorPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColorPicker.Location = New System.Drawing.Point(121, 29)
        Me.lblColorPicker.Name = "lblColorPicker"
        Me.lblColorPicker.Size = New System.Drawing.Size(40, 40)
        Me.lblColorPicker.TabIndex = 3
        '
        'txtDuration
        '
        Me.txtDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtDuration.Location = New System.Drawing.Point(121, 85)
        Me.txtDuration.Maximum = New Decimal(New Integer() {-559939584, 902409669, 54, 0})
        Me.txtDuration.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(43, 21)
        Me.txtDuration.TabIndex = 4
        Me.txtDuration.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblDuration
        '
        Me.lblDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(53, 87)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(62, 19)
        Me.lblDuration.TabIndex = 2
        Me.lblDuration.Text = "Duration:"
        '
        'lblMilliseconds
        '
        Me.lblMilliseconds.AutoSize = True
        Me.lblMilliseconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilliseconds.Location = New System.Drawing.Point(170, 87)
        Me.lblMilliseconds.Name = "lblMilliseconds"
        Me.lblMilliseconds.Size = New System.Drawing.Size(84, 15)
        Me.lblMilliseconds.TabIndex = 2
        Me.lblMilliseconds.Text = "(milliseconds)"
        '
        'lblFadeDuration
        '
        Me.lblFadeDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFadeDuration.Location = New System.Drawing.Point(21, 124)
        Me.lblFadeDuration.Name = "lblFadeDuration"
        Me.lblFadeDuration.Size = New System.Drawing.Size(94, 19)
        Me.lblFadeDuration.TabIndex = 2
        Me.lblFadeDuration.Text = "Fade duration:"
        '
        'lblFadeMilsec
        '
        Me.lblFadeMilsec.AutoSize = True
        Me.lblFadeMilsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFadeMilsec.Location = New System.Drawing.Point(170, 124)
        Me.lblFadeMilsec.Name = "lblFadeMilsec"
        Me.lblFadeMilsec.Size = New System.Drawing.Size(84, 15)
        Me.lblFadeMilsec.TabIndex = 2
        Me.lblFadeMilsec.Text = "(milliseconds)"
        '
        'txtFadeDuration
        '
        Me.txtFadeDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFadeDuration.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtFadeDuration.Location = New System.Drawing.Point(121, 122)
        Me.txtFadeDuration.Maximum = New Decimal(New Integer() {-559939584, 902409669, 54, 0})
        Me.txtFadeDuration.Name = "txtFadeDuration"
        Me.txtFadeDuration.Size = New System.Drawing.Size(43, 21)
        Me.txtFadeDuration.TabIndex = 4
        Me.txtFadeDuration.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.txtFadeDuration)
        Me.pnlEdit.Controls.Add(Me.txtDuration)
        Me.pnlEdit.Controls.Add(Me.lblColorPicker)
        Me.pnlEdit.Controls.Add(Me.lblFadeMilsec)
        Me.pnlEdit.Controls.Add(Me.lblMilliseconds)
        Me.pnlEdit.Controls.Add(Me.lblFadeDuration)
        Me.pnlEdit.Controls.Add(Me.lblDuration)
        Me.pnlEdit.Controls.Add(Me.lblColor)
        Me.pnlEdit.Location = New System.Drawing.Point(358, 37)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(266, 177)
        Me.pnlEdit.TabIndex = 5
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(437, 288)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 31)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabZone1)
        Me.tabMain.Controls.Add(Me.tabZone2)
        Me.tabMain.Controls.Add(Me.tabZone3)
        Me.tabMain.Controls.Add(Me.tabZone4)
        Me.tabMain.Controls.Add(Me.tabZone5)
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(340, 360)
        Me.tabMain.TabIndex = 6
        '
        'tabZone1
        '
        Me.tabZone1.Location = New System.Drawing.Point(4, 22)
        Me.tabZone1.Name = "tabZone1"
        Me.tabZone1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabZone1.Size = New System.Drawing.Size(332, 334)
        Me.tabZone1.TabIndex = 0
        Me.tabZone1.Text = "Zone 1"
        Me.tabZone1.UseVisualStyleBackColor = True
        '
        'tabZone2
        '
        Me.tabZone2.Location = New System.Drawing.Point(4, 22)
        Me.tabZone2.Name = "tabZone2"
        Me.tabZone2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabZone2.Size = New System.Drawing.Size(332, 334)
        Me.tabZone2.TabIndex = 1
        Me.tabZone2.Text = "Zone 2"
        Me.tabZone2.UseVisualStyleBackColor = True
        '
        'tabZone3
        '
        Me.tabZone3.Location = New System.Drawing.Point(4, 22)
        Me.tabZone3.Name = "tabZone3"
        Me.tabZone3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabZone3.Size = New System.Drawing.Size(332, 334)
        Me.tabZone3.TabIndex = 2
        Me.tabZone3.Text = "Zone 3"
        Me.tabZone3.UseVisualStyleBackColor = True
        '
        'tabZone4
        '
        Me.tabZone4.Location = New System.Drawing.Point(4, 22)
        Me.tabZone4.Name = "tabZone4"
        Me.tabZone4.Padding = New System.Windows.Forms.Padding(3)
        Me.tabZone4.Size = New System.Drawing.Size(332, 334)
        Me.tabZone4.TabIndex = 3
        Me.tabZone4.Text = "Zone 4"
        Me.tabZone4.UseVisualStyleBackColor = True
        '
        'tabZone5
        '
        Me.tabZone5.Location = New System.Drawing.Point(4, 22)
        Me.tabZone5.Name = "tabZone5"
        Me.tabZone5.Padding = New System.Windows.Forms.Padding(3)
        Me.tabZone5.Size = New System.Drawing.Size(332, 334)
        Me.tabZone5.TabIndex = 4
        Me.tabZone5.Text = "Zone 5"
        Me.tabZone5.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 423)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Name = "frmMain"
        Me.Text = "who "
        CType(Me.txtDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFadeDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents colorDialog As ColorDialog
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblColor As Label
    Friend WithEvents lblColorPicker As Label
    Friend WithEvents txtDuration As NumericUpDown
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblMilliseconds As Label
    Friend WithEvents lblFadeDuration As Label
    Friend WithEvents lblFadeMilsec As Label
    Friend WithEvents txtFadeDuration As NumericUpDown
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents btnStart As Button
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabZone1 As TabPage
    Friend WithEvents tabZone2 As TabPage
    Friend WithEvents tabZone3 As TabPage
    Friend WithEvents tabZone4 As TabPage
    Friend WithEvents tabZone5 As TabPage
End Class

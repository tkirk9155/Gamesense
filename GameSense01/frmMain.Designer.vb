<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.colorDialog = New System.Windows.Forms.ColorDialog()
        Me.lstZone1 = New System.Windows.Forms.ListView()
        Me.colColor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDuration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFadeDuration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.lstZone2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabZone3 = New System.Windows.Forms.TabPage()
        Me.tabZone4 = New System.Windows.Forms.TabPage()
        Me.tabZone5 = New System.Windows.Forms.TabPage()
        Me.lstZone3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstZone4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstZone5 = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.txtDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFadeDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEdit.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabZone1.SuspendLayout()
        Me.tabZone2.SuspendLayout()
        Me.tabZone3.SuspendLayout()
        Me.tabZone4.SuspendLayout()
        Me.tabZone5.SuspendLayout()
        Me.SuspendLayout()
        '
        'colorDialog
        '
        Me.colorDialog.AnyColor = True
        Me.colorDialog.Color = System.Drawing.Color.Transparent
        Me.colorDialog.FullOpen = True
        '
        'lstZone1
        '
        Me.lstZone1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colColor, Me.colDuration, Me.colFadeDuration})
        Me.lstZone1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstZone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstZone1.Location = New System.Drawing.Point(3, 3)
        Me.lstZone1.MultiSelect = False
        Me.lstZone1.Name = "lstZone1"
        Me.lstZone1.Size = New System.Drawing.Size(326, 328)
        Me.lstZone1.TabIndex = 0
        Me.lstZone1.UseCompatibleStateImageBehavior = False
        Me.lstZone1.View = System.Windows.Forms.View.Details
        '
        'colColor
        '
        Me.colColor.Text = "Color"
        '
        'colDuration
        '
        Me.colDuration.Text = "Duration"
        '
        'colFadeDuration
        '
        Me.colFadeDuration.Text = "Fade Duration"
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
        Me.txtDuration.Location = New System.Drawing.Point(121, 85)
        Me.txtDuration.Maximum = New Decimal(New Integer() {1569325055, 23283064, 0, 0})
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(43, 21)
        Me.txtDuration.TabIndex = 4
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
        Me.txtFadeDuration.Location = New System.Drawing.Point(121, 122)
        Me.txtFadeDuration.Maximum = New Decimal(New Integer() {1569325055, 23283064, 0, 0})
        Me.txtFadeDuration.Name = "txtFadeDuration"
        Me.txtFadeDuration.Size = New System.Drawing.Size(43, 21)
        Me.txtFadeDuration.TabIndex = 4
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
        Me.tabZone1.Controls.Add(Me.lstZone1)
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
        Me.tabZone2.Controls.Add(Me.lstZone2)
        Me.tabZone2.Location = New System.Drawing.Point(4, 22)
        Me.tabZone2.Name = "tabZone2"
        Me.tabZone2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabZone2.Size = New System.Drawing.Size(332, 334)
        Me.tabZone2.TabIndex = 1
        Me.tabZone2.Text = "Zone 2"
        Me.tabZone2.UseVisualStyleBackColor = True
        '
        'lstZone2
        '
        Me.lstZone2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstZone2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstZone2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstZone2.Location = New System.Drawing.Point(3, 3)
        Me.lstZone2.MultiSelect = False
        Me.lstZone2.Name = "lstZone2"
        Me.lstZone2.Size = New System.Drawing.Size(326, 328)
        Me.lstZone2.TabIndex = 1
        Me.lstZone2.UseCompatibleStateImageBehavior = False
        Me.lstZone2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Color"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Duration"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fade Duration"
        '
        'tabZone3
        '
        Me.tabZone3.Controls.Add(Me.lstZone3)
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
        Me.tabZone4.Controls.Add(Me.lstZone4)
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
        Me.tabZone5.Controls.Add(Me.lstZone5)
        Me.tabZone5.Location = New System.Drawing.Point(4, 22)
        Me.tabZone5.Name = "tabZone5"
        Me.tabZone5.Padding = New System.Windows.Forms.Padding(3)
        Me.tabZone5.Size = New System.Drawing.Size(332, 334)
        Me.tabZone5.TabIndex = 4
        Me.tabZone5.Text = "Zone 5"
        Me.tabZone5.UseVisualStyleBackColor = True
        '
        'lstZone3
        '
        Me.lstZone3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstZone3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstZone3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstZone3.Location = New System.Drawing.Point(3, 3)
        Me.lstZone3.MultiSelect = False
        Me.lstZone3.Name = "lstZone3"
        Me.lstZone3.Size = New System.Drawing.Size(326, 328)
        Me.lstZone3.TabIndex = 1
        Me.lstZone3.UseCompatibleStateImageBehavior = False
        Me.lstZone3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Color"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Duration"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Fade Duration"
        '
        'lstZone4
        '
        Me.lstZone4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lstZone4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstZone4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstZone4.Location = New System.Drawing.Point(3, 3)
        Me.lstZone4.MultiSelect = False
        Me.lstZone4.Name = "lstZone4"
        Me.lstZone4.Size = New System.Drawing.Size(326, 328)
        Me.lstZone4.TabIndex = 1
        Me.lstZone4.UseCompatibleStateImageBehavior = False
        Me.lstZone4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Color"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Duration"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Fade Duration"
        '
        'lstZone5
        '
        Me.lstZone5.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lstZone5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstZone5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstZone5.Location = New System.Drawing.Point(3, 3)
        Me.lstZone5.MultiSelect = False
        Me.lstZone5.Name = "lstZone5"
        Me.lstZone5.Size = New System.Drawing.Size(326, 328)
        Me.lstZone5.TabIndex = 1
        Me.lstZone5.UseCompatibleStateImageBehavior = False
        Me.lstZone5.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Color"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Duration"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Fade Duration"
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
        Me.Text = "Main"
        CType(Me.txtDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFadeDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tabZone1.ResumeLayout(False)
        Me.tabZone2.ResumeLayout(False)
        Me.tabZone3.ResumeLayout(False)
        Me.tabZone4.ResumeLayout(False)
        Me.tabZone5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents colorDialog As ColorDialog
    Friend WithEvents lstZone1 As ListView
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
    Friend WithEvents colColor As ColumnHeader
    Friend WithEvents colDuration As ColumnHeader
    Friend WithEvents colFadeDuration As ColumnHeader
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents btnStart As Button
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabZone1 As TabPage
    Friend WithEvents tabZone2 As TabPage
    Friend WithEvents lstZone2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents tabZone3 As TabPage
    Friend WithEvents lstZone3 As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents tabZone4 As TabPage
    Friend WithEvents lstZone4 As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents tabZone5 As TabPage
    Friend WithEvents lstZone5 As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
End Class

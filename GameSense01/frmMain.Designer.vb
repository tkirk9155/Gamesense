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
        Me.lstSteps = New System.Windows.Forms.ListView()
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
        CType(Me.txtDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFadeDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'colorDialog
        '
        Me.colorDialog.AnyColor = True
        Me.colorDialog.Color = System.Drawing.Color.Transparent
        Me.colorDialog.FullOpen = True
        '
        'lstSteps
        '
        Me.lstSteps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colColor, Me.colDuration, Me.colFadeDuration})
        Me.lstSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSteps.Location = New System.Drawing.Point(12, 12)
        Me.lstSteps.MultiSelect = False
        Me.lstSteps.Name = "lstSteps"
        Me.lstSteps.Size = New System.Drawing.Size(311, 360)
        Me.lstSteps.TabIndex = 0
        Me.lstSteps.UseCompatibleStateImageBehavior = False
        Me.lstSteps.View = System.Windows.Forms.View.Details
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
        Me.pnlEdit.Location = New System.Drawing.Point(329, 41)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(277, 177)
        Me.pnlEdit.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 423)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstSteps)
        Me.Name = "frmMain"
        Me.Text = "Main"
        CType(Me.txtDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFadeDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents colorDialog As ColorDialog
    Friend WithEvents lstSteps As ListView
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
End Class

Imports System.Threading

Public Class frmMain

    Private selectedIndex As Integer


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not GetSSE3Address() Then
            MessageBox.Show("Couldn't find coreProps.json!",
                            "error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Else
            SendKbdEvent()
        End If

        lstSteps.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        For Each control In pnlEdit.Controls
            control.Enabled = False
        Next

    End Sub



    Private Sub lstSteps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSteps.SelectedIndexChanged

        If lstSteps.SelectedItems.Count > 0 Then selectedIndex = lstSteps.SelectedItems(0).Index

        With lstSteps.Items(selectedIndex)
            lblColorPicker.BackColor = lstSteps.Items(selectedIndex).SubItems(0).BackColor
            If Not Double.TryParse(.SubItems(1).Text, txtDuration.Value) Then txtDuration.Value = 0
            If Not Double.TryParse(.SubItems(2).Text, txtFadeDuration.Value) Then txtFadeDuration.Value = 0
        End With

    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim lvi As New ListViewItem
        lvi.Text = ""
        lvi.SubItems.Add("0")
        lvi.SubItems.Add("0")
        lstSteps.Items.Add(lvi).UseItemStyleForSubItems = False
        selectedIndex = lstSteps.Items.Count - 1

        If lstSteps.Items.Count >= 1 Then
            For Each control In pnlEdit.Controls
                control.Enabled = True
            Next
        End If

    End Sub

    Private Sub lblColorPicker_Click(sender As Object, e As EventArgs) Handles lblColorPicker.Click

        If colorDialog.ShowDialog() = DialogResult.OK Then
            lblColorPicker.BackColor = colorDialog.Color
            lstSteps.Items(selectedIndex).SubItems(0).BackColor = colorDialog.Color
        End If

    End Sub

    Private Sub txtDuration_ValueChanged(sender As Object, e As EventArgs) Handles txtDuration.ValueChanged

        lstSteps.Items(selectedIndex).SubItems(1).Text = txtDuration.Value.ToString()

    End Sub

    Private Sub txtFadeDuration_ValueChanged(sender As Object, e As EventArgs) Handles txtFadeDuration.ValueChanged

        lstSteps.Items(selectedIndex).SubItems(2).Text = txtFadeDuration.Value.ToString()

    End Sub

End Class

Imports System.Threading

Public Class frmMain

    Private _selectedIndex As Integer
    Private _loading As Boolean = True

    Private WithEvents lstZone1 As New EventViewer With {.Dock = DockStyle.Fill}
    Private WithEvents lstZone2 As New EventViewer With {.Dock = DockStyle.Fill}
    Private WithEvents lstZone3 As New EventViewer With {.Dock = DockStyle.Fill}
    Private WithEvents lstZone4 As New EventViewer With {.Dock = DockStyle.Fill}
    Private WithEvents lstZone5 As New EventViewer With {.Dock = DockStyle.Fill}


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        _loading = True

        tabZone1.Controls.Add(lstZone1)
        tabZone2.Controls.Add(lstZone2)
        tabZone3.Controls.Add(lstZone3)
        tabZone4.Controls.Add(lstZone4)
        tabZone5.Controls.Add(lstZone5)

        For Each control In pnlEdit.Controls
            control.Enabled = False
        Next
        _loading = False

    End Sub



    Private Sub SelectionChanged(sender As Object, e As EventArgs) Handles lstZone1.SelectedIndexChanged,
                                                                           lstZone2.SelectedIndexChanged,
                                                                           lstZone3.SelectedIndexChanged,
                                                                           lstZone4.SelectedIndexChanged,
                                                                           lstZone5.SelectedIndexChanged

        With tabMain.SelectedTab.Controls.OfType(Of EventViewer).First()
            'If .lstArgb.Items(.lstArgb.SelectedIndex).ToString().Length <= 0 Then
            Dim i As Integer = .lstArgb.SelectedIndex
            lblColorPicker.BackColor = If(.lstArgb.Items(i).ToString().Length > 0, Color.FromArgb(.lstArgb.Items(i)), Color.Transparent)
            txtDuration.Value = .lstDuration.Items(i)
            txtFadeDuration.Value = .lstFadeDuration.Items(i)
        End With

    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        With tabMain.SelectedTab.Controls.OfType(Of EventViewer).First()
            .AddItem()
            .lstArgb.SelectedIndex = .lstArgb.Items.Count - 1
        End With

        For Each control In pnlEdit.Controls
            control.Enabled = True
        Next

    End Sub

    Private Sub lblColorPicker_Click(sender As Object, e As EventArgs) Handles lblColorPicker.Click

        If colorDialog.ShowDialog() = DialogResult.OK Then
            lblColorPicker.BackColor = colorDialog.Color
            With tabMain.SelectedTab.Controls.OfType(Of EventViewer).First()
                .lstArgb.Items(.lstArgb.SelectedIndex) = lblColorPicker.BackColor.ToArgb().ToString()
                .lstColor.Refresh()
            End With
        End If

    End Sub

    Private Sub txtDuration_ValueChanged(sender As Object, e As EventArgs) Handles txtDuration.ValueChanged

        If _loading Then Exit Sub
        With tabMain.SelectedTab.Controls.OfType(Of EventViewer).First().lstDuration
            .Items(.SelectedIndex) = txtDuration.Value.ToString()
        End With

    End Sub

    Private Sub txtFadeDuration_ValueChanged(sender As Object, e As EventArgs) Handles txtFadeDuration.ValueChanged

        If _loading Then Exit Sub
        With tabMain.SelectedTab.Controls.OfType(Of EventViewer).First().lstFadeDuration
            .Items(.SelectedIndex) = txtFadeDuration.Value.ToString()
        End With

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'BuildLispEvents()

        If Not GetSSE3Address() Then
            MessageBox.Show("Couldn't find coreProps.json!",
                            "error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Else
            RegisterExe()
            BuildLispEvents()
            RegisterEvents()
            EventTimer = New Timers.Timer(1000)
            AddHandler EventTimer.Elapsed, AddressOf EventTimer_Tick
            EventTimer.Start()
        End If

    End Sub



    Private Sub BuildLispEvents()

        If Not EventTimer Is Nothing Then
            EventTimer.Stop()
            EventTimer = Nothing
            EventTimer.Dispose()
        End If

        AllEvents = New List(Of List(Of LispEvent))

        For i As Integer = 0 To (tabMain.TabPages.Count - 1)

            Dim currentTab As EventViewer = CType(tabMain.TabPages(i).Controls.OfType(Of EventViewer).First(), EventViewer)
            AllEvents.Add(New List(Of LispEvent))

            With currentTab

                For x As Integer = 0 To (.lstArgb.Items.Count - 1)
                    AllEvents(i).Add(New LispEvent(x + 1,
                                                   "MY_MAIN",
                                                   Color.FromArgb(.lstArgb.Items(x)),
                                                   .lstDuration.Items(x),
                                                   .lstFadeDuration.Items(x)))
                Next

            End With

        Next

        For Each eventList As List(Of LispEvent) In AllEvents
            If eventList.Count > 0 Then eventList(0).Active = True
        Next

    End Sub


End Class

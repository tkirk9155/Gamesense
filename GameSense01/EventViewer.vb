Public Class EventViewer

    Private lockIndex As Boolean = False

    Private Sub lstArgb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFadeDuration.SelectedIndexChanged,
                                                                                       lstDuration.SelectedIndexChanged,
                                                                                       lstColor.SelectedIndexChanged,
                                                                                       lstArgb.SelectedIndexChanged
        If lockIndex Then Exit Sub
        If CType(sender, ListBox).SelectedIndex < 0 Then Exit Sub
        lockIndex = True
        For Each ctrl In Me.Controls.OfType(Of ListBox).Where(Function(b) b.Name <> CType(sender, ListBox).Name)
            ctrl.SelectedIndex = CType(sender, ListBox).SelectedIndex
        Next
        lockIndex = False
        RaiseEvent SelectedIndexChanged(sender, e)
        'If lstArgb.Items(lstArgb.SelectedIndex).ToString().Length > 0 Then RaiseEvent SelectedIndexChanged(sender, e)

    End Sub


    Public Sub RemoveAt(ByVal index As Integer)

        lstFadeDuration.Items.RemoveAt(index)
        lstDuration.Items.RemoveAt(index)
        lstColor.Items.RemoveAt(index)
        lstArgb.Items.RemoveAt(index)

    End Sub


    Public Sub AddItem()

        lstFadeDuration.Items.Add(0)
        lstDuration.Items.Add(100)
        lstColor.Items.Add("")
        lstArgb.Items.Add("")

    End Sub



    Private Sub lstColor_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstColor.DrawItem

        e.DrawBackground()
        Using g = e.Graphics
            g.FillRectangle(New SolidBrush(If(lstArgb.Items(e.Index).ToString().Length > 0, Color.FromArgb(lstArgb.Items(e.Index)), Color.Transparent)), e.Bounds)
        End Using

    End Sub



    Public Custom Event SelectedIndexChanged As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("SelectedIndexChanged", value)
        End AddHandler
        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("SelectedIndexChanged", value)
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
            CType(Me.Events("SelectedIndexChanged"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

End Class

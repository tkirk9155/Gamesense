Imports System.Threading

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not GetSSE3Address() Then
            MessageBox.Show("Couldn't find coreProps.json!",
                            "error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Else
            SendKbdEvent()
        End If

    End Sub
End Class

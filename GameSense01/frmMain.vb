Imports System.Threading

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not GetSSE3Address() Then
            MessageBox.Show("Couldn't find coreProps.json!",
                            "error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Else
            'Dim thrKbd As New Thread(AddressOf sendKbdEvent)
            'While True
            '    thrKbd.Start()
            '    Thread.Sleep(5000)
            'End While
            SendKbdEvent()
        End If

    End Sub
End Class

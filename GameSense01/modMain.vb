Imports System.Net
Imports System.Net.Http
Imports System.IO
Imports System.Data
Imports Newtonsoft.Json.Linq
Imports System.Threading

Module modMain

    Public SSE3_URL As String
    Private threadHeartbeat As Thread
    Public EventTimer As System.Timers.Timer
    Private timeElapsed As Integer = 0

    Public WithEvents AllEvents As List(Of List(Of LispEvent))

    Public Function GetSSE3Address() As Boolean

        Dim result As Boolean = False
        Dim jsonAddressStr As String = String.Empty
        Dim corePropsFileNm As String = Environment.GetEnvironmentVariable("ProgramData") & "\\SteelSeries\\SteelSeries Engine 3\\coreProps.json"

        jsonAddressStr = My.Computer.FileSystem.ReadAllText(corePropsFileNm)

        Try
            Dim jsonObj As JObject = JObject.Parse(jsonAddressStr)
            SSE3_URL = "http://" & jsonObj.GetValue("address").ToString()
            result = True
        Catch ex As Exception
            result = False
        End Try

        If SSE3_URL.Length <= 0 Then result = False

        Return result

    End Function



    Private Sub ExecutePost(ByVal sse3Address As String, ByVal jsonData As String)

        Dim jsonBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(jsonData)

        Dim req As HttpWebRequest = WebRequest.CreateHttp(New Uri(sse3Address))
        req.ContentType = "application/json"
        req.Method = "POST"
        req.ContentLength = jsonBytes.Length

        Using stream = req.GetRequestStream()
            stream.Write(jsonBytes, 0, req.ContentLength)
            stream.Close()
        End Using

        ' just for debugging
        Try
            Dim response = req.GetResponse().GetResponseStream()

        Catch ex As System.Net.WebException
            If ex.Status = WebExceptionStatus.ProtocolError Then
                Using sr = ex.Response.GetResponseStream()
                    Dim f As String = New StreamReader(sr).ReadToEnd()
                    MessageBox.Show(f)
                End Using
            End If
        End Try

    End Sub



    Private Sub SendEvent(ByVal eventData As String)
        ExecutePost(SSE3_URL & "/game_event", eventData)
    End Sub

    Public Sub RegisterEvents()
        For Each eventList As List(Of LispEvent) In AllEvents.Where(Function(x) x.Count > 0)
            ExecutePost(SSE3_URL & "/load_golisp_handlers", eventList.First().RegisterString)
        Next
    End Sub



    Public Sub RegisterExe()

        Dim jobj As New JObject
        jobj.Add("game", "MY_MAIN")
        jobj.Add("game_display_name", "testing")

        ExecutePost(SSE3_URL & "/game_metadata", jobj.ToString(Newtonsoft.Json.Formatting.None))

    End Sub



    Public Sub EventTimer_Tick(sender As Object, e As System.Timers.ElapsedEventArgs)

        For Each list As List(Of LispEvent) In AllEvents
            If list.Count > 0 Then
                Dim i As Integer = list.IndexOf(list.First(Function(x) x.Active))
                With list(i)

                    Dim n As Integer = If(i < (list.Count - 1), i + 1, 0)

                    ExecutePost(SSE3_URL & "/game_event", .Update(list(n).Red, list(n).Blue, list(n).Green))
                    If Not .Active Then list(n).Active = True

                    'End If

                End With
            End If
        Next

        timeElapsed += 100

    End Sub




End Module
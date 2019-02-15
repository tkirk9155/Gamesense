Imports System.Net
Imports System.Net.Http
Imports System.IO
Imports System.Data
Imports Newtonsoft.Json.Linq
Imports System.Threading

Module modMain

    Public SSE3_URL As String
    Private threadHeartbeat As Thread

    Public _allEvents As New List(Of LispEvent) From {
        }

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


    Public Sub SendKbdEvent()

        RegisterExe()
        RegisterEvent()
        threadHeartbeat = New Thread(AddressOf SendEvent)
        threadHeartbeat.Start()

    End Sub


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



    Private Sub SendEvent()

        While True
            Dim json As String = "
        {
            ""game"": ""MY_MAIN"",
            ""event"": ""CHANGE_COLOR"",
            ""data"": 
            { 
                ""device-type"": ""keyboard"",
                ""zone"": ""function-keys"",
                ""color"": {""red"": 255, ""green"": 0, ""blue"": 0},
                ""mode"": ""color""
            }
        }"

            ExecutePost(SSE3_URL & "/game_event", json)
            Thread.Sleep(2000)
        End While

    End Sub


    Private Sub RegisterEvent()

        'Dim json As String = "
        '    {
        '        ""game"": ""MY_MAIN"",
        '        ""event"": ""CHANGE_COLOR"",
        '        ""handlers"": [
        '        {
        '            ""device-type"": ""keyboard"",
        '            ""zone"": ""function-keys"",
        '            ""color"": {""gradient"": {""zero"": {""red"": 255, ""green"": 0, ""blue"": 0},
        '                                       ""hundred"": {""red"": 0, ""green"": 255, ""blue"": 0}}},
        '            ""mode"": ""color""
        '        }]
        '    }"
        Dim json As String = "
            {
                ""game"": ""MY_MAIN"",
                ""event"": ""CHANGE_COLOR"",
            }"

        ExecutePost(SSE3_URL & "/bind_game_event", json)

    End Sub




    Private Sub RegisterExe()

        'Dim json As String = "
        '    {
        '        ""game"": ""MYMAIN"",
        '        ""game_display_name"": ""testing"",
        '        ""developer"": ""me""
        '    }"

        Dim jobj As New JObject
        jobj.Add("game", "MY_MAIN")
        jobj.Add("game_display_name", "testing")

        ExecutePost(SSE3_URL & "/game_metadata", jobj.ToString(Newtonsoft.Json.Formatting.None))

    End Sub


End Module
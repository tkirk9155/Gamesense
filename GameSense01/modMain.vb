Imports System.Net
Imports System.Net.Http
Imports System.IO
Imports System.Data
Imports Newtonsoft.Json.Linq
Imports System.Threading

Module modMain

    Public SSE3_URL As String

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

        SetupHandlers()

    End Sub


    Private Sub ExecutePost(ByVal sse3Address As String, ByVal jsonData As String)

        Dim request As HttpWebRequest = WebRequest.CreateHttp(sse3Address)

        Dim jsonBytes As Byte() = System.Text.Encoding.Unicode.GetBytes(jsonData)

        With request
            .Method = HttpMethod.Post.Method
            .ContentType = "application/json"
            .ContentLength = jsonBytes.Length
        End With

        Using writer = request.GetRequestStream()
            writer.Write(jsonBytes, 0, jsonBytes.Length)
            writer.Close()
        End Using

        Dim resultString As String = ""
        Using reader As New StreamReader(request.GetResponse().GetResponseStream())
            resultString = reader.ReadToEnd()
            reader.Close()
        End Using

    End Sub


    Private Sub SetupHandlers()

        'Dim mainBinding As New JObject From {
        '    {"game", "MY_MAIN"},
        '    {"event", "timer"}}

        Dim mainBinding As New JObject From {
            New JProperty("game", "MY_MAIN"),
            New JProperty("event", "timer")}

        Dim hdArr As New JArray

        'Dim hdKbd As New JObject From {
        '    {"device-type", "keyboard"},
        '    {"zone", "function-keys"},
        '    {"mode", "percent"}}

        Dim hdKbd As New JObject From {
            New JProperty("device-type", "keyboard"),
            New JProperty("zone", "function-keys"),
            New JProperty("mode", "percent")}

        'Dim jZeroColor As New JObject From {
        '    {"red", 255},
        '    {"green", 0},
        '    {"blue", 0}}

        Dim jZeroColor As New JObject From {
            New JProperty("red", 255),
            New JProperty("green", 0),
            New JProperty("blue", 0)}

        'Dim jHundoColor As New JObject From {
        '    {"red", 0},
        '    {"green", 255},
        '    {"blue", 0}}

        Dim jHundoColor As New JObject From {
            New JProperty("red", 0),
            New JProperty("green", 255),
            New JProperty("blue", 0)}

        'Dim jGradient As New JObject From {
        '    {"zero", jZeroColor},
        '    {"hundred", jHundoColor}}

        Dim jGradient As New JObject From {
            New JProperty("zero", jZeroColor),
            New JProperty("hundred", jHundoColor)}

        'Dim jColor As New JObject From {
        '    {"gradient", jGradient}}

        Dim jColor As New JObject From {
            New JProperty("gradient", jGradient)}

        'hdKbd.Add({"color", jColor})
        hdKbd.Add(New JProperty("color", jColor))
        'hdArr.Add(hdKbd.   ' stopped here, don't comment this
        'mainBinding.Add("handlers", hdArr)
        mainBinding.Add(New JProperty("handlers", hdArr))
        ExecutePost(SSE3_URL, mainBinding.ToString())



    End Sub

End Module
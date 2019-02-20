Imports Newtonsoft.Json.Linq

Public Class LispEvent

    Public Red As Integer
    Public Blue As Integer
    Public Green As Integer

    Public Duration As Integer
    Public Fade As Integer

    Public Active As Boolean

    Private _baseColor As Color

    Public RegisterString As String = ""
    Private _eventString As String = ""
    Private _gameName As String = ""
    Private _zoneName As String = ""

    Public EventTimeElapsed As Integer

    Public Property EventString As String
        Get
            Return BuildJObject()
        End Get
        Set(value As String)

        End Set
    End Property

    Public Sub New(ByVal zoneId As Integer,
                   ByVal gameName As String,
                   ByVal pColor As Color,
                   ByVal durationMilliseconds As Integer,
                   ByVal fadeMilliseconds As Integer)

        Red = pColor.R
        Blue = pColor.B
        Green = pColor.G
        _baseColor = pColor

        EventTimeElapsed = 0
        Duration = durationMilliseconds
        Fade = fadeMilliseconds

        Dim zoneText As String = ""

        Select Case zoneId
            Case 1
                zoneText = "one"
            Case 2
                zoneText = "two"
            Case 3
                zoneText = "three"
            Case 4
                zoneText = "four"
            Case 5
                zoneText = "five"
        End Select

        _zoneName = ("""Zone" & zoneId.ToString() & """").ToUpper()
        _gameName = gameName

        Dim jobj As New JObject
        jobj.Add("game", _gameName)
        jobj.Add("golisp", "(handler " & _zoneName & "
                    (lambda (data)
                        (let* ((v (value: data))
                        (h (color->list v)))
                            (on-device 'rgb-5-zone show-on-zone: 'h " & zoneText & ":))))")
        RegisterString = jobj.ToString(Newtonsoft.Json.Formatting.None)


    End Sub


    Public Function Update(ByVal fadeRed As Integer, ByVal fadeBlue As Integer, ByVal fadeGreen As Integer) As String

        If EventTimeElapsed >= Duration AndAlso Fade > 0 Then
            Dim fadeValue As Integer = Fade / 100
            Dim interval As Integer = (fadeRed - Red) / fadeValue
            Red += interval
            interval = (fadeBlue - Blue) / fadeValue
            Blue += interval
            interval = (fadeGreen - Green) / fadeValue
            Green += interval
        End If

        Dim result As String = BuildJObject()

        EventTimeElapsed += 100

        If EventTimeElapsed >= Duration + Fade Then
            Active = False
            EventTimeElapsed = 0
            Red = _baseColor.R
            Blue = _baseColor.B
            Green = _baseColor.G
        End If

        Return result

    End Function


    Private Function BuildJObject() As String

        Dim result As String = "{
                ""game"": """ & _gameName & """,
                ""event"":" & _zoneName & ",
                ""data"": {""value"": """ & Hex(Color.FromArgb(Red, Blue, Green).ToArgb()).Substring(2).Insert(0, "#") & """}}"

        Return JObject.Parse(result).ToString(Newtonsoft.Json.Formatting.None)

    End Function


End Class

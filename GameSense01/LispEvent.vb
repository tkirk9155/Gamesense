Imports Newtonsoft.Json.Linq

Public Class LispEvent

    Public Red As Integer = 0
    Public Blue As Integer = 0
    Public Green As Integer = 0

    Private baseRed As Integer
    Private baseBlue As Integer
    Private baseGreen As Integer

    Public Duration As Integer = 0
    Public Fade As Integer = 0

    Public Active As Boolean

    Private _currentColor As Color

    Public RegisterString As String = ""
    Private _eventString As String = ""
    Private _gameName As String = ""
    Private _zoneName As String = ""

    Private _timeElapsed As Integer

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
        baseRed = pColor.R
        baseBlue = pColor.B
        baseGreen = pColor.G
        Duration = durationMilliseconds
        Fade = fadeMilliseconds

        _currentColor = pColor

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
                        (h (color->list v))))
                            (on-device 'rgb-5-zone show-on-zone: v " & zoneText & ":))))")
        RegisterString = jobj.ToString(Newtonsoft.Json.Formatting.None)


    End Sub


    Public Function Update(ByVal fadeRed As Integer, ByVal fadeBlue As Integer, ByVal fadeGreen As Integer) As String

        If Fade > 0 Then
            Dim fadeValue As Integer = Fade / 100
            Dim interval As Integer = (fadeRed - Red) / fadeValue
            Red += interval
            interval = (fadeBlue - Blue) / fadeValue
            Blue += interval
            interval = (fadeGreen - Green) / fadeValue
            Green += interval
        End If

        Dim result As String = BuildJObject()

        If _timeElapsed >= Duration + Fade Then
            Active = False
            _timeElapsed = 0
            Red = baseRed
            Blue = baseBlue
            Green = baseGreen
        End If

        Return result

    End Function


    Private Function BuildJObject() As String



        'Dim result As String = "{
        '        ""game"": """ & _gameName & """,
        '        ""event"":" & _zoneName & ",
        '        ""data"": {""value"": ""(" & Red.ToString() & " " & Blue.ToString() & " " & Green.ToString() & ")""}}"
        Dim result As String = "{
                ""game"": """ & _gameName & """,
                ""event"":" & _zoneName & ",
                ""data"": {""value"": """ & String.Format(_currentColor.ToArgb(), "x") & """}}"

        Return JObject.Parse(result).ToString(Newtonsoft.Json.Formatting.None)

    End Function


End Class

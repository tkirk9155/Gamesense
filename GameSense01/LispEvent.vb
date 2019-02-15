Public Class LispEvent

    Public Red As Integer = 0
    Public Blue As Integer = 0
    Public Green As Integer = 0

    Public Duration As Integer = 0
    Public Fade As Integer = 0

    Public RegisterString As String = ""
    Private _eventString As String = ""
    Private _gameName As String = ""
    Private _zoneName As String = ""

    Public Property EventString As String
        Get
            Return "{
                ""game"": """ & _gameName & """,
                ""event"":" & _zoneName & ",
                ""data"": {""value"": ""(" & Red.ToString() & " " & Blue.ToString() & " " & Green.ToString() & ")""}}
"
        End Get
        Set(value As String)

        End Set
    End Property

    Public Sub New(ByVal zoneId As Integer,
                   ByVal gameName As String,
                   ByVal rgbRed As Integer,
                   ByVal rgbBlue As Integer,
                   ByVal rgbGreen As Integer,
                   ByVal durationMilliseconds As Integer,
                   ByVal fadeMilliseconds As Integer)

        Red = rgbRed
        Blue = rgbBlue
        Green = rgbGreen

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

        _zoneName = """Zone" & zoneId.ToString() & """"
        _gameName = gameName

        ' need to check if newline and indents cause any problems
        RegisterString = "
                (handler " & _zoneName & "
                    (lambda (data)
                        (let* ((v (value: data)))
                            (on-device 'rgb-5-zone show-on-zone: v " & zoneText & ":))))"

    End Sub


End Class

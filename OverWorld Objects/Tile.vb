Public Class Tile
    Inherits PictureBox
    Private namé As String
    Private passable As Boolean = True
    Private encounterRate As Integer = 0
    Private str As String
    Private isString As Boolean = False
    Private healable As Boolean = False

    Public Function getHealable() As Boolean
        Return healable
    End Function
    Public Function getIsString() As Boolean
        Return isString
    End Function
    Public Function getString() As String
        Return str
    End Function


    Public Sub New()
        'a second testing sub for no set image
        encounterRate = 0
        passable = True
    End Sub
    Public Sub New(ByVal graphic As Image,
                   ByVal passabler As Boolean,
                   ByVal name As String,
                   ByVal encounterRater As Integer,
                   ByVal isStringer As Boolean,
                   ByVal strer As String,
                   ByVal healabler As Boolean)
        'when a new tile is created, for real use with multiple parameters
        Width = 64
        Height = 64
        Image = graphic
        encounterRate = encounterRater
        namé = name
        passable = passabler
        isString = isStringer
        str = strer
        healable = healabler
    End Sub
    Public Sub New(ByRef graphic As Image)
        'when a new tile is created, for testing with one parameter
        Width = 64
        Height = 64
        Image = graphic
    End Sub
    Public Sub setName(ByVal namer As String)
        'sets name
        namé = namer
    End Sub
    Public Function getName() As String
        'gets name
        Return namé
    End Function
    Public Sub setIfPassable(ByVal passabler As Boolean)
        'changes wheather the tile is passable
        'use a sepparate sub to change graphic if needed
        passable = passabler
    End Sub
    Public Function getIfPassable() As Boolean
        'returns wheather the tile is passable
        Return passable
    End Function
    Public Function getEncounterRate() As Integer
        'returns the encounter rate of the tile
        Return encounterRate
    End Function
    Public Sub setEncounterRate(ByVal encounterRater As Integer)
        'sets the tile's encounter rate
        'set to 0 for no encounters on the tile, 100 for all movement to make an encounter
        If encounterRater >= 0 And encounterRater <= 100 Then
            encounterRate = encounterRater
        End If
    End Sub
End Class

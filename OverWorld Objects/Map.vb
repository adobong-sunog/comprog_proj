Public Class Map
    Private tiles As Tileset
    Private thisMap(100, 100) As Tile
    Private xLimits As Integer
    Private yLimits As Integer
    Private musicName As String

    Public Sub playMusic()
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(musicName), AudioPlayMode.BackgroundLoop)
    End Sub
    Public Function getMusicName() As String
        Return musicName
    End Function
    Public Sub setMusicName(ByRef newMusicName As String)
        musicName = newMusicName
    End Sub
    Public Function getXLimits() As Integer
        Return xLimits
    End Function

    Public Function getYLimits() As Integer
        Return yLimits
    End Function

    Public Sub setxLimits(ByVal newXLimits As Integer)
        xLimits = newXLimits
    End Sub

    Public Sub setyLimits(ByVal newYLimits As Integer)
        yLimits = newYLimits
    End Sub

    Public Function getThisMap()
        Return thisMap
    End Function

    Public Function getTileSet() As Tileset
        Return tiles
    End Function

    Public Function getTile(ByRef x As Integer,
                            ByRef y As Integer) As Tile
        Return thisMap(x, y)
    End Function
    Public Function testGetTile(ByRef x As Integer,
                        ByRef y As Integer)
        If x > xLimits And y > yLimits And x < 0 And y < 0 Then
            Return -1
        Else
            Return 1
        End If

    End Function
End Class

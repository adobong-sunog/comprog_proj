Public Class Player
    Inherits PictureBox
    Private names As String
    Private playing As Boolean
    Private currentTile As Tile
    Private movingFromTile As Tile
    Private direction As String = "Down"
    Private team(5) As Fighter

    Public Function setFighter(ByVal num As Integer,
                               ByVal toTeam As Fighter)
        team(num) = toTeam
    End Function
    Public Function getFighter(ByVal num As Integer) As Fighter
        Return team(num)
    End Function
    Public Function getName() As String
        Return names
    End Function
    Public Sub setName(ByRef newName As String)
        names = newName
    End Sub
    Public Function getDirection() As String
        Return direction
    End Function
    Public Sub setDirection(ByVal directioner As String)
        direction = directioner
    End Sub

    Public Function getCurrentTile() As Tile
        Return currentTile
    End Function
    Public Sub setCurrentTile(ByRef newCurrentTile As Tile)
        currentTile = newCurrentTile
    End Sub

    Public Function getMovingFromTile() As Tile
        Return currentTile
    End Function
    Public Sub setMovingFromTile(ByRef newMovingFromTile As Tile)
        movingFromTile = newMovingFromTile
    End Sub

    Public Sub New()
        Dim pppppplayer As Bitmap = TestOfGameModeBattleTest.My.Resources.Player_Right
        pppppplayer.MakeTransparent(Color.White)

        For i = 0 To 5
            team(i) = New Fighter()
        Next

        Me.Image = pppppplayer
        Width = 64
        Height = 64
    End Sub
End Class

Public Class SuperTile
    Inherits PictureBox
    Private thisTile As New Tile()
    Private playerImage As New PictureBox

    Public Sub New()
        Width = 64
        Height = 64
        playerImage = Me
        playerImage.Image = My.Resources.Player_Down
    End Sub
    Public Sub setTile(ByRef newTile As Tile)
        thisTile = newTile
        Image = thisTile.Image
        Me.Refresh()
    End Sub
    Public Function getTile() As Tile
        Return thisTile
    End Function
End Class

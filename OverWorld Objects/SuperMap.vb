Public Class SuperMap
    Private tiles As Tileset
    Private thisMap(30, 30) As SuperTile
    Private xLimits As Integer
    Private yLimits As Integer
    Public Sub New()
        For i = 0 To 19
            For j = 0 To 10
                thisMap(i + 1, j + 1) = New SuperTile() With {
                    .Location = New Point(i * 64 - 32, j * 64 - 32)}
            Next
        Next
    End Sub
    Public Function GetThisMap()
        Return thisMap
    End Function
    Public Function GetTileSet() As Tileset
        Return tiles
    End Function
    Public Function GetTile(ByRef x As Integer,
                            ByRef y As Integer) As SuperTile
        Return thisMap(x, y)
    End Function
    Public Function TestGetTile(ByRef x As Integer,
                        ByRef y As Integer)
        If x > xLimits And y > yLimits And x < 0 And y < 0 Then
            Return -1
        Else
            Return thisMap(x, y)
        End If

    End Function
End Class

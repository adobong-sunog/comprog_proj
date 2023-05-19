Public Class MoveList
    Private moves(150) As Move

    Public Sub New()
        moves(0) = New Move("punch", 0, 15, 40)
        moves(1) = New Move("kick", 1, 10, 55)
    End Sub

    Public Function getMoveByIndex(ByRef toFind As Integer) As Move
        If toFind > 150 Or toFind < 0 Then
            Return Nothing
        Else
            Return moves(toFind)
        End If
    End Function
End Class

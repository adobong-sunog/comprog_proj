Public Class MoveSet
    Private moves(4) As Move
    Private noOfMoves As Integer
    Public Function getMoveByIndex(ByVal tofind As Integer) As Move
        If tofind > 4 Or tofind < 0 Then
            Return Nothing
        Else
            Return moves(tofind)
        End If
    End Function


    Public Function getNoOfMoves()
        Return noofmoves
    End Function


    Public Sub New(ByVal newMove1 As Move,
                   ByVal newMove2 As Move,
                   ByVal newMove3 As Move,
                   ByVal newMove4 As Move)
        moves(1) = newMove1
        moves(2) = newMove2
        moves(3) = newMove3
        moves(4) = newMove4
        noofmoves = 4
    End Sub

    Public Sub New(ByVal newMove1 As Move,
               ByVal newMove2 As Move,
               ByVal newMove3 As Move)
        moves(1) = newMove1
        moves(2) = newMove2
        moves(3) = newMove3
        noofmoves = 3
    End Sub

    Public Sub New(ByVal newMove1 As Move,
               ByVal newMove2 As Move)
        moves(1) = newMove1
        moves(2) = newMove2
        noofmoves = 2
    End Sub

    Public Sub New(ByVal newMove1 As Move)
        moves(1) = newMove1
        noofmoves = 1
    End Sub
End Class

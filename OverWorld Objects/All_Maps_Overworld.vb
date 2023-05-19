Public Class All_Maps_Overworld
    Private testingWorld As New Map
    Private tiles As New Tileset

    Public Sub New()
        createTestingWorld()
    End Sub

    Public Sub createTestingWorld()
        For j = 0 To 30
            For i = 0 To 30
                testingWorld.getThisMap(i, j) = tiles.getPlainGrass
            Next
            testingWorld.getThisMap(9, j) = tiles.getTree
        Next
        For i = 0 To 30
            For j = 0 To 4
                testingWorld.getThisMap(i, j) = tiles.GetTree
                testingWorld.getThisMap(j + 4, i) = tiles.GetTree
                testingWorld.getThisMap(21 + j, i) = tiles.getTree
                testingWorld.getThisMap(i, 25 + j) = tiles.getTree
            Next


        Next

        testingWorld.getThisMap(13, 19) = New Tile(TestOfGameModeBattleTest.My.Resources.Resources.Sign, False, "Sign", 0, True, getText(1), False)
        testingWorld.getThisMap(14, 19) = tiles.GetNurse
        testingWorld.getThisMap(15, 5) = tiles.GetDevil
        testingWorld.setxLimits(30)
        testingWorld.setyLimits(30)

        testingWorld.setMusicName("Thunderstorm")
    End Sub
    Public Function getTestingWorld() As Map
        testingWorld.playMusic()
        Return testingWorld
    End Function
    Public Function getText(ByVal toFind As Integer) As String
        Select Case toFind
            Case 1
                Return "Beware of dirt tiles, many enemies lurk in the mud."
        End Select
        Return ""
    End Function
End Class

Public Class Tileset
    Private plainGrass As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.PassTilePic, True, "Plain Grass", 10, True, GetText(2), False)
    Private tree As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.Tree, False, "Tree Base", 0, True, getText(1), False)
    Private mud_Top As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.mud_top, True, "Mud", 10, True, getText(3), False)
    Private mud_top_Left As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.mud_top_left, True, "Mud", 10, True, getText(3), False)
    Private mud_top_Right As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.mud_top_right, True, "Mud", 10, True, getText(3), False)
    Private mud_Left As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.mud_left, True, "Mud", 10, True, getText(3), False)
    Private mud_centre As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.mud_middle, True, "Mud", 10, True, getText(3), False)
    Private mud_Right As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.mud_right, True, "Mud", 10, True, getText(3), False)
    Private mud_bottom As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.mud_bottom, True, "Mud", 10, True, getText(3), False)
    Private mud_bottom_Left As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.mud_bottom_left, True, "Mud", 10, True, getText(3), False)
    Private mud_bottom_Right As New Tile(TestOfGameModeBattleTest.My.Resources.Resources.mud_bottom_right, True, "Mud", 10, True, getText(3), False)
    Private nurse As New Tile(My.Resources.DeGirl, False, "Nurse", 0, True, "Let me heal you.", True)
    Private devil As New Tile(My.Resources.DeDevil, False, "Osmort", 0, True, "Let us fight, once and for all, Lu!.", True)

    Public Function GetNurse() As Tile
        Return nurse
    End Function
    Public Function GetDevil() As Tile
        Return devil
    End Function
    Public Function GetPlainGrass() As Tile
        Return plainGrass
    End Function
    Public Function GetTree() As Tile
        Return tree
    End Function
    Public Function GetMud_Centre() As Tile
        Return mud_centre
    End Function
    Public Function GetMud_Top() As Tile
        Return mud_Top
    End Function
    Public Function GetMud_Top_Right() As Tile
        Return mud_top_Right
    End Function
    Public Function GetMud_Top_Left() As Tile
        Return mud_top_Left
    End Function
    Public Function GetMud_Left() As Tile
        Return mud_Left
    End Function
    Public Function GetMud_Right() As Tile
        Return mud_Right
    End Function
    Public Function GetMud_Bottom() As Tile
        Return mud_bottom
    End Function
    Public Function GetMud_Bottom_Left() As Tile
        Return mud_bottom_Left
    End Function
    Public Function GetMud_Bottom_Right() As Tile
        Return mud_bottom_Right
    End Function
    Public Function GetText(ByVal toFind As Integer) As String
        Select Case toFind
            Case 1
                Return "It's a tree!"
            Case 2
                Return "Why am I interacting with grass?"
            Case 3
                Return "Mud. Be carefull, going here may cause random encounters."
        End Select
        Return ""
    End Function
End Class

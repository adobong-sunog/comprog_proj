Public Class SpecieList
    Private species(150) As Specie

    Public Sub New()
        species(0) = New Specie(100, 49, 45, 65, 65, 50, 50, "Pnadat", My.Resources.Oath_s_Droplet, 111)
        species(1) = New Specie(50, 60, 60, 50, 70, 80, 50, "Pandara", My.Resources.Oath_s_Droplet, 156)
        species(2) = New Specie(39, 52, 43, 65, 60, 50, 40, "Panight", My.Resources.Oath_s_Droplet, 156)
        species(3) = New Specie(39, 52, 43, 65, 60, 50, 40, "Volcanine", My.Resources.Oath_s_Droplet, 156)
        species(4) = New Specie(39, 52, 43, 65, 60, 50, 40, "Charowl", My.Resources._05_Charowl, 156)
        species(5) = New Specie(39, 52, 43, 65, 60, 50, 40, "Ivany", My.Resources.fighter2, 156)
        species(6) = New Specie(39, 52, 43, 65, 60, 50, 40, "Ivany", My.Resources.Oath_s_Droplet, 156)
        species(7) = New Specie(39, 52, 43, 65, 60, 50, 40, "Ivany", My.Resources.fighter2, 156)
        species(8) = New Specie(39, 52, 43, 65, 60, 50, 40, "Ivany", My.Resources.Oath_s_Droplet, 156)
        species(9) = New Specie(39, 52, 43, 65, 60, 50, 40, "French Doormouse", My.Resources.fighter2, 156)
        species(10) = New Specie(39, 52, 43, 65, 60, 50, 40, "Crumleaf", My.Resources.fighter2, 156)
        species(11) = New Specie(39, 52, 43, 65, 60, 50, 40, "Starnite", My.Resources.fighter2, 156)


        species(12) = New Specie(100, 62, 53, 65, 70, 60, 50, "Devil", My.Resources.DeDevil, 156)
        species(13) = New Specie(39, 52, 43, 65, 60, 50, 40, "Bugg", My.Resources.fighter2, 156)
        species(14) = New Specie(39, 52, 43, 65, 60, 50, 40, "Cucanny", My.Resources.fighter2, 156)
    End Sub

    Public Function getSpecieByIndex(ByRef toFind As Integer) As Specie
        If toFind > 150 Or toFind < 0 Then
            Return Nothing
        Else
            Return species(toFind)
        End If
    End Function
End Class

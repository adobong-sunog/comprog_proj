Public Class Specie
    Private baseAttack As Integer
    Private baseDefence As Integer
    Private baseSpeed As Integer
    Private baseSpecialAttack As Integer
    Private baseSpecialDefence As Integer
    Private baseHP As Integer
    Private percentMale As Integer
    Private speciesName As String
    Private specieImage As Image
    Private xpDrop As Integer

    Private movesPerLevel(99) As Move
    Public Function getXPDrop()
        Return xpDrop
    End Function
    Public Function getSpecieImage() As Image
        Return specieImage
    End Function
    Public Sub setSpecieImage(ByRef specieImager As Image)
        specieImage = specieImager
    End Sub
    Public Function getBaseHP() As Integer
        Return baseHP
    End Function
    Public Function getBaseAttack() As Integer
        Return baseAttack
    End Function
    Public Function getBaseDefence() As Integer
        Return baseDefence
    End Function
    Public Function getBaseSpeed() As Integer
        Return baseSpeed
    End Function
    Public Function getBaseSpecialAttack() As Integer
        Return baseSpecialAttack
    End Function
    Public Function getBaseSpecialDefence() As Integer
        Return baseSpecialDefence
    End Function
    Public Function getSpeciesName() As String
        Return speciesName
    End Function

    Public Sub New(ByVal newbaseHP As Integer,
                   ByVal newBaseAttack As Integer,
                   ByVal newBaseDefence As Integer,
                   ByVal newBaseSpeed As Integer,
                   ByVal newBaseSpecialAttack As Integer,
                   ByVal newBaseSpecialDefence As Integer,
                   ByVal newPercentageMale As Integer,
                   ByVal newSpecieName As String,
                   ByVal newSpecieImage As Image,
                   ByVal newXPDrop As Integer)
        baseHP = newbaseHP
        baseAttack = newBaseAttack
        baseDefence = newBaseDefence
        baseSpeed = newBaseSpeed
        baseSpecialAttack = newBaseSpecialAttack
        baseSpecialDefence = newBaseSpecialDefence
        percentMale = newPercentageMale
        speciesName = newSpecieName
        specieImage = newSpecieImage
        xpDrop = newXPDrop
    End Sub

    Public Function getPecentageMale()
        Return percentMale
    End Function
End Class

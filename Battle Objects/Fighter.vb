Public Class Fighter
    ' Fighter info
    Private name As String
    Private gender As Char
    Private level As Integer
    Private iSpecie As Specie
    Private MaxHP As Integer
    Private xpForNextLevel As Integer
    Private xp As Integer
    Private moves As MoveSet
    ' Current acting stats
    Private HP As Integer
    Private attack As Integer
    Private defence As Integer
    Private speed As Integer
    Private specialAttack As Integer
    Private specialDefence As Integer
    ' Individual Stats
    Private ivHP As Integer
    Private ivAttack As Integer
    Private ivDefence As Integer
    Private ivSpeed As Integer
    Private ivSpecialAttack As Integer
    Private ivSpecialDefence As Integer

    Public Function GetRandomAttackIndex() As Integer
        Dim random As Integer = Int((Rnd() * (moves.getNoOfMoves)) + 1)

        Return random
    End Function

    Public Function XpDetermine(ByVal levelInt As Integer) As Integer
        Return (levelInt) * (levelInt) * (levelInt)
    End Function
    Public Function HpDetermine()
        Return Int(((((iSpecie.getBaseHP) * 2) * level + ivHP) / 100) + level + 10)
    End Function
    Public Function AttackDetermine()
        Return Int(((((iSpecie.getBaseAttack) * 2) * level + ivAttack) / 100) + 5)
    End Function
    Public Function DefenceDetermine()
        Return Int(((((iSpecie.getBaseDefence) * 2) * level + ivDefence) / 100) + 5)
    End Function
    Public Function SpeedDetermine()
        Return Int(((((iSpecie.getBaseSpeed) * 2) * level + ivSpeed) / 100) + 5)
    End Function
    Public Function SpecialAttackDetermine()
        Return Int(((((iSpecie.getBaseSpecialAttack) * 2) * level + ivSpecialAttack) / 100) + 5)
    End Function
    Public Function SpecialDefenceDetermine()
        Return Int(((((iSpecie.getBaseSpecialDefence) * 2) * level + ivSpecialDefence) / 100) + 5)
    End Function
    Public Sub New()

    End Sub
    Public Sub New(ByVal newName As String,
                   ByVal specier As Specie,
                   ByVal leveler As Integer,
                   ByVal newMove1 As Move,
                   ByVal newMove2 As Move,
                   ByVal newMove3 As Move,
                   ByVal newMove4 As Move)
        If specier.getPecentageMale = 101 Then
            gender = "U"
        ElseIf Int(Rnd() * 99) > specier.getPecentageMale Then
            gender = "f"
        Else
            gender = "m"
        End If

        If newName = "" Then
            name = specier.getSpeciesName
        Else
            name = newName
        End If
        iSpecie = specier
        level = leveler
        HP = hpDetermine()
        MaxHP = HP

        ivAttack = Int(Rnd() * 31)
        ivDefence = Int(Rnd() * 31)
        ivSpecialAttack = Int(Rnd() * 31)
        ivSpecialDefence = Int(Rnd() * 31)
        ivSpeed = Int(Rnd() * 31)
        ivHP = Int(Rnd() * 31)

        attack = attackDetermine()
        defence = defenceDetermine()
        specialAttack = specialAttackDetermine()
        specialDefence = specialDefenceDetermine()
        speed = speedDetermine()
        xp = xpDetermine(level)
        xpForNextLevel = xpDetermine(level + 1)

        moves = New MoveSet(newMove1, newMove2, newMove3, newMove4)
    End Sub

    Public Sub New(ByVal newName As String,
                   ByVal specier As Specie,
                   ByVal leveler As Integer,
                   ByVal newMove1 As Move,
                   ByVal newMove2 As Move,
                   ByVal newMove3 As Move)
        If specier.getPecentageMale = 101 Then
            gender = "U"
        ElseIf Int(Rnd() * 99) > specier.getPecentageMale Then
            gender = "f"
        Else
            gender = "m"
        End If

        If newName = "" Then
            name = specier.getSpeciesName
        Else
            name = newName
        End If
        iSpecie = specier
        level = leveler
        HP = hpDetermine()
        MaxHP = HP

        ivAttack = Int(Rnd() * 31)
        ivDefence = Int(Rnd() * 31)
        ivSpecialAttack = Int(Rnd() * 31)
        ivSpecialDefence = Int(Rnd() * 31)
        ivSpeed = Int(Rnd() * 31)
        ivHP = Int(Rnd() * 31)

        attack = attackDetermine()
        defence = defenceDetermine()
        specialAttack = specialAttackDetermine()
        specialDefence = specialDefenceDetermine()
        speed = speedDetermine()
        xp = xpDetermine(level)
        xpForNextLevel = xpDetermine(level + 1)

        moves = New MoveSet(newMove1, newMove2, newMove3)
    End Sub

    Public Sub New(ByVal newName As String,
                   ByVal specier As Specie,
                   ByVal leveler As Integer,
                   ByVal newMove1 As Move,
                   ByVal newMove2 As Move)
        If specier.getPecentageMale = 101 Then
            gender = "U"
        ElseIf Int(Rnd() * 99) > specier.getPecentageMale Then
            gender = "f"
        Else
            gender = "m"
        End If

        If newName = "" Then
            name = specier.getSpeciesName()
        Else
            name = newName
        End If
        iSpecie = specier
        level = leveler
        HP = hpDetermine()
        MaxHP = HP

        ivAttack = Int(Rnd() * 31)
        ivDefence = Int(Rnd() * 31)
        ivSpecialAttack = Int(Rnd() * 31)
        ivSpecialDefence = Int(Rnd() * 31)
        ivSpeed = Int(Rnd() * 31)
        ivHP = Int(Rnd() * 31)

        attack = attackDetermine()
        defence = defenceDetermine()
        specialAttack = specialAttackDetermine()
        specialDefence = specialDefenceDetermine()
        speed = speedDetermine()
        xp = xpDetermine(level)
        xpForNextLevel = xpDetermine(level + 1)

        moves = New MoveSet(newMove1, newMove2)
    End Sub

    Public Sub New(ByVal newName As String,
                   ByVal specier As Specie,
                   ByVal leveler As Integer,
                   ByVal newMove1 As Move)
        If specier.getPecentageMale = 101 Then
            gender = "U"
        ElseIf Int(Rnd() * 99) > specier.getPecentageMale Then
            gender = "f"
        Else
            gender = "m"
        End If

        If newName = "" Then
            name = specier.getSpeciesName
        Else
            name = newName
        End If
        iSpecie = specier
        level = leveler
        HP = hpDetermine()
        MaxHP = HP

        ivAttack = Int(Rnd() * 31)
        ivDefence = Int(Rnd() * 31)
        ivSpecialAttack = Int(Rnd() * 31)
        ivSpecialDefence = Int(Rnd() * 31)
        ivSpeed = Int(Rnd() * 31)
        ivHP = Int(Rnd() * 31)

        attack = attackDetermine()
        defence = defenceDetermine()
        specialAttack = specialAttackDetermine()
        specialDefence = specialDefenceDetermine()
        speed = speedDetermine()
        xp = xpDetermine(level)
        xpForNextLevel = xpDetermine(level + 1)

        moves = New MoveSet(newMove1)
    End Sub

    Public Sub DecreaseHealth(ByVal toDecrease As Integer)
        HP = HP - toDecrease

        If HP <= 0 Then
            HP = 0
            Me.faint()
        End If

        If HP > MaxHP Then
            HP = MaxHP
        End If
    End Sub
    Public Sub FullHeal()
        HP = MaxHP
    End Sub
    Public Sub XpIncrease(ByVal toIncrease As Integer)
        xp = xp + toIncrease
        If xp > xpForNextLevel Then
            level += 1
            attack = AttackDetermine()
            defence = DefenceDetermine()
            specialAttack = SpecialAttackDetermine()
            specialDefence = SpecialDefenceDetermine()
            speed = SpeedDetermine()
            FullHeal()
            xpForNextLevel = XpDetermine(level + 1)
        End If
    End Sub
    Public Sub Faint()

    End Sub
    Public Function GetXPForNextLevel()
        Return xpForNextLevel - XpDetermine(level)
    End Function
    Public Function GetCurrentXP()
        Return xp - XpDetermine(level)
    End Function
    Public Function GetMaxHP() As Integer
        Return MaxHP
    End Function

    Public Sub SetMaxHP(ByVal maxHPer As Integer)
        MaxHP = maxHPer
    End Sub
    Public Function GetHP() As Integer
        Return HP
    End Function

    Public Sub SetHP(ByVal HPer As Integer)
        HP = HPer
    End Sub

    Public Function GetMoveset() As MoveSet
        Return moves
    End Function
    Public Function GetName() As String
        Return name
    End Function
    Public Sub SetName(ByRef namer As String)
        name = namer
    End Sub
    Public Function GetGender() As Char
        Return gender
    End Function
    Public Function GetAttack() As Integer
        Return attack
    End Function
    Public Function GetDefence() As Integer
        Return defence
    End Function
    Public Function GetLevel() As Integer
        Return level
    End Function
    Public Function GetSpecialAttack() As Integer
        Return specialAttack
    End Function
    Public Function GetSpecialDefence() As Integer
        Return specialDefence
    End Function
    Public Function GetSpecie() As Specie
        Return iSpecie
    End Function
    Public Function GetSpeed() As Integer
        Return speed
    End Function
End Class

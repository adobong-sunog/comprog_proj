Public Class Battle_Form
    Private species As New SpecieList
    Private moves As New MoveList
    Private playerFighterTEST As New Fighter("Lu", species.getSpecieByIndex(0), 10, moves.getMoveByIndex(0), moves.getMoveByIndex(1))
    Private enemyFighterTEST As New Fighter("Cat", species.getSpecieByIndex(1), 5, moves.getMoveByIndex(0), moves.getMoveByIndex(1))

    Private Sub Battle_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sets up the healthbars
        setvals()
        ' Displays player gender
        If enemyFighterTEST.getGender = "m" Then
            PictureBox3.Image = My.Resources.m_icon
        ElseIf enemyFighterTEST.getGender = "f" Then
            PictureBox3.Image = My.Resources.f_Icon
        Else
            PictureBox3.Image = My.Resources.f_Icon
        End If
        ' Displays oponent's gender
        If playerFighterTEST.getGender = "m" Then
            PictureBox4.Image = My.Resources.m_icon
        ElseIf playerFighterTEST.getGender = "f" Then
            PictureBox4.Image = My.Resources.f_Icon
        Else
            PictureBox4.Image = My.Resources.u_icon
        End If
        ' Puts the text on the player attack buttons, being the attack name then the max number of uses
        Button1.Text = moves.getMoveByIndex(0).getName & "  " & moves.getMoveByIndex(0).getMaxNoOfUses
        Button2.Text = moves.getMoveByIndex(1).getName & "  " & moves.getMoveByIndex(1).getMaxNoOfUses
        Button3.Text = moves.getMoveByIndex(2).getName & "  " & moves.getMoveByIndex(2).getMaxNoOfUses
        Button4.Text = moves.getMoveByIndex(3).getName & "  " & moves.getMoveByIndex(3).getMaxNoOfUses

        Label2.Text = "So it begins!!"
    End Sub

    Sub setvals()
        If enemyFighterTEST.getHP <= 0 Then
            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value = 100 * (enemyFighterTEST.getHP / enemyFighterTEST.getMaxHP)
        End If


        If playerFighterTEST.getHP <= 0 Then
            ProgressBar2.Value = 0
        Else
            ProgressBar2.Value = 100 * (playerFighterTEST.getHP / playerFighterTEST.getMaxHP)
        End If

        Label1.Text = enemyFighterTEST.getHP & "/" & enemyFighterTEST.getMaxHP
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Damage As Integer

        If playerFighterTEST.getmoveset.getMoveByIndex(1).getAttOrSpAtt = 1 Then
            Damage = Int(playerFighterTEST.getmoveset.getMoveByIndex(1).getPower * playerFighterTEST.getSpecialAttack)
            enemyFighterTEST.setHP(enemyFighterTEST.getHP - Damage)
        Else
            Damage = Int(playerFighterTEST.getmoveset.getMoveByIndex(1).getPower * playerFighterTEST.getAttack / 10)
            enemyFighterTEST.setHP(enemyFighterTEST.getHP - Damage)
        End If

        Label2.Text = playerFighterTEST.getName & " used " & playerFighterTEST.getmoveset.getMoveByIndex(1).getName & " for " & Damage & " HP!"

        setvals()
        enemyAttack()
        setvals()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If playerFighterTEST.getmoveset.getNoOfMoves < 2 Then

        Else
            Dim Damage As Integer

            If playerFighterTEST.getmoveset.getMoveByIndex(2).getAttOrSpAtt = 1 Then
                Damage = Int(playerFighterTEST.getmoveset.getMoveByIndex(2).getPower * playerFighterTEST.getSpecialAttack)
                enemyFighterTEST.setHP(enemyFighterTEST.getHP - Damage)
            Else
                Damage = Int(playerFighterTEST.getmoveset.getMoveByIndex(2).getPower * playerFighterTEST.getAttack / 10)
                enemyFighterTEST.setHP(enemyFighterTEST.getHP - Damage)
            End If

            Label2.Text = playerFighterTEST.getName & " used " & playerFighterTEST.getmoveset.getMoveByIndex(2).getName & " for " & Damage & " HP!"

            setvals()
            enemyAttack()
            setvals()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If playerFighterTEST.getmoveset.getNoOfMoves < 3 Then

        Else
            Dim Damage As Integer

            If playerFighterTEST.getmoveset.getMoveByIndex(3).getAttOrSpAtt = 1 Then
                Damage = Int(playerFighterTEST.getmoveset.getMoveByIndex(3).getPower * playerFighterTEST.getSpecialAttack)
                enemyFighterTEST.setHP(enemyFighterTEST.getHP - Damage)
            Else
                Damage = Int(playerFighterTEST.getmoveset.getMoveByIndex(3).getPower * playerFighterTEST.getAttack / 10)
                enemyFighterTEST.setHP(enemyFighterTEST.getHP - Damage)
            End If

            Label2.Text = playerFighterTEST.getName & " used " & playerFighterTEST.getmoveset.getMoveByIndex(3).getName & " for " & Damage & " HP!"

            setvals()
            enemyAttack()
            setvals()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If playerFighterTEST.getmoveset.getNoOfMoves < 4 Then

        Else
            Dim Damage As Integer

            If playerFighterTEST.getmoveset.getMoveByIndex(4).getAttOrSpAtt = 1 Then
                Damage = Int(playerFighterTEST.getmoveset.getMoveByIndex(4).getPower * playerFighterTEST.getSpecialAttack)
                enemyFighterTEST.setHP(enemyFighterTEST.getHP - Damage)
            Else
                Damage = Int(playerFighterTEST.getmoveset.getMoveByIndex(4).getPower * playerFighterTEST.getAttack / 10)
                enemyFighterTEST.setHP(enemyFighterTEST.getHP - Damage)
            End If

            Label2.Text = playerFighterTEST.getName & " used " & playerFighterTEST.getmoveset.getMoveByIndex(4).getName & " for " & Damage & " HP!"

            setvals()
            enemyAttack()
            setvals()
        End If

    End Sub

    Private Sub enemyAttack()
        'the enemy attacks the player with a random attack from its moveset
        Dim theAttack As Move = enemyFighterTEST.getmoveset.getMoveByIndex(enemyFighterTEST.getRandomAttackIndex())
        Dim Damage As Integer

        If theAttack.getAttOrSpAtt = 1 Then
            Damage = Int(theAttack.getPower * enemyFighterTEST.getSpecialAttack)
            playerFighterTEST.setHP(playerFighterTEST.getHP - Damage)
        Else
            Damage = Int(theAttack.getPower * enemyFighterTEST.getAttack / 10)
            playerFighterTEST.setHP(playerFighterTEST.getHP - Damage)
        End If

        Label2.Text = enemyFighterTEST.getName & " used " & theAttack.getName & " for " & Damage & " HP!"
    End Sub
End Class
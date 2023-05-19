Public Class CombinedGameForm
    'overworld variables
    Private currentX As Integer = 8
    Private currentY As Integer = 20
    Private xmove As Integer = 0
    Private ymove As Integer = 0
    Private tempVal As Integer = 1
    Private menuCurrent As Integer = 1
    Private person As New Player
    Private aPress As Boolean = False
    'battle variables
    Private species As New SpecieList
    Private moves As New MoveList
    Private enemyFighterTEST As New Fighter("Goblin", species.getSpecieByIndex(4), 30, moves.getMoveByIndex(0), moves.getMoveByIndex(1))
    Private tempVar As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Plays title music
        My.Computer.Audio.Play(My.Resources.snowturn_village_3, AudioPlayMode.BackgroundLoop)
        Me.BackgroundImage = My.Resources.sample_title
        'Sets the initial player fighter team
        person.setFighter(0, New Fighter("Lu", species.getSpecieByIndex(0), 35, moves.getMoveByIndex(0), moves.getMoveByIndex(1)))

        'Hides intial hud items
        levelPlayer.Hide()
        levelEnemy.Hide()
        attack1.Hide()
        attack2.Hide()
        attack3.Hide()
        attack4.Hide()
        friendFighterImage.Hide()
        enemyFighterImage.Hide()
        narration.Hide()
        Label1.Hide()
        Me.Show()
        Me.Focus()
    End Sub
    'GAME MODE BATTLE
    '
    '
    '
    Private Sub Battle_Form_Load()
        My.Computer.Audio.Play(My.Resources.bite_hmm, AudioPlayMode.BackgroundLoop)
        enemyFighterTEST.FullHeal()

        tempVal = 4
        Me.BackgroundImage = My.Resources.DeForest

        ' Shows fighter images
        friendFighterImage.Show()
        friendFighterImage.Image = person.getFighter(0).GetSpecie.getSpecieImage
        enemyFighterImage.Show()
        enemyFighterImage.Image = enemyFighterTEST.GetSpecie.getSpecieImage

        ' Creates Battle HUD
        Dim enemyHealthBar As New ProgressBar
        enemyHealthBar.Location = New Point(410, 200)
        enemyHealthBar.Size = New Size(200, 20)
        Me.Controls.Add(enemyHealthBar)

        Dim playerHealthBar As New ProgressBar
        playerHealthBar.Location = New Point(10, 200)
        playerHealthBar.Size = New Size(200, 20)
        Me.Controls.Add(playerHealthBar)

        Dim playerXPBar As New ProgressBar
        playerXPBar.Location = New Point(10, 220)
        playerXPBar.Size = New Size(200, 10)
        playerXPBar.Value = ((person.getFighter(0).GetCurrentXP / person.getFighter(0).GetXPForNextLevel) * 100)
        Me.Controls.Add(playerXPBar)

        narration.Show()
        attack1.Location = New Point(170, 50)
        attack1.Show()
        attack2.Location = New Point(250, 50)
        attack2.Show()
        attack3.Location = New Point(330, 50)
        attack3.Show()
        attack4.Location = New Point(410, 50)
        attack4.Show()

        ' Sets up the healthbars
        setvals(enemyHealthBar, playerHealthBar)

        ' Puts the text on the player attack buttons, being the attack name then the max number of uses
        If person.getFighter(0).GetMoveset.getNoOfMoves >= 1 Then
            attack1.Text = "H: " & person.getFighter(0).GetMoveset.getMoveByIndex(1).getName & "  " & person.getFighter(0).GetMoveset.getMoveByIndex(1).getMaxNoOfUses
        End If
        If person.getFighter(0).GetMoveset.getNoOfMoves >= 2 Then
            attack2.Text = "J: " & person.getFighter(0).GetMoveset.getMoveByIndex(2).getName & "  " & person.getFighter(0).GetMoveset.getMoveByIndex(2).getMaxNoOfUses
        End If
        If person.getFighter(0).GetMoveset.getNoOfMoves >= 3 Then
            attack3.Text = "K: " & person.getFighter(0).GetMoveset.getMoveByIndex(3).getName & "  " & person.getFighter(0).GetMoveset.getMoveByIndex(3).getMaxNoOfUses
        End If
        If person.getFighter(0).GetMoveset.getNoOfMoves >= 4 Then
            attack4.Text = "L: " & person.getFighter(0).GetMoveset.getMoveByIndex(4).getName & "  " & person.getFighter(0).GetMoveset.getMoveByIndex(4).getMaxNoOfUses
        End If

        narration.Text = "And it begins!"

        'loop runs while in battle
        Dim battle As Boolean = True
        While battle = True
            Application.DoEvents()
            setvals(enemyHealthBar, playerHealthBar)
            If enemyFighterTEST.GetHP <= 0 Then
                battle = False
            ElseIf person.getFighter(0).GetHP <= 0 Then
                'hides battle ui
                enemyHealthBar.Hide()
                playerHealthBar.Hide()
                playerXPBar.Hide()
                narration.Hide()
                attack1.Hide()
                attack2.Hide()
                attack3.Hide()
                attack4.Hide()
                friendFighterImage.Hide()
                enemyFighterImage.Hide()
                levelPlayer.Hide()
                levelEnemy.Hide()
                Me.BackgroundImage = My.Resources.blackness

                My.Computer.Audio.Stop()
                Label1.Show()
                Label1.Text = "Game over."
                While battle = True
                    Application.DoEvents()
                End While
            End If
        End While

        ' Experience points:
        person.getFighter(0).XpIncrease((enemyFighterTEST.GetSpecie.getXPDrop * enemyFighterTEST.GetLevel) / 7)
        playerXPBar.Value = ((person.getFighter(0).GetCurrentXP / person.getFighter(0).GetXPForNextLevel) * 100)

        'hides battle ui
        enemyHealthBar.Hide()
        playerHealthBar.Hide()
        playerXPBar.Hide()
        narration.Hide()
        attack1.Hide()
        attack2.Hide()
        attack3.Hide()
        attack4.Hide()
        friendFighterImage.Hide()
        enemyFighterImage.Hide()
        levelPlayer.Hide()
        levelEnemy.Hide()
        Me.BackgroundImage = My.Resources.sample_loading_screen


        If enemyFighterTEST.GetSpecie.getSpeciesName = "Devil" Then
            'Plays once final fight is over.
            outro()
        End If

        tempVal = 3
    End Sub
    Private Function damageAttackCalculation(ByRef attacker As Fighter,
                                       ByRef defender As Fighter,
                                       ByRef usedMove As Move)
        Return ((((2 * attacker.GetLevel) / 5) + 2) * usedMove.getPower * (attacker.GetAttack / defender.GetDefence)) / 50 + 2
    End Function
    Private Function damageSpecialAttackCalculation(ByRef attacker As Fighter,
                                       ByRef defender As Fighter,
                                       ByRef usedMove As Move)
        Return ((((2 * attacker.GetLevel) / 5) + 2) * usedMove.getPower * (attacker.GetSpecialAttack / defender.GetSpecialDefence)) / 50 + 2
    End Function
    Private Sub Attack(ByVal attackNo As Integer)
        If person.getFighter(0).GetMoveset.getNoOfMoves < attackNo Then

        Else
            Dim Damage As Integer

            If person.getFighter(0).GetMoveset.getMoveByIndex(attackNo).getAttOrSpAtt = 1 Then
                Damage = Int(damageSpecialAttackCalculation(person.getFighter(0), enemyFighterTEST, person.getFighter(0).GetMoveset.getMoveByIndex(attackNo)))
                enemyFighterTEST.SetHP(enemyFighterTEST.GetHP - Damage)
            Else
                Damage = Int(damageAttackCalculation(person.getFighter(0), enemyFighterTEST, person.getFighter(0).GetMoveset.getMoveByIndex(attackNo)))
                enemyFighterTEST.SetHP(enemyFighterTEST.GetHP - Damage)
            End If

            narration.Text = person.getFighter(0).GetName & " used " & person.getFighter(0).GetMoveset.getMoveByIndex(attackNo).getName & " for " & Damage & " HP!"

            APressWaiter(6)

            narration.Text = enemyAttack()

            APressWaiter(4)

            narration.Text = "What will " & person.getFighter(0).GetName & " do?"
        End If
    End Sub
    Sub setvals(ByVal enemyHealthBar As ProgressBar,
                ByVal playerHealthBar As ProgressBar)
        If enemyFighterTEST.GetHP <= 0 Then
            enemyHealthBar.Value = 0
        Else
            enemyHealthBar.Value = 100 * (enemyFighterTEST.GetHP / enemyFighterTEST.GetMaxHP)
        End If


        If person.getFighter(0).GetHP <= 0 Then
            playerHealthBar.Value = 0
        Else
            playerHealthBar.Value = 100 * (person.getFighter(0).GetHP / person.getFighter(0).GetMaxHP)
        End If
    End Sub

    Private Function enemyAttack() As String
        'the enemy attacks the player with a random attack from its moveset
        Dim theAttack As Move = enemyFighterTEST.GetMoveset.getMoveByIndex(enemyFighterTEST.GetRandomAttackIndex())
        Dim Damage As Integer

        If theAttack.getAttOrSpAtt = 1 Then
            Damage = Int(damageSpecialAttackCalculation(enemyFighterTEST, person.getFighter(0), theAttack))
            person.getFighter(0).SetHP(person.getFighter(0).GetHP - Damage)
        Else
            Damage = Int(damageAttackCalculation(enemyFighterTEST, person.getFighter(0), theAttack))
            person.getFighter(0).SetHP(person.getFighter(0).GetHP - Damage)
        End If

        Return (enemyFighterTEST.GetName & " used " & theAttack.getName & " for " & Damage & " HP!")
    End Function


    'GAME MODE OVERWORLD
    '
    '
    '
    Sub MainLoop(ByVal map As SuperMap,
             ByVal currentmap As Map,
             ByVal currentX As Integer,
             ByVal currentY As Integer)
        Dim playing As Boolean = True

        ' Framerate Counter Variables
        Dim sec As Integer = TimeOfDay.Second
        Dim currentTicks As Integer
        Dim maxTicks As Integer
        Dim hTime As Integer = 8
        Dim sTime As Integer

        Dim timer As New Label
        Dim counter As New Label
        timer.Location = New Point(10, 10)
        counter.Location = New Point(10, 40)
        Me.Controls.Add(counter)
        Me.Controls.Add(timer)

        Dim movingX As Integer = 0
        Dim movingY As Integer = -1

        While playing
            ' Makes sure the game loads
            Application.DoEvents()

            ' Frame counter & Clock
            Tick(sec, currentTicks, maxTicks, hTime, sTime)
            timer.Text = "Lv: " & person.getFighter(0).GetLevel
            If hTime < 10 Then
                counter.Text = "0" & hTime
            Else
                counter.Text = hTime
            End If
            If sTime < 10 Then
                counter.Text += ":0" & sTime
            Else
                counter.Text += ":" & sTime
            End If

            ' Movement/User input
            MoveMap(map, currentmap, movingX, movingY)

            If aPress = True Then
                Dim checkingTile As Tile
                Select Case person.getDirection
                    Case "down"
                        checkingTile = map.GetTile(6, 4 + 1).getTile
                    Case "up"
                        checkingTile = map.GetTile(6, 4 - 1).getTile
                    Case "left"
                        checkingTile = map.GetTile(6 - 1, 4).getTile
                    Case "right"
                        checkingTile = map.GetTile(6 + 1, 4).getTile
                End Select
                If checkingTile.getIsString Then
                    Label1.Show()
                    Label1.Text = checkingTile.getString()
                    APressWaiter(3)
                    Label1.Hide()
                    ' aPress = False
                    xmove = 0
                    ymove = 0
                    If checkingTile.getHealable Then
                        person.getFighter(0).FullHeal()
                        person.getFighter(1).FullHeal()
                        person.getFighter(2).FullHeal()
                        person.getFighter(3).FullHeal()
                        person.getFighter(4).FullHeal()
                        person.getFighter(5).FullHeal()
                    End If
                    If checkingTile.getName = "Osmort" Then
                        enemyFighterTEST = New Fighter("Osmort", species.getSpecieByIndex(12), 30, moves.getMoveByIndex(1))
                        person.Hide()
                        For j = 0 To 10
                            For i = 0 To 6
                                map.GetTile(j + 1, i + 1).Hide()
                            Next
                        Next
                        Battle_Form_Load()
                    End If
                End If
            End If
            aPress = False
            ' NPC AI (Add later)


            ' Refresh the screen
            Me.Refresh()

        End While

    End Sub
    Sub MoveMap(ByRef map As SuperMap,
            ByRef currentmap As Map,
            ByRef movingX As Integer,
            ByRef movingY As Integer)


        If movingX <> 0 Or movingY <> 0 Then
            If movingX < 0 Then
                movingX += 1
            ElseIf movingX > 0 Then
                movingX -= 1
            ElseIf movingY < 0 Then
                movingY += 1
            ElseIf movingY > 0 Then
                movingY -= 1
            End If

        Else
            currentX += xmove
            currentY -= ymove
            If currentY < 0 Or currentX < 0 Or (currentX + 15) > currentmap.getXLimits Or (currentY + 9) > currentmap.getYLimits Or
                    currentmap.getTile(6 + currentX, 4 + currentY).getIfPassable <> True Or (xmove = 0 And ymove = 0) Then
                currentX -= xmove
                currentY += ymove
            Else
                movingX = 2
                movingY = 2

                If movingX <> 0 Then
                    For count = 0 To 10
                        For i = 0 To 6
                            map.GetTile(count + 1, i + 1).setTile(currentmap.getTile(currentX + count + 1, currentY + i + 1))
                            Me.Controls.Add(map.GetTile(count + 1, i + 1))
                        Next
                    Next
                ElseIf movingY <> 0 Then
                    For count = 0 To 10
                        For i = 0 To 6
                            map.GetTile(count + 1, i + 1).setTile(currentmap.getTile(currentX + count + 1, currentY + i + 1))
                            Me.Controls.Add(map.GetTile(count + 1, i + 1))
                        Next
                    Next
                End If

                ' Check for random encounter
                Dim rand As Integer = Int(Rnd() * 98 + 1)
                If map.GetTile(6, 4).getTile.getEncounterRate > rand Then
                    person.Hide()
                    For j = 0 To 10
                        For i = 0 To 6
                            map.GetTile(j + 1, i + 1).Hide()
                        Next
                    Next
                    Battle_Form_Load()
                    For j = 0 To 10
                        For i = 0 To 6
                            map.GetTile(j + 1, i + 1).Show()
                        Next
                    Next
                    person.Show()
                    tempVal = 3
                    currentmap.playMusic()
                End If
            End If

        End If

        ' Set player to current centre tile
        person.setCurrentTile(map.GetTile(6, 4).getTile)
        ' Set player's sprite direction
        Select Case person.getDirection
            Case "up"
                Select Case person.getCurrentTile.getName
                    Case "Plain Grass"
                        person.Image = My.Resources.PlayerGrassUp
                    Case "Mud"
                        person.Image = My.Resources.PlayerMudUp
                End Select
            Case "down"
                Select Case person.getCurrentTile.getName
                    Case "Plain Grass"
                        person.Image = My.Resources.PlayerGrassDown
                    Case "Mud"
                        person.Image = My.Resources.PlayerMudDown
                End Select
            Case "left"
                Select Case person.getCurrentTile.getName
                    Case "Plain Grass"
                        person.Image = My.Resources.PlayerGrassLeft
                    Case "Mud"
                        person.Image = My.Resources.PlayerMudLeft
                End Select
            Case "right"
                Select Case person.getCurrentTile.getName
                    Case "Plain Grass"
                        person.Image = My.Resources.PlayerGrassRight
                    Case "Mud"
                        person.Image = My.Resources.PlayerMudRight
                End Select
        End Select

        xmove = 0
        ymove = 0
    End Sub

    Sub Tick(ByRef sec As Integer,
             ByRef currentTicks As Integer,
             ByRef maxTicks As Integer,
             ByRef hTime As Integer,
             ByRef sTime As Integer)
        If sec = TimeOfDay.Second Then
            currentTicks += 1
        Else
            sec = TimeOfDay.Second
            maxTicks = currentTicks
            currentTicks = 0
            If sTime = 59 Then
                If hTime = 23 Then
                    hTime = 0
                    sTime = 0
                Else
                    hTime += 1
                    sTime = 0
                End If
            Else
                sTime += 1
            End If
        End If
    End Sub
    Sub intro()
        ' Intro
        Me.BackgroundImage = My.Resources.blackness
        My.Computer.Audio.Stop()
        Label1.Show()

        Label1.Text = "Long time ago..."
        APressWaiter(5)
        My.Computer.Audio.Play(My.Resources.PageTurn, AudioPlayMode.Background)
        Label1.Text = "In a land far, far away..."
        APressWaiter(5)
        My.Computer.Audio.Play(My.Resources.PageTurn, AudioPlayMode.Background)
        Label1.Text = "We will see the battles of a hero."
        APressWaiter(5)
        My.Computer.Audio.Play(My.Resources.PageTurn, AudioPlayMode.Background)
        Label1.Text = "His name is..."
        APressWaiter(5)
        My.Computer.Audio.Play(My.Resources.PageTurn, AudioPlayMode.Background)
        Me.BackgroundImage = My.Resources.BlobMain
        Label1.Text = "Lu."
        APressWaiter(5)
        My.Computer.Audio.Play(My.Resources.PageTurn, AudioPlayMode.Background)
        Label1.Text = "This, here, is his final fight..."
        APressWaiter(5)
        My.Computer.Audio.Play(My.Resources.PageTurn, AudioPlayMode.Background)
        Label1.Text = "(WASD to move, J to interact.)"
        APressWaiter(5)
        My.Computer.Audio.Play(My.Resources.PageTurn, AudioPlayMode.Background)

        tempVal = 2
        Label1.Hide()
    End Sub
    Sub outro()
        ' Outro
        Me.BackgroundImage = My.Resources.blackness
        My.Computer.Audio.Stop()
        Label1.Show()

        Label1.Text = "And here you have witnessed."
        APressWaiter(5)
        My.Computer.Audio.Play(My.Resources.PageTurn, AudioPlayMode.Background)
        Label1.Text = "The end of his story."
        APressWaiter(5)
        My.Computer.Audio.Play(My.Resources.PageTurn, AudioPlayMode.Background)
        Me.Close()
    End Sub
    Sub APressWaiter(ByRef tempvaler As Integer)
        'Waits for an a-press
        tempVal = 5
        aPress = False
        While aPress = False
            Application.DoEvents()
        End While
        tempVal = tempvaler
        aPress = False
    End Sub
    Sub Form1_Keypress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If tempVal = 1 Then
            ' Intro
            intro()

            ' Initialising the map, starting new game

            ' Loads image to show the game is loading
            Me.BackgroundImage = My.Resources.sample_loading_screen
            Me.Refresh()

            ' Starts initialising and loading the game
            Dim map As New SuperMap
            Dim allMaps As New All_Maps_Overworld
            Dim currentMap As New Map
            currentMap = allMaps.getTestingWorld
            For count = 0 To 10
                For i = 0 To 6
                    map.GetTile(count + 1, i + 1).setTile(currentMap.getTile(currentX + count, currentY + i))
                    Me.Controls.Add(map.GetTile(count + 1, i + 1))
                Next
            Next

            person.Location = map.GetTile(6, 4).Location
            person.setCurrentTile(map.GetTile(6, 4).getTile)
            Me.Controls.Add(person)
            person.Show()

            tempVal = 3

            ' Calls the loop to start the game
            MainLoop(map, currentMap, currentX, currentY)

        ElseIf tempVal = 3 Then
            Select Case e.KeyChar.ToString
                Case "d", "D"
                    xmove = 1
                    person.setDirection("right")
                Case "s", "S"
                    ymove = -1
                    person.setDirection("down")
                Case "a", "A"
                    xmove = -1
                    person.setDirection("left")
                Case "w", "W"
                    ymove = 1
                    person.setDirection("up")
                Case "j", "J"
                    aPress = True
            End Select

        ElseIf tempVal = 4 Then
            Select Case e.KeyChar.ToString
                Case "h"
                    Attack(1)
                Case "j"
                    Attack(2)
                Case "k"
                    Attack(3)
                Case "l"
                    Attack(4)
            End Select
        ElseIf tempVal = 5 Then
            aPress = True
        End If

    End Sub
End Class
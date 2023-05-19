Public Class Form1
    Dim currentX As Integer = 1
    Dim currentY As Integer = 1
    Dim xmove As Integer = 0
    Dim ymove As Integer = 0
    Dim tempVal As Integer = 1
    Dim menuCurrent As Integer = 1
    Dim person As New Player

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Focus()
    End Sub

    Sub MainLoop(ByVal map As SuperMap,
                 ByVal currentmap As Map,
                 ByVal currentX As Integer,
                 ByVal currentY As Integer)
        Dim playing As Boolean = True
        person.Location = map.GetTile(10, 5).Location
        Me.Controls.Add(person)

        ' Framerate Counter Variables
        Dim sec As Integer = TimeOfDay.Second
        Dim currentTicks As Integer
        Dim maxTicks As Integer

        Dim timer As New Label
        Dim counter As New Label
        timer.Location = New Point(10, 10)
        counter.Location = New Point(10, 40)
        Me.Controls.Add(timer)
        Me.Controls.Add(counter)

        Dim xMoveSee As New Label
        Dim YMoveSee As New Label
        xMoveSee.Location = New Point(10, 80)
        YMoveSee.Location = New Point(10, 120)
        Me.Controls.Add(xMoveSee)
        Me.Controls.Add(YMoveSee)

        While playing
            ' Makes sure the game loads
            Application.DoEvents()

            ' Frame counter
            Tick(sec, currentTicks, maxTicks)
            timer.Text = "FPS: " & maxTicks
            counter.Text = currentTicks

            xMoveSee.Text = xmove
            YMoveSee.Text = ymove

            ' Movement/User input
            MoveMap(map, currentmap)

            ' NPC AI (Add later)


            ' Refresh the screen
            Me.Refresh()

        End While

    End Sub
    Sub MoveMap(ByRef map As SuperMap,
                ByRef currentmap As Map)
        currentX += xmove
        currentY -= ymove

        If currentY < 0 Or currentX < 0 Or (currentX + 20) > currentmap.getXLimits Or (currentY + 11) > currentmap.getYLimits Or
            currentmap.getTile(10 + currentX, 5 + currentY).getIfPassable <> True Then
            currentX -= xmove
            currentY += ymove
        Else
            For count = 0 To 19
                For i = 0 To 10
                    map.GetTile(count + 1, i + 1).setTile(currentmap.getTile(currentX + count + 1, currentY + i + 1))
                    Me.Controls.Add(map.GetTile(count + 1, i + 1))
                Next
            Next
        End If

        xmove = 0
        ymove = 0

        'Check for random encounter

    End Sub

    Sub Tick(ByRef sec As Integer,
             ByRef currentTicks As Integer,
             ByRef maxTicks As Integer)
        If sec = TimeOfDay.Second Then
            currentTicks += 1
        Else
            sec = TimeOfDay.Second
            maxTicks = currentTicks
            currentTicks = 0
        End If
    End Sub
    Sub Form1_Keypress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If tempVal = 1 Then
            'takes away title image on first key press
            Me.BackgroundImage = My.Resources.arktree
            tempVal = 2
        ElseIf tempVal = 2 Then
            'Only selects if a key has been pressed to take away title image

            Select Case e.KeyChar
                ' A and D keys move curser right and left along the menu items, X or C to choose.
                Case "a"
                    If menuCurrent = 1 Then

                    Else
                        menuCurrent -= 1
                    End If

                Case "d"
                    If menuCurrent = 3 Then

                    Else
                        menuCurrent = +1
                    End If

                Case "z"
                    ' Goes back to the title image
                    Me.BackgroundImage = My.Resources.intro1_bg
                    tempVal = 1

                Case "x", "c"
                    Select Case menuCurrent
                        Case 1
                            ' Initialising the map, starting new game

                            ' Loads image to show the game is loading
                            Me.BackgroundImage = My.Resources.loading_screen
                            Me.Refresh()

                            ' Starts initialising and loading the game
                            Dim map As New SuperMap
                            Dim allMaps As New All_Maps_Overworld
                            Dim currentMap As New Map
                            currentMap = allMaps.getTestingWorld
                            For count = 0 To 19
                                For i = 0 To 10
                                    map.GetTile(count + 1, i + 1).setTile(currentMap.getTile(currentX + count, currentY + i))
                                    Me.Controls.Add(map.GetTile(count + 1, i + 1))
                                Next
                            Next

                            tempVal = 3


                            ' Calls the loop to start the game
                            MainLoop(map, currentMap, currentX, currentY)

                        Case 2
                            ' Sub load saved game (add later)
                    End Select
            End Select

        ElseIf tempVal = 3 Then
            Select Case e.KeyChar
                Case "d"
                    xmove = 1
                    person.Image = My.Resources.Player_Right
                Case "s"
                    ymove = -1
                    person.Image = My.Resources.Player_Down
                Case "a"
                    xmove = -1
                    person.Image = My.Resources.Player_Left
                Case "w"
                    ymove = 1
                    person.Image = My.Resources.Player_Up
            End Select

        End If

    End Sub
End Class
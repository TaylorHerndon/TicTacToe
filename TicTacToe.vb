Public Class TicTacToe

    Public Turn As Boolean

    Sub StartupSettings() Handles Me.Activated

        GameModeComboBox.SelectedItem = "Player Vs Player"

    End Sub

    Sub PlayerTurn() Handles TLButton.Click, TMButton.Click, TRButton.Click, MLButton.Click, MMButton.Click, MRButton.Click, BLButton.Click, BMButton.Click, BRButton.Click

        Dim selectedButton As Control = TLButton

        'Set score labels to black
        PlayerOneLabel.ForeColor = Color.Black
        PlayerTwoLabel.ForeColor = Color.Black
        TiesLabel.ForeColor = Color.Black

        'Set the selected button based on what button the mouse is over
        If TLButton.Bounds.Contains(PointToClient(Control.MousePosition)) Then
            selectedButton = TLButton
        End If

        If TMButton.Bounds.Contains(PointToClient(Control.MousePosition)) Then
            selectedButton = TMButton
        End If

        If TRButton.Bounds.Contains(PointToClient(Control.MousePosition)) Then
            selectedButton = TRButton
        End If

        If MLButton.Bounds.Contains(PointToClient(Control.MousePosition)) Then
            selectedButton = MLButton
        End If

        If MMButton.Bounds.Contains(PointToClient(Control.MousePosition)) Then
            selectedButton = MMButton
        End If

        If MRButton.Bounds.Contains(PointToClient(Control.MousePosition)) Then
            selectedButton = MRButton
        End If

        If BLButton.Bounds.Contains(PointToClient(Control.MousePosition)) Then
            selectedButton = BLButton
        End If

        If BMButton.Bounds.Contains(PointToClient(Control.MousePosition)) Then
            selectedButton = BMButton
        End If

        If BRButton.Bounds.Contains(PointToClient(Control.MousePosition)) Then
            selectedButton = BRButton
        End If

        'Choose character based on whos turn it is
        Dim character As String = "O"

        If Not Turn Then

            character = "X"

        End If

        'If the selected button hasn't been chosen assign the chosen character otherwise exit the sub
        If selectedButton.Text = "" Then

            selectedButton.Text = character

        Else

            Exit Sub

        End If

        BoardState() 'Update board state

        'If game mode is set to play against the computer play a computer move
        Select Case GameModeComboBox.SelectedItem

            'Plaver vs Player routine
            Case "Player Vs Player"

                AddScore(EvaluateBoard(), False) 'Update score if any win conditions are found

                'Clear the board if a win condition is found
                If EvaluateBoard() <> Nothing Then

                    EndEventDisplay()
                    ClearBoard()
                    Turn = True

                End If

            'Player vs Computer routine
            Case "Player Vs Computer (Random)"

                'Evaluate the board to see if any moves are available
                If EvaluateBoard() = "Tie" Or EvaluateBoard() = "X" Or EvaluateBoard() = "O" Then

                    'If a end condition is read then update the score and clear the board
                    AddScore(EvaluateBoard(), False)
                    EndEventDisplay()
                    ClearBoard()

                Else

                    ComputerMoveRandom() 'Make a random computer move

                    'If an end condition is read after the computer makes a move then update the score and clear the board
                    If EvaluateBoard() = "Tie" Or EvaluateBoard() = "X" Or EvaluateBoard() = "O" Then

                        AddScore(EvaluateBoard(), False)
                        EndEventDisplay()
                        ClearBoard()

                    End If

                End If

                'Toggle the turn saying that the computer's turn is finished
                Turn = Not Turn

            Case "Player Vs Computer (Little Timmy)"

                If EvaluateBoard() = "Tie" Or EvaluateBoard() = "X" Or EvaluateBoard() = "O" Then

                    'If a end condition is read then update the score and clear the board
                    AddScore(EvaluateBoard(), False)
                    EndEventDisplay()
                    ClearBoard()

                Else

                    ComputerMoveLittleTimmy() 'Little Timmy makes a move

                    'If an end condition is read after the computer makes a move then update the score and clear the board
                    If EvaluateBoard() = "Tie" Or EvaluateBoard() = "X" Or EvaluateBoard() = "O" Then

                        AddScore(EvaluateBoard(), False)
                        EndEventDisplay()
                        ClearBoard()

                    End If

                End If

                'Toggle the turn saying that the computer's turn is finished
                Turn = Not Turn

        End Select

        Turn = Not Turn

    End Sub

    Sub ClearButtonPress() Handles ClearButton.Click

        'Return everything to default values
        PlayerOneLabel.ForeColor = Color.Black
        PlayerTwoLabel.ForeColor = Color.Black
        TiesLabel.ForeColor = Color.Black

        AddScore("", True)
        ClearBoard()

    End Sub

    Sub GameModeSelectionChange() Handles GameModeComboBox.SelectedValueChanged

        'Change the game mode description box to the coresponding blurb every time the game mode box value changes
        Select Case GameModeComboBox.SelectedItem

            Case "Player Vs Player"

                GameModeDiscritionLabel.Text = "In Player vs Player each move" & vbNewLine &
                                               "switches between Xs and Os" & vbNewLine &
                                               "allways starting with Xs."

            Case "Player Vs Computer (Random)"

                GameModeDiscritionLabel.Text = "Play against a computer that" & vbNewLine &
                                               "has absolutely no idea what " & vbNewLine &
                                               "         is going on!       "

            Case "Player Vs Computer (Little Timmy)"

                GameModeDiscritionLabel.Text = "    Little Timmy isn't the  " & vbNewLine &
                                               " brightest but he does know " & vbNewLine &
                                               "  when you're about to win. "

        End Select

    End Sub

    Function BoardState()

        Static boardArray(2, 2) As String

        'Get the board state by reading each button and assigning the value to the coresponding position in the array
        boardArray(0, 0) = TLButton.Text
        boardArray(0, 1) = TMButton.Text
        boardArray(0, 2) = TRButton.Text

        boardArray(1, 0) = MLButton.Text
        boardArray(1, 1) = MMButton.Text
        boardArray(1, 2) = MRButton.Text

        boardArray(2, 0) = BLButton.Text
        boardArray(2, 1) = BMButton.Text
        boardArray(2, 2) = BRButton.Text

        Return boardArray

    End Function

    Sub ClearBoard()

        'Set all button text to nothing
        TLButton.Text = ""
        TMButton.Text = ""
        TRButton.Text = ""

        MLButton.Text = ""
        MMButton.Text = ""
        MRButton.Text = ""

        BLButton.Text = ""
        BMButton.Text = ""
        BRButton.Text = ""

        'Set turn to the default value
        Turn = False

    End Sub

    Function EvaluateBoard()

        Dim localBoardState
        localBoardState = BoardState()

        Dim boardXs(2, 2) As Boolean
        Dim boardOs(2, 2) As Boolean

        Dim moveAvailable As Boolean

        'Create boolean arrays for Xs and Os
        For r = 0 To 2

            For c = 0 To 2

                Select Case localBoardState(r, c)

                    Case "X"

                        boardXs(r, c) = True

                    Case "O"

                        boardOs(r, c) = True

                    Case ""

                        moveAvailable = True

                End Select

            Next

        Next

        'Test if any win conditions 
        If TestAllWinConditions(boardXs) Then

            Return "X"

        ElseIf TestAllWinConditions(boardOs) Then

            Return "O"

        ElseIf Not moveAvailable Then

            Return "Tie"

        Else

            Return Nothing

        End If

    End Function

    Function TestAllWinConditions(testThisArray)

        Dim winConditionFound = False

        'Run through all of the possible winning conditions and compare them to the given boolean array
        If testThisArray(0, 0) And testThisArray(0, 1) And testThisArray(0, 2) Then

            winConditionFound = True

        End If

        If testThisArray(1, 0) And testThisArray(1, 1) And testThisArray(1, 2) Then

            winConditionFound = True

        End If

        If testThisArray(2, 0) And testThisArray(2, 1) And testThisArray(2, 2) Then

            winConditionFound = True

        End If

        If testThisArray(0, 0) And testThisArray(1, 0) And testThisArray(2, 0) Then

            winConditionFound = True

        End If

        If testThisArray(0, 1) And testThisArray(1, 1) And testThisArray(2, 1) Then

            winConditionFound = True

        End If

        If testThisArray(0, 2) And testThisArray(1, 2) And testThisArray(2, 2) Then

            winConditionFound = True

        End If

        If testThisArray(0, 0) And testThisArray(1, 1) And testThisArray(2, 2) Then

            winConditionFound = True

        End If

        If testThisArray(0, 2) And testThisArray(1, 1) And testThisArray(2, 0) Then

            winConditionFound = True

        End If

        'return wether or not a win condition was found
        Return winConditionFound

    End Function

    Sub AddScore(incrementThisScore As String, Clear As Boolean)

        Static playerOneScore As Integer
        Static playerTwoScore As Integer
        Static tieScore As Integer

        'Set score labels to default values and set scores to 0
        If Clear Then

            PlayerOneLabel.Text = "Player 1: 0"
            PlayerTwoLabel.Text = "Player 2: 0"
            TiesLabel.Text = "Ties: 0"

            playerOneScore = 0
            playerTwoScore = 0
            tieScore = 0

            ClearBoard()

        End If

        'Increment the score of the coresponding player player 1 is allways X and player 2 is allways O
        Select Case incrementThisScore

            Case "X"

                playerOneScore += 1
                PlayerOneLabel.Text = "Player 1: " & playerOneScore

            Case "O"

                playerTwoScore += 1
                PlayerTwoLabel.Text = "Player 2: " & playerTwoScore

            Case "Tie"

                tieScore += 1
                TiesLabel.Text = "Ties: " & tieScore

            Case Else



        End Select

    End Sub

    Sub ComputerMoveRandom()

        Randomize()

        Dim localBoardState
        localBoardState = BoardState()

        Dim possibleMoves(2, 2) As Boolean
        Dim row As Integer
        Dim column As Integer

        'Find what moves can be made
        For r = 0 To 2

            For c = 0 To 2

                If localBoardState(r, c) = "" Then

                    possibleMoves(r, c) = True

                Else

                    possibleMoves(r, c) = False

                End If

            Next

        Next

        'Get a random row and collumn
        row = Math.Floor(VBMath.Rnd * 3)
        column = Math.Floor(VBMath.Rnd * 3)

        'Get random rows and columns until one isn't taken
        Do Until possibleMoves(row, column) = True

            'Get a random row and collumn
            row = Math.Floor(VBMath.Rnd * 3)
            column = Math.Floor(VBMath.Rnd * 3)

        Loop

        'Set the coresponding button to "O"
        Select Case row

            Case 0

                Select Case column

                    Case 0
                        TLButton.Text = "O"
                    Case 1
                        TMButton.Text = "O"
                    Case 2
                        TRButton.Text = "O"

                End Select

            Case 1

                Select Case column

                    Case 0
                        MLButton.Text = "O"
                    Case 1
                        MMButton.Text = "O"
                    Case 2
                        MRButton.Text = "O"

                End Select

            Case 2

                Select Case column

                    Case 0
                        BLButton.Text = "O"
                    Case 1
                        BMButton.Text = "O"
                    Case 2
                        BRButton.Text = "O"

                End Select

        End Select

    End Sub

    Sub ComputerMoveLittleTimmy()

        Dim localBoardState
        localBoardState = BoardState()

        'Find what moves can be made
        Dim possibleMoves(2, 2) As Boolean
        For r = 0 To 2

            For c = 0 To 2

                If localBoardState(r, c) = "" Then

                    possibleMoves(r, c) = True

                Else

                    possibleMoves(r, c) = False

                End If

            Next

        Next

        'Find out what the player has done
        Dim opponentMoves(2, 2)
        For r = 0 To 2

            For c = 0 To 2

                If localBoardState(r, c) = "X" Then

                    opponentMoves(r, c) = True

                Else

                    opponentMoves(r, c) = False

                End If

            Next

        Next

        'Little timmy needs to see if the player is one move from winning

        Dim testingBoard
        Dim winningMoveFound As Boolean
        Dim winningRow As Integer
        Dim winningColumn As Integer

        testingBoard = opponentMoves.Clone

        For r = 0 To 2

            For c = 0 To 2

                If possibleMoves(r, c) Then 'Check to see if the selected square is a possible move

                    testingBoard(r, c) = True 'Set the currently selected square to true

                    If TestAllWinConditions(testingBoard) Then 'See if the new board wins for X

                        winningMoveFound = True 'There is a winning move

                        'Record the winning move cordinates
                        winningRow = r
                        winningColumn = c

                        c = 2
                        r = 2

                    End If

                    testingBoard = opponentMoves.Clone

                Else

                    'Continue to the next square

                End If

            Next

        Next

        'At this point Little Timmy knows if there is a winning move for X and will play accordingly

        If winningMoveFound Then

            'Stop the winning move
            Select Case winningRow

                Case 0

                    Select Case winningColumn

                        Case 0
                            TLButton.Text = "O"
                        Case 1
                            TMButton.Text = "O"
                        Case 2
                            TRButton.Text = "O"

                    End Select

                Case 1

                    Select Case winningColumn

                        Case 0
                            MLButton.Text = "O"
                        Case 1
                            MMButton.Text = "O"
                        Case 2
                            MRButton.Text = "O"

                    End Select

                Case 2

                    Select Case winningColumn

                        Case 0
                            BLButton.Text = "O"
                        Case 1
                            BMButton.Text = "O"
                        Case 2
                            BRButton.Text = "O"

                    End Select

            End Select

        Else

            'Little Timmy isn't that good so if there isn't a winning move to stop he will just play a random move
            ComputerMoveRandom()

        End If

    End Sub

    Sub EndEventDisplay()

        'Find out who won by evaluating the board
        Dim endCondition As String = EvaluateBoard()

        'Set the coresponding lable to green text
        Select Case endCondition

            Case "X"

                PlayerOneLabel.ForeColor = Color.Green

            Case "O"

                PlayerTwoLabel.ForeColor = Color.Green

            Case "Tie"

                TiesLabel.ForeColor = Color.Green

        End Select

    End Sub

End Class

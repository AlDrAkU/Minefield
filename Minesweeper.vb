Imports Minefield.MineCell.MineCellView


Public Class Minesweeper
    Dim PlayerName As String
    Dim CellSize As Integer = CInt(settings.txtCellSize.Text)
    Dim Boardrows As Integer
    Dim BoardCols As Integer
    Dim MineCount As Integer
    Dim Seconds As Integer = 0
    Dim MarkedMines As Integer = 0
    Dim MineField(Boardrows, BoardCols) As MineCell
    Dim Done As Boolean = False


    Private Sub Minesweeper_Load(sender As Object, e As EventArgs) Handles Me.Load

        StartGame(8, 8, 10)

    End Sub
    Private Sub BuildBoard()
        Done = False
        Seconds = 0
        DoLabels()
        tmrTimer.Enabled = False
        MarkedMines = 0
        PlayerName = settings.txtNamePlayer.Text
        Dim CellSize As Integer = CInt(settings.txtCellSize.Text)
        'Loop through the rows and columns
        Me.Hide()
        ReDim MineField(Boardrows - 1, BoardCols - 1)
        pnlMine.Controls.Clear()

        For Row As Integer = 0 To Boardrows - 1
            For Col As Integer = 0 To BoardCols - 1
                Dim C As New MineCell
                pnlMine.Controls.Add(C)
                C.Left = CellSize * Col
                C.Top = CellSize * Row
                C.Width = CellSize
                C.Height = CellSize
                C.HasMine = False
                C.Number = 0
                C.X = Col
                C.Y = Row
                MineField(Row, Col) = C
                AddHandler C.MouseClick, AddressOf MineClick

            Next
        Next

        'Generate Random Mine Locations
        Dim RX As New Random
        For i As Integer = 1 To MineCount
            Dim X As Integer = 0
            Dim Y As Integer = 0
            Do
                X = RX.Next(0, BoardCols)
                Y = RX.Next(0, Boardrows)

            Loop Until Not MineField(Y, X).HasMine
            MineField(Y, X).HasMine = True
            'MineField(Y, X).ButtonColor = Color.Red
            'MineField(Y, X).View = Mine
        Next

        'Count the Mines
        For Row As Integer = 0 To Boardrows - 1
            For Col As Integer = 0 To BoardCols - 1
                If Not MineField(Row, Col).HasMine Then
                    For R As Integer = Row - 1 To Row + 1
                        For C As Integer = Col - 1 To Col + 1
                            If R >= 0 And R < Boardrows And C >= 0 And C < BoardCols And Not (Row = R And Col = C) Then
                                If MineField(R, C).HasMine Then
                                    MineField(Row, Col).Number += 1

                                End If
                            End If

                        Next
                    Next
                End If

                'If MineField(Row, Col).Number > 0 Then MineField(Row, Col).View = MineCell.MineCellView.Number
                'If MineField(Row, Col).Number > 0 Then MineField(Row, Col).ButtonColor = Color.Green

            Next
        Next




        'Resize to fit the minefield

        Me.Width = BoardCols * CellSize
        Do Until Me.pnlMine.Width = BoardCols * CellSize
            Me.Width += 1

        Loop
        Me.Height = Boardrows * CellSize
        Do Until pnlMine.Height = Boardrows * CellSize
            Me.Height += 1
        Loop
        Me.Show()

    End Sub
    Public Sub StartGame(Rows As Integer, Cols As Integer, Mines As Integer)
        Boardrows = Rows
        BoardCols = Cols
        MineCount = Mines
        BuildBoard()

    End Sub
    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click, NewGameToolStripMenuItem.Click
        BuildBoard()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click

    End Sub

  
    Private Sub MineClick(sender As Object, e As MouseEventArgs)
        If Done Then Exit Sub
        tmrTimer.Enabled = True

        Dim M As MineCell = CType(sender, MineCell)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If M.HasMine Then


                For Each MC As MineCell In MineField
                    If MC.HasMine Then MC.View = Mine
                Next
                tmrTimer.Enabled = False
                MessageBox.Show("Game Over! " & PlayerName, "You Lose!")
                Done = True

                'For R As Integer = 0 To Boardrows - 1
                'For C As Integer = 0 To BoardCols - 1
                ' Dim CC As MineCell = MineField(C, R)
                ' If CC.HasMine Then
                'CC.View = MineCell.MineCellView.Mine
                '  CC.Refresh()

                ' End If
                '  Next
                '  Next

            ElseIf M.Number > 0 Then
                M.View = Number
                If GameOver() Then
                    tmrTimer.Enabled = False
                    MessageBox.Show("Congratulations " & PlayerName & " You are victorious!", " You win! ")
                    Done = True
                    CalculateHighscore()
                End If
            ElseIf M.Number = 0 Then
                ShowBlanks(M)
                If GameOver() Then
                    tmrTimer.Enabled = False
                    MessageBox.Show("Congratulations " & PlayerName & " You are victorious! ", " You win! ")
                    Done = True
                    CalculateHighscore()
                End If
            End If



        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            Select Case M.View
                Case Button
                    M.View = Flag
                    MarkedMines += 1
                    DoLabels()

                Case Flag
                    M.View = Question
                    MarkedMines -= 1
                    DoLabels()

                Case Else
                    M.View = Button
            End Select
        End If
    End Sub

    Private Sub ShowBlanks(ByVal M As MineCell)
        M.View = Number
        For R As Integer = M.Y - 1 To M.Y + 1
            For C As Integer = M.X - 1 To M.X + 1
                If R >= 0 And R < Boardrows And C >= 0 And C < Boardrows Then
                    Dim MC As MineCell = MineField(R, C)
                    If MC.View = Button Then
                        If MC.Number = 0 Then
                            ShowBlanks(MC)
                        Else
                            MC.View = Number
                        End If


                    End If
                End If

            Next
        Next
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        Seconds += 1
        DoLabels()

    End Sub
    Private Sub DoLabels()
        lblTime.Text = Seconds.ToString
        If MarkedMines <= MineCount Then
            lblMines.Text = (MineCount - MarkedMines).ToString
        End If
    End Sub
    Private Function GameOver() As Boolean

        Dim TV As Boolean = True
        For Each Mc As MineCell In MineField
            If Not Mc.HasMine And Not Mc.View = Number Then
                TV = False
            End If
        Next
        Return TV
    End Function

    Private Sub BeginnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeginnerToolStripMenuItem.Click
        StartGame(8, 8, 10)

    End Sub

    Private Sub IntermediateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntermediateToolStripMenuItem.Click
        StartGame(16, 16, 40)

    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        StartGame(30, 30, 99)

    End Sub

   

    
    Private Sub CalculateHighscore()
        Dim ElapsedTime As Integer = Seconds
        Dim Rank1Score As Integer = CInt(settings.lblScoreRank1.Text)
        Dim Rank2Score As Integer = CInt(settings.lblScoreRank2.Text)
        Dim Rank3Score As Integer = CInt(settings.lblScoreRank3.Text)
        Dim Rank1Player As String = settings.lblNameRank1.Text
        Dim Rank2Player As String = settings.lblNameRank2.Text
        Dim Rank3Player As String = settings.lblNameRank3.Text

        PlayerName = settings.txtNamePlayer.Text

        If ElapsedTime < Rank1Score Then
            Rank3Score = Rank2Score
            Rank3Player = Rank2Player
            Rank2Player = Rank1Player
            Rank2Score = Rank1Score
            Rank1Score = ElapsedTime
            Rank1Player = PlayerName
        ElseIf ElapsedTime > Rank1Score And ElapsedTime < Rank2Score Then
            Rank3Score = Rank2Score
            Rank3Player = Rank2Player
            Rank2Player = PlayerName
            Rank2Score = ElapsedTime
        ElseIf ElapsedTime > Rank1Score And ElapsedTime > Rank2Score Then
            Rank3Player = PlayerName
            Rank3Score = ElapsedTime

        End If

        'Updating the labels
        settings.lblNameRank1.Text = Rank1Player
        settings.lblNameRank2.Text = Rank2Player
        settings.lblNameRank3.Text = Rank3Player
        settings.lblScoreRank1.Text = Rank1Score.ToString
        settings.lblScoreRank2.Text = Rank2Score.ToString
        settings.lblScoreRank3.Text = Rank3Score.ToString




    End Sub

    Private Sub SettingsHighscoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsHighscoreToolStripMenuItem.Click
        settings.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()

    End Sub
End Class

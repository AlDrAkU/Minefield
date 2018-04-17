Imports Minefield.Minesweeper



Public Class settings
    Dim NumberOfMines As Integer
    Dim NumberofRowsAndCols As Integer
    Dim PlayerName As String


    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        NumberOfMines = CInt(txtNrMines.Text)
        NumberofRowsAndCols = CInt(txtColsAndRows.Text)
        PlayerName = txtNamePlayer.Text

        Me.Hide()
        Minesweeper.StartGame(NumberofRowsAndCols, NumberofRowsAndCols, NumberOfMines)


    End Sub
End Class
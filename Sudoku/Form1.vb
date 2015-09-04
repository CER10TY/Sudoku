Public Class SudokuForm
    ' Member (Global) vars
    ' Dimension of each cell in the grid
    Const CellWidth As Integer = 32
    Const CellHeight As Integer = 32
    ' Offset from top left corner of window (adjust as necessary)
    Const xOffset As Integer = -20
    Const yOffset As Integer = 30
    ' Color for empty cell
    Private DEFAULT_BACKCOLOR As Color = Color.White
    ' Color for original puzzle values
    Private FIXED_FORECOLOR As Color = Color.Blue
    Private FIXED_BACKCOLOR As Color = Color.LightSteelBlue
    ' Color for user-inserted values
    Private USER_FORECOLOR As Color = Color.Black
    Private USER_BACKCOLOR As Color = Color.LightYellow
    ' Currently selected number
    Private SelectedNumber As Integer
    ' Stacks to keep track of all the moves
    Private Moves As Stack(Of String)
    Private RedoMoves As Stack(Of String)
    ' Keep track of filename (for saving)
    Private saveFilename As String = String.Empty
    ' Values on grid stored in array
    Private actual(9, 9) As Integer
    ' Used to keep track of elapsed time
    Private seconds As Integer = 0
    ' Check if game has started
    Private GameStarted As Boolean = False
    ' Hint Mode - whether user wants to solve puzzle enirely or just get a hint
    Private HintMode As Boolean
    Private HintVal As Integer = 0
    ' Keep track of possible solutions for cell. eg if cell(7,8) has possible solutions 2,3,5 possible(7,8) = 235
    Private possible(9, 9) As String

    ' DRAWING GRID ON GAME START - SUB
    Public Sub DrawBoard()
        ' Default selected number is 1
        btn1.Checked = True
        SelectedNumber = 1

        ' Storing the location of the cell
        Dim location As New Point
        ' Draw the cells (the meat of the sub)
        For row As Integer = 1 To 9
            For col As Integer = 1 To 9
                location.X = col * (CellWidth + 1) + xOffset
                location.Y = row * (CellHeight + 1) + yOffset
                Dim lbl As New Label
                With lbl ' Cell definition - color, location on grid etc
                    .Name = col.ToString() & row.ToString()
                    .BorderStyle = BorderStyle.Fixed3D
                    .Location = location
                    .Width = CellWidth
                    .Height = CellHeight
                    .TextAlign = ContentAlignment.MiddleCenter
                    .BackColor = DEFAULT_BACKCOLOR
                    .Font = New Font(.Font, .Font.Style Or FontStyle.Bold)
                    .Tag = "1"
                    AddHandler lbl.Click, AddressOf Cell_Click
                End With
                Me.Controls.Add(lbl)
            Next
        Next
    End Sub
    Private Sub Cell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Check to see if game has started or not
        If Not GameStarted Then
            DisplayActivity("Click File-> New to start a new game or File -> Open to load an existing game", True)
            Return
        End If

        Dim cellLabel As Label = CType(sender, Label)
        ' If cell is not erasable (.Tag value of 0) then exit
        If cellLabel.Tag.ToString() = "0" Then
            DisplayActivity("Selected cell is not empty", False)
            Return
        End If

        ' Determine col(umn) & row of selected cell
        Dim col As Integer = cellLabel.Name.Substring(0, 1) ' Since the cells follow the pattern of col, row, value we simply take the first value. Eg. 123 would be column 1, row 2, value 3.
        Dim row As Integer = cellLabel.Name.ToString().Substring(1, 1) ' Same principle, with the second value in the integer being the row.

        ' Erasing a cell
        If SelectedNumber = 0 Then
            ' If cell is empty, return
            If actual(col, row) = 0 Then Return

            ' Erase cell
            SetCell(col, row, SelectedNumber, 1)
            DisplayActivity("Number erased at (" & col & "," & row & ")", False)

        ElseIf cellLabel.Text = String.Empty Then
            ' Else set value, check if move is valid.
            If Not IsMoveValid(col, row, SelectedNumber) Then
                DisplayActivity("Invalid move at (" & col & "," & row & ")", False)
                Return
            End If
            ' Set the move
            SetCell(col, row, SelectedNumber, 1)
            DisplayActivity("Number placed at (" & col & "," & row & ")", False)
            ' Save the move
            Moves.Push(cellLabel.Name.ToString() & SelectedNumber)

            ' Check if puzzle is solved
            If isPuzzleSolved() Then
                timerSolved.Enabled = False
                Beep()
                ToolStripStatusLabel1.Text = "****Puzzled Solved****"
            End If
        End If
    End Sub

    Private Sub SudokuForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Init status bar
        ToolStripStatusLabel1.Text = String.Empty
        ToolStripStatusLabel2.Text = String.Empty
        ' Draw the board (call sub)
        DrawBoard()
    End Sub

    Private Sub SudokuForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Draw the lines outlining the minigrid
        Dim x1, x2, y1, y2 As Integer
        ' Draw horizontal lines -----
        x1 = 1 * (CellWidth + 1) + xOffset - 1
        x2 = 9 * (CellWidth + 1) + xOffset + CellWidth
        For r As Integer = 1 To 10 Step 3
            y1 = r * (CellHeight + 1) + yOffset - 1
            y2 = y1
            e.Graphics.DrawLine(Pens.Black, x1, y1, x2, y2)
        Next
        ' Draw the vertical lines |||||
        y1 = 1 * (CellHeight + 1) + yOffset - 1
        y2 = 9 * (CellHeight + 1) + yOffset + CellHeight
        For c As Integer = 1 To 10 Step 3
            x1 = c * (CellWidth + 1) + xOffset - 1
            x2 = x1
            e.Graphics.DrawLine(Pens.Black, x1, y1, x2, y2)
        Next
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        ' "New" Menu item - check if user wants to save first, then start new game. Else start new game.
        If GameStarted Then
            Dim response As MsgBoxResult = MessageBox.Show("Do you want to save current game?", "Save curent game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                SaveGameToDisk(False)
            ElseIf response = MsgBoxResult.Cancel Then
                Return
            End If
        End If
    End Sub
    Public Sub SaveGameToDisk(ByVal saveAs As Boolean)
        ' Save game function
        ' If savefilename is empty, means game has not been saved before
        If saveFilename = String.Empty OrElse saveAs Then
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "SD0 files (*.sdo)|*.sdo|All files (*.*)|*.*"
            saveFileDialog1.FilterIndex = 1
            saveFileDialog1.RestoreDirectory = False
            If saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' Store filename
                saveFilename = saveFileDialog1.FileName
            Else
                Return
            End If
        End If

        ' Formulate the string representing the values to store
        Dim str As New System.Text.StringBuilder()
        For row As Integer = 1 To 9
            For col As Integer = 1 To 9
                str.Append(actual(col, row).ToString())
            Next
        Next

        ' Save values to file
        Try
            Dim fileExists As Boolean
            fileExists = My.Computer.FileSystem.FileExists(saveFilename)
            If fileExists = True Then
                My.Computer.FileSystem.DeleteFile(saveFilename) ' Delete file before making a new one
                My.Computer.FileSystem.WriteAllText(saveFilename, str.ToString(), True)
                ToolStripStatusLabel1.Text = "Puzzle saved in " & saveFilename
            End If
        Catch ex As Exception
            MsgBox("Error saving game. Please try again.")
        End Try
    End Sub

    Public Sub StartNewGame()
        ' START NEW GAME
        saveFilename = String.Empty
        txtActivities.Text = String.Empty
        seconds = 0
        ClearBoard() ' Clear the board.
        GameStarted = True
        timerSolved.Enabled = True
        ToolStripStatusLabel1.Text = "New game started"
        CellToolTip.RemoveAll() ' Remove all cell tool tips.
    End Sub

    Public Sub ClearBoard()
        ' Init the stacks
        Moves = New Stack(Of String)
        RedoMoves = New Stack(Of String)

        ' Init cells on board
        For row As Integer = 1 To 9
            For col As Integer = 1 To 9
                SetCell(col, row, 0, 1)
            Next
        Next
    End Sub

    Private Sub timerSolved_Tick(sender As Object, e As EventArgs) Handles timerSolved.Tick
        ToolStripStatusLabel2.Text = "Elapsed time: " & seconds & " second(s)"
        seconds += 1
    End Sub
    Private Sub ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click
        Dim selectedButton As ToolStripButton = CType(sender, ToolStripButton)
        ' Uncheck all button controls in ToolStrip1
        ' Examples:
        ' ToolStrip1.Items.Item(0) is "Select number"
        ' ToolStrip1.Items.Item(1) is "1"
        For i As Integer = 1 To 10
            CType(ToolStrip1.Items.Item(i), ToolStripButton).Checked = False
        Next
        ' Set selected button to active, checked
        selectedButton.Checked = True
        ' Set appropriate number selected
        If selectedButton.Text = "Erase" Then
            SelectedNumber = 0
        Else
            SelectedNumber = CInt(selectedButton.Text)
        End If
    End Sub
    Public Function IsMoveValid(ByVal col As Integer, ByVal row As Integer, ByVal value As Integer) As Boolean
        ' Check if user move is valid.
        Dim puzzleSolved As Boolean = True
        ' Scan through column
        For r As Integer = 1 To 9
            If actual(col, r) = value Then ' Duplicate since value already exists in column.
                Return False
            End If
        Next
        ' Scan through row
        For c As Integer = 1 To 9
            If actual(c, row) = value Then ' Duplicate
                Return False
            End If
        Next

        ' Scan through minigrid
        Dim startC, startR As Integer
        startC = col - ((col - 1) Mod 3)
        startR = row - ((row - 1) Mod 3)

        For rr As Integer = 0 To 2
            For cc As Integer = 0 To 2
                If actual(startC + cc, startR + rr) = value Then
                    ' Duplicate
                    Return False
                End If
            Next
        Next
        Return True
    End Function
    Public Function IsPuzzleSolved() As Boolean
        ' Check if puzzle is solved
        ' Check row by row
        Dim pattern As String
        Dim r, c As Integer
        For r = 1 To 9
            pattern = "123456789"
            For c = 1 To 9
                pattern = pattern.Replace(actual(c, r).ToString(), String.Empty)
            Next
            If pattern.Length > 0 Then
                Return False
            End If
        Next
        ' Check col by col
        For c = 1 To 9
            pattern = "123456789"
            For r = 1 To 9
                pattern = pattern.Replace(actual(c, r).ToString(), String.Empty)
            Next
            If pattern.Length > 0 Then
                Return False
            End If
        Next
        ' Check by minigrid
        For c = 1 To 9 Step 3
            pattern = "123456789"
            For r = 1 To 9 Step 3
                For cc As Integer = 0 To 2
                    For rr As Integer = 0 To 2
                        pattern = pattern.Replace(actual(c + cc, r + rr).ToString(), String.Empty)
                    Next
                Next
            Next
            If pattern.Length > 0 Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Sub SetCell(ByVal col As Integer, ByVal row As Integer, ByVal value As Integer, ByVal erasable As Short)
        ' Set cell based on value selected in tool strip (ie 1,2,3,4,5,6,7,8,9)
        ' Locate the particular label control
        Dim lbl() As Control = Me.Controls.Find(col.ToString() & row.ToString(), True)
        Dim cellLabel As Label = CType(lbl(0), Label)

        ' Save the value in the array
        actual(col, row) = value
        ' If erasing cell, all possible() values have to be reset for each cell.
        If value = 0 Then
            For r As Integer = 1 To 9
                For c As Integer = 1 To 9
                    If actual(c, r) = 0 Then possible(c, r) = String.Empty
                Next
            Next
        Else
            possible(col, row) = value.ToString()
        End If
        If value = 0 Then ' Erasing the cell
            cellLabel.Text = String.Empty
            cellLabel.Tag = erasable
            cellLabel.BackColor = DEFAULT_BACKCOLOR
        Else
            If erasable = 0 Then ' Default puzzle values
                cellLabel.BackColor = FIXED_BACKCOLOR
                cellLabel.ForeColor = FIXED_FORECOLOR
            Else ' User-set values
                cellLabel.BackColor = USER_BACKCOLOR
                cellLabel.ForeColor = USER_FORECOLOR
            End If
            cellLabel.Text = value
            cellLabel.Tag = erasable
        End If
    End Sub
    Public Sub DisplayActivity(ByVal str As String, ByVal soundbeep As Boolean)
        ' Message function
        If soundbeep Then Beep()
        txtActivities.Text &= str & Environment.NewLine
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        ' "Undo" Menu item
        ' If no previous moves, then exit
        If Moves.Count = 0 Then Return

        ' Move from Moves stack to redomoves stack
        Dim str As String = Moves.Pop()
        RedoMoves.Push(str)

        ' Save value in the array
        SetCell(Integer.Parse(str(0)), Integer.Parse(str(1)), 0, 1)
        DisplayActivity("Value removed at (" & Integer.Parse(str(0)) & "," & Integer.Parse(str(1)) & ")", False)
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        ' "Redo" menu item
        ' If stack empty, exit
        If RedoMoves.Count = 0 Then Return

        ' Move from the redomoves stack to moves stack
        Dim str As String = RedoMoves.Pop()
        Moves.Push(str)

        ' save value in array
        SetCell(Integer.Parse(str(0)), Integer.Parse(str(1)), Integer.Parse(str(2)), 1)
        DisplayActivity("Value reinserted at (" & Integer.Parse(str(0)) & "," & Integer.Parse(str(1)) & ")", False)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        ' "Save As" Menu item
        If Not GameStarted Then
            DisplayActivity("Game not started yet.", True)
            Return
        End If

        SaveGameToDisk(True)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If Not GameStarted Then
            DisplayActivity("Game not started yet.", True)
            Return
        End If
        SaveGameToDisk(False)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If GameStarted Then
            Dim response As MsgBoxResult = MessageBox.Show("Do you want to save the current game?", "Save c urrent game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                SaveGameToDisk(False)
            ElseIf response = MsgBoxResult.Cancel Then
                Return
            End If
        End If

        ' load game from disk
        Dim filecontents As String
        Dim openfiledialog1 As New OpenFileDialog()
        openfiledialog1.Filter = "SD0 files (*.sdo)|*.sdo|All files (*.*)|*.*"
        openfiledialog1.FilterIndex = 1
        openfiledialog1.RestoreDirectory = False

        If openfiledialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            filecontents = My.Computer.FileSystem.ReadAllText(openfiledialog1.FileName)
            ToolStripStatusLabel1.Text = openfiledialog1.FileName
            saveFilename = openfiledialog1.FileName
        Else
            Return
        End If

        StartNewGame()

        ' init board
        Dim counter As Short = 0
        For row As Integer = 1 To 9
            For col As Integer = 1 To 9
                Try
                    If CInt(filecontents(counter).ToString()) <> 0 Then
                        SetCell(col, row, CInt(filecontents(counter).ToString()), 0)
                    End If
                Catch ex As Exception
                    MsgBox("File does not contain a valid sudoku puzzle")
                    Exit Sub
                End Try
                counter += 1
            Next
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If GameStarted Then
            Dim response As MsgBoxResult = MsgBox("Do you want to save the current game?", MsgBoxStyle.YesNoCancel, "Save current game")
            If response = MsgBoxResult.Yes Then
                SaveGameToDisk(False)
            ElseIf response = MsgBoxResult.Cancel Then
                Return
            End If
            ' exit app
        End If
    End Sub
    Public Sub SetToolTip(ByVal col As Integer, ByVal row As Integer, ByVal possibleValues As String)
        ' Set tooltip to suggest possible values for each cell to player.
        ' Locate the label control in question
        Dim lbl() As Control = Me.Controls.Find(col.ToString() & row.ToString(), True)
        CellToolTip.SetToolTip(CType(lbl(0), Label), possibleValues)
    End Sub
    Public Function CalculatePossibleValues(ByVal col As Integer, ByVal row As Integer) As String
        ' get current posssible values for selected cell
        Dim str As String
        If possible(col, row) = String.Empty Then
            str = "123456789"
        Else
            str = possible(col, row)
        End If
        ' Check by column - Step 1
        Dim r, c As Integer
        For r = 1 To 9
            If actual(col, r) <> 0 Then ' <> == !=
                ' Value in cell
                str = str.Replace(actual(col, r).ToString(), String.Empty)
            End If
        Next

        ' Check by row - Step 2
        For c = 1 To 9
            If actual(c, row) <> 0 Then ' <> == !=
                ' Value in cell
                str = str.Replace(actual(c, row).ToString(), String.Empty)
            End If
        Next

        ' Check by minigrid - Step 3
        Dim startC, startR As Integer
        startC = col - ((col - 1) Mod 3)
        startR = row - ((row - 1) Mod 3)
        For rr As Integer = startR To startR + 2
            For cc As Integer = startC To startC + 2
                If actual(cc, rr) <> 0 Then
                    ' Value in cell
                    str = str.Replace(actual(cc, rr).ToString(), String.Empty)
                End If
            Next
        Next

        ' If possible value is empty string produce error due to invalid move.
        If str = String.Empty Then
            Throw New Exception("Invalid Move.")
        End If
        Return str
    End Function
    Public Function CheckColumnsAndRows() As Boolean
        ' Checks for all possible values for all cells.
        ' It calls CalculatePossibleValues(), and assigns the returned number (if there's ONE number returned) to the cell it just checked.
        ' If HintMode is True (user is requesting a hint), this function exits after the first successfully confirmed cell.
        ' Else, it simply solves all cells.
        Dim changes As Boolean = False
        ' Check cells
        For row As Integer = 1 To 9
            For col As Integer = 1 To 9
                If actual(col, row) = 0 Then
                    Try
                        possible(col, row) = CalculatePossibleValues(col, row)
                        'debug ToolStripStatusLabel1.Text = possible(col, row).ToString()
                    Catch ex As Exception
                        DisplayActivity("Invalid placement, please undo move", False)
                        Throw New Exception("Invalid Move")
                    End Try

                    ' Tooltip display
                    'SetToolTip(col, row, possible(col, row)) ' Wrong placement - the function quits after one iteration if HintMode, leaving the tool tip stranded. View HelpToolTips subroutine instead.
                    If possible(col, row).Length = 1 Then ' If possible(c,r) only has 1 value in it
                        SetCell(col, row, CInt(possible(col, row)), 1) ' Set the cell
                        ' Update vars and txtActivities
                        actual(col, row) = CInt(possible(col, row))
                        DisplayActivity("Col/Row & Minigrid Elimination", False)
                        DisplayActivity("==============================", False)
                        DisplayActivity("Inserted value " & actual(col, row) & " in " & "(" & col & "," & row & ")", False)
                        ' Get UI of application to refresh with new numbers
                        Application.DoEvents()

                        ' Save move into stack
                        Moves.Push(col & row & possible(col, row))
                        'debug ToolStripStatusLabel1.Text = possible(5, 1).ToString()
                        ' If HintMode, stop
                        changes = True
                        If HintMode Then Return True
                    End If
                End If
            Next
        Next
        Return changes
    End Function

    Private Sub btnHint_Click(sender As Object, e As EventArgs) Handles btnHint.Click
        ' When user clicks Hint Button
        If (HintVal Mod 2) = 0 Then
            HintMode = True
            HintVal += 1
            'debug ToolStripStatusLabel1.Text = "Hint Mode ON"
        Else
            HintMode = False
            HintVal += 1
            'debug ToolStripStatusLabel1.Text = "Hint Mode OFF"
        End If
        If HintMode Then
            Try
                SolvePuzzle()
            Catch ex As Exception
                MessageBox.Show("Please undo your move", "Invalid move", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            HelpToolTips()
        End If
    End Sub

    Private Sub btnSolvePuzzle_Click(sender As Object, e As EventArgs) Handles btnSolvePuzzle.Click
        ' When user clicks the Solve Puzzle button
        HintMode = False
        Try
            SolvePuzzle()
        Catch ex As Exception
            MessageBox.Show("Please undo your move", "Invalid move", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function SolvePuzzle() As Boolean
        ' The actual solve puzzle function
        Dim changes As Boolean
        Dim ExitLoop As Boolean = False
        Try
            Do
                ' Perform CRME
                changes = CheckColumnsAndRows() ' Returns True or False
                If (HintMode AndAlso changes) OrElse IsPuzzleSolved() Then
                    ExitLoop = True
                    Exit Do
                End If
            Loop Until Not changes ' Loops until changes (which in turn calls CCAR()) returns false, which happens when a definitive value cannot be returned on a cell.
        Catch ex As Exception
            Throw New Exception("Invalid move")
        End Try

        If IsPuzzleSolved() Then
            timerSolved.Enabled = False
            Beep()
            ToolStripStatusLabel1.Text = "****Puzzled Solved****"
            MsgBox("Puzzle Solved")
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub HelpToolTips()
        ' Proper placement - now contains ALL possible tool tips for ALL empty cells.
        For row As Integer = 1 To 9
            For col As Integer = 1 To 9
                If actual(col, row) = 0 Then
                    possible(col, row) = CalculatePossibleValues(col, row)
                    SetToolTip(col, row, possible(col, row))
                End If
            Next
        Next
    End Sub
End Class

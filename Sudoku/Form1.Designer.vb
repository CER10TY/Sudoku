<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SudokuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SudokuForm))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifficultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtremelyDifficultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolLabel = New System.Windows.Forms.ToolStripLabel()
        Me.btn1 = New System.Windows.Forms.ToolStripButton()
        Me.btn2 = New System.Windows.Forms.ToolStripButton()
        Me.btn3 = New System.Windows.Forms.ToolStripButton()
        Me.btn4 = New System.Windows.Forms.ToolStripButton()
        Me.btn5 = New System.Windows.Forms.ToolStripButton()
        Me.btn6 = New System.Windows.Forms.ToolStripButton()
        Me.btn7 = New System.Windows.Forms.ToolStripButton()
        Me.btn8 = New System.Windows.Forms.ToolStripButton()
        Me.btn9 = New System.Windows.Forms.ToolStripButton()
        Me.btn10 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtActivities = New System.Windows.Forms.TextBox()
        Me.btnHint = New System.Windows.Forms.Button()
        Me.btnSolvePuzzle = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.timerSolved = New System.Windows.Forms.Timer(Me.components)
        Me.CellToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.HintToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(535, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.DifficultToolStripMenuItem, Me.ExtremelyDifficultToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ToolsToolStripMenuItem.Text = "&Levels"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Easy"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.OptionsToolStripMenuItem.Text = "&Medium"
        '
        'DifficultToolStripMenuItem
        '
        Me.DifficultToolStripMenuItem.Name = "DifficultToolStripMenuItem"
        Me.DifficultToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DifficultToolStripMenuItem.Text = "&Difficult"
        '
        'ExtremelyDifficultToolStripMenuItem
        '
        Me.ExtremelyDifficultToolStripMenuItem.Name = "ExtremelyDifficultToolStripMenuItem"
        Me.ExtremelyDifficultToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ExtremelyDifficultToolStripMenuItem.Text = "Ex&tremely Difficult"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolLabel, Me.btn1, Me.btn2, Me.btn3, Me.btn4, Me.btn5, Me.btn6, Me.btn7, Me.btn8, Me.btn9, Me.btn10})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(535, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolLabel
        '
        Me.ToolLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolLabel.Name = "ToolLabel"
        Me.ToolLabel.Size = New System.Drawing.Size(83, 22)
        Me.ToolLabel.Text = "Select number"
        '
        'btn1
        '
        Me.btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn1.Image = CType(resources.GetObject("btn1.Image"), System.Drawing.Image)
        Me.btn1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(23, 22)
        Me.btn1.Text = "1"
        '
        'btn2
        '
        Me.btn2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn2.Image = CType(resources.GetObject("btn2.Image"), System.Drawing.Image)
        Me.btn2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(23, 22)
        Me.btn2.Text = "2"
        '
        'btn3
        '
        Me.btn3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn3.Image = CType(resources.GetObject("btn3.Image"), System.Drawing.Image)
        Me.btn3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(23, 22)
        Me.btn3.Text = "3"
        '
        'btn4
        '
        Me.btn4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn4.Image = CType(resources.GetObject("btn4.Image"), System.Drawing.Image)
        Me.btn4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(23, 22)
        Me.btn4.Text = "4"
        '
        'btn5
        '
        Me.btn5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn5.Image = CType(resources.GetObject("btn5.Image"), System.Drawing.Image)
        Me.btn5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(23, 22)
        Me.btn5.Text = "5"
        '
        'btn6
        '
        Me.btn6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn6.Image = CType(resources.GetObject("btn6.Image"), System.Drawing.Image)
        Me.btn6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(23, 22)
        Me.btn6.Text = "6"
        '
        'btn7
        '
        Me.btn7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn7.Image = CType(resources.GetObject("btn7.Image"), System.Drawing.Image)
        Me.btn7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(23, 22)
        Me.btn7.Text = "7"
        '
        'btn8
        '
        Me.btn8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn8.Image = CType(resources.GetObject("btn8.Image"), System.Drawing.Image)
        Me.btn8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(23, 22)
        Me.btn8.Text = "8"
        '
        'btn9
        '
        Me.btn9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn9.Image = CType(resources.GetObject("btn9.Image"), System.Drawing.Image)
        Me.btn9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(23, 22)
        Me.btn9.Text = "9"
        '
        'btn10
        '
        Me.btn10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn10.Image = CType(resources.GetObject("btn10.Image"), System.Drawing.Image)
        Me.btn10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(38, 22)
        Me.btn10.Text = "Erase"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 389)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(535, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(332, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Activities"
        '
        'txtActivities
        '
        Me.txtActivities.Location = New System.Drawing.Point(329, 69)
        Me.txtActivities.Multiline = True
        Me.txtActivities.Name = "txtActivities"
        Me.txtActivities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtActivities.Size = New System.Drawing.Size(203, 300)
        Me.txtActivities.TabIndex = 5
        '
        'btnHint
        '
        Me.btnHint.Location = New System.Drawing.Point(12, 365)
        Me.btnHint.Name = "btnHint"
        Me.btnHint.Size = New System.Drawing.Size(142, 23)
        Me.btnHint.TabIndex = 6
        Me.btnHint.Text = "Hint"
        Me.btnHint.UseVisualStyleBackColor = True
        '
        'btnSolvePuzzle
        '
        Me.btnSolvePuzzle.Location = New System.Drawing.Point(160, 365)
        Me.btnSolvePuzzle.Name = "btnSolvePuzzle"
        Me.btnSolvePuzzle.Size = New System.Drawing.Size(142, 23)
        Me.btnSolvePuzzle.TabIndex = 7
        Me.btnSolvePuzzle.Text = "Solve Puzzle"
        Me.btnSolvePuzzle.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'timerSolved
        '
        Me.timerSolved.Interval = 1000
        '
        'SudokuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 411)
        Me.Controls.Add(Me.btnSolvePuzzle)
        Me.Controls.Add(Me.btnHint)
        Me.Controls.Add(Me.txtActivities)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "SudokuForm"
        Me.Text = "Sudoku"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DifficultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtremelyDifficultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btn1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtActivities As System.Windows.Forms.TextBox
    Friend WithEvents btnHint As System.Windows.Forms.Button
    Friend WithEvents btnSolvePuzzle As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents timerSolved As System.Windows.Forms.Timer
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CellToolTip As ToolTip
    Friend WithEvents HintToolTip As System.Windows.Forms.ToolTip
End Class

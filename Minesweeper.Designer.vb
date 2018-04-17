<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Minesweeper
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
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeginnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermediateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsHighscoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMines = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.pnlMine = New System.Windows.Forms.Panel()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainMenu.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(540, 24)
        Me.mnuMainMenu.TabIndex = 0
        Me.mnuMainMenu.Text = "MainMenu"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ToolStripSeparator1, Me.BeginnerToolStripMenuItem, Me.IntermediateToolStripMenuItem, Me.AdvancedToolStripMenuItem, Me.SettingsHighscoreToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "&Game"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'BeginnerToolStripMenuItem
        '
        Me.BeginnerToolStripMenuItem.Name = "BeginnerToolStripMenuItem"
        Me.BeginnerToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.BeginnerToolStripMenuItem.Text = "&Beginner"
        '
        'IntermediateToolStripMenuItem
        '
        Me.IntermediateToolStripMenuItem.Name = "IntermediateToolStripMenuItem"
        Me.IntermediateToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.IntermediateToolStripMenuItem.Text = "&Intermediate"
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AdvancedToolStripMenuItem.Text = "&Advanced"
        '
        'SettingsHighscoreToolStripMenuItem
        '
        Me.SettingsHighscoreToolStripMenuItem.Name = "SettingsHighscoreToolStripMenuItem"
        Me.SettingsHighscoreToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SettingsHighscoreToolStripMenuItem.Text = "Settings and Highscore"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblMines, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTime, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRetry, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlMine, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(540, 413)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lblMines
        '
        Me.lblMines.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMines.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMines.Location = New System.Drawing.Point(9, 9)
        Me.lblMines.Margin = New System.Windows.Forms.Padding(9)
        Me.lblMines.Name = "lblMines"
        Me.lblMines.Size = New System.Drawing.Size(222, 42)
        Me.lblMines.TabIndex = 0
        Me.lblMines.Text = "0"
        Me.lblMines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(309, 9)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(222, 42)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "0"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRetry
        '
        Me.btnRetry.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRetry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRetry.Location = New System.Drawing.Point(249, 9)
        Me.btnRetry.Margin = New System.Windows.Forms.Padding(9)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(42, 42)
        Me.btnRetry.TabIndex = 2
        Me.btnRetry.Text = "Start"
        Me.btnRetry.UseVisualStyleBackColor = False
        '
        'pnlMine
        '
        Me.pnlMine.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TableLayoutPanel1.SetColumnSpan(Me.pnlMine, 3)
        Me.pnlMine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMine.Location = New System.Drawing.Point(9, 69)
        Me.pnlMine.Margin = New System.Windows.Forms.Padding(9)
        Me.pnlMine.Name = "pnlMine"
        Me.pnlMine.Size = New System.Drawing.Size(522, 335)
        Me.pnlMine.TabIndex = 3
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 1000
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Minesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 437)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.MaximizeBox = False
        Me.Name = "Minesweeper"
        Me.Text = "Minefield™      ©Razvan Bouros"
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeginnerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntermediateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMines As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnRetry As System.Windows.Forms.Button
    Friend WithEvents pnlMine As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents SettingsHighscoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

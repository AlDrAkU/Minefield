<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.txtColsAndRows = New System.Windows.Forms.TextBox()
        Me.txtNrMines = New System.Windows.Forms.TextBox()
        Me.txtNamePlayer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblLooks1 = New System.Windows.Forms.Label()
        Me.lblLooks3 = New System.Windows.Forms.Label()
        Me.lblLooks2 = New System.Windows.Forms.Label()
        Me.lblNameRank1 = New System.Windows.Forms.Label()
        Me.lblNameRank3 = New System.Windows.Forms.Label()
        Me.lblNameRank2 = New System.Windows.Forms.Label()
        Me.lblScoreRank1 = New System.Windows.Forms.Label()
        Me.lblScoreRank2 = New System.Windows.Forms.Label()
        Me.lblScoreRank3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCellSize = New System.Windows.Forms.TextBox()
        Me.lblCellSize = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtColsAndRows
        '
        Me.txtColsAndRows.Location = New System.Drawing.Point(284, 30)
        Me.txtColsAndRows.Name = "txtColsAndRows"
        Me.txtColsAndRows.Size = New System.Drawing.Size(100, 20)
        Me.txtColsAndRows.TabIndex = 0
        Me.txtColsAndRows.Text = "8"
        '
        'txtNrMines
        '
        Me.txtNrMines.Location = New System.Drawing.Point(284, 56)
        Me.txtNrMines.Name = "txtNrMines"
        Me.txtNrMines.Size = New System.Drawing.Size(100, 20)
        Me.txtNrMines.TabIndex = 1
        Me.txtNrMines.Text = "10"
        '
        'txtNamePlayer
        '
        Me.txtNamePlayer.Location = New System.Drawing.Point(284, 82)
        Me.txtNamePlayer.Name = "txtNamePlayer"
        Me.txtNamePlayer.Size = New System.Drawing.Size(100, 20)
        Me.txtNamePlayer.TabIndex = 2
        Me.txtNamePlayer.Text = "Player1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desired Nr. of Columns and Rows"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desired Nr. of Mines"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Name Of Player"
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(309, 154)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(75, 23)
        Me.btnOkay.TabIndex = 6
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "HIGHSCORES"
        '
        'lblLooks1
        '
        Me.lblLooks1.AutoSize = True
        Me.lblLooks1.Location = New System.Drawing.Point(22, 16)
        Me.lblLooks1.Name = "lblLooks1"
        Me.lblLooks1.Size = New System.Drawing.Size(16, 13)
        Me.lblLooks1.TabIndex = 8
        Me.lblLooks1.Text = "1."
        '
        'lblLooks3
        '
        Me.lblLooks3.AutoSize = True
        Me.lblLooks3.Location = New System.Drawing.Point(22, 60)
        Me.lblLooks3.Name = "lblLooks3"
        Me.lblLooks3.Size = New System.Drawing.Size(16, 13)
        Me.lblLooks3.TabIndex = 11
        Me.lblLooks3.Text = "3."
        '
        'lblLooks2
        '
        Me.lblLooks2.AutoSize = True
        Me.lblLooks2.Location = New System.Drawing.Point(22, 38)
        Me.lblLooks2.Name = "lblLooks2"
        Me.lblLooks2.Size = New System.Drawing.Size(16, 13)
        Me.lblLooks2.TabIndex = 12
        Me.lblLooks2.Text = "2."
        '
        'lblNameRank1
        '
        Me.lblNameRank1.AutoSize = True
        Me.lblNameRank1.Location = New System.Drawing.Point(92, 16)
        Me.lblNameRank1.Name = "lblNameRank1"
        Me.lblNameRank1.Size = New System.Drawing.Size(56, 13)
        Me.lblNameRank1.TabIndex = 13
        Me.lblNameRank1.Text = "TestName"
        '
        'lblNameRank3
        '
        Me.lblNameRank3.AutoSize = True
        Me.lblNameRank3.Location = New System.Drawing.Point(92, 60)
        Me.lblNameRank3.Name = "lblNameRank3"
        Me.lblNameRank3.Size = New System.Drawing.Size(56, 13)
        Me.lblNameRank3.TabIndex = 16
        Me.lblNameRank3.Text = "TestName"
        '
        'lblNameRank2
        '
        Me.lblNameRank2.AutoSize = True
        Me.lblNameRank2.Location = New System.Drawing.Point(92, 38)
        Me.lblNameRank2.Name = "lblNameRank2"
        Me.lblNameRank2.Size = New System.Drawing.Size(56, 13)
        Me.lblNameRank2.TabIndex = 17
        Me.lblNameRank2.Text = "TestName"
        '
        'lblScoreRank1
        '
        Me.lblScoreRank1.AutoSize = True
        Me.lblScoreRank1.Location = New System.Drawing.Point(161, 16)
        Me.lblScoreRank1.Name = "lblScoreRank1"
        Me.lblScoreRank1.Size = New System.Drawing.Size(25, 13)
        Me.lblScoreRank1.TabIndex = 18
        Me.lblScoreRank1.Text = "999"
        '
        'lblScoreRank2
        '
        Me.lblScoreRank2.AutoSize = True
        Me.lblScoreRank2.Location = New System.Drawing.Point(161, 38)
        Me.lblScoreRank2.Name = "lblScoreRank2"
        Me.lblScoreRank2.Size = New System.Drawing.Size(25, 13)
        Me.lblScoreRank2.TabIndex = 19
        Me.lblScoreRank2.Text = "999"
        '
        'lblScoreRank3
        '
        Me.lblScoreRank3.AutoSize = True
        Me.lblScoreRank3.Location = New System.Drawing.Point(161, 60)
        Me.lblScoreRank3.Name = "lblScoreRank3"
        Me.lblScoreRank3.Size = New System.Drawing.Size(25, 13)
        Me.lblScoreRank3.TabIndex = 20
        Me.lblScoreRank3.Text = "999"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLooks1)
        Me.GroupBox1.Controls.Add(Me.lblScoreRank3)
        Me.GroupBox1.Controls.Add(Me.lblLooks3)
        Me.GroupBox1.Controls.Add(Me.lblScoreRank2)
        Me.GroupBox1.Controls.Add(Me.lblLooks2)
        Me.GroupBox1.Controls.Add(Me.lblScoreRank1)
        Me.GroupBox1.Controls.Add(Me.lblNameRank1)
        Me.GroupBox1.Controls.Add(Me.lblNameRank2)
        Me.GroupBox1.Controls.Add(Me.lblNameRank3)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 87)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'txtCellSize
        '
        Me.txtCellSize.Location = New System.Drawing.Point(284, 108)
        Me.txtCellSize.Name = "txtCellSize"
        Me.txtCellSize.Size = New System.Drawing.Size(100, 20)
        Me.txtCellSize.TabIndex = 24
        Me.txtCellSize.Text = "16"
        '
        'lblCellSize
        '
        Me.lblCellSize.AutoSize = True
        Me.lblCellSize.Location = New System.Drawing.Point(30, 115)
        Me.lblCellSize.Name = "lblCellSize"
        Me.lblCellSize.Size = New System.Drawing.Size(86, 13)
        Me.lblCellSize.TabIndex = 25
        Me.lblCellSize.Text = "Desired Cell Size"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 312)
        Me.Controls.Add(Me.lblCellSize)
        Me.Controls.Add(Me.txtCellSize)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNamePlayer)
        Me.Controls.Add(Me.txtNrMines)
        Me.Controls.Add(Me.txtColsAndRows)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtColsAndRows As System.Windows.Forms.TextBox
    Friend WithEvents txtNrMines As System.Windows.Forms.TextBox
    Friend WithEvents txtNamePlayer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblLooks1 As System.Windows.Forms.Label
    Friend WithEvents lblLooks3 As System.Windows.Forms.Label
    Friend WithEvents lblLooks2 As System.Windows.Forms.Label
    Friend WithEvents lblNameRank1 As System.Windows.Forms.Label
    Friend WithEvents lblNameRank3 As System.Windows.Forms.Label
    Friend WithEvents lblNameRank2 As System.Windows.Forms.Label
    Friend WithEvents lblScoreRank1 As System.Windows.Forms.Label
    Friend WithEvents lblScoreRank2 As System.Windows.Forms.Label
    Friend WithEvents lblScoreRank3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCellSize As System.Windows.Forms.TextBox
    Friend WithEvents lblCellSize As System.Windows.Forms.Label
End Class

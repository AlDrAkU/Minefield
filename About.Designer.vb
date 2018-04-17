<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAdress = New System.Windows.Forms.Label()
        Me.lblOsVersion = New System.Windows.Forms.Label()
        Me.lblHostname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(197, 226)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(75, 23)
        Me.btnOkay.TabIndex = 0
        Me.btnOkay.Text = "Ok"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Location = New System.Drawing.Point(12, 20)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(38, 13)
        Me.lblAbout.TabIndex = 1
        Me.lblAbout.Text = "About:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "This is version made for project purposes."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Currently at:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "© 2014 Razvan Bouros"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "All rights reserved."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "All unregistered use is punishable by law."
        '
        'lblAdress
        '
        Me.lblAdress.AutoSize = True
        Me.lblAdress.Location = New System.Drawing.Point(12, 123)
        Me.lblAdress.Name = "lblAdress"
        Me.lblAdress.Size = New System.Drawing.Size(0, 13)
        Me.lblAdress.TabIndex = 7
        '
        'lblOsVersion
        '
        Me.lblOsVersion.AutoSize = True
        Me.lblOsVersion.Location = New System.Drawing.Point(12, 146)
        Me.lblOsVersion.Name = "lblOsVersion"
        Me.lblOsVersion.Size = New System.Drawing.Size(0, 13)
        Me.lblOsVersion.TabIndex = 8
        '
        'lblHostname
        '
        Me.lblHostname.AutoSize = True
        Me.lblHostname.Location = New System.Drawing.Point(132, 99)
        Me.lblHostname.Name = "lblHostname"
        Me.lblHostname.Size = New System.Drawing.Size(0, 13)
        Me.lblHostname.TabIndex = 9
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblHostname)
        Me.Controls.Add(Me.lblOsVersion)
        Me.Controls.Add(Me.lblAdress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.btnOkay)
        Me.Name = "frmAbout"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAdress As System.Windows.Forms.Label
    Friend WithEvents lblOsVersion As System.Windows.Forms.Label
    Friend WithEvents lblHostname As System.Windows.Forms.Label
End Class

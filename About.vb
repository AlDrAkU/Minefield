Public Class frmAbout
    Dim Hostname As String = System.Net.Dns.GetHostName()
    Dim Adress As String = System.Net.Dns.GetHostByName(Hostname).AddressList(0).ToString()
    Dim OsVersion As String = My.Computer.Info.OSFullName

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHostname.Text = Hostname
        lblAdress.Text = Adress
        lblOsVersion.Text = OsVersion
    End Sub
    Private Sub btwOK_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Me.Close()

    End Sub
End Class
Public Class ServerPath
    Dim ManualClose As Boolean = True
    Private Sub ServerPath_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ServerPath_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ManualClose Then
            Form1.Close()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Guna2Transition1.ShowSync(Panel1)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath IsNot Nothing Then
            Form1.ServerLocation = FolderBrowserDialog1.SelectedPath
            Guna2TextBox23.Text = FolderBrowserDialog1.SelectedPath
            Guna2Button3.Enabled = True
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ManualClose = False
        Form1.WebBrowser1.Navigate(Guna2TextBox23.Text)
        Form1.Guna2Transition1.ShowSync(Form1.AppContainer)
        Me.Close()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Form1.Hide()
        CreateServer.Show()
    End Sub
End Class
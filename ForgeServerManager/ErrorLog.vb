Public Class ErrorLog
    Private Sub ErrorLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TextBox1.Text = Form1.ErrorContent.ToString
    End Sub
End Class
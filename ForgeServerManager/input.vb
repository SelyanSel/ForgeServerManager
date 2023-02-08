Public Class input
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Editor.GeneratorSettings = Me.Guna2TextBox1.Text
        Me.Close()
    End Sub

    Private Sub input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TextBox1.Text = Editor.GeneratorSettings
    End Sub
End Class
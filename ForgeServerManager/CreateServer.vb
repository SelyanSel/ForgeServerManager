Public Class CreateServer
    Dim ManualClose As Boolean = True
    Private Sub CreateServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CreateServer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ManualClose Then
            ServerPath.Show()
            Form1.Show()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Guna2CheckBox1.Checked = Not True Then
            MsgBox("Please read and agree to the Minecraft EULA. Link: https://account.mojang.com/documents/minecraft_eula", MsgBoxStyle.Critical, "Error")
        Else
            Me.Hide()
            CreatingServer.Show()
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then
            Guna2TextBox1.Text = "#By changing the setting below to TRUE you are indicating your agreement to our EULA (https://account.mojang.com/documents/minecraft_eula)." + vbNewLine + "eula=true"
        Else
            Guna2TextBox1.Text = "#By changing the setting below to TRUE you are indicating your agreement to our EULA (https://account.mojang.com/documents/minecraft_eula)." + vbNewLine + "eula=false"
        End If
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Guna2Button1.Enabled = True
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath IsNot Nothing Then
            Guna2ComboBox1.Enabled = True
        End If
    End Sub
End Class
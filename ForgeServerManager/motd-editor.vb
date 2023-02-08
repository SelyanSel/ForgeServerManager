Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Public Class motd_editor
    Dim Color As String
    Dim sm As New SettingManager(Form1.ServerLocation + "\server.properties")
    Public Function InitMinecraftFont()
        Dim pfc As PrivateFontCollection = New PrivateFontCollection()
        Dim fontLength As Integer = My.Resources.Minecraft.Length
        Dim fontdata As Byte() = My.Resources.Minecraft
        Dim data As System.IntPtr = Marshal.AllocCoTaskMem(fontLength)
        Marshal.Copy(fontdata, 0, data, fontLength)
        pfc.AddMemoryFont(data, fontLength)
        Label1.Font = New Font(pfc.Families(0), 14, FontStyle.Regular)
        Label3.Font = New Font(pfc.Families(0), 14, FontStyle.Regular)
        Guna2TextBox1.Font = New Font(pfc.Families(0), 9, FontStyle.Regular)
        Return True
    End Function
    Private Sub motd_editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitMinecraftFont()
        Guna2TextBox1.Text = sm.GetSetting("motd")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Color = "\u00A74"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Color = "\u00A76"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Color = "\u00A7e"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Color = "\u00A72"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Color = "\u00A7a"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Color = "\u00A71"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Color = "\u00A7f"
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Editor.MOTD = Color + Guna2TextBox1.Text
        Me.Close()
    End Sub
End Class
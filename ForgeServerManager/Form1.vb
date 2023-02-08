Imports System.IO
Imports System.Text
Imports System.Diagnostics

Public Class Form1
    Dim path As String
    Public ServerLocation As String = "C:\servere"
    Dim sm As New SettingManager(ServerLocation + "\server.properties")
    Public ErrorContent As String
    Public Arguments As String = "@user_jvm_args.txt @libraries/net/minecraftforge/forge/1.18.2-40.2.0/win_args.txt %* --nogui"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "localhost:" + sm.GetSetting("server-port")
        ServerPath.Show()
    End Sub
    Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Process.Start("https://www.buymeacoffee.com/celianalazard")
        Guna2Transition1.ShowSync(ThanksText)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Editor.Show()
    End Sub

    Private Sub Guna2Chip1_Click(sender As Object, e As EventArgs) Handles Guna2Chip1.Click
        ErrorLog.Show()
        ErrorLog.Guna2TextBox1.Text = ErrorContent
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If System.IO.File.Exists(ServerLocation + "\user_jvm_args.txt") Then
            path = ServerLocation + "\" + Guid.NewGuid.ToString() + ".bat"
            Try
                Dim fs As FileStream = File.Create(path)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo off" + vbNewLine + "title Forge Server" + vbNewLine + "echo Starting server on port " + sm.GetSetting("server-port").ToString + vbNewLine + "cd " + ServerLocation + vbNewLine + "java " + Arguments + vbNewLine + "pause")
                fs.Write(info, 0, info.Length)
                fs.Close()
                Process.Start(path)
            Catch ex As Exception
                ErrorContent = ex.ToString
                Guna2Transition1.ShowSync(Guna2Chip1)
                If File.Exists(path) Then
                    File.Delete(path)
                End If
            End Try
        Else
            MsgBox("ERROR: Unsuportted version! Currently, ForgeServerManager only support servers on 1.18+ !")
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Settings.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            For Each _file As String In Directory.GetFiles(ServerLocation, "*.bat")
                File.Delete(_file)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AppContainer_Paint(sender As Object, e As PaintEventArgs) Handles AppContainer.Paint

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        WebBrowser1.GoBack()
    End Sub
End Class

Imports System.IO
Imports System.IO.Compression
Imports Guna.UI2.WinForms
Imports System.Text

Public Class CreatingServer
    Dim CanClose As Boolean
    Dim path As String
    Private Sub CreatingServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2TaskBarProgress1.Increment(5)
        If Guna2TaskBarProgress1.Value = 80 Then
            Label1.Text = "Downloading Forge, Please wait."
        End If
        If Guna2TaskBarProgress1.Value = 100 Then
            Timer1.Stop()
            Guna2TaskBarProgress1.Value = 10
            My.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/989253678588387358/1072986124529713263/1.18.2_Forge.zip", CreateServer.FolderBrowserDialog1.SelectedPath + "\temp.zip")
            Process.Start("powershell", "Expand-Archive -LiteralPath '" + CreateServer.FolderBrowserDialog1.SelectedPath + "\temp.zip" + "' -DestinationPath " + CreateServer.FolderBrowserDialog1.SelectedPath)
            While Not File.Exists(CreateServer.FolderBrowserDialog1.SelectedPath + "\user_jvm_args.txt")
                Guna2TaskBarProgress1.Value = 30
                Label1.Text = "Extracting..."
            End While
            path = CreateServer.FolderBrowserDialog1.SelectedPath + "\" + Guid.NewGuid.ToString() + ".bat"
            Try
                Dim fs1 As FileStream = File.Create(path)
                Dim info1 As Byte() = New UTF8Encoding(True).GetBytes("@echo off" + vbNewLine + "title Forge Server" + vbNewLine + "echo Starting for the first time, please wait..." + vbNewLine + "cd " + CreateServer.FolderBrowserDialog1.SelectedPath + vbNewLine + "java @user_jvm_args.txt @libraries/net/minecraftforge/forge/1.18.2-40.2.0/win_args.txt %*")
                fs1.Write(info1, 0, info1.Length)
                fs1.Close()
                Process.Start(Path)
            Catch ex As Exception
                Form1.ErrorContent = ex.ToString
                ErrorLog.Show()
                ServerPath.Show()
                Me.Close()
                If File.Exists(Path) Then
                    File.Delete(Path)
                End If
            End Try
            While Not File.Exists(CreateServer.FolderBrowserDialog1.SelectedPath + "\eula.txt")
                Guna2TaskBarProgress1.Value = 50
                Label1.Text = "Final preparations..."
            End While
            Threading.Thread.Sleep(1000)
            Dim path2 As String = CreateServer.FolderBrowserDialog1.SelectedPath + "\eula.txt"
            Dim fs As FileStream = File.Create(path2)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("eula=true")
            fs.Write(info, 0, info.Length)
            fs.Close()
            Guna2TaskBarProgress1.Value = 70
            Me.Hide()
            Form1.ServerLocation = CreateServer.FolderBrowserDialog1.SelectedPath
            Form1.Show()
            Form1.WebBrowser1.Navigate(Form1.ServerLocation)
            Form1.Guna2Transition1.ShowSync(Form1.AppContainer)
            Congrats.Show()
            Me.Close()
        End If
    End Sub
End Class
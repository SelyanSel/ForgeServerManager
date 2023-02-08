Imports System.CodeDom.Compiler
Imports System.IO
Imports System.Text

Public Class Congrats
    Dim path As String
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Congrats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(Form1.ServerLocation + "\temp.zip") Then
            System.IO.File.Delete(Form1.ServerLocation + "\temp.zip")
        End If
        My.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/989253678588387358/1072997163551956992/server.properties", Form1.ServerLocation + "\server.properties")
    End Sub
End Class
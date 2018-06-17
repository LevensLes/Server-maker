Imports System.IO


Public Class Form1


    Dim UserAccName As String = SystemInformation.UserName
    Dim Ram1 As String = ("Xms1024M -Xmx1024M")
    Dim Ram2 As String = ("Xmx2048M -Xms2048M")
    Dim Ram3 As String = ("Xmx3072M -Xms3072M")
    Dim Ram4 As String = ("Xmx4096M -Xms4096M")

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FlatComboBox1.SelectedIndex = 0
        FlatComboBox2.SelectedIndex = 1

    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click
        Close()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        If FlatCheckBox1.Checked = True Then

        End If


        If Directory.Exists("C:\Users\" & UserAccName & "\desktop\Server") Then
            MessageBox.Show("Folder already exists")
            Stop
        Else
            Directory.CreateDirectory("C:\Users\" & UserAccName & "\desktop\Server")
        End If

        If FlatComboBox1.Text.Contains("1.7.10") Then
            My.Computer.Network.DownloadFile("https://cdn.getbukkit.org/spigot/spigot-1.7.10-SNAPSHOT-b1657.jar", "C:\Users\" & UserAccName & "\desktop\Server\spigot.jar")
        End If

        If FlatComboBox1.Text.Contains("1.8.9") Then
            My.Computer.Network.DownloadFile("https://cdn.getbukkit.org/spigot/spigot-1.8-R0.1-SNAPSHOT-latest.jar", "C:\Users\" & UserAccName & "\desktop\Server\spigot.jar")
        End If

        If FlatComboBox1.Text.Contains("1.9") Then
            My.Computer.Network.DownloadFile("https://cdn.getbukkit.org/spigot/spigot-1.9-R0.1-SNAPSHOT-latest.jar", "C:\Users\" & UserAccName & "\desktop\Server\spigot.jar")
        End If

        If FlatComboBox1.Text.Contains("1.10") Then
            My.Computer.Network.DownloadFile("https://cdn.getbukkit.org/spigot/spigot-1.10-R0.1-SNAPSHOT-latest.jar", "C:\Users\" & UserAccName & "\desktop\Server\spigot.jar")
        End If

        If FlatComboBox1.Text.Contains("1.11") Then
            My.Computer.Network.DownloadFile("https://cdn.getbukkit.org/spigot/spigot-1.11.jar", "C:\Users\" & UserAccName & "\desktop\Server\spigot.jar")
        End If

        If FlatComboBox1.Text.Contains("1.12") Then
            My.Computer.Network.DownloadFile("https://cdn.getbukkit.org/spigot/spigot-1.12.jar", "C:\Users\" & UserAccName & "\desktop\Server\spigot.jar")
        End If

        Dim filepath As String = ("C:\Users\" & UserAccName & "\desktop\Server\start.bat")
        System.IO.File.Create(filepath).Dispose()


        Dim file As System.IO.StreamWriter

        If FlatComboBox2.Text.Contains("1GB") Then
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & UserAccName & "\desktop\Server\start.bat", True)
            file.WriteLine("@echo off
java -" & Ram1 & " -jar spigot.jar -o true 
pause")
            file.Close()
        End If

        If FlatComboBox2.Text.Contains("2GB") Then
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & UserAccName & "\desktop\Server\start.bat", True)
            file.WriteLine("@echo off
java -" & Ram2 & " -jar spigot.jar -o true 
pause")
            file.Close()
        End If

        If FlatComboBox2.Text.Contains("3GB") Then
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & UserAccName & "\desktop\Server\start.bat", True)
            file.WriteLine("@echo off
java -" & Ram3 & " -jar spigot.jar -o true 
pause")
            file.Close()
        End If

        If FlatComboBox2.Text.Contains("4GB") Then
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & UserAccName & "\desktop\Server\start.bat", True)
            file.WriteLine("@echo off
java -" & Ram4 & " -jar spigot.jar -o true 
pause")
            file.Close()
        End If

        My.Computer.Network.DownloadFile("https://www.levensles.club/server/run.bat",
          "C:\Users\" & UserAccName & "\Downloads\run.bat")
        Dim proc As New System.Diagnostics.Process()

        proc = Process.Start("C:\Users\" & UserAccName & "\Downloads\run.bat", "")

        Threading.Thread.Sleep(1600)


        If FlatCheckBox2.Checked = True Then


            Dim nigger As String = ("C:\Users\" & UserAccName & "\desktop\Server\eula.txt")
            System.IO.File.Create(nigger).Dispose()

            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & UserAccName & "\desktop\Server\eula.txt", True)
            file.WriteLine("#By changing the setting below to TRUE you are indicating your agreement to our EULA (https://account.mojang.com/documents/minecraft_eula).
#Sun Jun 17 02:42:37 CEST 2018
eula=true
")
            file.Close()

        Else

        End If

        If FlatCheckBox1.Checked = True Then
            My.Computer.Network.DownloadFile("https://www.levensles.club/server/worldedit-bukkit-6.0.jar",
          "C:\Users\" & UserAccName & "\desktop\Server\plugins\world-edit.jar")

            My.Computer.Network.DownloadFile("https://www.levensles.club/server/Essentials.jar",
         "C:\Users\" & UserAccName & "\desktop\Server\plugins\essentials.jar")

        End If

    End Sub
End Class

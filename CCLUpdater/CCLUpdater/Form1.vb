Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports HtmlAgilityPack
Imports MadMilkman.Ini

Public Class Form1

    Dim currCCL As String = "?"

    Private Sub Log(ByVal s As String, ByVal IsError As Boolean)
        Dim item As ListViewItem

        item = lvLog.Items.Add(DateTime.Now.ToShortTimeString())
        item.SubItems.Add(s)

        lvLog.Items(lvLog.Items.Count - 1).EnsureVisible()

        If IsError Then
            item.ImageIndex = 3
        Else
            item.ImageIndex = 2
        End If
    End Sub

    Private Sub iniConfig()
        If System.IO.File.Exists("versions.ini") = False Then
            Dim options As New IniOptions()
            Dim iniFile As New IniFile(options)
            iniFile.Sections.Add(New IniSection(iniFile, "Versions", New IniKey(iniFile, "CCL", "?")))
            iniFile.Save("versions.ini")
        Else
            Dim ini As New IniFile()
            ini.Load("versions.ini")
            currCCL = ini.Sections("Versions").Keys("CCL").Value
        End If
    End Sub

    Public Sub ScrapeWeb(link As String, text As Label)
        Try
            'download page from the link into an HtmlDocument'
            Dim doc As HtmlDocument = New HtmlWeb().Load(link)
            'select <div> having class attribute equals fontdef1'
            Dim div As HtmlNode = doc.DocumentNode.SelectSingleNode("/html/body/div[4]/div/main/div[2]/div/div[2]/div/div[1]/ul/li[1]/a/span")
            'if the div is found, print the inner text'
            If Not div Is Nothing Then
                'Console.WriteLine(div.InnerText.Trim())
                text.Text = div.InnerText.Trim().Replace("v", "")
                Log("Last Version: " + div.InnerText.Trim().Replace("v", ""), True)
            End If
        Catch ex As Exception
            MsgBox("Error!")
            Log("Error getting version.", True)
            Button1.Enabled = True
            Button2.Enabled = False
            Button3.Enabled = False
        End Try
    End Sub

    Private Sub OnDownloadComplete(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        If Not e.Cancelled AndAlso e.Error Is Nothing Then
            MessageBox.Show("Download complete! now you can install!")
            Log("File downloaded successfully.", True)
            ProgressBar1.Value = 0
            Button3.Enabled = True
        Else
            MessageBox.Show("Download Failure!")
            Log("File downloaded incorrectly.", True)
            Button1.Enabled = True
            Button2.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub ShowDownloadProgress(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub saveIni(lastVersion As String)
        Dim options As New IniOptions()
        Dim iniFile As New IniFile(options)
        iniFile.Sections.Add(New IniSection(iniFile, "Versions", New IniKey(iniFile, "CCL", lastVersion)))
        iniFile.Save("versions.ini")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fix Your Game
        CheckForIllegalCrossThreadCalls = False
        iniConfig()
        Label4.Text = currCCL
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Log("Checking version CCL...", True)
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
        ScrapeWeb("https://github.com/danielcshn/Claw-Launcher/releases/latest", Label3)
        'Button2.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked Then
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
            Dim FinalURL As String = "https://github.com/danielcshn/Claw-Launcher/releases/download/" + Label3.Text + "/setup_CCL-FULL-" + Label3.Text + ".exe"
            Dim client As New WebClient()
            AddHandler client.DownloadProgressChanged, AddressOf ShowDownloadProgress
            AddHandler client.DownloadFileCompleted, AddressOf OnDownloadComplete
            client.DownloadFileAsync(New Uri(FinalURL), "setup_CCL-FULL-" + Label3.Text + ".exe")
            Log("Downloader: " + "setup_CCL-FULL-" + Label3.Text + ".exe", True)
            'Button7.Enabled = True
            Button2.Enabled = False
        Else
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
            Dim FinalURL As String = "https://github.com/danielcshn/Claw-Launcher/releases/download/" + Label3.Text + "/setup_CCL-MIN-" + Label3.Text + ".exe"
            Dim client As New WebClient()
            AddHandler client.DownloadProgressChanged, AddressOf ShowDownloadProgress
            AddHandler client.DownloadFileCompleted, AddressOf OnDownloadComplete
            client.DownloadFileAsync(New Uri(FinalURL), "setup_CCL-MIN-" + Label3.Text + ".exe")
            Log("Downloader: " + "setup_CCL-MIN-" + Label3.Text + ".exe", True)
            'Button7.Enabled = True
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckBox1.Checked Then
            Button1.Enabled = True
            Button3.Enabled = False
            Button2.Enabled = False
            If System.IO.File.Exists(Directory.GetCurrentDirectory() + "\setup_CCL-FULL-" + Label3.Text + ".exe") Then
                'The file exists
                saveIni(currCCL)
                System.Diagnostics.Process.Start("setup_CCL-FULL-" + Label3.Text + ".exe")
                Form1.ActiveForm.Close()
            Else
                'the file doesn't exist
            End If
        Else
            Button1.Enabled = True
            Button3.Enabled = False
            Button2.Enabled = False
            If System.IO.File.Exists(Directory.GetCurrentDirectory() + "\setup_CCL-MIN-" + Label3.Text + ".exe") Then
                'The file exists
                saveIni(currCCL)
                System.Diagnostics.Process.Start("setup_CCL-MIN-" + Label3.Text + ".exe")
                Form1.ActiveForm.Close()
            Else
                'the file doesn't exist
            End If
        End If
    End Sub

    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Label3.TextChanged
        If Label3.Text = Label4.Text Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        Else
            Button2.Enabled = True
            Button3.Enabled = False
            Label4.ForeColor = Color.Red
            Label3.ForeColor = Color.Green
            'Label3.Font = New Font(Me.Label3.Font, FontStyle.Bold)
        End If
    End Sub
End Class

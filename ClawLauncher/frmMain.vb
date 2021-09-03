Option Strict On
Imports System.IO
Imports MadMilkman.Ini

Public Class frmMain
    Dim setLang As String
    Dim setRun As Boolean = False
    Dim reLoad As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        iniConfig()

        Select Case setLang
            Case "EN"
                cbLang.SelectedIndex = 0
            Case "ES"
                cbLang.SelectedIndex = 1
            Case "DE"
                cbLang.SelectedIndex = 2
            Case "PL"
                cbLang.SelectedIndex = 3
            Case "PR"
                cbLang.SelectedIndex = 4
            Case "RUS"
                cbLang.SelectedIndex = 5
            Case Else
                cbLang.SelectedIndex = 0
        End Select

        If reLoad = "TRUE" Then
            smiGameFiles.Checked = True
        Else
            smiGameFiles.Checked = False
        End If
    End Sub

    Private Sub iniConfig()
        If System.IO.File.Exists("config.ini") = False Then
            Dim options As New IniOptions()
            Dim iniFile As New IniFile(options)
            reLoad = "TRUE"
            iniFile.Sections.Add(New IniSection(iniFile, "Game", New IniKey(iniFile, "GameSelect", "EN"), New IniKey(iniFile, "ReloadFiles", reLoad)))
            iniFile.Save("config.ini")
        Else
            Dim ini As New IniFile()
            ini.Load("config.ini")
            setLang = ini.Sections(0).Keys(0).Value
            reLoad = ini.Sections(0).Keys(1).Value
            'setLang = ini.Sections("Game").Keys("GameSelect").Value
        End If
    End Sub

    Private Sub saveIni(lineKey As String, lineValue As String)
        Dim options As New IniOptions()
        Dim iniFile As New IniFile(options)
        iniFile.Sections.Add(New IniSection(iniFile, "Game", New IniKey(iniFile, lineKey, lineValue), New IniKey(iniFile, "ReloadFiles", reLoad)))
        iniFile.Save("config.ini")
    End Sub

    Private Sub Execute7Zip(pathToExe As String, exeName As String, pathToArchive As String, password As String, destinationPath As String)
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = System.IO.Path.Combine(pathToExe, exeName)
        startInfo.Arguments = String.Format("x {0}{1}{0} -p{0}{2}{0} -o{0}{3}{0} -y", ControlChars.Quote, pathToArchive, password, destinationPath)
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        'Process.Start(startInfo)
        Dim ISCMD As Process = Process.Start(startInfo)
        ISCMD.WaitForExit()
    End Sub

    Private Sub runEXE(fileEXE As String)
        Dim info As New ProcessStartInfo()
        info.FileName = Directory.GetCurrentDirectory() & "\GAME\" & fileEXE
        info.WorkingDirectory = Directory.GetCurrentDirectory() & "\GAME"
        info.Arguments = ""
        Process.Start(info)
    End Sub

    Private Sub runWapMap(fileEXE As String)
        Dim info As New ProcessStartInfo()
        info.FileName = Directory.GetCurrentDirectory() & "\tools\WapMap\" & fileEXE
        info.WorkingDirectory = Directory.GetCurrentDirectory() & "\tools\WapMap\"
        info.Arguments = ""
        Process.Start(info)
    End Sub

    Private Sub bgdWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgdWorker1.DoWork
        bgdWorker1.ReportProgress(35)

        If System.IO.File.Exists(Directory.GetCurrentDirectory() & "\lang\" & setLang & ".7z") Then
            setRun = True
            Execute7Zip(Directory.GetCurrentDirectory() & "\tools\7z", "7z.exe",
                        Directory.GetCurrentDirectory() & "\lang\" & setLang & ".7z", "",
                        Directory.GetCurrentDirectory() & "\GAME\")
        Else
            setRun = False
            MessageBox.Show("Could not find language file: " & Directory.GetCurrentDirectory() & "\lang\" & setLang & ".7z", "No entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        bgdWorker1.ReportProgress(55)

        If System.IO.File.Exists(Directory.GetCurrentDirectory() & "\lang\" & setLang & "-VIDEO.7z") Then
            Execute7Zip(Directory.GetCurrentDirectory() & "\tools\7z", "7z.exe",
                        Directory.GetCurrentDirectory() & "\lang\" & setLang & "-VIDEO.7z", "",
                        Directory.GetCurrentDirectory() & "\GAME\")
        End If

        bgdWorker1.ReportProgress(75)

        If setRun = True Then
            Try
                runEXE("CLAW.EXE")
            Catch ex As Exception
                MsgBox("The operation was not performed due to: " & ex.Message)
            End Try
        End If

        bgdWorker1.ReportProgress(100)
    End Sub

    Private Sub bgdWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgdWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub bgdWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgdWorker1.RunWorkerCompleted
        btnLaunch.Enabled = True
    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        ProgressBar1.Value = 0

        If smiSaveGame.Checked Then
            If System.IO.File.Exists(Directory.GetCurrentDirectory() & "\tools\SaveGame\USR.7z") Then
                setRun = True
                Execute7Zip(Directory.GetCurrentDirectory() & "\tools\7z", "7z.exe",
                        Directory.GetCurrentDirectory() & "\tools\SaveGame\USR.7z", "",
                        Directory.GetCurrentDirectory() & "\GAME\")
            Else
                setRun = False
                MessageBox.Show("Could not find savegame file: " & Directory.GetCurrentDirectory() & "\tools\SaveGame\USR.7z", "No entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        If smiGameFiles.Checked Then
            btnLaunch.Enabled = False
            bgdWorker1.RunWorkerAsync()
        Else
            ProgressBar1.Value = 100
            Try
                runEXE("CLAW.EXE")
            Catch ex As Exception
                MsgBox("The operation was not performed due to: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnFolder_Click(sender As Object, e As EventArgs) Handles btnFolder.Click
        Process.Start(Directory.GetCurrentDirectory())
    End Sub

    Private Sub btnVoodoo_Click(sender As Object, e As EventArgs) Handles btnVoodoo.Click
        Try
            runEXE("dgVoodooCpl.exe")
        Catch ex As Exception
            MsgBox("The operation was not performed due to: " & ex.Message)
        End Try
    End Sub

    Private Sub cbLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLang.SelectedIndexChanged
        Select Case cbLang.SelectedIndex
            Case 0
                setLang = "EN"
                saveIni("GameSelect", "EN")
            Case 1
                setLang = "ES"
                saveIni("GameSelect", "ES")
            Case 2
                setLang = "DE"
                saveIni("GameSelect", "DE")
            Case 3
                setLang = "PL"
                saveIni("GameSelect", "PL")
            Case 4
                setLang = "PR"
                saveIni("GameSelect", "PR")
            Case 5
                setLang = "RUS"
                saveIni("GameSelect", "RUS")
            Case Else
                setLang = "EN"
                saveIni("GameSelect", "EN")
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(Directory.GetCurrentDirectory() & "\GAME\Custom\")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            runWapMap("WapMap.exe")
        Catch ex As Exception
            MsgBox("The operation was not performed due to: " & ex.Message)
        End Try
    End Sub

    Private Sub ReportBugsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportBugsToolStripMenuItem.Click
        Process.Start("https://github.com/danielcshn/Claw-Launcher/issues")
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Try
            Process.Start(Directory.GetCurrentDirectory() & "\tools\Updater\CCLUpdater.exe")
            Application.Exit()
        Catch ex As Exception
            MsgBox("The operation was not performed due to: " & ex.Message)
        End Try
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        Process.Start("https://github.com/danielcshn/Claw-Launcher/")
    End Sub

    Private Sub smiGameFiles_CheckedChanged(sender As Object, e As EventArgs) Handles smiGameFiles.CheckedChanged
        If smiGameFiles.Checked Then
            reLoad = "TRUE"
            saveIni("GameSelect", setLang)
        Else
            reLoad = "FALSE"
            saveIni("GameSelect", setLang)
        End If
    End Sub
End Class
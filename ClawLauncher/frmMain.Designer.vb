<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.bgdWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.btnFolder = New System.Windows.Forms.Button()
        Me.pbClaw = New System.Windows.Forms.PictureBox()
        Me.btnVoodoo = New System.Windows.Forms.Button()
        Me.cbLang = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiSaveGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiGameFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBugsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbClaw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgdWorker1
        '
        Me.bgdWorker1.WorkerReportsProgress = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Black
        Me.ProgressBar1.Location = New System.Drawing.Point(-4, 420)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(772, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 0
        '
        'btnLaunch
        '
        Me.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaunch.Location = New System.Drawing.Point(507, 361)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(246, 46)
        Me.btnLaunch.TabIndex = 1
        Me.btnLaunch.Text = "Launch"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'btnFolder
        '
        Me.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFolder.Location = New System.Drawing.Point(633, 303)
        Me.btnFolder.Name = "btnFolder"
        Me.btnFolder.Size = New System.Drawing.Size(120, 23)
        Me.btnFolder.TabIndex = 2
        Me.btnFolder.Text = "Folder"
        Me.btnFolder.UseVisualStyleBackColor = True
        '
        'pbClaw
        '
        Me.pbClaw.Image = CType(resources.GetObject("pbClaw.Image"), System.Drawing.Image)
        Me.pbClaw.Location = New System.Drawing.Point(-4, -8)
        Me.pbClaw.Name = "pbClaw"
        Me.pbClaw.Size = New System.Drawing.Size(772, 438)
        Me.pbClaw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClaw.TabIndex = 3
        Me.pbClaw.TabStop = False
        '
        'btnVoodoo
        '
        Me.btnVoodoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoodoo.Location = New System.Drawing.Point(507, 303)
        Me.btnVoodoo.Name = "btnVoodoo"
        Me.btnVoodoo.Size = New System.Drawing.Size(120, 23)
        Me.btnVoodoo.TabIndex = 5
        Me.btnVoodoo.Text = "dgVoodooCpl"
        Me.btnVoodoo.UseVisualStyleBackColor = True
        '
        'cbLang
        '
        Me.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLang.FormattingEnabled = True
        Me.cbLang.Items.AddRange(New Object() {"English - Ingles", "Spanish - Español", "German - Deutsch", "Polish - Polskie", "Portuguese - Português", "Russian - русский (Капитан Коготь)"})
        Me.cbLang.Location = New System.Drawing.Point(507, 276)
        Me.cbLang.Name = "cbLang"
        Me.cbLang.Size = New System.Drawing.Size(246, 21)
        Me.cbLang.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(507, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "WapMap"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(633, 332)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Folder Custom"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(767, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiSaveGame, Me.smiGameFiles})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'smiSaveGame
        '
        Me.smiSaveGame.CheckOnClick = True
        Me.smiSaveGame.Name = "smiSaveGame"
        Me.smiSaveGame.Size = New System.Drawing.Size(180, 22)
        Me.smiSaveGame.Text = "Load Save Game"
        '
        'smiGameFiles
        '
        Me.smiGameFiles.CheckOnClick = True
        Me.smiGameFiles.Name = "smiGameFiles"
        Me.smiGameFiles.Size = New System.Drawing.Size(180, 22)
        Me.smiGameFiles.Text = "Re-Load Game Files"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportBugsToolStripMenuItem, Me.ChangelogToolStripMenuItem, Me.ToolStripMenuItem2, Me.CheckForUpdatesToolStripMenuItem, Me.ToolStripMenuItem1, Me.AboutMeToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ReportBugsToolStripMenuItem
        '
        Me.ReportBugsToolStripMenuItem.Name = "ReportBugsToolStripMenuItem"
        Me.ReportBugsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ReportBugsToolStripMenuItem.Text = "Report Bugs"
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(168, 6)
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 6)
        '
        'AboutMeToolStripMenuItem
        '
        Me.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem"
        Me.AboutMeToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutMeToolStripMenuItem.Text = "About me..."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 423)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cbLang)
        Me.Controls.Add(Me.btnVoodoo)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnFolder)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.pbClaw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captain Claw Launcher"
        CType(Me.pbClaw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bgdWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnLaunch As Button
    Friend WithEvents btnFolder As Button
    Friend WithEvents pbClaw As PictureBox
    Friend WithEvents btnVoodoo As Button
    Friend WithEvents cbLang As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents smiSaveGame As ToolStripMenuItem
    Friend WithEvents smiGameFiles As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents AboutMeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportBugsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
End Class

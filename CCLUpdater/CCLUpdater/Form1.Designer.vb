<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuCustomLabel5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lvLog = New System.Windows.Forms.ListView()
        Me.chTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEvent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BunifuCustomLabel4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BunifuCustomLabel3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.CheckBox1)
        Me.Panel5.Controls.Add(Me.Button3)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel5.Location = New System.Drawing.Point(12, 119)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 207)
        Me.Panel5.TabIndex = 27
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 90)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(167, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Full Version (Including Videos)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(17, 154)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(215, 37)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "INSTALL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(17, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 37)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "DOWNLOAD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(17, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CHECK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Lato", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(14, 17)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(55, 13)
        Me.BunifuCustomLabel5.TabIndex = 0
        Me.BunifuCustomLabel5.Text = "ACTIONS"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lvLog)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel4.Location = New System.Drawing.Point(268, 119)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(288, 207)
        Me.Panel4.TabIndex = 26
        '
        'lvLog
        '
        Me.lvLog.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lvLog.AutoArrange = False
        Me.lvLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chTime, Me.chEvent})
        Me.lvLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvLog.HideSelection = False
        Me.lvLog.Location = New System.Drawing.Point(17, 44)
        Me.lvLog.MultiSelect = False
        Me.lvLog.Name = "lvLog"
        Me.lvLog.Size = New System.Drawing.Size(252, 147)
        Me.lvLog.TabIndex = 2
        Me.lvLog.UseCompatibleStateImageBehavior = False
        Me.lvLog.View = System.Windows.Forms.View.Details
        '
        'chTime
        '
        Me.chTime.Text = "Time"
        Me.chTime.Width = 40
        '
        'chEvent
        '
        Me.chEvent.Text = "Event"
        Me.chEvent.Width = 190
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Lato", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(14, 17)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(36, 13)
        Me.BunifuCustomLabel4.TabIndex = 0
        Me.BunifuCustomLabel4.Text = "LOGS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel2.Location = New System.Drawing.Point(268, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(288, 101)
        Me.Panel2.TabIndex = 25
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(17, 46)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(252, 36)
        Me.ProgressBar1.TabIndex = 0
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Lato", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(14, 17)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(75, 13)
        Me.BunifuCustomLabel3.TabIndex = 0
        Me.BunifuCustomLabel3.Text = "DOWNLOAD"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 101)
        Me.Panel3.TabIndex = 24
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(14, 17)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(54, 13)
        Me.BunifuCustomLabel2.TabIndex = 0
        Me.BunifuCustomLabel2.Text = "VERSION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Current Version"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(168, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(168, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lato", 8.0!)
        Me.Label12.Location = New System.Drawing.Point(14, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Last Version"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 340)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check for updates"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents BunifuCustomLabel5 As Label
    Friend WithEvents Panel4 As Panel
    Protected WithEvents lvLog As ListView
    Friend WithEvents chTime As ColumnHeader
    Friend WithEvents chEvent As ColumnHeader
    Friend WithEvents BunifuCustomLabel4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BunifuCustomLabel3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuCustomLabel2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class

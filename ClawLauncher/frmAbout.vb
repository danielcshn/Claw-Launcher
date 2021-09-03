Imports System.IO

Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() & "\credits.txt")
    End Sub
End Class
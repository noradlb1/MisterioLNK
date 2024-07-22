Namespace MisteryLnk
	Partial Public Class Form1
		''' <summary>
		''' Обязательная переменная конструктора.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Освободить все используемые ресурсы.
		''' </summary>
		''' <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Код, автоматически созданный конструктором форм Windows"

		''' <summary>
		''' Требуемый метод для поддержки конструктора — не изменяйте 
		''' содержимое этого метода с помощью редактора кода.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.LogotypeProgram = New System.Windows.Forms.PictureBox()
			Me.ProgramLabel = New System.Windows.Forms.Label()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.UrlPayload_Box = New System.Windows.Forms.TextBox()
			Me.MethodDrop_Menu = New System.Windows.Forms.ComboBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.BuildBtn = New System.Windows.Forms.Button()
			Me.ObfuscateChk = New System.Windows.Forms.CheckBox()
			Me.IconSelectBtn = New System.Windows.Forms.Button()
			Me.LnkIcon = New System.Windows.Forms.PictureBox()
			Me.CloseBtn = New System.Windows.Forms.Button()
			Me.MinimazeBtn = New System.Windows.Forms.Button()
			Me.label3 = New System.Windows.Forms.Label()
			DirectCast(Me.LogotypeProgram, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			DirectCast(Me.LnkIcon, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' LogotypeProgram
			' 
			Me.LogotypeProgram.Cursor = System.Windows.Forms.Cursors.Hand
			Me.LogotypeProgram.Image = My.Resources._new
			Me.LogotypeProgram.Location = New System.Drawing.Point(8, 29)
			Me.LogotypeProgram.Name = "LogotypeProgram"
			Me.LogotypeProgram.Size = New System.Drawing.Size(86, 78)
			Me.LogotypeProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.LogotypeProgram.TabIndex = 0
			Me.LogotypeProgram.TabStop = False
'			Me.LogotypeProgram.Click += New System.EventHandler(Me.LogotypeProgram_Click)
			' 
			' ProgramLabel
			' 
			Me.ProgramLabel.AutoSize = True
			Me.ProgramLabel.Font = New System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ProgramLabel.ForeColor = System.Drawing.Color.White
			Me.ProgramLabel.Location = New System.Drawing.Point(-3, 1)
			Me.ProgramLabel.Name = "ProgramLabel"
			Me.ProgramLabel.Size = New System.Drawing.Size(217, 28)
			Me.ProgramLabel.TabIndex = 1
			Me.ProgramLabel.Text = "Misterio - Dropper"
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.UrlPayload_Box)
			Me.groupBox1.Controls.Add(Me.MethodDrop_Menu)
			Me.groupBox1.Font = New System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.groupBox1.ForeColor = System.Drawing.Color.White
			Me.groupBox1.Location = New System.Drawing.Point(14, 113)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(354, 102)
			Me.groupBox1.TabIndex = 2
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Dropper Settings"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.White
			Me.label2.Location = New System.Drawing.Point(108, 12)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(116, 21)
			Me.label2.TabIndex = 7
			Me.label2.Text = "URL-Payload"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.White
			Me.label1.Location = New System.Drawing.Point(3, 69)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(188, 21)
			Me.label1.TabIndex = 6
			Me.label1.Text = "Method for Dropping"
			' 
			' UrlPayload_Box
			' 
			Me.UrlPayload_Box.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(22)))), (CInt((CByte(27)))), (CInt((CByte(67)))))
			Me.UrlPayload_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.UrlPayload_Box.ForeColor = System.Drawing.Color.MediumSlateBlue
			Me.UrlPayload_Box.Location = New System.Drawing.Point(4, 37)
			Me.UrlPayload_Box.Name = "UrlPayload_Box"
			Me.UrlPayload_Box.Size = New System.Drawing.Size(342, 20)
			Me.UrlPayload_Box.TabIndex = 1
			Me.UrlPayload_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' MethodDrop_Menu
			' 
			Me.MethodDrop_Menu.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(22)))), (CInt((CByte(27)))), (CInt((CByte(67)))))
			Me.MethodDrop_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.MethodDrop_Menu.ForeColor = System.Drawing.Color.White
			Me.MethodDrop_Menu.FormattingEnabled = True
			Me.MethodDrop_Menu.Items.AddRange(New Object() { "BAT", "CMD", "HTA", "LNK", "VBS"})
			Me.MethodDrop_Menu.Location = New System.Drawing.Point(192, 71)
			Me.MethodDrop_Menu.Name = "MethodDrop_Menu"
			Me.MethodDrop_Menu.Size = New System.Drawing.Size(158, 21)
			Me.MethodDrop_Menu.TabIndex = 0
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.BuildBtn)
			Me.groupBox2.Controls.Add(Me.ObfuscateChk)
			Me.groupBox2.Controls.Add(Me.IconSelectBtn)
			Me.groupBox2.Controls.Add(Me.LnkIcon)
			Me.groupBox2.Font = New System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.groupBox2.ForeColor = System.Drawing.Color.White
			Me.groupBox2.Location = New System.Drawing.Point(14, 221)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(354, 154)
			Me.groupBox2.TabIndex = 3
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Output Settings"
			' 
			' BuildBtn
			' 
			Me.BuildBtn.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(22)))), (CInt((CByte(27)))), (CInt((CByte(67)))))
			Me.BuildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.BuildBtn.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.BuildBtn.ForeColor = System.Drawing.Color.White
			Me.BuildBtn.Location = New System.Drawing.Point(6, 19)
			Me.BuildBtn.Name = "BuildBtn"
			Me.BuildBtn.Size = New System.Drawing.Size(218, 102)
			Me.BuildBtn.TabIndex = 8
			Me.BuildBtn.Text = "Build Dropper"
			Me.BuildBtn.UseVisualStyleBackColor = False
'			Me.BuildBtn.Click += New System.EventHandler(Me.BuildBtn_Click)
			' 
			' ObfuscateChk
			' 
			Me.ObfuscateChk.AutoSize = True
			Me.ObfuscateChk.Location = New System.Drawing.Point(7, 127)
			Me.ObfuscateChk.Name = "ObfuscateChk"
			Me.ObfuscateChk.Size = New System.Drawing.Size(224, 17)
			Me.ObfuscateChk.TabIndex = 7
			Me.ObfuscateChk.Text = "Obfuscate(Available: bat,cmd,vbs)"
			Me.ObfuscateChk.UseVisualStyleBackColor = True
			' 
			' IconSelectBtn
			' 
			Me.IconSelectBtn.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(22)))), (CInt((CByte(27)))), (CInt((CByte(67)))))
			Me.IconSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.IconSelectBtn.Font = New System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.IconSelectBtn.ForeColor = System.Drawing.Color.White
			Me.IconSelectBtn.Location = New System.Drawing.Point(237, 113)
			Me.IconSelectBtn.Name = "IconSelectBtn"
			Me.IconSelectBtn.Size = New System.Drawing.Size(110, 31)
			Me.IconSelectBtn.TabIndex = 6
			Me.IconSelectBtn.Text = "SELECT ICON"
			Me.IconSelectBtn.UseVisualStyleBackColor = False
'			Me.IconSelectBtn.Click += New System.EventHandler(Me.IconSelectBtn_Click)
			' 
			' LnkIcon
			' 
			Me.LnkIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.LnkIcon.Location = New System.Drawing.Point(237, 19)
			Me.LnkIcon.Name = "LnkIcon"
			Me.LnkIcon.Size = New System.Drawing.Size(111, 88)
			Me.LnkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.LnkIcon.TabIndex = 0
			Me.LnkIcon.TabStop = False
			' 
			' CloseBtn
			' 
			Me.CloseBtn.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(22)))), (CInt((CByte(27)))), (CInt((CByte(67)))))
			Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.CloseBtn.Font = New System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.CloseBtn.ForeColor = System.Drawing.Color.White
			Me.CloseBtn.Location = New System.Drawing.Point(341, 2)
			Me.CloseBtn.Name = "CloseBtn"
			Me.CloseBtn.Size = New System.Drawing.Size(37, 23)
			Me.CloseBtn.TabIndex = 4
			Me.CloseBtn.Text = "X"
			Me.CloseBtn.UseVisualStyleBackColor = False
'			Me.CloseBtn.Click += New System.EventHandler(Me.CloseBtn_Click)
			' 
			' MinimazeBtn
			' 
			Me.MinimazeBtn.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(22)))), (CInt((CByte(27)))), (CInt((CByte(67)))))
			Me.MinimazeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.MinimazeBtn.Font = New System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.MinimazeBtn.ForeColor = System.Drawing.Color.White
			Me.MinimazeBtn.Location = New System.Drawing.Point(298, 2)
			Me.MinimazeBtn.Name = "MinimazeBtn"
			Me.MinimazeBtn.Size = New System.Drawing.Size(37, 23)
			Me.MinimazeBtn.TabIndex = 5
			Me.MinimazeBtn.Text = "-"
			Me.MinimazeBtn.UseVisualStyleBackColor = False
'			Me.MinimazeBtn.Click += New System.EventHandler(Me.MinimazeBtn_Click)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.ForeColor = System.Drawing.Color.Honeydew
			Me.label3.Location = New System.Drawing.Point(96, 37)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(188, 68)
			Me.label3.TabIndex = 6
			Me.label3.Text = "Credists:" & ControlChars.CrLf & "Author: K3rnel-Dev" & ControlChars.CrLf & "Github: https://k3rnel-dev" & ControlChars.CrLf & "Telegram: @k666_dev"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(22)))), (CInt((CByte(27)))), (CInt((CByte(67)))))
			Me.ClientSize = New System.Drawing.Size(380, 388)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.MinimazeBtn)
			Me.Controls.Add(Me.CloseBtn)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.ProgramLabel)
			Me.Controls.Add(Me.LogotypeProgram)
			Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Misterio - [ MAIN ]"
'			Me.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.Form1_MouseDown)
			DirectCast(Me.LogotypeProgram, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			DirectCast(Me.LnkIcon, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents LogotypeProgram As System.Windows.Forms.PictureBox
		Private ProgramLabel As System.Windows.Forms.Label
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents CloseBtn As System.Windows.Forms.Button
		Private WithEvents MinimazeBtn As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private UrlPayload_Box As System.Windows.Forms.TextBox
		Private MethodDrop_Menu As System.Windows.Forms.ComboBox
		Private ObfuscateChk As System.Windows.Forms.CheckBox
		Private WithEvents IconSelectBtn As System.Windows.Forms.Button
		Private LnkIcon As System.Windows.Forms.PictureBox
		Private WithEvents BuildBtn As System.Windows.Forms.Button
		Private label3 As System.Windows.Forms.Label
	End Class
End Namespace


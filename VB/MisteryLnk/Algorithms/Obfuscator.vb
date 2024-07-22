Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Namespace MisteryLnk.Algorithms
	Friend Class Obfuscator
#Region "BatObfuscator"
		Public Shared Function BatObfuscator(ByVal batchCode As String) As String
			Try
				Dim obfuscatedCode As StringBuilder = New StringBuilder()
				Dim lines As String() = batchCode.Split({Environment.NewLine}, StringSplitOptions.None)
				obfuscatedCode.AppendLine("::obfuscated by MisterioLNK")

				For Each line As String In lines
					Dim obfuscatedLine As StringBuilder = New StringBuilder()
					Dim inPercent As Boolean = False

					For Each ch As Char In line

						If Not inPercent Then

							If ch = "%"c Then
								obfuscatedLine.Append(ch)
								inPercent = True
							Else
								Dim randomLength As Integer = New Random().[Next](1, 11)
								Dim randomString As String = randomString(randomLength)
								obfuscatedLine.Append($"{ch}%{randomString}%")
							End If
						Else

							If ch = "%"c Then
								obfuscatedLine.Append(ch)
								inPercent = False
							Else
								obfuscatedLine.Append(ch)
							End If
						End If
					Next

					obfuscatedCode.AppendLine(obfuscatedLine.ToString())
				Next

				Return obfuscatedCode.ToString()
			Catch ex As Exception
				MessageBox.Show("~ Internal Error ~", $"Internal Building Error: {ex}")
				Return Nothing
			End Try
		End Function

#End Region
#Region "VBSObfuscator"
		Public Shared Function VBSObfuscator(vbsCode As String) As String
			Dim obfuscatedCode As StringBuilder = New StringBuilder()
			Dim random As Random = New Random()

			For Each ch In vbsCode
				obfuscatedCode.Append($"Chr({Microsoft.VisualBasic.AscW(ch)})&")
			Next

			' Убираем последний амперсанд '&'
			If obfuscatedCode.Length > 0 Then
				obfuscatedCode.Length -= 1
			End If

			Return $"Execute({obfuscatedCode.ToString()})"
		End Function
#End Region
		'                public static string HTAObfuscator(string htaCode)
		'                {
		'                    StringBuilder obfuscatedCode = new StringBuilder();
		'
		'                    foreach (char ch in htaCode)
		'                    {
		'                        string charCode;
		'                        switch (ch)
		'                        {
		'                            case '"':
		'                                charCode = "\\\"";
		'                                break;
		'                            case '\\':
		'                                charCode = "\\\\";
		'                                break;
		'                            default:
		'                                charCode = $"String.fromCharCode({(int)ch})";
		'                                break;
		'                        }
		'
		'                        obfuscatedCode.Append(charCode);
		'                    }
		'                    string obfuscatedScript = $"<script>eval(\"{obfuscatedCode.ToString()}\");</script>";
		'                    return obfuscatedScript;
		'                }
#Region "HelperFunctions"
		Private Shared Function RandomString(ByVal length As Integer) As String
			Const chars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789卐☀☁☂☃☼☽★☆☾℃℉☀ -‘๑’-☁ϟ☂︸☃⁂☼☽✩✪✫✬✭✮✯✰牡マキグナルファ系路克瑞大阪市立学鎰命科ャマ能力ϒ人は妻スティ要望通り玉宏¥サ丹谷Ѫ灯影伝鶐ԱաԲբԳգԴդԵեԶզԷէԸըԹթԺժԻиԼլԽխԾծԿկՀհՁձՂղՃճՄмՅյՆնՇշՈոՉчПпՋջՌрՍսՎвՏтՐрՑцՒуՓпՔкՕоՖфლ(´ڡ`ლ)ლ(ಠ益ಠლ)ლ(╹◡╹ლ)ლ(◉◞౪◟◉‵ლヾ(⌐■_■)ノ♪(◕‿◕)| (• ◡•)|(❍ᴥ❍ʋ)⒑⒒⒓⒔⒕⒖⒗⒘⒙⒚⒛"
			Dim charArray() As Char = chars.ToCharArray()
			Dim rng As New Random()
			Dim n As Integer = charArray.Length
			Do While n > 1
				n -= 1
				Dim k As Integer = rng.Next(n + 1)
				Dim value As Char = charArray(k)
				charArray(k) = charArray(n)
				charArray(n) = value
			Loop
'INSTANT VB NOTE: The local variable randomString was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
			Dim randomString_Renamed As New StringBuilder()
			For i As Integer = 0 To length - 1
				randomString_Renamed.Append(charArray(rng.Next(charArray.Length)))
			Next i
			Return randomString_Renamed.ToString()
		End Function
		#End Region
	End Class
End Namespace

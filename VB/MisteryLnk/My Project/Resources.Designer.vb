﻿Imports System

'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код создан программой.
'     Исполняемая версия:4.0.30319.42000
'
'     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
'     повторной генерации кода.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My.Resources


	''' <summary>
	'''   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
	''' </summary>
	' Этот класс создан автоматически классом StronglyTypedResourceBuilder
	' с помощью такого средства, как ResGen или Visual Studio.
	' Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
	' с параметром /str или перестройте свой проект VS.
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
	Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
	Friend Module Resources

		Private resourceMan As Global.System.Resources.ResourceManager

		Private resourceCulture As Global.System.Globalization.CultureInfo

'		internal Resources()
'		{
'		}

		''' <summary>
		'''   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If Object.ReferenceEquals(resourceMan, Nothing) Then
					Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property

		''' <summary>
		'''   Перезаписывает свойство CurrentUICulture текущего потока для всех
		'''   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Property Culture() As Global.System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set(ByVal value As System.Globalization.CultureInfo)
				resourceCulture = value
			End Set
		End Property

		''' <summary>
		'''   Поиск локализованного ресурса типа System.Drawing.Bitmap.
		''' </summary>
		Friend ReadOnly Property _new() As System.Drawing.Bitmap
			Get
				Dim obj As Object = ResourceManager.GetObject("new", resourceCulture)
				Return (DirectCast(obj, System.Drawing.Bitmap))
			End Get
		End Property
	End Module
End Namespace

﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Collections.ObjectModel

Namespace Implement_the_New_Item_Row_Feature
	Partial Public Class MainPage
		Inherits UserControl
		Private list As ObservableCollection(Of TestData)
		Public Sub New()
			InitializeComponent()
'			#Region "Fill the GridControl with data"
			list = New ObservableCollection(Of TestData)()
			For i As Integer = 0 To 4
				list.Add(New TestData() With {.Text1 = Guid.NewGuid().ToString(), .Text2 = "text2 " & i, .Text3 = "text3 " & i})
			Next i
			grid.ItemsSource = list
'			#End Region
		End Sub
	End Class
	#Region "Test data"
	Public Class TestData
		Private privateText1 As String
		Public Property Text1() As String
			Get
				Return privateText1
			End Get
			Set(ByVal value As String)
				privateText1 = value
			End Set
		End Property
		Private privateText2 As String
		Public Property Text2() As String
			Get
				Return privateText2
			End Get
			Set(ByVal value As String)
				privateText2 = value
			End Set
		End Property
		Private privateText3 As String
		Public Property Text3() As String
			Get
				Return privateText3
			End Get
			Set(ByVal value As String)
				privateText3 = value
			End Set
		End Property
	End Class
	#End Region
End Namespace

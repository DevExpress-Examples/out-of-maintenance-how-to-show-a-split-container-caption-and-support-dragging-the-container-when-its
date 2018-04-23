Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraBars.Docking
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.XtraBars.Docking.Helpers
Imports System.Drawing

Namespace DXSample
	Public Class CustomDockManager
		Inherits DockManager
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal form As ContainerControl)
			MyBase.New(form)
		End Sub
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)
		End Sub
		Protected Overrides Function CreateDockPanel(ByVal dock As DockingStyle, ByVal createControlContainer As Boolean) As DockPanel
			Return New CustomDockPanel(createControlContainer, dock, Me)
		End Function

		Private showSplitContainerCaptionAlways_Renamed As Boolean = False

		Public Property ShowSplitContainerCaptionAlways() As Boolean
			Get
				Return showSplitContainerCaptionAlways_Renamed
			End Get
			Set(ByVal value As Boolean)
				If showSplitContainerCaptionAlways_Renamed <> value Then
					showSplitContainerCaptionAlways_Renamed = value
				End If
			End Set
		End Property
	End Class

	Public Class CustomDockPanel
		Inherits DockPanel
		Public Sub New()
			Me.New(False, DockingStyle.Float, Nothing)
		End Sub
		Public Sub New(ByVal createControlContainer As Boolean, ByVal dock As DockingStyle, ByVal dockManager As DockManager)
			MyBase.New(createControlContainer, dock, dockManager)
			DockLayout = New CustomDockLayout(dock, Me)
		End Sub

	End Class

	Public Class CustomDockLayout
		Inherits DockLayout
		Public Sub New(ByVal dock As DockingStyle, ByVal panel As DockPanel)
			MyBase.New(dock, panel)
		End Sub
		Public Sub New(ByVal dock As DockingStyle, ByVal size As Size, ByVal panel As DockPanel)
			MyBase.New(dock, size, panel)
		End Sub
		Protected Overrides ReadOnly Property HasCaption() As Boolean
			Get
				If DockManager.ShowSplitContainerCaptionAlways AndAlso HasChildren Then
					Return True
				End If
				Return MyBase.HasCaption
			End Get
		End Property

		Public Shadows ReadOnly Property DockManager() As CustomDockManager
			Get
				Return TryCast(MyBase.DockManager, CustomDockManager)
			End Get
		End Property

	End Class
End Namespace

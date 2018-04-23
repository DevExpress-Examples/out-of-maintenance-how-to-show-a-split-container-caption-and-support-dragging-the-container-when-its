Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.customDockManager1 = New DXSample.CustomDockManager(Me.components)
			Me.panelContainer1 = New DXSample.CustomDockPanel()
			Me.customDockPanel1 = New DXSample.CustomDockPanel()
			Me.customDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.customDockPanel2 = New DXSample.CustomDockPanel()
			Me.customDockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.customDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelContainer1.SuspendLayout()
			Me.customDockPanel1.SuspendLayout()
			Me.customDockPanel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' customDockManager1
			' 
			Me.customDockManager1.Form = Me
			Me.customDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
			Me.customDockManager1.ShowSplitContainerCaptionAlways = True
			Me.customDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' panelContainer1
			' 
			Me.panelContainer1.Controls.Add(Me.customDockPanel1)
			Me.panelContainer1.Controls.Add(Me.customDockPanel2)
			Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
			Me.panelContainer1.FloatLocation = New System.Drawing.Point(128, 268)
			Me.panelContainer1.FloatSize = New System.Drawing.Size(369, 302)
			Me.panelContainer1.FloatVertical = True
			Me.panelContainer1.ID = New System.Guid("95525a26-5a04-4cf1-aa44-1b00391bda1e")
			Me.panelContainer1.Location = New System.Drawing.Point(0, 0)
			Me.panelContainer1.Name = "panelContainer1"
			Me.panelContainer1.Size = New System.Drawing.Size(369, 302)
			Me.panelContainer1.Text = "SplitContainerCaption"
			' 
			' customDockPanel1
			' 
			Me.customDockPanel1.Controls.Add(Me.customDockPanel1_Container)
			Me.customDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.customDockPanel1.FloatSize = New System.Drawing.Size(194, 278)
			Me.customDockPanel1.FloatVertical = True
			Me.customDockPanel1.ID = New System.Guid("769afdb8-d63d-472f-b9f4-5af902ee7681")
			Me.customDockPanel1.Location = New System.Drawing.Point(1, 23)
			Me.customDockPanel1.Name = "customDockPanel1"
			Me.customDockPanel1.Size = New System.Drawing.Size(194, 278)
			Me.customDockPanel1.Text = "customDockPanel1"
			' 
			' customDockPanel1_Container
			' 
			Me.customDockPanel1_Container.Location = New System.Drawing.Point(2, 24)
			Me.customDockPanel1_Container.Name = "customDockPanel1_Container"
			Me.customDockPanel1_Container.Size = New System.Drawing.Size(190, 252)
			Me.customDockPanel1_Container.TabIndex = 0
			' 
			' customDockPanel2
			' 
			Me.customDockPanel2.Controls.Add(Me.customDockPanel2_Container)
			Me.customDockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.customDockPanel2.FloatSize = New System.Drawing.Size(173, 278)
			Me.customDockPanel2.ID = New System.Guid("fc2aba31-ebdc-4daf-803d-3276ead3523b")
			Me.customDockPanel2.Location = New System.Drawing.Point(195, 23)
			Me.customDockPanel2.Name = "customDockPanel2"
			Me.customDockPanel2.Size = New System.Drawing.Size(173, 278)
			Me.customDockPanel2.Text = "customDockPanel2"
			' 
			' customDockPanel2_Container
			' 
			Me.customDockPanel2_Container.Location = New System.Drawing.Point(2, 24)
			Me.customDockPanel2_Container.Name = "customDockPanel2_Container"
			Me.customDockPanel2_Container.Size = New System.Drawing.Size(169, 252)
			Me.customDockPanel2_Container.TabIndex = 0
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(480, 475)
			Me.Name = "Form1"
			Me.Text = "ShowSpltContainerCaption"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.customDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelContainer1.ResumeLayout(False)
			Me.customDockPanel1.ResumeLayout(False)
			Me.customDockPanel2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customDockManager1 As CustomDockManager
		Private panelContainer1 As CustomDockPanel
		Private customDockPanel1 As CustomDockPanel
		Private customDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private customDockPanel2 As CustomDockPanel
		Private customDockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

	End Class
End Namespace


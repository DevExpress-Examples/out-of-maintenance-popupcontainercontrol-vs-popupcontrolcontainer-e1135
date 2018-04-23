Imports Microsoft.VisualBasic
Imports System
Namespace PopupEditVsDropDownButton
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
			Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.dropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
			Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.popupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControl1.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupControlContainer1.SuspendLayout()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' popupContainerControl1
			' 
			Me.popupContainerControl1.Controls.Add(Me.checkEdit1)
			Me.popupContainerControl1.Location = New System.Drawing.Point(12, 53)
			Me.popupContainerControl1.Name = "popupContainerControl1"
			Me.popupContainerControl1.Size = New System.Drawing.Size(189, 100)
			Me.popupContainerControl1.TabIndex = 0
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(15, 19)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "checkEdit1"
			Me.checkEdit1.Size = New System.Drawing.Size(75, 19)
			Me.checkEdit1.TabIndex = 0
			' 
			' dropDownButton1
			' 
			Me.dropDownButton1.DropDownControl = Me.popupControlContainer1
			Me.dropDownButton1.Location = New System.Drawing.Point(230, 12)
			Me.dropDownButton1.Name = "dropDownButton1"
			Me.dropDownButton1.Size = New System.Drawing.Size(175, 23)
			Me.dropDownButton1.TabIndex = 1
			Me.dropDownButton1.Text = "dropDownButton1"
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.popupControlContainer1.Controls.Add(Me.checkEdit2)
			Me.popupControlContainer1.Location = New System.Drawing.Point(230, 53)
			Me.popupControlContainer1.Manager = Me.barManager1
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Size = New System.Drawing.Size(175, 100)
			Me.popupControlContainer1.TabIndex = 2
			Me.popupControlContainer1.Visible = False
			' 
			' checkEdit2
			' 
			Me.checkEdit2.Location = New System.Drawing.Point(19, 19)
			Me.checkEdit2.Name = "checkEdit2"
			Me.checkEdit2.Properties.Caption = "checkEdit2"
			Me.checkEdit2.Size = New System.Drawing.Size(75, 19)
			Me.checkEdit2.TabIndex = 0
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.MaxItemId = 0
			' 
			' popupContainerEdit1
			' 
			Me.popupContainerEdit1.Location = New System.Drawing.Point(12, 12)
			Me.popupContainerEdit1.Name = "popupContainerEdit1"
			Me.popupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.popupContainerEdit1.Properties.PopupControl = Me.popupContainerControl1
			Me.popupContainerEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
			Me.popupContainerEdit1.Size = New System.Drawing.Size(189, 20)
			Me.popupContainerEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(419, 188)
			Me.Controls.Add(Me.popupControlContainer1)
			Me.Controls.Add(Me.popupContainerEdit1)
			Me.Controls.Add(Me.dropDownButton1)
			Me.Controls.Add(Me.popupContainerControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControl1.ResumeLayout(False)
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupControlContainer1.ResumeLayout(False)
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
		Private dropDownButton1 As DevExpress.XtraEditors.DropDownButton
		Private popupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
		Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private checkEdit2 As DevExpress.XtraEditors.CheckEdit
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
	End Class
End Namespace


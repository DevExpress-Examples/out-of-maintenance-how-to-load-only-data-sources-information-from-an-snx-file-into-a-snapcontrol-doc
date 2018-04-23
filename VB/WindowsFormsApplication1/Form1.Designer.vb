Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
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
			Me.snapControl1 = New DevExpress.Snap.SnapControl()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
			Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
			Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
			Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
			Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
			Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
			Me.commandBarItem1 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
			Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
			Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
			Me.commandBarItem2 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
			Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
			Me.dataRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataRibbonPageGroup()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.snapDockManager1 = New DevExpress.Snap.Extensions.SnapDockManager(Me.components)
			Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.fieldListDockPanel1 = New DevExpress.Snap.Extensions.UI.FieldListDockPanel()
			Me.fieldListDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.reportExplorerDockPanel1 = New DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel()
			Me.reportExplorerDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.snapDocumentManager1 = New DevExpress.Snap.Extensions.SnapDocumentManager(Me.components)
			Me.noDocumentsView1 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
			Me.snapBarController1 = New DevExpress.Snap.Extensions.SnapBarController()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelContainer1.SuspendLayout()
			Me.fieldListDockPanel1.SuspendLayout()
			Me.reportExplorerDockPanel1.SuspendLayout()
			CType(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.snapBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' snapControl1
			' 
			Me.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.snapControl1.EnableToolTips = True
			Me.snapControl1.Location = New System.Drawing.Point(0, 144)
			Me.snapControl1.MenuManager = Me.ribbonControl1
			Me.snapControl1.Name = "snapControl1"
			Me.snapControl1.Options.Fields.EnableEmptyFieldDataAlias = True
			Me.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = Nothing
			Me.snapControl1.Size = New System.Drawing.Size(573, 427)
			Me.snapControl1.TabIndex = 0
			Me.snapControl1.Text = "snapControl1"
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.undoItem1, Me.redoItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.commandBarItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.commandBarItem2, Me.barButtonItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 13
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1})
			Me.ribbonControl1.Size = New System.Drawing.Size(773, 144)
			' 
			' undoItem1
			' 
			Me.undoItem1.Id = 1
			Me.undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			Me.redoItem1.Id = 2
			Me.redoItem1.Name = "redoItem1"
			' 
			' fileNewItem1
			' 
			Me.fileNewItem1.Id = 3
			Me.fileNewItem1.Name = "fileNewItem1"
			' 
			' fileOpenItem1
			' 
			Me.fileOpenItem1.Id = 4
			Me.fileOpenItem1.Name = "fileOpenItem1"
			' 
			' fileSaveItem1
			' 
			Me.fileSaveItem1.Id = 5
			Me.fileSaveItem1.Name = "fileSaveItem1"
			' 
			' fileSaveAsItem1
			' 
			Me.fileSaveAsItem1.Id = 6
			Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
			' 
			' commandBarItem1
			' 
			Me.commandBarItem1.Id = 7
			Me.commandBarItem1.Name = "commandBarItem1"
			Me.commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument
			' 
			' quickPrintItem1
			' 
			Me.quickPrintItem1.Id = 8
			Me.quickPrintItem1.Name = "quickPrintItem1"
			' 
			' printItem1
			' 
			Me.printItem1.Id = 9
			Me.printItem1.Name = "printItem1"
			' 
			' printPreviewItem1
			' 
			Me.printPreviewItem1.Id = 10
			Me.printPreviewItem1.Name = "printPreviewItem1"
			' 
			' commandBarItem2
			' 
			Me.commandBarItem2.Id = 11
			Me.commandBarItem2.Name = "commandBarItem2"
			Me.commandBarItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.NewDataSource
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Load data sources"
			Me.barButtonItem1.Id = 12
			Me.barButtonItem1.Name = "barButtonItem1"
'			Me.barButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem1_ItemClick);
			' 
			' fileRibbonPage1
			' 
			Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.dataRibbonPageGroup1, Me.ribbonPageGroup1})
			Me.fileRibbonPage1.Name = "fileRibbonPage1"
			' 
			' commonRibbonPageGroup1
			' 
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
			Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
			' 
			' dataRibbonPageGroup1
			' 
			Me.dataRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem2)
			Me.dataRibbonPageGroup1.Name = "dataRibbonPageGroup1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' snapDockManager1
			' 
			Me.snapDockManager1.Form = Me
			Me.snapDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
			Me.snapDockManager1.SnapControl = Me.snapControl1
			Me.snapDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
			' 
			' panelContainer1
			' 
			Me.panelContainer1.Controls.Add(Me.fieldListDockPanel1)
			Me.panelContainer1.Controls.Add(Me.reportExplorerDockPanel1)
			Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.panelContainer1.ID = New System.Guid("1237462c-3388-4acc-9357-5dafc5df5ab6")
			Me.panelContainer1.Location = New System.Drawing.Point(573, 144)
			Me.panelContainer1.Name = "panelContainer1"
			Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
			Me.panelContainer1.Size = New System.Drawing.Size(200, 427)
			Me.panelContainer1.Text = "panelContainer1"
			' 
			' fieldListDockPanel1
			' 
			Me.fieldListDockPanel1.Controls.Add(Me.fieldListDockPanel1_Container)
			Me.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.fieldListDockPanel1.ID = New System.Guid("60a2ab62-f68f-487e-91a6-a9c608d3c734")
			Me.fieldListDockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.fieldListDockPanel1.Name = "fieldListDockPanel1"
			Me.fieldListDockPanel1.OriginalSize = New System.Drawing.Size(200, 215)
			Me.fieldListDockPanel1.Size = New System.Drawing.Size(200, 214)
			Me.fieldListDockPanel1.SnapControl = Me.snapControl1
			' 
			' fieldListDockPanel1_Container
			' 
			Me.fieldListDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
			Me.fieldListDockPanel1_Container.Size = New System.Drawing.Size(192, 187)
			Me.fieldListDockPanel1_Container.TabIndex = 0
			' 
			' reportExplorerDockPanel1
			' 
			Me.reportExplorerDockPanel1.Controls.Add(Me.reportExplorerDockPanel1_Container)
			Me.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.reportExplorerDockPanel1.ID = New System.Guid("f195b2f5-193c-456c-8883-a3f92fb6d326")
			Me.reportExplorerDockPanel1.Location = New System.Drawing.Point(0, 214)
			Me.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1"
			Me.reportExplorerDockPanel1.OriginalSize = New System.Drawing.Size(200, 214)
			Me.reportExplorerDockPanel1.Size = New System.Drawing.Size(200, 213)
			Me.reportExplorerDockPanel1.SnapControl = Me.snapControl1
			' 
			' reportExplorerDockPanel1_Container
			' 
			Me.reportExplorerDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container"
			Me.reportExplorerDockPanel1_Container.Size = New System.Drawing.Size(192, 186)
			Me.reportExplorerDockPanel1_Container.TabIndex = 0
			' 
			' snapDocumentManager1
			' 
			Me.snapDocumentManager1.ClientControl = Me.snapControl1
			Me.snapDocumentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False
			Me.snapDocumentManager1.View = Me.noDocumentsView1
			Me.snapDocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.noDocumentsView1})
			' 
			' snapBarController1
			' 
			Me.snapBarController1.BarItems.Add(Me.undoItem1)
			Me.snapBarController1.BarItems.Add(Me.redoItem1)
			Me.snapBarController1.BarItems.Add(Me.fileNewItem1)
			Me.snapBarController1.BarItems.Add(Me.fileOpenItem1)
			Me.snapBarController1.BarItems.Add(Me.fileSaveItem1)
			Me.snapBarController1.BarItems.Add(Me.fileSaveAsItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem1)
			Me.snapBarController1.BarItems.Add(Me.quickPrintItem1)
			Me.snapBarController1.BarItems.Add(Me.printItem1)
			Me.snapBarController1.BarItems.Add(Me.printPreviewItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem2)
			Me.snapBarController1.Control = Me.snapControl1
			Me.snapBarController1.RibbonControl = Me.ribbonControl1
			Me.snapBarController1.SnapDockManager = Me.snapDockManager1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(773, 571)
			Me.Controls.Add(Me.snapControl1)
			Me.Controls.Add(Me.panelContainer1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Ribbon = Me.ribbonControl1
			Me.Text = "Form1"
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelContainer1.ResumeLayout(False)
			Me.fieldListDockPanel1.ResumeLayout(False)
			Me.reportExplorerDockPanel1.ResumeLayout(False)
			CType(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.snapBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private snapControl1 As DevExpress.Snap.SnapControl
		Private snapDockManager1 As DevExpress.Snap.Extensions.SnapDockManager
		Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
		Private fieldListDockPanel1 As DevExpress.Snap.Extensions.UI.FieldListDockPanel
		Private fieldListDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private reportExplorerDockPanel1 As DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel
		Private reportExplorerDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private snapDocumentManager1 As DevExpress.Snap.Extensions.SnapDocumentManager
		Private noDocumentsView1 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
		Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
		Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
		Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
		Private commandBarItem1 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
		Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
		Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
		Private commandBarItem2 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
		Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
		Private dataRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataRibbonPageGroup
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private snapBarController1 As DevExpress.Snap.Extensions.SnapBarController
	End Class
End Namespace


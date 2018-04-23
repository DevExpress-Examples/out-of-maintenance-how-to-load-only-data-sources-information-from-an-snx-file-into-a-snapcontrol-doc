Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			Dim snapServer As New DevExpress.Snap.SnapDocumentServer()

			Dim dataSourceTemplatesNames As New List(Of String)()
			dataSourceTemplatesNames.Add("nwindDataSourceTemplate.snx")
			dataSourceTemplatesNames.Add("carsDataBaseTemplate.snx")

			For Each dataSourceTemplate As String In dataSourceTemplatesNames
				Using fs As New System.IO.FileStream(dataSourceTemplate, System.IO.FileMode.Open)
					snapServer.LoadDocument(fs, DevExpress.Snap.Core.API.SnapDocumentFormat.Snap)

					For i As Integer = 0 To snapServer.Document.DataSources.Count - 1
						If snapServer.Document.DataSources(i).DataSource IsNot Nothing Then
							snapControl1.Document.DataSources.Add(snapServer.Document.DataSources(i).DataSourceName, snapServer.Document.DataSources(i).DataSource)
						End If
					Next i
				End Using
			Next dataSourceTemplate
		End Sub
	End Class
End Namespace

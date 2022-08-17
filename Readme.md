<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608726/14.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T226445)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
<!-- default file list end -->
# How to load only Data Sources information from an SNX file into a SnapControl document

> **Note**
>
> As you may already know, the [WinForms Snap control](https://docs.devexpress.com/WindowsForms/11373/controls-and-libraries/snap) and [Snap Report API](https://docs.devexpress.com/OfficeFileAPI/15188/snap-report-api) are now in maintenance support mode. No new features or capabilities are incorporated into these products. We recommend that you use [DevExpress Reporting](https://docs.devexpress.com/XtraReports/2162/reporting) tool to generate, edit, print, and export your business reports/documents.

<p>The main idea of the demonstrated approach is to load a corresponding SNX template into a temporary SnapDocumentServer instance and copy items from the <strong>SnapDocumentServer.Document.DataSources</strong> collection into a current SnapControl document.<br />In this sample, data sources are loaded from two templates: "<strong>nwindDataSourceTemplate.snx</strong>" and "<strong>carsDataBaseTemplate.snx</strong>".<br />In the attachment you can find a video which demonstrates how these templates were created.<br />Please take special note that the use of the <strong>SnapDocumentServer</strong> instance in an application requires adding a reference to the <strong>DevExpress.Docs</strong> assembly. This assembly is shipped only with the <strong>Universal</strong> subscription or with a separate <strong>Document Server </strong>subscription:<br /><a href="https://www.devexpress.com/Subscriptions/">https://www.devexpress.com/Subscriptions/</a></p>

<br/>



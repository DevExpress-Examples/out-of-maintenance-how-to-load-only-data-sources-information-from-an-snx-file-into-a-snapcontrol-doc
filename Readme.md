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


<p>The main idea of the demonstrated approach is to load a corresponding SNX template into a temporary SnapDocumentServer instance and copy items from the <strong>SnapDocumentServer.Document.DataSources</strong> collection into a current SnapControl document.<br />In this sample, data sources are loaded from two templates: "<strong>nwindDataSourceTemplate.snx</strong>" and "<strong>carsDataBaseTemplate.snx</strong>".<br />In the attachment you can find a video which demonstrates how these templates were created.<br />Please take special note that the use of the <strong>SnapDocumentServer</strong> instance in an application requires adding a reference to the <strong>DevExpress.Docs</strong> assembly. This assembly is shipped only with the <strong>Universal</strong> subscription or with a separate <strong>Document Server </strong>subscription:<br /><a href="https://www.devexpress.com/Subscriptions/">https://www.devexpress.com/Subscriptions/</a></p>

<br/>



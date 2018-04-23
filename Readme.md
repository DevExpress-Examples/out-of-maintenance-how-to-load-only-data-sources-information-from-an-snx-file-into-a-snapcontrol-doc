# How to load only Data Sources information from an SNX file into a SnapControl document


<p>The main idea of the demonstrated approach is to load a corresponding SNX template into a temporary SnapDocumentServer instance and copy items from the <strong>SnapDocumentServer.Document.DataSources</strong> collection into a current SnapControl document.<br />In this sample, data sources are loaded from two templates: "<strong>nwindDataSourceTemplate.snx</strong>" and "<strong>carsDataBaseTemplate.snx</strong>".<br />In the attachment you can find a video which demonstrates how these templates were created.<br />Please take special note that the use of the <strong>SnapDocumentServer</strong> instance in an application requires adding a reference to the <strong>DevExpress.Docs</strong> assembly. This assembly is shipped only with the <strong>Universal</strong> subscription or with a separate <strong>Document Server </strong>subscription:<br /><a href="https://www.devexpress.com/Subscriptions/">https://www.devexpress.com/Subscriptions/</a></p>

<br/>



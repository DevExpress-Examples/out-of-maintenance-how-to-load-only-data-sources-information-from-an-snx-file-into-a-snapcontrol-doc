using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace WindowsFormsApplication1 {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DevExpress.Snap.SnapDocumentServer snapServer = new DevExpress.Snap.SnapDocumentServer();

            List<string> dataSourceTemplatesNames = new List<string>();
            dataSourceTemplatesNames.Add("nwindDataSourceTemplate.snx");
            dataSourceTemplatesNames.Add("carsDataBaseTemplate.snx");

            foreach(string dataSourceTemplate in dataSourceTemplatesNames) {
                using(System.IO.FileStream fs = new System.IO.FileStream(dataSourceTemplate, System.IO.FileMode.Open)) {
                    snapServer.LoadDocument(fs, DevExpress.Snap.Core.API.SnapDocumentFormat.Snap);

                    for(int i = 0; i < snapServer.Document.DataSources.Count; i++) {
                        if(snapServer.Document.DataSources[i].DataSource != null) {
                            snapControl1.Document.DataSources.Add(snapServer.Document.DataSources[i].DataSourceName, snapServer.Document.DataSources[i].DataSource);
                        }
                    }
                }                
            }            
        }
    }
}

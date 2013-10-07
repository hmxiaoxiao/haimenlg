using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;
using Haimen.Report;

using DevExpress.XtraReports.UI;

namespace Haimen.GUI
{
    public partial class devAccountPrint : DevExpress.XtraEditors.XtraForm
    {
        private long m_id;
        public devAccountPrint(long id)
        {
            InitializeComponent();
            m_id = id;
        }

        private void devAccountPrint_Load(object sender, EventArgs e)
        {

        }

        private void tsbPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Create a report. 
            rptAccountPrint report = new rptAccountPrint(20);

            // Show the report's preview. 
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
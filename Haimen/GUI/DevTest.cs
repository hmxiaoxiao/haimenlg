using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class DevTest : DevExpress.XtraEditors.XtraForm
    {
        public DevTest()
        {
            InitializeComponent();
            ////this.gvCategories.DataController.AllowIEnumerableDetails = true;
            ////this.CategoryProductBindingSource.DataSource = DataProvider.GetCategories(); 
            //this.gridView1.DataController.AllowIEnumerableDetails = true;
            //(this.gridControl1.MainView as DevExpress.XtraGrid.Views.Base.BaseView).DataController.AllowIEnumerableDetails = true;
            //(this.gridView1 as DevExpress.XtraGrid.Views.Base.BaseView).DataController.AllowIEnumerableDetails = true;

            //this.bindingSource1.DataSource = Company.Query();
        }

        private void DevTest_Load(object sender, EventArgs e)
        {
            DataSet ds = Funds.GetLevel_NoUsed();
            gridControl1.DataSource = ds.Tables[0];
        }
    }
}
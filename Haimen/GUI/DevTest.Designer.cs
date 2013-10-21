namespace Haimen.GUI
{
    partial class DevTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_2_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_2_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_1_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_1_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_3_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_3_name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_2_id,
            this.c_2_name});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.ShowColumnHeaders = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // c_2_id
            // 
            this.c_2_id.Caption = "ID";
            this.c_2_id.FieldName = "id";
            this.c_2_id.Name = "c_2_id";
            // 
            // c_2_name
            // 
            this.c_2_name.Caption = "性质";
            this.c_2_name.FieldName = "name";
            this.c_2_name.Name = "c_2_name";
            this.c_2_name.Visible = true;
            this.c_2_name.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "level1";
            gridLevelNode2.LevelTemplate = this.gridView3;
            gridLevelNode2.RelationName = "level2";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(548, 350);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2,
            this.gridView3});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_1_id,
            this.c_1_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // c_1_id
            // 
            this.c_1_id.Caption = "ID";
            this.c_1_id.FieldName = "id";
            this.c_1_id.Name = "c_1_id";
            // 
            // c_1_name
            // 
            this.c_1_name.Caption = "性质";
            this.c_1_name.FieldName = "name";
            this.c_1_name.Name = "c_1_name";
            this.c_1_name.Visible = true;
            this.c_1_name.VisibleIndex = 0;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_3_id,
            this.c_3_name});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsDetail.AutoZoomDetail = true;
            this.gridView3.OptionsDetail.ShowDetailTabs = false;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.ShowColumnHeaders = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.OptionsView.ShowIndicator = false;
            this.gridView3.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // c_3_id
            // 
            this.c_3_id.Caption = "ID";
            this.c_3_id.FieldName = "id";
            this.c_3_id.Name = "c_3_id";
            // 
            // c_3_name
            // 
            this.c_3_name.Caption = "性质";
            this.c_3_name.FieldName = "name";
            this.c_3_name.Name = "c_3_name";
            this.c_3_name.Visible = true;
            this.c_3_name.VisibleIndex = 0;
            // 
            // DevTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 350);
            this.Controls.Add(this.gridControl1);
            this.Name = "DevTest";
            this.Text = "DevTest";
            this.Load += new System.EventHandler(this.DevTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn c_2_id;
        private DevExpress.XtraGrid.Columns.GridColumn c_2_name;
        private DevExpress.XtraGrid.Columns.GridColumn c_1_id;
        private DevExpress.XtraGrid.Columns.GridColumn c_1_name;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn c_3_id;
        private DevExpress.XtraGrid.Columns.GridColumn c_3_name;
    }
}
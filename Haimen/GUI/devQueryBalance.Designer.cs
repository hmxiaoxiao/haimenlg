namespace Haimen.GUI
{
    partial class devQueryBalance
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbSelectBank = new DevExpress.XtraBars.BarButtonItem();
            this.tsbSelectCompany = new DevExpress.XtraBars.BarButtonItem();
            this.tsbQuery = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lueBank = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_balance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_credit = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tsbQuery,
            this.tsbExit,
            this.tsbSelectBank,
            this.tsbSelectCompany});
            this.barManager1.MaxItemId = 8;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueBank,
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemRadioGroup1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbSelectBank, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbSelectCompany, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbQuery, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tsbSelectBank
            // 
            this.tsbSelectBank.Caption = "银行筛选";
            this.tsbSelectBank.Glyph = global::Haimen.Properties.Resources.Number_of_Pages_hot;
            this.tsbSelectBank.Id = 6;
            this.tsbSelectBank.Name = "tsbSelectBank";
            this.tsbSelectBank.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbSelectBank_ItemClick);
            // 
            // tsbSelectCompany
            // 
            this.tsbSelectCompany.Caption = "单位筛选";
            this.tsbSelectCompany.Glyph = global::Haimen.Properties.Resources.Notes_hot;
            this.tsbSelectCompany.Id = 7;
            this.tsbSelectCompany.Name = "tsbSelectCompany";
            this.tsbSelectCompany.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbSelectCompany_ItemClick);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Caption = "查询";
            this.tsbQuery.Glyph = global::Haimen.Properties.Resources.Search_hot;
            this.tsbQuery.Id = 0;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbQuery_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tsbExit.Id = 1;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(793, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 469);
            this.barDockControlBottom.Size = new System.Drawing.Size(793, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 430);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(793, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 430);
            // 
            // lueBank
            // 
            this.lueBank.AutoHeight = false;
            this.lueBank.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBank.Name = "lueBank";
            this.lueBank.NullText = "";
            this.lueBank.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem()});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(793, 430);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_bank,
            this.col_company,
            this.col_account,
            this.col_balance,
            this.col_credit});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_bank
            // 
            this.col_bank.Caption = "银行";
            this.col_bank.FieldName = "bankname";
            this.col_bank.Name = "col_bank";
            this.col_bank.Visible = true;
            this.col_bank.VisibleIndex = 0;
            // 
            // col_company
            // 
            this.col_company.Caption = "单位";
            this.col_company.FieldName = "companyname";
            this.col_company.Name = "col_company";
            this.col_company.Visible = true;
            this.col_company.VisibleIndex = 1;
            // 
            // col_account
            // 
            this.col_account.Caption = "帐号";
            this.col_account.FieldName = "account";
            this.col_account.Name = "col_account";
            this.col_account.Visible = true;
            this.col_account.VisibleIndex = 2;
            // 
            // col_balance
            // 
            this.col_balance.Caption = "余额";
            this.col_balance.DisplayFormat.FormatString = "c";
            this.col_balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_balance.FieldName = "balance";
            this.col_balance.Name = "col_balance";
            this.col_balance.Visible = true;
            this.col_balance.VisibleIndex = 3;
            // 
            // col_credit
            // 
            this.col_credit.Caption = "贷款";
            this.col_credit.DisplayFormat.FormatString = "c";
            this.col_credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_credit.FieldName = "credit";
            this.col_credit.Name = "col_credit";
            this.col_credit.Visible = true;
            this.col_credit.VisibleIndex = 4;
            // 
            // devQueryBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 469);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "devQueryBalance";
            this.Text = "银行单位余额查询";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem tsbQuery;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lueBank;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.BarButtonItem tsbSelectBank;
        private DevExpress.XtraBars.BarButtonItem tsbSelectCompany;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_bank;
        private DevExpress.XtraGrid.Columns.GridColumn col_company;
        private DevExpress.XtraGrid.Columns.GridColumn col_account;
        private DevExpress.XtraGrid.Columns.GridColumn col_balance;
        private DevExpress.XtraGrid.Columns.GridColumn col_credit;
    }
}
﻿namespace Haimen.NewGUI
{
    partial class DevAccountList
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
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_outcompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_outcompany_bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_outcompany_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_incompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_incompany_bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_incompany_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_signed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_memo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbModify = new DevExpress.XtraBars.BarButtonItem();
            this.tsbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsbCheck = new DevExpress.XtraBars.BarButtonItem();
            this.tsbQuery = new DevExpress.XtraBars.BarButtonItem();
            this.tsbRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tsbNewInput = new DevExpress.XtraBars.BarButtonItem();
            this.c1SplitContainer1 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel1 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel2 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.c1SplitterPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "金额";
            this.gridColumn13.FieldName = "Money";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView3;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(177, 500);
            this.gridControl2.TabIndex = 25;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15,
            this.gridColumn13,
            this.gridColumn14});
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "资金性质";
            this.gridColumn15.FieldName = "Funds.Name";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 2;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "用途";
            this.gridColumn14.FieldName = "Usage";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.accountBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueStatus});
            this.gridControl1.Size = new System.Drawing.Size(563, 500);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(Haimen.Entity.Account);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_code,
            this.col_outcompany,
            this.col_outcompany_bank,
            this.col_outcompany_account,
            this.col_incompany,
            this.col_incompany_bank,
            this.col_incompany_account,
            this.col_status,
            this.col_signed,
            this.col_memo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_code
            // 
            this.col_code.Caption = "单据字";
            this.col_code.FieldName = "Code";
            this.col_code.Name = "col_code";
            this.col_code.Visible = true;
            this.col_code.VisibleIndex = 0;
            // 
            // col_outcompany
            // 
            this.col_outcompany.Caption = "付款单位";
            this.col_outcompany.FieldName = "OutCompany.Name";
            this.col_outcompany.Name = "col_outcompany";
            this.col_outcompany.Visible = true;
            this.col_outcompany.VisibleIndex = 1;
            // 
            // col_outcompany_bank
            // 
            this.col_outcompany_bank.Caption = "开户行";
            this.col_outcompany_bank.FieldName = "OutCompany.Bank.Name";
            this.col_outcompany_bank.Name = "col_outcompany_bank";
            this.col_outcompany_bank.Visible = true;
            this.col_outcompany_bank.VisibleIndex = 2;
            // 
            // col_outcompany_account
            // 
            this.col_outcompany_account.Caption = "帐号";
            this.col_outcompany_account.FieldName = "OutCompany.Account";
            this.col_outcompany_account.Name = "col_outcompany_account";
            this.col_outcompany_account.Visible = true;
            this.col_outcompany_account.VisibleIndex = 3;
            // 
            // col_incompany
            // 
            this.col_incompany.Caption = "收款单位";
            this.col_incompany.FieldName = "InCompany.Name";
            this.col_incompany.Name = "col_incompany";
            this.col_incompany.Visible = true;
            this.col_incompany.VisibleIndex = 4;
            // 
            // col_incompany_bank
            // 
            this.col_incompany_bank.Caption = "开户行";
            this.col_incompany_bank.FieldName = "InCompnay.Bank.Name";
            this.col_incompany_bank.Name = "col_incompany_bank";
            this.col_incompany_bank.Visible = true;
            this.col_incompany_bank.VisibleIndex = 5;
            // 
            // col_incompany_account
            // 
            this.col_incompany_account.Caption = "帐号";
            this.col_incompany_account.FieldName = "InCompany.Account";
            this.col_incompany_account.Name = "col_incompany_account";
            this.col_incompany_account.Visible = true;
            this.col_incompany_account.VisibleIndex = 6;
            // 
            // col_status
            // 
            this.col_status.Caption = "状态";
            this.col_status.ColumnEdit = this.lueStatus;
            this.col_status.FieldName = "Status";
            this.col_status.Name = "col_status";
            this.col_status.Visible = true;
            this.col_status.VisibleIndex = 7;
            // 
            // lueStatus
            // 
            this.lueStatus.AutoHeight = false;
            this.lueStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStatus.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueStatus.Name = "lueStatus";
            // 
            // col_signed
            // 
            this.col_signed.Caption = "签订日期";
            this.col_signed.FieldName = "SignedDate";
            this.col_signed.Name = "col_signed";
            this.col_signed.Visible = true;
            this.col_signed.VisibleIndex = 8;
            // 
            // col_memo
            // 
            this.col_memo.Caption = "备注";
            this.col_memo.FieldName = "Memo";
            this.col_memo.Name = "col_memo";
            this.col_memo.Visible = true;
            this.col_memo.VisibleIndex = 9;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "资金性质";
            this.gridColumn11.FieldName = "Funds.Name";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "金额";
            this.gridColumn12.FieldName = "Money";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
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
            this.tsbNew,
            this.tsbNewInput,
            this.tsbModify,
            this.tsbDelete,
            this.tsbCheck,
            this.tsbQuery,
            this.tsbExit,
            this.tsbRefresh});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbModify, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbCheck, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbQuery, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tsbNew
            // 
            this.tsbNew.Caption = "新增";
            this.tsbNew.Glyph = global::Haimen.Properties.Resources.New_hot;
            this.tsbNew.Id = 0;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbNew_ItemClick);
            // 
            // tsbModify
            // 
            this.tsbModify.Caption = "编辑";
            this.tsbModify.Glyph = global::Haimen.Properties.Resources.Edit_hot;
            this.tsbModify.Id = 2;
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbEdit_ItemClick);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Caption = "删除";
            this.tsbDelete.Glyph = global::Haimen.Properties.Resources.Delete_hot;
            this.tsbDelete.Id = 3;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbDelete_ItemClick);
            // 
            // tsbCheck
            // 
            this.tsbCheck.Caption = "审核";
            this.tsbCheck.Glyph = global::Haimen.Properties.Resources.Close_hot;
            this.tsbCheck.Id = 4;
            this.tsbCheck.Name = "tsbCheck";
            this.tsbCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbCheck_ItemClick);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Caption = "查询";
            this.tsbQuery.Glyph = global::Haimen.Properties.Resources.Search_hot;
            this.tsbQuery.Id = 5;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbQuery_ItemClick);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Caption = "刷新";
            this.tsbRefresh.Glyph = global::Haimen.Properties.Resources.Refresh_hot;
            this.tsbRefresh.Id = 8;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbRefresh_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tsbExit.Id = 6;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(744, 37);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 558);
            this.barDockControlBottom.Size = new System.Drawing.Size(744, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 521);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(744, 37);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 521);
            // 
            // tsbNewInput
            // 
            this.tsbNewInput.Id = 7;
            this.tsbNewInput.Name = "tsbNewInput";
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(150)))));
            this.c1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1SplitContainer1.Location = new System.Drawing.Point(0, 37);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel1);
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel2);
            this.c1SplitContainer1.Size = new System.Drawing.Size(744, 521);
            this.c1SplitContainer1.SplitterColor = System.Drawing.Color.Transparent;
            this.c1SplitContainer1.TabIndex = 33;
            this.c1SplitContainer1.UseParentVisualStyle = false;
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.gridControl1);
            this.c1SplitterPanel1.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 21);
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Size = new System.Drawing.Size(563, 500);
            this.c1SplitterPanel1.SizeRatio = 76.081D;
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Text = "列表";
            this.c1SplitterPanel1.Width = 563;
            // 
            // c1SplitterPanel2
            // 
            this.c1SplitterPanel2.Controls.Add(this.gridControl2);
            this.c1SplitterPanel2.Height = 100;
            this.c1SplitterPanel2.Location = new System.Drawing.Point(567, 21);
            this.c1SplitterPanel2.Name = "c1SplitterPanel2";
            this.c1SplitterPanel2.Size = new System.Drawing.Size(177, 500);
            this.c1SplitterPanel2.TabIndex = 1;
            this.c1SplitterPanel2.Text = "明细";
            // 
            // DevAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 558);
            this.Controls.Add(this.c1SplitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevAccountList";
            this.Text = "资金往来列表";
            this.Load += new System.EventHandler(this.DevAccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.c1SplitterPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany;
        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany_bank;
        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany_account;
        private DevExpress.XtraGrid.Columns.GridColumn col_incompany;
        private DevExpress.XtraGrid.Columns.GridColumn col_incompany_bank;
        private DevExpress.XtraGrid.Columns.GridColumn col_incompany_account;
        private DevExpress.XtraGrid.Columns.GridColumn col_memo;
        private DevExpress.XtraGrid.Columns.GridColumn col_signed;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem tsbNew;
        private DevExpress.XtraBars.BarButtonItem tsbNewInput;
        private DevExpress.XtraBars.BarButtonItem tsbModify;
        private DevExpress.XtraBars.BarButtonItem tsbDelete;
        private DevExpress.XtraBars.BarButtonItem tsbCheck;
        private DevExpress.XtraBars.BarButtonItem tsbQuery;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel2;
        private DevExpress.XtraGrid.Columns.GridColumn col_status;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueStatus;
        private DevExpress.XtraBars.BarButtonItem tsbRefresh;
    }
}
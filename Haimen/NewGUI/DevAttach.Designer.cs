namespace Haimen.NewGUI
{
    partial class DevAttach
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lstFiles = new System.Windows.Forms.CheckedListBox();
            this.btnSelect = new C1.Win.C1Input.C1Button();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.btnUpload = new C1.Win.C1Input.C1Button();
            this.btnExit = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lstFiles);
            this.layoutControl1.Controls.Add(this.btnSelect);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(449, 235);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 29);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(401, 191);
            this.lstFiles.TabIndex = 7;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(417, 30);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(20, 20);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "…";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(449, 235);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSelect;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(405, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(24, 42);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 20, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(24, 42);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(405, 42);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(24, 173);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lstFiles;
            this.layoutControlItem1.CustomizationFormText = "选择上传的文件：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(405, 215);
            this.layoutControlItem1.Text = "选择上传的文件：";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 14);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Owner = this;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(262, 253);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(77, 26);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "上传";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(345, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 26);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DevAttach
            // 
            this.AcceptButton = this.btnUpload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(449, 294);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.layoutControl1);
            this.Name = "DevAttach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "文件上传";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private C1.Win.C1Input.C1Button btnSelect;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Input.C1Button btnUpload;
        private C1.Win.C1Input.C1Button btnExit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.CheckedListBox lstFiles;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;

    }
}
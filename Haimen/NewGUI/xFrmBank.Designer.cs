namespace Haimen.NewGUI
{
    partial class xFrmBank
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
            this.c1XLBook1 = new C1.C1Excel.C1XLBook();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.c1DropDownControl1 = new C1.Win.C1Input.C1DropDownControl();
            this.c1Label3 = new C1.Win.C1Input.C1Label();
            this.calcEdit1 = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.Location = new System.Drawing.Point(115, 97);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(100, 22);
            this.c1TextBox1.TabIndex = 0;
            this.c1TextBox1.Tag = null;
            this.c1TextBox1.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Location = new System.Drawing.Point(42, 100);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(55, 14);
            this.c1Label1.TabIndex = 1;
            this.c1Label1.Tag = null;
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.Location = new System.Drawing.Point(115, 125);
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.Size = new System.Drawing.Size(100, 22);
            this.c1TextBox2.TabIndex = 0;
            this.c1TextBox2.Tag = null;
            this.c1TextBox2.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Location = new System.Drawing.Point(42, 128);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(55, 14);
            this.c1Label2.TabIndex = 1;
            this.c1Label2.Tag = null;
            // 
            // c1DropDownControl1
            // 
            this.c1DropDownControl1.Location = new System.Drawing.Point(115, 162);
            this.c1DropDownControl1.Name = "c1DropDownControl1";
            this.c1DropDownControl1.Size = new System.Drawing.Size(100, 22);
            this.c1DropDownControl1.TabIndex = 2;
            this.c1DropDownControl1.Tag = null;
            this.c1DropDownControl1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // c1Label3
            // 
            this.c1Label3.AutoSize = true;
            this.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label3.Location = new System.Drawing.Point(51, 162);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(55, 14);
            this.c1Label3.TabIndex = 3;
            this.c1Label3.Tag = null;
            // 
            // calcEdit1
            // 
            this.calcEdit1.Location = new System.Drawing.Point(51, 244);
            this.calcEdit1.Name = "calcEdit1";
            this.calcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit1.Size = new System.Drawing.Size(100, 20);
            this.calcEdit1.TabIndex = 4;
            // 
            // xFrmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 332);
            this.Controls.Add(this.calcEdit1);
            this.Controls.Add(this.c1Label3);
            this.Controls.Add(this.c1DropDownControl1);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1TextBox2);
            this.Controls.Add(this.c1TextBox1);
            this.Name = "xFrmBank";
            this.Text = "银行";
            this.Load += new System.EventHandler(this.xFrmBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.C1Excel.C1XLBook c1XLBook1;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1DropDownControl c1DropDownControl1;
        private C1.Win.C1Input.C1Label c1Label3;
        private DevExpress.XtraEditors.CalcEdit calcEdit1;

    }
}
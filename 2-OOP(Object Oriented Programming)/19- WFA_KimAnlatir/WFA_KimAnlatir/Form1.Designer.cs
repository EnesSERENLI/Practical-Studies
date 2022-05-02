namespace WFA_KimAnlatir
{
    partial class Form1
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
            this.btnSec = new System.Windows.Forms.Button();
            this.lstSinif = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstKonu = new System.Windows.Forms.ListBox();
            this.btn2ndChance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(227, 358);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(263, 48);
            this.btnSec.TabIndex = 5;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // lstSinif
            // 
            this.lstSinif.FormattingEnabled = true;
            this.lstSinif.Location = new System.Drawing.Point(12, 12);
            this.lstSinif.Name = "lstSinif";
            this.lstSinif.Size = new System.Drawing.Size(209, 394);
            this.lstSinif.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(227, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(522, 340);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AD";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SOYAD";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "KONU";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PUAN";
            this.columnHeader4.Width = 108;
            // 
            // lstKonu
            // 
            this.lstKonu.FormattingEnabled = true;
            this.lstKonu.Location = new System.Drawing.Point(755, 12);
            this.lstKonu.Name = "lstKonu";
            this.lstKonu.Size = new System.Drawing.Size(325, 394);
            this.lstKonu.TabIndex = 4;
            // 
            // btn2ndChance
            // 
            this.btn2ndChance.Location = new System.Drawing.Point(496, 358);
            this.btn2ndChance.Name = "btn2ndChance";
            this.btn2ndChance.Size = new System.Drawing.Size(253, 48);
            this.btn2ndChance.TabIndex = 5;
            this.btn2ndChance.Text = "SECOND CHANCE";
            this.btn2ndChance.UseVisualStyleBackColor = true;
            this.btn2ndChance.Click += new System.EventHandler(this.btn2ndChance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 416);
            this.Controls.Add(this.btn2ndChance);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lstKonu);
            this.Controls.Add(this.lstSinif);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ListBox lstSinif;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListBox lstKonu;
        private System.Windows.Forms.Button btn2ndChance;
    }
}


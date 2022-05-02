
namespace WFA_TahminEt
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTutulan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmin Et";
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Location = new System.Drawing.Point(143, 37);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 29);
            this.txtTahmin.TabIndex = 1;
            this.txtTahmin.MouseHover += new System.EventHandler(this.txtTahmin_MouseHover);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(143, 73);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(100, 28);
            this.btnTahmin.TabIndex = 2;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(76, 104);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(240, 73);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHak
            // 
            this.lblHak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHak.Location = new System.Drawing.Point(28, 206);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(150, 150);
            this.lblHak.TabIndex = 4;
            this.lblHak.Text = "5";
            this.lblHak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLevel
            // 
            this.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLevel.Location = new System.Drawing.Point(203, 206);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(150, 150);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "1";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tahmin Hakkı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(250, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seviye";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Tahmin Edilen: 5 Seviye: 1",
            "Tahmin Edilen:6 Seviye1",
            "Tahmin Eden: 8  Tutulan: 8 Seviye: 2"});
            this.listBox1.Location = new System.Drawing.Point(422, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 342);
            this.listBox1.TabIndex = 5;
            // 
            // lblTutulan
            // 
            this.lblTutulan.AutoSize = true;
            this.lblTutulan.Location = new System.Drawing.Point(105, 389);
            this.lblTutulan.Name = "lblTutulan";
            this.lblTutulan.Size = new System.Drawing.Size(43, 13);
            this.lblTutulan.TabIndex = 6;
            this.lblTutulan.Text = "Tutulan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 420);
            this.Controls.Add(this.lblTutulan);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTutulan;
    }
}


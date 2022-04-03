namespace WFA_HastaneRandevu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBransEkle = new System.Windows.Forms.Button();
            this.txtBrans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbRandevuDoktor = new System.Windows.Forms.ComboBox();
            this.cmbRandevuBrans = new System.Windows.Forms.ComboBox();
            this.txtRandevuSoyad = new System.Windows.Forms.TextBox();
            this.txtRandevuAd = new System.Windows.Forms.TextBox();
            this.txtRandevuTckn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBransEkle);
            this.groupBox1.Controls.Add(this.txtBrans);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(69, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branş";
            // 
            // btnBransEkle
            // 
            this.btnBransEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBransEkle.Location = new System.Drawing.Point(6, 96);
            this.btnBransEkle.Name = "btnBransEkle";
            this.btnBransEkle.Size = new System.Drawing.Size(200, 36);
            this.btnBransEkle.TabIndex = 2;
            this.btnBransEkle.Text = "Branş Ekle";
            this.btnBransEkle.UseVisualStyleBackColor = true;
            this.btnBransEkle.Click += new System.EventHandler(this.btnBransEkle_Click);
            // 
            // txtBrans
            // 
            this.txtBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrans.Location = new System.Drawing.Point(6, 61);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(200, 29);
            this.txtBrans.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBrans);
            this.groupBox2.Controls.Add(this.btnDoktorEkle);
            this.groupBox2.Controls.Add(this.txtDoktorAd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(472, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 205);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doktor";
            // 
            // cmbBrans
            // 
            this.cmbBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(6, 99);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(200, 32);
            this.cmbBrans.TabIndex = 3;
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorEkle.Location = new System.Drawing.Point(6, 150);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(200, 36);
            this.btnDoktorEkle.TabIndex = 2;
            this.btnDoktorEkle.Text = "Doktor Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorAd.Location = new System.Drawing.Point(6, 61);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(200, 29);
            this.txtDoktorAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doktor Ad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpTarih);
            this.groupBox3.Controls.Add(this.cmbRandevuDoktor);
            this.groupBox3.Controls.Add(this.cmbRandevuBrans);
            this.groupBox3.Controls.Add(this.txtRandevuSoyad);
            this.groupBox3.Controls.Add(this.txtRandevuAd);
            this.groupBox3.Controls.Add(this.txtRandevuTckn);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 362);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Bilgisi";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(81, 233);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 4;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // cmbRandevuDoktor
            // 
            this.cmbRandevuDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRandevuDoktor.FormattingEnabled = true;
            this.cmbRandevuDoktor.Location = new System.Drawing.Point(81, 182);
            this.cmbRandevuDoktor.Name = "cmbRandevuDoktor";
            this.cmbRandevuDoktor.Size = new System.Drawing.Size(200, 32);
            this.cmbRandevuDoktor.TabIndex = 3;
            // 
            // cmbRandevuBrans
            // 
            this.cmbRandevuBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRandevuBrans.FormattingEnabled = true;
            this.cmbRandevuBrans.Location = new System.Drawing.Point(81, 142);
            this.cmbRandevuBrans.Name = "cmbRandevuBrans";
            this.cmbRandevuBrans.Size = new System.Drawing.Size(200, 32);
            this.cmbRandevuBrans.TabIndex = 3;
            this.cmbRandevuBrans.SelectedIndexChanged += new System.EventHandler(this.cmbRandevuBrans_SelectedIndexChanged);
            // 
            // txtRandevuSoyad
            // 
            this.txtRandevuSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRandevuSoyad.Location = new System.Drawing.Point(81, 107);
            this.txtRandevuSoyad.Name = "txtRandevuSoyad";
            this.txtRandevuSoyad.Size = new System.Drawing.Size(171, 29);
            this.txtRandevuSoyad.TabIndex = 1;
            // 
            // txtRandevuAd
            // 
            this.txtRandevuAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRandevuAd.Location = new System.Drawing.Point(81, 71);
            this.txtRandevuAd.Name = "txtRandevuAd";
            this.txtRandevuAd.Size = new System.Drawing.Size(171, 29);
            this.txtRandevuAd.TabIndex = 1;
            // 
            // txtRandevuTckn
            // 
            this.txtRandevuTckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRandevuTckn.Location = new System.Drawing.Point(81, 34);
            this.txtRandevuTckn.Name = "txtRandevuTckn";
            this.txtRandevuTckn.Size = new System.Drawing.Size(171, 29);
            this.txtRandevuTckn.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Brans:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tckn:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(428, 309);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(314, 214);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBransEkle;
        private System.Windows.Forms.TextBox txtBrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbRandevuDoktor;
        private System.Windows.Forms.ComboBox cmbRandevuBrans;
        private System.Windows.Forms.TextBox txtRandevuSoyad;
        private System.Windows.Forms.TextBox txtRandevuAd;
        private System.Windows.Forms.TextBox txtRandevuTckn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}


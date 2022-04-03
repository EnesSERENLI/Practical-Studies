namespace WFA_Automat
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
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAlisveris = new System.Windows.Forms.Button();
            this.chkPeynir = new System.Windows.Forms.CheckBox();
            this.ChkCikolata = new System.Windows.Forms.CheckBox();
            this.chkCay = new System.Windows.Forms.CheckBox();
            this.chkYumurta = new System.Windows.Forms.CheckBox();
            this.chkEkmek = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudParaYatir = new System.Windows.Forms.NumericUpDown();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudParaCek = new System.Windows.Forms.NumericUpDown();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaYatir)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaCek)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(255, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "TL";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(516, 252);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(564, 147);
            this.listBox2.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAlisveris);
            this.groupBox3.Controls.Add(this.chkPeynir);
            this.groupBox3.Controls.Add(this.ChkCikolata);
            this.groupBox3.Controls.Add(this.chkCay);
            this.groupBox3.Controls.Add(this.chkYumurta);
            this.groupBox3.Controls.Add(this.chkEkmek);
            this.groupBox3.Location = new System.Drawing.Point(516, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 190);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnAlisveris
            // 
            this.btnAlisveris.Location = new System.Drawing.Point(58, 148);
            this.btnAlisveris.Name = "btnAlisveris";
            this.btnAlisveris.Size = new System.Drawing.Size(172, 23);
            this.btnAlisveris.TabIndex = 1;
            this.btnAlisveris.Text = "Alışverişi Tamamla";
            this.btnAlisveris.UseVisualStyleBackColor = true;
            this.btnAlisveris.Click += new System.EventHandler(this.btnAlisveris_Click);
            // 
            // chkPeynir
            // 
            this.chkPeynir.AutoSize = true;
            this.chkPeynir.Location = new System.Drawing.Point(6, 117);
            this.chkPeynir.Name = "chkPeynir";
            this.chkPeynir.Size = new System.Drawing.Size(86, 17);
            this.chkPeynir.TabIndex = 0;
            this.chkPeynir.Text = "Peynir 45 TL";
            this.chkPeynir.UseVisualStyleBackColor = true;
            // 
            // ChkCikolata
            // 
            this.ChkCikolata.AutoSize = true;
            this.ChkCikolata.Location = new System.Drawing.Point(6, 94);
            this.ChkCikolata.Name = "ChkCikolata";
            this.ChkCikolata.Size = new System.Drawing.Size(95, 17);
            this.ChkCikolata.TabIndex = 0;
            this.ChkCikolata.Text = "Çikolata 30 TL";
            this.ChkCikolata.UseVisualStyleBackColor = true;
            // 
            // chkCay
            // 
            this.chkCay.AutoSize = true;
            this.chkCay.Location = new System.Drawing.Point(6, 66);
            this.chkCay.Name = "chkCay";
            this.chkCay.Size = new System.Drawing.Size(102, 17);
            this.chkCay.TabIndex = 0;
            this.chkCay.Text = "Çay (1kg 35 TL)";
            this.chkCay.UseVisualStyleBackColor = true;
            // 
            // chkYumurta
            // 
            this.chkYumurta.AutoSize = true;
            this.chkYumurta.Location = new System.Drawing.Point(6, 43);
            this.chkYumurta.Name = "chkYumurta";
            this.chkYumurta.Size = new System.Drawing.Size(127, 17);
            this.chkYumurta.TabIndex = 0;
            this.chkYumurta.Text = "Yumurta (10\'lu 20 TL)";
            this.chkYumurta.UseVisualStyleBackColor = true;
            // 
            // chkEkmek
            // 
            this.chkEkmek.AutoSize = true;
            this.chkEkmek.Location = new System.Drawing.Point(6, 19);
            this.chkEkmek.Name = "chkEkmek";
            this.chkEkmek.Size = new System.Drawing.Size(90, 17);
            this.chkEkmek.TabIndex = 0;
            this.chkEkmek.Text = "Ekmek (4 TL)";
            this.chkEkmek.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 293);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 108);
            this.listBox1.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.nudParaYatir);
            this.groupBox2.Controls.Add(this.btnParaYatir);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(238, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 123);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Yatır";
            // 
            // nudParaYatir
            // 
            this.nudParaYatir.Location = new System.Drawing.Point(74, 49);
            this.nudParaYatir.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudParaYatir.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudParaYatir.Name = "nudParaYatir";
            this.nudParaYatir.Size = new System.Drawing.Size(120, 29);
            this.nudParaYatir.TabIndex = 1;
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(74, 84);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(120, 33);
            this.btnParaYatir.TabIndex = 1;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.nudParaCek);
            this.groupBox1.Controls.Add(this.btnParaCek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 123);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Çek";
            // 
            // nudParaCek
            // 
            this.nudParaCek.Location = new System.Drawing.Point(80, 46);
            this.nudParaCek.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudParaCek.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudParaCek.Name = "nudParaCek";
            this.nudParaCek.Size = new System.Drawing.Size(120, 29);
            this.nudParaCek.TabIndex = 1;
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(80, 81);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(120, 36);
            this.btnParaCek.TabIndex = 1;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Miktar:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(12, 56);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(426, 88);
            this.lblBakiye.TabIndex = 8;
            this.lblBakiye.Text = "0.00";
            this.lblBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bakiye";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaYatir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaCek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAlisveris;
        private System.Windows.Forms.CheckBox chkPeynir;
        private System.Windows.Forms.CheckBox ChkCikolata;
        private System.Windows.Forms.CheckBox chkCay;
        private System.Windows.Forms.CheckBox chkYumurta;
        private System.Windows.Forms.CheckBox chkEkmek;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudParaYatir;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudParaCek;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label1;
    }
}


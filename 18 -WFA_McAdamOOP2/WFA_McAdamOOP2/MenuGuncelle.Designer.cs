namespace WFA_McAdamOOP2
{
    partial class MenuGuncelle
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateHamburger = new System.Windows.Forms.Button();
            this.nudUpdateHamburger = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateOldHamburger = new System.Windows.Forms.TextBox();
            this.txtUpdateNewHamburger = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateHamburger)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateHamburger);
            this.groupBox3.Controls.Add(this.nudUpdateHamburger);
            this.groupBox3.Controls.Add(this.txtUpdateOldHamburger);
            this.groupBox3.Controls.Add(this.txtUpdateNewHamburger);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 154);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Hamburger";
            // 
            // btnUpdateHamburger
            // 
            this.btnUpdateHamburger.BackColor = System.Drawing.Color.Fuchsia;
            this.btnUpdateHamburger.Location = new System.Drawing.Point(6, 120);
            this.btnUpdateHamburger.Name = "btnUpdateHamburger";
            this.btnUpdateHamburger.Size = new System.Drawing.Size(241, 28);
            this.btnUpdateHamburger.TabIndex = 3;
            this.btnUpdateHamburger.Text = "UPDATE";
            this.btnUpdateHamburger.UseVisualStyleBackColor = false;
            this.btnUpdateHamburger.Click += new System.EventHandler(this.btnUpdateHamburger_Click);
            // 
            // nudUpdateHamburger
            // 
            this.nudUpdateHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUpdateHamburger.Location = new System.Drawing.Point(127, 75);
            this.nudUpdateHamburger.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUpdateHamburger.Name = "nudUpdateHamburger";
            this.nudUpdateHamburger.Size = new System.Drawing.Size(120, 23);
            this.nudUpdateHamburger.TabIndex = 2;
            // 
            // txtUpdateOldHamburger
            // 
            this.txtUpdateOldHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateOldHamburger.Location = new System.Drawing.Point(159, 13);
            this.txtUpdateOldHamburger.Name = "txtUpdateOldHamburger";
            this.txtUpdateOldHamburger.Size = new System.Drawing.Size(88, 23);
            this.txtUpdateOldHamburger.TabIndex = 1;
            // 
            // txtUpdateNewHamburger
            // 
            this.txtUpdateNewHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateNewHamburger.Location = new System.Drawing.Point(159, 45);
            this.txtUpdateNewHamburger.Name = "txtUpdateNewHamburger";
            this.txtUpdateNewHamburger.Size = new System.Drawing.Size(88, 23);
            this.txtUpdateNewHamburger.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "HamburgerPrice:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "OldHamburgerName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "NewHamburgerName:";
            // 
            // MenuGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 177);
            this.Controls.Add(this.groupBox3);
            this.Name = "MenuGuncelle";
            this.Text = "Menu Güncelle";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateHamburger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateHamburger;
        private System.Windows.Forms.NumericUpDown nudUpdateHamburger;
        private System.Windows.Forms.TextBox txtUpdateOldHamburger;
        private System.Windows.Forms.TextBox txtUpdateNewHamburger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}
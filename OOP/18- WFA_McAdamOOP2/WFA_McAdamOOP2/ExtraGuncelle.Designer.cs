namespace WFA_McAdamOOP2
{
    partial class ExtraGuncelle
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateExtra = new System.Windows.Forms.Button();
            this.nudUpdateExtra = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateOldExtra = new System.Windows.Forms.TextBox();
            this.txtUpdateNewExtra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdateExtra);
            this.groupBox4.Controls.Add(this.nudUpdateExtra);
            this.groupBox4.Controls.Add(this.txtUpdateOldExtra);
            this.groupBox4.Controls.Add(this.txtUpdateNewExtra);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 154);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Extra";
            // 
            // btnUpdateExtra
            // 
            this.btnUpdateExtra.BackColor = System.Drawing.Color.Fuchsia;
            this.btnUpdateExtra.Location = new System.Drawing.Point(6, 120);
            this.btnUpdateExtra.Name = "btnUpdateExtra";
            this.btnUpdateExtra.Size = new System.Drawing.Size(241, 28);
            this.btnUpdateExtra.TabIndex = 3;
            this.btnUpdateExtra.Text = "UPDATE";
            this.btnUpdateExtra.UseVisualStyleBackColor = false;
            this.btnUpdateExtra.Click += new System.EventHandler(this.btnUpdateExtra_Click);
            // 
            // nudUpdateExtra
            // 
            this.nudUpdateExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUpdateExtra.Location = new System.Drawing.Point(93, 81);
            this.nudUpdateExtra.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUpdateExtra.Name = "nudUpdateExtra";
            this.nudUpdateExtra.Size = new System.Drawing.Size(154, 23);
            this.nudUpdateExtra.TabIndex = 2;
            // 
            // txtUpdateOldExtra
            // 
            this.txtUpdateOldExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateOldExtra.Location = new System.Drawing.Point(125, 16);
            this.txtUpdateOldExtra.Name = "txtUpdateOldExtra";
            this.txtUpdateOldExtra.Size = new System.Drawing.Size(122, 23);
            this.txtUpdateOldExtra.TabIndex = 1;
            // 
            // txtUpdateNewExtra
            // 
            this.txtUpdateNewExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateNewExtra.Location = new System.Drawing.Point(125, 47);
            this.txtUpdateNewExtra.Name = "txtUpdateNewExtra";
            this.txtUpdateNewExtra.Size = new System.Drawing.Size(122, 23);
            this.txtUpdateNewExtra.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "NewExtraName:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "ExtraPrice:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "OldExtraName:";
            // 
            // ExtraGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 177);
            this.Controls.Add(this.groupBox4);
            this.Name = "ExtraGuncelle";
            this.Text = "ExtraGuncelle";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateExtra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateExtra;
        private System.Windows.Forms.NumericUpDown nudUpdateExtra;
        private System.Windows.Forms.TextBox txtUpdateOldExtra;
        private System.Windows.Forms.TextBox txtUpdateNewExtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
    }
}
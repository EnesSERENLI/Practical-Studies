namespace WFA_McAdamOOP2
{
    partial class ExtraSil
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDeleteExtra = new System.Windows.Forms.Button();
            this.txtDeleteExtra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDeleteExtra);
            this.groupBox6.Controls.Add(this.txtDeleteExtra);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(253, 154);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Delete Extra";
            // 
            // btnDeleteExtra
            // 
            this.btnDeleteExtra.BackColor = System.Drawing.Color.Red;
            this.btnDeleteExtra.Location = new System.Drawing.Point(6, 120);
            this.btnDeleteExtra.Name = "btnDeleteExtra";
            this.btnDeleteExtra.Size = new System.Drawing.Size(241, 28);
            this.btnDeleteExtra.TabIndex = 3;
            this.btnDeleteExtra.Text = "DELETE";
            this.btnDeleteExtra.UseVisualStyleBackColor = false;
            this.btnDeleteExtra.Click += new System.EventHandler(this.btnDeleteExtra_Click);
            // 
            // txtDeleteExtra
            // 
            this.txtDeleteExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeleteExtra.Location = new System.Drawing.Point(93, 31);
            this.txtDeleteExtra.Name = "txtDeleteExtra";
            this.txtDeleteExtra.Size = new System.Drawing.Size(154, 23);
            this.txtDeleteExtra.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(11, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "ExtraName:";
            // 
            // ExtraSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 177);
            this.Controls.Add(this.groupBox6);
            this.Name = "ExtraSil";
            this.Text = "ExtraSil";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDeleteExtra;
        private System.Windows.Forms.TextBox txtDeleteExtra;
        private System.Windows.Forms.Label label11;
    }
}
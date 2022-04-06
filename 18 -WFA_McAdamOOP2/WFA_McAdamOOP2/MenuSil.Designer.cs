namespace WFA_McAdamOOP2
{
    partial class MenuSil
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeleteHamburger = new System.Windows.Forms.Button();
            this.txtDeleteHamburger = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeleteHamburger);
            this.groupBox5.Controls.Add(this.txtDeleteHamburger);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 154);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Delete Hamburger";
            // 
            // btnDeleteHamburger
            // 
            this.btnDeleteHamburger.BackColor = System.Drawing.Color.Red;
            this.btnDeleteHamburger.Location = new System.Drawing.Point(6, 120);
            this.btnDeleteHamburger.Name = "btnDeleteHamburger";
            this.btnDeleteHamburger.Size = new System.Drawing.Size(241, 28);
            this.btnDeleteHamburger.TabIndex = 3;
            this.btnDeleteHamburger.Text = "DELETE";
            this.btnDeleteHamburger.UseVisualStyleBackColor = false;
            this.btnDeleteHamburger.Click += new System.EventHandler(this.btnDeleteHamburger_Click);
            // 
            // txtDeleteHamburger
            // 
            this.txtDeleteHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeleteHamburger.Location = new System.Drawing.Point(127, 45);
            this.txtDeleteHamburger.Name = "txtDeleteHamburger";
            this.txtDeleteHamburger.Size = new System.Drawing.Size(120, 23);
            this.txtDeleteHamburger.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "HambugerName:";
            // 
            // MenuSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 173);
            this.Controls.Add(this.groupBox5);
            this.Name = "MenuSil";
            this.Text = "MenuSil";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDeleteHamburger;
        private System.Windows.Forms.TextBox txtDeleteHamburger;
        private System.Windows.Forms.Label label10;
    }
}
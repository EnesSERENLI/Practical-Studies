namespace WinUI.Forms
{
    partial class AdminForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateExtra = new System.Windows.Forms.Button();
            this.nudUpdateExtra = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateExtraID = new System.Windows.Forms.TextBox();
            this.txtUpdateExtra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddExtra = new System.Windows.Forms.Button();
            this.nudAddExtra = new System.Windows.Forms.NumericUpDown();
            this.txtAddExtra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeleteHamburger = new System.Windows.Forms.Button();
            this.txtDeleteHamburger = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateHamburger = new System.Windows.Forms.Button();
            this.nudUpdateHamburger = new System.Windows.Forms.NumericUpDown();
            this.txtUpdateHamburgerID = new System.Windows.Forms.TextBox();
            this.txtUpdateHamburger = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddHamburger = new System.Windows.Forms.Button();
            this.nudAddHamburger = new System.Windows.Forms.NumericUpDown();
            this.txtAddHamburger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateExtra)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddExtra)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateHamburger)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddHamburger)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDeleteExtra);
            this.groupBox6.Controls.Add(this.txtDeleteExtra);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(406, 332);
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
            this.btnDeleteExtra.Text = "DELETE Extra";
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
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdateExtra);
            this.groupBox4.Controls.Add(this.nudUpdateExtra);
            this.groupBox4.Controls.Add(this.txtUpdateExtraID);
            this.groupBox4.Controls.Add(this.txtUpdateExtra);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(406, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 154);
            this.groupBox4.TabIndex = 2;
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
            this.btnUpdateExtra.Text = "UPDATE extra";
            this.btnUpdateExtra.UseVisualStyleBackColor = false;
            this.btnUpdateExtra.Click += new System.EventHandler(this.btnUpdateExtra_Click);
            // 
            // nudUpdateExtra
            // 
            this.nudUpdateExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUpdateExtra.Location = new System.Drawing.Point(74, 81);
            this.nudUpdateExtra.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUpdateExtra.Name = "nudUpdateExtra";
            this.nudUpdateExtra.Size = new System.Drawing.Size(173, 23);
            this.nudUpdateExtra.TabIndex = 2;
            // 
            // txtUpdateExtraID
            // 
            this.txtUpdateExtraID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateExtraID.Location = new System.Drawing.Point(74, 16);
            this.txtUpdateExtraID.Name = "txtUpdateExtraID";
            this.txtUpdateExtraID.Size = new System.Drawing.Size(173, 23);
            this.txtUpdateExtraID.TabIndex = 1;
            // 
            // txtUpdateExtra
            // 
            this.txtUpdateExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateExtra.Location = new System.Drawing.Point(74, 47);
            this.txtUpdateExtra.Name = "txtUpdateExtra";
            this.txtUpdateExtra.Size = new System.Drawing.Size(173, 23);
            this.txtUpdateExtra.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Price:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(11, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddExtra);
            this.groupBox2.Controls.Add(this.nudAddExtra);
            this.groupBox2.Controls.Add(this.txtAddExtra);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(406, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Extra";
            // 
            // btnAddExtra
            // 
            this.btnAddExtra.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddExtra.Location = new System.Drawing.Point(6, 120);
            this.btnAddExtra.Name = "btnAddExtra";
            this.btnAddExtra.Size = new System.Drawing.Size(241, 28);
            this.btnAddExtra.TabIndex = 3;
            this.btnAddExtra.Text = "ADD Extra";
            this.btnAddExtra.UseVisualStyleBackColor = false;
            this.btnAddExtra.Click += new System.EventHandler(this.btnAddExtra_Click);
            // 
            // nudAddExtra
            // 
            this.nudAddExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAddExtra.Location = new System.Drawing.Point(93, 65);
            this.nudAddExtra.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAddExtra.Name = "nudAddExtra";
            this.nudAddExtra.Size = new System.Drawing.Size(154, 23);
            this.nudAddExtra.TabIndex = 2;
            // 
            // txtAddExtra
            // 
            this.txtAddExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddExtra.Location = new System.Drawing.Point(93, 31);
            this.txtAddExtra.Name = "txtAddExtra";
            this.txtAddExtra.Size = new System.Drawing.Size(154, 23);
            this.txtAddExtra.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ExtraName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ExtraPrice:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeleteHamburger);
            this.groupBox5.Controls.Add(this.txtDeleteHamburger);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(12, 332);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 154);
            this.groupBox5.TabIndex = 4;
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
            this.btnDeleteHamburger.Text = "DELETE Hamburger";
            this.btnDeleteHamburger.UseVisualStyleBackColor = false;
            this.btnDeleteHamburger.Click += new System.EventHandler(this.btnDeleteHamburger_Click);
            // 
            // txtDeleteHamburger
            // 
            this.txtDeleteHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeleteHamburger.Location = new System.Drawing.Point(37, 45);
            this.txtDeleteHamburger.Name = "txtDeleteHamburger";
            this.txtDeleteHamburger.Size = new System.Drawing.Size(210, 23);
            this.txtDeleteHamburger.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateHamburger);
            this.groupBox3.Controls.Add(this.nudUpdateHamburger);
            this.groupBox3.Controls.Add(this.txtUpdateHamburgerID);
            this.groupBox3.Controls.Add(this.txtUpdateHamburger);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 154);
            this.groupBox3.TabIndex = 5;
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
            this.btnUpdateHamburger.Text = "UPDATE Hamburger";
            this.btnUpdateHamburger.UseVisualStyleBackColor = false;
            this.btnUpdateHamburger.Click += new System.EventHandler(this.btnUpdateHamburger_Click);
            // 
            // nudUpdateHamburger
            // 
            this.nudUpdateHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUpdateHamburger.Location = new System.Drawing.Point(66, 75);
            this.nudUpdateHamburger.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUpdateHamburger.Name = "nudUpdateHamburger";
            this.nudUpdateHamburger.Size = new System.Drawing.Size(181, 23);
            this.nudUpdateHamburger.TabIndex = 2;
            // 
            // txtUpdateHamburgerID
            // 
            this.txtUpdateHamburgerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateHamburgerID.Location = new System.Drawing.Point(66, 19);
            this.txtUpdateHamburgerID.Name = "txtUpdateHamburgerID";
            this.txtUpdateHamburgerID.Size = new System.Drawing.Size(181, 23);
            this.txtUpdateHamburgerID.TabIndex = 1;
            // 
            // txtUpdateHamburger
            // 
            this.txtUpdateHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateHamburger.Location = new System.Drawing.Point(66, 45);
            this.txtUpdateHamburger.Name = "txtUpdateHamburger";
            this.txtUpdateHamburger.Size = new System.Drawing.Size(181, 23);
            this.txtUpdateHamburger.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddHamburger);
            this.groupBox1.Controls.Add(this.nudAddHamburger);
            this.groupBox1.Controls.Add(this.txtAddHamburger);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Hamburger";
            // 
            // btnAddHamburger
            // 
            this.btnAddHamburger.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddHamburger.Location = new System.Drawing.Point(6, 120);
            this.btnAddHamburger.Name = "btnAddHamburger";
            this.btnAddHamburger.Size = new System.Drawing.Size(241, 28);
            this.btnAddHamburger.TabIndex = 3;
            this.btnAddHamburger.Text = "ADD Hamburger";
            this.btnAddHamburger.UseVisualStyleBackColor = false;
            this.btnAddHamburger.Click += new System.EventHandler(this.btnAddHamburger_Click);
            // 
            // nudAddHamburger
            // 
            this.nudAddHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAddHamburger.Location = new System.Drawing.Point(127, 75);
            this.nudAddHamburger.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAddHamburger.Name = "nudAddHamburger";
            this.nudAddHamburger.Size = new System.Drawing.Size(120, 23);
            this.nudAddHamburger.TabIndex = 2;
            // 
            // txtAddHamburger
            // 
            this.txtAddHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddHamburger.Location = new System.Drawing.Point(127, 45);
            this.txtAddHamburger.Name = "txtAddHamburger";
            this.txtAddHamburger.Size = new System.Drawing.Size(120, 23);
            this.txtAddHamburger.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "HamburgerPrice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HambugerName:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 497);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateExtra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddExtra)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateHamburger)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddHamburger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDeleteExtra;
        private System.Windows.Forms.TextBox txtDeleteExtra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateExtra;
        private System.Windows.Forms.NumericUpDown nudUpdateExtra;
        private System.Windows.Forms.TextBox txtUpdateExtraID;
        private System.Windows.Forms.TextBox txtUpdateExtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddExtra;
        private System.Windows.Forms.NumericUpDown nudAddExtra;
        private System.Windows.Forms.TextBox txtAddExtra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDeleteHamburger;
        private System.Windows.Forms.TextBox txtDeleteHamburger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateHamburger;
        private System.Windows.Forms.NumericUpDown nudUpdateHamburger;
        private System.Windows.Forms.TextBox txtUpdateHamburgerID;
        private System.Windows.Forms.TextBox txtUpdateHamburger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddHamburger;
        private System.Windows.Forms.NumericUpDown nudAddHamburger;
        private System.Windows.Forms.TextBox txtAddHamburger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
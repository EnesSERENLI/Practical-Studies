namespace WinUI.Forms
{
    partial class HamburgerForm
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
            this.lblListAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpExtra = new System.Windows.Forms.FlowLayoutPanel();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMiddle = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListAmount
            // 
            this.lblListAmount.AutoSize = true;
            this.lblListAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListAmount.Location = new System.Drawing.Point(403, 451);
            this.lblListAmount.Name = "lblListAmount";
            this.lblListAmount.Size = new System.Drawing.Size(37, 17);
            this.lblListAmount.TabIndex = 110;
            this.lblListAmount.Text = "0 TL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(259, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 17);
            this.label13.TabIndex = 112;
            this.label13.Text = "Total Amount(KDV) :";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(674, 451);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(114, 26);
            this.btnOrder.TabIndex = 108;
            this.btnOrder.Text = "Complate Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(262, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(526, 433);
            this.listBox1.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "Hamburgers";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 437);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(244, 31);
            this.btnCalculate.TabIndex = 105;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudQuantity.Location = new System.Drawing.Point(82, 347);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(174, 26);
            this.nudQuantity.TabIndex = 104;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 103;
            this.label1.Text = "Quantity :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpExtra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 146);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extras";
            // 
            // flpExtra
            // 
            this.flpExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpExtra.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flpExtra.Location = new System.Drawing.Point(3, 22);
            this.flpExtra.Name = "flpExtra";
            this.flpExtra.Size = new System.Drawing.Size(238, 121);
            this.flpExtra.TabIndex = 0;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbLarge.Location = new System.Drawing.Point(176, 161);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(76, 28);
            this.rbLarge.TabIndex = 99;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMiddle
            // 
            this.rbMiddle.AutoSize = true;
            this.rbMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMiddle.Location = new System.Drawing.Point(91, 161);
            this.rbMiddle.Name = "rbMiddle";
            this.rbMiddle.Size = new System.Drawing.Size(85, 28);
            this.rbMiddle.TabIndex = 100;
            this.rbMiddle.Text = "Middle";
            this.rbMiddle.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSmall.Location = new System.Drawing.Point(11, 161);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(74, 28);
            this.rbSmall.TabIndex = 101;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // cmbMenu
            // 
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(12, 134);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(244, 21);
            this.cmbMenu.TabIndex = 98;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinUI.Properties.Resources._440_4404377_hamburger_logo_de_hamburguesa_png;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(13, 410);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(242, 21);
            this.cmbPayment.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 106;
            this.label3.Text = "Payment Method";
            // 
            // HamburgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 485);
            this.Controls.Add(this.lblListAmount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbLarge);
            this.Controls.Add(this.rbMiddle);
            this.Controls.Add(this.rbSmall);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HamburgerForm";
            this.Text = "HamburgerForm";
            this.Load += new System.EventHandler(this.HamburgerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpExtra;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMiddle;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label label3;
    }
}
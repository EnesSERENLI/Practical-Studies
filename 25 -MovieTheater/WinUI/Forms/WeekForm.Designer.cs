namespace WinUI.Forms
{
    partial class WeekForm
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
            this.dtpAddWeekLastDay = new System.Windows.Forms.DateTimePicker();
            this.dtpAddWeekFirstDay = new System.Windows.Forms.DateTimePicker();
            this.btnAddWeek = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddWeekName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeleteWeekID = new System.Windows.Forms.TextBox();
            this.btnDeleteWeek = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpUpdateWeekLastDay = new System.Windows.Forms.DateTimePicker();
            this.dtpUpdateWeekFirstDay = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateWeek = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUpdateWeekName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateWeekID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnListWeeks = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpAddWeekLastDay);
            this.groupBox1.Controls.Add(this.dtpAddWeekFirstDay);
            this.groupBox1.Controls.Add(this.btnAddWeek);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtAddWeekName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 239);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Week";
            // 
            // dtpAddWeekLastDay
            // 
            this.dtpAddWeekLastDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpAddWeekLastDay.Location = new System.Drawing.Point(137, 120);
            this.dtpAddWeekLastDay.Name = "dtpAddWeekLastDay";
            this.dtpAddWeekLastDay.Size = new System.Drawing.Size(196, 26);
            this.dtpAddWeekLastDay.TabIndex = 5;
            // 
            // dtpAddWeekFirstDay
            // 
            this.dtpAddWeekFirstDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpAddWeekFirstDay.Location = new System.Drawing.Point(137, 75);
            this.dtpAddWeekFirstDay.Name = "dtpAddWeekFirstDay";
            this.dtpAddWeekFirstDay.Size = new System.Drawing.Size(196, 26);
            this.dtpAddWeekFirstDay.TabIndex = 5;
            // 
            // btnAddWeek
            // 
            this.btnAddWeek.Location = new System.Drawing.Point(137, 175);
            this.btnAddWeek.Name = "btnAddWeek";
            this.btnAddWeek.Size = new System.Drawing.Size(196, 34);
            this.btnAddWeek.TabIndex = 4;
            this.btnAddWeek.Text = "Add Week";
            this.btnAddWeek.UseVisualStyleBackColor = true;
            this.btnAddWeek.Click += new System.EventHandler(this.btnAddWeek_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(137, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(196, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Movie";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtAddWeekName
            // 
            this.txtAddWeekName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddWeekName.Location = new System.Drawing.Point(137, 30);
            this.txtAddWeekName.Name = "txtAddWeekName";
            this.txtAddWeekName.Size = new System.Drawing.Size(196, 26);
            this.txtAddWeekName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "WeekLastDay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "WeekFirstDay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "WeekName:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "WeekID:";
            // 
            // txtDeleteWeekID
            // 
            this.txtDeleteWeekID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeleteWeekID.Location = new System.Drawing.Point(137, 30);
            this.txtDeleteWeekID.Name = "txtDeleteWeekID";
            this.txtDeleteWeekID.Size = new System.Drawing.Size(196, 26);
            this.txtDeleteWeekID.TabIndex = 1;
            // 
            // btnDeleteWeek
            // 
            this.btnDeleteWeek.Location = new System.Drawing.Point(137, 80);
            this.btnDeleteWeek.Name = "btnDeleteWeek";
            this.btnDeleteWeek.Size = new System.Drawing.Size(196, 34);
            this.btnDeleteWeek.TabIndex = 4;
            this.btnDeleteWeek.TabStop = false;
            this.btnDeleteWeek.Text = "Delete Week";
            this.btnDeleteWeek.UseVisualStyleBackColor = true;
            this.btnDeleteWeek.Click += new System.EventHandler(this.btnDeleteWeek_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteWeek);
            this.groupBox2.Controls.Add(this.txtDeleteWeekID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(367, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 131);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Week";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpUpdateWeekLastDay);
            this.groupBox3.Controls.Add(this.dtpUpdateWeekFirstDay);
            this.groupBox3.Controls.Add(this.btnUpdateWeek);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtUpdateWeekName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtUpdateWeekID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 259);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Week";
            // 
            // dtpUpdateWeekLastDay
            // 
            this.dtpUpdateWeekLastDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpUpdateWeekLastDay.Location = new System.Drawing.Point(137, 164);
            this.dtpUpdateWeekLastDay.Name = "dtpUpdateWeekLastDay";
            this.dtpUpdateWeekLastDay.Size = new System.Drawing.Size(196, 26);
            this.dtpUpdateWeekLastDay.TabIndex = 5;
            // 
            // dtpUpdateWeekFirstDay
            // 
            this.dtpUpdateWeekFirstDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpUpdateWeekFirstDay.Location = new System.Drawing.Point(137, 119);
            this.dtpUpdateWeekFirstDay.Name = "dtpUpdateWeekFirstDay";
            this.dtpUpdateWeekFirstDay.Size = new System.Drawing.Size(196, 26);
            this.dtpUpdateWeekFirstDay.TabIndex = 5;
            // 
            // btnUpdateWeek
            // 
            this.btnUpdateWeek.Location = new System.Drawing.Point(137, 219);
            this.btnUpdateWeek.Name = "btnUpdateWeek";
            this.btnUpdateWeek.Size = new System.Drawing.Size(196, 34);
            this.btnUpdateWeek.TabIndex = 4;
            this.btnUpdateWeek.Text = "Update Week";
            this.btnUpdateWeek.UseVisualStyleBackColor = true;
            this.btnUpdateWeek.Click += new System.EventHandler(this.btnUpdateWeek_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save Movie";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtUpdateWeekName
            // 
            this.txtUpdateWeekName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateWeekName.Location = new System.Drawing.Point(137, 74);
            this.txtUpdateWeekName.Name = "txtUpdateWeekName";
            this.txtUpdateWeekName.Size = new System.Drawing.Size(196, 26);
            this.txtUpdateWeekName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "WeekLastDay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "WeekFirstDay:";
            // 
            // txtUpdateWeekID
            // 
            this.txtUpdateWeekID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateWeekID.Location = new System.Drawing.Point(137, 30);
            this.txtUpdateWeekID.Name = "txtUpdateWeekID";
            this.txtUpdateWeekID.Size = new System.Drawing.Size(196, 26);
            this.txtUpdateWeekID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(10, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "WeekName:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(10, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "WeekID:";
            // 
            // btnListWeeks
            // 
            this.btnListWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListWeeks.Location = new System.Drawing.Point(357, 197);
            this.btnListWeeks.Name = "btnListWeeks";
            this.btnListWeeks.Size = new System.Drawing.Size(349, 285);
            this.btnListWeeks.TabIndex = 35;
            this.btnListWeeks.Text = "Bring the Weeks";
            this.btnListWeeks.UseVisualStyleBackColor = true;
            this.btnListWeeks.Click += new System.EventHandler(this.btnListWeeks_Click);
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
            this.listView1.Location = new System.Drawing.Point(712, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(462, 507);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "WeekID";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "WeekName";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "WeekFirstDay";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "WeekLastDay";
            this.columnHeader4.Width = 153;
            // 
            // WeekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 534);
            this.Controls.Add(this.btnListWeeks);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "WeekForm";
            this.Text = "WeekForm";
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
        private System.Windows.Forms.DateTimePicker dtpAddWeekLastDay;
        private System.Windows.Forms.DateTimePicker dtpAddWeekFirstDay;
        private System.Windows.Forms.Button btnAddWeek;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddWeekName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeleteWeekID;
        private System.Windows.Forms.Button btnDeleteWeek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpUpdateWeekLastDay;
        private System.Windows.Forms.DateTimePicker dtpUpdateWeekFirstDay;
        private System.Windows.Forms.Button btnUpdateWeek;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtUpdateWeekName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateWeekID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnListWeeks;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
namespace WinUI.Forms
{
    partial class SaloonForm
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
            this.btnListSession = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSaloon = new System.Windows.Forms.Button();
            this.txtUpdateCapacity = new System.Windows.Forms.TextBox();
            this.txtUpdateSaloonName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateSaloonID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSaloon = new System.Windows.Forms.Button();
            this.txtDeleteSaloon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddSaloon = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddCapacity = new System.Windows.Forms.TextBox();
            this.txtAddSaloonName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListSession
            // 
            this.btnListSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListSession.Location = new System.Drawing.Point(357, 12);
            this.btnListSession.Name = "btnListSession";
            this.btnListSession.Size = new System.Drawing.Size(374, 39);
            this.btnListSession.TabIndex = 32;
            this.btnListSession.Text = "Bring the Sessions";
            this.btnListSession.UseVisualStyleBackColor = true;
            this.btnListSession.Click += new System.EventHandler(this.btnListSession_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(357, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 482);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SaloonID";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SaloonName";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Capacity";
            this.columnHeader3.Width = 131;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateSaloon);
            this.groupBox3.Controls.Add(this.txtUpdateCapacity);
            this.groupBox3.Controls.Add(this.txtUpdateSaloonName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtUpdateSaloonID);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 198);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Session";
            // 
            // btnUpdateSaloon
            // 
            this.btnUpdateSaloon.Location = new System.Drawing.Point(137, 158);
            this.btnUpdateSaloon.Name = "btnUpdateSaloon";
            this.btnUpdateSaloon.Size = new System.Drawing.Size(196, 34);
            this.btnUpdateSaloon.TabIndex = 4;
            this.btnUpdateSaloon.Text = "Update Saloon";
            this.btnUpdateSaloon.UseVisualStyleBackColor = true;
            this.btnUpdateSaloon.Click += new System.EventHandler(this.btnUpdateSaloon_Click);
            // 
            // txtUpdateCapacity
            // 
            this.txtUpdateCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateCapacity.Location = new System.Drawing.Point(137, 117);
            this.txtUpdateCapacity.Name = "txtUpdateCapacity";
            this.txtUpdateCapacity.Size = new System.Drawing.Size(196, 26);
            this.txtUpdateCapacity.TabIndex = 1;
            // 
            // txtUpdateSaloonName
            // 
            this.txtUpdateSaloonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateSaloonName.Location = new System.Drawing.Point(137, 75);
            this.txtUpdateSaloonName.Name = "txtUpdateSaloonName";
            this.txtUpdateSaloonName.Size = new System.Drawing.Size(196, 26);
            this.txtUpdateSaloonName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Capacity:";
            // 
            // txtUpdateSaloonID
            // 
            this.txtUpdateSaloonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateSaloonID.Location = new System.Drawing.Point(137, 30);
            this.txtUpdateSaloonID.Name = "txtUpdateSaloonID";
            this.txtUpdateSaloonID.Size = new System.Drawing.Size(196, 26);
            this.txtUpdateSaloonID.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(10, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "SaloonName:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(10, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "SaloonID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteSaloon);
            this.groupBox2.Controls.Add(this.txtDeleteSaloon);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 129);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Session";
            // 
            // btnDeleteSaloon
            // 
            this.btnDeleteSaloon.Location = new System.Drawing.Point(137, 73);
            this.btnDeleteSaloon.Name = "btnDeleteSaloon";
            this.btnDeleteSaloon.Size = new System.Drawing.Size(196, 34);
            this.btnDeleteSaloon.TabIndex = 4;
            this.btnDeleteSaloon.TabStop = false;
            this.btnDeleteSaloon.Text = "Delete Saloon";
            this.btnDeleteSaloon.UseVisualStyleBackColor = true;
            this.btnDeleteSaloon.Click += new System.EventHandler(this.btnDeleteSaloon_Click);
            // 
            // txtDeleteSaloon
            // 
            this.txtDeleteSaloon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeleteSaloon.Location = new System.Drawing.Point(137, 30);
            this.txtDeleteSaloon.Name = "txtDeleteSaloon";
            this.txtDeleteSaloon.Size = new System.Drawing.Size(196, 26);
            this.txtDeleteSaloon.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "SaloonID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddSaloon);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtAddCapacity);
            this.groupBox1.Controls.Add(this.txtAddSaloonName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 188);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Session";
            // 
            // btnAddSaloon
            // 
            this.btnAddSaloon.Location = new System.Drawing.Point(137, 132);
            this.btnAddSaloon.Name = "btnAddSaloon";
            this.btnAddSaloon.Size = new System.Drawing.Size(196, 34);
            this.btnAddSaloon.TabIndex = 4;
            this.btnAddSaloon.Text = "Add Saloon";
            this.btnAddSaloon.UseVisualStyleBackColor = true;
            this.btnAddSaloon.Click += new System.EventHandler(this.btnAddSaloon_Click);
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
            // txtAddCapacity
            // 
            this.txtAddCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddCapacity.Location = new System.Drawing.Point(137, 82);
            this.txtAddCapacity.Name = "txtAddCapacity";
            this.txtAddCapacity.Size = new System.Drawing.Size(196, 26);
            this.txtAddCapacity.TabIndex = 1;
            // 
            // txtAddSaloonName
            // 
            this.txtAddSaloonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddSaloonName.Location = new System.Drawing.Point(137, 37);
            this.txtAddSaloonName.Name = "txtAddSaloonName";
            this.txtAddSaloonName.Size = new System.Drawing.Size(196, 26);
            this.txtAddSaloonName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capacity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "SaloonName:";
            // 
            // SaloonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 549);
            this.Controls.Add(this.btnListSession);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaloonForm";
            this.Text = "SaloonForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListSession;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateSaloon;
        private System.Windows.Forms.TextBox txtUpdateSaloonName;
        private System.Windows.Forms.TextBox txtUpdateSaloonID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteSaloon;
        private System.Windows.Forms.TextBox txtDeleteSaloon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddSaloon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddSaloonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateCapacity;
        private System.Windows.Forms.Label label4;
    }
}
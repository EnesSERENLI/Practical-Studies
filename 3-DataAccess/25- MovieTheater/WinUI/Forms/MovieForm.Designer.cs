namespace WinUI.Forms
{
    partial class MovieForm
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
            this.rbDurationDesc = new System.Windows.Forms.RadioButton();
            this.rbDurationAcs = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbSelectCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalMovie = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCategory = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAllMovies = new System.Windows.Forms.Button();
            this.btnMyTopFive = new System.Windows.Forms.Button();
            this.btnSerialMovies = new System.Windows.Forms.Button();
            this.btnWatchBeforeDie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDurationDesc
            // 
            this.rbDurationDesc.AutoSize = true;
            this.rbDurationDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbDurationDesc.Location = new System.Drawing.Point(1099, 26);
            this.rbDurationDesc.Name = "rbDurationDesc";
            this.rbDurationDesc.Size = new System.Drawing.Size(152, 19);
            this.rbDurationDesc.TabIndex = 9;
            this.rbDurationDesc.TabStop = true;
            this.rbDurationDesc.Text = "Desc Order by Duration";
            this.rbDurationDesc.UseVisualStyleBackColor = true;
            this.rbDurationDesc.CheckedChanged += new System.EventHandler(this.rbDurationDesc_CheckedChanged);
            // 
            // rbDurationAcs
            // 
            this.rbDurationAcs.AutoSize = true;
            this.rbDurationAcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbDurationAcs.Location = new System.Drawing.Point(952, 26);
            this.rbDurationAcs.Name = "rbDurationAcs";
            this.rbDurationAcs.Size = new System.Drawing.Size(143, 19);
            this.rbDurationAcs.TabIndex = 10;
            this.rbDurationAcs.TabStop = true;
            this.rbDurationAcs.Text = "Asc Order by Duration";
            this.rbDurationAcs.UseVisualStyleBackColor = true;
            this.rbDurationAcs.CheckedChanged += new System.EventHandler(this.rbDurationAcs_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(435, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(511, 26);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(365, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Search:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(340, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(909, 409);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MovieID";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MovieName";
            this.columnHeader2.Width = 207;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 425;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Duration";
            this.columnHeader4.Width = 118;
            // 
            // cmbSelectCategory
            // 
            this.cmbSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSelectCategory.FormattingEnabled = true;
            this.cmbSelectCategory.Location = new System.Drawing.Point(91, 20);
            this.cmbSelectCategory.Name = "cmbSelectCategory";
            this.cmbSelectCategory.Size = new System.Drawing.Size(235, 28);
            this.cmbSelectCategory.TabIndex = 17;
            this.cmbSelectCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCategory_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Category";
            // 
            // lblTotalMovie
            // 
            this.lblTotalMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalMovie.Location = new System.Drawing.Point(38, 369);
            this.lblTotalMovie.Name = "lblTotalMovie";
            this.lblTotalMovie.Size = new System.Drawing.Size(120, 100);
            this.lblTotalMovie.TabIndex = 13;
            this.lblTotalMovie.Text = "0";
            this.lblTotalMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(46, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Movies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(187, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Category";
            // 
            // lblTotalCategory
            // 
            this.lblTotalCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCategory.Location = new System.Drawing.Point(183, 369);
            this.lblTotalCategory.Name = "lblTotalCategory";
            this.lblTotalCategory.Size = new System.Drawing.Size(120, 100);
            this.lblTotalCategory.TabIndex = 13;
            this.lblTotalCategory.Text = "0";
            this.lblTotalCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAllMovies);
            this.groupBox1.Controls.Add(this.btnMyTopFive);
            this.groupBox1.Controls.Add(this.btnSerialMovies);
            this.groupBox1.Controls.Add(this.btnWatchBeforeDie);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 277);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advices";
            // 
            // btnAllMovies
            // 
            this.btnAllMovies.Location = new System.Drawing.Point(6, 216);
            this.btnAllMovies.Name = "btnAllMovies";
            this.btnAllMovies.Size = new System.Drawing.Size(304, 38);
            this.btnAllMovies.TabIndex = 0;
            this.btnAllMovies.Text = "All Movies";
            this.btnAllMovies.UseVisualStyleBackColor = true;
            this.btnAllMovies.Click += new System.EventHandler(this.btnAllMovies_Click);
            // 
            // btnMyTopFive
            // 
            this.btnMyTopFive.Location = new System.Drawing.Point(6, 156);
            this.btnMyTopFive.Name = "btnMyTopFive";
            this.btnMyTopFive.Size = new System.Drawing.Size(304, 38);
            this.btnMyTopFive.TabIndex = 0;
            this.btnMyTopFive.Text = "My Top Five Movies";
            this.btnMyTopFive.UseVisualStyleBackColor = true;
            this.btnMyTopFive.Click += new System.EventHandler(this.btnMyTopFive_Click);
            // 
            // btnSerialMovies
            // 
            this.btnSerialMovies.Location = new System.Drawing.Point(6, 100);
            this.btnSerialMovies.Name = "btnSerialMovies";
            this.btnSerialMovies.Size = new System.Drawing.Size(304, 38);
            this.btnSerialMovies.TabIndex = 0;
            this.btnSerialMovies.Text = "Serial Movies";
            this.btnSerialMovies.UseVisualStyleBackColor = true;
            this.btnSerialMovies.Click += new System.EventHandler(this.btnSerialMovies_Click);
            // 
            // btnWatchBeforeDie
            // 
            this.btnWatchBeforeDie.Location = new System.Drawing.Point(6, 45);
            this.btnWatchBeforeDie.Name = "btnWatchBeforeDie";
            this.btnWatchBeforeDie.Size = new System.Drawing.Size(304, 38);
            this.btnWatchBeforeDie.TabIndex = 0;
            this.btnWatchBeforeDie.Text = "Watch before You Die";
            this.btnWatchBeforeDie.UseVisualStyleBackColor = true;
            this.btnWatchBeforeDie.Click += new System.EventHandler(this.btnWatchBeforeDie_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbSelectCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalMovie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbDurationDesc);
            this.Controls.Add(this.rbDurationAcs);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView1);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDurationDesc;
        private System.Windows.Forms.RadioButton rbDurationAcs;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cmbSelectCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalMovie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMyTopFive;
        private System.Windows.Forms.Button btnSerialMovies;
        private System.Windows.Forms.Button btnWatchBeforeDie;
        private System.Windows.Forms.Button btnAllMovies;
    }
}
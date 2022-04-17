namespace WinUI
{
    partial class LoginForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieDirectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saloonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theathersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.moviesCategoriesToolStripMenuItem,
            this.sessionsToolStripMenuItem,
            this.weeksToolStripMenuItem,
            this.saloonsToolStripMenuItem,
            this.theathersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieDirectionToolStripMenuItem});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // movieDirectionToolStripMenuItem
            // 
            this.movieDirectionToolStripMenuItem.Name = "movieDirectionToolStripMenuItem";
            this.movieDirectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.movieDirectionToolStripMenuItem.Text = "Movie Direction";
            this.movieDirectionToolStripMenuItem.Click += new System.EventHandler(this.movieDirectionToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoryToolStripMenuItem.Text = "Categories";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // moviesCategoriesToolStripMenuItem
            // 
            this.moviesCategoriesToolStripMenuItem.Name = "moviesCategoriesToolStripMenuItem";
            this.moviesCategoriesToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.moviesCategoriesToolStripMenuItem.Text = "MoviesCategories";
            this.moviesCategoriesToolStripMenuItem.Click += new System.EventHandler(this.moviesCategoriesToolStripMenuItem_Click);
            // 
            // sessionsToolStripMenuItem
            // 
            this.sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            this.sessionsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sessionsToolStripMenuItem.Text = "Sessions";
            this.sessionsToolStripMenuItem.Click += new System.EventHandler(this.sessionsToolStripMenuItem_Click);
            // 
            // weeksToolStripMenuItem
            // 
            this.weeksToolStripMenuItem.Name = "weeksToolStripMenuItem";
            this.weeksToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.weeksToolStripMenuItem.Text = "Weeks";
            this.weeksToolStripMenuItem.Click += new System.EventHandler(this.weeksToolStripMenuItem_Click);
            // 
            // saloonsToolStripMenuItem
            // 
            this.saloonsToolStripMenuItem.Name = "saloonsToolStripMenuItem";
            this.saloonsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.saloonsToolStripMenuItem.Text = "Saloons";
            this.saloonsToolStripMenuItem.Click += new System.EventHandler(this.saloonsToolStripMenuItem_Click);
            // 
            // theathersToolStripMenuItem
            // 
            this.theathersToolStripMenuItem.Name = "theathersToolStripMenuItem";
            this.theathersToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.theathersToolStripMenuItem.Text = "Theathers";
            this.theathersToolStripMenuItem.Click += new System.EventHandler(this.theathersToolStripMenuItem_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 466);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieDirectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saloonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theathersToolStripMenuItem;
    }
}


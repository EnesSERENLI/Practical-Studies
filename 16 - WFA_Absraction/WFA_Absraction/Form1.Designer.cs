namespace WFA_Absraction
{
    partial class Form1
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
            this.lstMuzisyenler = new System.Windows.Forms.ListBox();
            this.lstKlasikGitar = new System.Windows.Forms.ListBox();
            this.lstKeman = new System.Windows.Forms.ListBox();
            this.lstPiyano = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstMuzisyenler
            // 
            this.lstMuzisyenler.FormattingEnabled = true;
            this.lstMuzisyenler.Location = new System.Drawing.Point(12, 12);
            this.lstMuzisyenler.Name = "lstMuzisyenler";
            this.lstMuzisyenler.Size = new System.Drawing.Size(139, 212);
            this.lstMuzisyenler.TabIndex = 0;
            // 
            // lstKlasikGitar
            // 
            this.lstKlasikGitar.FormattingEnabled = true;
            this.lstKlasikGitar.Location = new System.Drawing.Point(157, 12);
            this.lstKlasikGitar.Name = "lstKlasikGitar";
            this.lstKlasikGitar.Size = new System.Drawing.Size(139, 212);
            this.lstKlasikGitar.TabIndex = 0;
            // 
            // lstKeman
            // 
            this.lstKeman.FormattingEnabled = true;
            this.lstKeman.Location = new System.Drawing.Point(302, 12);
            this.lstKeman.Name = "lstKeman";
            this.lstKeman.Size = new System.Drawing.Size(139, 212);
            this.lstKeman.TabIndex = 0;
            // 
            // lstPiyano
            // 
            this.lstPiyano.FormattingEnabled = true;
            this.lstPiyano.Location = new System.Drawing.Point(447, 12);
            this.lstPiyano.Name = "lstPiyano";
            this.lstPiyano.Size = new System.Drawing.Size(139, 212);
            this.lstPiyano.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPiyano);
            this.Controls.Add(this.lstKeman);
            this.Controls.Add(this.lstKlasikGitar);
            this.Controls.Add(this.lstMuzisyenler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMuzisyenler;
        private System.Windows.Forms.ListBox lstKlasikGitar;
        private System.Windows.Forms.ListBox lstKeman;
        private System.Windows.Forms.ListBox lstPiyano;
    }
}


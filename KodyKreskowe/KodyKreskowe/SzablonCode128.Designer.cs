﻿namespace KodyKreskowe {
    partial class SzablonCode128 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SzablonCode128));
            this.TextBoxInfoNadKodem = new System.Windows.Forms.TextBox();
            this.PictureBoxKod = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKod)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxInfoNadKodem
            // 
            this.TextBoxInfoNadKodem.Location = new System.Drawing.Point(12, 12);
            this.TextBoxInfoNadKodem.Name = "TextBoxInfoNadKodem";
            this.TextBoxInfoNadKodem.ReadOnly = true;
            this.TextBoxInfoNadKodem.Size = new System.Drawing.Size(260, 20);
            this.TextBoxInfoNadKodem.TabIndex = 0;
            // 
            // PictureBoxKod
            // 
            this.PictureBoxKod.Location = new System.Drawing.Point(12, 38);
            this.PictureBoxKod.Name = "PictureBoxKod";
            this.PictureBoxKod.Size = new System.Drawing.Size(370, 141);
            this.PictureBoxKod.TabIndex = 1;
            this.PictureBoxKod.TabStop = false;
            this.PictureBoxKod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxKod_MouseClick);
            // 
            // SzablonCode128
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 191);
            this.Controls.Add(this.PictureBoxKod);
            this.Controls.Add(this.TextBoxInfoNadKodem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 230);
            this.MinimumSize = new System.Drawing.Size(410, 230);
            this.Name = "SzablonCode128";
            this.Text = "Code128";
            this.Load += new System.EventHandler(this.SzablonCode128_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SzablonCode128_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxInfoNadKodem;
        private System.Windows.Forms.PictureBox PictureBoxKod;
    }
}
namespace KodyKreskowe {
    partial class SzablonEan13 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SzablonEan13));
            this.PictureBoxKod = new System.Windows.Forms.PictureBox();
            this.TextBoxInfoNadKodem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKod)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxKod
            // 
            this.PictureBoxKod.Location = new System.Drawing.Point(12, 38);
            this.PictureBoxKod.Name = "PictureBoxKod";
            this.PictureBoxKod.Size = new System.Drawing.Size(260, 111);
            this.PictureBoxKod.TabIndex = 0;
            this.PictureBoxKod.TabStop = false;
            this.PictureBoxKod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxKod_MouseClick);
            // 
            // TextBoxInfoNadKodem
            // 
            this.TextBoxInfoNadKodem.Location = new System.Drawing.Point(12, 12);
            this.TextBoxInfoNadKodem.Name = "TextBoxInfoNadKodem";
            this.TextBoxInfoNadKodem.ReadOnly = true;
            this.TextBoxInfoNadKodem.Size = new System.Drawing.Size(132, 20);
            this.TextBoxInfoNadKodem.TabIndex = 1;
            // 
            // SzablonEan13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.TextBoxInfoNadKodem);
            this.Controls.Add(this.PictureBoxKod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "SzablonEan13";
            this.Text = "Ean13";
            this.Load += new System.EventHandler(this.SzablonEan13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxKod;
        private System.Windows.Forms.TextBox TextBoxInfoNadKodem;
    }
}
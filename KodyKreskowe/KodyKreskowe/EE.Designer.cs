namespace KodyKreskowe {
    partial class EE {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EE));
            this.SuspendLayout();
            // 
            // EE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KodyKreskowe.Properties.Resources.EasterEgg;
            this.ClientSize = new System.Drawing.Size(394, 391);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 430);
            this.MinimumSize = new System.Drawing.Size(410, 430);
            this.Name = "EE";
            this.Text = "EE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EE_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
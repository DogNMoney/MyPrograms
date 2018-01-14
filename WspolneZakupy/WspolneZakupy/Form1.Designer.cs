namespace WspolneZakupy {
    partial class WspolneZakupy {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            this.DoladujButton = new System.Windows.Forms.Button();
            this.WartoscDlaOperacjiBox = new System.Windows.Forms.TextBox();
            this.KomunikatLabel = new System.Windows.Forms.Label();
            this.FunduszeLabel = new System.Windows.Forms.Label();
            this.FunduszeWartoscLabel = new System.Windows.Forms.Label();
            this.OdejmijButton = new System.Windows.Forms.Button();
            this.UwagiBox = new System.Windows.Forms.TextBox();
            this.OpisUwagLabel = new System.Windows.Forms.Label();
            this.OpisKwotyLabel = new System.Windows.Forms.Label();
            this.HistoriaZPlikuBox = new System.Windows.Forms.TextBox();
            this.HistoriaOperacjiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoladujButton
            // 
            this.DoladujButton.Location = new System.Drawing.Point(115, 225);
            this.DoladujButton.Name = "DoladujButton";
            this.DoladujButton.Size = new System.Drawing.Size(75, 23);
            this.DoladujButton.TabIndex = 3;
            this.DoladujButton.Text = "&Doładuj";
            this.DoladujButton.UseVisualStyleBackColor = true;
            this.DoladujButton.Click += new System.EventHandler(this.DoladujButton_Click);
            // 
            // WartoscDlaOperacjiBox
            // 
            this.WartoscDlaOperacjiBox.Location = new System.Drawing.Point(12, 227);
            this.WartoscDlaOperacjiBox.Name = "WartoscDlaOperacjiBox";
            this.WartoscDlaOperacjiBox.Size = new System.Drawing.Size(97, 20);
            this.WartoscDlaOperacjiBox.TabIndex = 2;
            this.WartoscDlaOperacjiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WartoscDlaOperacjiBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KwotaDoDoladowaniaBox_KeyPress);
            // 
            // KomunikatLabel
            // 
            this.KomunikatLabel.AutoSize = true;
            this.KomunikatLabel.BackColor = System.Drawing.Color.Red;
            this.KomunikatLabel.Location = new System.Drawing.Point(12, 9);
            this.KomunikatLabel.Name = "KomunikatLabel";
            this.KomunikatLabel.Size = new System.Drawing.Size(192, 13);
            this.KomunikatLabel.TabIndex = 0;
            this.KomunikatLabel.Text = "Mała ilość gotówki, doładuj pieniądzę!!";
            this.KomunikatLabel.Visible = false;
            // 
            // FunduszeLabel
            // 
            this.FunduszeLabel.AutoSize = true;
            this.FunduszeLabel.Location = new System.Drawing.Point(12, 38);
            this.FunduszeLabel.Name = "FunduszeLabel";
            this.FunduszeLabel.Size = new System.Drawing.Size(56, 13);
            this.FunduszeLabel.TabIndex = 0;
            this.FunduszeLabel.Text = "Fundusze:";
            // 
            // FunduszeWartoscLabel
            // 
            this.FunduszeWartoscLabel.Location = new System.Drawing.Point(74, 38);
            this.FunduszeWartoscLabel.Name = "FunduszeWartoscLabel";
            this.FunduszeWartoscLabel.Size = new System.Drawing.Size(35, 13);
            this.FunduszeWartoscLabel.TabIndex = 0;
            this.FunduszeWartoscLabel.Text = "0";
            this.FunduszeWartoscLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OdejmijButton
            // 
            this.OdejmijButton.Location = new System.Drawing.Point(200, 225);
            this.OdejmijButton.Name = "OdejmijButton";
            this.OdejmijButton.Size = new System.Drawing.Size(75, 23);
            this.OdejmijButton.TabIndex = 4;
            this.OdejmijButton.Text = "&Odejmij";
            this.OdejmijButton.UseVisualStyleBackColor = true;
            this.OdejmijButton.Click += new System.EventHandler(this.OdejmijButton_Click);
            // 
            // UwagiBox
            // 
            this.UwagiBox.Location = new System.Drawing.Point(12, 188);
            this.UwagiBox.Name = "UwagiBox";
            this.UwagiBox.Size = new System.Drawing.Size(260, 20);
            this.UwagiBox.TabIndex = 1;
            // 
            // OpisUwagLabel
            // 
            this.OpisUwagLabel.AutoSize = true;
            this.OpisUwagLabel.Location = new System.Drawing.Point(12, 172);
            this.OpisUwagLabel.Name = "OpisUwagLabel";
            this.OpisUwagLabel.Size = new System.Drawing.Size(115, 13);
            this.OpisUwagLabel.TabIndex = 0;
            this.OpisUwagLabel.Text = "Komentarz do operacji:";
            // 
            // OpisKwotyLabel
            // 
            this.OpisKwotyLabel.AutoSize = true;
            this.OpisKwotyLabel.Location = new System.Drawing.Point(12, 211);
            this.OpisKwotyLabel.Name = "OpisKwotyLabel";
            this.OpisKwotyLabel.Size = new System.Drawing.Size(40, 13);
            this.OpisKwotyLabel.TabIndex = 0;
            this.OpisKwotyLabel.Text = "Kwota:";
            // 
            // HistoriaZPlikuBox
            // 
            this.HistoriaZPlikuBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.HistoriaZPlikuBox.Location = new System.Drawing.Point(12, 75);
            this.HistoriaZPlikuBox.Multiline = true;
            this.HistoriaZPlikuBox.Name = "HistoriaZPlikuBox";
            this.HistoriaZPlikuBox.ReadOnly = true;
            this.HistoriaZPlikuBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HistoriaZPlikuBox.Size = new System.Drawing.Size(260, 80);
            this.HistoriaZPlikuBox.TabIndex = 0;
            this.HistoriaZPlikuBox.TabStop = false;
            // 
            // HistoriaOperacjiLabel
            // 
            this.HistoriaOperacjiLabel.AutoSize = true;
            this.HistoriaOperacjiLabel.Location = new System.Drawing.Point(12, 59);
            this.HistoriaOperacjiLabel.Name = "HistoriaOperacjiLabel";
            this.HistoriaOperacjiLabel.Size = new System.Drawing.Size(85, 13);
            this.HistoriaOperacjiLabel.TabIndex = 0;
            this.HistoriaOperacjiLabel.Text = "Historia operacji:";
            // 
            // WspolneZakupy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.HistoriaOperacjiLabel);
            this.Controls.Add(this.HistoriaZPlikuBox);
            this.Controls.Add(this.OpisKwotyLabel);
            this.Controls.Add(this.OpisUwagLabel);
            this.Controls.Add(this.UwagiBox);
            this.Controls.Add(this.OdejmijButton);
            this.Controls.Add(this.FunduszeWartoscLabel);
            this.Controls.Add(this.FunduszeLabel);
            this.Controls.Add(this.KomunikatLabel);
            this.Controls.Add(this.WartoscDlaOperacjiBox);
            this.Controls.Add(this.DoladujButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "WspolneZakupy";
            this.Text = "WspolneZakupy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoladujButton;
        private System.Windows.Forms.TextBox WartoscDlaOperacjiBox;
        private System.Windows.Forms.Label KomunikatLabel;
        private System.Windows.Forms.Label FunduszeLabel;
        private System.Windows.Forms.Label FunduszeWartoscLabel;
        private System.Windows.Forms.Button OdejmijButton;
        private System.Windows.Forms.TextBox UwagiBox;
        private System.Windows.Forms.Label OpisUwagLabel;
        private System.Windows.Forms.Label OpisKwotyLabel;
        private System.Windows.Forms.TextBox HistoriaZPlikuBox;
        private System.Windows.Forms.Label HistoriaOperacjiLabel;
    }
}


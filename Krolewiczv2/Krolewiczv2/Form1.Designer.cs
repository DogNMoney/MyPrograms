namespace Krolewiczv2 {
    partial class KrolewiczApp {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KrolewiczApp));
            this.LabelZamawiajacy = new System.Windows.Forms.Label();
            this.TextBoxZamawajacy = new System.Windows.Forms.TextBox();
            this.LabelZestaw = new System.Windows.Forms.Label();
            this.LabelGlowne = new System.Windows.Forms.Label();
            this.ZupyLabel = new System.Windows.Forms.Label();
            this.LabelDodatkowe = new System.Windows.Forms.Label();
            this.TextBoxZestaw = new System.Windows.Forms.TextBox();
            this.TextBoxGlowne = new System.Windows.Forms.TextBox();
            this.TextBoxZupy = new System.Windows.Forms.TextBox();
            this.TextBoxDodatkowe = new System.Windows.Forms.TextBox();
            this.LabelNaleznosc = new System.Windows.Forms.Label();
            this.LabelNaleznoscWartosc = new System.Windows.Forms.Label();
            this.ButtonZamow = new System.Windows.Forms.Button();
            this.ButtonZen = new System.Windows.Forms.Button();
            this.TextBoxHistoriaZamowien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelZamawiajacy
            // 
            this.LabelZamawiajacy.AutoSize = true;
            this.LabelZamawiajacy.Location = new System.Drawing.Point(12, 9);
            this.LabelZamawiajacy.Name = "LabelZamawiajacy";
            this.LabelZamawiajacy.Size = new System.Drawing.Size(72, 13);
            this.LabelZamawiajacy.TabIndex = 0;
            this.LabelZamawiajacy.Text = "Zamawiający:";
            // 
            // TextBoxZamawajacy
            // 
            this.TextBoxZamawajacy.Location = new System.Drawing.Point(90, 6);
            this.TextBoxZamawajacy.Name = "TextBoxZamawajacy";
            this.TextBoxZamawajacy.Size = new System.Drawing.Size(182, 20);
            this.TextBoxZamawajacy.TabIndex = 1;
            // 
            // LabelZestaw
            // 
            this.LabelZestaw.AutoSize = true;
            this.LabelZestaw.Location = new System.Drawing.Point(12, 40);
            this.LabelZestaw.Name = "LabelZestaw";
            this.LabelZestaw.Size = new System.Drawing.Size(45, 13);
            this.LabelZestaw.TabIndex = 0;
            this.LabelZestaw.Text = "Zestaw:";
            // 
            // LabelGlowne
            // 
            this.LabelGlowne.AutoSize = true;
            this.LabelGlowne.Location = new System.Drawing.Point(12, 65);
            this.LabelGlowne.Name = "LabelGlowne";
            this.LabelGlowne.Size = new System.Drawing.Size(48, 13);
            this.LabelGlowne.TabIndex = 0;
            this.LabelGlowne.Text = "Główne:";
            // 
            // ZupyLabel
            // 
            this.ZupyLabel.AutoSize = true;
            this.ZupyLabel.Location = new System.Drawing.Point(12, 90);
            this.ZupyLabel.Name = "ZupyLabel";
            this.ZupyLabel.Size = new System.Drawing.Size(34, 13);
            this.ZupyLabel.TabIndex = 0;
            this.ZupyLabel.Text = "Zupy:";
            // 
            // LabelDodatkowe
            // 
            this.LabelDodatkowe.AutoSize = true;
            this.LabelDodatkowe.Location = new System.Drawing.Point(12, 115);
            this.LabelDodatkowe.Name = "LabelDodatkowe";
            this.LabelDodatkowe.Size = new System.Drawing.Size(65, 13);
            this.LabelDodatkowe.TabIndex = 0;
            this.LabelDodatkowe.Text = "Dodatkowe:";
            // 
            // TextBoxZestaw
            // 
            this.TextBoxZestaw.Location = new System.Drawing.Point(90, 37);
            this.TextBoxZestaw.Name = "TextBoxZestaw";
            this.TextBoxZestaw.Size = new System.Drawing.Size(50, 20);
            this.TextBoxZestaw.TabIndex = 2;
            this.TextBoxZestaw.Text = "0";
            this.TextBoxZestaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxZestaw.TextChanged += new System.EventHandler(this.TextBoxZestaw_TextChanged);
            this.TextBoxZestaw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxZestaw_KeyPress);
            // 
            // TextBoxGlowne
            // 
            this.TextBoxGlowne.Location = new System.Drawing.Point(90, 62);
            this.TextBoxGlowne.Name = "TextBoxGlowne";
            this.TextBoxGlowne.Size = new System.Drawing.Size(50, 20);
            this.TextBoxGlowne.TabIndex = 3;
            this.TextBoxGlowne.Text = "0";
            this.TextBoxGlowne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxGlowne.TextChanged += new System.EventHandler(this.TextBoxGlowne_TextChanged);
            this.TextBoxGlowne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxGlowne_KeyPress);
            // 
            // TextBoxZupy
            // 
            this.TextBoxZupy.Location = new System.Drawing.Point(90, 87);
            this.TextBoxZupy.Name = "TextBoxZupy";
            this.TextBoxZupy.Size = new System.Drawing.Size(50, 20);
            this.TextBoxZupy.TabIndex = 4;
            this.TextBoxZupy.Text = "0";
            this.TextBoxZupy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxZupy.TextChanged += new System.EventHandler(this.TextBoxZupy_TextChanged);
            this.TextBoxZupy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxZupy_KeyPress);
            // 
            // TextBoxDodatkowe
            // 
            this.TextBoxDodatkowe.Location = new System.Drawing.Point(90, 112);
            this.TextBoxDodatkowe.Name = "TextBoxDodatkowe";
            this.TextBoxDodatkowe.Size = new System.Drawing.Size(50, 20);
            this.TextBoxDodatkowe.TabIndex = 5;
            this.TextBoxDodatkowe.Text = "0";
            this.TextBoxDodatkowe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxDodatkowe.TextChanged += new System.EventHandler(this.TextBoxDodatkowe_TextChanged);
            this.TextBoxDodatkowe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDodatkowe_KeyPress);
            // 
            // LabelNaleznosc
            // 
            this.LabelNaleznosc.AutoSize = true;
            this.LabelNaleznosc.Location = new System.Drawing.Point(156, 40);
            this.LabelNaleznosc.Name = "LabelNaleznosc";
            this.LabelNaleznosc.Size = new System.Drawing.Size(60, 13);
            this.LabelNaleznosc.TabIndex = 0;
            this.LabelNaleznosc.Text = "Należność:";
            // 
            // LabelNaleznoscWartosc
            // 
            this.LabelNaleznoscWartosc.AutoSize = true;
            this.LabelNaleznoscWartosc.Location = new System.Drawing.Point(237, 40);
            this.LabelNaleznoscWartosc.Name = "LabelNaleznoscWartosc";
            this.LabelNaleznoscWartosc.Size = new System.Drawing.Size(13, 13);
            this.LabelNaleznoscWartosc.TabIndex = 0;
            this.LabelNaleznoscWartosc.Text = "0";
            // 
            // ButtonZamow
            // 
            this.ButtonZamow.Location = new System.Drawing.Point(159, 60);
            this.ButtonZamow.Name = "ButtonZamow";
            this.ButtonZamow.Size = new System.Drawing.Size(75, 23);
            this.ButtonZamow.TabIndex = 6;
            this.ButtonZamow.Text = "&Zamów";
            this.ButtonZamow.UseVisualStyleBackColor = true;
            this.ButtonZamow.Click += new System.EventHandler(this.ButtonZamow_Click);
            // 
            // ButtonZen
            // 
            this.ButtonZen.Location = new System.Drawing.Point(159, 85);
            this.ButtonZen.Name = "ButtonZen";
            this.ButtonZen.Size = new System.Drawing.Size(75, 23);
            this.ButtonZen.TabIndex = 7;
            this.ButtonZen.Text = "Ż&eń";
            this.ButtonZen.UseVisualStyleBackColor = true;
            this.ButtonZen.Click += new System.EventHandler(this.ButtonZen_Click);
            // 
            // TextBoxHistoriaZamowien
            // 
            this.TextBoxHistoriaZamowien.Location = new System.Drawing.Point(15, 138);
            this.TextBoxHistoriaZamowien.Multiline = true;
            this.TextBoxHistoriaZamowien.Name = "TextBoxHistoriaZamowien";
            this.TextBoxHistoriaZamowien.ReadOnly = true;
            this.TextBoxHistoriaZamowien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxHistoriaZamowien.Size = new System.Drawing.Size(257, 311);
            this.TextBoxHistoriaZamowien.TabIndex = 0;
            this.TextBoxHistoriaZamowien.TabStop = false;
            // 
            // KrolewiczApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.TextBoxHistoriaZamowien);
            this.Controls.Add(this.ButtonZen);
            this.Controls.Add(this.ButtonZamow);
            this.Controls.Add(this.LabelNaleznoscWartosc);
            this.Controls.Add(this.LabelNaleznosc);
            this.Controls.Add(this.TextBoxDodatkowe);
            this.Controls.Add(this.TextBoxZupy);
            this.Controls.Add(this.TextBoxGlowne);
            this.Controls.Add(this.TextBoxZestaw);
            this.Controls.Add(this.LabelDodatkowe);
            this.Controls.Add(this.ZupyLabel);
            this.Controls.Add(this.LabelGlowne);
            this.Controls.Add(this.LabelZestaw);
            this.Controls.Add(this.TextBoxZamawajacy);
            this.Controls.Add(this.LabelZamawiajacy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "KrolewiczApp";
            this.Text = "Królewicz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelZamawiajacy;
        private System.Windows.Forms.TextBox TextBoxZamawajacy;
        private System.Windows.Forms.Label LabelZestaw;
        private System.Windows.Forms.Label LabelGlowne;
        private System.Windows.Forms.Label ZupyLabel;
        private System.Windows.Forms.Label LabelDodatkowe;
        private System.Windows.Forms.TextBox TextBoxZestaw;
        private System.Windows.Forms.TextBox TextBoxGlowne;
        private System.Windows.Forms.TextBox TextBoxZupy;
        private System.Windows.Forms.TextBox TextBoxDodatkowe;
        private System.Windows.Forms.Label LabelNaleznosc;
        private System.Windows.Forms.Label LabelNaleznoscWartosc;
        private System.Windows.Forms.Button ButtonZamow;
        private System.Windows.Forms.Button ButtonZen;
        private System.Windows.Forms.TextBox TextBoxHistoriaZamowien;
    }
}


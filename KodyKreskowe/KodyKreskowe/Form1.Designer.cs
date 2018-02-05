namespace KodyKreskowe {
    partial class KodyKreskowe {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KodyKreskowe));
            this.LabelDokonajWyboru = new System.Windows.Forms.Label();
            this.RadioButtonEan13 = new System.Windows.Forms.RadioButton();
            this.RadioButtonCode128 = new System.Windows.Forms.RadioButton();
            this.RadioButtonEan128 = new System.Windows.Forms.RadioButton();
            this.LabelKodDoWygenerowaniaOpis = new System.Windows.Forms.Label();
            this.ButtonGenerujKod = new System.Windows.Forms.Button();
            this.TextBoxOpisNadKodem = new System.Windows.Forms.TextBox();
            this.LabelOpisNadTextBoxOpisu = new System.Windows.Forms.Label();
            this.ComboBoxKodDoWygenerowaniaWartosc = new System.Windows.Forms.ComboBox();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelDokonajWyboru
            // 
            this.LabelDokonajWyboru.AutoSize = true;
            this.LabelDokonajWyboru.Location = new System.Drawing.Point(12, 9);
            this.LabelDokonajWyboru.Name = "LabelDokonajWyboru";
            this.LabelDokonajWyboru.Size = new System.Drawing.Size(209, 13);
            this.LabelDokonajWyboru.TabIndex = 0;
            this.LabelDokonajWyboru.Text = "Wybierz kod kreskowy do wygenerowania:";
            // 
            // RadioButtonEan13
            // 
            this.RadioButtonEan13.AutoSize = true;
            this.RadioButtonEan13.Checked = true;
            this.RadioButtonEan13.Location = new System.Drawing.Point(239, 7);
            this.RadioButtonEan13.Name = "RadioButtonEan13";
            this.RadioButtonEan13.Size = new System.Drawing.Size(56, 17);
            this.RadioButtonEan13.TabIndex = 0;
            this.RadioButtonEan13.TabStop = true;
            this.RadioButtonEan13.Text = "Ean13";
            this.RadioButtonEan13.UseVisualStyleBackColor = true;
            this.RadioButtonEan13.CheckedChanged += new System.EventHandler(this.RadioButtonEan13_CheckedChanged);
            // 
            // RadioButtonCode128
            // 
            this.RadioButtonCode128.AutoSize = true;
            this.RadioButtonCode128.Location = new System.Drawing.Point(311, 7);
            this.RadioButtonCode128.Name = "RadioButtonCode128";
            this.RadioButtonCode128.Size = new System.Drawing.Size(68, 17);
            this.RadioButtonCode128.TabIndex = 0;
            this.RadioButtonCode128.Text = "Code128";
            this.RadioButtonCode128.UseVisualStyleBackColor = true;
            this.RadioButtonCode128.CheckedChanged += new System.EventHandler(this.RadioButtonCode128_CheckedChanged);
            // 
            // RadioButtonEan128
            // 
            this.RadioButtonEan128.AutoSize = true;
            this.RadioButtonEan128.Location = new System.Drawing.Point(397, 7);
            this.RadioButtonEan128.Name = "RadioButtonEan128";
            this.RadioButtonEan128.Size = new System.Drawing.Size(62, 17);
            this.RadioButtonEan128.TabIndex = 0;
            this.RadioButtonEan128.Text = "Ean128";
            this.RadioButtonEan128.UseVisualStyleBackColor = true;
            this.RadioButtonEan128.CheckedChanged += new System.EventHandler(this.RadioButtonEan128_CheckedChanged);
            // 
            // LabelKodDoWygenerowaniaOpis
            // 
            this.LabelKodDoWygenerowaniaOpis.AutoSize = true;
            this.LabelKodDoWygenerowaniaOpis.Location = new System.Drawing.Point(12, 84);
            this.LabelKodDoWygenerowaniaOpis.Name = "LabelKodDoWygenerowaniaOpis";
            this.LabelKodDoWygenerowaniaOpis.Size = new System.Drawing.Size(121, 13);
            this.LabelKodDoWygenerowaniaOpis.TabIndex = 0;
            this.LabelKodDoWygenerowaniaOpis.Text = "Kod do wygenerowania:";
            // 
            // ButtonGenerujKod
            // 
            this.ButtonGenerujKod.Location = new System.Drawing.Point(15, 126);
            this.ButtonGenerujKod.Name = "ButtonGenerujKod";
            this.ButtonGenerujKod.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerujKod.TabIndex = 3;
            this.ButtonGenerujKod.Text = "&Generuj kod";
            this.ButtonGenerujKod.UseVisualStyleBackColor = true;
            this.ButtonGenerujKod.Click += new System.EventHandler(this.ButtonGenerujKod_Click);
            // 
            // TextBoxOpisNadKodem
            // 
            this.TextBoxOpisNadKodem.Location = new System.Drawing.Point(15, 52);
            this.TextBoxOpisNadKodem.MaxLength = 50;
            this.TextBoxOpisNadKodem.Name = "TextBoxOpisNadKodem";
            this.TextBoxOpisNadKodem.Size = new System.Drawing.Size(364, 20);
            this.TextBoxOpisNadKodem.TabIndex = 2;
            // 
            // LabelOpisNadTextBoxOpisu
            // 
            this.LabelOpisNadTextBoxOpisu.AutoSize = true;
            this.LabelOpisNadTextBoxOpisu.Location = new System.Drawing.Point(12, 36);
            this.LabelOpisNadTextBoxOpisu.Name = "LabelOpisNadTextBoxOpisu";
            this.LabelOpisNadTextBoxOpisu.Size = new System.Drawing.Size(87, 13);
            this.LabelOpisNadTextBoxOpisu.TabIndex = 4;
            this.LabelOpisNadTextBoxOpisu.Text = "Opis nad kodem:";
            // 
            // ComboBoxKodDoWygenerowaniaWartosc
            // 
            this.ComboBoxKodDoWygenerowaniaWartosc.FormattingEnabled = true;
            this.ComboBoxKodDoWygenerowaniaWartosc.Location = new System.Drawing.Point(12, 99);
            this.ComboBoxKodDoWygenerowaniaWartosc.Name = "ComboBoxKodDoWygenerowaniaWartosc";
            this.ComboBoxKodDoWygenerowaniaWartosc.Size = new System.Drawing.Size(557, 21);
            this.ComboBoxKodDoWygenerowaniaWartosc.TabIndex = 1;
            this.ComboBoxKodDoWygenerowaniaWartosc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxKodDoWygenerowaniaWartosc_KeyDown);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Location = new System.Drawing.Point(489, 4);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(83, 45);
            this.ButtonHelp.TabIndex = 5;
            this.ButtonHelp.Text = "&Przykładowe kody";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // KodyKreskowe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.ComboBoxKodDoWygenerowaniaWartosc);
            this.Controls.Add(this.LabelOpisNadTextBoxOpisu);
            this.Controls.Add(this.TextBoxOpisNadKodem);
            this.Controls.Add(this.ButtonGenerujKod);
            this.Controls.Add(this.LabelKodDoWygenerowaniaOpis);
            this.Controls.Add(this.RadioButtonEan128);
            this.Controls.Add(this.RadioButtonCode128);
            this.Controls.Add(this.RadioButtonEan13);
            this.Controls.Add(this.LabelDokonajWyboru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 200);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "KodyKreskowe";
            this.Text = "KodyKreskowe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDokonajWyboru;
        private System.Windows.Forms.RadioButton RadioButtonEan13;
        private System.Windows.Forms.RadioButton RadioButtonCode128;
        private System.Windows.Forms.RadioButton RadioButtonEan128;
        private System.Windows.Forms.Label LabelKodDoWygenerowaniaOpis;
        private System.Windows.Forms.Button ButtonGenerujKod;
        private System.Windows.Forms.TextBox TextBoxOpisNadKodem;
        private System.Windows.Forms.Label LabelOpisNadTextBoxOpisu;
        private System.Windows.Forms.ComboBox ComboBoxKodDoWygenerowaniaWartosc;
        private System.Windows.Forms.Button ButtonHelp;
    }
}


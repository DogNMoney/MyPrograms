using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodyKreskowe {
    public partial class KodyKreskowe : Form {
        bool flagaean13 = true;
        bool flagacode128 = false;
        bool flagaean128 = false;

        public KodyKreskowe() {
            InitializeComponent();
        }

        private void RadioButtonEan13_CheckedChanged(object sender, EventArgs e) {
            if (RadioButtonEan13.Checked) {
                flagaean13 = true;
                flagacode128 = false;
                flagaean128 = false;
            }
        }

        private void RadioButtonCode128_CheckedChanged(object sender, EventArgs e) {
            if (RadioButtonCode128.Checked) {
                flagaean13 = false;
                flagacode128 = true;
                flagaean128 = false;
            }
        }

        private void RadioButtonEan128_CheckedChanged(object sender, EventArgs e) {
            if (RadioButtonEan128.Checked) {
                flagaean13 = false;
                flagacode128 = false;
                flagaean128 = true;
            }
        }

        private void ButtonGenerujKod_Click(object sender, EventArgs e) {
            try {
                if (TextBoxKodDoWygenerowaniaWartosc.Text == "" || String.IsNullOrWhiteSpace(TextBoxKodDoWygenerowaniaWartosc.Text) == true ||
                String.IsNullOrEmpty(TextBoxKodDoWygenerowaniaWartosc.Text) == true) {
                    MessageBox.Show("Nie podałeś kodu do wygenerowania!", "Komunikat", MessageBoxButtons.OK);
                } else {
                    if(flagaean13 == true) {
                        if(TextBoxKodDoWygenerowaniaWartosc.Text.Length != 13) {
                            MessageBox.Show("Wprowadzony kod ean13 jest nieprawidłowy!", "Komunikat", MessageBoxButtons.OK);
                        } else {
                            SzablonEan13 wygenerowanyeanform = new SzablonEan13();
                            wygenerowanyeanform.Kod = TextBoxKodDoWygenerowaniaWartosc.Text;
                            wygenerowanyeanform.Informacjanadkodem = TextBoxOpisNadKodem.Text;
                            wygenerowanyeanform.Show();
                        }
                    }
                    if(flagacode128 == true) {
                        SzablonCode128 wygenerowanyeanform = new SzablonCode128();
                        wygenerowanyeanform.Kod = TextBoxKodDoWygenerowaniaWartosc.Text;
                        wygenerowanyeanform.Informacjanadkodem = TextBoxOpisNadKodem.Text;
                        wygenerowanyeanform.Show();
                    }
                    if(flagaean128 == true) {
                        SzablonEan128 wygenerowanyeanform = new SzablonEan128();
                        wygenerowanyeanform.Kod = TextBoxKodDoWygenerowaniaWartosc.Text;
                        wygenerowanyeanform.Informacjanadkodem = TextBoxOpisNadKodem.Text;
                        wygenerowanyeanform.Show();
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void PictureBoxHelp_MouseClick(object sender, MouseEventArgs e) {
            MessageBox.Show("Okno pomocy dostępne w przyszłej wersji projektu", "Komunikat", MessageBoxButtons.OK);
            //TODO Do zrobienia encyklopedia przykładowych kodów kreskowych
        }
    }
}

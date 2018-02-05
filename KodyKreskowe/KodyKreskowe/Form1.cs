using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodyKreskowe {
    public partial class KodyKreskowe : Form {
        bool flagaean13 = true;
        bool flagacode128 = false;
        bool flagaean128 = false;

        String[] historiaean13;
        String[] historiacode128;
        String[] historiaean128;

        String[] obejscie = { "Wprowadź kod" };

        int licznikGenerowan = 0;

        public void WczytajHistorie() {
            try {
                if (File.Exists("HistoriaEan13.txt")) {
                    historiaean13 = File.ReadAllLines("HistoriaEan13.txt");
                } else {
                    historiaean13 = obejscie;
                }
                if (File.Exists("HistoriaCode128.txt")) {
                    historiacode128 = File.ReadAllLines("HistoriaCode128.txt");
                } else {
                    historiacode128 = obejscie;
                }
                if (File.Exists("HistoriaEan128.txt")) {
                    historiaean128 = File.ReadAllLines("HistoriaEan128.txt");
                } else {
                    historiaean128 = obejscie;
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        public KodyKreskowe() {
            InitializeComponent();
            WczytajHistorie();
            ComboBoxKodDoWygenerowaniaWartosc.DataSource = historiaean13;
            ComboBoxKodDoWygenerowaniaWartosc.Focus();
        }

        private void RadioButtonEan13_CheckedChanged(object sender, EventArgs e) {
            if (RadioButtonEan13.Checked) {
                flagaean13 = true;
                flagacode128 = false;
                flagaean128 = false;
                ComboBoxKodDoWygenerowaniaWartosc.DataSource = historiaean13;
            }
        }

        private void RadioButtonCode128_CheckedChanged(object sender, EventArgs e) {
            if (RadioButtonCode128.Checked) {
                flagaean13 = false;
                flagacode128 = true;
                flagaean128 = false;
                ComboBoxKodDoWygenerowaniaWartosc.DataSource = historiacode128;
            }
        }

        private void RadioButtonEan128_CheckedChanged(object sender, EventArgs e) {
            if (RadioButtonEan128.Checked) {
                flagaean13 = false;
                flagacode128 = false;
                flagaean128 = true;
                ComboBoxKodDoWygenerowaniaWartosc.DataSource = historiaean128;
            }
        }

        public static void ZapamietajKodEan13(String koddopliku) {
            String path = "HistoriaEan13.txt";

            try {
                if (File.Exists(path)) {
                    String[] linesinfile = File.ReadAllLines(path);
                    if (linesinfile.Length >= 20) {
                        linesinfile[0] = koddopliku;
                    }
                    FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(koddopliku);
                    foreach(String line in linesinfile) {
                        sw.WriteLine(line);
                    }
                    sw.Close();
                } else {
                    StreamWriter sw = File.CreateText(path);
                    sw.WriteLine(koddopliku);
                    sw.Close();
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        public static void ZapamietajKodCode128(String koddopliku) {
            String path = "HistoriaCode128.txt";

            try {
                if (File.Exists(path)) {
                    String[] linesinfile = File.ReadAllLines(path);
                    if (linesinfile.Length >= 20) {
                        linesinfile[0] = koddopliku;
                    }
                    FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(koddopliku);
                    foreach (String line in linesinfile) {
                        sw.WriteLine(line);
                    }
                    sw.Close();
                } else {
                    StreamWriter sw = File.CreateText(path);
                    sw.WriteLine(koddopliku);
                    sw.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        public static void ZapamietajKodEan128(String koddopliku) {
            String path = "HistoriaEan128.txt";

            try {
                if (File.Exists(path)) {
                    String[] linesinfile = File.ReadAllLines(path);
                    if (linesinfile.Length >= 20) {
                        linesinfile[0] = koddopliku;
                    }
                    FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(koddopliku);
                    foreach (String line in linesinfile) {
                        sw.WriteLine(line);
                    }
                    sw.Close();
                } else {
                    StreamWriter sw = File.CreateText(path);
                    sw.WriteLine(koddopliku);
                    sw.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        public void GenerujKod() {
            try {
                if (ComboBoxKodDoWygenerowaniaWartosc.Text == "" || String.IsNullOrWhiteSpace(ComboBoxKodDoWygenerowaniaWartosc.Text) == true ||
                String.IsNullOrEmpty(ComboBoxKodDoWygenerowaniaWartosc.Text) == true) {
                    MessageBox.Show("Nie podałeś kodu do wygenerowania!", "Komunikat", MessageBoxButtons.OK);
                } else {
                    licznikGenerowan++;
                    if(licznikGenerowan%10 == 0) {
                        EE easteregg = new EE();
                        easteregg.Show();
                    }
                    if (flagaean13 == true) {
                        if (ComboBoxKodDoWygenerowaniaWartosc.Text.Length != 13) {
                            MessageBox.Show("Wprowadzony kod ean13 jest nieprawidłowy!", "Komunikat", MessageBoxButtons.OK);
                        } else {
                            if (!historiaean13.Contains(ComboBoxKodDoWygenerowaniaWartosc.Text)) {
                                ZapamietajKodEan13(ComboBoxKodDoWygenerowaniaWartosc.Text);
                            }
                            SzablonEan13 wygenerowanyeanform = new SzablonEan13();
                            wygenerowanyeanform.Kod = ComboBoxKodDoWygenerowaniaWartosc.Text;
                            wygenerowanyeanform.Informacjanadkodem = TextBoxOpisNadKodem.Text;
                            wygenerowanyeanform.Show();
                        }
                    }
                    if (flagacode128 == true) {
                        if (!historiacode128.Contains(ComboBoxKodDoWygenerowaniaWartosc.Text)) {
                            ZapamietajKodCode128(ComboBoxKodDoWygenerowaniaWartosc.Text);
                        }
                        SzablonCode128 wygenerowanyeanform = new SzablonCode128();
                        wygenerowanyeanform.Kod = ComboBoxKodDoWygenerowaniaWartosc.Text;
                        wygenerowanyeanform.Informacjanadkodem = TextBoxOpisNadKodem.Text;
                        wygenerowanyeanform.Show();
                    }
                    if (flagaean128 == true) {
                        if (!historiaean128.Contains(ComboBoxKodDoWygenerowaniaWartosc.Text)) {
                            ZapamietajKodEan128(ComboBoxKodDoWygenerowaniaWartosc.Text);
                        }
                        SzablonEan128 wygenerowanyeanform = new SzablonEan128();
                        wygenerowanyeanform.Kod = ComboBoxKodDoWygenerowaniaWartosc.Text;
                        wygenerowanyeanform.Informacjanadkodem = TextBoxOpisNadKodem.Text;
                        wygenerowanyeanform.Show();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void ButtonGenerujKod_Click(object sender, EventArgs e) {
            GenerujKod();
        }

        private void ComboBoxKodDoWygenerowaniaWartosc_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                GenerujKod();
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e) {
            HelpForm oknopomocy = new HelpForm();
            oknopomocy.Show();
        }

    }
}

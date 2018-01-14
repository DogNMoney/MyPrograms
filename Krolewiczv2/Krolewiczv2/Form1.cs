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

namespace Krolewiczv2 {
    public partial class KrolewiczApp : Form {
        Stack<Zamawiajacy> stoszamawiajacych = new Stack<Zamawiajacy>();

        private void WyczyscLubStworzPlik() {
            String path = "HistoriaZamowien.txt";

            try {
                if (!File.Exists(path)) {
                    StreamWriter sw = File.CreateText(path);
                    sw.Close();
                } else {
                    FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Close();
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void AktualizujPlikZHistoria(Zamawiajacy zamawiajacy) {
            String path = "HistoriaZamowien.txt";

            try {
                if (!File.Exists(path)) {
                    StreamWriter sw = File.CreateText(path);
                    sw.WriteLine("{0}", zamawiajacy.Nazwa1);
                    sw.WriteLine("Zestawy: {0} Główne: {1} Zupy: {2} Dodatkowe: {3}",
                        zamawiajacy.Zestaw1, zamawiajacy.Glowne1, zamawiajacy.Zupy1, zamawiajacy.Dodatkowe1);
                    sw.WriteLine("----");
                    sw.Close();
                } else {
                    FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine("{0}", zamawiajacy.Nazwa1);
                    sw.WriteLine("Zestawy: {0} Główne: {1} Zupy: {2} Dodatkowe: {3}",
                        zamawiajacy.Zestaw1, zamawiajacy.Glowne1, zamawiajacy.Zupy1, zamawiajacy.Dodatkowe1);
                    sw.WriteLine("----");
                    sw.Close();
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void AktualizujHistorieZPliku() {
            String path = "HistoriaZamowien.txt";

            try {
                this.TextBoxHistoriaZamowien.Text = "";
                if (File.Exists(path)) {
                    String[] lines = File.ReadAllLines(path);
                    foreach(String line in lines) {
                        this.TextBoxHistoriaZamowien.Text += line + "\r\n";
                    }
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void WyczyscPolaIUstawFocus() {
            TextBoxZamawajacy.Text = "";
            TextBoxZestaw.Text = "0";
            TextBoxGlowne.Text = "0";
            TextBoxZupy.Text = "0";
            TextBoxDodatkowe.Text = "0";

            TextBoxZamawajacy.Focus();
        }

        private void DodajKoncoweWartosci(int ilosczestawow, int iloscglownych, int ilosczup, int iloscdodatkowych) {
            String path = "HistoriaZamowien.txt";
            
            if (File.Exists(path)) {
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Podsumowanie zamówienia:");
                sw.WriteLine("Zestawy: {0} Główne: {1} Zupy: {2} Dodatkowe: {3}", ilosczestawow, iloscglownych,
                                                                                  ilosczup, iloscdodatkowych);
                sw.WriteLine("Kwota: {0}", (ilosczestawow * 13) + (iloscglownych * 10) + (ilosczup * 4) + (iloscdodatkowych * 8));
                sw.WriteLine("Telefon do królewicza: 32 353 07 42");
                sw.Close();
            } else {
                MessageBox.Show("Ktoś usunął Ci plik!!!", "Komunikat", MessageBoxButtons.OK);
            }
        }

        public KrolewiczApp() {
            InitializeComponent();
            WyczyscLubStworzPlik();
        }

        private void TextBoxZestaw_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void TextBoxGlowne_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void TextBoxZupy_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void TextBoxDodatkowe_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void TextBoxZestaw_TextChanged(object sender, EventArgs e) {
            try {
                if(TextBoxZestaw.Text == "") {
                    TextBoxZestaw.Text = "0";
                }
                LabelNaleznoscWartosc.Text = (int.Parse(TextBoxZestaw.Text) * 13 + int.Parse(TextBoxGlowne.Text) * 10 +
                                              int.Parse(TextBoxZupy.Text) * 4 + int.Parse(TextBoxDodatkowe.Text) * 8).ToString();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void TextBoxGlowne_TextChanged(object sender, EventArgs e) {
            try {
                if (TextBoxGlowne.Text == "") {
                    TextBoxGlowne.Text = "0";
                }
                LabelNaleznoscWartosc.Text = (int.Parse(TextBoxZestaw.Text) * 13 + int.Parse(TextBoxGlowne.Text) * 10 +
                                              int.Parse(TextBoxZupy.Text) * 4 + int.Parse(TextBoxDodatkowe.Text) * 8).ToString();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void TextBoxZupy_TextChanged(object sender, EventArgs e) {
            try {
                if (TextBoxZupy.Text == "") {
                    TextBoxZupy.Text = "0";
                }
                LabelNaleznoscWartosc.Text = (int.Parse(TextBoxZestaw.Text) * 13 + int.Parse(TextBoxGlowne.Text) * 10 +
                                              int.Parse(TextBoxZupy.Text) * 4 + int.Parse(TextBoxDodatkowe.Text) * 8).ToString();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void TextBoxDodatkowe_TextChanged(object sender, EventArgs e) {
            try {
                if (TextBoxDodatkowe.Text == "") {
                    TextBoxDodatkowe.Text = "0";
                }
                LabelNaleznoscWartosc.Text = (int.Parse(TextBoxZestaw.Text) * 13 + int.Parse(TextBoxGlowne.Text) * 10 +
                                              int.Parse(TextBoxZupy.Text) * 4 + int.Parse(TextBoxDodatkowe.Text) * 8).ToString();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void ButtonZamow_Click(object sender, EventArgs e) {
            stoszamawiajacych.Push(new Zamawiajacy(TextBoxZamawajacy.Text, int.Parse(TextBoxZestaw.Text),
                                                   int.Parse(TextBoxGlowne.Text), int.Parse(TextBoxZupy.Text),
                                                   int.Parse(TextBoxDodatkowe.Text)));
            AktualizujPlikZHistoria(new Zamawiajacy(TextBoxZamawajacy.Text, int.Parse(TextBoxZestaw.Text),
                                                   int.Parse(TextBoxGlowne.Text), int.Parse(TextBoxZupy.Text),
                                                   int.Parse(TextBoxDodatkowe.Text)));
            AktualizujHistorieZPliku();
            WyczyscPolaIUstawFocus();
        }

        private void ButtonZen_Click(object sender, EventArgs e) {
            DialogResult yesno = MessageBox.Show("Czy chcesz zakończyć zamówienie i pożenić ludzi? \r\n" +
                                                 "Operacji nie będzie można cofnąć!", "Komunikat", MessageBoxButtons.YesNo);
            if(yesno == DialogResult.Yes) {
                Stack<Zamawiajacy> revstoszamawiajacych = new Stack<Zamawiajacy>();
                int ilosczestawow = 0;
                int iloscglownych = 0;
                int ilosczup = 0;
                int iloscdodatkowych = 0;
                int lengthstosu = stoszamawiajacych.Count();
                try {
                    for (int i = 0; i < lengthstosu; i++) {
                        Zamawiajacy zamawiajacy = stoszamawiajacych.Pop();
                        ilosczestawow += zamawiajacy.Zestaw1;
                        iloscglownych += zamawiajacy.Glowne1;
                        ilosczup += zamawiajacy.Zupy1;
                        iloscdodatkowych += zamawiajacy.Dodatkowe1;
                        revstoszamawiajacych.Push(zamawiajacy);
                    }
                    Stack<String> stosglownych = new Stack<String>();
                    Stack<String> stoszup = new Stack<String>();
                    for (int i = 0; i < lengthstosu; i++) {
                        Zamawiajacy zamawiajacy = revstoszamawiajacych.Pop();
                        if (zamawiajacy.Glowne1 > 0) {
                            for (int j = 0; j < zamawiajacy.Glowne1; j++) {
                                stosglownych.Push(zamawiajacy.Nazwa1);
                            }
                        }
                        if (zamawiajacy.Zupy1 > 0) {
                            for (int j = 0; j < zamawiajacy.Zupy1; j++) {
                                stoszup.Push(zamawiajacy.Nazwa1);
                            }
                        }
                    }
                    Stack<String> revstosglownych = new Stack<String>();
                    Stack<String> revstoszup = new Stack<String>();
                    int lengthg = stosglownych.Count();
                    int lengthz = stoszup.Count();
                    for (int i = 0; i < lengthg; i++) {
                        revstosglownych.Push(stosglownych.Pop());
                    }
                    for (int i = 0; i < lengthz; i++) {
                        revstoszup.Push(stoszup.Pop());
                    }
                    if (lengthg >= lengthz) {
                        for (int i = 0; i < lengthz; i++) {
                            MessageBox.Show("Pożeniono " + revstosglownych.Pop() + " i " + revstoszup.Pop(), "Żeniaczka", MessageBoxButtons.OK);
                            iloscglownych--;
                            ilosczup--;
                            ilosczestawow++;
                        }
                    }
                    if (lengthg < lengthz) {
                        for (int i = 0; i < lengthg; i++) {
                            MessageBox.Show("Pożeniono " + revstosglownych.Pop() + " i " + revstoszup.Pop(), "Żeniaczka", MessageBoxButtons.OK);
                            iloscglownych--;
                            ilosczup--;
                            ilosczestawow++;
                        }
                    }
                    DodajKoncoweWartosci(ilosczestawow, iloscglownych, ilosczup, iloscdodatkowych);
                    AktualizujHistorieZPliku();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
                }
            }
        }
    }
}

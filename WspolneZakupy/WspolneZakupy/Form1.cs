using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WspolneZakupy {
    public partial class WspolneZakupy : Form {
        public void WczytajKwote() {
            String path = "HistoriaDoladowan.txt";
            try {
                if (File.Exists(path)) {
                    String lastline = File.ReadLines(path).Last();
                    if(lastline.Contains("Kwota po odjeciu: ")) {
                        lastline = lastline.Replace("Kwota po odjeciu: ", "");
                    }
                    if(lastline.Contains("Kwota po doladowaniu: ")) {
                        lastline = lastline.Replace("Kwota po doladowaniu: ", "");
                    }
                    this.FunduszeWartoscLabel.Text = lastline;
                } else {
                    this.FunduszeWartoscLabel.Text = "0";
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        public void WczytajHistorie() {
            String path = "HistoriaDoladowan.txt";

            try {
                if (File.Exists(path)) {
                    String[] lines = File.ReadAllLines(path);
                    foreach(String line in lines) {
                        this.HistoriaZPlikuBox.Text += line + "\r\n";
                    }
                } else {
                    this.HistoriaZPlikuBox.Text = "";
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        public WspolneZakupy() {
            InitializeComponent();
            WczytajKwote();
            WczytajHistorie();
            if(int.Parse(this.FunduszeWartoscLabel.Text) < 150) {
                this.KomunikatLabel.Visible = true;
            } else {
                this.KomunikatLabel.Visible = false;
            }
        }

        public int DoladujKwote(String obecnefundusze, String doladowanie) {
            int obecnefunduszewartosc = int.Parse(obecnefundusze);
            int doladowaniewartosc = int.Parse(doladowanie);

            return obecnefunduszewartosc + doladowaniewartosc;
        }

        public void DoladowanieFunduszyLog(String obecnefundusze, String doladowanie, String uwagi) {
            int funduszepodoladowaniu = int.Parse(obecnefundusze) + int.Parse(doladowanie);

            try {
                if (!File.Exists("HistoriaDoladowan.txt")) {
                    StreamWriter sw = File.CreateText("HistoriaDoladowan.txt");
                    sw.WriteLine("Data: " + DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year);
                    sw.WriteLine("Uwagi: " + uwagi);
                    sw.WriteLine("Kwota przed doladowaniem: " + int.Parse(obecnefundusze));
                    sw.Write("Kwota po doladowaniu: " + funduszepodoladowaniu);
                    sw.Close();
                } else {
                    FileStream fs = new FileStream("HistoriaDoladowan.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine("");
                    sw.WriteLine("----");
                    sw.WriteLine("Data: " + DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year);
                    sw.WriteLine("Uwagi: " + uwagi);
                    sw.WriteLine("Kwota przed doladowaniem: " + int.Parse(obecnefundusze));
                    sw.Write("Kwota po doladowaniu: " + funduszepodoladowaniu);
                    sw.Close();
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void DoladujButton_Click(object sender, EventArgs e) {
            try {
                DoladowanieFunduszyLog(this.FunduszeWartoscLabel.Text, this.WartoscDlaOperacjiBox.Text, this.UwagiBox.Text);
                this.FunduszeWartoscLabel.Text = DoladujKwote(this.FunduszeWartoscLabel.Text, this.WartoscDlaOperacjiBox.Text).ToString();
                this.WartoscDlaOperacjiBox.Text = "";
                this.UwagiBox.Text = "";
                UpdateHistoriaZPlikuBox();
                if (int.Parse(this.FunduszeWartoscLabel.Text) > 150) {
                    this.KomunikatLabel.Visible = false;
                } else {
                    this.KomunikatLabel.Visible = true;
                }
            } catch (ArgumentNullException) {
                MessageBox.Show("Nie podano kwoty", "Komunikat", MessageBoxButtons.OK);
            } catch (ArgumentException) {
                MessageBox.Show("Nieprawidłowa wartość kwoty", "Komunikat", MessageBoxButtons.OK);
            } catch (IOException) {
                MessageBox.Show("Nieprawidłowa wartość kwoty", "Komunikat", MessageBoxButtons.OK);
            } catch (FormatException) {
                MessageBox.Show("Nieprawidłowa wartość kwoty", "Komunikat", MessageBoxButtons.OK);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void KwotaDoDoladowaniaBox_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        public void OdejmowanieFunduszyLog(String obecnefundusze, String kwotadoodjecia, String uwagi) {
            int funduszepoodjeciu = int.Parse(obecnefundusze) - int.Parse(kwotadoodjecia);

            try {
                if (File.Exists("HistoriaDoladowan.txt")) {
                    FileStream fs = new FileStream("HistoriaDoladowan.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine("");
                    sw.WriteLine("----");
                    sw.WriteLine("Data: " + DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year);
                    sw.WriteLine("Uwagi: " + uwagi);
                    sw.WriteLine("Kwota przed odjeciem: " + int.Parse(obecnefundusze));
                    sw.Write("Kwota po odjeciu: " + funduszepoodjeciu);
                    sw.Close();
                } else {
                    MessageBox.Show("Nie ma pliku do zalogowania", "Komunikat", MessageBoxButtons.OK);
                    return;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        public int OdejmijKwote(String obecnefundusze, String kwotadoodjecia) {
            int obecnefunduszewartosc = int.Parse(obecnefundusze);
            int kwotadoodjeciawartosc = int.Parse(kwotadoodjecia);

            return obecnefunduszewartosc - kwotadoodjeciawartosc;
        }

        public void UpdateHistoriaZPlikuBox() {
            String path = "HistoriaDoladowan.txt";

            try {
                this.HistoriaZPlikuBox.Text = "";
                if (File.Exists(path)) {
                    String[] lines = File.ReadAllLines(path);
                    foreach (String line in lines) {
                        this.HistoriaZPlikuBox.Text += line + "\r\n";
                    }
                } else {
                    this.HistoriaZPlikuBox.Text = "";
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        private void OdejmijButton_Click(object sender, EventArgs e) {
            try {
                OdejmowanieFunduszyLog(this.FunduszeWartoscLabel.Text, this.WartoscDlaOperacjiBox.Text, this.UwagiBox.Text);
                this.FunduszeWartoscLabel.Text = OdejmijKwote(this.FunduszeWartoscLabel.Text, this.WartoscDlaOperacjiBox.Text).ToString();
                this.WartoscDlaOperacjiBox.Text = "";
                this.UwagiBox.Text = "";
                UpdateHistoriaZPlikuBox();
                if (int.Parse(this.FunduszeWartoscLabel.Text) < 150) {
                    this.KomunikatLabel.Visible = true;
                } else {
                    this.KomunikatLabel.Visible = false;
                }
            } catch (ArgumentNullException) {
                MessageBox.Show("Nie podano kwoty", "Komunikat", MessageBoxButtons.OK);
            } catch (ArgumentException) {
                MessageBox.Show("Nieprawidłowa wartość kwoty", "Komunikat", MessageBoxButtons.OK);
            } catch (IOException) {
                MessageBox.Show("Nieprawidłowa wartość kwoty", "Komunikat", MessageBoxButtons.OK);
            } catch (FormatException) {
                MessageBox.Show("Nieprawidłowa wartość kwoty", "Komunikat", MessageBoxButtons.OK);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
    }

        private void KwotaDoOdjeciaBox_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }
    }
}

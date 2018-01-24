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
    public partial class HelpForm : Form {
        String[] danezpliku;

        private BarcodeLib.Barcode.Linear ean13jeden = new BarcodeLib.Barcode.Linear();
        private BarcodeLib.Barcode.Linear ean13dwa = new BarcodeLib.Barcode.Linear();

        private BarcodeLib.Barcode.Linear lokalizacja = new BarcodeLib.Barcode.Linear();
        private BarcodeLib.Barcode.Linear zlecenie = new BarcodeLib.Barcode.Linear();
        private BarcodeLib.Barcode.Linear wz = new BarcodeLib.Barcode.Linear();
        private BarcodeLib.Barcode.Linear pojemnik = new BarcodeLib.Barcode.Linear();
        private BarcodeLib.Barcode.Linear userjeden = new BarcodeLib.Barcode.Linear();
        private BarcodeLib.Barcode.Linear userdwa = new BarcodeLib.Barcode.Linear();

        private BarcodeLib.Barcode.Linear ean128jeden = new BarcodeLib.Barcode.Linear();
        private BarcodeLib.Barcode.Linear ean128dwa = new BarcodeLib.Barcode.Linear();

        public void WczytajKody() {
            try {
                if (File.Exists("Kody.txt")) {
                    danezpliku = File.ReadAllLines("Kody.txt");
                } else {
                    MessageBox.Show("Nie ma pliku Kody.txt!", "Komunikat", MessageBoxButtons.OK);
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Komunikat", MessageBoxButtons.OK);
            }
        }

        public void SkonfigurujKody() {
            ean13jeden.Type = BarcodeLib.Barcode.BarcodeType.EAN13;
            ean13jeden.Data = danezpliku[2].Remove(danezpliku[2].Length - 1);
            ean13jeden.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            ean13jeden.BarColor = Color.Black;
            ean13jeden.LeftMargin = 4;
            ean13jeden.RightMargin = 4;
            ean13jeden.BarWidth = 2;
            ean13jeden.TopMargin = 20;
            ean13jeden.ImageHeight = PictureBoxKodEanJeden.Height - 15;
            ean13jeden.ImageWidth = PictureBoxKodEanJeden.Width;
            ean13dwa.Type = BarcodeLib.Barcode.BarcodeType.EAN13;
            ean13dwa.Data = danezpliku[4].Remove(danezpliku[4].Length - 1);
            ean13dwa.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            ean13dwa.BarColor = Color.Black;
            ean13dwa.LeftMargin = 4;
            ean13dwa.RightMargin = 4;
            ean13dwa.BarWidth = 2;
            ean13dwa.TopMargin = 20;
            ean13dwa.ImageHeight = PictureBoxKodEanDwa.Height - 15;
            ean13dwa.ImageWidth = PictureBoxKodEanDwa.Width;

            lokalizacja.Type = BarcodeLib.Barcode.BarcodeType.CODE128;
            lokalizacja.Data = danezpliku[7];
            lokalizacja.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            lokalizacja.BarColor = Color.Black;
            lokalizacja.LeftMargin = 4;
            lokalizacja.RightMargin = 4;
            lokalizacja.BarWidth = 2;
            lokalizacja.TopMargin = 20;
            lokalizacja.ImageHeight = PictureBoxKodLokalizacja.Height - 15;
            lokalizacja.ImageWidth = PictureBoxKodLokalizacja.Width;

            zlecenie.Type = BarcodeLib.Barcode.BarcodeType.CODE128;
            zlecenie.Data = danezpliku[10];
            zlecenie.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            zlecenie.BarColor = Color.Black;
            zlecenie.LeftMargin = 4;
            zlecenie.RightMargin = 4;
            zlecenie.BarWidth = 2;
            zlecenie.TopMargin = 20;
            zlecenie.ImageHeight = PictureBoxKodZlecenie.Height - 15;
            zlecenie.ImageWidth = PictureBoxKodZlecenie.Width;

            wz.Type = BarcodeLib.Barcode.BarcodeType.CODE128;
            wz.Data = danezpliku[13];
            wz.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            wz.BarColor = Color.Black;
            wz.LeftMargin = 4;
            wz.RightMargin = 4;
            wz.BarWidth = 2;
            wz.TopMargin = 20;
            wz.ImageHeight = PictureBoxKodWZ.Height - 15;
            wz.ImageWidth = PictureBoxKodWZ.Width;

            pojemnik.Type = BarcodeLib.Barcode.BarcodeType.CODE128;
            pojemnik.Data = danezpliku[16];
            pojemnik.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            pojemnik.BarColor = Color.Black;
            pojemnik.LeftMargin = 4;
            pojemnik.RightMargin = 4;
            pojemnik.BarWidth = 2;
            pojemnik.TopMargin = 20;
            pojemnik.ImageHeight = PictureBoxKodPojemnik.Height - 15;
            pojemnik.ImageWidth = PictureBoxKodPojemnik.Width;

            userjeden.Type = BarcodeLib.Barcode.BarcodeType.CODE128;
            userjeden.Data = danezpliku[19];
            userjeden.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            userjeden.BarColor = Color.Black;
            userjeden.LeftMargin = 4;
            userjeden.RightMargin = 4;
            userjeden.BarWidth = 2;
            userjeden.TopMargin = 20;
            userjeden.ImageHeight = PictureBoxKodUser1.Height - 15;
            userjeden.ImageWidth = PictureBoxKodUser1.Width;
            userdwa.Type = BarcodeLib.Barcode.BarcodeType.CODE128;
            userdwa.Data = danezpliku[21];
            userdwa.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            userdwa.BarColor = Color.Black;
            userdwa.LeftMargin = 4;
            userdwa.RightMargin = 4;
            userdwa.BarWidth = 2;
            userdwa.TopMargin = 20;
            userdwa.ImageHeight = PictureBoxKodUser2.Height - 15;
            userdwa.ImageWidth = PictureBoxKodUser2.Width;

            ean128jeden.Type = BarcodeLib.Barcode.BarcodeType.EAN128;
            ean128jeden.Data = danezpliku[24];
            ean128jeden.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            ean128jeden.BarColor = Color.Black;
            ean128jeden.LeftMargin = 4;
            ean128jeden.RightMargin = 4;
            ean128jeden.BarWidth = 2;
            ean128jeden.TopMargin = 20;
            ean128jeden.ImageHeight = PictureBoxEan128Jeden.Height - 15;
            ean128jeden.ImageWidth = PictureBoxEan128Jeden.Width;
            ean128dwa.Type = BarcodeLib.Barcode.BarcodeType.EAN128;
            ean128dwa.Data = danezpliku[26];
            ean128dwa.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            ean128dwa.BarColor = Color.Black;
            ean128dwa.LeftMargin = 4;
            ean128dwa.RightMargin = 4;
            ean128dwa.BarWidth = 2;
            ean128dwa.TopMargin = 20;
            ean128dwa.ImageHeight = PictureBoxEan128Dwa.Height - 15;
            ean128dwa.ImageWidth = PictureBoxEan128Dwa.Width;
        }

        public void NamalujKody() {
            Font font = new Font("TimesNewRoman", 10, FontStyle.Bold, GraphicsUnit.Pixel);
            Graphics graphics;

            PictureBoxKodEanJeden.Image = ean13jeden.drawBarcode();
            graphics = Graphics.FromImage(PictureBoxKodEanJeden.Image);
            graphics.DrawString(danezpliku[1], font, Brushes.Black, new Point(0, 0));
            PictureBoxKodEanDwa.Image = ean13dwa.drawBarcode();
            graphics = Graphics.FromImage(PictureBoxKodEanDwa.Image);
            graphics.DrawString(danezpliku[3], font, Brushes.Black, new Point(0, 0));

            PictureBoxKodLokalizacja.Image = lokalizacja.drawBarcode();
            graphics = Graphics.FromImage(PictureBoxKodLokalizacja.Image);
            graphics.DrawString(danezpliku[6], font, Brushes.Black, new Point(0, 0));

            PictureBoxKodZlecenie.Image = zlecenie.drawBarcode();
            graphics = Graphics.FromImage(PictureBoxKodZlecenie.Image);
            graphics.DrawString(danezpliku[9], font, Brushes.Black, new Point(0, 0));

            PictureBoxKodWZ.Image = wz.drawBarcode();
            graphics = Graphics.FromImage(PictureBoxKodWZ.Image);
            graphics.DrawString(danezpliku[12], font, Brushes.Black, new Point(0, 0));

            PictureBoxKodPojemnik.Image = pojemnik.drawBarcode();
            graphics = Graphics.FromImage(PictureBoxKodPojemnik.Image);
            graphics.DrawString(danezpliku[15], font, Brushes.Black, new Point(0, 0));

            PictureBoxKodUser1.Image = userjeden.drawBarcode();
            graphics = Graphics.FromImage(PictureBoxKodUser1.Image);
            graphics.DrawString(danezpliku[18], font, Brushes.Black, new Point(0, 0));
            PictureBoxKodUser2.Image = userdwa.drawBarcode();
            graphics = Graphics.FromImage(PictureBoxKodUser2.Image);
            graphics.DrawString(danezpliku[20], font, Brushes.Black, new Point(0, 0));

            PictureBoxEan128Jeden.Image = ean128jeden.drawBarcode();
            graphics = Graphics.FromImage(PictureBoxEan128Jeden.Image);
            graphics.DrawString(danezpliku[23], font, Brushes.Black, new Point(0, 0));
            PictureBoxEan128Dwa.Image = ean128dwa.drawBarcode();
            graphics = Graphics.FromImage(PictureBoxEan128Dwa.Image);
            graphics.DrawString(danezpliku[25], font, Brushes.Black, new Point(0, 0));
        }

        public HelpForm() {
            InitializeComponent();
            WczytajKody();
            SkonfigurujKody();
            NamalujKody();
        }

        private void ButtonEan128_Click(object sender, EventArgs e) {
            PictureBoxKodEanJeden.Visible = false;
            PictureBoxKodEanDwa.Visible = false;

            PictureBoxKodLokalizacja.Visible = false;
            PictureBoxKodZlecenie.Visible = false;
            PictureBoxKodWZ.Visible = false;
            PictureBoxKodPojemnik.Visible = false;

            PictureBoxKodUser1.Visible = false;
            PictureBoxKodUser2.Visible = false;

            PictureBoxEan128Jeden.Visible = true;
            PictureBoxEan128Dwa.Visible = true;
        }

        private void ButtonEan13_Click(object sender, EventArgs e) {
            PictureBoxKodEanJeden.Visible = true;
            PictureBoxKodEanDwa.Visible = true;

            PictureBoxKodLokalizacja.Visible = false;
            PictureBoxKodZlecenie.Visible = false;
            PictureBoxKodWZ.Visible = false;
            PictureBoxKodPojemnik.Visible = false;

            PictureBoxKodUser1.Visible = false;
            PictureBoxKodUser2.Visible = false;

            PictureBoxEan128Jeden.Visible = false;
            PictureBoxEan128Dwa.Visible = false;
        }

        private void ButtonLokalizacja_Click(object sender, EventArgs e) {
            PictureBoxKodEanJeden.Visible = false;
            PictureBoxKodEanDwa.Visible = false;

            PictureBoxKodLokalizacja.Visible = true;
            PictureBoxKodZlecenie.Visible = false;
            PictureBoxKodWZ.Visible = false;
            PictureBoxKodPojemnik.Visible = false;

            PictureBoxKodUser1.Visible = false;
            PictureBoxKodUser2.Visible = false;

            PictureBoxEan128Jeden.Visible = false;
            PictureBoxEan128Dwa.Visible = false;
        }

        private void ButtonZlecenie_Click(object sender, EventArgs e) {
            PictureBoxKodEanJeden.Visible = false;
            PictureBoxKodEanDwa.Visible = false;

            PictureBoxKodLokalizacja.Visible = false;
            PictureBoxKodZlecenie.Visible = true;
            PictureBoxKodWZ.Visible = false;
            PictureBoxKodPojemnik.Visible = false;

            PictureBoxKodUser1.Visible = false;
            PictureBoxKodUser2.Visible = false;

            PictureBoxEan128Jeden.Visible = false;
            PictureBoxEan128Dwa.Visible = false;
        }

        private void ButtonWZ_Click(object sender, EventArgs e) {
            PictureBoxKodEanJeden.Visible = false;
            PictureBoxKodEanDwa.Visible = false;

            PictureBoxKodLokalizacja.Visible = false;
            PictureBoxKodZlecenie.Visible = false;
            PictureBoxKodWZ.Visible = true;
            PictureBoxKodPojemnik.Visible = false;

            PictureBoxKodUser1.Visible = false;
            PictureBoxKodUser2.Visible = false;

            PictureBoxEan128Jeden.Visible = false;
            PictureBoxEan128Dwa.Visible = false;
        }

        private void ButtonPojemnik_Click(object sender, EventArgs e) {
            PictureBoxKodEanJeden.Visible = false;
            PictureBoxKodEanDwa.Visible = false;

            PictureBoxKodLokalizacja.Visible = false;
            PictureBoxKodZlecenie.Visible = false;
            PictureBoxKodWZ.Visible = false;
            PictureBoxKodPojemnik.Visible = true;

            PictureBoxKodUser1.Visible = false;
            PictureBoxKodUser2.Visible = false;

            PictureBoxEan128Jeden.Visible = false;
            PictureBoxEan128Dwa.Visible = false;
        }

        private void ButtonUser_Click(object sender, EventArgs e) {
            PictureBoxKodEanJeden.Visible = false;
            PictureBoxKodEanDwa.Visible = false;

            PictureBoxKodLokalizacja.Visible = false;
            PictureBoxKodZlecenie.Visible = false;
            PictureBoxKodWZ.Visible = false;
            PictureBoxKodPojemnik.Visible = false;

            PictureBoxKodUser1.Visible = true;
            PictureBoxKodUser2.Visible = true;

            PictureBoxEan128Jeden.Visible = false;
            PictureBoxEan128Dwa.Visible = false;
        }

        private void HelpForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }
    }
}

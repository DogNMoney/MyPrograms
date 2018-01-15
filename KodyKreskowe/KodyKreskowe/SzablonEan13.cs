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
    public partial class SzablonEan13 : Form {
        private String kod;
        private String informacjanadkodem;
        private BarcodeLib.Barcode.Linear ean13 = new BarcodeLib.Barcode.Linear();

        public void SkonfigurujKod() {
            TextBoxInfoNadKodem.Text = kod;
            ean13.Type = BarcodeLib.Barcode.BarcodeType.EAN13;
            ean13.Data = kod.Remove(kod.Length - 1);
            ean13.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            ean13.BarColor = Color.Black;
            ean13.LeftMargin = 4;
            ean13.RightMargin = 4;
            ean13.BarWidth = 2;
            ean13.TopMargin = 20;
            ean13.ImageHeight = PictureBoxKod.Height - 15;
            ean13.ImageWidth = PictureBoxKod.Width;
        }

        public void WyswietlKod() {
            PictureBoxKod.Image = ean13.drawBarcode();
            Graphics graphics = Graphics.FromImage(PictureBoxKod.Image);
            Font font = new Font("TimesNewRoman", 10, FontStyle.Bold, GraphicsUnit.Pixel);
            graphics.DrawString(informacjanadkodem, font, Brushes.Black, new Point(0,0));
        }

        public SzablonEan13() {
            InitializeComponent();
        }

        public string Kod { get => kod; set => kod = value; }
        public string Informacjanadkodem { get => informacjanadkodem; set => informacjanadkodem = value; }

        private void SzablonEan13_Load(object sender, EventArgs e) {
            SkonfigurujKod();
            WyswietlKod();
        }

        private void PictureBoxKod_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                Clipboard.SetImage(PictureBoxKod.Image);
            }
        }
    }
}

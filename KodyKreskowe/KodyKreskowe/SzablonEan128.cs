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
    public partial class SzablonEan128 : Form {
        private string informacjanadkodem;
        private string kod;
        private BarcodeLib.Barcode.Linear ean128 = new BarcodeLib.Barcode.Linear();

        public SzablonEan128() {
            InitializeComponent();
        }

        public string Informacjanadkodem { get => informacjanadkodem; set => informacjanadkodem = value; }
        public string Kod { get => kod; set => kod = value; }

        public void SkonfigurujKod() {
            TextBoxInfoNadKodem.Text = kod;
            ean128.Type = BarcodeLib.Barcode.BarcodeType.EAN128;
            ean128.Data = kod;
            ean128.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            ean128.BarColor = Color.Black;
            ean128.LeftMargin = 4;
            ean128.RightMargin = 4;
            ean128.BarWidth = 2;
            ean128.TopMargin = 20;
            ean128.ImageHeight = PictureBoxKod.Height - 15;
            ean128.ImageWidth = PictureBoxKod.Width;
        }

        public void WyswietlKod() {
            PictureBoxKod.Image = ean128.drawBarcode();
            Graphics graphics = Graphics.FromImage(PictureBoxKod.Image);
            Font font = new Font("TimesNewRoman", 10, FontStyle.Bold, GraphicsUnit.Pixel);
            graphics.DrawString(informacjanadkodem, font, Brushes.Black, new Point(0, 0));
        }

        private void SzablonEan128_Load(object sender, EventArgs e) {
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

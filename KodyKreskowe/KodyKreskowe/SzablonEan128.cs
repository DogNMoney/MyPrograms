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
            TextBoxInfoNadKodem.Text = informacjanadkodem;
            ean128.Type = BarcodeLib.Barcode.BarcodeType.EAN128;
            ean128.Data = informacjanadkodem;
            ean128.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            ean128.BarColor = Color.Black;
            ean128.LeftMargin = 4;
            ean128.RightMargin = 4;
            ean128.BarWidth = 2;
        }

        public void WyswietlKod() {
            PictureBoxKod.Image = ean128.drawBarcode();
        }

        private void SzablonEan128_Load(object sender, EventArgs e) {
            SkonfigurujKod();
            WyswietlKod();
        }
    }
}

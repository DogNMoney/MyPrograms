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
    public partial class SzablonCode128 : Form {
        private string informacjanadkodem;
        private string kod;
        private BarcodeLib.Barcode.Linear code128 = new BarcodeLib.Barcode.Linear();

        public SzablonCode128() {
            InitializeComponent();
        }

        public string Informacjanadkodem { get => informacjanadkodem; set => informacjanadkodem = value; }
        public string Kod { get => kod; set => kod = value; }

        public void SkonfigurujKod() {
            TextBoxInfoNadKodem.Text = informacjanadkodem;
            code128.Type = BarcodeLib.Barcode.BarcodeType.CODE128;
            code128.Data = informacjanadkodem;
            code128.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            code128.BarColor = Color.Black;
            code128.LeftMargin = 4;
            code128.RightMargin = 4;
            code128.BarWidth = 2;
        }

        public void WyswietlKod() {
            PictureBoxKod.Image = code128.drawBarcode();
        }

        private void SzablonCode128_Load(object sender, EventArgs e) {
            SkonfigurujKod();
            WyswietlKod();
        }
    }
}

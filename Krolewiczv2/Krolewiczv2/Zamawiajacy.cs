using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krolewiczv2 {
    class Zamawiajacy {
        private String Nazwa;
        private int Zestaw;
        private int Glowne;
        private int Zupy;
        private int Dodatkowe;

        public string Nazwa1 { get => Nazwa; set => Nazwa = value; }
        public int Zestaw1 { get => Zestaw; set => Zestaw = value; }
        public int Glowne1 { get => Glowne; set => Glowne = value; }
        public int Zupy1 { get => Zupy; set => Zupy = value; }
        public int Dodatkowe1 { get => Dodatkowe; set => Dodatkowe = value; }

        public Zamawiajacy() {
            this.Nazwa = "Nikt";
            this.Zestaw = 0;
            this.Glowne = 0;
            this.Zupy = 0;
            this.Dodatkowe = 0;
        }

        public Zamawiajacy(String nazwa, int zestaw, int glowne, int zupy, int dodatkowe) {
            this.Nazwa = nazwa;
            this.Zestaw = zestaw;
            this.Glowne = glowne;
            this.Zupy = zupy;
            this.Dodatkowe = dodatkowe;
        }

        public Zamawiajacy(Zamawiajacy zamawiajacy) {
            this.Nazwa = zamawiajacy.Nazwa1;
            this.Zestaw = zamawiajacy.Zestaw1;
            this.Glowne = zamawiajacy.Glowne1;
            this.Zupy = zamawiajacy.Zupy1;
            this.Dodatkowe = zamawiajacy.Dodatkowe1;
        }
    }
}

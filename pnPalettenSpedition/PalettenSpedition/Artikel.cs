namespace PalettenSpedition
{
    internal class Artikel
    {
        int id;
        string bezeichnung;
        Einheit einheit;
        double gewichtProEinheit;
        double breite;
        double laenge;
        double hohe;

        public int ID { get { return id; } }
        public string Bezeichnung { get { return bezeichnung; } }
        public Einheit Einheit { get { return einheit; } }
        public double GewichtProEinheit { get { return gewichtProEinheit; } }
        public double Breite { get { return breite; } }
        public double Laenge { get { return laenge; } }
        public double Hohe { get { return hohe; } }

        public Artikel(int id, string bezeichnung, Einheit einheit, double gewichtProEinheit, double breite, double laenge, double hohe)
        {
            this.id = id;
            this.bezeichnung = bezeichnung;
            this.einheit = einheit;
            this.gewichtProEinheit = gewichtProEinheit;
            this.breite = breite;
            this.laenge = laenge;
            this.hohe = hohe;
        }
    }
}
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
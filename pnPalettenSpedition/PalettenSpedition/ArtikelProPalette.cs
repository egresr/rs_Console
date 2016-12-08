using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalettenSpedition
{

    //
    //Inhalt für eine Palette generieren
    //Aussenmassen ermitteln;
    //

    class ArtikelProPalette
    {
        static int gesammteSendungAnzahl;

        int sendungId = 1;
        double aussenBreite;
        double aussenLaenge;
        double aussenHohe;
        bool sonderSendung = false;
        bool sendungStornieren = false;
        private double maxAussenHohe = 1000;

        Palette palette;
        Artikel artikel;
        List<Artikel> listArtikels;
        List<ArtikelProPalette> listSendungen;


        public ArtikelProPalette(List<Artikel> listArtikels)
        {
            this.listArtikels = listArtikels;
        }

        public ArtikelProPalette(Artikel artikel, Palette palette)
        {
            sendungId += gesammteSendungAnzahl;
            gesammteSendungAnzahl++;

            this.artikel = artikel;
            this.palette = palette;

            BerechneAussenMassen();
        }


        public List<ArtikelProPalette> PackeArtikelAufPalette()
        {
            listSendungen = new List<ArtikelProPalette>();

            foreach (Artikel artikel in listArtikels)
            {
                listSendungen.Add(new ArtikelProPalette(artikel, new Palette()));
            }

            return listSendungen;
        }

        public void BerechneAussenMassen()
        {
            if (palette.Breite >= artikel.Breite) //Sendung Aussenbreite ermitteln
                aussenBreite = palette.Breite;
            if (palette.Breite < artikel.Breite)
            {
                aussenBreite = artikel.Breite;
                sonderSendung = true;
            }


            if (palette.Laenge >= artikel.Laenge) //Sendung Aussenhohe ermitteln
                aussenLaenge = palette.Laenge;
            if (palette.Laenge < artikel.Laenge)
            {
                aussenLaenge = artikel.Laenge;
                sonderSendung = true;
            }

            aussenHohe = palette.Hohe + artikel.Hohe;
            if (aussenHohe > maxAussenHohe)
            {
                sendungStornieren = true;

                Console.Clear();

                Console.SetCursorPosition(Console.WindowHeight / 2, Console.WindowWidth / 2);
                Console.WriteLine(">>>>>>>>> Achtung MAX Aussenhohe wurde von Sendung Nr: __{0}__ überschritten <<<<<<<<<", sendungId);
                Console.ReadLine();

                Console.SetCursorPosition((Console.WindowHeight / 2) + 3, Console.WindowWidth / 2);//ToGo Korrigieren: 
                                                                                                   //Cursor wird nicht in gewünschte 
                                                                                                   //Position gesetzt
                Console.Write(">>>>>>>>>>>>>>>>>> Achtung Sendung Nr: __{0}__ wurde ___STORNIERT___ <<<<<<<<<<<<<<<<<<", sendungId);
                Console.ReadLine();

                StorniereSendung(sendungId);
            }


        }

        public List<ArtikelProPalette> StorniereSendung(List<ArtikelProPalette> sendung)
        {
            foreach (ArtikelProPalette item in listSendungen)
            {
                item.Remove(artikel.ID);
            }

            return listSendungen;
        }



    }
}
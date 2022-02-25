using System;
namespace uebung_dokument
{
    public class WordDatei : Dokument
    {
        public string Titel { get; set; }

        public int Seitenanzahl { get; set; }

        public string Autor { get; set; }

        public WordDatei(string titel, bool _istPrivat, DateTime erstellzeitpunkt)
        {
            this.Titel = titel;
            this.Erstellzeit = erstellzeitpunkt;
            this.IstPrivat = _istPrivat;
        }
    }
}

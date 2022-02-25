using System;
namespace uebung_dokument
{
    public class EMail : Dokument
    {
        public string Absender { get; set; }

        public string Empfänger { get; set; }

        public string Betreff { get; set; }

        public EMail(string absender, string empfänger, bool _istPrivat, DateTime erstellzeitpunkt)
        {
            this.Absender = absender;
            this.Empfänger = empfänger;
            this.Erstellzeit = erstellzeitpunkt;
            this.IstPrivat = _istPrivat;

        }
    }
}

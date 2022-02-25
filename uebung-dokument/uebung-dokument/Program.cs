using System;

namespace uebung_dokument
{
    class Program
    {
        static void Main(string[] args)
        {
            WordDatei w1 = new WordDatei("Datei 1", true, DateTime.Now);

            EMail e1 = new EMail("Brugger Bastian",
                "Sebastian Entleitner",
                false,
                DateTime.Now);

            Console.WriteLine($"{w1.Titel}, {w1.IstPrivat}, {w1.Erstellzeit}");
            Console.WriteLine($"{e1.Absender}, {e1.Empfänger}, {e1.IstPrivat}, {e1.Erstellzeit}");
        }
    }
}

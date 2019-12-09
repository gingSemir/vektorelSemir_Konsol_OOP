using System;
using Vektorel.EmlakciLib;

namespace Vektorel.Konsol.EmlakciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ev evim = new Ev();// nesne turetme Metod-1
            evim.Alan = 130;
            evim.OdaSayisi = -3;
            evim.KatNo = 4;
            evim.Semt = "Fulya";
            Console.WriteLine(evim.EvBilgileriniGetir()); 
            Ev evim2 = new Ev { Alan = 110, Semt = "Bilkent", KatNo = 8, OdaSayisi = 4 }; // nesne turetme Metod-2

            Console.ReadKey();
        }
    }
}

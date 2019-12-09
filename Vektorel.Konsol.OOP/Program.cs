using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Konsol.OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Ev evim = new Ev();

            Console.WriteLine("Oda sayisi giriniz:");
            int odaSayisi = int.Parse(Console.ReadLine());
            evim.OdaSayisiDegistir(odaSayisi);
            Console.WriteLine("Semt giriniz:");
            evim.semt = Console.ReadLine();
            Console.WriteLine("Kat no giriniz:");
            evim.katNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Alan giriniz:");
            evim.alan = double.Parse(Console.ReadLine());

            Console.WriteLine($"Oda Sayisi:{evim.OdaSayisiGetir()}\nSemt:{evim.semt}\nKat No:{evim.katNo}\nAlan:{evim.alan}");
            Console.ReadKey();

        }
    }

    class Ev
    {
        int odaSayisi; // field
        public string semt;
        public int katNo;
        public double alan;

        public void OdaSayisiDegistir(int odaSayisi)
        {
            this.odaSayisi = Math.Abs(odaSayisi);
        }

        public int OdaSayisiGetir()
        {
            return this.odaSayisi;
        }


        // field lari disaridan gelen hatali degerlere karsi koruma islemi: Kapsulleme / Encapsulation

    }

}

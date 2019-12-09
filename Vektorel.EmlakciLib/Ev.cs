using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.EmlakciLib
{
    public class Ev
    {
        private int odaSayisi; // sadece kontrollu atama yapmak icin field kullanilir disinda sadece property yeterli !!!
        private int katNo;
        private string semt;
        private string sehir;

        public int OdaSayisi { get => odaSayisi; set => odaSayisi = Math.Abs(value); } // value : disaridan gelen degeri temsil eder!
                                                                                       // => : GoesTo / Lambda Operatoru / Expression Bodied Members (tek satirlik ifadelere Expressiod Bodie denir! )
        public int KatNo { get => katNo; set => katNo = value; } // get ve set :  accessors
        public string Semt
        {
            get => semt; set
            {
                semt = value.ToUpper();
                switch (semt)
                {
                    case "FULYA":
                        this.sehir = "Istanbul";
                        break;
                    case "BILKENT":
                        this.sehir = "Ankara";
                        break;
                    default:
                        this.sehir = "Sehir bilinmiyor!";
                        break;
                }
            }
        }// con satirli islemler yapacak olursak metoda cevir!
        public double Alan { get; set; } // herhangibir sey yapmayaaksak sadece property kullan ( dikkat et: "double alan" field i yok! )


        public string EvBilgileriniGetir() => $"Oda Sayisi:{this.odaSayisi}\nKat No:{this.KatNo}\nSemt:{this.Semt}\nAlan:{this.Alan}\nSehir:{this.sehir}";

    }

}

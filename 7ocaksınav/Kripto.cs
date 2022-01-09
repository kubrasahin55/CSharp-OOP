using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ocaksınav
{
    internal class Kripto:Piyasalar
    {

        public int coinno;
        public string coinsembol;
        public int alimfiyat;
        public int satisfiyat;
        public string teknolojiadi;

       
        public override double KomisyonBelirle(string ulke, int hacim, double birimfiyat, double birimsayisi)
        {
            double fiyat = 0;
          
            if (ulke=="çin"&& hacim>100000)
            {
                if (birimfiyat>300 && birimsayisi>100)
                {
                     fiyat= (birimfiyat * birimsayisi) * 7 / 100;
                    Console.WriteLine("ülke çin ve birim fiyat 300 üstü ise fiyat: "+fiyat);
                    return fiyat;
                }
                else if (birimfiyat<300 && birimsayisi<100)
                {
                    fiyat = (birimfiyat * birimsayisi) * 3.5;
                    Console.WriteLine("ülke çin ve birim fiyat 300 altı ise fiyat: " + fiyat);
                    return fiyat;
                }
              return fiyat;
               
               
            }

           else if (ulke == "amerika" && hacim < 100000)
            {
                if (birimfiyat > 300 && birimsayisi > 100)
                {
                     fiyat = (birimfiyat * birimsayisi) * 2 / 100;
                    Console.WriteLine("ülke çin ve birim fiyat 300 üstü ise fiyat: " + fiyat);
                    return fiyat;
                }
                else if (birimfiyat < 300 && birimsayisi < 100)
                {
                    fiyat = (birimfiyat * birimsayisi) * 3.5;
                    Console.WriteLine("ülke çin ve birim fiyat 300 altı ise fiyat: " + fiyat);
                    return fiyat;
                }
            }
             return fiyat;
        }

       
        public override void SermayeBelirleme(string ulke, int hacim, string durum)
        {
            if (ulke=="italya"&& hacim<900000)
            {
                Console.WriteLine("Sektör seçiniz ");
                Console.WriteLine("1.Teknoloji Sektörü");
                Console.WriteLine("2.Snayi Sektörü");
                int secim=Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:

                        Console.WriteLine("Teknoloji Sektörü");
                        BirimFiyati += hacim * 30 / 100;
                        Console.WriteLine("Ekstra birim sayısı aldınzı birim fiyatınız: "+BirimFiyati);

                        break;

                   case 2:
                        Console.WriteLine("Sanayi Sektörü ");
                        BirimFiyati -= hacim * 2 / 5;
                        Console.WriteLine("Ekstra birim sayısı aldınzı birim fiyatınız: " + BirimFiyati);
                        break;
                }
            }
        }
        
        
        


        public void VeriAl()
        {
            VeriAl1();
          Console.WriteLine("Coinno giriniz");
         coinno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coin sembol giriniz..");
            coinsembol = Console.ReadLine();
            Console.WriteLine("Alım Fİyatını Gİriniz.");
            alimfiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Satış Fiyatını Gİrin.");
            satisfiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teknoloji Adını girin..");
            teknolojiadi=Console.ReadLine();
            
            Console.Clear();
        }
        public void yazdır()
        {
            Console.WriteLine("Coinno :  "+coinno);
            Console.WriteLine("Coin Sembolü :  "+coinsembol);
            Console.WriteLine("Alım Fiyatı :  "+alimfiyat);
            Console.WriteLine("Satış Fiyatı : "+satisfiyat);
            Console.WriteLine("Teknoloji Adı  : "+teknolojiadi);
            KomisyonBelirle("çin", 100000, 301, 101);
            SermayeBelirleme("italya", 900000, "italya piyasa");

        }


    }
}

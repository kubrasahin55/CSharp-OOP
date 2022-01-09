using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ocaksınav
{
    abstract internal class Piyasalar
    {


        int piyasano;
        string ulke;
        int hacim;
        int birimFiyati;
        int birimSayisi;
        string durum;

        public int Piyasano
        {
            get
            { return piyasano; }
            set { piyasano = value; }
        }
        public string Ulke
        {
            get { return ulke; }
            set { ulke = value; }
        }

        public int Hacim
        {
            get { return hacim; }
            set { hacim = value; }
        }
        public int BirimFiyati
        {
            get { return birimFiyati; }
            set
            {
                birimFiyati = value;
            }
        }
        public int BirimSayisi
        {
            get { return birimSayisi; }
            set { birimSayisi = value; }
        }
        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }

        public abstract double KomisyonBelirle(string ulke, int hacim, double birimfiyat, double birimsayisi);
        public abstract void SermayeBelirleme(string ulke, int hacim, string durum);

        public virtual void Durum2(string durum)
        {
            if (durum == "çin")
            {
                Console.WriteLine("UZAK DOĞU ÜLKELERİ TÜRKİYE YATIRIMCILARI FAALİUET GÖSTERMEKTEDİR.");
            }
            else if (durum == "amerika")
            {
                Console.WriteLine("Avrupa birliği ülkeleri yatırımları ve sektörleri faaliyet göstermektir.");
            }
        }

        public void VeriAl1()
        {
            // Piyasalar piyasalar1=new Piyasalar();
            Console.WriteLine("Piyasa no girin.. ");
            Piyasano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ülke giriniz: ");
            Ulke = Console.ReadLine();
            Console.WriteLine("Hacim giriniz.");
            Hacim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birim Fiyatı Gİriniz.");
            BirimFiyati = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birim Sayısı Gİrin");
            BirimSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hangi piyasa da Çin -Amerika ");
            Durum = Console.ReadLine();
            Durum2(durum);
            //Console.Clear();
        }



    }
}

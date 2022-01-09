using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ocaksınav
{
    internal class Borsa : Piyasalar
    {
        string sektoradi;
        string yatirimsirketi;
        string bilancoDurumu;
        int sermayeDurumu;


        public string SektorAdi
        {
            get { return sektoradi; }
            set
            {
                sektoradi = value;
                if (sektoradi == "hizmet")
                {
                    Console.WriteLine("Hizmet sektörüne hoşgeldinz.");
                }
            }
        }
        public string Yatirimsirketi
        {
            get { return yatirimsirketi; }
            set { yatirimsirketi = value; }
        }
        public string BilancoDurumu
        {
            get
            { return bilancoDurumu; }
            set { bilancoDurumu = value; }
        }
        public int SermayeDurumu
        {
            get { return sermayeDurumu; }
            set { sermayeDurumu = value; }
        }

        public override double KomisyonBelirle(string ulke, int hacim, double birimfiyat, double birimsayisi)
        {
            throw new NotImplementedException();
        }

        public override void SermayeBelirleme(string ulke, int hacim, string durum)
        {
            if (ulke == "türkiye" && durum == "türk piyasası")
            {
                int fiyat =(hacim * 7)/100;
                Console.WriteLine("Paranızın %7 komisyonlu hali : " + fiyat);
            }
        }

        public void sektor(string sektoradi, string bilancodurumu)
        {
            if (sektoradi == "hizmet" && bilancodurumu == "gelir tablosu")
            {
                Console.WriteLine("Hizmet sektörü ");
            }
        }
        public void Verial()
        {
            Console.WriteLine("sektör adı giriniz");
            SektorAdi = Console.ReadLine();
            Console.WriteLine("Yatırım şirketi giriniz.. ");
            Yatirimsirketi = Console.ReadLine();
            Console.WriteLine("Bilanço durumunu girin: ");
            BilancoDurumu = Console.ReadLine();
            Console.WriteLine("Sermayeniz ne kadar ");
            SermayeDurumu = Convert.ToInt32(Console.ReadLine());
            sektor(sektoradi, bilancoDurumu);
            Console.Clear();


        }
        public void Yazdir()
        {
            Console.WriteLine("Sektör adı: " + sektoradi);
            Console.WriteLine("Yatırım Şirketi: " + yatirimsirketi);
            Console.WriteLine("Bilanço durumu:" + bilancoDurumu);
            Console.WriteLine("Sermaye: " + sermayeDurumu);
            SermayeBelirleme("türkiye",20000, "türk piyasası");
        }
    }
}

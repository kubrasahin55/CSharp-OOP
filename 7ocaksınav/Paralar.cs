using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ocaksınav
{
    internal class Paralar:Piyasalar
    {
        public string dovizadi;
        public string parabirimi;
        public string dovizmerkezleri;
        public int yiilikArtis;
        public int aylikArtis;

        public override double KomisyonBelirle(string ulke, int hacim, double birimfiyat, double birimsayisi)
        {
            return 0;
        }
        

        public override void SermayeBelirleme(string ulke, int hacim, string durum)
        {
           // throw new NotImplementedException();
        }


        public void Artis(int yillikArtis,int aylikArtis)
        {
            if (yillikArtis>5&& aylikArtis<5)
            {
                yillikArtis = yillikArtis * 5 / 100;
                Console.WriteLine("Yıllık artış miktarı :"+yillikArtis);
            }
        } 

        public void veriAl()
        {
            Console.WriteLine("Döviz Adı Giriniz: ");
            dovizadi =Console.ReadLine();
            Console.WriteLine("Para birimi giriniz: ");
            parabirimi =Console.ReadLine();
            Console.WriteLine("Döviz Merkezinizi yazınız..");
            dovizmerkezleri =Console.ReadLine();
            Console.WriteLine("Yıllık artış miktarını yazın.");
            //yillikArtis = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Aylık artış miktarını yazın: ");
            //aylikArtis = Convert.ToInt32(Console.ReadLine());
            
        }
        public void yazdır()
        {
            Console.WriteLine("döviz adı: "+dovizadi);
            Console.WriteLine("Para birimi : "+parabirimi);
            Console.WriteLine("Döviz Merkezi: "+dovizmerkezleri);
            Console.WriteLine("Yıllık Artış fiyatınız : "+yiilikArtis);
            Console.WriteLine("Aylık Artış Miktarınız: ");
           Artis(6, 4);
            


        }

        
       
    }
}

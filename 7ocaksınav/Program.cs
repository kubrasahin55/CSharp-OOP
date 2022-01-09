using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ocaksınav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Piyasa Ekranına Hoşgeldiniz..");
            Console.WriteLine("Piyasa Seçimi Yapınızzz..");
            Console.WriteLine("1-Kripto");
            Console.WriteLine("2-Borsa");
            Console.WriteLine("3-Paralar");

            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:

                    Console.WriteLine("Kripto Ekranıı");
                    Kripto k1 = new Kripto();
                    k1.VeriAl();
                    k1.yazdır();

                    break;

                case 2:

                    Console.WriteLine("Borsa Ekranı");
                    Borsa b1 = new Borsa();
                    b1.Verial();
                    b1.Yazdir();
                    break;

                case 3:

                    Console.WriteLine("Paralar Ekranı");
                    Paralar p1 = new Paralar();
                    p1.veriAl();
                    p1.yazdır();
                    break;

            }
            Console.ReadKey();
        }
    }
}

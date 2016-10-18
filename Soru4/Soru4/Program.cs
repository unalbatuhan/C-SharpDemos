using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hesaplama Islemleri";
            int a, b, sonuc;
            string secim;
            Console.WriteLine("1- Dikdortgen alan hesaplamak icin..");
            Console.WriteLine("2- Ucgen alanı hesaplamak icin..");
            Console.WriteLine("3- Daire alanı hesaplamak icin..");
            Console.WriteLine("4- Kelime Birlestirmek icin..");
            Console.WriteLine("5- Faktoriyel hesaplamak icin..");
            Console.WriteLine("Seceneklerden Birini Seciniz =");
            secim = Console.ReadLine();
            //Console.Read();
            switch(secim)
            {
                case "1":
                    {
                        Console.Write("Dikdörtgenin kısa kenarını giriniz  : ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Dikdörtgenin uzun kenarını giriniz  : ");
                        b = Convert.ToInt32(Console.ReadLine());
                        sonuc = a * b;
                        Console.ReadKey();
                        //Console.WriteLine("Dikdörtgenin Alanı   : {0}", sonuc); Double k1, k2, cevre, alan;
                        //Console.WriteLine("Kısa Kenarı Giriniz..");
                        //k1 = Convert.ToInt16(Console.ReadLine());
                        //Console.WriteLine("Uzun Kenarı Giriniz..");
                        //k2 = Convert.ToInt16(Console.ReadLine());
                        //cevre = (k1 + k2) * 2;
                        //alan = (k1 * k2);
                        //Console.WriteLine("Dikdörtgenin Çevresi{0} ve alanı {1} dir.", cevre, alan);
                    }
                    break;
                case "2":
                    {
                        Console.Write("Uçgeninin yuksekligini giriniz   : ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Uçgeninin Tabanını giriniz       : ");
                        b = Convert.ToInt32(Console.ReadLine());
                        sonuc = (a * b) / 2;
                        Console.WriteLine("Ucgenin Alani    : {0}", sonuc);
                        Console.ReadKey();

                        
                    }
                    break;
                case "3":
                    {
                        int alan, r;
                        Console.Write("Dairenin Yarıcapını Giriniz :");
                        r = Convert.ToInt16(Console.ReadLine());
                        alan = 3 * r * r;
                        Console.Write("Dairenin alanı..:{0}", alan);
                        Console.ReadKey();
                    }
                    break;
                case "4":
                    {
                        string kelime1, kelime2;
                        Console.WriteLine("Birinci kelimeyi Girin = ");
                        kelime1 = Console.ReadLine();
                        Console.WriteLine("Ikinci kelimeyi girin = ");
                        kelime2 = Console.ReadLine();
                        Console.WriteLine("Birlesmis Hali" + kelime1 + kelime2);
                        Console.ReadKey();

                    }
                    break;
                case "5":
                    {
                        int i, sayi, fakt = 1;
                        Console.Write("Sayı giriniz: ");
                        sayi = Convert.ToInt32(Console.ReadLine());
                        for (i = 1; i <= sayi; i++)
                        {
                            fakt = fakt * i;
                        }
                        Console.Write("Sonuc:" + fakt);
                        Console.ReadKey();
                    }
                    break;
            }
            //string hesaplama;
            //hesaplama = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("1-Dikdörtgenin Alanını Hesaplamak için..");
            //Console.WriteLine("Seçeneklerden birini seçiniz = ");
            //switch(hesaplama)
            //{
            //    case "1":
            //        Double k1, k2, cevre, alan;
            //        Console.WriteLine("Kısa Kenarı Giriniz..");
            //        k1 = Convert.ToInt16(Console.ReadLine());
            //        Console.WriteLine("Uzun Kenarı Giriniz..");
            //        k2 = Convert.ToInt16(Console.ReadLine());
            //        cevre = (k1 + k2) * 2;
            //        alan = (k1 * k2);
            //        Console.WriteLine("Dikdörtgenin Çevresi{0} ve alanı {1} dir.", cevre, alan);
            //        break;
            //}

        }
    }
}
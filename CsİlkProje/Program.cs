using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama_Cikarma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Toplama Ve Çıkarma Yapan C# Programı!

            Console.WriteLine(">>> Hangi İşlemi Yapmak İstiyorsunuz?");
            Console.WriteLine(">>> Toplama <-> Çıkarma");
            string girdi = Console.ReadLine();
            if (girdi.ToLower() == "toplama")
            {
                Console.WriteLine(">>> 1. Sayıyı giriniz lütfen");
                long ilksayi = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(">>> 2. Sayıyı giriniz lütfen");
                long ikincisayi = Convert.ToInt64(Console.ReadLine());
                long toplam = ilksayi + ikincisayi;
                Console.WriteLine(">>> İşlem Sonucu: {0}", toplam);
            }
            else
            {
                Console.WriteLine(">>> 1. Sayıyı giriniz lütfen");
                long ilksayi = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(">>> 2. Sayıyı giriniz lütfen");
                long ikincisayi = Convert.ToInt64(Console.ReadLine());
                long toplam = ilksayi - ikincisayi;
                Console.WriteLine(">>> İşlem Sonucu: {0}", toplam);
            }
            Console.ReadKey();
        }
    }
}
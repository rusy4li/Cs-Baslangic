using System;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World Yazma
            Console.WriteLine(">>> Hello World!"); 
            Console.WriteLine();

            // Integer Veri Tipi #Tam Sayı
            // 2,147,483,647 ve -2,147,483,647 girilebilecek en yüksek sayılardır!
            int sayi1;
            sayi1 = 50000;

            // Long Veri Tipi #Uzun Sayı
            // 9,223,372,036,854 ve -9,223,372,036,854 girilebilecek en yüksek sayılardır!
            long sayi2;
            sayi2 = 9223372036854775807;

            // Short Veri Tipi #Kısa Sayı
            // 32767 ve -32768 girilebilecek en yüksek sayılardır!
            short sayi3;
            sayi3 = 32767;

            // Byte Veri Tipi #Düşük yer kaplar!
            // 0 ve 255 girilebilecek en yüksek sayılardır!
            byte sayi4;
            sayi4 = 255;

            // Double Veri Tipi #Ondalıklı Sayı
            double sayi5;
            sayi5 = 10.4;

            // Decimal Veri Tipi #Ondalıklı Sayı
            decimal sayi6;
            sayi6 = 10.4m;

            // Float Veri Tipi #Ondalıklı Sayı
            float sayi7;
            sayi7 = 10.4F;

            // Bool Veri Tipi #True veya False Girilebiliyor sadece
            bool condition;
            condition = true;

            // Char Veri Tipi #Tek karakter girilebilir sadece 'A','a' gibi
            char character;
            character = 'B';

            // String Veri Tipi #Karakter başıan yer kaplar!
            string greetings;
            greetings = "Hello!";

            // Var Keywords #Girdiğiniz veri türünü değişkenİsmine atıyor!
            var number1 = "Rusy4li";

            // Veri Tipi ve Kapladığı Alan
            // Data Type    |   Size
            //  Integer     |   4 bytes
            //  Long        |   8 bytes
            //  Float       |   4 bytes
            //  Double      |   8 bytes
            //  Bool        |   1 bit 
            //  Char        |   2 bytes
            //  String      |   2 bytes #Karakter başına!

            // Not:
            // 1byte = 8 bit

            // WriteLine Bölümü
            Console.WriteLine(">>> İnt değeri {0}", sayi1);
            Console.WriteLine(">>> Long değeri {0}", sayi2);
            Console.WriteLine(">>> Short değeri {0}", sayi3);
            Console.WriteLine(">>> Byte değeri {0}", sayi4);
            Console.WriteLine(">>> Double değeri {0}", sayi5);
            Console.WriteLine(">>> Decimal değeri {0}", sayi6);
            Console.WriteLine(">>> Float değeri {0}", sayi7);
            Console.WriteLine(">>> Bool değeri {0}", condition);
            Console.WriteLine(">>> Char değeri {0}", character);
            Console.WriteLine(">>> String değeri {0}", greetings);
            Console.WriteLine(">>> Var değeri {0}", number1);
            Console.WriteLine(">>> Enum değeri {0}", Days.Friday);

            Console.ReadKey(); // Cmd'nin kapanmasını engelliyor!
        }
    }
    enum Days // Programı daha okunabilir hale getirmek için kullanıyoruz!
    {
        Monday, Tuesday, Wednesday, Thursday, Friday
    }
}
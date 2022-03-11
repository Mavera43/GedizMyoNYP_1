using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3_1
{
    class veriDonusumleri
    {
        static void Main(string[] args)
        {
            Console.WriteLine(125.8.GetType());
            //  double x = 148.89;
            float f = 148.89f;  //f yada F ekini eklememiz gerekiyor
            decimal d = 148.89m;//m yada M ekini eklememiz gerekiyor

            double i = (3 * (5.7d / 7d));
           Console.WriteLine("Sonuç :{0:N10}", i);



            ////kesirli kısmı kaybetmek istemiyorsak;
            //float x = 3 * (5f / 7f);
            //Console.WriteLine("Sonuç :{0:N10}", x);
            ////----------------------

            //int x1 = 3;
            //int z1 = 5;
            //float y1 = 4.5f;
            //// 3 * 4.5 / 5 = 2.7
            //double fiyat = 187.52;
            ////aşağıdaki her iki kullanımda aynı amaç içindir. Farklı yöntem kullanılmıştır
            //Console.WriteLine("{0} * {1} / {2} = {3:F3}", x1, y1, z1, (x1 * y1 / z1));
            //Console.WriteLine($"{x1} * {y1} / {z1} = {(x1 * y1 / z1)}");
            //Console.WriteLine($"Ürünün fiyatı {fiyat:C}");
            //-------------

            //decimal urunFiyatı = 987.99m;
            //decimal indirimOrani = 0.20m;
            //decimal zamOrani = 0.10m;
            //decimal indirimliFiyat = 0m;
            //decimal zamliFiyat = 0m;
            //// bir sayıyı bir oran miktarınca eksiltmek için;
            //indirimliFiyat = urunFiyatı * (1 - indirimOrani);
            //zamliFiyat = urunFiyatı * (1 + zamOrani);
            //Console.WriteLine($"Ürünün Fiyatı : {urunFiyatı:C3}");
            //Console.WriteLine($"İndirimli Fiyatı : {indirimliFiyat:C3}");
            //Console.WriteLine($"Zamlı Fiyatı : {zamliFiyat:C0}");

            //klavyeden veri girdirmek için Console.ReadLine() metodu kullanılır

            decimal urunFiyatı;
            decimal indirimOrani;
            Console.WriteLine("Ürün Fiyatı Nedir ?");
            //urunFiyatı = Convert.ToDecimal(Console.ReadLine());
            urunFiyatı = decimal.Parse(Console.ReadLine());
            Console.WriteLine("İndirim Oranı nedir ? [ 0,15 gibi ] ");
            // indirimOrani = Convert.ToDecimal(Console.ReadLine());
            indirimOrani = decimal.Parse(Console.ReadLine());

            decimal indirimliFiyat = urunFiyatı * (1 - indirimOrani);
            Console.WriteLine($"İndirimli Fiyat : {indirimliFiyat:C2}");

            Console.ReadLine();













        }
    }
}

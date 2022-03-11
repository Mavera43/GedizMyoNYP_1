using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            vergiTutarıBul();

        }

        private static void vergiTutarıBul()
        {
            /* Örnek: Bu örnekte basit bir vergi hesabı programı geliştirmek istiyoruz.Gelir vergisinin aşağıdaki kurallara göre belirlendiğini varsayalım:*/
            double gelir = 50000, vergi = 0;
           // Console.WriteLine("Gelir Tutarınızı Yazınız ");
           // gelir = float.Parse(Console.ReadLine());

            if (gelir <= 150000)
                vergi = gelir * .25;
             if (gelir <= 300000)
                vergi = gelir * .30;
             if (gelir <= 600000)
                vergi = gelir * .35;
            else  /// if (gelir > 600000)
                vergi = gelir * .40;

            Console.WriteLine($"Hesaplanan vergi {vergi}");
        }

        private static void ifElseif_1()
        {
            //sayının sıfırmı, büyükmü yada küçükmü olduğunu if else if yapısı ile yazalım
            int sayı = -7;
            if (sayı > 0)
                Console.WriteLine("Sayı sıfırdan büyük (pozitif)");
            else if (sayı == 0)
                Console.WriteLine("sayı sıfıra eşit");
            else if (sayı < 0)
                Console.WriteLine("sayı sıfırdan küçük. (negatif)");
            else
                Console.WriteLine("hatalı değer");
        }

        private static void ortalamaHesaplama()
        {
            /* Öğrencinin vize ve final notunu klavyeden aldıktan sonra ortalamasını hesaplayıp,
            * Daha sonra; Final notu 50 ve üzeri ise ve ortalaması 60’ın üzerinde ise GEÇTİ,
            * değilse KALDI yazacak bir C# programı.*/

            float vize, final, ortalama;
            Console.WriteLine("Vize Notu Giriniz");
            vize = float.Parse(Console.ReadLine());
            Console.WriteLine("Final Notu Giriniz");
            final = float.Parse(Console.ReadLine());
            ortalama = (vize * 0.4f) + (final * 0.6f);

            if (ortalama >= 60 && final >= 50)  //&& and yani ve operatörü
                Console.WriteLine($"Geçtiniz. Ortalamanız : {ortalama}");
            else
                Console.WriteLine($"Kaldınız Ortalamanız: { ortalama}");
        }

        private static void netMaas()
        {
            /*   Örnek: Brüt Maaş tutarına göre aşağıda verilen tablodaki vergi kesintisini ve net maaşı hesaplayan programı yapın.
                   Açıklama: Brüt maaşı;
                   2500’den küçük veya eşitse % 10 vergi oranı,
           değilse % 15 vergi oranı kabul ederek;
                   vergi tutarını ve net maaşı hesaplayın.*/
            float brutMaas = 1850.40f;
            float vergiKesintisi = 0; //hesaplatılacak
            float netMaas = 0; //hesaplatılacak
            if (brutMaas <= 2500)
            {
                vergiKesintisi = brutMaas * 0.10f;
                //netMaas = brutMaas - vergiKesintisi;
                //Console.WriteLine($"Vergi Kesintisi : {vergiKesintisi}");
                //Console.WriteLine($"Net Maaş : {netMaas}");
            }
            else
            {
                vergiKesintisi = brutMaas * .15f;
                //netMaas = brutMaas - vergiKesintisi;
                //Console.WriteLine($"Vergi Kesintisi : {vergiKesintisi}");
                //Console.WriteLine($"Net Maaş : {netMaas}");
            }

            netMaas = brutMaas - vergiKesintisi;
            Console.WriteLine($"Vergi Kesintisi : {vergiKesintisi}");
            Console.WriteLine($"Net Maaş : {netMaas}");
        }

        private static void tekCiftSayi()
        {
            Console.WriteLine("Bir Sayı Giriniz : ");
            string sayi = Console.ReadLine();
            int gercekSayi = int.Parse(sayi);
            if (gercekSayi % 2 == 0)
                Console.WriteLine("Sayı çift sayıdır....");
            if (gercekSayi % 2 != 0)
                Console.WriteLine("Sayı Tek sayıdır");
        }
    }
}

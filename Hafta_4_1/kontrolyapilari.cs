using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4_1
{
    class kontrolyapilari
    {
        static void Main(string[] args)
        {
            //2. koşul = ortalaması 3 ve üzeri olanlara +4 kredi ilave edilecek. Krediniz artırıldı şeklinde mesaj yazdıralım. 3'ün altında olanlara +2 kredi ilave edilecek. Yine mesaj yazılacak.
            //ortalama 3'Ün üzerinde ise harç tutarı %50 indirimli olacak.
            double ortalama;
            int alabilecegiKredi= 24;
            ortalama = 3.5;
            alabilecegiKredi = 24;
            double harcTutari = 200;
            if(ortalama>=2 && ortalama <=3)  //ortalama 2 ile 3 arasında mı?
                Console.WriteLine(true);

            if (ortalama >= 3)
            {
                alabilecegiKredi += 4;
                harcTutari /= 2; 
                Console.WriteLine($"Krediniz Artırıldı. Yeni krediniz : {alabilecegiKredi}");
                Console.WriteLine($"Harç Tutarınız azaltıldı. Yeni Harç Tutarınız : {harcTutari}");
            }
            else //if koşulundaki sonuc false olursa burası çalışır
            {
                if (ortalama >= 2)
                {
                    alabilecegiKredi += 2;
                    Console.WriteLine($"Krediniz Artırıldı. Yeni krediniz : {alabilecegiKredi}");
                }
                else
                    Console.WriteLine("Ortalamanız 2'nin altında olduğu için krediniz artırılmadı...");
            }




        }

        private static int ifKosul_1()
        {
            //  if(true)
            //gerçekleşmesini istedipğimiz kodlar
            double ortalama = 2.5;
            int alabilecegiKredi = 24;
            //1. koşul ortalaması 2 ve üzeri olanlara +4 kredi ilave edilecek. Krediniz artırıldı şeklinde mesaj yazdıralım.
            if (ortalama >= 2)
            {
                alabilecegiKredi += 4;
                Console.WriteLine($"Krediniz artırıldı. Yeni krediniz {alabilecegiKredi}");
            }
            Console.WriteLine("---------------------------");
           
            return alabilecegiKredi;
        }
    }
}

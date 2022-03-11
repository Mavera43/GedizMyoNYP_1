using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GedizMyoNYP_1_Hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
             


            // string str;
            //değişken oluşturma ve ilk değerini atama
            string str = "Merhaba Gediz";
            // string x = 10; // hata oluşur. Çünkü değişken tipi ile atanan değer farklı
            //sayısal bir veriyi tırnak içine yazarsak o artık metin(string) olmuş olur.
            string x = "10";
            int oran; //int tipi tamsayılar içindir.

            Console.WriteLine(x);

            oran = 30;
            Console.WriteLine(oran);

            // ondalıklı veri giriş yapabileceğimiz 3 tane değişken tanımlayıp ilk değerlerini 0 olarak verdik
            double vize=50, final=75, ortalama = 80;
          //  vize = 45;
            Console.WriteLine("vize notu :" + vize);

            // bir değişkeni başka bir değişken içerisine aktarabilirsiniz
            //vize = final;
            ortalama = vize * .40 + final * .60;
            Console.WriteLine("Hesaplanan Ortalama :"+ortalama);
            //konsol ekranında ENTER tuşu basılana kadar bekletir.
            //Eğer bir veri girilmişse veriyi de okur.

            //byte b = -10;  hatalı değer aktarımı. Çünkü byte tipi 0 ile 255 arası değer alır.
            string adSoyad = "Kazım Karakaya";
            string _adSoyad = "Osman Fırat";
            string okul="Gediz MYO", OKUL="Tavşanlı MYO"; //ikiside farklı değişkendir. C# büyük küçük harf duyarlıdır.
            Console.WriteLine(okul);
            Console.WriteLine(OKUL);

            //değişkenlere değer atama yaparken mutlaka eşitin solunda değişken olması gerekir. Eşitin sağında ise bir değişken, bir ifade, bir değer olabilir.
            //   "Mühendislik" = okul;  // bu satır yanlış

           // int havaSıcaklıgı = 10; bu tanımlama yerine aşağıdaki kullanılmaldırı.
            sbyte havaSıcaklıgı = -7;
            uint ui;
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);


            //ondalıklı değerleri saklamak için kullanılır.
            //decimal ondalık hassasiyeti en fazla olandır.
            float satısFiyatı1 = 148.13f;
            float satısFiyatı2 = 152.13F;

            double dbl = 8754.187954566d;
            decimal dc = 147899.9874563214775656m;

            char cinsiyet1 = 'E';
            string cinsiyet2 = "E";
            Console.WriteLine("ilk satış fiyatı :"+satısFiyatı1+"\nİkinci satış Fiyatı :"+satısFiyatı2);

            string path = "c:\\windows\\system";
            string fontPath = @"c:\windows\fonts";
            Console.WriteLine(path);
            Console.WriteLine(fontPath);

            string siir = "Neler yapmadık bu vatan için  \nkimimiz öldük, \nKimimiz nutuk söyledik.  \nO.Veli Kanık";
            Console.WriteLine(siir);

            bool sonuc = (50> 10);
            Console.WriteLine("Karşılaştırma sonucu : "+sonuc);

            int b1 = 100;
            int b2 = 150;
            int b3 = 80;
            int fiyat = 900;
            //b1 ve b2 toplamı > b3'ten ve aynı zamanda b1, b2 ve b3 ün toplamı büyük mü fiyattan

            // mantıksal karşılaştırmalarda ve operatoru= &&
            sonuc = ((b1 + b2) > b3) && ((b1 + b3 + b2) > fiyat);
            Console.WriteLine("ve ile Karşılaştırma sonucu : " + sonuc);

            //b1 ve b2 toplamı > b3'ten veya b1, b2 ve b3 ün toplamı büyük mü fiyattan
            // mantıksal karşılaştırmalarda ve operatoru= &&
            sonuc = ((b1 + b2) > b3) || ((b1 + b3 + b2) > fiyat);
            Console.WriteLine("veya ile Karşılaştırma sonucu : " + sonuc);
            //! işareti bir mantıksal sınamanın sonucunun tersini verir.
            //true ise false, false ise true yapar

            sonuc = !(50 > 10);
            

            int a1 = 1;
            double d1 = 8795;
            float f1 = 784221.58745f;
            bool bool1 = true;
            char c1 = 'T';
            object obj = null;
            obj = a1;
            obj = d1;
            obj = f1;
            obj = bool1;
            obj = c1;
            Console.ReadLine();
        }
    }
}

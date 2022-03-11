using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3_2
{
    class turDonusumleri
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tür dönüşümleri");

            byte b = 120;
            int i = 0;
            i = b;  //bilinçsiz tür dönüşümü. Veri kaybı olmaz.
            double d = i;
             decimal dc = (decimal)d;
            // bilinçli tür dönüşümü
            //   decimal dc = 21474836479.45m;
            d  = (int)i;
            i = (int)d; //casting yöntemi. büyük türün küçük türe dönüşümü. Veri kaybı olabilir.
         //   i = Convert.ToInt32(dc);
            Console.WriteLine($"dc'nin değeri : {d}");
            Console.WriteLine($"i'nin değeri : {i}");
            //  Console.WriteLine(int.MaxValue);

            decimal myDecimal = 1.23456789m;
            float myFloat = (float)myDecimal;
            Console.WriteLine($"Decimal: {myDecimal}");
            Console.WriteLine($"Float: {myFloat}");

            int a1 = 355;
            byte b1 = (byte)a1;
            Console.WriteLine(b1);

            //--------------toString() metodu

            int a2 = 6;

            string b2 = a2.ToString();
            b2 = 125.ToString();
            Console.WriteLine(b2);

            string c2 = 12.5f.ToString();
            Console.WriteLine(c2);

            string d2 = 'k'.ToString();
            Console.WriteLine(d2);

            b2 = "587";
            Console.WriteLine($"b2 = {b2} --- {b2.GetType()}");
            int x3 = int.Parse(b2);
            Console.WriteLine($"x3 = {x3} --- {x3.GetType()}");
            x3 = int.Parse("7890");
            Console.WriteLine($"x3 = {x3} --- {x3.GetType()}");

            //Console.WriteLine("----------------");
            //int first = 2;
            //string second = "4";
            //int result = first + int.Parse(second);
            //Console.WriteLine($"sonuc : {result}");

            // Console.WriteLine("----------------");
            // int _first; int _second;
            // string first = "5";
            // string second = "7";
            // int sum=0;
            //// int sum = int.Parse(first) + int.Parse(second);
            // bool bfirst = int.TryParse(first, out _first);
            // bool bsecond = int.TryParse(second, out _second);
            // if (bfirst && bsecond)
            // {
            //     sum = _first + _second;
            //     Console.WriteLine($"Toplam : {sum}");
            // }
            // else
            //     Console.WriteLine("Hatalı veri olduğu için hesaplama işlemi yapılamadı...");
            // Console.WriteLine("-----------------------------");

            string value1 = "5";
            string value2 = "7";
            //int result = value1 * value2; //Aşağıdaki gibi tür dönüşümü gerekir.

            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = false;
            Console.WriteLine("-------------------");
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string

            // küçük tür büyük türe dönüştürülüyor
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double

            //büyük tür küçük türe dönüştürülüyor
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int

            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            Console.WriteLine(Convert.ToInt16(myBool));   // convert bool to int

            int valueCasting = (int)1.5m; // casting yöntemi  ondalık kısmı yok olur
            Console.WriteLine($"valueCasting (casting) : {valueCasting}");

            int valueConvert = Convert.ToInt32(1.5m); // ondalık kısmı yukarı yuvarlanır
            Console.WriteLine($"valueConvert (convert): {valueConvert}");







        }
    }
}

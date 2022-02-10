using System;

namespace Degiskenler_Veri_Tipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            str = "Mert Özdemir";
            string ad = "Mert";
            string soyad = "Özdemir";
            string tamIsım = ad + " " + soyad;
            Console.WriteLine(tamIsım);

            int int1 = 4;
            int int2 = 3;
            int sonuc = int1 * int2;
            Console.WriteLine(sonuc);

            bool b1 = 10 > 2;
            Console.WriteLine(b1);

            string number = "20";
            int number1 = 20;
            string yeniDeger = number + number1.ToString();
            Console.WriteLine(yeniDeger);
            int number2 = number1 + Convert.ToInt32(number);
            Console.WriteLine(number2);


            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);
            
            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);

            

        }
    }
}

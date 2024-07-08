using System;

namespace Operatorler
{
    class Program
    {
        public static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x = 3;
            int y = 5;
            y = y+2;

            Console.WriteLine(y);
            y +=2;

            Console.WriteLine(y);
            y /=2;
 
            Console.WriteLine(y);
            y *=2;

            Console.WriteLine(y);

            Console.WriteLine(x);


            // mantıksal Operatorler

            bool isSuccess = true;
            bool isActive = false;

            if (isSuccess && isActive)
            {
                Console.WriteLine("perfect");
            }
            else if (isSuccess || isActive)
            {
                Console.WriteLine("Good");
            }
            else if (isSuccess && !isActive)
            {
                Console.WriteLine("fine!");
            }

            // ilişkisel Operatorler


            int a = 3;
            int b = 4;

            bool sonuc = a<b;

            Console.WriteLine(sonuc);

            sonuc = a>b;

            Console.WriteLine(sonuc);

            sonuc = a<=b;

            Console.WriteLine(sonuc);

            sonuc = a>=b;

            Console.WriteLine(sonuc);

            sonuc = a!=b;
            Console.WriteLine(sonuc);

            sonuc = a==b;

            Console.WriteLine(sonuc);



            // Aritmetik Operatorler


            int sayi1 = 10;
            int sayi2 = 15;

            int sonuc1 = sayi1 + sayi2;

            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 - sayi2;

            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;

            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 / sayi2;

            Console.WriteLine(sonuc1);

            // mod alma

            int sonuc2 = 20%3;

            Console.WriteLine(sonuc2);


        }
    }
}
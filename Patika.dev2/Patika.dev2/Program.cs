using System;

namespace Patika.dev2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;

            //Mantıksal Operatörler

            if((a < b) && (b > c))
            {
                Console.WriteLine("Fine!");
            }

            if ((a < b) || (b > c))
            {
                Console.WriteLine("Fine!");
            }


            if ((a < b) && !(b > c))
            {
                Console.WriteLine("Fine!");
            }

            //İlişkisel Operatörler

            bool tf = a < b;

            if (a == b)
            {
                Console.WriteLine("Fine!");
            }

            if(a != b)
            {
                Console.WriteLine("Nice!");
            }

            //Aritmetik Operatörler

            Console.WriteLine(a + b + c);

            a = b * 2;
            b = a / 2;
            c = 0;

            Console.WriteLine(a + b + c);




        }
    }
}
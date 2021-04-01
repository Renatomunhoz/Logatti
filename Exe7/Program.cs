using System;

namespace Exe7
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            Console.WriteLine("Informe o primeiro valor:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor:");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a>b) & (a > c))
            {

                Console.WriteLine("O maior número é:" + a);
            }


            if ((b > a) & (b > c))
            {

                Console.WriteLine("O maior número é:" + b);
            }
            else
            {
                Console.WriteLine("O maior número é:" + c);
            }


            

        }
    }
}

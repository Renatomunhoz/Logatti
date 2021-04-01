using System;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {

            int lado1, lado2, lado3;
            
            Console.WriteLine("Informe o valor do lado 1:");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado 2:");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado 3:");
            lado3 = Convert.ToInt32(Console.ReadLine());


            if (lado1 < lado2 + lado3)
            {
                if (lado2 < lado1 + lado3)
                {
                    if (lado3 < lado1 + lado2)
                    {
                        Console.WriteLine("É um triangulo");
                    }
                    else
                    {
                        Console.WriteLine("Não é um triangulo");
                    }
                }
                else
                {
                    Console.WriteLine("Não é um triangulo");
                }

             }
            else
            {
                Console.WriteLine("Não é um triangulo");
            }
        }
    }
}

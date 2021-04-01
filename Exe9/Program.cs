using System;

namespace Exe9
{
    class Program
    {
        static void Main(string[] args)
        {
            float p = 0;
            float maior = 0;
            float media = 0;
            float soma = 0;
            int codigo;

            for (int i = 0; i < 15; i++)
            {

                Console.WriteLine("Informe o código do produto: ");
                codigo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o preço do produto: ");
                p = Convert.ToInt32(Console.ReadLine());

                if (p > maior)
                {
                    maior = p;
                }

                soma = soma + p;

            }

            media = soma / 15;

            Console.WriteLine("O maior preço é:" + maior);
            Console.WriteLine("A soma aritmétcia é:" + media);
        }
    }
}

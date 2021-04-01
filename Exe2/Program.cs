using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            float branco = 0;
            float nulo = 0;
            float valido = 0;
            float total = 0;
            int opcao;
            float  porcent1 = 0;
            float  porcent2 = 0;
            float  porcent3 = 0;

            do
            {

                Console.WriteLine("Informe o seu voto:");
                Console.WriteLine("1 - Branco");
                Console.WriteLine("2 - Nulo");
                Console.WriteLine("3 - Válido ");
                Console.WriteLine("4 - Sair \n");
                opcao = Convert.ToInt32(Console.ReadLine());


                if ((opcao > 4) & (opcao < 1))
                {

                    Console.WriteLine("Informe uma opção correta.");

                }

                if (opcao == 1)
                {
                    branco = branco + 1;
                    total = total + 1;
                }

                if (opcao == 2)
                {
                    nulo = nulo + 1;
                    total = total + 1;
                }

                if (opcao == 3)
                {
                    valido = valido + 1;
                    total = total + 1;
                }



                else
                {
                    if (opcao == 4)
                        Console.WriteLine("\n Fim de Programa");

                }

            } while (opcao != 4);



            porcent1 = ((branco / 100) * total);
            porcent2 = ((nulo / 100) * total);
            porcent3 = ((valido / 100) * total);


            Console.WriteLine("\n TOTAL DE VOTOS:" + total);
            Console.WriteLine("Porcentagem em Branco:" + porcent1);
            Console.WriteLine("\nPorcentagem em Nulo:" + porcent2);
            Console.WriteLine("\n PÇorcentagm em valido:" + porcent2);
        }

    }
}

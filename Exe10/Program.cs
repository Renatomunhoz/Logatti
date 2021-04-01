/*
A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. Faça um
algoritmos para coletar dados sobre o salário e número de filhos de 4 habitantes e após as
leituras, escrever:

a) Média de salário da população
b) Média do número de filhos
c) Maior salário dos habitantes



*/



using System;

namespace Exe10
{
    class Program
    {
        static void Main(string[] args)
        {

            float salario = 0;
            int filho = 0;
            float mediaSalario = 0;
            float maiorSalario = 0;
            float mediaFilho = 0;
           
            

            for (int i = 0; i<4; i++)
            {
                Console.WriteLine("Informe o seu salario:");
                salario = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o numero de filhos:");
                filho = Convert.ToInt32(Console.ReadLine());


                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }
                

            }

            mediaSalario = salario / 4;

            mediaFilho = filho / 4;


            Console.WriteLine("A media de salário da população é:" + mediaSalario);
            Console.WriteLine("A media do número ded filhos é:" + mediaFilho);
            Console.WriteLine("O maior salário da população é:" + maiorSalario);
        }

    }
}

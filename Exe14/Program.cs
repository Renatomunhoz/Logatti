/*Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por
mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das
vendas por ele efetuadas. Escrever um algoritmo que leia o número de carros por ele
vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro
vendido. Calcule e escreva o salário final do vendedor */


using System;

namespace Exe14
{
    class Program
    {
        static void Main(string[] args)
        {

            float salfixo = 0;
            float comissao = 0;
            int carro = 0;
            float vendas = 0;
            float salTotal = 0;
            float valorVendas = 0;

            Console.WriteLine(" Quantos carros o vendedor efetuou:");
            carro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Qual foi o valor total de suas vendas:");
            vendas= int.Parse(Console.ReadLine());


            Console.WriteLine("\n Qual o salário fixo do vendedor:");
            salfixo = int.Parse(Console.ReadLine());


            Console.WriteLine("\n Qual o valor que o vendedor recebe por carro vendido:");
            comissao = int.Parse(Console.ReadLine());



            valorVendas = ((vendas/100)* 5);

            salTotal = (carro * comissao) + salfixo +  valorVendas;



            Console.WriteLine("O salário total do funcionário é:" + salTotal);
            

        }


    }
}

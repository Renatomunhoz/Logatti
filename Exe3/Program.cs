/*O custo de um carro novo ao consumidor é a soma do custo de fábrica coma porcentagem
do distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que o percentual do
distribuidor seja de 28% e os impostos de 45%, escrever um algoritmo para ler o custo de
fábrica de um carro, calcular e escrever o custo final ao consumidor */


using System;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorC = 0;
            int valorF = 0;
            int valorI = 0;
            int soma = 0;
            Console.WriteLine("Qual o valor do carro para fábrica:");
            valorF = int.Parse(Console.ReadLine());

            valorC = ((valorF /100) * 28) ;
            valorI = ((valorF / 100) * 45);

            soma = (valorC + valorI) + valorF;
            Console.WriteLine("O valor do carro para o consumidor é:" + soma);      
        }
    }
}

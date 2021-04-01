using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 0;
            int dia = 0;
            int mes = 0;


            Console.WriteLine("Qual a sua idadde:");
            idade = Console.ReadLine();

            dia = idade * 365;
            mes = dia / 12;

            Console.WriteLine("Sua idade em dias eh:", dia);
        }
    }
}

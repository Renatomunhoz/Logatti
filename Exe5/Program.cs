/*Tendo como dados de entrada o nome, a altura e o sexo (M ou F) de uma pessoa, calcule e
mostre seu peso ideal, utilizando as seguintes fórmulas:
- para sexo masculino: peso ideal = (72.7 * altura) - 58
- para sexo feminino: peso ideal = (62.1 * altura) - 44.7 */



using System;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {

            String nome;
            int sexo;
            float pesoideal, altura;
            
            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual o seu sexo?");
            Console.WriteLine(" 1 - M ou \n 2 - F");
            sexo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a sua altura:");
            altura = int.Parse(Console.ReadLine());

            if (sexo == 1)
            {
                pesoideal = (72, 7 * altura) - 58;
            }
            else
            {
                pesoideal = (62,1 * altura) - 44,7;

            }



            Console.WriteLine("O seu peso ideal é:" + pesoideal);





        }
    }
}

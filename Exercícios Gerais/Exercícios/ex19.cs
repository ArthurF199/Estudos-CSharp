using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex19
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n*i}");
            }
        }
    }
}

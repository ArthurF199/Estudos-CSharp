using System;
using System.Collections.Generic;
using System.Text;

//Soma de números

//Peça ao usuário um número N.
//Use um for para somar todos os números de 1 até N e mostre o resultado.

namespace Controle_de_Fluxo.Laços_de_Repetição.ForLoop
{
    internal class Ex05
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            int soma = new();

            for (int i = 1; i <= num; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma de todos os números de 1 até {num} é {soma}");
        }
    }
}

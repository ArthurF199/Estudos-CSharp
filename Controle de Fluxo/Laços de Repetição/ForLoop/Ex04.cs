using System;
using System.Collections.Generic;
using System.Text;

//Tabuada

//Peça ao usuário um número inteiro.
//Use um for para mostrar a tabuada desse número de 1 a 10.

namespace Controle_de_Fluxo.Laços_de_Repetição.ForLoop
{
    internal class Ex04
    {
        public static void Executar()
        {
            Console.Write("Qual tabuada deseja ver? ");
            int num = int.Parse(Console.ReadLine());


            Console.WriteLine($"Tabuada do {num}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num*i}");
            }
        }
    }
}

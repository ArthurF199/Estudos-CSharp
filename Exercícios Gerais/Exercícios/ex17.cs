using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex17
    {
        public static void Executar()
        {
            Console.Write("Nota: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
            } else if (nota >= 5)
            {
                Console.WriteLine("Recuperação");
            } else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}

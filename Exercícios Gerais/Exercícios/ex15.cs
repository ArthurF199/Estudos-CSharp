using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization.Metadata;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex15
    {
        public static void Executar()
        {
            Console.Write("Nota 1: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine(nota1 > nota2);
            Console.WriteLine(nota1 < nota2);
            Console.WriteLine(nota1 == nota2);
            Console.WriteLine(nota1 != nota2);
            Console.WriteLine(nota1 >= nota2);
            Console.WriteLine(nota1 <= nota2);
        }
    }
}

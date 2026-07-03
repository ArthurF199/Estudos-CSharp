using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex13
    {
        public static void Executar()
        {
            Console.Write("Número 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(
                $"""
                Soma: {n1 + n2}
                Subtração: {n1 - n2}
                Multiplicação: {n1 * n2}
                Divisão: {n1 / n2}
                """);
        }
    }
}

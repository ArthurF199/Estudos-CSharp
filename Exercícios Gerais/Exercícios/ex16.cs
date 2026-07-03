using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex16
    {
        public static void Executar()
        {
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Possui carteira? (True ou False): ");
            bool possuiCarteira = bool.Parse(Console.ReadLine());

            Console.WriteLine($"Pode dirigir? {idade >= 18 && possuiCarteira}");
        }
    }
}

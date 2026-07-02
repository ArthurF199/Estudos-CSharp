using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex12
    {
        public static void Executar()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            int altura = int.Parse(Console.ReadLine());

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}

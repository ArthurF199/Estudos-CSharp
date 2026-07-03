using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex23
    {
        public static void Executar()
        {
            int notas = 0;
            string situacao = "";

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Quantas notas você possui? ");
            int quantNotas = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantNotas; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                int nota = int.Parse(Console.ReadLine());
                notas += nota;
            }

            if (notas / quantNotas >= 5)
            {
                situacao = "Aprovado";
            }
            else if (notas / quantNotas < 5)
            {
                situacao = "Reprovado";
            }
            else
            {
                situacao = "Recuperação";
            }


            Console.WriteLine(
                $"""
                Aluno: {nome}
                Média: {notas / quantNotas}
                Situação: {situacao}
                """);
        }
    }
}

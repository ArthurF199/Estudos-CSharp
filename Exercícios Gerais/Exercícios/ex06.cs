using System;
using System.Collections.Generic;
using System.Text;


namespace Exercícios_Gerais.Exercícios
{
    internal class ex06
    {
        public static void Executar()
        {
            Console.Write("Quantos números irá digitar? ");
            int nQuant = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 0;
            int maior = 0;

            for (int i = 0; i < nQuant; i++)
            {   

                if (i % 2 == 0)
                {   
                    Console.Write("Digite um número: ");
                    n1 = int.Parse(Console.ReadLine());
                } else
                {          
                    Console.Write("Digite um número: ");
                    n2 = int.Parse(Console.ReadLine());
                }

                if (n1+1 == n2 && n2 > maior)
                {
                    maior = n2;
                } else if (n1-1 == n2 && n1 > maior)
                {
                    maior = n1;
                }
            }

            Console.WriteLine($"Maior sequência: {maior}");
        }
    }
}
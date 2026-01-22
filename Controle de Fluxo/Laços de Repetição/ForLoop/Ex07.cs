using System;
using System.Collections.Generic;
using System.Text;

//Maior e menor número

//Peça ao usuário quantos números ele vai digitar.
//Use um for para descobrir:

//O maior

//O menor número informado

namespace Controle_de_Fluxo.Laços_de_Repetição.ForLoop
{
    internal class Ex07
    {
        public static void Executar()
        {
            int quantidade = int.Parse(Console.ReadLine());
            int maior = new();
            int menor = new();

            for (int i = 0; i < quantidade; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i == 0) { maior = num; menor = num; }
                else
                {
                    if (num > maior)
                    {
                        maior = num;
                    } else if (num < menor)
                    {
                        menor = num;
                    }
                }
            }


            Console.WriteLine(maior);
            Console.WriteLine(menor);
        }
    }
}

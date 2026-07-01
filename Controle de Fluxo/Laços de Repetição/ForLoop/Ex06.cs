using System;
using System.Collections.Generic;
using System.Text;

//Peça ao usuário:

//Um número inicial

//Um número final

//Use um for para contar quantos números são múltiplos de 3 nesse intervalo.

namespace Controle_de_Fluxo.Laços_de_Repetição.ForLoop
{
    internal class Ex06
    {
        public static void Executar()
        {
            int numInicial = int.Parse(Console.ReadLine());
            int numFinal = int.Parse(Console.ReadLine());
            int multiplosDe3 = new();

            Console.Write($"No intervalo de {numInicial} e {numFinal}, existem ");
            

            for (int i = numInicial; i <= numFinal; i++)
            {
                if (i % 3 == 0)
                {
                    multiplosDe3++;
                }
            }

            Console.Write($"{multiplosDe3} múltiplos de 3");
        }
    }
}

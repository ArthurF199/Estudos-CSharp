using System;
using System.Collections.Generic;
using System.Text;

//Exercício 1

//Imprima os números de 0 a 20, pulando de 2 em 2.

namespace Controle_de_Fluxo.Laços_de_Repetição.ForLoop
{
    internal class Ex01
    {
        public static void Executar()
        {
            for (int i = 0; i <= 20; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}

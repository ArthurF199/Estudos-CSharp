using System;
using System.Collections.Generic;
using System.Text;

//Exercício 2

//Imprima os números de 20 até 0.

namespace Controle_de_Fluxo.Laços_de_Repetição.ForLoop
{
    internal class Ex02
    {
        public static void Executar()
        {
            for (int i = 20; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

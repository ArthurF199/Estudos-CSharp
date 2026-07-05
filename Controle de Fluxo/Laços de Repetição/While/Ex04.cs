using System;
using System.Collections.Generic;
using System.Text;


// Faça uma contagem regressiva de 10 até 0.

namespace Controle_de_Fluxo.Laços_de_Repetição.While
{
    internal class Ex04
    {
        public static void Executar()
        {
            int i = 10;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.WriteLine("FIM");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;


// Mostre os números de 1 até 20 usando while.

namespace Controle_de_Fluxo.Laços_de_Repetição.While
{
    internal class Ex01
    {
        public static void Executar()
        {
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

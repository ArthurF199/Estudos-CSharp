using System;
using System.Collections.Generic;
using System.Text;


// Mostre os números pares entre 0 e 100.

namespace Controle_de_Fluxo.Laços_de_Repetição.While
{
    internal class Ex02
    {
        public static void Executar()
        {
            int numero = 0;

            while (numero <= 100)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;


// Calcule a soma dos números de 1 até 100 usando while.

namespace Controle_de_Fluxo.Laços_de_Repetição.While
{
    internal class Ex03
    {
        public static void Executar() 
        {
            int soma = 0;
            int i = 1;

            while (i <= 100)
            {
                soma = soma + i;
                i++;
            }

            Console.WriteLine(soma);
        }
    }
}

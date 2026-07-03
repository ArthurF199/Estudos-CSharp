using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex20
    {
        public static void Executar()
        {
            int c = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    c++;
                }
            }

            Console.WriteLine(c);
        }
    }
}

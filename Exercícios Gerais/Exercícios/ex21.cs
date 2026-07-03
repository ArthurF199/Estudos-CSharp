using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex21
    {
        public static void Executar()
        {
            int a = 10;
            int b = a;

            Console.WriteLine(a);
            Console.WriteLine(b);
            b = 20;
            Console.WriteLine(a);
            Console.WriteLine(b);


            string nome1 = "Arthur";
            string nome2 = nome1;

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            nome2 = "Pedro";
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex04
    {
        public static void Executar()
        {
            int numQuantity = int.Parse(Console.ReadLine());
            int negative = 0;
            int positive = 0;
            int zero = 0;

            for (int i = 1; i < numQuantity; i++)
            {
                if (int.Parse(Console.ReadLine()) > 0)
                {
                    positive += 1;
                } else if (int.Parse(Console.ReadLine()) < 0)
                {
                    negative += 1;
                } else
                {
                    zero += 1;
                }
            }

            Console.WriteLine($"There are {negative} negative numbers.");
            Console.WriteLine($"There are {zero} zero numbers.");
            Console.WriteLine($"There are {positive} positive numbers.");
        }
    }
}
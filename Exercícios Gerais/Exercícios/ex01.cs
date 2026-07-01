using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex01
    {
        public static void Executar()
        {   
            Console.Write("How many numbers? ");
            int numberQuantity = int.Parse(Console.ReadLine());
            int Highest = 0;
            int Lowest = 0;
            int evenQuantity = 0;
            int oddQuantity = 0;
            int numberAverage = 0;

            for (int i = 0; i < numberQuantity; i++)
            {   
                Console.Write("Type a number: ");
                int n = int.Parse(Console.ReadLine());

                // Even and Odd Number
                if (n % 2 == 0)
                {
                    evenQuantity ++;
                } else
                {
                    oddQuantity ++;
                }

                // Highest and Lowest Number
                if (i == 0)
                {   
                    Highest = n;
                    Lowest = n;
                } else if (n > Highest)
                {
                    Highest = n;
                } else if (n < Lowest)
                {
                    Lowest = n;
                }

                // Number Average
                numberAverage += n;
            }

            Console.WriteLine($"Highest Number: {Highest}");
            Console.WriteLine($"Lowest Number: {Lowest}");
            Console.WriteLine($"Even Quantity: {evenQuantity}");
            Console.WriteLine($"Odd Quantity: {oddQuantity}");
            Console.WriteLine($"Number Average: {numberAverage/numberQuantity}");
        }   
    }
}

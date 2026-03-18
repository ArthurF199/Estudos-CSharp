using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex03
    {
        public static void Executar()
        {   
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");

            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a operação que deseja (1-4): ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                    break;
                case 2:
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                    break;
                case 3:
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                    break;
                case 4:
                    if (n1 == 0 || n2 == 0)
                    {
                        Console.WriteLine($"{n1} / {n2} = 0");
                    } else
                    {
                        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                    }
                    break;
            }
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

//Peça ao usuário:

//Dois números inteiros

//Uma operação:

//+

//-

//*

///

//Use switch para:

//Realizar a operação escolhida

//Mostrar o resultado

namespace Controle_de_Fluxo.Switch
{
    internal class Ex03_Calculadora
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a operação que deseja(+ - * /): ");
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"O resultado da operação é {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"O resultado da operação é {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"O resultado da operação é {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"O resultado da operação é {num1 / num2}");
                    break;
            }
        }
    }
}

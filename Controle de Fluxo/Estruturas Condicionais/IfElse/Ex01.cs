using System;
using System.Collections.Generic;
using System.Text;

//Peça ao usuário sua idade e mostre se ele é maior ou menos de idade 

namespace Controle_de_Fluxo.Estruturas_Condicionais.IfElse
{
    internal class Ex01
    {
        public static void Executar()
        {
            Console.Write("Qual a sua idade?");
            int Idade = int.Parse(Console.ReadLine());

            if (Idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            } else
            {
                Console.WriteLine("Você é menor de idade");
            }
        }
    }
}

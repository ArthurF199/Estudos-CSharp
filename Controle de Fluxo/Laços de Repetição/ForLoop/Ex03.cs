using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Text;

//Exercício 3

//Dado:

//int[] valores = { 5, 8, 2, 10 };


//Use for para:

//Somar todos os valores

//Mostrar o resultado final

namespace Controle_de_Fluxo.Laços_de_Repetição.ForLoop
{
    internal class Ex03
    {
        public static void Executar()
        {
            int[] valores = { 5, 8, 2, 10 };
            int soma = new();


            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }
            
            Console.WriteLine(soma);
        }
    }
}

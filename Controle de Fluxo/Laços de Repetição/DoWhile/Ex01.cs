using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;


// Peça números ao usuário até que ele digite 0.

namespace Controle_de_Fluxo.Laços_de_Repetição.DoWhile
{
    internal class Ex01
    {
        public static void Executar()
        {
            int numero = 0;
            do
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero != 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

//Peça ao usuário suas notas dos 4 bimestres, depois, mostre a média e se passou de ano ou não.

namespace Controle_de_Fluxo.Estruturas_Condicionais.IfElse
{
    internal class Ex02
    {
        public static void Executar()
        {
            int[] nota = { 0, 0, 0, 0 };
            double media = new();
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Qual foi a sua nota do {i} Bimestre: ");
                nota[i - 1] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nota.Length; i++)
            {
                media += nota[i];
            }

            if ((media /= 4) > 6)
            {
                Console.WriteLine($"Sua média foi de {media}");
                Console.WriteLine("Aprovado!!!");
            } else
            {
                Console.WriteLine($"Sua média foi de {media}");
                Console.WriteLine("Reprovado!!!");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_de_Fluxo.IfElse
{
    internal class Ex02_Nota
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
            media /= 4;
            Console.WriteLine(media);
        }
    }
}

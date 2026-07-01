using System;
using System.Collections.Generic;
using System.Text;


namespace Exercícios_Gerais.Exercícios
{
    internal class ex05
    {
        public static void Executar()
        {   
            bool executar = true;
            while (executar)
            {
                Console.Write("Digite o número da tabuada que deseja: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n}*{i}={n*i}");
                }


                Console.WriteLine("""
                Deseja ver outra tabuada?
                1 - Sim
                2 - Não
                
                Digite o número da ação que deseja: 
                """);
                switch (int.Parse(Console.ReadLine())) {
                    case 1:
                        continue;
                    case 2:
                        executar = false;
                        break;
                }
            }
        }
    }
}
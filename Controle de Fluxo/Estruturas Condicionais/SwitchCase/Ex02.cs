using System;
using System.Collections.Generic;
using System.Text;

// Mostre o seguinte menu no console:

//1 - Iniciar
//2 - Configurações
//3 - Sair


//Peça para o usuário escolher uma opção.

//Use switch para:

//1 → Mostrar "Iniciando..."

//2 → Mostrar "Abrindo configurações..."

//3 → Mostrar "Saindo..."

//Qualquer outro valor → "Opção inválida"

namespace Controle_de_Fluxo.Estruturas_Condicionais.Switch
{
    internal class Ex02
    {
        public static void Executar()
        {
            Console.WriteLine(
                """
                1 - Iniciar
                2 - Configurações
                3 - Sair
                """);

            Console.Write("Selecione uma opção: ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Iniciando...");
                    break;
                case 2:
                    Console.WriteLine("Abrindo configurações...");
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

        }
    }
}

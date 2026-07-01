using System;
using System.Collections.Generic;
using System.Text;

//Peça para o usuário digitar um número de 1 a 7.

//Use switch para:

//1 → Domingo

//2 → Segunda-feira

//3 → Terça-feira

//4 → Quarta-feira

//5 → Quinta-feira

//6 → Sexta-feira

//7 → Sábado

//Se o número for inválido, mostre uma mensagem de erro.

namespace Controle_de_Fluxo.Estruturas_Condicionais.Switch
{
    internal class Ex01
    {
        public static void Executar()
        {
            Console.Write("Digite um número de 1 a 7: ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Valor Inválido.");
                    break;
            }
        }
    }
}

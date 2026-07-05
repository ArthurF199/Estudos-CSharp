using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;


// Peça uma senha até que seja digitado:

namespace Controle_de_Fluxo.Laços_de_Repetição.DoWhile
{
    internal class Ex02
    {
        public static void Executar()
        {
            string senha = "";
            do
            {
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();
            } while (senha != "admin123");
        }
    }
}

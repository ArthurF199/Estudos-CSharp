using System;
using System.Collections.Generic;
using System.Text;


// Crie um menu que continue aparecendo até o usuário escolher sair.

namespace Controle_de_Fluxo.Laços_de_Repetição.DoWhile
{
    internal class Ex03
    {
        public static void Executar()
        {
            do
            {
                Console.Write(
                    """
                    1 - Jogar
                    2 - Configurações
                    3 - Créditos
                    0 - Sair
                    Escolha uma opção: 
                    """);
            } while (int.Parse(Console.ReadLine()) != 0);
        }
    }
}

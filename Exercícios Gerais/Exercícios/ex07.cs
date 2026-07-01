namespace Exercícios_Gerais.Exercícios
{
    internal class ex07
    {
        public static void Executar()
        {   
            Console.Write("Digite o número inicial: ");
            int nInicial = int.Parse(Console.ReadLine());

            Console.Write("Digite o número final: ");
            int nFinal = int.Parse(Console.ReadLine());

            int multiplos2 = 0;
            int multiplos3 = 0;
            int multiplos5 = 0;

            for (int i = nInicial; i <= nFinal; i++)
            {
                if (i % 2 == 0)
                {
                    multiplos2 += 1;
                }

                if (i % 3 == 0)
                {
                    multiplos3 += 1;
                }

                if (i % 5 == 0)
                {
                    multiplos5 += 1;
                }
            }

            Console.WriteLine($"Dentre {nInicial} e {nFinal} temos:");
            Console.WriteLine($"Múltiplos de 2: {multiplos2}");
            Console.WriteLine($"Múltiplos de 3: {multiplos3}");
            Console.WriteLine($"Múltiplos de 5: {multiplos5}");
        }
    }
}
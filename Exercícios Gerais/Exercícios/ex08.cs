namespace Exercícios_Gerais.Exercícios
{
    internal class ex08
    {
        public static void Executar()
        {
            Console.Write("Quantos números? ");
            int nQuant = int.Parse(Console.ReadLine());

            int maior1 = 0;
            int maior2 = 0;

            for (int i = 0; i < nQuant; i++)
            {
                Console.Write("Digite um número: ");
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Número Inválido!");
                    return;
                }

                if (n > maior1)
                {   
                    maior2 = maior1;
                    maior1 = n;
                } else if (n > maior2)
                {
                    maior2 = n;
                }
                Console.WriteLine($"{maior1} {maior2}");
            }

            Console.WriteLine(maior1);

        }
    }
}
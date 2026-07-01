namespace Exercícios_Gerais.Exercícios
{
    internal class ex10
    {
        public static void Executar()
        {   
            Console.Write("Quantas pessoas irão votar? ");
            int pQuant = int.Parse(Console.ReadLine());
            int votosA = 0;
            int votosB = 0;
            int votosNull = 0;


            for (int i = 0; i < pQuant; i++)
            {
                Console.WriteLine("1 - Candidato A");
                Console.WriteLine("2 - Candidato B");
                Console.WriteLine("3 - Branco");

                Console.Write("Qual o seu voto? ");
                int voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        votosA++;
                        break;
                    case 2:
                        votosB++;
                        break;
                    case 3:
                        votosNull++;
                        break;
                }
            }

            Console.WriteLine($"Candidato A - {votosA} votos.");
            Console.WriteLine($"Candidato B - {votosB} votos.");
            Console.WriteLine($"Branco - {votosNull} votos.");
            
            if (votosA > votosB || votosA > votosNull)
            {
                Console.WriteLine("Candidato A venceu!!!");
            }
            else if (votosB > votosA || votosB > votosNull)
            {
                Console.WriteLine("Candidato B venceu!!!");
            }
        }
    }
}
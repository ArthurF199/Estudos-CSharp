using System;


namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua nota: ");
            int nota = int.Parse(Console.ReadLine());
            if (nota >= 9)
            {
                Console.WriteLine("Excelente!");
            } else if (nota >= 6)
            {
                Console.WriteLine("Aprovado");
            } else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }

}




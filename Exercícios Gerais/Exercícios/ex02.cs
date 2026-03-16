using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Gerais.Exercícios
{
    internal class ex02
    {
        public static void Executar()
        {   
            Console.Write("How many grades? ");
            int gradesQuantity = int.Parse(Console.ReadLine());
            float gradesAverage = 0;
            int averageGradesQuantity = 0;
            int nonAverageGradesQuantity = 0;
            int passQuantity = 0;
            int remedialQuantity = 0;
            int failedQuantity = 0;

            for (int i = 1; i <= gradesQuantity; i++)
            {   
                Console.Write($"Grade: ");
                int grade = int.Parse(Console.ReadLine());
                
                gradesAverage += grade;
                

                switch (grade)
                {      
                    case > 7:
                        averageGradesQuantity += 1;
                        passQuantity += 1;
                        break;
                    case > 5:
                        averageGradesQuantity += 1;
                        remedialQuantity += 1;
                        break;
                    default:
                        failedQuantity += 1;
                        break;
                }


            }
            gradesAverage /= gradesQuantity;
            
            Console.WriteLine($"There is {gradesAverage} of grade average.");
            Console.WriteLine($"There are {averageGradesQuantity} of grades above average.");
            Console.WriteLine($"There are {nonAverageGradesQuantity} of grade not above average.");
            Console.WriteLine($"There are {passQuantity} students who passed.");
            Console.WriteLine($"There are {remedialQuantity} students on remedial class.");
            Console.WriteLine($"There are {failedQuantity} students who failed.");
        }   
    }
}

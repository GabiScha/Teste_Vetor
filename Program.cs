using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1_pg72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Escreva o vetor correspondente a " + i);
                vetor[i] = int.Parse(Console.ReadLine());

                Console.Clear();
            }

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("O vetor " + i + " coresponde a " + vetor.GetValue(i));
                 

            }





            Console.ReadKey();







        }
    }
}

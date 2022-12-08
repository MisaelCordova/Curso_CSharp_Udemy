using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 numeros");
            int[] vetor = new int[10];
            for(int i=0; i < 10; i++)
            {
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i < 10;i++) {
                Console.WriteLine($"numero {i+1}: " + Convert.ToString(vetor[i]));
            }
            for(int i=0; i < 10;)
            Console.ReadKey();

        }
    }
}

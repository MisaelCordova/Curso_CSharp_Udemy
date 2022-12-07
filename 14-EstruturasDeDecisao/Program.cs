using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_EstruturasDeDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            UInt32 idade = Convert.ToUInt32(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }

            Console.WriteLine("Digite seu salario");
            UInt32 salario = Convert.ToUInt32(Console.ReadLine());
            if (salario < 1000)
            {
                Console.WriteLine("Você ganha menos que 1 salario minimo");

            }
            else if (salario < 2000)
            {
                Console.WriteLine("Você ganha menos que 2 salario minimo");
            }
            else if (salario < 5000)
            {
                Console.WriteLine("Você ganha 5 salarios Minimos");
            }
            else
            {
                Console.WriteLine("Você é rico");
            }
           

            Console.WriteLine("Pressione uma tecla do teclado:");
            char tecla  = Console.ReadKey(true).KeyChar;
            switch(tecla)
            {
                case 'a':
                    Console.WriteLine("Você pressionou a");
                    break;
                case 'b':
                    Console.WriteLine("Você pressionou b");
                    break;
                case 'c':
                    Console.WriteLine("Você pressionou c");
                    break;
                default:
                    Console.WriteLine("Eu desconheço essa tecla");
                    break;
            }

     
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_LacosDeRepeticao_break_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pressione C para continue");
                Console.WriteLine("Pressione B para break");
                string tecla = Console.ReadKey().KeyChar.ToString();
                if (tecla == "c")
                {
                    continue;
                }
                else if(tecla=="b")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida");
                }
                Console.WriteLine("pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("pressione qualquer tecla para sair");
            Console.ReadLine();

        }
    }
}

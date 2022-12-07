using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MaisSobreOperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;
            bool ResultadoOu_1 = var1 |var2;
            bool ResultadoOU_2 = var1 ||var2;

            bool ResultadoE_1 = var1 & var2;
            bool ResultadoE_2 = var1 && var2;

            Console.WriteLine(ResultadoOu_1);
            Console.WriteLine(ResultadoOU_2);
            Console.WriteLine(ResultadoE_1);
            Console.WriteLine(ResultadoE_2);    
            Console.ReadKey();

        }
    }
}

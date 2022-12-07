using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;
            //negacao
            bool resultadoNegacao = !var1;
            Console.WriteLine(resultadoNegacao);
            /// E
            bool resultadoE = var1 & var2;
            Console.WriteLine("Resultado E "+resultadoE);
            // OU
            bool resultadoOu =  var1 | var2;
            Console.WriteLine("resultado OU " + resultadoOu);

            // Ou excluisivo
            bool resultadoXor = var1 ^ var2;
            Console.WriteLine("Resultado XOR "+resultadoXor);

            Console.ReadKey();
        }
    }
}

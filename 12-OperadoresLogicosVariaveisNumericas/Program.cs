using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OperadoresLogicosVariaveisNumericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Negacao ~ 
            int var1 = 0b11001100;
            int resultadoNegacao = ~var1;
            Console.WriteLine("negacao é"+Convert.ToString(var1,2)+" é "+Convert.ToString(resultadoNegacao,2));
            

            //Operador OU 
            int var2 = 0b11001100;
            int var3 = 0b11110000;
            int resultadoOU =  var2 | var3;
            Console.WriteLine("Operador ou é " + Convert.ToString(var2, 2) + " é " + Convert.ToString(resultadoOU, 2));

            //Operador E
            int resultadoE = var2 & var3;
            Console.WriteLine("Operador E é " + Convert.ToString(var2, 2) + " é " + Convert.ToString(resultadoE, 2));

            //Operador OU exclusivo (XOR) - 
            int resultadoXOR = var2 ^ var3;
            Console.WriteLine("Operador XOR é " + Convert.ToString(var2, 2) + " é " + Convert.ToString(resultadoXOR, 2));

            // Operador > e <
            int var4 = 10;
            int var5 = 20;
            Console.WriteLine("maior que "+(var4 > var5));
            Console.WriteLine("maior que " + (var4 < var5));

            //maior >= e <=
            Console.WriteLine("maior que " + (var4 >= var5));
            Console.WriteLine("maior que " + (var4 <= var5));
            Console.WriteLine("maior que " + (var5 >= var5));
            Console.WriteLine("maior que " + (var5 <= var5));

            // Operador igual - ==

            bool resultadoIgual = (var4 == var4);
            Console.WriteLine("resultado igual "+resultadoIgual);
            resultadoIgual = (var4 == var5);
            Console.WriteLine(resultadoIgual);
            Console.ReadKey();
        }
    }
}

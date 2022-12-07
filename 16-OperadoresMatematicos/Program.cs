using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OperadoresMatematicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 15.5, n2 = 10;
            //soma
            double resultadoSoma = n1 + n2;
            Console.WriteLine("Resultado Soma "+resultadoSoma);
            //subtracao
            double resultadoSubtracao = n1 - n2;
            Console.WriteLine("Resultado Subtração "+resultadoSubtracao);
            //multiplicação
            double resultadoMultiplicacao = n1 * n2;
            Console.WriteLine("Resultado Multiplição "+resultadoMultiplicacao);
            //Divisao
            double resultadoDivisao = n1 / n2;
            Console.WriteLine(resultadoDivisao);
            //resto % 
            int n3 = 4;
            int n4 = 3,n5 = 5, n6 = 10;
            int resultadoResto = n3 % n4;
            Console.WriteLine(resultadoResto);

            Console.WriteLine(n5);
            //soma resumida, pega o valor de n3 adciona 10
            n3 += 10;
            // subtracao resumida
            n4 -= 10;
            // multiplicacao
            n5 *= 10;   
            n6 /= 10;
            int n7 = 7;
            n7++;// poscremento
            --n6;//antecremento

            Console.WriteLine($"soma n3: {n5} ");
            Console.WriteLine("subtracao n4: " + n4);
            Console.WriteLine("multiplicacao n5: " + n5);
            Console.WriteLine(" divisao n6: " + n6);
            Console.WriteLine("incremento n7: " + n7);
            Console.WriteLine("decremento n7: " + n7--);
            Console.WriteLine("decremento pos n7: " + n7);
           
        }
    }
}

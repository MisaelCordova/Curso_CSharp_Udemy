using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OperadoresMatematicosAvancados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double potenciacao = Math.Pow(4, 2);
            Console.WriteLine(potenciacao);

            double raiz = 3;
            double radiciacao = Math.Pow(27, 1/raiz);
            Console.WriteLine(radiciacao);

            double maximo = Math.Max(4, 8);
            Console.WriteLine(maximo);

            double minimo  = Math.Min(4, 8);

            double modulo = Math.Abs(-10);
            Console.WriteLine(modulo);
            
            /// trigonometria
            double angulo = 30* (2*Math.PI)/360;
            //sin seno cos cosseno
            double seno = Math.Sin(angulo);
            Console.WriteLine(angulo);

            //arcseno - Asin
            // ArcoCosseno
            // ArcTangente
            double arseno = Math.Asin(seno);
            Console.WriteLine(arseno);

            double arsenoGraus = arseno *360/(2*Math.PI);
            Console.WriteLine(arsenoGraus);

            double numero = 3.33;
            double arredondaParaCima = Math.Ceiling(numero);
            Console.WriteLine(arredondaParaCima);

            double arredondaParaBaixo = Math.Floor(numero);
            Console.WriteLine(arredondaParaBaixo);

            //Logaritimo
            double base10 = Math.Log10(100);
            Console.WriteLine(base10);

            double baseE = Math.Log(Math.E * Math.E * Math.E);

            Console.WriteLine(baseE);

            Console.ReadKey();
            
        }
    }
}

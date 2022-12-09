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
            int[] MeuArray = new int[3];
            // outra formas de criar um array
            int[] meuArray1 = {1,2,4,5};
            //array de 2 dimensões 
            string[,] MeuArray2 = new string[2, 3];
            MeuArray2[0, 0] = "1";
            MeuArray2[0, 1] = "2";
            MeuArray2[0,2] = "3";
            MeuArray2[1, 0] = "11";
            MeuArray2[1, 1] = "12";
            MeuArray2[1, 0] = "13";

            Console.WriteLine(MeuArray2[0, 0]);
            Console.WriteLine(MeuArray2[0, 1]);
            Console.WriteLine(MeuArray2[0, 2]);

            Console.WriteLine(MeuArray2[1, 0]);
            Console.WriteLine(MeuArray2[1, 1]);
            Console.WriteLine(MeuArray2[1, 2]);
            //outra maneira de inicializa um array de 2 dimensões
            string[,] MeuArray3 = { { "1", "2", "3" }, { "11", "12", "13" } };
            Console.WriteLine(MeuArray3[0, 0]);
            Console.WriteLine(MeuArray3[0, 1]);
            Console.WriteLine(MeuArray3[0, 2]);

            Console.WriteLine(MeuArray3[1, 0]);
            Console.WriteLine(MeuArray3[1, 1]);
            Console.WriteLine(MeuArray3[1, 2]);

            //número de elementos do array

            int tamanho1 = MeuArray3.GetLength(0);
            int tamanho2 = MeuArray3.GetLength(1);

            Console.WriteLine("Primeira dimensão do array MeuArray6 possui: "+tamanho1 + " elementos");
            Console.WriteLine("A segunda dimensão possui MeuArray6 possui: " + tamanho2 + " elementos");


            //Array  3 dimensões
            int[,,] meuArray4 = new int[2, 2, 2];
            meuArray4[0, 0, 0] = 10;

            Console.ReadKey();



        }
    }
}

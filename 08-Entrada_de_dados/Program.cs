using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Entrada_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprimindo textos
            /* comentario 
             * pulando
             * linha
             */
            //Console.WriteLine("hello World");
            //Console.WriteLine("Pressione qualquer tecla para sair");
            //Console.Write("Misael "); // Console.Write imprime os valores sem pular a linha
            //Console.Write("Córdova");
            // Console.ReadKey();
            // variaveis
            //int idade;
            //idade = 18;
            //Console.WriteLine(idade);
            //string nomeCompleto = "Misael Córdova", menorNome = "teste";
            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(menorNome);

            //var salario = 100000;
            //datetime dtnascimento = new datetime(2000, 6, 27, 0, 0, 0);
            //console.writeline(dtnascimento.year);
            //console.writeline(dtnascimento.month);
            //console.writeline(dtnascimento.day);
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome);
            Console.WriteLine("Digite sua idade:");
            string idade = Console.ReadLine();

            Console.WriteLine("Você tem " + idade + " anos de idade");
            Console.WriteLine("Pressione qualquer tecla:");

            int idadeint = Convert.ToInt32(idade);
            char teclaPressionada = Console.ReadKey(true).KeyChar;
            string teclaPressionadaString = Convert.ToString(Console.ReadKey(true));
            Console.WriteLine("Tecla pressionada: " + teclaPressionada);
            Console.ReadKey();
        }
    }
}

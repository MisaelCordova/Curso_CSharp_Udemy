using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_TerceiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Pressione C para cadastrar um usuário ou S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    Console.WriteLine("Digite seu nome completo");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Pressione M para masculino F para feminino: ");
                    char genero = Console.ReadKey(true).KeyChar;
                    Console.WriteLine("Digite a data de Nascimento no formato dd/mm/aaaa");
                   
                }
                else if (opcao == "s")
                {
                    Console.WriteLine("Encerrando o programa");
                }
                else
                {
                    Console.WriteLine("Opção desconhecida");
                }
            } while (opcao !="s");
            Console.WriteLine("Pressione qulaque tecla para fechar");
            Console.ReadKey();
        }
    }
}

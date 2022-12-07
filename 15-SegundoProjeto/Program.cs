using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione A para alugar um filme ou S para sair da locadora:");
            char tecla = Console.ReadKey(true).KeyChar;
            if(tecla == 'A' || tecla == 'a')
            {
                Console.WriteLine("Pressione 1 para alugar top gun");
                Console.WriteLine("Pressione 2 para alugar a bela e a fera");
                Console.WriteLine("Pressione 3 para alugar o homem aranha");
                int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
                switch(opcaoFilme)
                {
                    case 1:
                        Console.WriteLine("Você alugou top gun");
                        break;
                    case 2:
                        Console.WriteLine("Você alugou bela e a fera");
                        break;
                    case 3:
                        Console.WriteLine("Você alugou homem aranha");
                        break;
                    default:
                        Console.WriteLine("Opção desconhecida");
                        break;
                }
            }
            else if(tecla == 'S' || tecla == 's')
            {
                Console.WriteLine("Muito Obrigado Volta sempre");
            }
            Console.ReadKey();
        }
    }
}

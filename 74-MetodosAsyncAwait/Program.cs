using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Net;

namespace _74_MetodosAsyncAwait
{
    internal class Program
    {
        public static string CompraBolo(string nomeFilho)
        {
            Console.WriteLine($"{nomeFilho} foi ao mercado. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine($"{nomeFilho} comprou o bolo. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine($"{nomeFilho} voltou para casa. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            return "Abacaxi";
        }
        public static string CompraBexiga(string nomeFilho)
        {
            Console.WriteLine($"{nomeFilho} foi ao mercado. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine($"{nomeFilho} comprou a bexiga. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine($"{nomeFilho} voltou para casa. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            return "Amarela";
        }
        //-------------------------------------------------- metodos async
        public static  async Task<string> CompraBoloAsync(string nomeFilho)
        {
            Console.WriteLine($"{nomeFilho} foi ao mercado. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine($"{nomeFilho} comprou o bolo. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000); Thread.Sleep(2000);
            Console.WriteLine($"{nomeFilho} voltou para casa. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            return "Abacaxi";
        }
        public static async Task<string> CompraBexigaAsync(string nomeFilho)
        {
            Console.WriteLine($"{nomeFilho} foi ao mercado. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine($"{nomeFilho} comprou a bexiga. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine($"{nomeFilho} voltou para casa. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            return "Amarela";
        }
        public static async void FazFesta()
        {
            Task<string> compraBoloTask = CompraBoloAsync("Juliana");
            Task<string> compraBexiga = CompraBexigaAsync("Pedro");

            string sabor = await compraBoloTask;
            string cor = await compraBexiga;

            Console.WriteLine("O sabor do bolo é: " + sabor);
            Console.WriteLine("A cor da bexiga é: " + cor);
        }
        static void Main(string[] args)
        {
            //  string sabor = CompraBolo("Juliana");
            //  string cor = CompraBexiga("Pedro");
            FazFesta();
            Console.ReadKey();
        }
    }
}

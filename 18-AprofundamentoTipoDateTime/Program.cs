using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AprofundamentoTipoDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2020, 09, 26);
            DateTime dataHora = new DateTime(2022, 09, 26, 14, 05, 45);

            Console.WriteLine("Ano: "+dataHora.Year);
            Console.WriteLine("Mês: " + dataHora.Month);
            Console.WriteLine("Dia: "+ dataHora.Day);
            Console.WriteLine("Hora: " + dataHora.Hour);
            Console.WriteLine("Minuto: " + dataHora.Minute);
            Console.WriteLine("Segundos: " + dataHora.Second);
            Console.WriteLine("---------");

            //pegando a data e hora atual
            DateTime dataHoraAtual = DateTime.Now;
            Console.WriteLine(dataHoraAtual.ToString());
            // Convertendo uma string em DateTime

            DateTime dataConvertida = Convert.ToDateTime("22/11/2030");
            DateTime dataHoraConvertida = Convert.ToDateTime("22/11/2030 14:10:23");
            Console.WriteLine



            
            Console.ReadKey();
        }
    }
}

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
            Console.WriteLine("------");

            //formatando data e hora impressa
            Console.WriteLine(dataHoraConvertida.ToString("yy/MM"));
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM/2022"));
            Console.WriteLine(dataHoraConvertida.ToString("yyyy-MM-dd"));
            Console.WriteLine(dataHoraConvertida.ToString("HH:mm:ss"));


            //Operações com as variaiveis DateTime
            DateTime dataHora2 = new DateTime(2020, 09, 24, 14, 5, 20);
            Console.WriteLine("data hora normal: "+dataHora2);
            dataHora2 = dataHora2.AddDays(4);
            Console.WriteLine("data hora + 4: "+dataHora2.ToString());

            //dataHora2 = dataHora2.AddMonths(4);
            //dataHora2= dataHora2.AddYears(4);

            dataHora2 = dataHora2.Add(new TimeSpan(4, 1, 55, 30));
            Console.WriteLine(dataHora2.ToString("dd HH:mm :ss"));

            //Subitraindo datas

            DateTime dataHora3 = new DateTime(2022, 3, 1, 14, 5,20);
            Console.WriteLine("data hora 3"+dataHora3.ToString());
            Console.WriteLine("----");
            dataHora3 = dataHora3.Subtract(new TimeSpan(1, 5, 20));
            Console.WriteLine(dataHora3.ToString("HH:mm:ss"));

            dataHora3 = dataHora3.AddDays(-1);
            Console.WriteLine(dataHora3.ToString("dd/MM/yy"));



            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Enum
{
    internal class Program
    {
        enum NotasDeReal_e
        {
            notaDe2 = 2,
            notaDe5 = 5,
            notaDe10 = 10
        };
        static void Main(string[] args)
        {
            NotasDeReal_e minhaNota = NotasDeReal_e.notaDe10;
            Console.WriteLine(minhaNota+" vale "+ Convert.ToUInt32(minhaNota));


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_NonoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseDeDados baseDeDados = new BaseDeDados("BaseDeDados.xml");
            InterfaceGrafica meuPrograma = new InterfaceGrafica(baseDeDados);
            meuPrograma.IniciaInterface();
        }
    }
}

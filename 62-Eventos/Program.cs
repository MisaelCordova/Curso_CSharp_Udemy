using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //evento é uma maneira de trocar informações entre objetos de classes
            //eventos possibilitam um objeto avisar outros objetos quando alguma coisa acontece
            Cozinha cozinhaHamburguer = new Cozinha();
            Cozinha cozihaJaponesa = new Cozinha();

            TabletGarcom tabletJoao = new TabletGarcom("João", cozinhaHamburguer);
            TabletGarcom tabletPedro = new TabletGarcom("Pedro", cozinhaHamburguer);
            TabletGarcom tabletMaria = new TabletGarcom("Maria", cozinhaHamburguer);

            TabletGarcom tabletJoana = new TabletGarcom("Joana", cozihaJaponesa);
            TabletGarcom tabletAline = new TabletGarcom("Aline", cozihaJaponesa);
            TabletGarcom tabletMarcos = new TabletGarcom("Marcos", cozihaJaponesa);

            cozinhaHamburguer.EnviaMensagemPedidoPronto(12);

            cozihaJaponesa.EnviaMensagemPedidoPronto(29);

            Console.ReadKey();
        }
    }
}

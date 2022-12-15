using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_Eventos
{
    internal class TabletGarcom
    {
        private string nome;
        public void MostraMensagemPedidoProntoNaCozinha(object fonte, EventArgsPedidoPronto e)
        {
            Console.WriteLine($"O Pedido { e.NumeroPedido} está pronto na cozinha, {nome}");
        }
        public TabletGarcom(string nome, Cozinha cozinha) 
        {
            this.nome = nome;
            cozinha.MensagemPedidoProntoEvent += MostraMensagemPedidoProntoNaCozinha;
        }
    }
}

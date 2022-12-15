using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_Eventos
{
    internal class Cozinha
    {
        public delegate void MensagemPedidoProntoEnventHandler(object fonte, EventArgsPedidoPronto e);
        public event MensagemPedidoProntoEnventHandler MensagemPedidoProntoEvent;
        public void EnviaMensagemPedidoPronto(UInt32 numeroDoPedido)
        {
            if(MensagemPedidoProntoEvent != null)
            {
                EventArgsPedidoPronto e = new EventArgsPedidoPronto(numeroDoPedido);
                MensagemPedidoProntoEvent(this, e);

            }
        }
    }
}

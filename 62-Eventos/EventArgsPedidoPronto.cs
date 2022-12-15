﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_Eventos
{
    internal class EventArgsPedidoPronto : EventArgs
    {
        private UInt32 numeroPedido;
        public UInt32 NumeroPedido
        {
            get { return numeroPedido; }
        }
        public EventArgsPedidoPronto(UInt32 numeroPedido)
        {
            this.numeroPedido = numeroPedido;
        }
    }
}

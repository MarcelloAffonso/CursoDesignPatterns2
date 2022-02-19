using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class PagaPedido : IComando
    {
        private Pedido _pedido;

        public PagaPedido(Pedido pedido)
        {
            this._pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pagando o pedido do cliente {0}", _pedido.Cliente);
            this._pedido.Paga();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class FinalizaPedido : IComando
    {
        private Pedido _pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this._pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido do cliente {0}", _pedido.Cliente);
            this._pedido.Finaliza();
        }
    }
}
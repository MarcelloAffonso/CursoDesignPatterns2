using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public interface IExpressao
    {
        /// <summary>
        /// Método responsável por avaliar/interpretar a expressão matemática
        /// </summary>
        int Avalia();

        /// <summary>
        /// Método responsável por aceitar uma impressora, que basicamente imprimirá a expressão. Recebe um IVisitor pq pode ser qualquer visitor
        /// </summary>
        void Aceita(IVisitor impressora);
    }
}

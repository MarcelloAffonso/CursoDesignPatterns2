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
    }
}

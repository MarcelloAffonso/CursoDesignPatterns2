using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class RaizQuadrada:IExpressao
    {
        /// <summary>
        /// Expressão que será elevada ao quadrado
        /// </summary>
        private IExpressao expressao;

        public RaizQuadrada(IExpressao expressao)
        {
            this.expressao = expressao;
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(this.expressao.Avalia());
        }
    }
}

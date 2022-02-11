using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class Divisao : IExpressao
    {
        /// <summary>
        /// Expressão da esquerda
        /// </summary>
        private IExpressao esquerda;

        /// <summary>
        /// Expressão da direita
        /// </summary>
        private IExpressao direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            return esquerda.Avalia() / direita.Avalia();
        }
    }
}

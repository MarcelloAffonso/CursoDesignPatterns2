using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class Soma : IExpressao
    {
        /// <summary>
        /// Expressão da esquerda
        /// </summary>
        private IExpressao esquerda;

        /// <summary>
        /// Expressão da direita
        /// </summary>
        private IExpressao direita;

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            // Faz a avaliação do valor numérico da expressão da esquerda e soma com o valor numérico avaliado da expressão da direita
            return esquerda.Avalia() + direita.Avalia();
        }
    }
}

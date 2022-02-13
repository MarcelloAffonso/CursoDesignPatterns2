using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class Multiplicacao : IExpressao
    {
        /// <summary>
        /// Expressão da esquerda
        /// </summary>
        private IExpressao esquerda;

        /// <summary>
        /// Expressão da direita
        /// </summary>
        private IExpressao direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            return esquerda.Avalia() * direita.Avalia();
        }

        public void Aceita(IVisitor impressora)
        {

        }
    }
}

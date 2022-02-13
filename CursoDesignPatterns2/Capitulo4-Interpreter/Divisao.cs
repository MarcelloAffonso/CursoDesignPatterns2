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
        public IExpressao Esquerda { get; private set; }

        /// <summary>
        /// Expressão da direita
        /// </summary>
        public IExpressao Direita { get; private set; }

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            return Esquerda.Avalia() / Direita.Avalia();
        }

        public void Aceita(IVisitor impressora)
        {

        }
    }
}

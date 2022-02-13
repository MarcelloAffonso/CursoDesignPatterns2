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
        public IExpressao Esquerda { get; private set; }

        /// <summary>
        /// Expressão da direita
        /// </summary>
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            // Faz a avaliação do valor numérico da expressão da esquerda e soma com o valor numérico avaliado da expressão da direita
            return Esquerda.Avalia() + Direita.Avalia();
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.VisitaSoma(this);
        }
    }
}

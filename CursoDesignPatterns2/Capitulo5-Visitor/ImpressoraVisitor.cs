using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class ImpressoraVisitor : IVisitor
    {
        public void VisitaSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write("+");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void VisitaSubtracao(Subtracao subtracao)
        {
            Console.Write("(");

            subtracao.Esquerda.Aceita(this);
            Console.Write("-");

            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void VisitaNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}

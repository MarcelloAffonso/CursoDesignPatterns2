using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class ImpressoraPreFixoVisitor : IVisitor
    {
        public void VisitaNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }

        public void VisitaSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write(" + ");
            soma.Esquerda.Aceita(this);
            Console.Write(" ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void VisitaSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write(" - ");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}

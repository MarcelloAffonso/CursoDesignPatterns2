using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public interface IVisitor
    {
        void VisitaSoma(Soma soma);
        void VisitaSubtracao(Subtracao subtracao);
        void VisitaNumero(Numero numero);
    }
}

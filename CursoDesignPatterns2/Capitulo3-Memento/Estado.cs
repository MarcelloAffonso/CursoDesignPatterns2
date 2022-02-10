using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class Estado
    {
        public Contrato Contrato { get; set; }

        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }
    }
}

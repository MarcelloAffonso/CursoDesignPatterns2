using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class Numero : IExpressao
    {
        private int numero;

        public Numero(int numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// A avaliação de um número nada mais é do que o próprio valor do número
        /// </summary>
        public int Avalia()
        {
            return this.numero;
        }
    }
}

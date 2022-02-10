using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class Historico
    {

        private IList<Estado> Estados = new List<Estado>();

        /// <summary>
        /// Adiciona o Estado a lista de Estados.
        /// </summary>
        public void Adiciona(Estado estado)
        {
            this.Estados.Add(estado);
        }

        /// <summary>
        /// Devolve o Estado anterior baseado no indice da lista.
        /// </summary>
        public Estado Pega(int indice)
        {
            return this.Estados[indice];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public interface INota
    {
        /// <summary>
        /// Toda classe que implementar deverá determinar a frequencia da nota
        /// </summary>
        int Frequencia { get; }
    }
}

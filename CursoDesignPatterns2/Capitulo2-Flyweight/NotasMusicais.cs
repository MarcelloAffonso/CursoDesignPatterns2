using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class NotasMusicais
    {
        /// <summary>
        /// Dicionário contendo todas as notas
        /// </summary>
        private static IDictionary<string, INota> notas =
        new Dictionary<string, INota>() {
        { "Do", new Do() } ,
        { "Re", new Re() } ,
        { "Mi", new Mi() },
        { "Fa", new Fa() },
        { "Sol", new Sol() },
        { "La", new La() },
        { "Si", new Si() }
        };

        public INota Pega(string nota)
        {
            return notas[nota];
        }
    }
}

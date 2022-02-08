using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class Piano
    {
        /// <summary>
        /// Toca a música (coleção de notas) passada no argumento
        /// </summary>
        public void Toca(IList<INota> musica)
        {
            foreach(INota nota in musica)
            {
                // Para cada nota da música toca sua frequencia por 300ms
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}

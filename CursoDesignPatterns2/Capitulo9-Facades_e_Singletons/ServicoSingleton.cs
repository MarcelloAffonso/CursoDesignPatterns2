using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    /// <summary>
    /// Classe singleton para um objeto de Servico
    /// </summary>
    public class ServicoSingleton
    {
        private static Servico servico = new Servico();

        public Servico Instancia
        {
            get{
                return servico;
            }
        }
    }
}

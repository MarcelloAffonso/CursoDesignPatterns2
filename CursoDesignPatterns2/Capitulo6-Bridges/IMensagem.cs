using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    /// <summary>
    /// Interface que garante que a mensagem só terá a responsabilidade de formatar o texto que será disparado
    /// </summary>
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Envia();

        string Formata();
    }
}

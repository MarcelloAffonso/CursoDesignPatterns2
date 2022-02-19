using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    /// <summary>
    /// Interface que garante que os "enviadores" terao somente a responsabilidade de enviar
    /// </summary>
    public interface IEnviador
    {
        void Envia(IMensagem mensagem);
    }
}

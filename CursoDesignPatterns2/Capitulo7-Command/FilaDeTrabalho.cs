using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class FilaDeTrabalho
    {
        private IList<IComando> _comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            this._comandos.Add(comando);
        }

        public void Processa()
        {
            foreach(var comando in this._comandos)
            {
                comando.Executa();
            }
        }
    }
}

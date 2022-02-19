using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por email.");
            Console.WriteLine(mensagem.Formata());
        }
    }
}

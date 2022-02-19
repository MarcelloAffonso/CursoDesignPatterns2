using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por SMS.");
            Console.WriteLine(mensagem.Formata());
        }
    }
}

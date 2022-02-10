using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns2
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }


        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        /// <summary>
        /// Avança o tipo de contrato
        /// </summary>
        public void Avanca()
        {
            if (this.Tipo == TipoContrato.Novo)
            {
                this.Tipo = TipoContrato.EmAndamento;
            }
            else if (this.Tipo == TipoContrato.EmAndamento)
            {
                this.Tipo = TipoContrato.Acertado;
            }
            else if (this.Tipo == TipoContrato.Acertado)
            {
                this.Tipo = TipoContrato.Concluido;
            }
        }

        /// <summary>
        /// Restaura o Contrato para o Estado anterior passado.
        /// </summary>
        public void Restaura(Estado estado)
        {
            this.Cliente = estado.Contrato.Cliente;
            this.Data = estado.Contrato.Data;
            this.Tipo = estado.Contrato.Tipo;
        }


        public Estado SalvaEstado()
        {
            // Importante notar que é criado um novo objeto para representar o "momento" atual do Contrato
            // Se fosse passado o próprio Contrato todos os objetos ficariam iguais no fim
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }
    }
}

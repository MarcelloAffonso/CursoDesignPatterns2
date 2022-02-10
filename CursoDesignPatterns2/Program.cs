using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CursoDesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Capitulo 1
            //IDbConnection conexao = new ConnectionFactory().GetConnection();

            //IDbCommand comando = conexao.CreateCommand();
            //comando.CommandText = "select * from tabela"; 
            #endregion

            #region Capitulo 2
            //NotasMusicais notas = new NotasMusicais();

            //// Cria uma coleção de notas, gerando uma música
            //IList<INota> doReMiFa = new List<INota>() {
            //notas.Pega("Do"),
            //notas.Pega("Re"),
            //notas.Pega("Mi"),
            //notas.Pega("Fa"),
            //notas.Pega("Fa"),
            //notas.Pega("Fa"),

            //notas.Pega("Do"),
            //notas.Pega("Re"),
            //notas.Pega("Do"),
            //notas.Pega("Re"),
            //notas.Pega("Re"),
            //notas.Pega("Re"),

            //notas.Pega("Do"),
            //notas.Pega("Sol"),
            //notas.Pega("Fa"),
            //notas.Pega("Mi"),
            //notas.Pega("Mi"),
            //notas.Pega("Mi"),

            //notas.Pega("Do"),
            //notas.Pega("Re"),
            //notas.Pega("Mi"),
            //notas.Pega("Fa"),
            //notas.Pega("Fa"),
            //notas.Pega("Fa")
            //};

            //Piano piano = new Piano();
            //piano.Toca(doReMiFa); 
            #endregion

            #region Capitulo 3
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Marcello", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            Console.WriteLine(historico.Pega(2).Contrato.Tipo);
            #endregion
        }
    }
}

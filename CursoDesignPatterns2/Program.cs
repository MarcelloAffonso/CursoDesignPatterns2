using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

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
            //Historico historico = new Historico();

            //Contrato contrato = new Contrato(DateTime.Now, "Marcello", TipoContrato.Novo);
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());

            //Console.WriteLine(historico.Pega(2).Contrato.Tipo);
            #endregion

            #region Capitulo 4
            //// 1+10=11
            //IExpressao esquerda = new Soma(new Numero(1), new Numero(10));

            //// 20-10=10
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            //// Soma as duas expressões - 11+10= 21
            //IExpressao soma = new Soma(esquerda, direita);

            //IExpressao raiz = new RaizQuadrada(new Numero(9));

            //// Exibe o resultado
            //Console.WriteLine(soma.Avalia());

            //// Exibe o resultado
            //Console.WriteLine(raiz.Avalia());

            //// API do próprio C#
            //Expression somaExpression = Expression.Add(Expression.Constant(10), Expression.Constant(100));

            //// Gera a função matemática de 10 + 100
            //Func<int> funcao = Expression.Lambda<Func<int>>(somaExpression).Compile();

            //Console.WriteLine(funcao());
            #endregion

            #region Capitulo 5
            //ImpressoraPreFixoVisitor impressora = new ImpressoraPreFixoVisitor();
            //soma.Aceita(impressora); 
            #endregion

            #region Capitulo 6

            IMensagem mensagem = new MensagemAdministrativa("Marcello");
            IEnviador enviador = new EnviaPorEmail();

            mensagem.Enviador = enviador;

            mensagem.Envia();

            #endregion


        }
    }
}

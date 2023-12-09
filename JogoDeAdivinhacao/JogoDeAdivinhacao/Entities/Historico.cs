using JogoDeAdivinhacao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace JogoDeAdivinhacao.Entities
{
    public class Historico
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int NumerosTentativa { get; set; }
        public DateTime DataJogada { get; set; }
        public string Resultado { get; set; }


        public Historico(int id = 0, string nome = "", int numerosTentativa = 0, DateTime dataJogada = default, string resultado = "")
        {

            ID = id;
            Nome = nome;
            NumerosTentativa = numerosTentativa;
            DataJogada = dataJogada;
            Resultado = resultado;
        }    

        //metodo para inserir dados no banco de dados para salvar no histórico
        public void Inserir()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsereHistorico";
            cmd.Parameters.AddWithValue("p_id", ID).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("p_nome", Nome).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("p_numerotentativas", NumerosTentativa).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("p_datajogada", DataJogada).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("p_resultado", Resultado).Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            ID = Convert.ToInt32(cmd.Parameters["p_id"].Value);
        }

        //metodo para exibir o histórico por uma datagridview
        public List<Historico> ListarHistorico(int inicio = 0, int limite = 0)
        {
            List<Historico> lista = new List<Historico>();
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.Text;
            if (limite > 0)
                cmd.CommandText = "select * from historico limit " + inicio + "," + limite;
            else
                cmd.CommandText = "select * from historico";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Historico(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    Convert.ToInt32(dr.GetString(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4)
                    ));
            }
            return lista;
        }
    }
}


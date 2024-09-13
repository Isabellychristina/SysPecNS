using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {
        private object id;

        public int Id { get; set; }
        public int Produto_id { get; set; }
        public double Quantidade { get; set; }
        public DateTime Data_ultimo_movimento { get; set; }
        public List<Produto> Produtos { get; set; }
        public Estoque()
        {

        }

        public Estoque(int id, int produto_id, double quantidade, DateTime data_ultimo_movimento)
        {
            Id = id;
            Produto_id = produto_id;
            Quantidade = quantidade;
            Data_ultimo_movimento = data_ultimo_movimento;
        }

        public Estoque(int produto_id, double quantidade, DateTime data_ultimo_movimento)
        {
            Produto_id = produto_id;
            Quantidade = quantidade;
            Data_ultimo_movimento = data_ultimo_movimento;
        }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_estoque_insert";
            cmd.Parameters.AddWithValue("spproduto_id", Produto_id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdata_ultimo_movimento", Data_ultimo_movimento);


            cmd.ExecuteNonQuery();
        }

        public void Atualizar()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType |= CommandType.Text;
            cmd.CommandText = $"update estoque set quantidade = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static Estoque ObterPorId(int id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from estoque where id = '{id}'";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque = new(
                 dr.GetInt32(0),
                 dr.GetInt32(1),
                 dr.GetDouble(2),
                 dr.GetDateTime(3)
                 );

            }
            return estoque;

        }

        public static List<Estoque> ObterLista()
        {
            List<Estoque> estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from estoque order by produto";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque.Add(new(
                 dr.GetInt32(0),
                 dr.GetInt32(1),
                 dr.GetDouble(2),
                 dr.GetDateTime(3)
                 ));


            }
            return estoque;

        }

        public static List<Estoque> ObterListaPorProduto(int id)
        {
            List<Estoque> estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from estoque where produtos = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
 
                estoque.Add(new(
                 dr.GetInt32(0),
                 dr.GetInt32(1),
                 dr.GetDouble(2),
                 dr.GetDateTime(3)
                 ));



            }
            return estoque;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    internal class Endereco
    {
        //Criar Cliente_id, Cep, Logradouro, numero, complemento, bairro, cidade, uf , tipo_endereco
        public int Id { get; set; }
        public int Cliente_id { get; set; }
        public string? Cep {  get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Tipo_Endereco { get; set;}
        public bool Ativo { get; set; }

        public Endereco() { }

        public Endereco (int cliente_id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo_Endereco, bool ativo)
        {
            
            Cliente_id = cliente_id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo_Endereco = tipo_Endereco;
            Ativo = ativo;
        }

        public Endereco (int id, int cliente_id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo_Endereco, bool ativo)
        {
            Id = id;
            Cliente_id = cliente_id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo_Endereco = tipo_Endereco;
            Ativo = ativo;
        }

        public void Inserir ()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_Endereco);
            Id = Convert.ToInt32(cmd.ExecuteScalar()); 

            var dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                Id = dr.GetInt32(0);
            }
        }

        public static Endereco ObterPorId(int id)
        {
            Endereco Endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from enderecos where id - {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                Endereco = new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9),
                    dr.GetBoolean(10)
                    );
            }
            return Endereco;
        }

        public static List<Endereco> ObterLista(string nome = "")
        {
            List<Endereco> Lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = System.Data.CommandType.Text;

            comandosSQL.CommandText = "select * from clientes order by nome";
            if (nome == "")
            {
                comandosSQL.CommandText = "select * from endereco order by nome";
            }
            else
            {
                comandosSQL.CommandText = $"select * from clientes where nome like '%{nome}%' order by nome";

            }

            var dr = comandosSQL.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetString(9),
                        dr.GetBoolean(10)
                        )
                    );

            }
            return Lista;
        }

        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType |= CommandType.Text;
            cmd.CommandText = $"update enderecos set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void Atualizar () 
        {
            var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "sp_endereco_update";
                cmd.Parameters.AddWithValue("spcliente_id", Cliente_id);
                cmd.Parameters.AddWithValue("spcep", Cep);
                cmd.Parameters.AddWithValue("splogradouro", Logradouro);
                cmd.Parameters.AddWithValue("spnumero", Numero);
                cmd.Parameters.AddWithValue("spcomplemento", Complemento);
                cmd.Parameters.AddWithValue("spbairro", Bairro);
                cmd.Parameters.AddWithValue("spcidade", Cidade);
                cmd.Parameters.AddWithValue("spuf", Uf);
                cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_Endereco);

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
        }

        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType |= CommandType.Text;
            cmd.CommandText = $"update enderecos set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType |= CommandType.Text;
            cmd.CommandText = $"delete from enderecos where id = {Id}";
            cmd.ExecuteNonQuery();
        }
      




    }
    }
}

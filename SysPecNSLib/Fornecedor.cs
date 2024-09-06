using System.Data;

namespace SysPecNSLib
{
    public class Fornecedor
    {

        public int Id { get; set; }
        public string? Razao_Social { get; set; }
        public string? Fantasia { get; set; }
        public string? Cnpj { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }


        public Fornecedor() { }

        public Fornecedor(string razao_Social, string fantasia, string cnpj, string contato, string telefone, string email)
        {
            Razao_Social = razao_Social;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }


        public Fornecedor(int id, string razao_Social, string fantasia, string cnpj, string contato, string telefone, string email)
        {
            Id = id;
            Razao_Social = razao_Social;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public void Inserir ()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_insert";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sprazao_social", Razao_Social);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);

            var dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                Id = dr.GetInt32(0);            
            }

        }

        public static Fornecedor ObterPorId(int id)
        {
            Fornecedor fornecedor = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from fornecedor where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                fornecedor = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6)
                        );
            }
            return fornecedor;
        }

        public static List<Fornecedor> ObterLista(string nome= "") 
        {
            List<Fornecedor> Lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from fornecedores order by razao_social";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                Lista.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6)
                        ));
            }
            return Lista;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "sp_fornecedor_update";
            cmd.CommandText = "sp_fornecedor_insert";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sprazao_social", Razao_Social);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
            cmd.Parameters.AddWithValue("spcontao", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }



    }
}

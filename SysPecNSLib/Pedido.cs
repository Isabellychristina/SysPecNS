using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Pedido
    {

        public int Id { get; set; } 
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        //propriedade que lista a a classe de pedido 
        public List<ItemPedido> Itens { get; set; }



        //metodo construtor vazio
        public Pedido() 
        { 
        
        }

        //metodo construtor sem o Id 
        public Pedido(Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }

        //metodo construtor sem o Id, Data e Status
        public Pedido(Usuario usuario, Cliente cliente, double desconto)
        {
            
            Usuario = usuario;
            Cliente = cliente;  
            Desconto = desconto;
        }

        // metodo construtor com tudo
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto, List<ItemPedido> itens)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Itens = itens;
        }

        //Criando o metodo Inserir, para inserir pedidos
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id );
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());


        }

        //Criando o metodo Alterar, para alterar os pedidos
        public void Alterar()
        {

        }

        //Com o numero do Id, consultamos tudo sobre o pedido
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();

            return pedido;
        }
         
        //Listar os pedidos                   || //listando direto de um unico cliente ou usuario
        public static List<Pedido> ObterLista(int idCliente=0, int idUsuario=0)
        {
            List<Pedido> pedidos = new();

            return pedidos;
        }
        public void Deletar()
        {

        }

        
    }
}

using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SysPecNSDesk
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Fornecedor.ObterLista(nome);
            dgvFornecedor.Rows.Clear();
            int cont = 0;
            foreach (var fornecedor in lista)
            {
                dgvFornecedor.Rows.Add();
                dgvFornecedor.Rows[cont].Cells[0].Value = fornecedor.Id;
                dgvFornecedor.Rows[cont].Cells[1].Value = fornecedor.Razao_Social;
                dgvFornecedor.Rows[cont].Cells[2].Value = fornecedor.Fantasia;
                dgvFornecedor.Rows[cont].Cells[3].Value = fornecedor.Cnpj;
                dgvFornecedor.Rows[cont].Cells[4].Value = fornecedor.Contato;
                dgvFornecedor.Rows[cont].Cells[5].Value = fornecedor.Telefone;
                dgvFornecedor.Rows[cont].Cells[6].Value = fornecedor.Email;

                cont++;

            }



        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            Fornecedor fornecedor = new(

             txtRazaoSocial.Text,
             txtFantasia.Text,
             txtCnpj.Text,
             txtContato.Text,
             txtTelefone.Text,
             txtEmail.Text
             );

            fornecedor.Inserir();
            if (fornecedor.Id > 0)
            {
                MessageBox.Show($"Fornecedor gravado com sucesso, com o Id {fornecedor.Id}");
                FrmFornecedor_Load(sender, e);
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                LimpaControles();
                btnConsultar.Text = "$Obter por ID";
                txtId.Focus();
                txtId.ReadOnly = false;
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Fornecedor fornecedor = Fornecedor.ObterPorId(int.Parse(txtId.Text));
                    txtRazaoSocial.Text = fornecedor.Razao_Social;
                    txtFantasia.Text = fornecedor.Fantasia;
                    txtCnpj.Text = fornecedor.Cnpj;
                    txtContato.Text = fornecedor.Contato;
                    txtTelefone.Text = fornecedor.Telefone;
                    txtEmail.Text = fornecedor.Email;
                }

            }

        }

        private void LimpaControles()
        {
            txtId.Clear();
            txtRazaoSocial.Clear();
            txtFantasia.Clear();
            txtCnpj.Clear();
            txtContato.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
             txtRazaoSocial.Text,
             txtFantasia.Text,
             txtCnpj.Text,
             txtContato.Text,
             txtTelefone.Text,
             txtEmail.Text
             );

            fornecedor.Atualizar(); // grava as alteraçoes do banco
            MessageBox.Show($"Fornecedor {fornecedor.Id} - {fornecedor.Razao_Social} atualizado com sucesso");
            btnEditar.Enabled = false;
            txtId.ReadOnly = true;
            btnConsultar.Text = "&Consultar";
            LimpaControles();
            FrmFornecedor_Load(sender, e);
        }
    }
}

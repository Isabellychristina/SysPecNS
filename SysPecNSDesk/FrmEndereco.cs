using MySqlX.XDevAPI;
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

namespace SysPecNSDesk
{
    public partial class FrmEndereco : Form
    {
        public FrmEndereco()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(

                Cliente.ObterPorId(Convert.ToInt32(txtId.Text)), 
                txtLogradouro.Text,
                txtCep.Text,
                txtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                txtUF.Text,
                cmbTipo_Endereco.Text
                ); 

            endereco.Inserir();
            if (endereco.Id > 0)
            {
                txtId.Text = endereco.Id.ToString();
                MessageBox.Show($"O cliente {endereco.Logradouro}, " + $"foi inserido com sucesso, com Id {endereco.Id}. ");

                txtId.Clear();
                txtLogradouro.Clear();
                txtCep.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtUF.Clear();

                txtLogradouro.Focus();

                FrmEndereco_Load(sender, e);
            }

            else

            {
                MessageBox.Show("Falha ao gravar o usuário.");
            }
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Endereco.ObterLista(nome);
            dgvEnderecos.Rows.Clear();
            int cont = 0;
            foreach (var endereco in lista)
            {
                dgvEnderecos.Rows.Add();
                dgvEnderecos.Rows[cont].Cells[0].Value = endereco.Cliente.Id;
                dgvEnderecos.Rows[cont].Cells[1].Value = endereco.Cep;
                dgvEnderecos.Rows[cont].Cells[2].Value = endereco.Logradouro;
                dgvEnderecos.Rows[cont].Cells[3].Value = endereco.Numero;
                dgvEnderecos.Rows[cont].Cells[4].Value = endereco.Complemento;
                dgvEnderecos.Rows[cont].Cells[5].Value = endereco.Bairro;
                dgvEnderecos.Rows[cont].Cells[6].Value = endereco.Cidade;
                dgvEnderecos.Rows[cont].Cells[6].Value = endereco.Uf;
                cont++;

            }
        }
        private void FrmEndereco_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

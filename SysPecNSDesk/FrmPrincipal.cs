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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            FrmUsuario frmUsuario = new();
            //Indica que o container pai é o container atual (FrmPrincipal)
            frmUsuario.MdiParent = this;
            frmUsuario.Show();

            //frmUsuario.ShowDialog(); Impede que qualquer outra ação seja executada, a janela em questão fica em primeiro e único plano.


        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //informar mensagem de confirmação que o usuario quer sair do sistema, colocar botão de confirmação.
            var msg = MessageBox.Show("Deseja Sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes)
                //sair do sistema
                Application.Exit();

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new();
            //Indica que o container pai é o container atual (FrmPrincipal)
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }


        private void enderecosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEndereco frmEndereco = new();
            //Indica que o container pai é o container atual (FrmPrincipal)
            frmEndereco.MdiParent = this;
            frmEndereco.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmFornecedor = new();
            //Indica que o container pai é o container atual (FrmPrincipal)
            frmFornecedor.MdiParent = this;
            frmFornecedor.Show();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            //FrmLogin.MdiParent = this;
            frmLogin.ShowDialog();
            // 
            //Text += $" ({Program.UsuarioLogado.Email}) ";
            // vai mostrar qual usuario que logou e qual o nome do nivel dele
            toolStripStatusLabel1.Text = $"{Program.UsuarioLogado.Nome} - {Program.UsuarioLogado.Nivel.Nome}";
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo frmPedidoNovo = new();
            //Indica que o container pai é o container atual (FrmPrincipal)
            frmPedidoNovo.MdiParent = this;
            frmPedidoNovo.Show();
        }
    }
}

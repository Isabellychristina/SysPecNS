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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void txtProdudoId_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarregaGrid()
        {

            var Lista = Estoque.ObterLista();
            dgvEstoque.Rows.Clear();
            int count = 0;
            foreach (var estoque in Lista)
            {
                dgvEstoque.Rows.Add();
                dgvEstoque.Rows[count].Cells[0].Value = estoque.Id;
                dgvEstoque.Rows[count].Cells[1].Value = estoque.Produto_id;
                dgvEstoque.Rows[count].Cells[2].Value = estoque.Quantidade;
                dgvEstoque.Rows[count].Cells[3].Value = estoque.Data_ultimo_movimento;

                count++;
            }


        }

    }





}

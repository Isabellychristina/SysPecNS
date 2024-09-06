using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {   //
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                //obrigatorio colocar um email e uma senha
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
                if (usuario.Id > 0)
                {
                    // se o usuario estiver ativo, fechar form
                    if (usuario.Ativo)
                    {
                        // usuario logado que foi criado no inicio, chama o metodo principal para executar, no caso o metodo main "Classe de usuario"
                        Program.UsuarioLogado = usuario;
                        Close();
                    }
                    //se não 
                    else
                    {
                        //usuario inativo, procurar responsavel
                        MessageBox.Show("Seu usuário está inativo. \n Procure a gerência.");
                        Application.Exit();
                    }

                }
                // se email e senha estiver incorreto
                else
                {   
                    //aparece essa mensagem para o usuario
                    MessageBox.Show("Usuário ou Senha inválidos, ou não existe. \n Tente Novamente.");
                    //retornar para usuario digitar novamente 
                    txtEmail.Focus();
                }
            }
            else
            {
                MessageBox.Show("Você deve preencher email e senha ");
                txtEmail.Focus();
            }
        }
        
    }
}

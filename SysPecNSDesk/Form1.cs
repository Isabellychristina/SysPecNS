namespace SysPecNSDesk
{
    public partial class Operacoes : Form
    {
        public Operacoes()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Qualquer informação/função presente aqui será executada apenas após o formulário ser carregado.
        }


        private void btnConfirma_Click(object sender, EventArgs e)
        {

            //int numero = int.Parse(txtNumero1.Text);
            // int numero = convert.ToInt32(txtNumero.Text);
            //for (int i = 0; i < 10; i++)
            //{
            //lstResultado.Items.Add($"{numero} x {i + 1} = {numero * i}");
            //}


            string operacao = cmbOperacao.Text;
            int posicaoOperacao = cmbOperacao.SelectedIndex;
            double numero1 = 0;
            if (txtNumero1.Text != string.Empty)
            {
                numero1 = Convert.ToDouble(txtNumero1.Text);

            }
            double numero2 = 0;
            if (posicaoOperacao < 5)
            {
                numero2 = Convert.ToDouble(txtNumero2.Text);
            }
            double resultado = 0;
            switch (posicaoOperacao)
            {
                case 0:
                    resultado = numero1 * numero2;
                    break;
                case 1:
                    resultado = numero1 / numero2;
                    break;
                case 2:
                    resultado = numero1 + numero2;
                    break;
                case 3:
                    resultado = numero1 - numero2;
                    break;
                case 4:
                    resultado = Math.Pow(numero1, numero2);
                    break;
                case 5:
                    resultado = Math.Sqrt(numero2);
                    break;
                case 6:
                    resultado = Math.Log(numero1);
                    break;
                default:
                    break;
            }
            lstResultado.Items.Add($"{operacao} - {posicaoOperacao} = {resultado}"); //interpolação
        }


        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperacao.SelectedIndex > 4)
            {
                txtNumero2.Enabled = false;
            }
            else
            {
                txtNumero2.Enabled = true;
            }

            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
            BtnConfirma.Enabled = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Length > 0)
            {
                BtnConfirma.Enabled = true;
            }
        }

        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



namespace SysPecNSDesk
{
    partial class FrmEndereco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtLogradouro = new TextBox();
            txtCep = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            lblId = new Label();
            lblLogradouro = new Label();
            lblCep = new Label();
            lblNumero = new Label();
            lblComplemento = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblBairro = new Label();
            lblCidade = new Label();
            lblUf = new Label();
            chkAtivo = new CheckBox();
            btnInserir = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvEnderecos = new DataGridView();
            txtBusca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(29, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 0;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(29, 100);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(394, 23);
            txtLogradouro.TabIndex = 1;
            txtLogradouro.TextChanged += txtLogradouro_TextChanged;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(452, 100);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(182, 23);
            txtCep.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(672, 100);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(94, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(29, 167);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(269, 23);
            txtComplemento.TabIndex = 4;
            txtComplemento.TextChanged += txtComplemento_TextChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(29, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(30, 75);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 6;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(452, 74);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 7;
            lblCep.Text = "Cep";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(672, 75);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 8;
            lblNumero.Text = "Número";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(29, 140);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 9;
            lblComplemento.Text = "Complemento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(535, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(713, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 12;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(326, 141);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 13;
            lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(535, 144);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 14;
            lblCidade.Text = "Cidade";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(717, 144);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 15;
            lblUf.Text = "UF";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(369, 211);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 16;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(80, 247);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 17;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(369, 247);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(627, 247);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 19;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Location = new Point(29, 305);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.Size = new Size(737, 133);
            dgvEnderecos.TabIndex = 20;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(30, 276);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(738, 23);
            txtBusca.TabIndex = 21;
            // 
            // FrmEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBusca);
            Controls.Add(dgvEnderecos);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnInserir);
            Controls.Add(chkAtivo);
            Controls.Add(lblUf);
            Controls.Add(lblCidade);
            Controls.Add(lblBairro);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblComplemento);
            Controls.Add(lblNumero);
            Controls.Add(lblCep);
            Controls.Add(lblLogradouro);
            Controls.Add(lblId);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtCep);
            Controls.Add(txtLogradouro);
            Controls.Add(txtId);
            Name = "FrmEndereco";
            Text = "FrmEndereco";
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtLogradouro;
        private TextBox txtCep;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private Label lblId;
        private Label lblLogradouro;
        private Label lblCep;
        private Label lblNumero;
        private Label lblComplemento;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblUf;
        private CheckBox chkAtivo;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvEnderecos;
        private TextBox txtBusca;
    }
}
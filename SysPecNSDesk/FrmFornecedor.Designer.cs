namespace SysPecNSDesk
{
    partial class FrmFornecedor
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
            txtRazaoSocial = new TextBox();
            txtFantasia = new TextBox();
            txtCnpj = new TextBox();
            txtContato = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            lblId = new Label();
            lblRazaoSocial = new Label();
            lblfantasia = new Label();
            lblCnpj = new Label();
            lblContato = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            btnAdicionar = new Button();
            btnConsultar = new Button();
            btnEditar = new Button();
            dgvFornecedor = new DataGridView();
            clmId = new DataGridViewTextBoxColumn();
            clmRazaoSocial = new DataGridViewTextBoxColumn();
            clmFantasia = new DataGridViewTextBoxColumn();
            clmCnpj = new DataGridViewTextBoxColumn();
            clmContato = new DataGridViewTextBoxColumn();
            clmTelefone = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(44, 39);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(44, 110);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(258, 23);
            txtRazaoSocial.TabIndex = 1;
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(333, 110);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(269, 23);
            txtFantasia.TabIndex = 2;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(44, 184);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(258, 23);
            txtCnpj.TabIndex = 3;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(333, 184);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(150, 23);
            txtContato.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(502, 184);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(123, 23);
            txtTelefone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(44, 249);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 23);
            txtEmail.TabIndex = 6;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(44, 18);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 7;
            lblId.Text = "Id";
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Location = new Point(44, 92);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(72, 15);
            lblRazaoSocial.TabIndex = 8;
            lblRazaoSocial.Text = "Razão Social";
            // 
            // lblfantasia
            // 
            lblfantasia.AutoSize = true;
            lblfantasia.Location = new Point(333, 92);
            lblfantasia.Name = "lblfantasia";
            lblfantasia.Size = new Size(50, 15);
            lblfantasia.TabIndex = 9;
            lblfantasia.Text = "Fantasia";
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(44, 166);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(32, 15);
            lblCnpj.TabIndex = 10;
            lblCnpj.Tag = "";
            lblCnpj.Text = "Cnpj";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(333, 166);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(50, 15);
            lblContato.TabIndex = 11;
            lblContato.Text = "Contato";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(502, 166);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 12;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(44, 231);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(44, 307);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(117, 39);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(218, 306);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(143, 40);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(415, 306);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AllowUserToAddRows = false;
            dgvFornecedor.AllowUserToDeleteRows = false;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { clmId, clmRazaoSocial, clmFantasia, clmCnpj, clmContato, clmTelefone, clmEmail });
            dgvFornecedor.Location = new Point(44, 368);
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.ReadOnly = true;
            dgvFornecedor.Size = new Size(742, 150);
            dgvFornecedor.TabIndex = 17;
            // 
            // clmId
            // 
            clmId.Frozen = true;
            clmId.HeaderText = "ID";
            clmId.Name = "clmId";
            clmId.ReadOnly = true;
            clmId.Width = 40;
            // 
            // clmRazaoSocial
            // 
            clmRazaoSocial.Frozen = true;
            clmRazaoSocial.HeaderText = "Razão Social";
            clmRazaoSocial.Name = "clmRazaoSocial";
            clmRazaoSocial.ReadOnly = true;
            clmRazaoSocial.Width = 150;
            // 
            // clmFantasia
            // 
            clmFantasia.Frozen = true;
            clmFantasia.HeaderText = "Fantasia";
            clmFantasia.Name = "clmFantasia";
            clmFantasia.ReadOnly = true;
            clmFantasia.Width = 150;
            // 
            // clmCnpj
            // 
            clmCnpj.Frozen = true;
            clmCnpj.HeaderText = "CNPJ";
            clmCnpj.Name = "clmCnpj";
            clmCnpj.ReadOnly = true;
            // 
            // clmContato
            // 
            clmContato.Frozen = true;
            clmContato.HeaderText = "Contato";
            clmContato.Name = "clmContato";
            clmContato.ReadOnly = true;
            clmContato.Width = 80;
            // 
            // clmTelefone
            // 
            clmTelefone.Frozen = true;
            clmTelefone.HeaderText = "Telefone";
            clmTelefone.Name = "clmTelefone";
            clmTelefone.ReadOnly = true;
            clmTelefone.Width = 80;
            // 
            // clmEmail
            // 
            clmEmail.Frozen = true;
            clmEmail.HeaderText = "Email";
            clmEmail.Name = "clmEmail";
            clmEmail.ReadOnly = true;
            clmEmail.Width = 150;
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 551);
            Controls.Add(dgvFornecedor);
            Controls.Add(btnEditar);
            Controls.Add(btnConsultar);
            Controls.Add(btnAdicionar);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblContato);
            Controls.Add(lblCnpj);
            Controls.Add(lblfantasia);
            Controls.Add(lblRazaoSocial);
            Controls.Add(lblId);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtContato);
            Controls.Add(txtCnpj);
            Controls.Add(txtFantasia);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtId);
            Name = "FrmFornecedor";
            Text = "FrmFornecedor";
            Load += FrmFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtRazaoSocial;
        private TextBox txtFantasia;
        private TextBox txtCnpj;
        private TextBox txtContato;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label lblId;
        private Label lblRazaoSocial;
        private Label lblfantasia;
        private Label lblCnpj;
        private Label lblContato;
        private Label lblTelefone;
        private Label lblEmail;
        private Button btnAdicionar;
        private Button btnConsultar;
        private Button btnEditar;
        private DataGridView dgvFornecedor;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmRazaoSocial;
        private DataGridViewTextBoxColumn clmFantasia;
        private DataGridViewTextBoxColumn clmCnpj;
        private DataGridViewTextBoxColumn clmContato;
        private DataGridViewTextBoxColumn clmTelefone;
        private DataGridViewTextBoxColumn clmEmail;
    }
}
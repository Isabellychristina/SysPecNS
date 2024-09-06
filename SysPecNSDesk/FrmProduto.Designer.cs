namespace SysPecNSDesk
{
    partial class FrmProduto
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            npEstoqueMinimo = new NumericUpDown();
            lblDesconto = new Label();
            lblCategoria = new Label();
            lblDescricao = new Label();
            lblEstoqueMin = new Label();
            lblUnidadeVenda = new Label();
            lblValorUni = new Label();
            lblCodBar = new Label();
            lblId = new Label();
            cmbCategoria = new ComboBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            txtId = new TextBox();
            txtDesconto = new TextBox();
            txtDescricao = new TextBox();
            txtUnidadeVenda = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBar = new TextBox();
            dgvProdutos = new DataGridView();
            lblTitulo = new Label();
            ClnId = new DataGridViewTextBoxColumn();
            ClnCodBar = new DataGridViewTextBoxColumn();
            ClnDescrição = new DataGridViewTextBoxColumn();
            ClnValorUni = new DataGridViewTextBoxColumn();
            ClnUnidadeDeVenda = new DataGridViewTextBoxColumn();
            ClnCategoria = new DataGridViewTextBoxColumn();
            ClnEstoqueMin = new DataGridViewTextBoxColumn();
            ClnDesconto = new DataGridViewTextBoxColumn();
            ClnDataCad = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(npEstoqueMinimo);
            groupBox1.Controls.Add(lblDesconto);
            groupBox1.Controls.Add(lblCategoria);
            groupBox1.Controls.Add(lblDescricao);
            groupBox1.Controls.Add(lblEstoqueMin);
            groupBox1.Controls.Add(lblUnidadeVenda);
            groupBox1.Controls.Add(lblValorUni);
            groupBox1.Controls.Add(lblCodBar);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtUnidadeVenda);
            groupBox1.Controls.Add(txtValorUnit);
            groupBox1.Controls.Add(txtCodBar);
            groupBox1.Location = new Point(22, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(903, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Location = new Point(618, 136);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(81, 23);
            npEstoqueMinimo.TabIndex = 3;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(23, 278);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 28;
            lblDesconto.Text = "Desconto";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(291, 200);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 27;
            lblCategoria.Text = "Categoria";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(23, 200);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 26;
            lblDescricao.Text = "Descrição";
            // 
            // lblEstoqueMin
            // 
            lblEstoqueMin.AutoSize = true;
            lblEstoqueMin.Location = new Point(618, 118);
            lblEstoqueMin.Name = "lblEstoqueMin";
            lblEstoqueMin.Size = new Size(94, 15);
            lblEstoqueMin.TabIndex = 25;
            lblEstoqueMin.Text = "Estoque Mínimo";
            // 
            // lblUnidadeVenda
            // 
            lblUnidadeVenda.AutoSize = true;
            lblUnidadeVenda.Location = new Point(441, 118);
            lblUnidadeVenda.Name = "lblUnidadeVenda";
            lblUnidadeVenda.Size = new Size(102, 15);
            lblUnidadeVenda.TabIndex = 24;
            lblUnidadeVenda.Text = "Unidade de Venda";
            // 
            // lblValorUni
            // 
            lblValorUni.AutoSize = true;
            lblValorUni.Location = new Point(276, 118);
            lblValorUni.Name = "lblValorUni";
            lblValorUni.Size = new Size(78, 15);
            lblValorUni.TabIndex = 23;
            lblValorUni.Text = "Valor Unitário";
            // 
            // lblCodBar
            // 
            lblCodBar.AutoSize = true;
            lblCodBar.Location = new Point(23, 118);
            lblCodBar.Name = "lblCodBar";
            lblCodBar.Size = new Size(97, 15);
            lblCodBar.TabIndex = 22;
            lblCodBar.Text = "Código de Barras";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(23, 31);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 21;
            lblId.Text = "Id";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(291, 218);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(447, 23);
            cmbCategoria.TabIndex = 5;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(491, 296);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(364, 296);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(228, 296);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(23, 49);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 15;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(23, 296);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(157, 23);
            txtDesconto.TabIndex = 6;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(23, 218);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(223, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.ForeColor = SystemColors.ScrollBar;
            txtUnidadeVenda.Location = new Point(441, 136);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(157, 23);
            txtUnidadeVenda.TabIndex = 2;
            txtUnidadeVenda.Text = "Ex:CAIXA";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(276, 136);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(138, 23);
            txtValorUnit.TabIndex = 1;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(23, 136);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(210, 23);
            txtCodBar.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { ClnId, ClnCodBar, ClnDescrição, ClnValorUni, ClnUnidadeDeVenda, ClnCategoria, ClnEstoqueMin, ClnDesconto, ClnDataCad });
            dgvProdutos.Location = new Point(22, 444);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(903, 171);
            dgvProdutos.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(355, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 36);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "PRODUTOS";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // ClnId
            // 
            ClnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = Color.White;
            ClnId.DefaultCellStyle = dataGridViewCellStyle1;
            ClnId.HeaderText = "ID";
            ClnId.Name = "ClnId";
            ClnId.ReadOnly = true;
            ClnId.Width = 50;
            // 
            // ClnCodBar
            // 
            ClnCodBar.HeaderText = "Código de Barras";
            ClnCodBar.Name = "ClnCodBar";
            ClnCodBar.ReadOnly = true;
            ClnCodBar.Width = 170;
            // 
            // ClnDescrição
            // 
            ClnDescrição.HeaderText = "Descrição";
            ClnDescrição.Name = "ClnDescrição";
            ClnDescrição.ReadOnly = true;
            ClnDescrição.Width = 200;
            // 
            // ClnValorUni
            // 
            ClnValorUni.HeaderText = "Valor Unitário";
            ClnValorUni.Name = "ClnValorUni";
            ClnValorUni.ReadOnly = true;
            ClnValorUni.Width = 60;
            // 
            // ClnUnidadeDeVenda
            // 
            ClnUnidadeDeVenda.HeaderText = "Unidade de Venda";
            ClnUnidadeDeVenda.Name = "ClnUnidadeDeVenda";
            ClnUnidadeDeVenda.ReadOnly = true;
            ClnUnidadeDeVenda.Width = 80;
            // 
            // ClnCategoria
            // 
            ClnCategoria.HeaderText = "Categoria";
            ClnCategoria.Name = "ClnCategoria";
            ClnCategoria.ReadOnly = true;
            // 
            // ClnEstoqueMin
            // 
            ClnEstoqueMin.HeaderText = "Estoque Mínimo";
            ClnEstoqueMin.Name = "ClnEstoqueMin";
            ClnEstoqueMin.ReadOnly = true;
            ClnEstoqueMin.Width = 80;
            // 
            // ClnDesconto
            // 
            ClnDesconto.HeaderText = "Desconto";
            ClnDesconto.Name = "ClnDesconto";
            ClnDesconto.ReadOnly = true;
            // 
            // ClnDataCad
            // 
            ClnDataCad.HeaderText = "Data Cadastro";
            ClnDataCad.Name = "ClnDataCad";
            ClnDataCad.ReadOnly = true;
            ClnDataCad.Width = 80;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 643);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProdutos);
            Controls.Add(groupBox1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private TextBox txtId;
        private TextBox txtDesconto;
        private TextBox txtDescricao;
        private TextBox txtUnidadeVenda;
        private TextBox txtValorUnit;
        private TextBox txtCodBar;
        private Label lblDesconto;
        private Label lblCategoria;
        private Label lblDescricao;
        private Label lblEstoqueMin;
        private Label lblUnidadeVenda;
        private Label lblValorUni;
        private Label lblCodBar;
        private Label lblId;
        private ComboBox cmbCategoria;
        private DataGridView dgvProdutos;
        private NumericUpDown npEstoqueMinimo;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn ClnId;
        private DataGridViewTextBoxColumn ClnCodBar;
        private DataGridViewTextBoxColumn ClnDescrição;
        private DataGridViewTextBoxColumn ClnValorUni;
        private DataGridViewTextBoxColumn ClnUnidadeDeVenda;
        private DataGridViewTextBoxColumn ClnCategoria;
        private DataGridViewTextBoxColumn ClnEstoqueMin;
        private DataGridViewTextBoxColumn ClnDesconto;
        private DataGridViewTextBoxColumn ClnDataCad;
    }
}
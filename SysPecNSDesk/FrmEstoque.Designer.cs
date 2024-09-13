namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            label1 = new Label();
            txtProdudoId = new TextBox();
            dgvEstoque = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnProdutoid = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clndata_ultimo_movimento = new DataGridViewTextBoxColumn();
            btnConsultar = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            btnAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 37);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Id do Produto";
            // 
            // txtProdudoId
            // 
            txtProdudoId.Enabled = false;
            txtProdudoId.Location = new Point(11, 65);
            txtProdudoId.Name = "txtProdudoId";
            txtProdudoId.Size = new Size(142, 23);
            txtProdudoId.TabIndex = 0;
            txtProdudoId.TextChanged += txtProdudoId_TextChanged;
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { clnId, clnProdutoid, clnQuantidade, clndata_ultimo_movimento });
            dgvEstoque.Location = new Point(8, 238);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.Size = new Size(574, 202);
            dgvEstoque.TabIndex = 4;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 80;
            // 
            // clnProdutoid
            // 
            clnProdutoid.Frozen = true;
            clnProdutoid.HeaderText = "Produto_Id";
            clnProdutoid.Name = "clnProdutoid";
            clnProdutoid.ReadOnly = true;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 150;
            // 
            // clndata_ultimo_movimento
            // 
            clndata_ultimo_movimento.Frozen = true;
            clndata_ultimo_movimento.HeaderText = "Data da Ultima movimentação";
            clndata_ultimo_movimento.Name = "clndata_ultimo_movimento";
            clndata_ultimo_movimento.ReadOnly = true;
            clndata_ultimo_movimento.Width = 200;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(45, 104);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 37);
            btnConsultar.TabIndex = 13;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvEstoque);
            groupBox1.Location = new Point(175, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 461);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controle de Estoque";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 169);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 15;
            label2.Text = "Quantidade";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 325);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(141, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 298);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 17;
            label3.Text = "Data";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(45, 235);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 38);
            btnAdicionar.TabIndex = 18;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 553);
            Controls.Add(btnAdicionar);
            Controls.Add(label3);
            Controls.Add(btnConsultar);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtProdudoId);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProdudoId;
        private DataGridView dgvEstoque;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnProdutoid;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clndata_ultimo_movimento;
        private Button btnConsultar;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button btnAdicionar;
    }
}
namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            grbIdentificacao = new GroupBox();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            grbItens = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label9 = new Label();
            txtDescontoItem = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            btnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtIdPedido = new TextBox();
            label2 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            txtSubTotal = new TextBox();
            txtDescontoPedido = new TextBox();
            txtDescontoItens = new TextBox();
            btnFechar = new Button();
            txtTotal = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox1 = new GroupBox();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(btnInserePedido);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(label4);
            grbIdentificacao.Controls.Add(textBox2);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Controls.Add(label3);
            grbIdentificacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbIdentificacao.Location = new Point(14, 77);
            grbIdentificacao.Margin = new Padding(3, 4, 3, 4);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Padding = new Padding(3, 4, 3, 4);
            grbIdentificacao.Size = new Size(854, 183);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            // 
            // btnInserePedido
            // 
            btnInserePedido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserePedido.Location = new Point(695, 59);
            btnInserePedido.Margin = new Padding(3, 4, 3, 4);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(86, 65);
            btnInserePedido.TabIndex = 5;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(99, 100);
            txtIdCliente.Margin = new Padding(3, 4, 3, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(98, 27);
            txtIdCliente.TabIndex = 4;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 104);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Cliente";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(221, 100);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(415, 32);
            textBox2.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(99, 36);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(537, 32);
            txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 43);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Usuário";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(radioButton2);
            grbItens.Controls.Add(radioButton1);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbItens.Location = new Point(14, 268);
            grbItens.Margin = new Padding(3, 4, 3, 4);
            grbItens.Name = "grbItens";
            grbItens.Padding = new Padding(3, 4, 3, 4);
            grbItens.Size = new Size(854, 349);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(634, 13);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(124, 24);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(488, 13);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(124, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(641, 38);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(635, 64);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.Size = new Size(93, 27);
            txtDescontoItem.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(539, 40);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 9;
            label8.Text = "Quant.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(439, 42);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 8;
            label7.Text = "Valor Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(154, 43);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 7;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 42);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 6;
            label5.Text = "Código de Barras";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(537, 65);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(75, 27);
            txtQuantidade.TabIndex = 5;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(439, 65);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(82, 27);
            txtValorUnit.TabIndex = 4;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(6, 65);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(96, 27);
            txtCodBar.TabIndex = 3;
            txtCodBar.TextChanged += txtCodBar_TextChanged;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(154, 65);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(266, 27);
            txtDescricao.TabIndex = 2;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(754, 37);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(94, 55);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(6, 112);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.RowHeadersWidth = 51;
            dgvItensPedido.Size = new Size(842, 230);
            dgvItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.MinimumWidth = 6;
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 50;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.MinimumWidth = 6;
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 130;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.MinimumWidth = 6;
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.MinimumWidth = 6;
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 110;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.MinimumWidth = 6;
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 125;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.MinimumWidth = 6;
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 125;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.MinimumWidth = 6;
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(427, 12);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 2;
            label1.Text = "NOVO PEDIDO";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.Location = new Point(754, 12);
            txtIdPedido.Margin = new Padding(3, 4, 3, 4);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(214, 52);
            txtIdPedido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(648, 12);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 4;
            label2.Text = "Número";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(618, 625);
            label10.Name = "label10";
            label10.Size = new Size(112, 31);
            label10.TabIndex = 5;
            label10.Text = "TOTAL R$";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Navy;
            textBox1.Location = new Point(737, 622);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 38);
            textBox1.TabIndex = 6;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(67, 56);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(218, 27);
            txtSubTotal.TabIndex = 7;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(67, 181);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(218, 27);
            txtDescontoPedido.TabIndex = 8;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(67, 124);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(218, 27);
            txtDescontoItens.TabIndex = 9;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(130, 268);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 68);
            btnFechar.TabIndex = 11;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(67, 235);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(218, 27);
            txtTotal.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(67, 33);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 12;
            label11.Text = "Sub Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(67, 96);
            label12.Name = "label12";
            label12.Size = new Size(128, 20);
            label12.TabIndex = 13;
            label12.Text = "Desconto Itens R$";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(67, 158);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 14;
            label13.Text = "Desconto R$";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(67, 211);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 15;
            label14.Text = "Total R$";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtSubTotal);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtDescontoPedido);
            groupBox1.Controls.Add(txtDescontoItens);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(btnFechar);
            groupBox1.Location = new Point(883, 268);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 349);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formas";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(1239, 663);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(txtIdPedido);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            TransparencyKey = SystemColors.ActiveBorder;
            Load += FrmPedidoNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private Label label3;
        private Label label1;
        private TextBox txtIdPedido;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox textBox2;
        private Label label4;
        private Button btnInserePedido;
        private TextBox txtIdCliente;
        private Button btnAddItem;
        private DataGridView dgvItensPedido;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private Label label9;
        private TextBox txtDescontoItem;
        private Label label10;
        private TextBox textBox1;
        private TextBox txtSubTotal;
        private TextBox txtDescontoPedido;
        private TextBox txtDescontoItens;
        private Button btnFechar;
        private TextBox txtTotal;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
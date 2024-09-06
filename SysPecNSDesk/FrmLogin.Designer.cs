namespace SysPecNSDesk
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblEmail = new Label();
            lblSenha = new Label();
            btnLogar = new Button();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(50, 55);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(50, 126);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 17);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.PeachPuff;
            btnLogar.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogar.Location = new Point(71, 215);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(90, 31);
            btnLogar.TabIndex = 2;
            btnLogar.Text = "&Entrar";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.PeachPuff;
            btnCancelar.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(246, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 31);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.PeachPuff;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(50, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(215, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.PeachPuff;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(50, 157);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(215, 23);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("News706 BT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(108, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(238, 25);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Area de Login SysPec";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // FrmLogin
            // 
            AcceptButton = btnLogar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            BackgroundImage = Properties.Resources.pngtree_rainbow_curves_abstract_colorful_background_image_2164067;
            BackgroundImageLayout = ImageLayout.Center;
            CancelButton = btnCancelar;
            ClientSize = new Size(424, 274);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnLogar);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblSenha;
        private Button btnLogar;
        private Button btnCancelar;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblTitulo;
    }
}
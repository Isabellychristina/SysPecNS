namespace SysPecNSDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirma = new Button();
            txtConfirma = new TextBox();
            lstConfirma = new ListBox();
            SuspendLayout();
            // 
            // btnConfirma
            // 
            btnConfirma.Location = new Point(282, 321);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(75, 23);
            btnConfirma.TabIndex = 0;
            btnConfirma.Text = "button1";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // txtNumero
            // 
            txtConfirma.Location = new Point(282, 292);
            txtConfirma.Name = "txtConfirma";
            txtConfirma.Size = new Size(100, 23);
            txtConfirma.TabIndex = 1;
            txtConfirma.Text = "&Confirma";
            // 
            // lstConfirma
            // 
            lstConfirma.FormattingEnabled = true;
            lstConfirma.ItemHeight = 15;
            lstConfirma.Location = new Point(282, 192);
            lstConfirma.Name = "lstConfirma";
            lstConfirma.Size = new Size(120, 94);
            lstConfirma.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstConfirma);
            Controls.Add(txtConfirma);
            Controls.Add(btnConfirma);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirma;
        private TextBox txtConfirma;
        private ListBox lstConfirma;
    }
}

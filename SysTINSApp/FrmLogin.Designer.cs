namespace SysTINSApp
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
            txtEmail = new Label();
            textBox1 = new TextBox();
            txtSenha = new Label();
            textBox2 = new TextBox();
            btnEntrar = new Label();
            btnCancelar = new Label();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.ForeColor = SystemColors.ButtonFace;
            txtEmail.Location = new Point(262, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(61, 25);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "E-mail";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Font = new Font("Segoe UI", 13F);
            txtSenha.ForeColor = SystemColors.ButtonFace;
            txtSenha.Location = new Point(262, 196);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(60, 25);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            txtSenha.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            
            // 
            // btnEntrar
            // 
            btnEntrar.AutoSize = true;
            btnEntrar.Location = new Point(262, 299);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(38, 15);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "&Entrar";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Location = new Point(417, 299);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(53, 15);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 12F);
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Location = new Point(262, 266);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 21);
            lblMensagem.TabIndex = 7;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblMensagem);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(textBox2);
            Controls.Add(txtSenha);
            Controls.Add(textBox1);
            Controls.Add(txtEmail);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtEmail;
        private TextBox textBox1;
        private Label txtSenha;
        private TextBox textBox2;
        private Label btnEntrar;
        private Label btnCancelar;
        private Label lblMensagem;
    }
}
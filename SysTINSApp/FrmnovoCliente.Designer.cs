namespace SysTINSApp
{
    partial class FrmnovoCliente
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
            lblcliente = new Label();
            txtNome = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtTelefone = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblDatanas = new Label();
            btnCadas = new Button();
            lblCPF = new Label();
            txtCPF = new TextBox();
            lblCadastro = new Label();
            SuspendLayout();
            // 
            // lblcliente
            // 
            lblcliente.AutoSize = true;
            lblcliente.Location = new Point(36, 87);
            lblcliente.Name = "lblcliente";
            lblcliente.Size = new Size(97, 15);
            lblcliente.TabIndex = 0;
            lblcliente.Text = "Nome do Cliente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(36, 114);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(259, 23);
            txtNome.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(317, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(36, 168);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(148, 23);
            txtTelefone.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 150);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(205, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(205, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblDatanas
            // 
            lblDatanas.AutoSize = true;
            lblDatanas.Location = new Point(317, 87);
            lblDatanas.Name = "lblDatanas";
            lblDatanas.Size = new Size(114, 15);
            lblDatanas.TabIndex = 7;
            lblDatanas.Text = "Data de Nascimento";
            // 
            // btnCadas
            // 
            btnCadas.Location = new Point(36, 245);
            btnCadas.Name = "btnCadas";
            btnCadas.Size = new Size(75, 23);
            btnCadas.TabIndex = 8;
            btnCadas.Text = "Cadastrar";
            btnCadas.UseVisualStyleBackColor = true;
            btnCadas.Click += btnCadas_Click;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(441, 150);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 9;
            lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(441, 168);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(143, 23);
            txtCPF.TabIndex = 10;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI", 19F);
            lblCadastro.Location = new Point(275, 9);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(242, 36);
            lblCadastro.TabIndex = 11;
            lblCadastro.Text = "Cadastro De Cliente";
            // 
            // FrmnovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCadastro);
            Controls.Add(txtCPF);
            Controls.Add(lblCPF);
            Controls.Add(btnCadas);
            Controls.Add(lblDatanas);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNome);
            Controls.Add(lblcliente);
            Name = "FrmnovoCliente";
            Text = "FrmNovoCliente";
            Load += FrmnovoCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcliente;
        private TextBox txtNome;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTelefone;
        private Label label1;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblDatanas;
        private Button btnCadas;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblCadastro;
    }
}
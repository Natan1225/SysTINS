namespace SysTINSApp
{
    partial class FrmConsultaCliente
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
            lblNome = new Label();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            lblCPF = new Label();
            chcativo = new CheckBox();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Endereço = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewTextBoxColumn();
            btnConsultar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(50, 78);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(97, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do Cliente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(50, 96);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(257, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(336, 98);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(134, 23);
            txtCPF.TabIndex = 2;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(347, 80);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // chcativo
            // 
            chcativo.AutoSize = true;
            chcativo.Location = new Point(515, 102);
            chcativo.Name = "chcativo";
            chcativo.Size = new Size(54, 19);
            chcativo.TabIndex = 4;
            chcativo.Text = "Ativo";
            chcativo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, CPF, Endereço, Ativo });
            dataGridView1.Location = new Point(24, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(764, 190);
            dataGridView1.TabIndex = 5;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 270;
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            // 
            // Endereço
            // 
            Endereço.HeaderText = "Endereço";
            Endereço.Name = "Endereço";
            Endereço.Width = 250;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(50, 194);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(151, 194);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(256, 194);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(btnExcluir);
            Controls.Add(btnConsultar);
            Controls.Add(dataGridView1);
            Controls.Add(chcativo);
            Controls.Add(lblCPF);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FrmConsultaCliente";
            Text = "FrmConsultaCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCPF;
        private Label lblCPF;
        private CheckBox chcativo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Endereço;
        private DataGridViewTextBoxColumn Ativo;
        private Button btnConsultar;
        private Button btnExcluir;
        private Button btnAtualizar;
    }
}
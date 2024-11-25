using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;

namespace SysTINSApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            Hide();
            FrmLogin frmLogin = new();
            var retorno = frmLogin.ShowDialog();
            if (retorno == DialogResult.OK)
            {
                tsslUsuario.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
                MessageBox.Show($"Usuario Logado Com Sucesso!");
                Show();
            }

            else
                Application.Exit();




        }



        private void novoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new(); // cria uma instância (objeto) do FrmUsuarios
            frmUsuarios.MdiParent = this; //associa esta instância ao container (MDI) FrmPrincipal
            frmUsuarios.Show(); // exibe o form 
        }

        private void manterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmnovoCliente frmNovoCliente = new();
            frmNovoCliente.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frmConsultaCliente = new();
            frmConsultaCliente.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmnovoPedido frmnovoPedido = new();
            frmnovoPedido.MdiParent = this;
            frmnovoPedido.txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome;
            frmnovoPedido.Show();
        }
    }
}

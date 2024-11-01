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

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            Hide();
            FrmLogin frmLogin = new();
           var retorno = frmLogin.ShowDialog();
            if (retorno == DialogResult.OK)
            {
                tsslUsuario.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
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
    }
}

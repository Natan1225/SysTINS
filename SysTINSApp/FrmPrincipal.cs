﻿using System;
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
        //    var cmd = Banco.Abrir();
        //    cmd.CommandText = "select * from niveis where id = 1";
        //    var dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        MessageBox.Show($"Olá {dr.GetString(1)}");
        //    }
        //}

        //private void movimentoToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    FrmUsuarios frmUsuarios = new();
        //    frmUsuarios.MdiParent = this;
        //    frmUsuarios.Show();
        }
    }
}

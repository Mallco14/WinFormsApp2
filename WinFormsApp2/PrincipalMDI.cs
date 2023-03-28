using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            manUsuario usuario = new manUsuario();
            usuario.Show();
            this.Hide();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
                    
        }
    }
}

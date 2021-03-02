using LaboratorioProgramacionUno.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.lblEstado.Text = 0.ToString();

            this.Hide();
            frm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.lblEstado.Text = 1.ToString();

            this.Hide();
            frm.Show();
        }
    }
}

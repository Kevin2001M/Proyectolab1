using LaboratorioProgramacionUno.DOMINIO;
using LaboratorioProgramacionUno.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno.VISTA
{
    
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        public int estado;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //tipoLogin tipo = new tipoLogin();
            //tipo.Estado = estado;

            Login log = new Login();
            log.Usuario = txtNombre.Text;
            log.Password = txtPassword.Text;
            log.Estado = this.estado;
            
            
            clsLogin cls = new clsLogin();
            int varComparar = cls.Users(log);
            Operaciones frmOp = new Operaciones();

            if (varComparar == 1 && estado == 0) {
                
                MessageBox.Show("Binevenido " + txtNombre.Text);

                this.Hide();
                frmOp.Show();

                frmOp.txtIva.Enabled = false;
                frmOp.txtNombreDelProducto.Enabled = false;

            } else if (varComparar == 1 && estado == 1) {

                MessageBox.Show("Binevenido " + txtNombre.Text);

                this.Hide();
                frmOp.Show();
            }
            else {
                MessageBox.Show("Datos erroneos, intentelo de nuevo.");
            }
            frmOp.lblNombreDeUsuario.Text = txtNombre.Text;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            estado = Convert.ToInt32(lblEstado.Text);
        }
    }
}

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
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double IVA = Convert.ToDouble(txtIva.Text);
            string nombreDelProducto = txtNombreDelProducto.Text;
            double precioP = Convert.ToDouble(txtPrecioDelProducto.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            double descuento = 0;
            double TotalSinIva = 0;

            lblNombreDelProducto.Text = nombreDelProducto.ToString();
            if (precioP <= 50)
            {
                descuento = 0.0;
            }
            else if (precioP > 50 && precioP < 100)
            {
                descuento = 0.05;
            }
            else if (precioP >= 100 && precioP < 101)
            {
                descuento = 0.10;
            }
            else if (precioP >= 101 && precioP < 150)
            {
                descuento = 0.20;
            }
            else if (precioP >= 150)
            {
                descuento = 0.50;
            }
            TotalSinIva = precioP * cantidad;
            lblTotalSinIVA.Text = TotalSinIva.ToString();

            double IvaAAgregar = TotalSinIva * IVA;
            lblIvaAAgregar.Text = IvaAAgregar.ToString();

            double TotalSinDConIva = TotalSinIva + IvaAAgregar;
            lblTotalSinDescuentoSinIva.Text = TotalSinDConIva.ToString();

            double TotalAPagar = TotalSinDConIva - (TotalSinDConIva * descuento);
            lblTotalAPagar.Text = TotalAPagar.ToString();
        }

        private void Operaciones_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MENOR o IGUAL 50 NO TENDRÁ DESCUENTO", "<=50");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100 TENDRÁ UN DESCUENTO DEL 0.05", " >50 and <100 ");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL A 100 O MENOR QUE 101 TENDRÁ UN DESCUENTO DEL 0.10 ", " >= 100 and < 101");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL 101 Y MENOR QUE 150 TENDRÁ UN DESCUENTO DEL 0.20", ">101 and <150");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRÁ UN DESCUENTO DEL 0.50", "> 150");
        }
    }
}

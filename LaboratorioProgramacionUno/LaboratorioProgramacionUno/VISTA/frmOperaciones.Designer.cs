
namespace LaboratorioProgramacionUno.VISTA
{
    partial class Operaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSinIVA = new System.Windows.Forms.Label();
            this.lblNombreDelProducto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIvaAAgregar = new System.Windows.Forms.Label();
            this.lblTotalSinDescuentoSinIva = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioDelProducto = new System.Windows.Forms.TextBox();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla de descuentos";
            // 
            // lblTotalSinIVA
            // 
            this.lblTotalSinIVA.AutoSize = true;
            this.lblTotalSinIVA.Location = new System.Drawing.Point(1182, 363);
            this.lblTotalSinIVA.Name = "lblTotalSinIVA";
            this.lblTotalSinIVA.Size = new System.Drawing.Size(14, 20);
            this.lblTotalSinIVA.TabIndex = 1;
            this.lblTotalSinIVA.Text = "-";
            // 
            // lblNombreDelProducto
            // 
            this.lblNombreDelProducto.AutoSize = true;
            this.lblNombreDelProducto.Location = new System.Drawing.Point(1182, 305);
            this.lblNombreDelProducto.Name = "lblNombreDelProducto";
            this.lblNombreDelProducto.Size = new System.Drawing.Size(14, 20);
            this.lblNombreDelProducto.TabIndex = 2;
            this.lblNombreDelProducto.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(867, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total sin descuento y con IVA incluido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(868, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "IVA a agregar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(868, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total sin IVA:";
            // 
            // lblIvaAAgregar
            // 
            this.lblIvaAAgregar.AutoSize = true;
            this.lblIvaAAgregar.Location = new System.Drawing.Point(1182, 430);
            this.lblIvaAAgregar.Name = "lblIvaAAgregar";
            this.lblIvaAAgregar.Size = new System.Drawing.Size(14, 20);
            this.lblIvaAAgregar.TabIndex = 6;
            this.lblIvaAAgregar.Text = "-";
            // 
            // lblTotalSinDescuentoSinIva
            // 
            this.lblTotalSinDescuentoSinIva.AutoSize = true;
            this.lblTotalSinDescuentoSinIva.Location = new System.Drawing.Point(1182, 484);
            this.lblTotalSinDescuentoSinIva.Name = "lblTotalSinDescuentoSinIva";
            this.lblTotalSinDescuentoSinIva.Size = new System.Drawing.Size(14, 20);
            this.lblTotalSinDescuentoSinIva.TabIndex = 7;
            this.lblTotalSinDescuentoSinIva.Text = "-";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(1182, 532);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(14, 20);
            this.lblTotalAPagar.TabIndex = 8;
            this.lblTotalAPagar.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(868, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(867, 532);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total a pagar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 551);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(112, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nombre del producto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(112, 484);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Precio del producto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "IVA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1081, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "Usuario actual:";
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(1081, 69);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(14, 20);
            this.lblNombreDeUsuario.TabIndex = 16;
            this.lblNombreDeUsuario.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(116, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ACCION";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "REGLA";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(325, 335);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(217, 26);
            this.txtIva.TabIndex = 18;
            this.txtIva.Text = "0.13";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(325, 545);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(217, 26);
            this.txtCantidad.TabIndex = 19;
            // 
            // txtPrecioDelProducto
            // 
            this.txtPrecioDelProducto.Location = new System.Drawing.Point(325, 484);
            this.txtPrecioDelProducto.Name = "txtPrecioDelProducto";
            this.txtPrecioDelProducto.Size = new System.Drawing.Size(217, 26);
            this.txtPrecioDelProducto.TabIndex = 20;
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Location = new System.Drawing.Point(325, 406);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(217, 26);
            this.txtNombreDelProducto.TabIndex = 21;
            this.txtNombreDelProducto.Text = "LAPTOP";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(399, 605);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(142, 32);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Operaciones
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 669);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNombreDelProducto);
            this.Controls.Add(this.txtPrecioDelProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.lblTotalSinDescuentoSinIva);
            this.Controls.Add(this.lblIvaAAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNombreDelProducto);
            this.Controls.Add(this.lblTotalSinIVA);
            this.Controls.Add(this.label1);
            this.Name = "Operaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.Operaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalSinIVA;
        private System.Windows.Forms.Label lblNombreDelProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIvaAAgregar;
        private System.Windows.Forms.Label lblTotalSinDescuentoSinIva;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioDelProducto;
        private System.Windows.Forms.Button btnCalcular;
        public System.Windows.Forms.TextBox txtIva;
        public System.Windows.Forms.TextBox txtNombreDelProducto;
        public System.Windows.Forms.Label lblNombreDeUsuario;
    }
}
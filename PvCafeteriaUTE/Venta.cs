using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PvCafeteria.Modelo
{
    public partial class Venta : Form
    {
        //corores generales botones y color de letra
        int col1 = 094;
        int col2 = 153;
        int col3 = 033;

        //corores generales fondo
        int col21 = 234;
        int col22 = 255;
        int col23 = 209;
        //variable nota num
        int numNota =0;

         Negocios.NVenta cnventas = new Negocios.NVenta();//objeto de Nproveedor en consola
        public Venta()
        {
            InitializeComponent();
             
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

        }

        private void txtnotanum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            nota_id();
            
            //color de fonfo 
            this.BackColor = System.Drawing.Color.FromArgb(col21, col22, col23);
            //color de las letras
            ForeColor = Color.FromArgb(col1, col2, col3);
            //colores de los texbox 
            this.txtcodigo.ForeColor = Color.FromArgb(col1, col2, col3);
            this.txtcantidad.ForeColor = Color.FromArgb(col1, col2, col3);
            this.txtimporte.ForeColor = Color.FromArgb(col1, col2, col3);
            //estilo de la tabla 
            this.TablaVenta.BackgroundColor = Color.FromArgb(col21, col22, col23);
            TablaVenta.EnableHeadersVisualStyles = false;
            TablaVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(col1, col2, col3);
            TablaVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(col21, col22, col23);
            this.TablaVenta.BorderStyle = BorderStyle.Fixed3D;
            TablaVenta.AutoGenerateColumns = false;
            TablaVenta.RowHeadersVisible = false;
            //texto campo cantida default con valor de 1 txtcantidad
             
            txtcantidad.Text="1";

            txtnotanum.Text = numNota.ToString();
           
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }

        private void TablaVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtcantidad.Text.Length; i++)
            {
                if (txtcantidad.Text[i] == '.')
                { IsDec = true; }

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            { e.Handled = false; }
            else if (e.KeyChar == 46)
            { e.Handled = (IsDec) ? true : false; }
            else
            { e.Handled = true; }
        }

        private void btnAgregarpro_Click(object sender, EventArgs e)
        {
            if (campo_lleno() == true)
            {
                cnventas.Ven_notaid = numNota;
                cnventas.Ven_Codigo = txtcodigo.Text;
                cnventas.Ven_cantidad = Convert.ToDouble(txtcantidad.Text);
                cnventas.Busca_producto();
                cnventas.Agregar_productoventas();
                llenartablaventa();
                 
            }
        }

        private bool campo_lleno()//comprobacion del  codigo del producto y cantidad

        {
            bool lleno = false;
            if (!string.IsNullOrWhiteSpace(txtcodigo.Text)) //comprueba que no este vacio txtcodigo
            {
                if (!string.IsNullOrWhiteSpace(txtcantidad.Text))
                {
                    lleno = true;
                }
                else { MessageBox.Show("Inserte cantidad "); }
            }
            else { MessageBox.Show("Inserte el codigo del producto a vender"); }

            return lleno;
        }

        private void llenartablaventa()//nena la tabal venta
        {
            
            DataTable tabla = cnventas.Tablaventa();
            TablaVenta.DataSource = tabla;
        }

        private void nota_id()
        {
             DataTable tabla = cnventas.busca_num_nota();
            

                for (int i = 0; i < tabla.Rows.Count; i++)//busca los datos en la tabla temporal
                {
                    //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                    numNota = Convert.ToInt32(tabla.Rows[i]["idNota"] + "");
                   
                }
                numNota = numNota + 1;
                tabla.Clear();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            cnventas.Ven_Codigo = txtcodigo.Text;
        }

        

        


    }
}

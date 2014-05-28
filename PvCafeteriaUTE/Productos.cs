using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PvCafeteria.Modelo;
namespace PvCafeteria.Modelo
{
    public partial class Productos : Form
    {
        //corores generales botones y color de letra
        int col1 = 094;
        int col2 = 153;
        int col3 = 033;

        //corores generales fondo
        int col21 = 234;
        int col22 = 255;
        int col23 = 209;

        Negocios.NProductos cnproductos = new Negocios.NProductos();//objeto de Nproveedor en consola

        //variable que carga el valor para saber que tipo de actividad va a realizar el form
        public string ActividadahacerProductos;
        public Productos()
        {
            InitializeComponent();
        }

       

      

        private void Productos_Load(object sender, EventArgs e)
        {

            //color de fonfo 
            this.BackColor = System.Drawing.Color.FromArgb(col21, col22, col23);
            //color de las letras
            ForeColor = Color.FromArgb(col1, col2, col3);
            //colores de los texbox 
            this.txtcodproov.ForeColor = Color.FromArgb(col1, col2, col3);
            this.txtcodproduc.ForeColor = Color.FromArgb(col1, col2, col3);
            this.txtdescripcion.ForeColor = Color.FromArgb(col1, col2, col3);
            
            this.txtexistencia.ForeColor = Color.FromArgb(col1, col2, col3);
            this.txtprecioprovee.ForeColor = Color.FromArgb(col1, col2, col3);
            this.txtpreciopublic.ForeColor = Color.FromArgb(col1, col2, col3);
            estadoactividad_productos();
        }

        private void lbprovedoor_Click(object sender, EventArgs e)
        {

        }
        private void estadoactividad_productos()//metodo para saber que es lo que va a hacer al iniciar el form
        {
            switch (ActividadahacerProductos)
            {
                case "Agregar":
                    // botones de agregar producto o comida
                    button1.Visible = true;
                    button2.Visible = true;
                   // lbProveedor.Text = "Agregar Nuevo Proveedor";
                    //btnGproveedor.Text = "Guardar";
                    break;
                case "Modificar":
                    //MessageBox.Show("Modificar");
                    //lbProveedor.Text = "Modificar  Proveedor";
                   // label11.Text = "Buscar por (Código ó Nombre) del proveedor a Modificar";
                   // btnGproveedor.Text = "Modificar";
                   // panel1.Visible = true;
                    break;
                case "Eliminar":
                    // MessageBox.Show("Eliminar");
                  //  lbProveedor.Text = "Eliminar  Proveedor";
                   // label11.Text = "Buscar  por (Código  ó Nombre) del proveedor a Eliminar";
                   // btnGproveedor.Text = "Eliminar";
                    //panel1.Visible = true;

                    break;
                case "Reporte":
                    // MessageBox.Show("Eliminar");
                   // radioButton1.Checked = true;
                   // label14.Text = "Reporte de proveedores";
                   //// panel2.Visible = true;
                   // dataGridView1.AutoGenerateColumns = false;
                   // dataGridView1.RowHeadersVisible = false;
                   // llenartabla();



                    break;
                default:
                    MessageBox.Show("Otro");
                    break;

            }


        }

        private void btnNproducto_Click(object sender, EventArgs e)
        {
            label1.Text = "Agregar Nuevo Producto";
           
            radioButton1.Checked = true;
            txtcodproov.AutoCompleteCustomSource = cnproductos.Autocomplete_nombre_proveedor();
            txtcodproov.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtcodproov.AutoCompleteSource = AutoCompleteSource.CustomSource;

            if (panel2.Visible == true)
            {
                panel2.Visible = false; 
                label3.Visible = false;
                textBox7.Visible = false;
                button6.Visible = false;
            }
              panel1.Visible = true;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Agregar Nuevo Comida";
            if (panel1.Visible == true) { panel1.Visible = false; }
              panel2.Visible = true;
              label3.Visible = true;
              textBox7.Visible = true;
              button6.Visible = true;
              Max_ticket_num();
        }

      

        private void txtprecioprovee_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void GuardarproN_Click(object sender, EventArgs e)//Boton guardar
        {
            Guardar();


        }

        
        private bool validar_texbox_vacio(Panel Panel_del_formualrio)
        {
             //comprobacion de campos:
            bool vacio = false; // Variable utilizada para saber si hay algún TextBox vacio.
           
            foreach (Control oControls in Panel_del_formualrio.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio. 
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable. 
                    
                }
            }
            if (vacio == true) MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje. 
           return vacio; // Devolvemos el valor variable. 
        }

        public bool Comprobar_si_existeXodigoproducto_y_proveedor(string codigopro, string provee)//funcion para comprobar campo Codigo porducto y campo proveedor
        {
            bool existecodigo = true;
            bool codigobien1 = true;
            bool proveedorbien = false;
            try {

                DataTable tablaC = cnproductos.Consulta_Codido_Producto();
                
                for (int i = 0; i < tablaC.Rows.Count; i++)//busca los datos en la tabla temporal
                {
                    //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                    if (codigopro == (tablaC.Rows[i]["Prod_codigo"] + ""))
                    {
                        MessageBox.Show("El codigo ya existe, modifica la existencia en Inventarios");
                        codigobien1 = false;
                    }


                }//for
                tablaC.Clear();

               
                DataTable tablaP = cnproductos.Datos();
                for (int i = 0; i < tablaP.Rows.Count; i++)//busca los datos en la tabla temporal
                {                    //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                    if (provee == (tablaP.Rows[i]["provee_nombre"] + ""))
                    {
                       proveedorbien = true;
                    }

                  }//for
               
                tablaP.Clear();
                if (proveedorbien == false)
                { MessageBox.Show("No existe el proveedor, Registra en Modulo Proveedores"); }

                if ((codigobien1 == true) && (proveedorbien == true))
                {
                    existecodigo = true;
                }
                else { existecodigo = false; }
            
            }
            catch{
                existecodigo = false; 
            }
                return existecodigo;
        }//fin de la funcio

        private void Guardar()//metodo para guardar produxto
        {
            if (validar_texbox_vacio(panel1) == false)
            {
                if (Comprobar_si_existeXodigoproducto_y_proveedor(txtcodproduc.Text, txtcodproov.Text) == true)
                {
                    //variable
                    cnproductos.PrecioProProveeG = Convert.ToDouble(txtprecioprovee.Text);
                    cnproductos.PrecioProVentaG = Convert.ToDouble(txtpreciopublic.Text);
                    cnproductos.ExistenciaProG = Convert.ToDouble(txtexistencia.Text);
                     ///funciones
                    Unidad_de_medida();
                    cnproductos.AgregarProductos();
                
                }

            }
        }

        private void txtexistencia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtexistencia_KeyPress(object sender, KeyPressEventArgs e)//veneto key press campo Existencia
        {
          //  MessageBox.Show(Convert.ToInt16(e.KeyChar).ToString());

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtexistencia.Text.Length; i++)
            {
                if (txtexistencia.Text[i] == '.')
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

        private void txtprecioprovee_KeyPress(object sender, KeyPressEventArgs e)//vento key press campo precio proveedor
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtprecioprovee.Text.Length; i++)
            {
                if (txtprecioprovee.Text[i] == '.')
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

        private void txtpreciopublic_KeyPress(object sender, KeyPressEventArgs e)//vento key press campo precio publico
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtpreciopublic.Text.Length; i++)
            {
                if (txtpreciopublic.Text[i] == '.')
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

        private void txtcodproduc_TextChanged(object sender, EventArgs e)
        {
            cnproductos.CodigoProG = txtcodproduc.Text;
        }

        private void txtcodproov_TextChanged(object sender, EventArgs e)
        {
            cnproductos.proveeProG = txtcodproov.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            cnproductos.DescripProG = richTextBox1.Text; 
        }
        private void Unidad_de_medida()
        {
            if (radioButton1.Checked == true)
            {
                cnproductos.UnidadProveeG = 1;
            }
            else if (radioButton2.Checked == true)
            { cnproductos.UnidadProveeG = 2; }
            else if (radioButton3.Checked == true)
            { cnproductos.UnidadProveeG = 3; }
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            cnproductos.NombreProG = txtdescripcion.Text;
        }

        private void txtpreciopublic_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)//boton para guardar comida
        {
            if (validar_texbox_vacio(panel2) == false)
            {
                //textBox1.Text campo nombre comida
                //richTextBox2 campo descripcion para comida
                //textBox3 //campo precio comida
                //button4   boton gurdar comida
                //button3 boton cancelar comida
                cnproductos.com_nom = textBox1.Text;
                cnproductos.com_decrip = richTextBox2.Text;
                cnproductos.com_precio = Convert.ToDouble(textBox3.Text);
               // MessageBox.Show(" Guardar ");
                cnproductos.Agragr_comida();
                textBox1.Text = "";
                richTextBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (textBox3.Text[i] == '.')
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

        private void Max_ticket_num()//metodo para llenar el maximo de tickets 
        {

            DataTable tabla = cnproductos.Max_ticket();
            
            for (int i = 0; i < tabla.Rows.Count; i++)//busca los datos en la tabla temporal
            {
                //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                textBox7.Text = (tabla.Rows[i]["ticket"] + "");
                

            }
            tabla.Clear();//limpia la tabla


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox2.Text = "";
            textBox3.Text = "";
        }
      
        
        
    }
}

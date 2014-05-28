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
    public  partial class Principal : Form
    {
        public int LUsVenta { get; set; }
       public int LUsProductos { get; set; }
       public int LUsPedidos  { get; set; }
       public int LusCorte { get; set; }
       public int LUsInventario  { get; set; }

       public int LUsProveedores { get; set; }
       public int LUsClientes { get; set; }
       public int LUsEmpleados { get; set; }
       public int LUConfiguracion { get; set; }
       public int LUsPantalla { get; set; }
       public string UsuarioNombre { get; set; }
       int Hprovee = 0;
       int HClientes = 0;
       int HEmpleados = 0;
       int Hconfig = 0;
       int HPantalla = 0;
        
        //corores generales botones y color de letra
        int col1 = 094;
        int col2 = 153;
        int col3 = 033;

        //corores generales fondo
        int col21 = 234;
        int col22 = 255;
        int col23 = 209;

       
        public Principal()
        {
            InitializeComponent();
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            //llama como formulario hijo al formulario venta
            AddFormInPanel(new PvCafeteria.Modelo.Venta());
            
            /*
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            PvCafeteria.Modelo.Venta hijo1 = new PvCafeteria.Modelo.Venta();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
             * */
        }
        //metodo para para crear formularios hijos en el panelContenedor
        private void AddFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void menu2_Click(object sender, EventArgs e) 
        {
            
            //lama como formulario hijo al formulario nProducto 
            AddFormInPanel(new PvCafeteria.Modelo.nProducto());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Comprobar_privilegios();
            //iniciar timer 
            timerPrincipal.Enabled = true;
            timerPrincipal.Interval = 60;
            //color de fondo de principal
            this.BackColor = System.Drawing.Color.FromArgb(col21, col22, col23);
            //color  letra de botones 
            this.menu1.ForeColor = Color.FromArgb(col1, col2, col3);
            this.menu2.ForeColor = Color.FromArgb(col1, col2, col3);
            this.menu3.ForeColor = Color.FromArgb(col1, col2, col3);
            this.menu4.ForeColor = Color.FromArgb(col1, col2, col3);
            this.menu5.ForeColor = Color.FromArgb(col1, col2, col3);
            this.menu6.ForeColor = Color.FromArgb(col1, col2, col3);
            this.btnsalir.ForeColor = Color.FromArgb(col1, col2, col3);
            this.btnayuda.ForeColor = Color.FromArgb(col1, col2, col3);
            //color de groupbox de datos
            this.gboxDatos.ForeColor = Color.FromArgb(col1, col2, col3);
            label2.Text = UsuarioNombre;
        }

        private void menu6_Click(object sender, EventArgs e)
        {
            PvCafeteria.Modelo.Herramientas cnherra = new PvCafeteria.Modelo.Herramientas();
            cnherra.HUsProveedores = Hprovee;
            cnherra.HUsClientes = HClientes;
            cnherra.HUsEmpleados = HEmpleados;
            cnherra.HUConfiguracion = Hconfig;
            cnherra.HUsPantalla = HPantalla;
            //lama como formulario hijo al formulario Herramientas
            AddFormInPanel(cnherra);
            
            //MessageBox.Show("HerraBoton"+Hprovee.ToString());
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            //llama como formulario hijo al formulario Pedidos en el panel conetenedor panelPedidos
            AddFormInPanel(new PvCafeteria.Modelo.Pedidos());
        }

        private void menu4_Click(object sender, EventArgs e)
        {
            //llama como formulario hijo al formulario Corte en el panel conetenedor panelPedidos
            AddFormInPanel(new PvCafeteria.Modelo.Corte());
        }

        private void lbHora_Click(object sender, EventArgs e)
        {
            
        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToShortTimeString();
            lbfecha.Text = DateTime.Now.ToShortDateString();
        }
        public void Comprobar_privilegios()
        {
            
            //Venta
            if (LUsVenta == 0)
            {
                menu1.Enabled = false;
            }
            else { menu1.Enabled = true; }
            //Productos
            if (LUsProductos == 0)
            {
                menu2.Enabled = false;
            }
            else { menu2.Enabled = true; }
            //Pedidos
            if (LUsPedidos == 0)
            {
                menu3.Enabled = false;
            }
            else { menu3.Enabled = true; }
            //Corte
            if (LusCorte == 0)
            {
                menu4.Enabled = false;
            }
            else { menu4.Enabled = true; }
            //Inventario
            if (LUsInventario == 0)
            {
                menu5.Enabled = false;
            }
            else { menu5.Enabled = true; }
            //Porveedores
            if (LUsProveedores == 0)
            {
                Hprovee = 0;
            }
            else { Hprovee = 1; }
            //Clientes
            if (LUsClientes == 0)
            {
                HClientes = 0;
            }
            else { HClientes = 1; }
            //Empleados
            if (LUsEmpleados == 0)
            {
                HEmpleados = 0;
            }
            else { HEmpleados = 1; }
            //Config
            if (LUConfiguracion == 0)
            {
                Hconfig = 0;
            }
            else { Hconfig = 1; }
            //Pantalla2
            if (LUsPantalla == 0)
            {
                HPantalla = 0;
            }
            else { HPantalla = 1; }
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

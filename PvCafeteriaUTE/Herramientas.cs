using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PvCafeteria.Negocios;

namespace PvCafeteria.Modelo
{
    public partial class Herramientas : Form
    {
        //corores generales botones y color de letra
        int col1 = 094;
        int col2 = 153;
        int col3 = 033;

        //corores generales fondo
        int col21 = 234;
        int col22 = 255;
        int col23 = 209;

        public int HUsProveedores { get; set; }
        public int HUsClientes { get; set; }
        public int HUsEmpleados { get; set; }
        public int HUConfiguracion { get; set; }
        public int HUsPantalla { get; set; }
        
        //creacion de objeto de la clase LoginN
        Negocios.LoginN clogin = new Negocios.LoginN();

        
        public Herramientas()
        {
            InitializeComponent();
            
        }

        private void AddFormInPanel(object formHijo)
        {
            if (this.panelherra.Controls.Count > 0)
                this.panelherra.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelherra.Controls.Add(fh);
            this.panelherra.Tag = fh;
            fh.Show();
        }
        private void Herramientas_Load(object sender, EventArgs e)
        {
            Comprobar_priviHerra();
            //color de fonfo 
            this.BackColor = System.Drawing.Color.FromArgb(col21, col22, col23);
            //color de las letras
            ForeColor = Color.FromArgb(col1, col2, col3);
           
            
        }

        private void btnmod8_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new PvCafeteria.Modelo.Empleados());
        }

        private void btnmod7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnmod6_Click(object sender, EventArgs e)
        {
            //crea un formulario hijo del formulario panelherra
            AddFormInPanel(new PvCafeteria.Modelo.Proveedor());
        }

        private void btnmod9_Click(object sender, EventArgs e)
        {
           
        }
        private void Comprobar_priviHerra()
        {
          //  MessageBox.Show(HUsProveedores.ToString());
            //Porveedores
            if (HUsProveedores == 0)
            {
                btnmod6.Enabled = false;
            }
            else { btnmod6.Enabled = true; }
            //Clientes
            if (HUsClientes == 0)
            {
                btnmod7.Enabled = false;
            }
            else { btnmod7.Enabled = true; }
            //Empleados
            if (HUsEmpleados == 0)
            {
                btnmod8.Enabled = false;
            }
            else { btnmod8.Enabled = true; }
            //Config
            if (HUConfiguracion == 0)
            {
                btnmod9.Enabled = false;
            }
            else { btnmod9.Enabled = true; }
            //Pantalla2
            if (HUsPantalla == 0)
            {
                btnmod10.Enabled = false;
            }
            else { btnmod10.Enabled = true; }
        
        }
        
    }
}

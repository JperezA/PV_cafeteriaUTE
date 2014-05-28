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
    public partial class nProducto : Form
    {
        public nProducto()
        {
            InitializeComponent();
        }
        //metodo para crear formularios hijose
        private void AddFormInPanel(object formHijo)
        {
            if (this.panelPro.Controls.Count > 0)
                this.panelPro.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelPro.Controls.Add(fh);
            this.panelPro.Tag = fh;
            fh.Show();
        }

        //Boton de Nuevo al hacer click en ella
        private void btnNproducto_Click(object sender, EventArgs e)
        {
            ///Agrega el estado 
            Productos pro = new Productos();
            pro.ActividadahacerProductos = "Agregar";

            //crea un formulario hijo del formulario nproveedor
            AddFormInPanel(pro);
        }
    }
}

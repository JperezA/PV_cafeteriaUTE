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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }
        //metodo para crear formularios hijos
        private void AddFormInPanel(object formHijo)
        {
            if (this.panelPedidos.Controls.Count > 0)
                this.panelPedidos.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelPedidos.Controls.Add(fh);
            this.panelPedidos.Tag = fh;
            fh.Show();
        }
        private void btnMpedido_Click(object sender, EventArgs e)
        {
            //llama al como formulario hijo al formulario nPedidos para que se muestre en el Panel conenedor panelPedidos
            AddFormInPanel(new PvCafeteria.Modelo.nPedidos());

        }
    }
}

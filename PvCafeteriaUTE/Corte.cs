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
    public partial class Corte : Form
    {
        public Corte()
        {
            InitializeComponent();
        }
        //metodo para crear formularios hijos
        private void AddFormInPanel(object formHijo)
        {
            if (this.panelCorte.Controls.Count > 0)
                this.panelCorte.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelCorte.Controls.Add(fh);
            this.panelCorte.Tag = fh;
            fh.Show();
        }
        private void btnRcorte_Click(object sender, EventArgs e)
        {
            //llama al como formulario hijo al formulario nCorte para que se muestre en el Panel conenedor panelCorte
            AddFormInPanel(new PvCafeteria.Modelo.nCorte());
        }
    }
}

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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        //metodo para craer formulario hijos en el panel contendor llamado panelCon
        private void AddFormInPanel(object formHijo)
        {
            if (this.panelCon.Controls.Count > 0)
                this.panelCon.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelCon.Controls.Add(fh);
            this.panelCon.Tag = fh;
            fh.Show();
        }

        private void btnNuevoEmpl_Click(object sender, EventArgs e)
        {
            
            //crea un formulario hijo del formulario nEmpleado
            nEmpleado emple = new nEmpleado();
            emple.ActividadahacerEmpleados = "Agregar";
           
            AddFormInPanel(emple);
            
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnMempl_Click(object sender, EventArgs e)
        {
            //crea un formulario hijo del formulario nEmpleado
            nEmpleado emple = new nEmpleado();
            emple.ActividadahacerEmpleados = "Modificar";

            AddFormInPanel(emple);
        }

        private void btnEempl_Click(object sender, EventArgs e)
        {
            //crea un formulario hijo del formulario nEmpleado
            nEmpleado emple = new nEmpleado();
            emple.ActividadahacerEmpleados = "Eliminar";

            AddFormInPanel(emple);
        }

        private void btnRempl_Click(object sender, EventArgs e)
        {//crea un formulario hijo del formulario nEmpleado
            nEmpleado emple = new nEmpleado();
            emple.ActividadahacerEmpleados = "Reporte";

            AddFormInPanel(emple);

        }
    }
}

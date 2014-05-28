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
    public partial class Proveedor : Form
    {
        //creacion de objeto de la clase LoginN
        Negocios.Nproveedor cnproveedor = new Negocios.Nproveedor();
        Modelo.nProveedor nprovee = new Modelo.nProveedor();
        public string EstadobotonProveedor;
     

        public Proveedor()
        {
            InitializeComponent();
        }


        //metodo para craer formulario hijos en el panel contendor llamado paneCproveedor
        public  void AddFormInPanel(object formHijo)
        {
            if (this.paneCproveedor.Controls.Count > 0)
                this.paneCproveedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.paneCproveedor.Controls.Add(fh);
            this.paneCproveedor.Tag = fh;
            fh.Show();
        }//panel 

        
      
        private void Proveedor_Load(object sender, EventArgs e)
        {
           
        }
        //boton para abrir la ventana agregar nuevo proveedor
       private void btnNproveedor_Click(object sender, EventArgs e)
        {
           //Agrega el estado 
             nProveedor pro = new nProveedor();
            pro.Actividadahacer = "Agregar"; 
            
            //crea un formulario hijo del formulario nproveedor
            AddFormInPanel(pro);
            paneCproveedor.Visible = true;
            
         
        }//agregar
       
        //boton para abrir la ventana Modificar nuevo proveedor
        private void btnMproveedor_Click(object sender, EventArgs e)
       {
           nProveedor pro = new nProveedor();
           pro.Actividadahacer = "Modificar";
           //crea un formulario hijo del formulario nproveedor
           AddFormInPanel(pro);
           paneCproveedor.Visible = true;
                          
        }//modificar

        private void btnRproveedor_Click(object sender, EventArgs e)
        {
            nProveedor pro = new nProveedor();
            pro.Actividadahacer = "Reporte";
            //crea un formulario hijo del formulario nproveedor
            AddFormInPanel(pro);
            paneCproveedor.Visible = true;
            
        }

        private void btnEproveedor_Click(object sender, EventArgs e)
        {
            //Agrega el estado 
            
            nProveedor pro = new nProveedor();
            pro.Actividadahacer = "Eliminar";
            //crea un formulario hijo del formulario nproveedor
            AddFormInPanel(pro);
            paneCproveedor.Visible = true;
            
        }
         

    }
}

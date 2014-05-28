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

namespace PvCafeteriaUTE
{
    
   
    public partial class Login : Form
    {
        //varaiables para permisos del sistema

       



         
        //corores generales botones y color de letra
        int col1 =094;
        int col2 = 153;
        int col3 = 033;

        //corores generales fondo
        int col21 = 234;
        int col22 = 255;
        int col23 = 209;

        

        LoginN cnlogin = new LoginN();

        //creacion de una insatacia del formulario principal
        PvCafeteria.Modelo.Principal frmPrincipal = new PvCafeteria.Modelo.Principal();
     
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //color de fonfo 
            this.BackColor = System.Drawing.Color.FromArgb(col21,col22,col23);
            
            //color fonfo  de los bones 
            this.btnEntrar.BackColor = Color.FromArgb(col1,col2,col3);
            this.btncancelar.BackColor = Color.FromArgb(col1, col2, col3);
            //color letra grooup box
            this.gboxlogin.ForeColor = Color.FromArgb(col1, col2, col3);
            //color letra boton
            this.btnEntrar.ForeColor = Color.FromArgb(col21,col22,col23);
            this.btncancelar.ForeColor = Color.FromArgb(col21, col22, col23);
            //imagen de los botones
            this.btnEntrar.Image = PvCafeteria.Modelo.Properties.Resources.imgentrar1;
            this.btncancelar.Image = PvCafeteria.Modelo.Properties.Resources.cancelar1;
            //color de las letras de lso texboxs
            this.txtbusuario.ForeColor = Color.FromArgb(col1, col2, col3);
            this.txtbcontrasena.ForeColor = Color.FromArgb(col1, col2, col3);
            //fondo de las imagenes de usuario y contraseña
            this.imgpass.BackColor = Color.FromArgb(col1, col2, col3);
            this.imguser.BackColor = Color.FromArgb(col1, col2, col3);}

            
            
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //boton de login
        private void btnEntrar_Click(object sender, EventArgs e)
        {
           //llama al formularioprincipal
            comprobar_uss_passs();
            
         }

        private void comprobar_uss_passs()
        {
            cnlogin.Log_usuario = txtbusuario.Text;
            cnlogin.Log_pass = txtbcontrasena.Text;
           
            DataSet Tabla = new DataSet();

            try
            {
                Tabla = cnlogin.Buscar_usuario_pass();
               
                    if (Tabla.Tables[0].Rows.Count > 0)
                {
                    DataRow campo = Tabla.Tables[0].Rows[0];
                   // string usuario;
                    //usuario = campo["U_name"].ToString() + " " + campo["U_pass"].ToString();
                    frmPrincipal.LUsVenta = Convert.ToInt16(campo["UsVenta"]);
                    frmPrincipal.LUsProductos = Convert.ToInt16(campo["UsProductos"]);
                    frmPrincipal.LUsPedidos = Convert.ToInt16(campo["UsPedidos"]);
                    frmPrincipal.LusCorte = Convert.ToInt16(campo["UsCorte"]);
                    frmPrincipal.LUsInventario = Convert.ToInt16(campo["UsInventario"]);
                    frmPrincipal.LUsProveedores = Convert.ToInt16(campo["UsProveedores"]);
                    frmPrincipal.LUsClientes = Convert.ToInt16(campo["UsClientes"]);
                    frmPrincipal.LUsEmpleados = Convert.ToInt16(campo["UsEmpleados"]);
                    frmPrincipal.LUConfiguracion = Convert.ToInt16(campo["UsConfiguracion"]);
                    frmPrincipal.LUsPantalla = Convert.ToInt16(campo["UsPantalla"]);
                  
                   // MessageBox.Show(usuario);
                    Buscarnombre_uss();
                    this.Hide();
                    frmPrincipal.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("El usuario y/o contraseña no existen o estan incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Tabla.Clear();
        
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Buscarnombre_uss()

        {
            DataSet Tabla = new DataSet();
            cnlogin.Log_usuario = txtbusuario.Text;
            try
            {
                Tabla = cnlogin.Buscar_usuario_Nombre();

                if (Tabla.Tables[0].Rows.Count > 0)
                {
                    DataRow campo = Tabla.Tables[0].Rows[0];
                    string usuario;
                    usuario = campo["Em_nombre"].ToString() + " " + campo["Em_apellido"].ToString();
                    frmPrincipal.UsuarioNombre = usuario;
                }
                Tabla.Clear();
            }
            catch 
            {  }
        }
    }
}

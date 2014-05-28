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
using System.Text.RegularExpressions;//  uso para comprobacion de correo


namespace PvCafeteria.Modelo
{
    public partial class nProveedor : Form
    {
        //DATASET
        Negocios.ReporteDataset Reporte;
        DataTable TablaR;
        //corores generales botones y color de letra
        int col1 = 094;
        int col2 = 153;
        int col3 = 033;

        //corores generales fondo
        int col21 = 234;
        int col22 = 255;
        int col23 = 209;
        //creacion de objeto de la clase LoginN
        Negocios.Nproveedor cnproveedor = new Negocios.Nproveedor();//objeto de Nproveedor en consola

        //variable para guardar los id. 

     string IDPRO;

        public string Actividadahacer;
        

        
        public nProveedor()
        {
            InitializeComponent();
            
        }
      
           
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.EmpresaproveedorG = textBox1.Text;
        }

        //boton guardar 
        private void btnGproveedor_Click(object sender, EventArgs e)
        {
            //verificación
            validar(this);

            if (vacios == false)
            {
                switch (Actividadahacer)
                    {
                        case "Agregar":
                            //guarda los datos
                            if (ValidarID_PR_NOM(textBox1.Text, textBox2.Text) == true)
                            {
                                cnproveedor.agregarProveedor();
                                textBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";
                                textBox6.Text = "";
                                textBox7.Text = "";
                                textBox8.Text = "";
                                textBox9.Text = "";
                                richTextBox1.Text = "";
                               // MessageBox.Show("Agregado");
                            }

                            break;
                        case "Modificar":
                          // MessageBox.Show("Modificar");
                           cnproveedor.modificarProveedor();
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";
                            textBox8.Text = "";
                            textBox9.Text = "";
                            richTextBox1.Text = "";
                           // MessageBox.Show("Actualizado");
                            break;
                        case "Eliminar":
                          // MessageBox.Show("Eliminar");
                           cnproveedor.eliminarProveedor();
                           textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";
                            textBox8.Text = "";
                            textBox9.Text = "";
                            richTextBox1.Text = "";
                           // MessageBox.Show("Eliminado");
                            break;
                        default:
                            MessageBox.Show("Otro");
                            break;
            }
            

                //guarda lo capturado  llamando al metetodo agreagar proveedor
            }//se cierra la comprobacion de campos vacios

           
        }//btnGuardar

        //boton cancelar 
        private void btnCproveedor_Click(object sender, EventArgs e)
        {
            //-----guarda lo capturado  llamando al metetodo agreagar proveedor
            //-----cnproveedor.eliminarProveedor();
            //limpia todo los campos 
           textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            richTextBox1.Text = "";
           
           
           
        }//btncancelar

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.NomEmpresaG = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.ApeEmpresaG = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.DirEmpresaG = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.CuidadEmpresaG = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.EstadoEmpresaG = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {


            cnproveedor.CpEmpresaG = textBox7.Text; 
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.TelEmpresaG = textBox8.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.CorreoEmpresaG = textBox9.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.DescEmpresaG = richTextBox1.Text;
        
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
                if (Char.IsDigit(e.KeyChar)) 
                { 
                  e.Handled = false; 
                } 
                else 
                  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                  { 
                    e.Handled = false; 
                  } 
                  else 
                  { 
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true; 
                  } 
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    } 
        }

        private void nProveedor_Load(object sender, EventArgs e)
        {
            //Activador();
            estadoactividadprovee();
            Negocios.Nproveedor cnproveedor2 = new Negocios.Nproveedor();
            ModNombreProveedor.AutoCompleteCustomSource = cnproveedor2.Autocomplete();
            ModNombreProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ModNombreProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }//evento load

        //validacion de correo
        public static bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }// se cierra  comprobacion de correo

        //comprobacion de campos:
        public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio. 
        public bool vacios;
        
        private void validar(Form nProveedor)
        {
            vacios = false;
            foreach (Control oControls in nProveedor.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio. 
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable. 
                    vacios = true;
                }
            }
            if (vacio == true) MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje. 
            vacio = false; // Devolvemos el valor original a nuestra variable. 
        }

       

        private void actualizardatos() {

            DataTable tabla = cnproveedor.Modificarproveedor1();

            if (tabla.Rows.Count <= 0)
            { MessageBox.Show("Vuelva a intentar con otros valores"); }
            else
            {
               
                panel1.Visible = false;
                for (int i = 0; i < tabla.Rows.Count; i++)//busca los datos en la tabla temporal
                {
                    //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "");//busqueda
                    IDPRO = (tabla.Rows[i]["idProveedores"] + "");
                    textBox1.Text = (Convert.ToString(tabla.Rows[i]["Provee_emprem"] + ""));
                    // MessageBox.Show(textBox1.Text);
                    textBox2.Text = (tabla.Rows[i]["provee_nombre"] + "");
                    // MessageBox.Show(textBox2.Text);
                    textBox3.Text = (tabla.Rows[i]["Provee_apellido"] + "");
                    textBox4.Text = (tabla.Rows[i]["Provee_direccion"] + "");
                    textBox5.Text = (tabla.Rows[i]["Provee_ciudad"] + "");
                    textBox6.Text = (tabla.Rows[i]["Provee_estado"] + "");
                    textBox7.Text = (tabla.Rows[i]["Provee_cp"] + "");
                    textBox8.Text = (tabla.Rows[i]["Provee_tel"] + "");
                    textBox9.Text = (tabla.Rows[i]["Provee_correo"] + "");
                    richTextBox1.Text = (tabla.Rows[i]["Provee_descrip"] + "");
                
                }
                tabla.Clear();
            }
        }//lenar tabla

        private void estadoactividadprovee()
        {
            switch(Actividadahacer)
            {
            case "Agregar":
                    lbProveedor.Text = "Agregar Nuevo Proveedor";
                    btnGproveedor.Text = "Guardar";
                 break;
             case "Modificar":
                 //MessageBox.Show("Modificar");
                 lbProveedor.Text = "Modificar  Proveedor";
                 label11.Text = "Buscar por (Código ó Nombre) del proveedor a Modificar";
                 btnGproveedor.Text = "Modificar";
                 panel1.Visible = true;
                  break;
             case "Eliminar":
                 // MessageBox.Show("Eliminar");
                  lbProveedor.Text = "Eliminar  Proveedor";
                  label11.Text = "Buscar  por (Código  ó Nombre) del proveedor a Eliminar";
                  btnGproveedor.Text = "Eliminar";
                  panel1.Visible = true;
                  
                  break;
             case "Reporte":
                  // MessageBox.Show("Eliminar");
                  radioButton1.Checked = true;
                  label14.Text = "Reporte de proveedores";
                  panel1.Visible = true;
                  panel2.Visible = true;
                  dataGridView1.AutoGenerateColumns = false;
                  dataGridView1.RowHeadersVisible = false;
                  llenartabla();
                  
                  
               
                  break;
              default:
                  MessageBox.Show("Otro");
                    break;
            
            }
        
        
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
                actualizardatos();
                cnproveedor.idpro1 = IDPRO;
           
               
        }

        private void Mcod_proveedor_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.TipoBuscadoIDNOMBRE ="Provee_emprem";
            cnproveedor.BusProveeNom = Mcod_proveedor.Text;
        }

        private void ModNombreProveedor_TextChanged(object sender, EventArgs e)
        {
            cnproveedor.TipoBuscadoIDNOMBRE = "provee_nombre";
            cnproveedor.BusProveeNom = ModNombreProveedor.Text;
        }
        private void llenartabla() {

            TablaR = cnproveedor.Consultaall();
            Reporte = new ReporteDataset();
            Reporte.Tables.Add(TablaR);
            dataGridView1.DataSource = Reporte.Tables[0];
           
            label17.Text = this.dataGridView1.Rows.Count.ToString();
             //color de fonfo 
            this.BackColor = System.Drawing.Color.FromArgb(col21, col22, col23);
            //color de las letras
            ForeColor = Color.FromArgb(col1, col2, col3);
           
            //estilo de la tabla 
            this.dataGridView1.BackgroundColor = Color.FromArgb(col21, col22, col23);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(col1, col2, col3);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(col21, col22, col23);
            this.dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            
           
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                { Reporte.Tables[0].DefaultView.RowFilter = ("provee_nombre like '" + textBox10.Text + "%'"); }
                else if (radioButton2.Checked) { Reporte.Tables[0].DefaultView.RowFilter = ("Provee_emprem like '" + textBox10.Text + "%'"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente con otros Valores");
            }
        }

        private  bool ValidarID_PR_NOM(string ID_PROVE,string NOM_PROVE) //validar campo ID_proveedor y Campo_Nombre que no se repitan
        {
            bool Correcto = false;
            bool ID_correcto = true;
            bool NOm_correcto = true;
                  
            try
            {
                DataTable tablaN = cnproveedor.Datos();
                DataTable tablaC = cnproveedor.Datos_Codigo();
               
                                for (int i = 0; i < tablaN.Rows.Count; i++)//busca los datos en la tabla temporal
                                {
                                    //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                                    if (NOM_PROVE == (tablaN.Rows[i]["provee_nombre"] + ""))
                                    {
                                        MessageBox.Show("Intento con otros valores en el Campo Nombre Proveedor");
                                        NOm_correcto = false;
                                    }
                                                        
                                  }//for
                  tablaN.Clear();

                  for (int i = 0; i < tablaC.Rows.Count; i++)//busca los datos en la tabla temporal
                  {
                      //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                      if (ID_PROVE == (tablaC.Rows[i]["Provee_emprem"] + ""))
                      {
                          MessageBox.Show("Intento con otros valores en el Campo Código del Proveedor");
                          ID_correcto = false;
                      }
                      

                  }//for
                  tablaC.Clear();

                  if ((ID_correcto == true )&&( NOm_correcto == true))
                  {
                      Correcto = true;
                  }
                  else { Correcto = false; }
            }
            catch
            {
                Correcto = false;
            }
            return Correcto;
        }
       

    }
}

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
using System.Text.RegularExpressions;
namespace PvCafeteria.Modelo
{
    public partial class nEmpleado : Form
    {
        //DATASET
        Negocios.ReporteDataset Reporte;
        DataTable TablaR;
        //boolean comprueba si se preciona el campo usurio
        Boolean campousurioactivo = false;

        //corores generales botones y color de letra
        int col1 = 094;
        int col2 = 153;
        int col3 = 033;

        //corores generales fondo
        int col21 = 234;
        int col22 = 255;
        int col23 = 209;
        //creacion de objeto de la clase LoginN
        Negocios.Nempleado cnempleado = new Negocios.Nempleado();//objeto de Nproveedor en consola

        //Checkbox variables
        private int UsVentas;
        private int Usproductos;
        private int UsPedidos;
        private int UsCorte;
        private int UsInventario;
        private int UsProveedores;
        private int UsClientes;
        private int UsEmpleados;
        private int UsConfiguracion;
        private int UsPantalla2;
        private int Compro_Privilegio = 0;
        //variable para guardar los id. 
       
        Int32 IDEmpelado = 0;

        public string ActividadahacerEmpleados;
        

        public nEmpleado()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void nEmpleado_Load(object sender, EventArgs e)
        {
            estadoactividadEmpleado();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cnempleado.NomEmpleadoG = textBox1.Text;//envia los datos al la capa negocios
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cnempleado.ApeEmpleadoG = textBox2.Text; //envia los datos al la capa negocios
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cnempleado.DirEmpleadoG = textBox3.Text; //envia los datos al la capa negocios
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            cnempleado.CuidadEmpleadoG = textBox4.Text; //envia los datos al la capa negocios
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            cnempleado.EstadoEmpleadoG = textBox5.Text; //envia los datos al la capa negocios
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            cnempleado.CpEmpleadoG = textBox6.Text; //envia los datos al la capa negocios
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cnempleado.TelEmpleadoG = maskedTextBox2.Text; //envia los datos al la capa negocios
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cnempleado.CelEmpleadoG = maskedTextBox3.Text;  //envia los datos al la capa negocios
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            cnempleado.CorreoEmpleadoG = textBox9.Text;  //envia los datos al la capa negocios
        }
               
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

                        
              //envia los datos al la capa negocios
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            cnempleado.DescEmpleadoG = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (button1.Text == "Privilegios")
            { button1.Text = "Regresar";
            btnGempl.Visible = false;
            btnCempl.Visible = false;
            }
            else { button1.Text = "Privilegios";
            btnGempl.Visible = true;
            btnCempl.Visible = true;
            }
           
            if (this.panel1.Visible == false)
            { this.panel1.Visible = true; }
            else
            { this.panel1.Visible = false; }
            //color de las imagenes decontraseña y usuario
            this.imgpass.BackColor = Color.FromArgb(col1, col2, col3);
            this.imguser.BackColor = Color.FromArgb(col1, col2, col3);
        }

        public void validar_checkbox()
        {
            //checkbox1 ---Ventas
            if (checkBox1.Checked) { UsVentas = 1; }
            else { UsVentas = 0; }

            //checkbox2 ---Productos
            if (checkBox2.Checked) { Usproductos = 1; }
            else { Usproductos = 0; }

            //checkbox3 ---Pedidos
            if (checkBox3.Checked) { UsPedidos = 1; }
            else { UsPedidos = 0; }

            //checkbox4 ---Corte
            if (checkBox4.Checked) { UsCorte = 1; }
            else { UsCorte = 0; }

            //checkbox5 ---Inventario
            if (checkBox5.Checked) { UsInventario = 1; }
            else { UsInventario = 0; }

            //checkbox6 ---Proveedores
            if (checkBox6.Checked) { UsProveedores = 1; }
            else { UsProveedores = 0; }

            //checkbox7 ---Clientes
            if (checkBox7.Checked) { UsClientes = 1; }
            else { UsClientes = 0; }

            //checkBox8 ---Empleados
            if (checkBox8.Checked) { UsEmpleados = 1; }
            else { UsEmpleados = 0; }

            //checkBox9 ---Configuracion
            if (checkBox9.Checked) { UsConfiguracion = 1; }
            else { UsConfiguracion = 0; }

            //checkBox10 ---Ventas
            if (checkBox10.Checked) { UsPantalla2 = 1; }
            else { UsPantalla2 = 0; }
        } //valida que los checkbox

        public void llenar_richtext()//llenar richbox
        {
            
            string richbox_texto = "";

            if (UsVentas == 1) { cnempleado.UsVentasG = 1; richbox_texto = "Ventas" + "\r\n"; }
            else { cnempleado.UsVentasG = 0; }

            if (Usproductos == 1) { cnempleado.UsproductosG = 1; richbox_texto = richbox_texto + "Productos" + "\r\n"; }
            else { cnempleado.UsproductosG = 0; }

            if (UsPedidos == 1) { cnempleado.UsPedidosG = 1; richbox_texto = richbox_texto + "Pedidos" + "\r\n"; }
            else { cnempleado.UsPedidosG = 0; }

            if (UsCorte == 1) { cnempleado.UsCorteG = 1; richbox_texto = richbox_texto + "Corte" + "\r\n"; }
            else { cnempleado.UsCorteG = 0; }

            if (UsInventario == 1) { cnempleado.UsInventarioG = 1; richbox_texto = richbox_texto + "Inventario" + "\r\n"; }
            else { cnempleado.UsInventarioG = 0; }

            if (UsProveedores == 1) { cnempleado.UsProveedoresG = 1; richbox_texto = richbox_texto + "Proveedores" + "\r\n"; }
            else { cnempleado.UsProveedoresG = 0; }

            if (UsClientes == 1) { cnempleado.UsClientesG = 1; richbox_texto = richbox_texto + "Clientes" + "\r\n"; }
            else { cnempleado.UsClientesG = 0; }

            if (UsEmpleados == 1) { cnempleado.UsEmpleadosG = 1; richbox_texto = richbox_texto + "Empleados" + "\r\n"; }
            else { cnempleado.UsEmpleadosG = 0; }

            if (UsConfiguracion == 1) { cnempleado.UsConfiguracionG = 1; richbox_texto = richbox_texto + "Configuración" + "\r\n"; }
            else { cnempleado.UsConfiguracionG = 0; }

            if (UsPantalla2 == 1) { cnempleado.UsPantalla2G = 1; richbox_texto = richbox_texto + "Pantalla 2" + "\r\n"; }
            else { cnempleado.UsPantalla2G = 0; }

            richTextBox3.Text = richbox_texto;

        }

        private void button2_Click(object sender, EventArgs e)//boton agregar en privilegios
        {
            cnempleado.idempleadoG = label16.Text;
            validar_checkbox();
            llenar_richtext();
            switch(ActividadahacerEmpleados)
            { 
                case("Agregar"):  
                Comprobar_U_name();
                break;
                case ("Modificar"):
                if (campousurioactivo == true)
                {
                   // MessageBox.Show("true");
                    Comprobar_U_name();
                }
                else {
                    //MessageBox.Show("False");
                    cnempleado.usernameEmpleadoG = textBox7.Text;
                    cnempleado.modificarUserEmple();
                
                }
                break;
                default:
                break;
            }
            
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
          //  campousurioactivo = true;
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            ocultarpassword();
            
            cnempleado.userpassEmpleadoG = textBox8.Text;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        

        public void ocultarpassword()
        {
            if (checkBox11.Checked == false)
            { textBox8.PasswordChar = '*'; }
            else { textBox8.PasswordChar = char.MinValue; }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            ocultarpassword();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            cnempleado.UsDescripcionG = textBox10.Text;
        }

        private void Id_Empleado()//
        {
            DataTable tabla = cnempleado.ID_Empleados();

            if (tabla.Rows.Count <= 0)
            { MessageBox.Show("Vuelva a intentar con otros valores"); }
            else
            {

               
                for (int i = 0; i < tabla.Rows.Count; i++)//busca los datos en la tabla temporal
                {
                    //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                    IDEmpelado =Convert.ToInt32(tabla.Rows[i]["idEmpleados"] + "");
                   

                }
                IDEmpelado = IDEmpelado + 1;
                tabla.Clear();
            }
        }

        private void Comprobar_U_name()
        {
          
      
          string Existe_user = "";
           if (textBox7.Text == "Otro Valor" || textBox7.Text == "") { MessageBox.Show("Intento con otros valores en el Campo Usuario"); Existe_user = "si"; }
            
                   else
                           {
                                   DataTable tabla = cnempleado.Consulta_U_name();
                                  for (int i = 0; i < tabla.Rows.Count; i++)//busca los datos en la tabla temporal
                                          {
                                                //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                                             if (textBox7.Text == (tabla.Rows[i]["U_name"] + ""))
                                                {
                                                    MessageBox.Show("Intento con otros valores en el Campo Usuario");
                                                    textBox7.Text = "Otro Valor";
                                                    Existe_user = "si";
                                                }
                    
                                            }//for

                                            tabla.Clear();
                                        }//if1
                                        if (Existe_user != "si")
                                           {  switch (ActividadahacerEmpleados)
                                             {
                                                case "Agregar":
                                               cnempleado.usernameEmpleadoG = textBox7.Text;
                                               cnempleado.AgregarUser();
                                               Compro_Privilegio = 1;
                                               break;
                                                case "Modificar":
                                                cnempleado.usernameEmpleadoG = textBox7.Text;
                                                cnempleado.modificarUserEmple();
                                               break;
                                                default:
                                               MessageBox.Show("Otro");
                                               break;
                                             }
                        
                         }
                                       
            
         }

        private void btnCempl_Click(object sender, EventArgs e)
        {
           
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
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            textBox10.Text = "";
            richTextBox3.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            cnempleado.idempleadoG = label16.Text;
            //cnempleado.Eliminar_U_name();
        }

        private void btnGempl_Click(object sender, EventArgs e)
        {
            
            
            cnempleado.FechainicioEmpleadoG = maskedTextBox1.Text;
            cnempleado.CelEmpleadoG = maskedTextBox3.Text;
            cnempleado.TelEmpleadoG = maskedTextBox2.Text;
           //envia los datos al la capa negocios
           
                validar(this);

                if (vacios == false)
                {
                    switch (ActividadahacerEmpleados)
                    {
                        case "Agregar":
                            //guarda los datos
                            if (Validarfecha(maskedTextBox1.Text) == true)//valida campo fecha
                             {
                                  cnempleado.FechainicioEmpleadoG = maskedTextBox1.Text;

                                         if (Compro_Privilegio == 1)//valida que este agregado el user
                                        //verificación
                                         {
                                        cnempleado.agregarEmpleado();
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
                                        maskedTextBox1.Text = "";
                                        maskedTextBox2.Text = "";
                                        maskedTextBox3.Text = "";
                                        textBox10.Text = "";
                                        richTextBox3.Text = "";
                                        checkBox1.Checked = false;
                                        checkBox2.Checked = false;
                                        checkBox3.Checked = false;
                                        checkBox4.Checked = false;
                                        checkBox5.Checked = false;
                                        checkBox6.Checked = false;
                                        checkBox7.Checked = false;
                                        checkBox8.Checked = false;
                                        checkBox9.Checked = false;
                                        checkBox10.Checked = false;
                                        Compro_Privilegio = 0;
                                        Id_Empleado();
                                        label16.Text =Convert.ToString(IDEmpelado);
                                         }
                                        else { MessageBox.Show("Falta darle Privilegios al Usuario"); }
                             }//if fecha
                            else { MessageBox.Show("El formato de la fecha es AÑO/MES/DIA"); }
                            break;
                        case "Modificar":///boton modificar
                            cnempleado.modificarEmpleado();
                            label16.Text = "";
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
                            maskedTextBox1.Text = "";
                            maskedTextBox2.Text = "";
                            maskedTextBox3.Text = "";
                            textBox10.Text = "";
                            richTextBox3.Text = "";
                            checkBox1.Checked = false;
                            checkBox2.Checked = false;
                            checkBox3.Checked = false;
                            checkBox4.Checked = false;
                            checkBox5.Checked = false;
                            checkBox6.Checked = false;
                            checkBox7.Checked = false;
                            checkBox8.Checked = false;
                            checkBox9.Checked = false;
                            checkBox10.Checked = false;
                            break;
                        case "Eliminar":
                            
                            cnempleado.eliminarEmpleado();
                            cnempleado.Eliminar_U_name();
                            label16.Text = "";
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
                            maskedTextBox1.Text = "";
                            maskedTextBox2.Text = "";
                            maskedTextBox3.Text = "";
                            textBox10.Text = "";
                            richTextBox3.Text = "";
                            checkBox1.Checked = false;
                            checkBox2.Checked = false;
                            checkBox3.Checked = false;
                            checkBox4.Checked = false;
                            checkBox5.Checked = false;
                            checkBox6.Checked = false;
                            checkBox7.Checked = false;
                            checkBox8.Checked = false;
                            checkBox9.Checked = false;
                            checkBox10.Checked = false;
                            MessageBox.Show("Eliminado");
                            break;
                        default:
                            MessageBox.Show("Otro");
                            break;
                    }


                    //guarda lo capturado  llamando al metetodo agreagar proveedor
                }//if casos
            
        }//medoto guardar

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
            
          public void estadoactividadEmpleado()
        {
            switch (ActividadahacerEmpleados)
            {
                case "Agregar":
                     Id_Empleado();
                  label16.Text =Convert.ToString(IDEmpelado);
                   maskedTextBox1.Visible = true;
                    lbNEmple.Text = "Agregar Nuevo  Empleado";
                    btnGempl.Text = "Guardar";
                    break;
                case "Modificar":
                    //MessageBox.Show("Modificar");
                    button2.Text = "Actualizar";
                    label24.Visible = true;
                    lbNEmple.Text = "Modificar  Empleado";
                    label21.Text = "Buscar por (Nombre o Número) del empleado a Modificar";
                    btnGempl.Text = "Modificar";
                    panel2.Visible = true;
                    break;
                case "Eliminar":
                    // MessageBox.Show("Eliminar");
                    lbNEmple.Text = "Eliminar  Empleado";
                    label24.Visible = true;
                    label21.Text = "Buscar  por (Nombre o Número) del empleado a Eliminar";
                    btnGempl.Text = "Eliminar";
                    panel2.Visible = true;

                    break;
                case "Reporte":
                    
                    radioButton4.Checked = true;
                     label28.Text = "Reporte de Empleados";
                      panel4.Visible = true;
                    dataGridView2.AutoGenerateColumns = false;
                    dataGridView2.RowHeadersVisible = false;
                    llenartabla();
                
                // dataGridView1.AutoGenerateColumns = false;
                //llenartabla();
                break;
                default:
                    MessageBox.Show("Otro");
                    break;

            }
        }

          private void button3_Click(object sender, EventArgs e)//buscar modificar o eliminar
          {
              actualizardatos();
          }
          private void actualizardatos()
          {
              DataTable tabla2 = cnempleado.Consulta_users_Emple();//mada a llamar la funcion en capa Negocios
              
                 
              if (tabla2.Rows.Count <= 0)
              { MessageBox.Show("Vuelva a intentar con otros valores"); }
              else
              {
                  if (tabla2.Rows.Count != 0)//comprueba la tabla si tiene datos
                  {

                      for (int i = 0; i < tabla2.Rows.Count; i++)//busca los datos en la tabla temporal
                      {

                          //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                          label16.Text = (tabla2.Rows[i]["idUsers"] + "");
                          textBox7.Text = (tabla2.Rows[i]["U_name"] + "");
                          textBox8.Text = (tabla2.Rows[i]["U_pass"] + "");
                          textBox10.Text = (tabla2.Rows[i]["U_Type"] + "");
                          UsVentas = Convert.ToInt32((tabla2.Rows[i]["UsVenta"]));
                          Usproductos = Convert.ToInt16((tabla2.Rows[i]["UsProductos"]));
                          UsPedidos = Convert.ToInt16((tabla2.Rows[i]["UsPedidos"]));
                          UsCorte = Convert.ToInt16((tabla2.Rows[i]["UsCorte"]));
                          UsInventario = Convert.ToInt16((tabla2.Rows[i]["UsInventario"]));
                          UsProveedores = Convert.ToInt16((tabla2.Rows[i]["UsProveedores"]));
                          UsClientes = Convert.ToInt16((tabla2.Rows[i]["UsClientes"]));
                          UsEmpleados = Convert.ToInt16((tabla2.Rows[i]["UsEmpleados"]));
                          UsConfiguracion = Convert.ToInt16((tabla2.Rows[i]["UsConfiguracion"]));
                          UsPantalla2 = Convert.ToInt16((tabla2.Rows[i]["UsPantalla"]));

                      }
                      if (UsVentas == 1) { checkBox1.Checked = true; }//comprueba si esta activado el privilegio Ventas
                      if (Usproductos == 1) { checkBox2.Checked = true; }
                      if (UsPedidos == 1) { checkBox3.Checked = true; }
                      if (UsCorte == 1) { checkBox4.Checked = true; }
                      if (UsInventario == 1) { checkBox5.Checked = true; }
                      if (UsProveedores == 1) { checkBox6.Checked = true; }
                      if (UsClientes == 1) { checkBox7.Checked = true; }
                      if (UsEmpleados == 1) { checkBox8.Checked = true; }
                      if (UsConfiguracion == 1) { checkBox9.Checked = true; }
                      if (UsPantalla2 == 1) { checkBox10.Checked = true; }
                      llenar_richtext();
                  }
                  tabla2.Clear();//limpia la tabla2

                  cnempleado.idempleadoG = label16.Text;
                  DataTable tabla = cnempleado.ModificarEmpleado1();
                  panel2.Visible = false;
                  for (int i = 0; i < tabla.Rows.Count; i++)//busca los datos en la tabla temporal
                  {
                      //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                      label16.Text = (tabla.Rows[i]["idEmpleados"] + "");
                      textBox1.Text = (tabla.Rows[i]["Em_nombre"] + "");
                      textBox2.Text = (tabla.Rows[i]["Em_apellido"] + "");
                      textBox3.Text = (tabla.Rows[i]["Em_direccion"] + "");
                      textBox4.Text = (tabla.Rows[i]["Em_ciudad"] + "");
                      textBox5.Text = (tabla.Rows[i]["Em_estado"] + "");
                      textBox6.Text = (tabla.Rows[i]["Em_cp"] + "");
                      textBox9.Text = (tabla.Rows[i]["Em_correo"] + "");
                      label24.Text = (tabla.Rows[i]["Em_fecha"] + "");
                      maskedTextBox2.Text = (tabla.Rows[i]["Em_telefono"] + "");
                      maskedTextBox3.Text = (tabla.Rows[i]["Movil"] + "");
                      richTextBox1.Text = (tabla.Rows[i]["Em_observacion"] + "");

                  }
                  tabla.Clear();//limpia la tabla
                 //carga el numero del empleado
                  

                 
              }
          }

          private void textBox11_TextChanged(object sender, EventArgs e)
          {

              cnempleado.TipoBuscadoIDNOMBRE = "U_name";
              cnempleado.BusEMPLEANom = textBox11.Text; //texbox busqueda nombre
             
          }

          private void textBox12_TextChanged(object sender, EventArgs e)
          {
              
              cnempleado.TipoBuscadoIDNOMBRE = "idUsers";
              cnempleado.BusEMPLEANom = textBox12.Text; //texbox busqueda nombre
             
          }

          private void textBox12_KeyPress(object sender, KeyPressEventArgs e)//bloquea letras
          {
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

          private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
          {
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

          private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
          {
              campousurioactivo = true;
          }
          private static bool Validarfecha(string inputDate) //validar fecha
          {
              bool isDate = true;
              try
              {
                  DateTime dateValue;
                  dateValue = DateTime.ParseExact(inputDate, "yyyy/MM/dd", null);
              }
              catch
              {
                  isDate = false;
              }
              return isDate;
          }
          private void llenartabla()//llenar tabla o dataGridView2
          {


              TablaR = cnempleado.Consultatablaempleadosreporte();
              Reporte = new ReporteDataset();
              Reporte.Tables.Add(TablaR);
              dataGridView2.DataSource = Reporte.Tables[0];
              label30.Text = this.dataGridView2.Rows.Count.ToString();
              //color de fonfo 
              this.BackColor = System.Drawing.Color.FromArgb(col21, col22, col23);
              //color de las letras
              ForeColor = Color.FromArgb(col1, col2, col3);

              //estilo de la tabla 
              this.dataGridView2.BackgroundColor = Color.FromArgb(col21, col22, col23);
              dataGridView2.EnableHeadersVisualStyles = false;
              dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(col1, col2, col3);
              dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(col21, col22, col23);
              this.dataGridView2.BorderStyle = BorderStyle.Fixed3D;
              


          }

          private void textBox14_TextChanged(object sender, EventArgs e)
          {
              try
              {
                  if (radioButton4.Checked)
                  { Reporte.Tables[0].DefaultView.RowFilter = ("U_name like '" + textBox14.Text + "%'"); }
                  else if (radioButton3.Checked)
                  { Reporte.Tables[0].DefaultView.RowFilter = " Convert(idUsers,'System.String') like '" + textBox14.Text + "%'"; }//buscar por numero
                  else if (radioButton5.Checked) { Reporte.Tables[0].DefaultView.RowFilter = ("Em_nombre like '" + textBox14.Text + "%'"); }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Intente con otros Valores");
              }
          }
  }
}

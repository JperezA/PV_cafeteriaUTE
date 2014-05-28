using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using PvCafeteria.Datos;
using System.Windows.Forms;
using System.Data;
using System.Collections;



namespace PvCafeteria.Negocios
{
    public class Nproveedor
    {
        

        

        //sql es para guardar las cadenas sql
        string sql;
        //creacion de objeto de la clase Mysql
        PvCafeteria.Datos.Mysql mq = new PvCafeteria.Datos.Mysql("bd_cafeute");
        //objeto de la clase mysqlconnection
        MySqlConnection conexion = new MySqlConnection();

        ///variables para transportar los datos de los campos que contiene el formulario nProveedor
        private string  Empresaproveedor;
        private string NomEmpresa;
        private  string ApeEmpresa;
        private string DirEmpresa;
        private string CuidadEmpresa;
        private string EstadoEmpresa;
        private  string CpEmpresa;
        private  string TelEmpresa;
        private string CorreoEmpresa;
        private string DescEmpresa;
        private string BusProveecod1;
        private string BusProveeNom1;
        private string TipoBuscadoIDNOMBRE1;
        private string idpro;
        
        //metodos para ser llamados desde la otra clase vara llevar las variables 
        public new string EmpresaproveedorG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return Empresaproveedor;
            }
            set
            {
                Empresaproveedor = value;
            }
        }
        public new string NomEmpresaG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return NomEmpresa;
            }
            set
            {
                NomEmpresa = value;
            }
        }
        public new string ApeEmpresaG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return ApeEmpresa;
            }
            set
            {
                ApeEmpresa = value;
            }
        }
        public new string DirEmpresaG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return DirEmpresa;
            }
            set
            {
                DirEmpresa = value;
            }
        }
        public new string CuidadEmpresaG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return CuidadEmpresa;
            }
            set
            {
                CuidadEmpresa = value;
            }
        }
        public new string EstadoEmpresaG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return EstadoEmpresa;
            }
            set
            {
                EstadoEmpresa = value;
            }
        }
        public new string CpEmpresaG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return CpEmpresa;
            }
            set
            {
                CpEmpresa = value;
            }
        }
        public new string TelEmpresaG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return TelEmpresa;
            }
            set
            {
                TelEmpresa = value;
            }
        }
        public new string CorreoEmpresaG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return CorreoEmpresa;
            }
            set
            {
                CorreoEmpresa = value;
            }
        }
        public new string DescEmpresaG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return DescEmpresa;
            }
            set
            {
                DescEmpresa = value;
            }
        }
        public new string BusProveecod  //metodo para ser llamado desde la venta proveedor
        {
            get
            {
                return BusProveecod1;
            }
            set
            {
                BusProveecod1 = value;
            }
        }
        public new string BusProveeNom  //metodo para ser llamado desde la venta proveedor
        {
            get
            {
                return BusProveeNom1;
            }
            set
            {
                BusProveeNom1 = value;
            }
        }
        public new string idpro1  //metodo para duardar id del proveedor
        {
            get
            {
                return idpro;
            }
            set
            {
                idpro = value;
            }
        }

        public new string TipoBuscadoIDNOMBRE  //metodo para ser llamado desde la venta proveedor para poner si buscar por Id o calificacion 
        {
            get
            {
                return TipoBuscadoIDNOMBRE1;
            }
            set
            {
                TipoBuscadoIDNOMBRE1 = value;
            }
        }


        //metodo para agregar provedorres
        public void agregarProveedor()
        {
            if (MessageBox.Show("¿Estas seguro de guardar los datos?", "Guardar",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes) 

            {
                try
                {


                    conexion = mq.conectar();//carga el Mysqlconection 
                   // MessageBox.Show("conectado");
                    sql = "insert into proveedores(Provee_emprem, provee_nombre, Provee_apellido, Provee_direccion, Provee_ciudad,  Provee_estado,  Provee_cp,  Provee_tel,  Provee_correo,  Provee_descrip)";
                    sql = sql + "values('" + Empresaproveedor + "','" + NomEmpresa + "','" + ApeEmpresa + "','" + DirEmpresa + "','" + CuidadEmpresa + "','" + EstadoEmpresa + "'," + CpEmpresa + ",'" + TelEmpresa + "','" + CorreoEmpresa + "','" + DescEmpresa + "')";

                    MySqlCommand adaptador = new MySqlCommand(sql, conexion);

                   // MessageBox.Show(sql);
                    adaptador.ExecuteNonQuery();

                    this.conexion.Close();
                    MessageBox.Show("Agregado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }//se cierra el catch


            }

        } //metodo para consular Proveedores
       

        //metodo para modificar proveedores
        public void modificarProveedor()
        {
            if (MessageBox.Show("¿Estas seguro de Actualizar los datos?", "Actualizar",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        == DialogResult.Yes)
            {
            try
            {
                conexion = mq.conectar();
                sql = "update proveedores set Provee_emprem ='"+Empresaproveedor+"',provee_nombre='" + NomEmpresa + "',Provee_apellido ='" + ApeEmpresa + "', Provee_direccion='" + DirEmpresa + "', Provee_ciudad='" + CuidadEmpresa + "',  Provee_estado ='" + EstadoEmpresa + "',  Provee_cp=" + CpEmpresa + ",  Provee_tel='" + TelEmpresa + "',  Provee_correo='" + CorreoEmpresa + "',  Provee_descrip='" + DescEmpresa + "' where idProveedores="+idpro+"";
                
                MySqlCommand adaptador = new MySqlCommand(sql, conexion);

                adaptador.ExecuteNonQuery();

                this.conexion.Close();
                MessageBox.Show("Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }//se cierra catch

        }//se cierra la comprobaacion 
        }//se cierra el metodo modificarProveedor

        public void eliminarProveedor()
        {
            if (MessageBox.Show("¿Estas seguro de Eliminar los datos?", "Eliminar",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
            {
            try{

                conexion = mq.conectar();
               // MessageBox.Show("conectado");
                sql = "delete from proveedores where idProveedores="+idpro+"";

            MySqlCommand adaptador = new MySqlCommand(sql, conexion);

            adaptador.ExecuteNonQuery();
           MessageBox.Show("Eliminado");
            
                }
             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }//se cierra catch
        }
        }//se cierra el metodo eliminarProveedor

        public DataTable Consultaall()
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "select * from proveedores"; //consulta a la tabla Proveedores


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);
            return dt;

        }

        //metodo para cargar los datos de la bd
        public  DataTable Datos()
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();
                   


            string consulta = "select provee_nombre from proveedores"; //consulta a la tabla nombre


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();
            
            adap.Fill(dt);
            return dt;
            
        }
        public DataTable Datos_Codigo()//consulta puro codigo del proveedor
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "select Provee_emprem from proveedores"; //consulta a la tabla nombre


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);
            return dt;

        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public  AutoCompleteStringCollection Autocomplete()
        {
             DataTable dt =  Datos();
         
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado


              foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["provee_nombre"]));
                  }

              return coleccion;
        }

        //metodo para buscar proveedores
        public  void Modificarproveedor() { 
          try
            {
                conexion = mq.conectar();//carga el Mysqlconection 

                if (BusProveecod == null )//verifica los campos 
                {
                    sql = "select * from proveedores where provee_nombre ='" + BusProveeNom + "';";
                   // MessageBox.Show(Convert.ToString(sql));
                }
                else {
                    sql = "select * from proveedores where Provee_emprem = '" + BusProveecod + "';";
                   // MessageBox.Show(Convert.ToString(sql));
                }
                           
               

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexion);

                DataTable tabla = new DataTable();//crea una tabla

                adaptador.Fill(tabla);//pasa los datos en la la tabla

                if (tabla == null)
                {
                    MessageBox.Show("No se encontraron datos");
                }
                else
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)//busca los datos en la tabla temporal
                    {
                      //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda

                        EmpresaproveedorG = (tabla.Rows[i]["Provee_emprem"] + "          ");
                        MessageBox.Show(Empresaproveedor);
                        NomEmpresa = (tabla.Rows[i]["provee_nombre"] + "          ");
                        ApeEmpresa = (tabla.Rows[i]["Provee_apellido"] + "          ");
                        DirEmpresa = (tabla.Rows[i]["Provee_direccion"] + "          ");
                        CuidadEmpresa = (tabla.Rows[i]["Provee_ciudad"] + "          ");
                        EstadoEmpresa = (tabla.Rows[i]["Provee_estado"] + "          ");
                        CpEmpresa = (tabla.Rows[i]["Provee_cp"] + "          ");
                        TelEmpresa = (tabla.Rows[i]["Provee_tel"] + "          ");
                        CorreoEmpresa = (tabla.Rows[i]["Provee_correo"] + "          ");
                        DescEmpresa = (tabla.Rows[i]["Provee_descrip"] + "          ");

                    }
                    tabla.Clear();

                      
                }//cierre de la comprobacion de la tabla
                this.conexion.Close(); // se cierra la conexion de la base de datos 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }//se cierra catch
             
        } //Modificar proveedor mediante busqueda

        public DataTable Modificarproveedor1()
        {
            DataTable tabla = new DataTable();//crea una tabla
            try
            {
                
                conexion = mq.conectar();//carga el Mysqlconection 

                sql = "select * from proveedores where " + TipoBuscadoIDNOMBRE1 + " ='" + BusProveeNom1 + "';";
                 //   MessageBox.Show(Convert.ToString(sql));
              

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                MySqlDataAdapter adap = new MySqlDataAdapter(comando);


                adap.Fill(tabla);
              conexion.Close();
                
                
                               
                 // se cierra la conexion de la base de datos 
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());

            }//se cierra catch
            return tabla;
        } //Modificar proveedor mediante busqueda

    }//se cierra clase Nproveedor
}

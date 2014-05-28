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
    public  class Nempleado
    {
        

        //sql es para guardar las cadenas sql
        string sql;
        //creacion de objeto de la clase Mysql
        PvCafeteria.Datos.Mysql mq = new PvCafeteria.Datos.Mysql("bd_cafeute");
        //objeto de la clase mysqlconnection
        MySqlConnection conexion = new MySqlConnection();

        ///variables para transportar los datos de los campos que contiene el formulario nProveedor
        private string  NumEmpleado;
        private string NomEmpleado;
        private  string ApeEmpleado;
        private string DirEmpleado;
        private string CuidadEmpleado;
        private string EstadoEmpleado;
        private  string CpEmpleado;
        private  string TelEmpleado;
        private string CelEmpleado;
        private string CorreoEmpleado;
        private string DescEmpleado;
        private string NivelEmpleado;
        private string FechainicioEmpleado;
        private string usernameEmpleado;
        private string userpassEmpleado;
        //
        private string BusEMPLEAcod1;
        private string BusEMPLEANom1;
        private string TipoBuscadoIDNOMBRE1;
        private string idempleado;
    
        
        //Checkbox variables
        public int UsVentasG { get; set; }
        public int UsproductosG { get; set; }
        public int UsPedidosG { get; set; }
        public int UsCorteG { get; set; }
        public int UsInventarioG { get; set; }
        public int UsProveedoresG { get; set; }
        public int UsClientesG { get; set; }
        public int UsEmpleadosG { get; set; }
        public int UsConfiguracionG { get; set; }
        public int UsPantalla2G { get; set; }
        public string UsDescripcionG { get; set; }

        //metodos para ser llamados desde la otra clase vara llevar las variables 
        public new string NumEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return NumEmpleado;
            }
            set
            {
                NumEmpleado = value;
            }
        }
        public new string NomEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return NomEmpleado;
            }
            set
            {
                NomEmpleado = value;
            }
        }
        public new string ApeEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return ApeEmpleado;
            }
            set
            {
                ApeEmpleado = value;
            }
        }
        public new string DirEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return DirEmpleado;
            }
            set
            {
                DirEmpleado = value;
            }
        }
        public new string CuidadEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return CuidadEmpleado;
            }
            set
            {
                CuidadEmpleado = value;
            }
        }
        public new string EstadoEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return EstadoEmpleado;
            }
            set
            {
                EstadoEmpleado = value;
            }
        }
        public new string CpEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return CpEmpleado;
            }
            set
            {
                CpEmpleado = value;
            }
        }
        public new string TelEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return TelEmpleado;
            }
            set
            {
                TelEmpleado = value;
            }
        }

        public new string CelEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return CelEmpleado;
            }
            set
            {
                CelEmpleado = value;
            }
        }
        public new string CorreoEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return CorreoEmpleado;
            }
            set
            {
                CorreoEmpleado = value;
            }
        }
        public new string DescEmpleadoG  //metodo para ser llamado desde la venta principal
        {
            get
            {
                return DescEmpleado;
            }
            set
            {
                DescEmpleado = value;
            }
        }
        public new string BusEMPLEAcod  //metodo para ser llamado desde la venta proveedor
        {
            get
            {
                return BusEMPLEAcod1;
            }
            set
            {
                BusEMPLEAcod1 = value;
            }
        }
        public new string BusEMPLEANom  //metodo para ser llamado desde la venta proveedor
        {
            get
            {
                return BusEMPLEANom1;
            }
            set
            {
                BusEMPLEANom1 = value;
            }
        }
        public new string idempleadoG  //metodo para duardar id del proveedor
        {
            get
            {
                return idempleado;
            }
            set
            {
                idempleado = value;
            }
        }
        public new string FechainicioEmpleadoG  //metodo para duardar id del proveedor
        {
            get
            {
                return FechainicioEmpleado;
            }
            set
            {
                FechainicioEmpleado = value;
            }
        }
        public new string usernameEmpleadoG  //metodo para duardar id del proveedor
        {
            get
            {
                return usernameEmpleado;
            }
            set
            {
                usernameEmpleado = value;
            }
        }
        public new string userpassEmpleadoG  //metodo para duardar id del proveedor
        {
            get
            {
                return userpassEmpleado;
            }
            set
            {
                userpassEmpleado = value;
            }
        }
        public new string NivelEmpleadoG  //metodo para duardar id del proveedor
        {
            get
            {
                return NivelEmpleado;
            }
            set
            {
                NivelEmpleado = value;
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
        public void agregarEmpleado()
        {
            if (MessageBox.Show("¿Estas seguro de guardar los datos?", "Guardar",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes) 

            {
                try
                {


                    conexion = mq.conectar();//carga el Mysqlconection 
                    sql = "INSERT INTO `bd_cafeute`.`empleados` (`idEmpleados`, `Em_nombre`, `Em_apellido`, `Em_direccion`, `Em_ciudad`, `Em_estado`, `Em_cp`, `Em_telefono`, `Em_correo`, `Em_observacion`, `Em_fecha`, `Usuario_sis_id`, `Movil`)";
                    sql = sql + "VALUES ('" + idempleado + "', '" + NomEmpleado + "', '" + ApeEmpleado + "', '" + DirEmpleado + "', '" + CuidadEmpleado + "', '"+ EstadoEmpleado+"', '"+CpEmpleado+"', '"+TelEmpleado+"', '"+CorreoEmpleado+"', '"+DescEmpleado+"', '"+FechainicioEmpleado+"', '"+idempleado+"', '"+CelEmpleado+"');";

                    MySqlCommand adaptador = new MySqlCommand(sql, conexion);

                    //MessageBox.Show(sql);
                    adaptador.ExecuteNonQuery();

                    this.conexion.Close();
                    MessageBox.Show("Agregado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }//se cierra el catch


            }

        }
        public void AgregarUser()
        {
            try
                {


                    conexion = mq.conectar();//carga el Mysqlconection 
                    //MessageBox.Show("conectado");
                    sql = "INSERT INTO `bd_cafeute`.`users` (`idUsers`, `U_name`, `U_pass`, `U_Type`, `UsVenta`, `UsProductos`, `UsPedidos`, `UsCorte`, `UsInventario`, `UsProveedores`, `UsClientes`, `UsEmpleados`, `UsConfiguracion`, `UsPantalla`)";
                    sql = sql + "VALUES ('" + idempleado + "', '" + usernameEmpleado + "', '" + userpassEmpleado + "', '" + UsDescripcionG + "', '" + UsVentasG + "', '" + UsproductosG + "', '" + UsPedidosG + "', '" + UsCorteG + "', '" + UsInventarioG + "', '" + UsProveedoresG + "', '" + UsClientesG + "', '" + UsEmpleadosG + "', '" + UsConfiguracionG + "', '" + UsPantalla2G + "');";
                //   MessageBox.Show(sql);
                    MySqlCommand adaptador = new MySqlCommand(sql, conexion);

                   adaptador.ExecuteNonQuery();

                    this.conexion.Close();
                   // MessageBox.Show("Agregado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }//se cierra el catch
        } 
             

        //metodo para modificar proveedores
        public void modificarEmpleado()
        {
            if (MessageBox.Show("¿Estas seguro de Actualizar los datos?", "Actualizar",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        == DialogResult.Yes)
            {
            try
            {
                conexion = mq.conectar();
                sql = "update empleados set Em_nombre='" + NomEmpleado + "',Em_apellido ='" + ApeEmpleado + "', Em_direccion= '" + DirEmpleado + "', Em_ciudad='" + CuidadEmpleado + "', Em_estado='" + EstadoEmpleado + "', Em_cp='" + CpEmpleado + "', Em_telefono='" + TelEmpleado + "', Em_correo='" + CorreoEmpleado + "', Em_observacion='" + DescEmpleado + "', Movil = '" + CelEmpleado + "' where idEmpleados = '"+idempleado+"';";
                
                MySqlCommand adaptador = new MySqlCommand(sql, conexion);

                adaptador.ExecuteNonQuery();

                this.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }//se cierra catch

        }//se cierra la comprobaacion 
        }//se cierra el metodo modificarProveedor

        public void modificarUserEmple()
        {
             try
                {
                    conexion = mq.conectar();
                    sql = "update users set U_name ='" + usernameEmpleado + "',U_pass='" + userpassEmpleado + "',U_Type ='" + UsDescripcionG + "', UsVenta='" + UsVentasG + "', UsProductos='" + UsproductosG + "',  UsPedidos ='" + UsPedidosG + "',  UsCorte=" + UsCorteG + ",  UsInventario='" + UsInventarioG + "',  UsProveedores='" + UsProveedoresG + "',  UsClientes='" + UsClientesG + "',UsEmpleados='" + UsEmpleadosG + "', UsConfiguracion='" + UsConfiguracionG + "',UsPantalla='" + UsPantalla2G + "'  where idUsers=" + idempleado + "";

                    MySqlCommand adaptador = new MySqlCommand(sql, conexion);

                    adaptador.ExecuteNonQuery();

                    this.conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }//se cierra catch

              }//se cierra el metodo modificarProveedor
        public void eliminarEmpleado()
        {
            if (MessageBox.Show("¿Estas seguro de Eliminar los datos?", "Eliminar",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
            {
            try{

                conexion = mq.conectar();
               // MessageBox.Show("conectado");
                sql = "delete from empleados where idEmpleados="+idempleado+"";

            MySqlCommand adaptador = new MySqlCommand(sql, conexion);

            adaptador.ExecuteNonQuery();
           // MessageBox.Show("Eliminado");
            
                }
             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }//se cierra catch
        }
        }//se cierra el metodo eliminarProveedor

        public DataTable Consultatablaempleadosreporte()
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "SELECT empleados.*,users.* FROM empleados,users where empleados.Usuario_sis_id = users.idUsers"; //consulta a la tabla Proveedores


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);
            return dt;

        }
        public DataTable ID_Empleados()
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "SELECT MAX(idUsers) AS idEmpleados FROM Users;"; //consulta a la tabla Proveedores


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
                   


            string consulta = "select Max(provee_nombre) from proveedores"; //consulta a la tabla nombre


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();
            
            adap.Fill(dt);
            return dt;
            
        }

                
        public DataTable ModificarEmpleado1()//metodo para buscar depende del texbox que le cargune datos Nombre o Numero empleado
        {
            DataTable tabla = new DataTable();//crea una tabla
            try
            {
                
                conexion = mq.conectar();//carga el Mysqlconection 
                sql = "select * from empleados where idEmpleados =" + idempleado + ";";
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
        public DataTable Consulta_users_Emple()//metodo patra consultar el usuario de cada emplead
        {
            DataTable tabla = new DataTable();//crea una tabla
            try
            {

                conexion = mq.conectar();//carga el Mysqlconection 
                sql = "select * from users where " + TipoBuscadoIDNOMBRE1 + " ='" + BusEMPLEANom1 + "';";
                
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
        }
        public DataTable Consulta_U_name()
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "SELECT (U_name)  FROM users;"; //consulta a la tabla empleados


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);
            
            return dt;

        }
        public void Eliminar_U_name()
        {

            try
            {

                conexion = mq.conectar();

                sql = "delete from users where idUsers=" + idempleado + "";

                MySqlCommand adaptador = new MySqlCommand(sql, conexion);

                adaptador.ExecuteNonQuery();
               /// MessageBox.Show("Eliminado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }//se cierra catch
        }

    }//se cierra clase Nempleado
    
}

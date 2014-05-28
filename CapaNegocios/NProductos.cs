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
    public class NProductos
    {
        //sql es para guardar las cadenas sql
        string sql;
        //creacion de objeto de la clase Mysql
        PvCafeteria.Datos.Mysql mq = new PvCafeteria.Datos.Mysql("bd_cafeute");
        //objeto de la clase mysqlconnection
        MySqlConnection conexion = new MySqlConnection();

        //variables para manejar los datos
       
        public string CodigoProG { get; set; }
        public string proveeProG {get;set;}
        public string NombreProG {get;set;}
        public string DescripProG {get;set;}
        public double PrecioProProveeG {get;set;}
        public double PrecioProVentaG { get; set; }
        public double ExistenciaProG {get;set;}
        public int UnidadProveeG {get;set;}
        //para Comida
        public string com_nom { get; set; }
        public string com_decrip { get; set; }
        public double com_precio { get; set; }

        public DataTable Consulta_Codido_Producto()
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "SELECT (Prod_codigo)FROM productos;"; //consulta a la tabla empleados


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);

            return dt;

        }//se cierra el metodo consutal_codigo

        //metodo para cargar los datos de la bd
        public DataTable Datos()
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

        //metodo para cargar la coleccion de datos para el autocomplete
        public AutoCompleteStringCollection Autocomplete_nombre_proveedor()//autocompleta el nombre del proveedor
        {
            DataTable dt = Datos();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado


            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["provee_nombre"]));
            }

            return coleccion;
        }//termina la funcio Aut
        
        public void AgregarProductos()
        {
            string Cod_provee = codigo_proveedor();

            if (MessageBox.Show("¿Estas seguro de guardar los datos?", "Guardar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {


                    conexion = mq.conectar();//carga el Mysqlconection 
                    // MessageBox.Show("conectado");
                    sql = "INSERT INTO `bd_cafeute`.`productos` (`Produc_id_Proveedor`, `Prod_codigo`, `Prod_fecha`, `Prod_nombre`, `Prod_existencia`, `Prod_precio_provee`, `Prod_precio_vent`, `Pro_descrip`, `Unidad`) ";
                    sql = sql + "values('" + Cod_provee + "','" + CodigoProG + "',sysdate(),'" + NombreProG + "'," + ExistenciaProG + ",'" + PrecioProProveeG + "','" + PrecioProVentaG + "','" + DescripProG + "'," + UnidadProveeG + ")";

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

        } //metodo para consular Proveedores

        public string codigo_proveedor()//funcion que devuelbe el codigo del proveedor
        {
            string cod_provee="";
            string codiii="";
            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "select idProveedores from proveedores where Provee_nombre = '" + proveeProG + "';"; //consulta a la tabla nombre


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)//busca los datos en la tabla temporal
            {
                //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "");//busqueda
                codiii = (dt.Rows[i]["idProveedores"] + "");
            }
            cod_provee = codiii;
            dt.Clear();
            return cod_provee;
        }
        public bool Existe_comida()
        {
            bool existe = false;

            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "select com_nom from comidas"; //consulta a la tabla empleados


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)//busca los datos en la tabla temporal
            {
               // MessageBox.Show(dt.Rows[i]["com_nom"] + "");
                if (com_nom == (dt.Rows[i]["com_nom"] + ""))
                {
                    MessageBox.Show("Ya esta dado de alta esta comida"); 
                    existe = true;
                }
            }
            dt.Clear();

            
            return existe;

        }

        public void Agragr_comida()
        {
            if (Existe_comida() == false)
            {
                if (MessageBox.Show("¿Estas seguro de guardar los datos?", "Guardar",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                {
                    try
                    {


                        conexion = mq.conectar();//carga el Mysqlconection 
                        // MessageBox.Show("conectado");
                        sql = "INSERT INTO `bd_cafeute`.`comidas` (`com_nom`, `com_descrip`, `com_precio`) ";
                        sql = sql + "values('" +com_nom  + "','" + com_decrip + "'," + com_precio + ")";

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
        }//fin funcion

        public DataTable Max_ticket()
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "select ticket from max_ticket"; //consulta a la tabla nombre


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);
            return dt;

        }
    }
}

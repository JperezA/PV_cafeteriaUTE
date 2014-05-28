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
    public class NVenta
    {

        //sql es para guardar las cadenas sql
        string sql;
        //creacion de objeto de la clase Mysql
        PvCafeteria.Datos.Mysql mq = new PvCafeteria.Datos.Mysql("bd_cafeute");
        //objeto de la clase mysqlconnection
        MySqlConnection conexion = new MySqlConnection();

       //variable
        public string Ven_Codigo { get; set; }
        string Ven_descripcion = "";
        double Ven_precioven=0.00;
        public double Ven_cantidad { get; set; }
         double Ven_importe =0.00;
         public int Ven_notaid { get; set; }
        
        public void Agregar_productoventas()
        {
            if (comprobar_exixtencia_del_productos() == true)
            {
                try
                {
                    Busca_producto();
                    Ven_importe = importe(Ven_precioven,Ven_cantidad);
                    conexion = mq.conectar();//carga el Mysqlconection 
                    sql = "INSERT INTO `bd_cafeute`.`ventas` (`idVenta`,`Ven_prod_codigo`, `Ven_prod_descrip`, `Ven_pro_precvent`, `Ven_cantidad`, `Importe`, `Not_id_venta`)";
                    sql = sql + "VALUES (null,'" + Ven_Codigo + "', '" + Ven_descripcion + "', '" + Ven_precioven + "', '" + Ven_cantidad + "', '" + Ven_importe + "', '" + Ven_notaid + "');";

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

        public DataTable busca_num_nota()
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "SELECT MAX(idNota) AS idNota FROM nota_vent;"; //consulta a la tabla Proveedores


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);
            return dt;
        }
        public void Busca_producto()
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "select Prod_nombre,Prod_precio_vent from productos where Prod_codigo = '"+Ven_Codigo+"';"; //consulta a la tabla Proveedores


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();
            adap.Fill(dt);

            if (dt.Rows.Count <= 0)
            { MessageBox.Show("No Existe el Producto"); }
            else
            {


                for (int i = 0; i < dt.Rows.Count; i++)//busca los datos en la tabla temporal
                {
                    //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                    Ven_descripcion = (dt.Rows[i]["Prod_nombre"] + "");
                    Ven_precioven = Convert.ToDouble(dt.Rows[i]["Prod_precio_vent"] + "");

                }
                dt.Clear();
            }
            
        }

        private double importe (double preciopub,double cantidadpro)//funcion que calcula el importe
        {
            double totalimporte = 0;
            totalimporte = (preciopub * cantidadpro);
            
           totalimporte =( (double) ( (int) (totalimporte * 100) ) ) / 100;

           MessageBox.Show(totalimporte.ToString());
            return totalimporte;
 
        }

        public DataTable Tablaventa()
        {
            conexion = mq.conectar();
            DataTable dt = new DataTable();

            try
            {
                             
                string consulta = "select Ven_prod_codigo, Ven_prod_descrip, Ven_pro_precvent,Ven_cantidad, Importe from ventas where Not_id_venta = " + Ven_notaid + " "; //consulta a la tabla Proveedores

              //  MessageBox.Show(consulta);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adap = new MySqlDataAdapter(comando);
                conexion.Close();

                adap.Fill(dt);
                
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            return dt;
        }//fin funcion

        public bool comprobar_exixtencia_del_productos()
        {
            bool siexiste = false;

            conexion = mq.conectar();
            DataTable dt = new DataTable();



            string consulta = "select Prod_codigo from productos;"; //consulta a la tabla Proveedores


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();
            adap.Fill(dt);

           
            for (int i = 0; i < dt.Rows.Count; i++)//busca los datos en la tabla temporal
            {
                //  MessageBox.Show(tabla.Rows[i]["Provee_nombre"] + "          ");//busqueda
                if (Ven_Codigo == (dt.Rows[i]["Prod_codigo"] + ""))
                {
                    siexiste = true;
                   
                }

            }//for

            dt.Clear();
            if (siexiste == false) { MessageBox.Show("El codigo no coincide con la lista de productos"); }

            return siexiste;
        }

    }
}

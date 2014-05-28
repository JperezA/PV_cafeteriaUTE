using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using PvCafeteria.Datos;
using System.Windows.Forms;


namespace PvCafeteria.Negocios
{
    public class LoginN
    {

        //sql es para guardar las cadenas sql
        string sql;
        //creacion de objeto de la clase Mysql
        PvCafeteria.Datos.Mysql mq = new PvCafeteria.Datos.Mysql("bd_cafeute");
        //objeto de la clase mysqlconnection
        MySqlConnection conexion = new MySqlConnection();

        public string Log_usuario { get; set; }
        public string Log_pass { get; set; }
        
        public DataSet Buscar_usuario_pass()
        {
            conexion = mq.conectar();
            DataSet dt = new DataSet();



            string consulta = "select * from users where U_name ='" + Log_usuario+ "' and U_pass = '"+ Log_pass +"';";//consulta a la tabla Proveedores


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);
            return dt;
        }
        public DataSet Buscar_usuario_Nombre()
        {
            conexion = mq.conectar();
            DataSet dt = new DataSet();



            
              string consulta = "SELECT empleados.Em_nombre, empleados.Em_apellido";
                   consulta=  consulta +"  FROM empleados";
                   consulta = consulta + " INNER JOIN USERS ON empleados.idempleados = users.IdUsers";
                   consulta = consulta + " WHERE users.U_name =  '" + Log_usuario + "'";


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            conexion.Close();

            adap.Fill(dt);
            return dt;
        }
     


    }
}

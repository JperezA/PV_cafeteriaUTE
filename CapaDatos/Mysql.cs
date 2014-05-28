using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace PvCafeteria.Datos
{
    public class Mysql
    {

        static string cadena;
        string sql;

       

        public Mysql(string base_de_datos)
        {
            cadena = "server=localhost;";
            cadena += "user=root;";
            cadena += "password='';";
            cadena += "database=" + base_de_datos + ";";

        }

        public  MySqlConnection conectar()
        {
           
                MySqlConnection conexion = new MySqlConnection();
                
                    conexion.ConnectionString = cadena;
                    conexion.Open();
                    return conexion;
                         
        }


      
    
    }
}

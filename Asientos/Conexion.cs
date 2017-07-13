using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Asientos
{
    class Conexion
    {
        string server = "localhost";
        string user = "root";
        string password = "";
        string database = "sala_de_cine";

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection conn;
        
        
       
        public Conexion()
        {

        }
        public MySqlConnection conectar()
        {
            
            builder.Server = server ;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = database ;
            

            try
            {
                conn = new MySqlConnection(builder.ToString());
                conn.Open();          
               
               
            }catch( MySqlException e)
            {
                MessageBox.Show("Conexion fallida : " + e.Message);
                conn.Close();
            }
            

            return conn;

        }
    }
}

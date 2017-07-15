using Asientos;
using cine.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cine.Controladores
{
    class DulcesDAO
    {
        Conexion con = new Conexion();

        public void actualizarDulces( Dulces dulces){}

        public void guardarDulces( Dulces dulces)
        {
            MySqlConnection conexion = con.conectar();
            string query = "insert into dulces( id_inventario_dulceria, precio) values(?id_Inventario_Dulceria, ?precio)";
        }
    }
}

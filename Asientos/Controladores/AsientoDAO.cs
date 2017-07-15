using Asientos;
using cine.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine.Controladores
{
    class AsientoDAO
    {
        Conexion con = new Conexion();

        public void actualizarAsientos( Asiento asiento)
        {

        }

        public void guardar( Asiento asiento)
        {
            MySqlConnection conexion = con.conectar();
            string query = "insert into asiento( nombre_asiento, estado_asiento, id_sala) values(?nombre_Asiento, ?estado_Asiento, ?id_Sala)";

            MySqlCommand cmd = new MySqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("?nombre_asiento", asiento.Nombre_Asiento);
            cmd.Parameters.AddWithValue("?estado_asiento", asiento.Estado_Asiento);
            cmd.Parameters.AddWithValue("?id_sala", asiento.Id_Sala);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro exitoso");
        }

        public void eliminarAsiento()
        {

        }

        public void actualizarAsiento( Asiento asiento)
        {
            MySqlConnection conexion = con.conectar();
            string query = "update asiento set nombre_asiento like ?nombre_Asiento, set estado_asiento like ?estado_Asiento, set id_sala like ?id_Sala";

            MessageBox.Show("Modificacion Exitosa");
        }

        public List<Asiento> obtenerTodos()
        {
            List<Asiento> asiento = new List<Asiento>();

            MySqlConnection conexion = con.conectar();

            return asiento;
        }
    }
}

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
    class SalaDAO
    {
        Conexion con = new Conexion();

        public void actualizarSalas( Sala sala) { }

        public void guardarSalas( Sala sala)
        {
            MySqlConnection conexion = con.conectar();
            string query = "insert into salas(nombre_sala, descripcion) values(?nombre_Sala, descripcion)";

            MySqlCommand cmd = new MySqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("?nombre_Sala", sala.Nombre_Sala);
            cmd.Parameters.AddWithValue("?descripcion", sala.Descripcion);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro exitoso");
        }

        public void eliminarSala( Sala sala) { }

        public void actualizarSala( Sala sala)
        {
            MySqlConnection conexion = con.conectar();
            string query = "update sala set nombre_sala like ?nombre_Sala, set descripcion like ?descripcion";

            MessageBox.Show("Modificacion Exitosa");
        }

        public List<Sala> obtenerSala()
        {
            List<Sala> sala = new List<Sala>();

            MySqlConnection conexion = con.conectar();

            return sala;
        }
    }
}

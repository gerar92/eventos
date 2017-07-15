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
    class BebidasDAO
    {

        Conexion con = new Conexion();
        public void actualizarUsuario(Usuarios usuario)
        {


        }



        public void guardar(Bebidas bebidas)
        {
            MySqlConnection conexion = con.conectar();
            string query = "insert into bebidas( nombre_bebida, precio,inventario_dulceria_id_inventario_dulceria, imagen) values(?nombreBebidas,?precioBebida,?inventarioDulceria,?imagenBebida)";

            MySqlCommand cmd = new MySqlCommand(query, conexion);


            cmd.Parameters.AddWithValue("?nombre_bebida", bebidas.NombreBebidas);
            cmd.Parameters.AddWithValue("?precio", bebidas.PrecioBebida);
            cmd.Parameters.AddWithValue("?inventario_dulceria_id_inventario_dulceria", bebidas.InventarioDulceria);
            cmd.Parameters.AddWithValue("?imagen", bebidas.ImagenBebida);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro exitoso");
        }
        public void EliminarUsuario(Usuarios usuario)
        {

        }

        public void actualizar(Usuarios usuarios)
        {

        }
        public List<Bebidas> obtenerTodos()
        {
            List<Bebidas> Bebidas = new List<Bebidas>();


            MySqlConnection conexion = con.conectar();
            string sql = "select * from bebidas";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            MySqlDataReader msdr = cmd.ExecuteReader();




            while (msdr.Read())
            {
                Bebidas be = new Bebidas();

                be.IdBebidas = (int)msdr["idBebida"];
                be.NombreBebidas = (string)msdr["nombre_bebida"];
                be.PrecioBebida = (float)msdr["precio"];
                be.InventarioDulceria = (int)msdr["inventari_dulceria_id_inventario_dulceria"];
                be.ImagenBebida = (string)msdr["imagen_bebida"];

                Bebidas.Add(be);
            }

            return Bebidas;

        }


        public Bebidas buscarPorId(int id_bebidas)
        {
            MySqlConnection conexion = con.conectar();
            string sql = "select * from bebidas where id_bebidas = " + id_bebidas;
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            MySqlDataReader msdr = cmd.ExecuteReader();
            Bebidas be = new Bebidas();

            while (msdr.Read())
            {

                be.IdBebidas = (int)msdr["idBebida"];
                be.NombreBebidas = (string)msdr["nombre_bebida"];
                be.PrecioBebida = (float)msdr["precio"];
                be.InventarioDulceria = (int)msdr["inventari_dulceria_id_inventario_dulceria"];
                be.ImagenBebida = (string)msdr["imagen_bebida"];

            }

            return be;
        }
    }
}

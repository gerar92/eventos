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
    class UsuariosDAO
    {
       
        Conexion con = new Conexion();
   

    

        public void guardar(Usuarios usuario)
        {
            MySqlConnection conexion = con.conectar();
            string query = "insert into usuarios( nombre_usuario, edad_usuario, password, direccion, correo , tipo_usuario) values(?nombre_usuarios,?edad_usuario,?password,?direccion,?correo,?tipo_usuario)";

            MySqlCommand cmd = new MySqlCommand(query, conexion);

            
            cmd.Parameters.AddWithValue("?nombre_usuarios", usuario.Nombre_usuario);
            cmd.Parameters.AddWithValue("?edad_usuario", usuario.Edad_usuario);
            cmd.Parameters.AddWithValue("?password", usuario.Password);
            cmd.Parameters.AddWithValue("?direccion", usuario.Direccion);
            cmd.Parameters.AddWithValue("?correo", usuario.Correo);
            cmd.Parameters.AddWithValue("?tipo_usuario", usuario.Tipo_usuario);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro exitoso");
        }
        public void EliminarUsuario(Usuarios usuario)
        {

        }

        public void actualizar( Usuarios usuario)
        {
            MySqlConnection conexion = con.conectar();
            string query = "update usuarios set nombre_usuario like ?nombre_usuarios, set edad_usuario like ?edad_usuario, set password like ?password, set direccion like ?direccion ,set correo like ?correo, correo , set tipo_usuario like ?tipo_usuario)";

            MySqlCommand cmd = new MySqlCommand(query, conexion);


            cmd.Parameters.AddWithValue("?nombre_usuarios", usuario.Nombre_usuario);
            cmd.Parameters.AddWithValue("?edad_usuario", usuario.Edad_usuario);
            cmd.Parameters.AddWithValue("?password", usuario.Password);
            cmd.Parameters.AddWithValue("?direccion", usuario.Direccion);
            cmd.Parameters.AddWithValue("?correo", usuario.Correo);
            cmd.Parameters.AddWithValue("?tipo_usuario", usuario.Tipo_usuario);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Modificacion Exitosa");

        }
        public List<Usuarios> obtenerTodos()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            

            MySqlConnection conexion = con.conectar();
            string sql = "select * from usuarios";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            MySqlDataReader msdr = cmd.ExecuteReader();




            while (msdr.Read())
            {
                Usuarios us = new Usuarios();

                us.Id_usuario = (int)msdr["id_usuarios"];
                us.Nombre_usuario = (string)msdr["nombre_usuario"];
                us.Edad_usuario = (int)msdr["edad_usuario"];
                us.Password = (string)msdr["password"];
                us.Direccion = (string)msdr["direccion"];
                us.Correo = (string)msdr["correo"];
                us.Tipo_usuario = (string)msdr["tipo_usuario"];

                usuarios.Add(us);
            }

            return usuarios;

        }


        public Usuarios buscarPorId(int id_usuario)
        {
            MySqlConnection conexion = con.conectar();
            string sql = "select * from usuarios where id_usuarios = " + id_usuario;
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            MySqlDataReader msdr = cmd.ExecuteReader();
            Usuarios us = new Usuarios();

            while (msdr.Read())
            {
                

                us.Id_usuario = (int)msdr["id_usuarios"];
                us.Nombre_usuario = (string)msdr["nombre_usuario"];
                us.Edad_usuario = (int)msdr["edad_usuario"];
                us.Password = (string)msdr["password"];
                us.Direccion = (string)msdr["direccion"];
                us.Correo = (string)msdr["correo"];
                us.Tipo_usuario = (string)msdr["tipo_usuario"];

                
            }

            return us;
        }
    }
}

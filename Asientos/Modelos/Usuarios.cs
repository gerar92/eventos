using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine.Modelos
{
    class Usuarios
    {
        private int id_usuario;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        private string nombre_usuario;

        public string Nombre_usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        private int edad_usuario;

        public int Edad_usuario
        {
            get { return edad_usuario; }
            set { edad_usuario = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string  correo;

        public string  Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private string tipo_usuario;

        public string Tipo_usuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }


        public Usuarios()
        {

        }
        public Usuarios(  string nombre_usuario, int edad, string password, string direccion, string correo, string tipo_usuario)
        {
            
            this.nombre_usuario = nombre_usuario;
            this.edad_usuario = edad;
            this.direccion = direccion;
            this.correo = correo;
            this.tipo_usuario = tipo_usuario;

        }




    }
}

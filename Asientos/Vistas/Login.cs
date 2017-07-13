using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using cine.Controladores;
using cine.Modelos;
using cine.Vistas;

namespace Asientos
{
    public partial class Login : PlantillaLogin
    {
       public static int usuarioLogeado;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            





        }

        public void validarUsuario()
        {
            UsuariosDAO user = new UsuariosDAO();
            List<Usuarios> usuarios = new List<Usuarios>();
            usuarios = user.obtenerTodos();
            bool valDatos = false;

            foreach (var us in usuarios)
            {
                if (us.Nombre_usuario == txtNombre.Text && us.Password == txtContra.Text)
                {
                    usuarioLogeado = us.Id_usuario;
                    valDatos = true;
                    break;
                }
                else {
                    valDatos = false;
                }
                
            }


            if( valDatos)
            {
                Contenedor cont = new Contenedor();
                cont.Show();
                this.Hide();
            }
            else{ 
            
                MessageBox.Show("Datos incorrectos");
            }

            limpiarTexto();

            
        }

       

        private void Login_Load(object sender, EventArgs e)
        {
          

        }

        private void tableData_Paint(object sender, PaintEventArgs e)
        {

        }

        public void limpiarTexto()
        {
            txtContra.Clear();
            txtNombre.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnAcceder2_Click(object sender, EventArgs e)
        {
            validarUsuario();
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

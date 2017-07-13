using cine.Controladores;
using cine.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine.Vistas
{
    public partial class ModificarUsuarios : AgregarUsuarios
    {
        public ModificarUsuarios()
        {
            InitializeComponent();
        }

        private void ModificarUsuarios_Load(object sender, EventArgs e)
        {
            UsuariosDAO ud = new UsuariosDAO();
            List<Usuarios> usuarios = ud.obtenerTodos();

            foreach (Usuarios u in usuarios)
            {
                cbUsuariosRegistrados.Items.Add(u.Nombre_usuario);

                
                
            }



            
        }

        public string usuarioSeleccionado()
        {
            return cbUsuariosRegistrados.SelectedText;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void lbRegistroUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbUsuariosRegistrados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosDAO ud = new UsuariosDAO();
            List<Usuarios> usuarios = ud.obtenerTodos();
            bool validado = false;
            Usuarios us = new Usuarios();

            string userSelected = cbUsuariosRegistrados.SelectedItem.ToString();

            foreach (Usuarios u in usuarios)
            {
               

                if (u.Nombre_usuario ==  usuarioSeleccionado()){
                   
                    us = u;
                    
                    validado = true;

                }
                else
                {
                    validado = false;
                }

            }

            if (validado)
            {
                txtNombreUs.Text = us.Nombre_usuario;
                txtEdadUs.Text = Convert.ToString(us.Edad_usuario);
                txtPassordUs.Text = us.Password;
                txtDireccionUs.Text = us.Direccion;
                txtCorreoUs.Text = us.Correo;

            }
            else
            {
                MessageBox.Show("Usuario no seleccionado");
            }



        }
    }
}

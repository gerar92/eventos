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
        Usuarios usuarioEncontrado = new Usuarios();
        public ModificarUsuarios()
        {
            InitializeComponent();
        }



  

  

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void lbRegistroUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosDAO ud = new UsuariosDAO();
            List<Usuarios> usuarios = ud.obtenerTodos();
           

            bool validado = false;
    

            foreach( Usuarios u in usuarios)
            {
                if( txtBusquedaUsuarios.Text == u.Nombre_usuario)
                {
                    

                    usuarioEncontrado = u;
                    validado = true;
                    break;
                }else
                {
                    validado = false;
                }
            }

            if (validado)
            {
                txtPassordUs.PasswordChar = '\0';
                desplegarValoreUsuario();
                
            }
            else
            {
                MessageBox.Show("Usuario " + txtBusquedaUsuarios.Text + "  no existe ");
            }

        }

        public void desplegarValoreUsuario()
        {
            txtNombreUs.Text = usuarioEncontrado.Nombre_usuario;
            txtEdadUs.Text = Convert.ToString(usuarioEncontrado.Edad_usuario);
            txtPassordUs.Text = usuarioEncontrado.Password;
            txtDireccionUs.Text = usuarioEncontrado.Direccion;
            txtCorreoUs.Text = usuarioEncontrado.Correo;

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            UsuariosDAO u = new UsuariosDAO();
            Usuarios usuarioModificado = new Usuarios();
            usuarioModificado.Nombre_usuario = txtNombreUs.Text;
            usuarioModificado.Edad_usuario = Convert.ToInt16(txtEdadUs.Text);
            usuarioModificado.Password = txtPassordUs.Text;
            usuarioModificado.Direccion = txtDireccionUs.Text;
            usuarioModificado.Correo = txtCorreoUs.Text;

            u.actualizar(usuarioModificado);

            usuarioModificado.Tipo_usuario = validarTipoUsuario();
        }
    }
}

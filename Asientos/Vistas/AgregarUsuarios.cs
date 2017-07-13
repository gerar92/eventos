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
    public partial class AgregarUsuarios : PlantillaModulos
    {
        public AgregarUsuarios()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
       

        private void AgregarUsuarios_Load(object sender, EventArgs e)
        {
           
           
        }
        public virtual bool validarContraseña()
        {
            bool validacion = false;

            if( string.Equals(txtPassordUs.Text, txtConfirPass.Text))
            {
                validacion = true;
            }else
            {
                validacion = false;
            }

            return validacion;
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            

        }

        public virtual void validacionRegistro()
        {
            if (validarContraseña())
            {
                registrar();

                MessageBox.Show("Registro exitoso", "Error contraseñas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            }
            else
            {
                MessageBox.Show("Contraseñas no coinciden", "Error contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        public virtual void registrar()
        {
            UsuariosDAO usuario = new UsuariosDAO();
            Usuarios u = new Usuarios();

            u.Nombre_usuario = txtNombreUs.Text;
            u.Edad_usuario = Convert.ToInt16(txtEdadUs.Text);
            u.Password = txtPassordUs.Text;
            u.Direccion = txtDireccionUs.Text;
            u.Correo = txtCorreoUs.Text;
            u.Tipo_usuario = validarTipoUsuario();

            usuario.guardar(u);
            
        }

        public virtual string validarTipoUsuario()
        {
            string tipoUsuario = "sin asignar";

            if( rbAdmin.Checked){
                tipoUsuario = "administrador";
            }
            else if (rbDulceria.Checked) {
                tipoUsuario = "dulceria";
            }
            else if (rbProyeccion.Checked ){
                tipoUsuario = "proyeccion";
            }
            else if(rbTaquilla.Checked){
                tipoUsuario = "taquilla";
            }
            else
            {
                MessageBox.Show("Tipo de usuario no asignado");
            }


                return tipoUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validacionRegistro();
        }
    }
}

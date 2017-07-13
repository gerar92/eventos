using Asientos;
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
    public partial class Contenedor : PlantillaContenedor
    {
        private int childFormNumber = 0;

        public Contenedor()        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {
            
            sesionUsuario();

            
        }

        public void sesionUsuario()
        {
            UsuariosDAO usuario = new UsuariosDAO();
            Usuarios u = usuario.buscarPorId(Login.usuarioLogeado);

            lsesion.Text = u.Nombre_usuario;

        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuarios au = new AgregarUsuarios();
            au.MdiParent = this;
            au.Show();
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasTaquillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salas s = new Salas();
            s.MdiParent = this;
            s.Show();



        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuarios mu = new ModificarUsuarios();
            mu.MdiParent = this;
            mu.Show();

        }
    }
}

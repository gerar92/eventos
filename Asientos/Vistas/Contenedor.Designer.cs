namespace cine.Vistas
{
    partial class Contenedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteleraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCarteleraDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioDulceriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDulculceriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioTaquillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasTaquillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lsesion = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(706, 0);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(813, 1);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.usuarioDulceriaToolStripMenuItem,
            this.usuarioTaquillaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(888, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.toolStripSeparator3,
            this.productosToolStripMenuItem,
            this.carteleraToolStripMenuItem});
            this.administracionToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.ButtonHighlight;
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuariosToolStripMenuItem,
            this.eliminarUsuariosToolStripMenuItem,
            this.modificarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // registrarUsuariosToolStripMenuItem
            // 
            this.registrarUsuariosToolStripMenuItem.Name = "registrarUsuariosToolStripMenuItem";
            this.registrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registrarUsuariosToolStripMenuItem.Text = "Registrar Usuarios";
            this.registrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuariosToolStripMenuItem_Click);
            // 
            // eliminarUsuariosToolStripMenuItem
            // 
            this.eliminarUsuariosToolStripMenuItem.Name = "eliminarUsuariosToolStripMenuItem";
            this.eliminarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.eliminarUsuariosToolStripMenuItem.Text = "Eliminar Usuarios";
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            this.modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            this.modificarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modificarUsuariosToolStripMenuItem.Text = "Modificar Usuarios";
            this.modificarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductosToolStripMenuItem,
            this.solicitarProductosToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productosToolStripMenuItem.Text = "Dulceria";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // agregarProductosToolStripMenuItem
            // 
            this.agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            this.agregarProductosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agregarProductosToolStripMenuItem.Text = "Agregar Productos";
            // 
            // solicitarProductosToolStripMenuItem
            // 
            this.solicitarProductosToolStripMenuItem.Name = "solicitarProductosToolStripMenuItem";
            this.solicitarProductosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.solicitarProductosToolStripMenuItem.Text = "Solicitar Productos";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // carteleraToolStripMenuItem
            // 
            this.carteleraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPeliculaToolStripMenuItem,
            this.aToolStripMenuItem,
            this.crearCarteleraDelDiaToolStripMenuItem});
            this.carteleraToolStripMenuItem.Name = "carteleraToolStripMenuItem";
            this.carteleraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.carteleraToolStripMenuItem.Text = "Cartelera";
            // 
            // agregarPeliculaToolStripMenuItem
            // 
            this.agregarPeliculaToolStripMenuItem.Name = "agregarPeliculaToolStripMenuItem";
            this.agregarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.agregarPeliculaToolStripMenuItem.Text = "Agregar Pelicula";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aToolStripMenuItem.Text = "Crear Funcion";
            // 
            // crearCarteleraDelDiaToolStripMenuItem
            // 
            this.crearCarteleraDelDiaToolStripMenuItem.Name = "crearCarteleraDelDiaToolStripMenuItem";
            this.crearCarteleraDelDiaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.crearCarteleraDelDiaToolStripMenuItem.Text = "Crear Cartelera del dia";
            // 
            // usuarioDulceriaToolStripMenuItem
            // 
            this.usuarioDulceriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasDulculceriaToolStripMenuItem});
            this.usuarioDulceriaToolStripMenuItem.Name = "usuarioDulceriaToolStripMenuItem";
            this.usuarioDulceriaToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.usuarioDulceriaToolStripMenuItem.Text = "Usuario Dulceria";
            // 
            // ventasDulculceriaToolStripMenuItem
            // 
            this.ventasDulculceriaToolStripMenuItem.Name = "ventasDulculceriaToolStripMenuItem";
            this.ventasDulculceriaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ventasDulculceriaToolStripMenuItem.Text = "Ventas Dulculceria";
            // 
            // usuarioTaquillaToolStripMenuItem
            // 
            this.usuarioTaquillaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasTaquillaToolStripMenuItem});
            this.usuarioTaquillaToolStripMenuItem.Name = "usuarioTaquillaToolStripMenuItem";
            this.usuarioTaquillaToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.usuarioTaquillaToolStripMenuItem.Text = "Usuario Taquilla";
            // 
            // ventasTaquillaToolStripMenuItem
            // 
            this.ventasTaquillaToolStripMenuItem.Name = "ventasTaquillaToolStripMenuItem";
            this.ventasTaquillaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventasTaquillaToolStripMenuItem.Text = "Ventas Taquilla";
            this.ventasTaquillaToolStripMenuItem.Click += new System.EventHandler(this.ventasTaquillaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 582);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(888, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // lsesion
            // 
            this.lsesion.AutoSize = true;
            this.lsesion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsesion.Location = new System.Drawing.Point(468, 0);
            this.lsesion.Name = "lsesion";
            this.lsesion.Size = new System.Drawing.Size(41, 12);
            this.lsesion.TabIndex = 4;
            this.lsesion.Text = "sesion";
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 604);
            this.Controls.Add(this.lsesion);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Contenedor";
            this.Text = "Contenedor";
            this.Load += new System.EventHandler(this.Contenedor_Load);
            this.Controls.SetChildIndex(this.statusStrip, 0);
            this.Controls.SetChildIndex(this.menuStrip, 0);
            this.Controls.SetChildIndex(this.lsesion, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnCerrarSesion, 0);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteleraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPeliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCarteleraDelDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioDulceriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDulculceriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioTaquillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasTaquillaToolStripMenuItem;
        private System.Windows.Forms.Label lsesion;
    }
}




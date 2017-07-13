namespace cine.Vistas
{
    partial class ModificarUsuarios
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
            this.lbBuscarUsuario = new System.Windows.Forms.Label();
            this.btnBuscarUsuarios = new System.Windows.Forms.Button();
            this.txtBusquedaUsuarios = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.Text = "MODIFICAR USUARIOS";
            // 
            // txtPassordUs
            // 
            this.txtPassordUs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPassordUs.Location = new System.Drawing.Point(202, 175);
            // 
            // txtConfirPass
            // 
            this.txtConfirPass.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtConfirPass.Location = new System.Drawing.Point(202, 199);
            // 
            // txtEdadUs
            // 
            this.txtEdadUs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtEdadUs.Location = new System.Drawing.Point(202, 151);
            // 
            // txtNombreUs
            // 
            this.txtNombreUs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNombreUs.Location = new System.Drawing.Point(202, 120);
            // 
            // txtCorreoUs
            // 
            this.txtCorreoUs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCorreoUs.Location = new System.Drawing.Point(202, 247);
            // 
            // txtDireccionUs
            // 
            this.txtDireccionUs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDireccionUs.Location = new System.Drawing.Point(202, 223);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 202);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 291);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(28, 253);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 226);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(27, 181);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(27, 157);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(27, 127);
            // 
            // rbAdmin
            // 
            this.rbAdmin.Location = new System.Drawing.Point(31, 318);
            // 
            // rbDulceria
            // 
            this.rbDulceria.Location = new System.Drawing.Point(184, 318);
            // 
            // rbProyeccion
            // 
            this.rbProyeccion.Location = new System.Drawing.Point(297, 318);
            // 
            // rbTaquilla
            // 
            this.rbTaquilla.Location = new System.Drawing.Point(453, 318);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(21, 366);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Modificar";
            this.btnRegistrar.Visible = false;
      
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(579, 1);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(612, 358);
            this.btnSalir.TabIndex = 12;
            // 
            // lbBuscarUsuario
            // 
            this.lbBuscarUsuario.AutoSize = true;
            this.lbBuscarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbBuscarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.lbBuscarUsuario.Location = new System.Drawing.Point(26, 60);
            this.lbBuscarUsuario.Name = "lbBuscarUsuario";
            this.lbBuscarUsuario.Size = new System.Drawing.Size(91, 12);
            this.lbBuscarUsuario.TabIndex = 16;
            this.lbBuscarUsuario.Text = "Buscar Usuario";
            // 
            // btnBuscarUsuarios
            // 
            this.btnBuscarUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuarios.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscarUsuarios.Location = new System.Drawing.Point(518, 49);
            this.btnBuscarUsuarios.Name = "btnBuscarUsuarios";
            this.btnBuscarUsuarios.Size = new System.Drawing.Size(104, 23);
            this.btnBuscarUsuarios.TabIndex = 18;
            this.btnBuscarUsuarios.Text = "Buscar";
            this.btnBuscarUsuarios.UseVisualStyleBackColor = false;
            this.btnBuscarUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBusquedaUsuarios
            // 
            this.txtBusquedaUsuarios.BackColor = System.Drawing.Color.GhostWhite;
            this.txtBusquedaUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBusquedaUsuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaUsuarios.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtBusquedaUsuarios.Location = new System.Drawing.Point(202, 57);
            this.txtBusquedaUsuarios.Multiline = true;
            this.txtBusquedaUsuarios.Name = "txtBusquedaUsuarios";
            this.txtBusquedaUsuarios.Size = new System.Drawing.Size(272, 22);
            this.txtBusquedaUsuarios.TabIndex = 20;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificar.Location = new System.Drawing.Point(21, 366);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 23);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ModificarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(678, 392);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtBusquedaUsuarios);
            this.Controls.Add(this.btnBuscarUsuarios);
            this.Controls.Add(this.lbBuscarUsuario);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ModificarUsuarios";
            this.Text = "ModificarUsuarios";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPassordUs, 0);
            this.Controls.SetChildIndex(this.txtConfirPass, 0);
            this.Controls.SetChildIndex(this.txtEdadUs, 0);
            this.Controls.SetChildIndex(this.txtNombreUs, 0);
            this.Controls.SetChildIndex(this.txtCorreoUs, 0);
            this.Controls.SetChildIndex(this.txtDireccionUs, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.rbAdmin, 0);
            this.Controls.SetChildIndex(this.rbDulceria, 0);
            this.Controls.SetChildIndex(this.rbProyeccion, 0);
            this.Controls.SetChildIndex(this.rbTaquilla, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.lbBuscarUsuario, 0);
            this.Controls.SetChildIndex(this.btnBuscarUsuarios, 0);
            this.Controls.SetChildIndex(this.txtBusquedaUsuarios, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBuscarUsuario;
        public System.Windows.Forms.Button btnBuscarUsuarios;
        private System.Windows.Forms.TextBox txtBusquedaUsuarios;
        public System.Windows.Forms.Button btnModificar;
    }
}
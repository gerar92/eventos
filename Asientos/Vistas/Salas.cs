using cine.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Asientos
{
    public partial class Salas : PlantillaModulos
    {
        public int[,] estados;
        public static bool[,] seleccionados;
        public Salas()
        {
            InitializeComponent();
        }

        

        private void Salas_Load(object sender, EventArgs e)
        {
            estados = new int[10, 10];
            seleccionados = new bool[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    estados[i, j] = 1;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    seleccionados[i, j] = false;
                }
            }

            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAsientosSeleccionados.Clear();
            asientosSeleccionados();
            mostrarAsientosSeleccionados();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            estados[1, 1]++;

            AsientoAsignado(pb11, validarEstado(estados[1, 1]));

        
        }

        private void AsientoAsignado( PictureBox asiento, bool estado)
        {
            if( estado)
            {
                asiento.Image = Image.FromFile("E:/Imagenes/asiento_ocupado.png");
            }else
            {
                asiento.Image = Image.FromFile("E:/Imagenes/asiento_libre.png");
            }
            
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            estados[1, 2]++;

            AsientoAsignado(pb12, validarEstado(estados[1, 2]));
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pb00_Click(object sender, EventArgs e)
        {
            estados[0, 0]++;

            AsientoAsignado(pb00, validarEstado(estados[0,0]));
        }
        
        public void asientosSeleccionados()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    
                    if (estados[i, j] % 2 == 0)
                    {
                        seleccionados[i, j] = true;
                    }else
                    {
                        seleccionados[i, j] = false;
                    }
                }
            }

            
        }

        public void mostrarAsientosSeleccionados()
        {

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if( seleccionados[i,j] == true )
                    {
                        
                        txtAsientosSeleccionados.Text += "" + i + j + " " + seleccionados[i, j] + "\r\n";
                       
                    }
                }
            }
            
        }

        public bool validarEstado( int conteo)
        {
            bool estado;

            if( conteo % 2 == 0)
            {
                estado = true;
            }else
            {
                estado = false;
            }

            return estado;
        }

        private void pb01_Click(object sender, EventArgs e)
        {
            estados[0, 1]++;
            AsientoAsignado(pb01, validarEstado(estados[0,1]));
        }

        private void pb02_Click(object sender, EventArgs e)
        {
            estados[0, 2]++;
            AsientoAsignado(pb02, validarEstado(estados[0, 2]));
        }

        private void pb03_Click(object sender, EventArgs e)
        {
            estados[0, 3]++;
            AsientoAsignado(pb03, validarEstado(estados[0, 3]));
        }

        private void pb04_Click(object sender, EventArgs e)
        {
            estados[0, 4]++;
            AsientoAsignado(pb04, validarEstado(estados[0, 4]));
        }

        private void pb05_Click(object sender, EventArgs e)
        {
            estados[0, 5]++;
            AsientoAsignado(pb05, validarEstado(estados[0, 5]));
        }

        private void pb06_Click(object sender, EventArgs e)
        {
            estados[0, 6]++;
            AsientoAsignado(pb06, validarEstado(estados[0, 6]));
        }

        private void pb07_Click(object sender, EventArgs e)
        {
            estados[0, 7]++;
            AsientoAsignado(pb07, validarEstado(estados[0, 7]));
        }

        private void pb08_Click(object sender, EventArgs e)
        {
            estados[0, 8]++;
            AsientoAsignado(pb08, validarEstado(estados[0, 8]));
        }

        private void pb09_Click(object sender, EventArgs e)
        {
            estados[0, 9]++;
            AsientoAsignado(pb09, validarEstado(estados[0, 9]));
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            estados[1, 0]++;
            AsientoAsignado(pb10, validarEstado(estados[1, 0]));
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            estados[1, 3]++;
            AsientoAsignado(pb13, validarEstado(estados[1, 3]));
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            estados[1, 4]++;
            AsientoAsignado(pb14, validarEstado(estados[1, 4]));
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            estados[1, 5]++;
            AsientoAsignado(pb15, validarEstado(estados[1, 5]));
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            estados[1, 6]++;
            AsientoAsignado(pb16, validarEstado(estados[1, 6]));
        }

        private void pb17_Click(object sender, EventArgs e)
        {
            estados[1, 7]++;
            AsientoAsignado(pb17, validarEstado(estados[1, 7]));
        }

        private void pb18_Click(object sender, EventArgs e)
        {
            estados[1, 8]++;
            AsientoAsignado(pb18, validarEstado(estados[1, 8]));
        }

        private void pb19_Click(object sender, EventArgs e)
        {
            estados[1, 9]++;
            AsientoAsignado(pb19, validarEstado(estados[1, 9]));
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            estados[2, 0]++;
            AsientoAsignado(pb20, validarEstado(estados[2, 0]));
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            estados[2, 1]++;
            AsientoAsignado(pb21, validarEstado(estados[2, 1]));
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            estados[2, 2]++;
            AsientoAsignado(pb22, validarEstado(estados[2, 2]));
        }

        private void pb23_Click(object sender, EventArgs e)
        {
            estados[2, 3]++;
            AsientoAsignado(pb23, validarEstado(estados[2, 3]));
        }

        private void pb24_Click(object sender, EventArgs e)
        {
            estados[2, 4]++;
            AsientoAsignado(pb24, validarEstado(estados[2, 4]));
        }

        private void pb25_Click(object sender, EventArgs e)
        {
            estados[2, 5]++;
            AsientoAsignado(pb25, validarEstado(estados[2, 5]));
        }

        private void pb26_Click(object sender, EventArgs e)
        {
            estados[2, 6]++;
            AsientoAsignado(pb26, validarEstado(estados[2, 6]));
        }

        private void pb27_Click(object sender, EventArgs e)
        {
            estados[2, 7]++;
            AsientoAsignado(pb27, validarEstado(estados[2, 7]));
        }

        private void pb28_Click(object sender, EventArgs e)
        {
            estados[2, 8]++;
            AsientoAsignado(pb28, validarEstado(estados[2, 8]));
        }

        private void pb29_Click(object sender, EventArgs e)
        {
            estados[2, 9]++;
            AsientoAsignado(pb29, validarEstado(estados[2, 9]));
        }

        private void pb30_Click(object sender, EventArgs e)
        {
            estados[3, 0]++;
            AsientoAsignado(pb30, validarEstado(estados[3, 0]));
        }

        private void pb31_Click(object sender, EventArgs e)
        {
            estados[3, 1]++;
            AsientoAsignado(pb31, validarEstado(estados[3, 1]));
        }

        private void pb32_Click(object sender, EventArgs e)
        {
            estados[3, 2]++;
            AsientoAsignado(pb32, validarEstado(estados[3, 2]));
        }

        private void pb33_Click(object sender, EventArgs e)
        {
            estados[3, 3]++;
            AsientoAsignado(pb33, validarEstado(estados[3, 3]));
        }

        private void pb34_Click(object sender, EventArgs e)
        {
            estados[3, 4]++;
            AsientoAsignado(pb34, validarEstado(estados[3, 4]));
        }

        private void pb35_Click(object sender, EventArgs e)
        {
            estados[3, 5]++;
            AsientoAsignado(pb35, validarEstado(estados[3, 5]));
        }

        private void pb36_Click(object sender, EventArgs e)
        {
            estados[3, 6]++;
            AsientoAsignado(pb36, validarEstado(estados[3, 6]));
        }

        private void pb37_Click(object sender, EventArgs e)
        {
            estados[3, 7]++;
            AsientoAsignado(pb37, validarEstado(estados[3, 7]));
        }

        private void pb38_Click(object sender, EventArgs e)
        {
            estados[3, 8]++;
            AsientoAsignado(pb38, validarEstado(estados[3, 8]));
        }

        private void pb39_Click(object sender, EventArgs e)
        {
            estados[3, 9]++;
            AsientoAsignado(pb39, validarEstado(estados[3, 9])); ;
        }

        private void pb40_Click(object sender, EventArgs e)
        {
            estados[4, 0]++;
            AsientoAsignado(pb40, validarEstado(estados[4, 0]));
        }

        private void pb41_Click(object sender, EventArgs e)
        {
            estados[4, 1]++;
            AsientoAsignado(pb41, validarEstado(estados[4, 1]));
        }

        private void pb42_Click(object sender, EventArgs e)
        {
            estados[4, 2]++;
            AsientoAsignado(pb42, validarEstado(estados[4, 2]));
        }

        private void pb43_Click(object sender, EventArgs e)
        {
            estados[4, 3]++;
            AsientoAsignado(pb43, validarEstado(estados[4, 3]));
        }

        private void pb44_Click(object sender, EventArgs e)
        {
            estados[4, 4]++;
            AsientoAsignado(pb44, validarEstado(estados[4, 4]));
        }

        private void pb45_Click(object sender, EventArgs e)
        {
            estados[4, 5]++;
            AsientoAsignado(pb45, validarEstado(estados[4, 5]));
        }

        private void pb46_Click(object sender, EventArgs e)
        {
            estados[4, 6]++;
            AsientoAsignado(pb46, validarEstado(estados[4, 6]));
        }//

        private void pb47_Click(object sender, EventArgs e)
        {
            estados[4, 7]++;
            AsientoAsignado(pb47, validarEstado(estados[4, 7]));
        }

        private void pb48_Click(object sender, EventArgs e)
        {
            estados[4, 8]++;
            AsientoAsignado(pb48, validarEstado(estados[4, 8]));
        }

        private void pb49_Click(object sender, EventArgs e)
        {
            estados[4, 9]++;
            AsientoAsignado(pb49, validarEstado(estados[4, 9]));
        }

        private void pb50_Click(object sender, EventArgs e)
        {
            estados[5, 0]++;
            AsientoAsignado(pb50, validarEstado(estados[5, 0]));
        }

        private void pb51_Click(object sender, EventArgs e)
        {
            estados[5, 1]++;
            AsientoAsignado(pb51, validarEstado(estados[5, 1]));
        }

        private void pb52_Click(object sender, EventArgs e)
        {
            estados[5, 2]++;
            AsientoAsignado(pb52, validarEstado(estados[5, 2]));
        }

        private void pb53_Click(object sender, EventArgs e)
        {
            estados[5, 3]++;
            AsientoAsignado(pb53, validarEstado(estados[5, 3]));
        }

        private void pb54_Click(object sender, EventArgs e)
        {//
            estados[5, 4]++;
            AsientoAsignado(pb54, validarEstado(estados[5, 4]));
        }

        private void pb55_Click(object sender, EventArgs e)
        {
            estados[5, 5]++;
            AsientoAsignado(pb55, validarEstado(estados[5, 5]));
        }

        private void pb56_Click(object sender, EventArgs e)
        {
            estados[5, 6]++;
            AsientoAsignado(pb56, validarEstado(estados[5, 6]));
        }

        private void pb57_Click(object sender, EventArgs e)
        {
            estados[5, 7]++;
            AsientoAsignado(pb57, validarEstado(estados[5, 7]));
        }

        private void pb58_Click(object sender, EventArgs e)
        {
            estados[5, 8]++;
            AsientoAsignado(pb58, validarEstado(estados[5, 8]));
        }

        private void pb59_Click(object sender, EventArgs e)
        {
            estados[5, 9]++;
            AsientoAsignado(pb59, validarEstado(estados[5, 9]));
        }

        private void pb60_Click(object sender, EventArgs e)
        {
            estados[6, 0]++;
            AsientoAsignado(pb60, validarEstado(estados[6,0 ]));
        }

        private void pb61_Click(object sender, EventArgs e)
        {
            estados[6, 1]++;
            AsientoAsignado(pb61, validarEstado(estados[6, 1]));
        }

        private void pb62_Click(object sender, EventArgs e)
        {
            estados[6, 2]++;
            AsientoAsignado(pb62, validarEstado(estados[6, 2]));
        }

        private void pb63_Click(object sender, EventArgs e)
        {
            estados[6, 3]++;
            AsientoAsignado(pb63, validarEstado(estados[6, 3]));
        }

        private void pb64_Click(object sender, EventArgs e)
        {
            estados[6, 4]++;
            AsientoAsignado(pb64, validarEstado(estados[6, 4]));
        }

        private void pb65_Click(object sender, EventArgs e)
        {
            estados[6, 5]++;
            AsientoAsignado(pb65, validarEstado(estados[6, 5]));
        }

        private void pb66_Click(object sender, EventArgs e)
        {
            estados[6, 6]++;
            AsientoAsignado(pb66, validarEstado(estados[6, 6]));
        }

        private void pb67_Click(object sender, EventArgs e)
        {
            estados[6, 7]++;
            AsientoAsignado(pb67, validarEstado(estados[6, 7]));
        }

        private void pb68_Click(object sender, EventArgs e)
        {
            estados[6, 8]++;
            AsientoAsignado(pb68, validarEstado(estados[6, 8]));
        }

        private void pb69_Click(object sender, EventArgs e)
        {
            estados[6, 9]++;
            AsientoAsignado(pb69, validarEstado(estados[6, 9]));
        }

        private void pb70_Click(object sender, EventArgs e)
        {
            estados[7, 0]++;
            AsientoAsignado(pb70, validarEstado(estados[7, 0]));
        }

        private void pb71_Click(object sender, EventArgs e)
        {
            estados[7, 1]++;
            AsientoAsignado(pb71, validarEstado(estados[7, 1]));
        }

        private void pb72_Click(object sender, EventArgs e)
        {
            estados[7, 2]++;
            AsientoAsignado(pb72, validarEstado(estados[7, 2]));
        }

        private void pb73_Click(object sender, EventArgs e)
        {
            estados[7, 3]++;
            AsientoAsignado(pb73, validarEstado(estados[7, 3]));
        }

        private void pb74_Click(object sender, EventArgs e)
        {
            estados[7, 4]++;
            AsientoAsignado(pb74, validarEstado(estados[7, 4]));
        }

        private void pb75_Click(object sender, EventArgs e)
        {
            estados[7, 5]++;
            AsientoAsignado(pb75, validarEstado(estados[7, 5]));
        }

        private void pb76_Click(object sender, EventArgs e)
        {
            estados[7, 6]++;
            AsientoAsignado(pb76, validarEstado(estados[7, 6]));
        }

        private void pb77_Click(object sender, EventArgs e)
        {
            estados[7, 7]++;
            AsientoAsignado(pb77, validarEstado(estados[7, 7]));
        }

        private void pb78_Click(object sender, EventArgs e)
        {
            estados[7, 8]++;
            AsientoAsignado(pb78, validarEstado(estados[7, 8]));
        }

        private void pb79_Click(object sender, EventArgs e)
        {
            estados[7, 9]++;
            AsientoAsignado(pb79, validarEstado(estados[7, 9])); ;
        }

        private void pb80_Click(object sender, EventArgs e)
        {
            estados[8, 0]++;
            AsientoAsignado(pb80, validarEstado(estados[8, 0]));
        }

        private void pb81_Click(object sender, EventArgs e)
        {
            estados[8, 1]++;
            AsientoAsignado(pb81, validarEstado(estados[8, 1]));
        }

        private void pb82_Click(object sender, EventArgs e)
        {
            estados[8, 2]++;
            AsientoAsignado(pb82, validarEstado(estados[8, 2]));
        }

        private void pb83_Click(object sender, EventArgs e)
        {
            estados[8, 3]++;
            AsientoAsignado(pb83, validarEstado(estados[8, 3]));
        }

        private void pb84_Click(object sender, EventArgs e)
        {
            estados[8, 4]++;
            AsientoAsignado(pb84, validarEstado(estados[8, 4]));
        }

        private void pb85_Click(object sender, EventArgs e)
        {
            estados[8, 5]++;
            AsientoAsignado(pb85, validarEstado(estados[8, 5]));
        }

        private void pb86_Click(object sender, EventArgs e)
        {
            estados[8, 6]++;
            AsientoAsignado(pb86, validarEstado(estados[8, 6]));
        }

        private void pb87_Click(object sender, EventArgs e)
        {
            estados[8, 7]++;
            AsientoAsignado(pb87, validarEstado(estados[8, 7]));
        }

        private void pb88_Click(object sender, EventArgs e)
        {
            estados[8, 8]++;
            AsientoAsignado(pb88, validarEstado(estados[8, 8]));
        }

        private void pb89_Click(object sender, EventArgs e)
        {
            estados[8, 9]++;
            AsientoAsignado(pb89, validarEstado(estados[8, 9]));
        }

        private void pb90_Click(object sender, EventArgs e)
        {
            estados[9, 0]++;
            AsientoAsignado(pb90, validarEstado(estados[9, 0]));
        }

        private void pb91_Click(object sender, EventArgs e)
        {

            estados[9, 1]++;
            AsientoAsignado(pb91, validarEstado(estados[9, 1]));
        }

        private void pb92_Click(object sender, EventArgs e)
        {
            estados[9, 2]++;
            AsientoAsignado(pb92, validarEstado(estados[9, 2]));
        }

        private void pb93_Click(object sender, EventArgs e)
        {
            estados[9, 3]++;
            AsientoAsignado(pb93, validarEstado(estados[9, 3]));
        }

        private void pb94_Click(object sender, EventArgs e)
        {
            estados[9, 4]++;
            AsientoAsignado(pb94, validarEstado(estados[9, 4]));
        }

        private void pb95_Click(object sender, EventArgs e)
        {
            estados[9, 5]++;
            AsientoAsignado(pb95, validarEstado(estados[9, 5]));
        }

        private void pb96_Click(object sender, EventArgs e)
        {
            estados[9, 6]++;
            AsientoAsignado(pb96, validarEstado(estados[9, 6]));
        }

        private void pb97_Click(object sender, EventArgs e)
        {
            estados[9, 7]++;
            AsientoAsignado(pb97, validarEstado(estados[9, 7]));
        }

        private void pb98_Click(object sender, EventArgs e)
        {
            estados[9, 8]++;
            AsientoAsignado(pb98, validarEstado(estados[9, 8]));
        }

        private void pb99_Click(object sender, EventArgs e)
        {
            estados[9, 9]++;
            AsientoAsignado(pb99, validarEstado(estados[9, 9]));
        }

    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine.Modelos
{
    class Bebidas
    {
       

        private int idBebidas;

        public int IdBebidas
        {
            get { return idBebidas; }
            set { idBebidas = value; }
        }

        private string nombreBebidas;

        public string NombreBebidas
        {
            get { return nombreBebidas; }
            set { nombreBebidas = value; }
        }

        private float precioBebida;

        public float PrecioBebida
        {
            get { return precioBebida; }
            set { precioBebida = value; }
        }

        private int inventarioDulceria;

        public int InventarioDulceria
        {
            get { return inventarioDulceria; }
            set { inventarioDulceria = value; }
        }


        private string imagenBebida;

        public string ImagenBebida
        {
            get { return imagenBebida; }
            set { imagenBebida = value; }
        }


        public Bebidas() { }

        public Bebidas( int idBebidas, string nombreBebidas, float costoBebida, string imagenBebida)
        {
            this.idBebidas = idBebidas;
            this.nombreBebidas = nombreBebidas;
            this.costoBebida = costoBebida;
            this.imagenBebida = imagenBebida;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine.Modelos
{
    class Dulces
    {
        private int id_Dulces;

        public int Id_Dulces
        {
            get { return id_Dulces; }
            set { id_Dulces = value; }
        }

        private int id_Inventario_Dulceria;

        public int Id_Inventario_Dulceria
        {
            get { return id_Inventario_Dulceria; }
            set { id_Inventario_Dulceria = value; }
        }

        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        public Dulces() { }

        public Dulces(int id_Inventario_Dulceria, float precio)
        {
            this.id_Inventario_Dulceria = id_Inventario_Dulceria;
            this.precio = precio;
        }

    }
}

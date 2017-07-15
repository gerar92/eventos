using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine.Modelos
{
    class Sala
    {
        private int id_Sala;

        public int Id_Sala
        {
            get { return id_Sala; }
            set { id_Sala = value; }
        }

        private string nombre_Sala;

        public string Nombre_Sala
        {
            get { return nombre_Sala; }
            set { nombre_Sala = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Sala() { }

        public Sala(string nombre_Sala, string descripcion)
        {
            this.nombre_Sala = nombre_Sala;
            this.descripcion = descripcion;
        }


    }
}

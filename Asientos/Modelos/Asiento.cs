using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine.Modelos
{
    class Asiento
    {
        private int id_asiento;

        public int Id_Asiento
        {
            get { return id_asiento; }
            set { id_asiento = value; }
        }

        private string nombre_Asiento;

        public string Nombre_Asiento
        {
            get { return nombre_Asiento; }
            set { nombre_Asiento = value; }
        }

        private string estado_Asiento;

        public string Estado_Asiento
        {
            get { return estado_Asiento; }
            set { estado_Asiento = value; }
        }

        private int id_Sala;

        public int Id_Sala
        {
            get { return id_Sala; }
            set { id_Sala = value; }
        }

        public Asiento() { }

        public Asiento(string nombre_Asiento, string estado_Asiento, int id_Sala)
        {
            this.nombre_Asiento = nombre_Asiento;
            this.estado_Asiento = estado_Asiento;
            this.id_Sala = id_Sala;
        }


    }
}

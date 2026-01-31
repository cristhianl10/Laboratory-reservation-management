using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PRIMER_PARCIAL.Modelo
{
    internal class Cl_Laboratorio
    {
        private int id, capacidad;
        private string nombre;
        private bool estado;

        public Cl_Laboratorio()
        {
            id = 0;
            nombre = string.Empty;
            capacidad = 0;
            estado = true;
        }

        public Cl_Laboratorio(int id, string nombre, int capacidad, bool estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.capacidad = capacidad;
            this.estado = estado;
        }

        public int ID { get { return id; } set { id = value; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public int Capacidad { get { return capacidad; } set { capacidad = value; } }

        public bool Estado { get { return estado; } set { estado = value; } }
    }
}

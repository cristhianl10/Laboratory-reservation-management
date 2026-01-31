using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PRIMER_PARCIAL.Modelo
{
    internal class Cl_Reserva
    {
        //variables a usar con su respectivo encapsulamiento
        private string nombreDocente, nombreAsignatura;
        private Cl_Laboratorio laboratorio; //almacena el laboratorio asociado con esta reserva
        private DateOnly fechaReserva;
        private TimeOnly horaInicioReserva, horaFinReserva;
        private int id, cantidadEstudiantes;
        private string nombreLaboratorio;

        // constructor sin parametros
        public Cl_Reserva()
        {
            nombreDocente = string.Empty;
            nombreAsignatura = string.Empty;
            laboratorio = new Cl_Laboratorio();
            fechaReserva = DateOnly.MinValue;
            horaInicioReserva = TimeOnly.MinValue;
            horaFinReserva = TimeOnly.MinValue;
            id = 0;
            cantidadEstudiantes = 0;
        }
        // constructor con parametros
        public Cl_Reserva(string nombreDocente, string nombreAsignatura, Cl_Laboratorio laboratorio,
            DateOnly fechaReserva, TimeOnly horaInicioReserva, TimeOnly horaFinReserva, int id, int cantidadEstudiantes)
        {
            this.nombreDocente = nombreDocente;
            this.nombreAsignatura = nombreAsignatura;
            this.laboratorio = laboratorio;
            this.fechaReserva = fechaReserva;
            this.horaInicioReserva = horaInicioReserva;
            this.horaFinReserva = horaFinReserva;
            this.id= id;
            this.cantidadEstudiantes = cantidadEstudiantes;
        }
        //propiedades para acceder a los atributos encapsulados
        public string NombreDocente
        {
            get { return nombreDocente; } set { nombreDocente = value; }
        }
        public string NombreAsignatura
        {
            get { return nombreAsignatura; } set { nombreAsignatura = value; }
        }
        public Cl_Laboratorio Laboratorio
        {
            get { return laboratorio; } set { laboratorio = value; }
        }
        public DateOnly FechaReserva
        {
            get { return fechaReserva; } set { fechaReserva = value; }
        }
        public TimeOnly HoraInicioReserva
        {
            get { return horaInicioReserva; } set { horaInicioReserva = value; }
        }
        public TimeOnly HoraFinReserva
        {
            get { return horaFinReserva; } set { horaFinReserva = value; }
        }
        public int ID
        {
            get { return id; } set { id = value; }
        }
        public int CantidadEstudiantes
        {
            get { return cantidadEstudiantes; } set { cantidadEstudiantes = value; }
        }

        public string NombreLaboratorio
        {
            get
            {
                return laboratorio != null ? laboratorio.Nombre : string.Empty;
            }
        }
    }
}

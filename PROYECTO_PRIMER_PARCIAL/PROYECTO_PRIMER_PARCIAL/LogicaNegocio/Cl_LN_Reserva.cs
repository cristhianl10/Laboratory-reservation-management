using PROYECTO_PRIMER_PARCIAL.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PRIMER_PARCIAL.LogicaNegocio
{
    internal class Cl_LN_Reserva
    {
        //declarando una lista de tipo reserva
        public static List<Cl_Reserva> listaReservas = new List<Cl_Reserva>();
        
        //obtener el siguiente ID de la reserva
        public int GetNextID()
        {
            if (listaReservas.Count == 0)
                return 1;
            else
                return listaReservas[listaReservas.Count - 1].ID + 1;
        }
        
        //retorna el indice de la lista de donde se ubica el ID de la reserva 
        public int GetIndiceLista(int idReserva)
        {
            for (int i = 0; i < listaReservas.Count; i++)
            {
                if (listaReservas[i].ID == idReserva)
                    return i;
            }
            return -1; //o retorna -1 cuando no lo encuentra
        }
        public List<Cl_Reserva> getListaReservas()
        {
            return listaReservas;
        }
        public void CrearReserva(Cl_Reserva reserva)
        {
            try
            {
                listaReservas.Add(reserva);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void EditarReserva(Cl_Reserva reserva)
        {
            try
            {
                int indice = GetIndiceLista(reserva.ID);
                if (indice == -1)
                    throw new ArgumentException("El ID a editar no se encuentra");
                else
                {
                    //reemplazando el objeto reserva
                    listaReservas[indice] = reserva;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void EliminarReserva(Cl_Reserva reserva)
        {
            try
            {
                int indice = GetIndiceLista(reserva.ID);
                if (indice == -1)
                    throw new ArgumentException("El código a eliminar no se encuentra");
                else
                {
                    //eliminar el Objeto reserva en el índice
                    listaReservas.RemoveAt(indice);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //busca y devuelve la reserva cuyo ID coincide con el id enviado
        public Cl_Reserva ObtenerReserva(int id)
        {
            foreach (var reserva in listaReservas)
            {
                if (reserva.ID == id)
                    return reserva;
            }
            return null; //si no se encuentra ninguna coincidencia, retorna null
        }
        //verifica si existe una reserva con el Id indicado
        public bool BuscarPorId(int id)
        {
            foreach (var reserva in listaReservas)
            {
                if (reserva.ID == id)
                    return true;
            }
            return false; //retorna false si no se encuentra una coincidencia
        }
        //se agregan las reservas cuyo nombre de laboratorio coincide con el parámetro recibido
        public List<Cl_Reserva> FiltrarPorLaboratorio(string nombreLab)
        {
            List<Cl_Reserva> lista = new List<Cl_Reserva>();

            foreach (var reserva in listaReservas)
            {
                if (reserva.Laboratorio != null && reserva.Laboratorio.Nombre == nombreLab)
                    lista.Add(reserva);
            }
            return lista; //retorna una lista con todas las reservas asociadas al laboratorio indicado
        }
        //retorna una lista con todas las reservas que coinciden con la fecha indicada
        public List<Cl_Reserva> FiltrarPorFecha(DateOnly fecha)
        {
            List<Cl_Reserva> lista = new List<Cl_Reserva>();

            foreach (var reserva in listaReservas)
            {
                if (reserva.FechaReserva == fecha)
                    lista.Add(reserva);
            }

            return lista;
        }

        //validamos que los campos obligatorios estén completos
        public void ValidarCampos(Cl_Reserva reserva)
        {
            if (string.IsNullOrWhiteSpace(reserva.NombreDocente))
                throw new Exception("El nombre del docente no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(reserva.NombreAsignatura))
                throw new Exception("Debe ingresar el nombre de la asignatura.");

            if (reserva.Laboratorio == null)
                throw new Exception("Debe seleccionar un laboratorio activo.");

            if (!reserva.Laboratorio.Estado)
                throw new Exception("No se puede asignar un laboratorio inactivo");
            
            if (reserva.CantidadEstudiantes <= 0)
                throw new Exception("La cantidad de estudiantes debe ser mayor a 0.");
        }
        //validamos que el laboratorio pueda recibir esa cantidad de estudiantes
        public void ValidarCapacidad(Cl_Reserva reserva)
        {
            if (reserva.Laboratorio == null)
                throw new Exception("Debe seleccionar un laboratorio.");

            if (reserva.CantidadEstudiantes > reserva.Laboratorio.Capacidad)
                throw new Exception($"El laboratorio soporta {reserva.Laboratorio.Capacidad} estudiantes, " + $"pero ingresó {reserva.CantidadEstudiantes}.");
        }
        //validamos el horario de la reserva
        public void ValidarHorario(Cl_Reserva reserva)
        {
            if (reserva.HoraInicioReserva >= reserva.HoraFinReserva)
                throw new Exception("La hora de inicio debe ser menor a la hora de fin.");

            DateTime fechaHoraActual = DateTime.Now;
            DateOnly fechaActual = DateOnly.FromDateTime(fechaHoraActual);
            TimeOnly horaActual = TimeOnly.FromDateTime(fechaHoraActual);

            if (reserva.FechaReserva == fechaActual)
            {
                if (reserva.HoraInicioReserva < horaActual)
                    throw new Exception("No puede reservar en una hora que ya pasó.");
            }

            if (reserva.FechaReserva < fechaActual)
                throw new Exception("No puede reservar en una fecha pasada.");
        }
        //validamos si hay choque con otra reserva
        public void ValidarSolapamiento(Cl_Reserva nueva)
        {
            foreach (var reserva in listaReservas)
            {
                if (reserva.Laboratorio.Nombre == nueva.Laboratorio.Nombre && reserva.FechaReserva == nueva.FechaReserva && reserva.ID != nueva.ID)
                {
                    bool solapa = nueva.HoraInicioReserva < reserva.HoraFinReserva && nueva.HoraFinReserva > reserva.HoraInicioReserva;
                    if (solapa)
                    {
                        throw new Exception($"Conflicto de horario: ya existe una reserva de " + $"{reserva.HoraInicioReserva} a {reserva.HoraFinReserva}.");
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_PRIMER_PARCIAL.Modelo;

namespace PROYECTO_PRIMER_PARCIAL.LogicaNegocio
{
    internal class Cl_LN_Laboratorio
    {
        //Crea una lista de tipo laboratorio
        public static List<Cl_Laboratorio> lista_laboratorio = new List<Cl_Laboratorio>();

        //Se obtiene la ID del siguiente laboratorio
        public int GetNextID()
        {
            if (lista_laboratorio.Count == 0)
                return 1;
            else
                return lista_laboratorio[lista_laboratorio.Count - 1].ID + 1;
        }
       
        //retorna el indice del laboratorio en la lista en base a su ID
        public int GetIndiceLista(int ID)
        {
            //Se recibe el ID del laboratorio para determinar su indice en la lista
            for (int i = 0; i < lista_laboratorio.Count; i++)
            {
                if (lista_laboratorio[i].ID == ID)
                    return i;
            }
            return -1; //o retorna -1 cuando no lo encuentra
        }

        //regresa la lista de laboratorios
        public List<Cl_Laboratorio> getListaLaboratorios()
        {
            return lista_laboratorio;
        }

        //filtra los laboratorios para regresar una lista con solo los que esten activos
        public List<Cl_Laboratorio> getListaLaboratoriosActivos()
        {
            
            List<Cl_Laboratorio> activos = new List<Cl_Laboratorio>();

            foreach (Cl_Laboratorio lab in lista_laboratorio)
            {
                if (lab.Estado)
                    activos.Add(lab);
            }

            return activos;
        }


        public void AgregarLaboratorio(Cl_Laboratorio laboratorio)
        {
            //recibe un objeto de laboratorio para agregarlo a la lista
            try
            {
                lista_laboratorio.Add(laboratorio);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void ModificarLaboratorio(Cl_Laboratorio laboratorio)
        {
            try
            {
                //recibe un objeto de laboratorio para buscarlo en base a su ID
                //Para actualizar sus datos
                int indice = GetIndiceLista(laboratorio.ID);
                if (indice == -1)
                    throw new ArgumentException("El código del laboratorio a modificar no se encuentra");
                else
                {
                    lista_laboratorio[indice] = laboratorio;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        
        public void EliminarLaboratorio(Cl_Laboratorio laboratorio)
        {
            try
            {
                //recibe un objeto de laboratorio para buscarlo en base a su ID
                //Para eliminarlo de la lista
                int indice = GetIndiceLista(laboratorio.ID);
                if (indice == -1)
                    throw new ArgumentException("El código del laboratorio a eliminar no se encuentra");

                lista_laboratorio.RemoveAt(indice);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void ValidarCampos(Cl_Laboratorio nuevolaboratorio)
        {
            //Valida que el nombre no este vacio
            if (string.IsNullOrWhiteSpace(nuevolaboratorio.Nombre))
                throw new Exception("El nombre del laboratorio no puede estar vacio");
            //valida que la capacidad se sea mayor a 0
            if (nuevolaboratorio.Capacidad <= 0)
                throw new Exception("La capacidad del laboratorio debe ser mayor a 0.");
        }

        public void ValidarDuplicados(Cl_Laboratorio nuevolaboratorio)
        {
            //Verifica que existan laboratorios con el mismo nombre
            foreach (var laboratorio in lista_laboratorio)
            {
                if (laboratorio.Nombre == nuevolaboratorio.Nombre && laboratorio.ID != nuevolaboratorio.ID)
                {

                    throw new Exception("No pueden haber 2 laboratorios con el mismo nombre");

                }
            }

        }
    }
    
}

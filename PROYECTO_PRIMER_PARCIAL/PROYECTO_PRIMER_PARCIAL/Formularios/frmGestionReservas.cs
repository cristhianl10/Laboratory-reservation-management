using PROYECTO_PRIMER_PARCIAL.LogicaNegocio;
using PROYECTO_PRIMER_PARCIAL.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PRIMER_PARCIAL.Formularios;

public partial class frmGestionReservas : Form
{
    Cl_LN_Reserva lnReserva = new Cl_LN_Reserva();
    Cl_LN_Laboratorio lnLaboratorio = new Cl_LN_Laboratorio();

    private bool es_Reserva_nuevo = false;

    public frmGestionReservas()
    {
        InitializeComponent();

        desactivar_controles();
        btnGuardar.Enabled = false;
        btnEliminar.Enabled = false;
        btnLimpiar.Enabled = false;
        btnNuevo.Enabled = true;
        CargarReservasGrid();
        cargarListaLaboratorio();

        cbFiltroLab.Enabled = false;
        dtpFiltroFechaReserva.Enabled = false;
    }

    private void activar_controles()
    {
        txtDocente.Enabled = true;
        txtAsignatura.Enabled = true;
        dtpFechaReserva.Enabled = true;
        dtpHoraInicio.Enabled = true;
        dtpHoraFin.Enabled = true;
        nudNumEstudiantes.Enabled = true;
        cbLaboratorios.Enabled = true;
    }

    private void desactivar_controles()
    {
        txtDocente.Enabled = false;
        txtAsignatura.Enabled = false;
        dtpFechaReserva.Enabled = false;
        dtpHoraInicio.Enabled = false;
        dtpHoraFin.Enabled = false;
        nudNumEstudiantes.Enabled = false;
        cbLaboratorios.Enabled = false;
    }

    private void limpiar_controles()
    {
        txtDocente.Text = string.Empty;
        txtAsignatura.Text = string.Empty;
        DateTime horaPresente = DateTime.Now;
        dtpHoraInicio.Value = horaPresente;
        dtpHoraFin.Value = horaPresente;
        dtpFechaReserva.Value = DateTime.Now;
        nudNumEstudiantes.Value = 1;
        txtID.Text = string.Empty;
    }


    private void cargarListaLaboratorio()
    {
        if (lnLaboratorio.getListaLaboratoriosActivos().Count > 0)
        {
            //lleno el combo box de laboratorios
            cbLaboratorios.DataSource = lnLaboratorio.getListaLaboratoriosActivos();
            //lleno el combo box de filtro de laboratorios
            cbFiltroLab.DataSource = lnLaboratorio.getListaLaboratoriosActivos();
            //llenamos por su nombre
            cbLaboratorios.DisplayMember = "Nombre";
            cbFiltroLab.DisplayMember = "Nombre";
        }
    }

    private void cargarConsulta(List<Cl_Reserva> reservas)
    {
        //recibe una lista de reservas
        try
        {
            dgvReserva.DataSource = null;
            //si el listado tiene mas de 0 elementos, se carga en el dgv
            if (reservas.Count > 0)
            {
                dgvReserva.AutoGenerateColumns = false;
                dgvReserva.DataSource = null;
                dgvReserva.DataSource = reservas;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void CargarReservasGrid()
    {
        //si el listado de reservas tiene mas de 0 elementos, se carga en el dgv
        try
        {
            dgvReserva.DataSource = null;
            if (lnReserva.getListaReservas().Count > 0)
            {
                dgvReserva.AutoGenerateColumns = false;
                dgvReserva.DataSource = null;
                dgvReserva.DataSource = lnReserva.getListaReservas();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnVolver_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        limpiar_controles();
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
        btnLimpiar.Enabled = true;
        limpiar_controles();
        btnGuardar.Enabled = true;
        btnEliminar.Enabled = false;
        btnNuevo.Enabled = false;
        es_Reserva_nuevo = true;
        btnConsultaFecha.Enabled = false;
        btnConsultaLaboratorio.Enabled = false;
        btnMostrarTodo.Enabled = false;
        gbDatosReserva.Text = "Datos Reserva - CREANDO RESERVA";
        activar_controles();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Cl_Reserva nuevaReserva = new Cl_Reserva();
            if (es_Reserva_nuevo)
            {
                //si la reserva es nueva, se guarda
                nuevaReserva.ID = lnReserva.GetNextID();
                nuevaReserva.NombreDocente = txtDocente.Text;
                nuevaReserva.NombreAsignatura = txtAsignatura.Text;
                nuevaReserva.FechaReserva = DateOnly.FromDateTime(dtpFechaReserva.Value);
                nuevaReserva.HoraInicioReserva = TimeOnly.FromDateTime(dtpHoraInicio.Value);
                nuevaReserva.HoraFinReserva = TimeOnly.FromDateTime(dtpHoraFin.Value);
                nuevaReserva.CantidadEstudiantes = (int)nudNumEstudiantes.Value;
                nuevaReserva.Laboratorio = (Cl_Laboratorio)cbLaboratorios.SelectedItem;

                lnReserva.ValidarCampos(nuevaReserva);
                lnReserva.ValidarCapacidad(nuevaReserva);
                lnReserva.ValidarHorario(nuevaReserva);
                lnReserva.ValidarSolapamiento(nuevaReserva);

                lnReserva.CrearReserva(nuevaReserva);
                MessageBox.Show("Reserva Creada con Éxito");
                es_Reserva_nuevo = false;
            }
            else
            {
                //si no es nueva, se actualizan los datos
                nuevaReserva.ID = int.Parse(txtID.Text);
                nuevaReserva.NombreDocente = txtDocente.Text;
                nuevaReserva.NombreAsignatura = txtAsignatura.Text;
                nuevaReserva.FechaReserva = DateOnly.FromDateTime(dtpFechaReserva.Value);
                nuevaReserva.HoraInicioReserva = TimeOnly.FromDateTime(dtpHoraInicio.Value);
                nuevaReserva.HoraFinReserva = TimeOnly.FromDateTime(dtpHoraFin.Value);
                nuevaReserva.CantidadEstudiantes = (int)nudNumEstudiantes.Value;
                nuevaReserva.Laboratorio = (Cl_Laboratorio)cbLaboratorios.SelectedItem;

                lnReserva.ValidarCampos(nuevaReserva);
                lnReserva.ValidarCapacidad(nuevaReserva);
                lnReserva.ValidarHorario(nuevaReserva);
                lnReserva.ValidarSolapamiento(nuevaReserva);

                lnReserva.EditarReserva(nuevaReserva);
                MessageBox.Show("Reserva Actualizada con Exito");
                es_Reserva_nuevo = false;
            }
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;
            btnConsultaFecha.Enabled = true;
            btnConsultaLaboratorio.Enabled = true;
            btnMostrarTodo.Enabled = true;
            gbDatosReserva.Text = "Datos Reserva";
            desactivar_controles();
            CargarReservasGrid();
            limpiar_controles();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            Cl_Reserva obj_reserva = new Cl_Reserva();
            obj_reserva.ID = int.Parse(txtID.Text);
            lnReserva.EliminarReserva(obj_reserva);

            limpiar_controles();
            desactivar_controles();

            CargarReservasGrid();
            dgvReserva.ClearSelection();

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnConsultaFecha.Enabled = true;
            btnConsultaLaboratorio.Enabled = true;
            btnMostrarTodo.Enabled = true;

            MessageBox.Show("La reserva ha sido eliminada");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }



    private void dgvReserva_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        //Se selecciona una reserva de la tabla para actualizar
        try
        {
            //validaciones para que solo se pueda cargar las reservas de la tabla
            if (e.RowIndex < 0)
                return;

            if (dgvReserva.Rows.Count == 0)
                return;

            if (dgvReserva.Rows[e.RowIndex].IsNewRow)
                return;

            if (dgvReserva.Rows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    
                    es_Reserva_nuevo = false;
                    btnLimpiar.Enabled = true;
                    btnMostrarTodo.Enabled = false;
                    btnConsultaLaboratorio.Enabled = false;
                    btnConsultaFecha.Enabled = false;
                    cbFiltroLab.Enabled = false;
                    dtpFiltroFechaReserva.Enabled = false;
                    string nombreLaboratorio = cbLaboratorios.Text;
                    //si se seleccion una reserva de la tabla, carga los datos en los controles
                    txtID.Text = dgvReserva.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    txtDocente.Text = dgvReserva.Rows[e.RowIndex].Cells["NombreDocente"].Value.ToString();
                    txtAsignatura.Text = dgvReserva.Rows[e.RowIndex].Cells["NombreAsignatura"].Value.ToString();
                    dtpFechaReserva.Value = DateTime.Parse(dgvReserva.Rows[e.RowIndex].Cells["FechaReserva"].Value.ToString());
                    dtpHoraInicio.Value = DateTime.Parse(dgvReserva.Rows[e.RowIndex].Cells["HoraInicioReserva"].Value.ToString());
                    dtpHoraFin.Value = DateTime.Parse(dgvReserva.Rows[e.RowIndex].Cells["HoraFinReserva"].Value.ToString());
                    nudNumEstudiantes.Value = int.Parse(dgvReserva.Rows[e.RowIndex].Cells["CantidadEstudiantes"].Value.ToString());

                    int idReserva = int.Parse(txtID.Text);
                    Cl_Reserva reservaSeleccionada = lnReserva.ObtenerReserva(idReserva);
                    //se busca el laboratorio de la reserva para que aparezca seleccionado en el combo box
                    if (reservaSeleccionada != null && reservaSeleccionada.Laboratorio != null)
                    {
                        foreach (Cl_Laboratorio lab in cbLaboratorios.Items)
                        {
                            if (lab.Nombre == reservaSeleccionada.Laboratorio.Nombre)
                            {
                                cbLaboratorios.SelectedItem = lab;
                                break;
                            }
                        }
                    }

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnEliminar.Enabled = true;
                    gbDatosReserva.Text = "Datos Reserva - ACTUALIZANDO RESERVA";
                    activar_controles();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void validarVaciocbFiltroLab()
    {
        //valida que el combo box para filtrar por laboratorios no este vacio
        if (cbFiltroLab.Items.Count == 0)
        {
            throw new Exception("No hay laboratorios para filtrar");
        }
    }

    private void validarReservasCbFiltroLab(Cl_Laboratorio laboratorio)
    {
        //valida que hayan reservas para el laboratorio que se reciba
        if (lnReserva.FiltrarPorLaboratorio(laboratorio.Nombre).Count == 0)
        {
            throw new Exception("No hay reservas para este laboratorio.");
        }
    }

    private void validarReservasDtpFiltroFechaReserva()
    {
        //valida que hayan reservas en la fecha seleccionada el dtp
        if (lnReserva.FiltrarPorFecha(DateOnly.FromDateTime(dtpFiltroFechaReserva.Value)).Count == 0)
        {
            throw new Exception("No hay reservas para esta fecha.");
        }
    }

    private void btnConsultaLaboratorio_Click(object sender, EventArgs e)
    {
        Cl_Laboratorio laboratorio = (Cl_Laboratorio)cbFiltroLab.SelectedItem;
        //si el combobox de filtrar laboratorio esta habilitado
        if (cbFiltroLab.Enabled)
        {
            try
            {
                //valida que no este vacio la seleccion del combobox 
                validarVaciocbFiltroLab();
                //valida que existan reservas en ese laboratorio
                validarReservasCbFiltroLab(laboratorio);
                //carga las reservas para ese laboratorio en el dgv
                cargarConsulta(lnReserva.FiltrarPorLaboratorio(laboratorio.Nombre));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        else // en caso de no estar habilitado el combobox
        {
            
            // se habilidad el combobox
            cbFiltroLab.Enabled = true;
            // se deshabilita el dtp de fechas de reserva
            dtpFiltroFechaReserva.Enabled = false;
        }

    }

    private void btnMostrarTodo_Click(object sender, EventArgs e)
    {
        //Se desactivan el combobox y el dtp para filtrar
        cbFiltroLab.Enabled = false;
        dtpFiltroFechaReserva.Enabled = false;
        //Se cargan todas las reservas en dgv
        CargarReservasGrid();
    }

    private void btnConsultaFecha_Click(object sender, EventArgs e)
    {
        //si el de dtp esta habilitado
        if (dtpFiltroFechaReserva.Enabled)
        {
            try
            {
                //valida que existan reservas en esa fecha
                validarReservasDtpFiltroFechaReserva();
                //carga las reservas de la fecha seleccionada en el dgv
                cargarConsulta(lnReserva.FiltrarPorFecha(DateOnly.FromDateTime(dtpFiltroFechaReserva.Value)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        else //si el dtp para selecciona la fecha no esta habilitado
        {
            //se habilita el dtp
            dtpFiltroFechaReserva.Enabled = true;
            //se deshabilita el combobox para filtrar por laboratorios
            cbFiltroLab.Enabled = false;
        }

    }

    private void txtDocente_KeyPress(object sender, KeyPressEventArgs e)
    {
        //valida que solo se ingresen letras en el txtDpcente
        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
        {
            e.Handled = true;
        }
    }

}
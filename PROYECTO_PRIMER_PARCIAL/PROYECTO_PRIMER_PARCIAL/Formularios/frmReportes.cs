using PROYECTO_PRIMER_PARCIAL.LogicaNegocio;
using PROYECTO_PRIMER_PARCIAL.Modelo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PRIMER_PARCIAL.Formularios
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void validarFechas(DateOnly fechaDesde, DateOnly fechaHasta)
        {
            if (fechaDesde > fechaHasta)
            {
                throw new Exception("La fecha 'Desde' no puede ser mayor a la fecha 'Hasta'.");
            }
        }

        private void validarListaResevas()
        {
            if (Cl_LN_Reserva.listaReservas.Count == 0)
            {
                throw new Exception("No hay reservas registradas para generar el reporte.");
            }
        }

        private void GenerarReporteSimple()
        {
            try
            {
                dgvResumenLabs.Rows.Clear();
                DateOnly fechaDesde = DateOnly.FromDateTime(dtpFechaDesde.Value);
                DateOnly fechaHasta = DateOnly.FromDateTime(dtpFechaHasta.Value);

                validarFechas(fechaDesde, fechaHasta);
                validarListaResevas();

                int reservasEncontradas = 0;

                foreach (Cl_Reserva reserva in Cl_LN_Reserva.listaReservas)
                {
                    //filtro por rango de fechas
                    if (reserva.FechaReserva < fechaDesde || reserva.FechaReserva > fechaHasta)
                        continue;

                    reservasEncontradas++;

                    string nombreLaboratorio = reserva.Laboratorio.Nombre;
                    double horas = (reserva.HoraFinReserva.ToTimeSpan() -
                        reserva.HoraInicioReserva.ToTimeSpan()).TotalHours;

                    bool encontrado = false;

                    // 2. Buscar si el laboratorio ya está en el grid
                    foreach (DataGridViewRow fila in dgvResumenLabs.Rows)
                    {
                        if (fila.Cells["Laboratorio"].Value?.ToString() == nombreLaboratorio)
                        {
                            fila.Cells["TotalReservas"].Value =
                                Convert.ToInt32(fila.Cells["TotalReservas"].Value) + 1;
                            fila.Cells["HorasTotales"].Value =
                                Convert.ToDouble(fila.Cells["HorasTotales"].Value) + horas;
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        dgvResumenLabs.Rows.Add(nombreLaboratorio, 1, horas);
                    }
                }

                if (reservasEncontradas == 0)
                {
                    throw new Exception("No hay reservas en el rango de fechas seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            GenerarReporteSimple();
        }

    }
}

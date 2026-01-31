using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_PRIMER_PARCIAL.LogicaNegocio;
using PROYECTO_PRIMER_PARCIAL.Modelo;

namespace PROYECTO_PRIMER_PARCIAL.Formularios
{
    public partial class frmGestionLaboratorios : Form
    {
        private Cl_LN_Laboratorio ln_laboratorio = new Cl_LN_Laboratorio();
        private bool es_Laboratorio_nuevo = false;
        public frmGestionLaboratorios()
        {
            InitializeComponent();
            desactivar_controles();
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            CargarLaboratoriosGrid();
            txtID.Enabled = false;
        }

        private void activar_controles()
        {
            txtNombreLab.Enabled = true;
            nudCapacidad.Enabled = true;
            chkEstado.Enabled = true;
        }

        private void desactivar_controles()
        {
            txtNombreLab.Enabled = false;
            nudCapacidad.Enabled = false;
            chkEstado.Enabled = false;
        }
        private void limpiar_controles()
        {
            txtID.Text = string.Empty;
            txtNombreLab.Text = string.Empty;
            nudCapacidad.Value = 1;
            chkEstado.Checked = false;
        }

        private void CargarLaboratoriosGrid()
        {
            try
            {
                dgvLaboratorios.AutoGenerateColumns = false;
                dgvLaboratorios.DataSource = null;
                //verifica que existan laboratorios para cargarlos
                if (ln_laboratorio.getListaLaboratorios().Count > 0)
                {
                    dgvLaboratorios.DataSource = null;
                    dgvLaboratorios.DataSource = ln_laboratorio.getListaLaboratorios();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar_controles();
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            es_Laboratorio_nuevo = true;
            gbDatosLaboratorio.Text = "Datos del Laboratorio - CREANDO...";
            activar_controles();
            chkEstado.Enabled = true;
            chkEstado.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Crear un objeto de Tipo laboratorio
                Cl_Laboratorio obj_laboratorio = new Cl_Laboratorio();

                if (es_Laboratorio_nuevo)
                {
                    //si el laboratorio es nuevo, lo guarda
                    obj_laboratorio.ID = ln_laboratorio.GetNextID();
                    obj_laboratorio.Nombre = txtNombreLab.Text;
                    obj_laboratorio.Capacidad = int.Parse(nudCapacidad.Text);
                    obj_laboratorio.Estado = chkEstado.Checked;

                    ln_laboratorio.ValidarCampos(obj_laboratorio);
                    ln_laboratorio.ValidarDuplicados(obj_laboratorio);

                    ln_laboratorio.AgregarLaboratorio(obj_laboratorio);
                    MessageBox.Show("Laboratorio Creado con Éxito");
                    es_Laboratorio_nuevo = false;
                }
                else 
                {
                    //si el laboratorio no es nuevo, actualiza
                    obj_laboratorio.ID = int.Parse(txtID.Text);
                    obj_laboratorio.Nombre = txtNombreLab.Text;
                    obj_laboratorio.Capacidad = int.Parse(nudCapacidad.Text);
                    obj_laboratorio.Estado = chkEstado.Checked;
                    ln_laboratorio.ValidarCampos(obj_laboratorio);
                    ln_laboratorio.ValidarDuplicados(obj_laboratorio);
                    ln_laboratorio.ModificarLaboratorio(obj_laboratorio);

                    MessageBox.Show("Laboratorio Actualizado con Exito");
                    es_Laboratorio_nuevo = false;

                }

                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                btnNuevo.Enabled = true;
                gbDatosLaboratorio.Text = "Datos del Laboratorio";
                desactivar_controles();
                CargarLaboratoriosGrid();
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
                Cl_Laboratorio obj_laboratorio = new Cl_Laboratorio();
                obj_laboratorio.ID = int.Parse(txtID.Text);
                ln_laboratorio.EliminarLaboratorio(obj_laboratorio);

                limpiar_controles();
                desactivar_controles();

                CargarLaboratoriosGrid();
                dgvLaboratorios.ClearSelection();

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;

                MessageBox.Show("El laboratorio ha sido eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvLaboratorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se selecciona un laboratorio de la tabla para actualizar
            try
            {
                if (dgvLaboratorios.Rows.Count > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        //si se seleccion un laboratorio de la tabla, carga los datos en los controles
                        txtID.Text = dgvLaboratorios.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                        txtNombreLab.Text = dgvLaboratorios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                        nudCapacidad.Text = dgvLaboratorios.Rows[e.RowIndex].Cells["Capacidad"].Value.ToString();
                        chkEstado.Checked = bool.Parse(dgvLaboratorios.Rows[e.RowIndex].Cells["Estado"].Value.ToString());

                        btnNuevo.Enabled = false;
                        btnGuardar.Enabled = true;
                        btnEliminar.Enabled = true;
                        gbDatosLaboratorio.Text = "Datos del Laboratorio - ACTUALIZANDO";
                        activar_controles();
                        chkEstado.Enabled = true;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

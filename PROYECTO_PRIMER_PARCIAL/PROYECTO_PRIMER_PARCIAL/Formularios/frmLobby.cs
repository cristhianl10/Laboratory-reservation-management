using PROYECTO_PRIMER_PARCIAL.Formularios;

namespace PROYECTO_PRIMER_PARCIAL
{
    public partial class frmLobby : Form
    {
        public frmLobby()
        {
            InitializeComponent();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            frmGestionReservas formReservas = new frmGestionReservas();
            formReservas.ShowDialog();
        }

        private void btnLaboratorios_Click(object sender, EventArgs e)
        {
            frmGestionLaboratorios formLaboratorio = new frmGestionLaboratorios();
            formLaboratorio.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes formReportes = new frmReportes();
            formReportes.ShowDialog();
        }

        private void pcAgenda_Click(object sender, EventArgs e)
        {
            frmGestionReservas formGestionReservas = new frmGestionReservas();
            formGestionReservas.ShowDialog();
        }

        private void lblBotonReserva_Click(object sender, EventArgs e)
        {
            frmGestionReservas formReservas = new frmGestionReservas();
            formReservas.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmGestionLaboratorios formReservas = new frmGestionLaboratorios();
            formReservas.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmGestionLaboratorios formReservas = new frmGestionLaboratorios();
            formReservas.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmReportes formReservas = new frmReportes();
            formReservas.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmReportes formReservas = new frmReportes();
            formReservas.ShowDialog();
        }
    }
}

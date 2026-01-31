namespace PROYECTO_PRIMER_PARCIAL.Formularios
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnVolver = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            gbFiltros = new GroupBox();
            dtpFechaHasta = new DateTimePicker();
            label1 = new Label();
            dtpFechaDesde = new DateTimePicker();
            lblFechaDesde = new Label();
            btnGenerarReporte = new Button();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            dgvResumenLabs = new DataGridView();
            Laboratorio = new DataGridViewTextBoxColumn();
            TotalReservas = new DataGridViewTextBoxColumn();
            HorasTotales = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbFiltros.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumenLabs).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.System;
            btnVolver.Location = new Point(29, 34);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 34);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "← Volver ";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 103);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(689, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblSubtitulo.Location = new Point(291, 62);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(208, 20);
            lblSubtitulo.TabIndex = 10;
            lblSubtitulo.Text = "Datos de uso de Laboratorios";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(236, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(315, 40);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Reporte y Estadísticas";
            // 
            // gbFiltros
            // 
            gbFiltros.AutoSize = true;
            gbFiltros.Controls.Add(dtpFechaHasta);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Controls.Add(dtpFechaDesde);
            gbFiltros.Controls.Add(lblFechaDesde);
            gbFiltros.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFiltros.ImeMode = ImeMode.NoControl;
            gbFiltros.Location = new Point(100, 128);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(341, 193);
            gbFiltros.TabIndex = 4;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Rango de Fechas ";
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaHasta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(33, 127);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(214, 25);
            dtpFechaHasta.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 107);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 2;
            label1.Text = "Fecha Hasta:";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDesde.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(33, 65);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(214, 25);
            dtpFechaDesde.TabIndex = 1;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaDesde.Location = new Point(33, 45);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(85, 17);
            lblFechaDesde.TabIndex = 0;
            lblFechaDesde.Text = "Fecha Desde:";
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = SystemColors.MenuHighlight;
            btnGenerarReporte.Cursor = Cursors.Hand;
            btnGenerarReporte.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarReporte.Location = new Point(48, 80);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(148, 42);
            btnGenerarReporte.TabIndex = 5;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerarReporte);
            groupBox1.Location = new Point(455, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 191);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 611);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 50);
            panel2.TabIndex = 7;
            // 
            // dgvResumenLabs
            // 
            dgvResumenLabs.AllowUserToAddRows = false;
            dgvResumenLabs.AllowUserToResizeColumns = false;
            dgvResumenLabs.AllowUserToResizeRows = false;
            dgvResumenLabs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResumenLabs.BackgroundColor = Color.White;
            dgvResumenLabs.BorderStyle = BorderStyle.Fixed3D;
            dgvResumenLabs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvResumenLabs.Columns.AddRange(new DataGridViewColumn[] { Laboratorio, TotalReservas, HorasTotales });
            dgvResumenLabs.Location = new Point(100, 346);
            dgvResumenLabs.Name = "dgvResumenLabs";
            dgvResumenLabs.RowHeadersVisible = false;
            dgvResumenLabs.Size = new Size(583, 221);
            dgvResumenLabs.TabIndex = 8;
            // 
            // Laboratorio
            // 
            Laboratorio.DataPropertyName = "Laboratorios";
            Laboratorio.HeaderText = "Laboratorio";
            Laboratorio.Name = "Laboratorio";
            Laboratorio.ReadOnly = true;
            // 
            // TotalReservas
            // 
            TotalReservas.DataPropertyName = "Total Reservas";
            TotalReservas.HeaderText = "Total Reservas";
            TotalReservas.Name = "TotalReservas";
            TotalReservas.ReadOnly = true;
            // 
            // HorasTotales
            // 
            HorasTotales.DataPropertyName = "Horas Totales";
            dataGridViewCellStyle1.Format = "N2";
            HorasTotales.DefaultCellStyle = dataGridViewCellStyle1;
            HorasTotales.HeaderText = "Horas Totales";
            HorasTotales.Name = "HorasTotales";
            HorasTotales.ReadOnly = true;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 192);
            ClientSize = new Size(810, 661);
            Controls.Add(dgvResumenLabs);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(gbFiltros);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes y Estadísticas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResumenLabs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private GroupBox gbFiltros;
        private DateTimePicker dtpFechaDesde;
        private Label lblFechaDesde;
        private DateTimePicker dtpFechaHasta;
        private Label label1;
        private Button btnGenerarReporte;
        private GroupBox groupBox1;
        private Panel panel2;
        private DataGridView dgvResumenLabs;
        private DataGridViewTextBoxColumn Laboratorio;
        private DataGridViewTextBoxColumn TotalReservas;
        private DataGridViewTextBoxColumn HorasTotales;
    }
}
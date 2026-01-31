namespace PROYECTO_PRIMER_PARCIAL.Formularios
{
    partial class frmGestionReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionReservas));
            btnVolver = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panel2 = new Panel();
            gbDatosReserva = new GroupBox();
            txtID = new TextBox();
            lblID = new Label();
            nudNumEstudiantes = new NumericUpDown();
            lblNumeroEstudiantes = new Label();
            dtpHoraFin = new DateTimePicker();
            lblHoraFin = new Label();
            dtpHoraInicio = new DateTimePicker();
            lblHoraInicio = new Label();
            dtpFechaReserva = new DateTimePicker();
            label1 = new Label();
            cbLaboratorios = new ComboBox();
            lblLab = new Label();
            txtAsignatura = new TextBox();
            lblAsignatura = new Label();
            txtDocente = new TextBox();
            lblDocente = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            dgvReserva = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NombreDocente = new DataGridViewTextBoxColumn();
            NombreAsignatura = new DataGridViewTextBoxColumn();
            Laboratorio = new DataGridViewTextBoxColumn();
            FechaReserva = new DataGridViewTextBoxColumn();
            HoraInicioReserva = new DataGridViewTextBoxColumn();
            HoraFinReserva = new DataGridViewTextBoxColumn();
            CantidadEstudiantes = new DataGridViewTextBoxColumn();
            btnConsultaLaboratorio = new Button();
            btnConsultaFecha = new Button();
            btnMostrarTodo = new Button();
            dtpFiltroFechaReserva = new DateTimePicker();
            cbFiltroLab = new ComboBox();
            gbFiltro = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbDatosReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumEstudiantes).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReserva).BeginInit();
            gbFiltro.SuspendLayout();
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
            btnVolver.TabIndex = 1;
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
            panel1.Size = new Size(816, 103);
            panel1.TabIndex = 4;
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
            lblSubtitulo.Location = new Point(218, 59);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(324, 20);
            lblSubtitulo.TabIndex = 10;
            lblSubtitulo.Text = "Crea y Administra las reservas de Laboratorios";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(236, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(293, 40);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Gestión de Reservas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 643);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 10);
            panel2.TabIndex = 5;
            // 
            // gbDatosReserva
            // 
            gbDatosReserva.Controls.Add(txtID);
            gbDatosReserva.Controls.Add(lblID);
            gbDatosReserva.Controls.Add(nudNumEstudiantes);
            gbDatosReserva.Controls.Add(lblNumeroEstudiantes);
            gbDatosReserva.Controls.Add(dtpHoraFin);
            gbDatosReserva.Controls.Add(lblHoraFin);
            gbDatosReserva.Controls.Add(dtpHoraInicio);
            gbDatosReserva.Controls.Add(lblHoraInicio);
            gbDatosReserva.Controls.Add(dtpFechaReserva);
            gbDatosReserva.Controls.Add(label1);
            gbDatosReserva.Controls.Add(cbLaboratorios);
            gbDatosReserva.Controls.Add(lblLab);
            gbDatosReserva.Controls.Add(txtAsignatura);
            gbDatosReserva.Controls.Add(lblAsignatura);
            gbDatosReserva.Controls.Add(txtDocente);
            gbDatosReserva.Controls.Add(lblDocente);
            gbDatosReserva.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDatosReserva.Location = new Point(62, 109);
            gbDatosReserva.Name = "gbDatosReserva";
            gbDatosReserva.Size = new Size(480, 280);
            gbDatosReserva.TabIndex = 6;
            gbDatosReserva.TabStop = false;
            gbDatosReserva.Text = "Datos Reserva";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(56, 247);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 27);
            txtID.TabIndex = 17;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(27, 249);
            lblID.Name = "lblID";
            lblID.Size = new Size(23, 17);
            lblID.TabIndex = 16;
            lblID.Text = "ID:";
            // 
            // nudNumEstudiantes
            // 
            nudNumEstudiantes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudNumEstudiantes.Location = new Point(187, 214);
            nudNumEstudiantes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumEstudiantes.Name = "nudNumEstudiantes";
            nudNumEstudiantes.Size = new Size(149, 25);
            nudNumEstudiantes.TabIndex = 15;
            nudNumEstudiantes.TextAlign = HorizontalAlignment.Center;
            nudNumEstudiantes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNumeroEstudiantes
            // 
            lblNumeroEstudiantes.AutoSize = true;
            lblNumeroEstudiantes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroEstudiantes.Location = new Point(24, 216);
            lblNumeroEstudiantes.Name = "lblNumeroEstudiantes";
            lblNumeroEstudiantes.Size = new Size(157, 17);
            lblNumeroEstudiantes.TabIndex = 14;
            lblNumeroEstudiantes.Text = "Número de Estudiantes: *";
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHoraFin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHoraFin.Format = DateTimePickerFormat.Time;
            dtpHoraFin.Location = new Point(248, 179);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new Size(203, 25);
            dtpHoraFin.TabIndex = 13;
            // 
            // lblHoraFin
            // 
            lblHoraFin.AutoSize = true;
            lblHoraFin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraFin.Location = new Point(248, 159);
            lblHoraFin.Name = "lblHoraFin";
            lblHoraFin.Size = new Size(88, 17);
            lblHoraFin.TabIndex = 12;
            lblHoraFin.Text = "Hora de Fin: *";
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHoraInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHoraInicio.Format = DateTimePickerFormat.Time;
            dtpHoraInicio.Location = new Point(24, 179);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(203, 25);
            dtpHoraInicio.TabIndex = 11;
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraInicio.Location = new Point(24, 159);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(102, 17);
            lblHoraInicio.TabIndex = 10;
            lblHoraInicio.Text = "Hora de Inicio: *";
            // 
            // dtpFechaReserva
            // 
            dtpFechaReserva.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaReserva.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaReserva.Format = DateTimePickerFormat.Short;
            dtpFechaReserva.Location = new Point(249, 108);
            dtpFechaReserva.Name = "dtpFechaReserva";
            dtpFechaReserva.Size = new Size(203, 25);
            dtpFechaReserva.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 88);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 8;
            label1.Text = "Fecha Reserva: *";
            // 
            // cbLaboratorios
            // 
            cbLaboratorios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLaboratorios.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLaboratorios.FormattingEnabled = true;
            cbLaboratorios.Location = new Point(24, 108);
            cbLaboratorios.Name = "cbLaboratorios";
            cbLaboratorios.Size = new Size(203, 25);
            cbLaboratorios.TabIndex = 7;
            // 
            // lblLab
            // 
            lblLab.AutoSize = true;
            lblLab.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLab.Location = new Point(24, 88);
            lblLab.Name = "lblLab";
            lblLab.Size = new Size(135, 17);
            lblLab.TabIndex = 6;
            lblLab.Text = "Laboratorio (activo): *";
            // 
            // txtAsignatura
            // 
            txtAsignatura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAsignatura.Location = new Point(249, 55);
            txtAsignatura.MaxLength = 100;
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(203, 25);
            txtAsignatura.TabIndex = 5;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAsignatura.Location = new Point(249, 32);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(136, 17);
            lblAsignatura.TabIndex = 4;
            lblAsignatura.Text = "Asignatura / Motivo: *";
            // 
            // txtDocente
            // 
            txtDocente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocente.Location = new Point(24, 55);
            txtDocente.MaxLength = 100;
            txtDocente.Name = "txtDocente";
            txtDocente.Size = new Size(203, 25);
            txtDocente.TabIndex = 3;
            txtDocente.KeyPress += txtDocente_KeyPress;
            // 
            // lblDocente
            // 
            lblDocente.AutoSize = true;
            lblDocente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocente.Location = new Point(24, 32);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new Size(147, 17);
            lblDocente.TabIndex = 2;
            lblDocente.Text = "Docente Responsable: *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(428, 106);
            label2.Name = "label2";
            label2.Size = new Size(115, 13);
            label2.TabIndex = 16;
            label2.Text = "* Campos Obligatorios";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Location = new Point(548, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 279);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(41, 150);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 34);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "✘ Eliminar ";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(41, 204);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(137, 34);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Enabled = false;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(41, 97);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 34);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "✓ Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.CornflowerBlue;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(41, 45);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(137, 34);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "+ Nueva Reserva";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvReserva
            // 
            dgvReserva.AllowUserToAddRows = false;
            dgvReserva.AllowUserToDeleteRows = false;
            dgvReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReserva.BackgroundColor = Color.White;
            dgvReserva.BorderStyle = BorderStyle.Fixed3D;
            dgvReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserva.Columns.AddRange(new DataGridViewColumn[] { ID, NombreDocente, NombreAsignatura, Laboratorio, FechaReserva, HoraInicioReserva, HoraFinReserva, CantidadEstudiantes });
            dgvReserva.Location = new Point(62, 500);
            dgvReserva.MultiSelect = false;
            dgvReserva.Name = "dgvReserva";
            dgvReserva.ReadOnly = true;
            dgvReserva.RowHeadersVisible = false;
            dgvReserva.Size = new Size(704, 127);
            dgvReserva.TabIndex = 18;
            dgvReserva.CellClick += dgvReserva_CellClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.True;
            ID.Width = 50;
            // 
            // NombreDocente
            // 
            NombreDocente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NombreDocente.DataPropertyName = "NombreDocente";
            NombreDocente.HeaderText = "Docente Responsable";
            NombreDocente.Name = "NombreDocente";
            NombreDocente.ReadOnly = true;
            NombreDocente.Resizable = DataGridViewTriState.True;
            NombreDocente.Width = 160;
            // 
            // NombreAsignatura
            // 
            NombreAsignatura.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NombreAsignatura.DataPropertyName = "NombreAsignatura";
            NombreAsignatura.HeaderText = "Asignatura / Motivo";
            NombreAsignatura.Name = "NombreAsignatura";
            NombreAsignatura.ReadOnly = true;
            NombreAsignatura.Resizable = DataGridViewTriState.True;
            // 
            // Laboratorio
            // 
            Laboratorio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Laboratorio.DataPropertyName = "NombreLaboratorio";
            Laboratorio.HeaderText = "Nombre de Laboratorio";
            Laboratorio.Name = "Laboratorio";
            Laboratorio.ReadOnly = true;
            Laboratorio.Resizable = DataGridViewTriState.True;
            // 
            // FechaReserva
            // 
            FechaReserva.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FechaReserva.DataPropertyName = "FechaReserva";
            FechaReserva.HeaderText = "Fecha Reserva";
            FechaReserva.Name = "FechaReserva";
            FechaReserva.ReadOnly = true;
            FechaReserva.Resizable = DataGridViewTriState.True;
            // 
            // HoraInicioReserva
            // 
            HoraInicioReserva.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HoraInicioReserva.DataPropertyName = "HoraInicioReserva";
            HoraInicioReserva.HeaderText = "Hora de Inicio";
            HoraInicioReserva.Name = "HoraInicioReserva";
            HoraInicioReserva.ReadOnly = true;
            HoraInicioReserva.Resizable = DataGridViewTriState.True;
            HoraInicioReserva.Width = 80;
            // 
            // HoraFinReserva
            // 
            HoraFinReserva.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HoraFinReserva.DataPropertyName = "HoraFinReserva";
            HoraFinReserva.HeaderText = "Hora de Fin";
            HoraFinReserva.Name = "HoraFinReserva";
            HoraFinReserva.ReadOnly = true;
            HoraFinReserva.Resizable = DataGridViewTriState.True;
            HoraFinReserva.Width = 80;
            // 
            // CantidadEstudiantes
            // 
            CantidadEstudiantes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CantidadEstudiantes.DataPropertyName = "CantidadEstudiantes";
            CantidadEstudiantes.HeaderText = "Numero de Estudiantes";
            CantidadEstudiantes.Name = "CantidadEstudiantes";
            CantidadEstudiantes.ReadOnly = true;
            CantidadEstudiantes.Resizable = DataGridViewTriState.True;
            // 
            // btnConsultaLaboratorio
            // 
            btnConsultaLaboratorio.BackColor = Color.SeaShell;
            btnConsultaLaboratorio.Cursor = Cursors.Hand;
            btnConsultaLaboratorio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultaLaboratorio.Location = new Point(42, 24);
            btnConsultaLaboratorio.Name = "btnConsultaLaboratorio";
            btnConsultaLaboratorio.Size = new Size(157, 34);
            btnConsultaLaboratorio.TabIndex = 8;
            btnConsultaLaboratorio.Text = "Filtrar por laboratorio";
            btnConsultaLaboratorio.UseVisualStyleBackColor = false;
            btnConsultaLaboratorio.Click += btnConsultaLaboratorio_Click;
            // 
            // btnConsultaFecha
            // 
            btnConsultaFecha.BackColor = Color.Bisque;
            btnConsultaFecha.Cursor = Cursors.Hand;
            btnConsultaFecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultaFecha.Location = new Point(282, 24);
            btnConsultaFecha.Name = "btnConsultaFecha";
            btnConsultaFecha.Size = new Size(137, 34);
            btnConsultaFecha.TabIndex = 19;
            btnConsultaFecha.Text = "Filtrar por fecha";
            btnConsultaFecha.UseVisualStyleBackColor = false;
            btnConsultaFecha.Click += btnConsultaFecha_Click;
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.BackColor = Color.LightBlue;
            btnMostrarTodo.Cursor = Cursors.Hand;
            btnMostrarTodo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarTodo.Location = new Point(486, 24);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(137, 34);
            btnMostrarTodo.TabIndex = 20;
            btnMostrarTodo.Text = "Mostrar todo";
            btnMostrarTodo.UseVisualStyleBackColor = false;
            btnMostrarTodo.Click += btnMostrarTodo_Click;
            // 
            // dtpFiltroFechaReserva
            // 
            dtpFiltroFechaReserva.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFiltroFechaReserva.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFiltroFechaReserva.Format = DateTimePickerFormat.Short;
            dtpFiltroFechaReserva.Location = new Point(282, 64);
            dtpFiltroFechaReserva.Name = "dtpFiltroFechaReserva";
            dtpFiltroFechaReserva.Size = new Size(137, 25);
            dtpFiltroFechaReserva.TabIndex = 18;
            // 
            // cbFiltroLab
            // 
            cbFiltroLab.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltroLab.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFiltroLab.FormattingEnabled = true;
            cbFiltroLab.Location = new Point(42, 63);
            cbFiltroLab.Name = "cbFiltroLab";
            cbFiltroLab.Size = new Size(157, 25);
            cbFiltroLab.TabIndex = 21;
            // 
            // gbFiltro
            // 
            gbFiltro.Controls.Add(cbFiltroLab);
            gbFiltro.Controls.Add(btnMostrarTodo);
            gbFiltro.Controls.Add(dtpFiltroFechaReserva);
            gbFiltro.Controls.Add(btnConsultaLaboratorio);
            gbFiltro.Controls.Add(btnConsultaFecha);
            gbFiltro.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            gbFiltro.Location = new Point(62, 394);
            gbFiltro.Name = "gbFiltro";
            gbFiltro.Size = new Size(704, 100);
            gbFiltro.TabIndex = 22;
            gbFiltro.TabStop = false;
            gbFiltro.Text = "Filtros de búsqueda de Reserva";
            // 
            // frmGestionReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 200, 238);
            ClientSize = new Size(816, 653);
            Controls.Add(dgvReserva);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(gbDatosReserva);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(gbFiltro);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmGestionReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Reservas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbDatosReserva.ResumeLayout(false);
            gbDatosReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumEstudiantes).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReserva).EndInit();
            gbFiltro.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Panel panel2;
        private GroupBox gbDatosReserva;
        private TextBox txtDocente;
        private Label lblDocente;
        private Label lblLab;
        private TextBox txtAsignatura;
        private Label lblAsignatura;
        private Label label1;
        private ComboBox cbLaboratorios;
        private DateTimePicker dtpFechaReserva;
        private Label lblNumeroEstudiantes;
        private DateTimePicker dtpHoraFin;
        private Label lblHoraFin;
        private DateTimePicker dtpHoraInicio;
        private Label lblHoraInicio;
        private Label label2;
        private NumericUpDown nudNumEstudiantes;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dgvReserva;
        private Label lblID;
        private TextBox txtID;
        private Button btnConsultaLaboratorio;
        private Button btnConsultaFecha;
        private Button btnMostrarTodo;
        private DateTimePicker dtpFiltroFechaReserva;
        private ComboBox cbFiltroLab;
        private GroupBox gbFiltro;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NombreDocente;
        private DataGridViewTextBoxColumn NombreAsignatura;
        private DataGridViewTextBoxColumn Laboratorio;
        private DataGridViewTextBoxColumn FechaReserva;
        private DataGridViewTextBoxColumn HoraInicioReserva;
        private DataGridViewTextBoxColumn HoraFinReserva;
        private DataGridViewTextBoxColumn CantidadEstudiantes;
    }
}
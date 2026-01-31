namespace PROYECTO_PRIMER_PARCIAL.Formularios
{
    partial class frmGestionLaboratorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionLaboratorios));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            btnVolver = new Button();
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblSubtitulo = new Label();
            panel2 = new Panel();
            gbDatosLaboratorio = new GroupBox();
            txtID = new TextBox();
            label1 = new Label();
            chkEstado = new CheckBox();
            lblEstado = new Label();
            nudCapacidad = new NumericUpDown();
            lblCapacidad = new Label();
            txtNombreLab = new TextBox();
            lblNombre = new Label();
            gbBotones = new GroupBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            dgvLaboratorios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Capacidad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewCheckBoxColumn();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbDatosLaboratorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            gbBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorios).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(236, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(347, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Laboratorios";
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.System;
            btnVolver.Location = new Point(29, 34);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 34);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "← Volver ";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(btnVolver);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(810, 103);
            pnlHeader.TabIndex = 1;
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
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(234, 62);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(351, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Administra el catálogo de laboratorios disponibles";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 611);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 50);
            panel2.TabIndex = 2;
            // 
            // gbDatosLaboratorio
            // 
            gbDatosLaboratorio.Controls.Add(txtID);
            gbDatosLaboratorio.Controls.Add(label1);
            gbDatosLaboratorio.Controls.Add(chkEstado);
            gbDatosLaboratorio.Controls.Add(lblEstado);
            gbDatosLaboratorio.Controls.Add(nudCapacidad);
            gbDatosLaboratorio.Controls.Add(lblCapacidad);
            gbDatosLaboratorio.Controls.Add(txtNombreLab);
            gbDatosLaboratorio.Controls.Add(lblNombre);
            gbDatosLaboratorio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDatosLaboratorio.Location = new Point(77, 120);
            gbDatosLaboratorio.Name = "gbDatosLaboratorio";
            gbDatosLaboratorio.Size = new Size(322, 250);
            gbDatosLaboratorio.TabIndex = 3;
            gbDatosLaboratorio.TabStop = false;
            gbDatosLaboratorio.Text = "Datos del Laboratorio";
            // 
            // txtID
            // 
            txtID.Location = new Point(155, 29);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(132, 27);
            txtID.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 6;
            label1.Text = "ID del Laboratorio:";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkEstado.Location = new Point(32, 215);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(185, 21);
            chkEstado.TabIndex = 5;
            chkEstado.Text = "¿El laboratorio está activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(32, 186);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(51, 17);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado:";
            // 
            // nudCapacidad
            // 
            nudCapacidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCapacidad.Location = new Point(32, 149);
            nudCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(255, 25);
            nudCapacidad.TabIndex = 3;
            nudCapacidad.TextAlign = HorizontalAlignment.Center;
            nudCapacidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCapacidad.Location = new Point(30, 121);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(73, 17);
            lblCapacidad.TabIndex = 2;
            lblCapacidad.Text = "Capacidad:";
            // 
            // txtNombreLab
            // 
            txtNombreLab.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreLab.Location = new Point(30, 86);
            txtNombreLab.MaxLength = 100;
            txtNombreLab.Name = "txtNombreLab";
            txtNombreLab.Size = new Size(257, 25);
            txtNombreLab.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(30, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(155, 17);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Laboratorio:";
            // 
            // gbBotones
            // 
            gbBotones.Controls.Add(btnEliminar);
            gbBotones.Controls.Add(btnGuardar);
            gbBotones.Controls.Add(btnNuevo);
            gbBotones.Location = new Point(435, 120);
            gbBotones.Name = "gbBotones";
            gbBotones.Size = new Size(287, 250);
            gbBotones.TabIndex = 4;
            gbBotones.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(79, 168);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "X Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(79, 114);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "✓ Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.CornflowerBlue;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(79, 62);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(137, 34);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "+ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvLaboratorios
            // 
            dgvLaboratorios.AllowUserToAddRows = false;
            dgvLaboratorios.AllowUserToDeleteRows = false;
            dgvLaboratorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaboratorios.BackgroundColor = Color.White;
            dgvLaboratorios.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLaboratorios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLaboratorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaboratorios.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Capacidad, Estado });
            dgvLaboratorios.GridColor = Color.White;
            dgvLaboratorios.Location = new Point(77, 387);
            dgvLaboratorios.MultiSelect = false;
            dgvLaboratorios.Name = "dgvLaboratorios";
            dgvLaboratorios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvLaboratorios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvLaboratorios.RowHeadersVisible = false;
            dgvLaboratorios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLaboratorios.Size = new Size(645, 201);
            dgvLaboratorios.TabIndex = 5;
            dgvLaboratorios.CellClick += dgvLaboratorios_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Capacidad
            // 
            Capacidad.DataPropertyName = "Capacidad";
            Capacidad.HeaderText = "Capacidad";
            Capacidad.Name = "Capacidad";
            Capacidad.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Resizable = DataGridViewTriState.True;
            Estado.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmGestionLaboratorios
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 252, 240);
            ClientSize = new Size(810, 661);
            Controls.Add(dgvLaboratorios);
            Controls.Add(gbBotones);
            Controls.Add(gbDatosLaboratorio);
            Controls.Add(panel2);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmGestionLaboratorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Laboratorios";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbDatosLaboratorio.ResumeLayout(false);
            gbDatosLaboratorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            gbBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnVolver;
        private Panel pnlHeader;
        private Panel panel2;
        private Label lblSubtitulo;
        private PictureBox pictureBox1;
        private GroupBox gbDatosLaboratorio;
        private TextBox txtNombreLab;
        private Label lblNombre;
        private Label lblEstado;
        private NumericUpDown nudCapacidad;
        private Label lblCapacidad;
        private GroupBox gbBotones;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnEliminar;
        private DataGridView dgvLaboratorios;
        private CheckBox chkEstado;
        private TextBox txtID;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Capacidad;
        private DataGridViewCheckBoxColumn Estado;
    }
}
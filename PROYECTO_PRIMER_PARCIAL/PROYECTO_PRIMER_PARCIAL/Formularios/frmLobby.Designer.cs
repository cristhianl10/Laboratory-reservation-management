namespace PROYECTO_PRIMER_PARCIAL
{
    partial class frmLobby
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLobby));
            pnlHeader = new Panel();
            pictureBox3 = new PictureBox();
            pcUg = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            btnReservas = new Button();
            pcAgenda = new PictureBox();
            lblBotonReserva = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            btnLaboratorios = new Button();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            label3 = new Label();
            btnReportes = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcUg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcAgenda).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pictureBox3);
            pnlHeader.Controls.Add(pcUg);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(810, 159);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(573, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(217, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pcUg
            // 
            pcUg.Image = (Image)resources.GetObject("pcUg.Image");
            pcUg.Location = new Point(23, 35);
            pcUg.Name = "pcUg";
            pcUg.Size = new Size(155, 85);
            pcUg.SizeMode = PictureBoxSizeMode.Zoom;
            pcUg.TabIndex = 2;
            pcUg.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(249, 99);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(266, 21);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gestión de Laboratorios de Cómputo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(231, 54);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(321, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Reservas";
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.White;
            btnReservas.Cursor = Cursors.Hand;
            btnReservas.FlatAppearance.BorderSize = 0;
            btnReservas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservas.ForeColor = Color.Black;
            btnReservas.ImageAlign = ContentAlignment.BottomLeft;
            btnReservas.Location = new Point(209, 314);
            btnReservas.Name = "btnReservas";
            btnReservas.Padding = new Padding(50, 0, 0, 25);
            btnReservas.Size = new Size(343, 99);
            btnReservas.TabIndex = 1;
            btnReservas.Text = "Gestión de Reservas\r\n";
            btnReservas.UseVisualStyleBackColor = false;
            btnReservas.Click += btnReservas_Click;
            // 
            // pcAgenda
            // 
            pcAgenda.BackColor = Color.MediumSlateBlue;
            pcAgenda.BackgroundImageLayout = ImageLayout.None;
            pcAgenda.Cursor = Cursors.Hand;
            pcAgenda.Image = (Image)resources.GetObject("pcAgenda.Image");
            pcAgenda.Location = new Point(245, 340);
            pcAgenda.Name = "pcAgenda";
            pcAgenda.Size = new Size(45, 45);
            pcAgenda.SizeMode = PictureBoxSizeMode.StretchImage;
            pcAgenda.TabIndex = 2;
            pcAgenda.TabStop = false;
            pcAgenda.Click += pcAgenda_Click;
            // 
            // lblBotonReserva
            // 
            lblBotonReserva.AutoSize = true;
            lblBotonReserva.BackColor = Color.White;
            lblBotonReserva.Cursor = Cursors.Hand;
            lblBotonReserva.Location = new Point(314, 365);
            lblBotonReserva.Name = "lblBotonReserva";
            lblBotonReserva.Size = new Size(173, 15);
            lblBotonReserva.TabIndex = 3;
            lblBotonReserva.Text = "Crea, editar y consultar reservas";
            lblBotonReserva.Click += lblBotonReserva_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(240, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 55);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 561);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 100);
            panel2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(645, 63);
            label5.Name = "label5";
            label5.Size = new Size(145, 15);
            label5.TabIndex = 2;
            label5.Text = "Proyecto POE - GRUPO #8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(1024, 76);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 1;
            label4.Text = "v1.0.0 - 2025";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(255, 15);
            label1.TabIndex = 0;
            label1.Text = "Universidad de Guayaquil - Carrera de Software";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGreen;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(245, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(240, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 55);
            panel3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Cursor = Cursors.Hand;
            label2.Location = new Point(314, 260);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 8;
            label2.Text = "Administrar laboratorios";
            label2.Click += label2_Click;
            // 
            // btnLaboratorios
            // 
            btnLaboratorios.BackColor = Color.White;
            btnLaboratorios.Cursor = Cursors.Hand;
            btnLaboratorios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLaboratorios.ForeColor = Color.Black;
            btnLaboratorios.ImageAlign = ContentAlignment.BottomLeft;
            btnLaboratorios.Location = new Point(209, 209);
            btnLaboratorios.Name = "btnLaboratorios";
            btnLaboratorios.Padding = new Padding(90, 0, 0, 25);
            btnLaboratorios.Size = new Size(343, 99);
            btnLaboratorios.TabIndex = 6;
            btnLaboratorios.Text = "Gestión de Laboratorios";
            btnLaboratorios.UseVisualStyleBackColor = false;
            btnLaboratorios.Click += btnLaboratorios_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Coral;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(245, 445);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Coral;
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(240, 440);
            panel4.Name = "panel4";
            panel4.Size = new Size(55, 55);
            panel4.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Cursor = Cursors.Hand;
            label3.Location = new Point(314, 470);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 12;
            label3.Text = "Ver resumen de uso";
            label3.Click += label3_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.White;
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.Black;
            btnReportes.ImageAlign = ContentAlignment.BottomLeft;
            btnReportes.Location = new Point(209, 419);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(80, 0, 0, 25);
            btnReportes.Size = new Size(343, 99);
            btnReportes.TabIndex = 10;
            btnReportes.Text = "Reportes y Estadísticas ";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // frmLobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(810, 661);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(btnReportes);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(btnLaboratorios);
            Controls.Add(panel2);
            Controls.Add(pcAgenda);
            Controls.Add(panel1);
            Controls.Add(lblBotonReserva);
            Controls.Add(btnReservas);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmLobby";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor de Laboratorios";
            Load += frmLobby_Load;
            Paint += panel1_Paint;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcUg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcAgenda).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void frmLobby_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitulo;
        private PictureBox pcUg;
        private Label lblSubtitulo;
        private Button btnReservas;
        private PictureBox pcAgenda;
        private Label lblBotonReserva;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private Button btnLaboratorios;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label label3;
        private Button btnReportes;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label1;
        private Label label5;
    }
}

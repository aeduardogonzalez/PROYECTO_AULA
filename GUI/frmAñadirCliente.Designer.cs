﻿namespace GUI
{
    partial class frmAñadirCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAñadirCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtIdCiudad = new System.Windows.Forms.TextBox();
            this.cboxGenero = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxCiudad = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAnadirCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.ModificarDGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::GUI.Properties.Resources.fondo2;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtIdCiudad);
            this.groupBox1.Controls.Add(this.cboxGenero);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboxCiudad);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnAnadirCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPuntuacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgvConsulta);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1215, 708);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(137, 108);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(195, 22);
            this.txtCedula.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 264);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(744, 81);
            this.label11.TabIndex = 29;
            this.label11.Text = "Por favor digite en el cuadro de texto el campo por el que quiere consultar,\r\nLo " +
    "puede hacer Con la cédula, el género, la ciudad, el estado y la Fecha\r\nDe nacimi" +
    "ento del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.BackgroundImage = global::GUI.Properties.Resources.editar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(943, 318);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 82);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bell MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(0, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(355, 46);
            this.label10.TabIndex = 20;
            this.label10.Text = "Control De Cliente";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(319, 353);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtBuscar.TabIndex = 26;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(137, 154);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(195, 22);
            this.txtApellido.TabIndex = 13;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(519, 154);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(195, 22);
            this.txtDireccion.TabIndex = 15;
            // 
            // txtIdCiudad
            // 
            this.txtIdCiudad.Location = new System.Drawing.Point(1103, 10);
            this.txtIdCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCiudad.Name = "txtIdCiudad";
            this.txtIdCiudad.Size = new System.Drawing.Size(100, 22);
            this.txtIdCiudad.TabIndex = 28;
            this.txtIdCiudad.Visible = false;
            // 
            // cboxGenero
            // 
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboxGenero.Location = new System.Drawing.Point(903, 203);
            this.cboxGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(195, 24);
            this.cboxGenero.TabIndex = 22;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(589, 119);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(195, 22);
            this.dtpFechaNacimiento.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Direccion";
            // 
            // cboxCiudad
            // 
            this.cboxCiudad.FormattingEnabled = true;
            this.cboxCiudad.Location = new System.Drawing.Point(899, 155);
            this.cboxCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.cboxCiudad.Name = "cboxCiudad";
            this.cboxCiudad.Size = new System.Drawing.Size(195, 24);
            this.cboxCiudad.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::GUI.Properties.Resources.avance_rapido;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1071, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 82);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(800, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "Genero";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(984, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 27;
            this.txtId.Visible = false;
            // 
            // btnAnadirCliente
            // 
            this.btnAnadirCliente.BackColor = System.Drawing.Color.White;
            this.btnAnadirCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnadirCliente.BackgroundImage")));
            this.btnAnadirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnadirCliente.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnAnadirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnadirCliente.Location = new System.Drawing.Point(811, 318);
            this.btnAnadirCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadirCliente.Name = "btnAnadirCliente";
            this.btnAnadirCliente.Size = new System.Drawing.Size(117, 82);
            this.btnAnadirCliente.TabIndex = 24;
            this.btnAnadirCliente.UseVisualStyleBackColor = false;
            this.btnAnadirCliente.Click += new System.EventHandler(this.btnAnadirCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ciudad";
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Reportado",
            "En mora"});
            this.cboxEstado.Location = new System.Drawing.Point(899, 114);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(195, 24);
            this.cboxEstado.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "FechaNacimiento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 203);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Puntacion";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(519, 204);
            this.txtPuntuacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(195, 22);
            this.txtPuntuacion.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(805, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "Estado";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModificarDGV,
            this.Id,
            this.cedula,
            this.nombre,
            this.Apellido,
            this.FechaNacimiento,
            this.genero,
            this.direccion,
            this.puntuacion,
            this.estado,
            this.Id_Ciudad,
            this.ciudad});
            this.dgvConsulta.Location = new System.Drawing.Point(9, 417);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.Size = new System.Drawing.Size(1179, 281);
            this.dgvConsulta.TabIndex = 33;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // ModificarDGV
            // 
            this.ModificarDGV.HeaderText = "";
            this.ModificarDGV.MinimumWidth = 6;
            this.ModificarDGV.Name = "ModificarDGV";
            this.ModificarDGV.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "id del cliente";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cedula";
            this.cedula.MinimumWidth = 6;
            this.cedula.Name = "cedula";
            this.cedula.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.MinimumWidth = 6;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Width = 160;
            // 
            // genero
            // 
            this.genero.HeaderText = "Genero";
            this.genero.MinimumWidth = 6;
            this.genero.Name = "genero";
            this.genero.Width = 125;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.Width = 125;
            // 
            // puntuacion
            // 
            this.puntuacion.HeaderText = "Puntuacion";
            this.puntuacion.MinimumWidth = 6;
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // Id_Ciudad
            // 
            this.Id_Ciudad.HeaderText = "Id De La Ciudad";
            this.Id_Ciudad.MinimumWidth = 6;
            this.Id_Ciudad.Name = "Id_Ciudad";
            this.Id_Ciudad.Visible = false;
            this.Id_Ciudad.Width = 125;
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.MinimumWidth = 6;
            this.ciudad.Name = "ciudad";
            this.ciudad.Width = 125;
            // 
            // frmAñadirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 706);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAñadirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrediXpert";
            this.Load += new System.EventHandler(this.frmAñadirCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewButtonColumn ModificarDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntuacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnadirCliente;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboxCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cboxGenero;
        private System.Windows.Forms.TextBox txtIdCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
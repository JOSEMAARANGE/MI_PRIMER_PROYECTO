using LOGICA;

namespace MI_PRIMER_PROYECTO
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.DniTextbox = new System.Windows.Forms.TextBox();
            this.estudianteEnEdicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NombreTextbox = new System.Windows.Forms.TextBox();
            this.ApellidoTextbox = new System.Windows.Forms.TextBox();
            this.TelefonoTextbox = new System.Windows.Forms.TextBox();
            this.DniLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.estudianteGridView = new System.Windows.Forms.DataGridView();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeInscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaCursada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Logo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MateriaCursadaTextBox = new System.Windows.Forms.TextBox();
            this.MateriaCursadalabel = new System.Windows.Forms.Label();
            this.AprobadoComboBox = new System.Windows.Forms.ComboBox();
            this.AgregarBotton = new System.Windows.Forms.Button();
            this.CancelarBotton = new System.Windows.Forms.Button();
            this.lblMateriaAprobado = new System.Windows.Forms.Label();
            this.MateriasComboBox = new System.Windows.Forms.ComboBox();
            this.MateriasLabel = new System.Windows.Forms.Label();
            this.ModificarBotton = new System.Windows.Forms.Button();
            this.FechaDeInscripcionDateTime = new System.Windows.Forms.DateTimePicker();
            this.FechaDeInscripcionLabel = new System.Windows.Forms.Label();
            this.FechaDeNacimientoDateTime = new System.Windows.Forms.DateTimePicker();
            this.FechaDeNacimientoLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingNavigatorEstudiante = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteEnEdicionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteBindingSource)).BeginInit();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEstudiante)).BeginInit();
            this.bindingNavigatorEstudiante.SuspendLayout();
            this.SuspendLayout();
            // 
            // DniTextbox
            // 
            this.DniTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteEnEdicionBindingSource, "Dni", true));
            this.DniTextbox.Location = new System.Drawing.Point(206, 63);
            this.DniTextbox.Name = "DniTextbox";
            this.DniTextbox.Size = new System.Drawing.Size(200, 20);
            this.DniTextbox.TabIndex = 0;
            this.DniTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniTextbox_KeyPress);
            // 
            // estudianteEnEdicionBindingSource
            // 
            this.estudianteEnEdicionBindingSource.DataSource = typeof(LOGICA.Estudiante);
            this.estudianteEnEdicionBindingSource.Filter = "";
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteEnEdicionBindingSource, "Nombre", true));
            this.NombreTextbox.Location = new System.Drawing.Point(206, 99);
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.Size = new System.Drawing.Size(200, 20);
            this.NombreTextbox.TabIndex = 1;
            this.NombreTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTextbox_KeyPress);
            // 
            // ApellidoTextbox
            // 
            this.ApellidoTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteEnEdicionBindingSource, "Apellido", true));
            this.ApellidoTextbox.Location = new System.Drawing.Point(206, 139);
            this.ApellidoTextbox.Name = "ApellidoTextbox";
            this.ApellidoTextbox.Size = new System.Drawing.Size(200, 20);
            this.ApellidoTextbox.TabIndex = 2;
            this.ApellidoTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoTextbox_KeyPress);
            // 
            // TelefonoTextbox
            // 
            this.TelefonoTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteEnEdicionBindingSource, "Telefono", true));
            this.TelefonoTextbox.Location = new System.Drawing.Point(206, 180);
            this.TelefonoTextbox.Name = "TelefonoTextbox";
            this.TelefonoTextbox.Size = new System.Drawing.Size(200, 20);
            this.TelefonoTextbox.TabIndex = 3;
            this.TelefonoTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoTextbox_KeyPress);
            // 
            // DniLabel
            // 
            this.DniLabel.AutoSize = true;
            this.DniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniLabel.Location = new System.Drawing.Point(31, 71);
            this.DniLabel.Name = "DniLabel";
            this.DniLabel.Size = new System.Drawing.Size(37, 16);
            this.DniLabel.TabIndex = 4;
            this.DniLabel.Text = "DNI:";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(26, 103);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(76, 16);
            this.NombreLabel.TabIndex = 5;
            this.NombreLabel.Text = "NOMBRE:";
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoLabel.Location = new System.Drawing.Point(26, 143);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(83, 16);
            this.ApellidoLabel.TabIndex = 6;
            this.ApellidoLabel.Text = "APELLIDO:";
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(26, 184);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(91, 16);
            this.TelefonoLabel.TabIndex = 7;
            this.TelefonoLabel.Text = "TELEFONO:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(1227, 517);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // estudianteGridView
            // 
            this.estudianteGridView.AllowUserToAddRows = false;
            this.estudianteGridView.AllowUserToDeleteRows = false;
            this.estudianteGridView.AutoGenerateColumns = false;
            this.estudianteGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.estudianteGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.estudianteGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.estudianteGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.estudianteGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.MateriaActual,
            this.fechaDeNacimientoDataGridViewTextBoxColumn,
            this.fechaDeInscripcionDataGridViewTextBoxColumn,
            this.MateriaCursada});
            this.estudianteGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estudianteGridView.DataSource = this.EstudianteBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.estudianteGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.estudianteGridView.Location = new System.Drawing.Point(428, 72);
            this.estudianteGridView.Name = "estudianteGridView";
            this.estudianteGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.estudianteGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.estudianteGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.estudianteGridView.Size = new System.Drawing.Size(891, 430);
            this.estudianteGridView.TabIndex = 12;
            this.estudianteGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.estudianteGridView_CellContentDoubleClick);

            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniDataGridViewTextBoxColumn.Width = 48;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 69;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 74;
            // 
            // MateriaActual
            // 
            this.MateriaActual.DataPropertyName = "MateriaActual";
            this.MateriaActual.HeaderText = "MateriaActual";
            this.MateriaActual.Name = "MateriaActual";
            this.MateriaActual.ReadOnly = true;
            this.MateriaActual.Width = 97;
            // 
            // fechaDeNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaDeNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaDeNacimiento";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaDeNacimiento";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.Name = "fechaDeNacimientoDataGridViewTextBoxColumn";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDeNacimientoDataGridViewTextBoxColumn.Width = 129;
            // 
            // fechaDeInscripcionDataGridViewTextBoxColumn
            // 
            this.fechaDeInscripcionDataGridViewTextBoxColumn.DataPropertyName = "FechaDeInscripcion";
            this.fechaDeInscripcionDataGridViewTextBoxColumn.HeaderText = "FechaDeInscripcion";
            this.fechaDeInscripcionDataGridViewTextBoxColumn.Name = "fechaDeInscripcionDataGridViewTextBoxColumn";
            this.fechaDeInscripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDeInscripcionDataGridViewTextBoxColumn.Width = 127;
            // 
            // MateriaCursada
            // 
            this.MateriaCursada.DataPropertyName = "MateriaCursada";
            this.MateriaCursada.HeaderText = "MateriaCursada";
            this.MateriaCursada.Name = "MateriaCursada";
            this.MateriaCursada.ReadOnly = true;
            this.MateriaCursada.Width = 106;
            // 
            // EstudianteBindingSource
            // 
            this.EstudianteBindingSource.DataSource = typeof(LOGICA.Estudiante);
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logo.Controls.Add(this.label6);
            this.Logo.Controls.Add(this.pictureBox);
            this.Logo.Location = new System.Drawing.Point(2, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(1331, 63);
            this.Logo.TabIndex = 13;
            this.Logo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(476, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "ALTA DE ESTUDIANTES";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::MI_PRIMER_PROYECTO.Properties.Resources.OIP;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(0, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(141, 57);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.MateriaCursadaTextBox);
            this.groupBox1.Controls.Add(this.MateriaCursadalabel);
            this.groupBox1.Controls.Add(this.AprobadoComboBox);
            this.groupBox1.Controls.Add(this.AgregarBotton);
            this.groupBox1.Controls.Add(this.CancelarBotton);
            this.groupBox1.Controls.Add(this.lblMateriaAprobado);
            this.groupBox1.Controls.Add(this.MateriasComboBox);
            this.groupBox1.Controls.Add(this.MateriasLabel);
            this.groupBox1.Controls.Add(this.ModificarBotton);
            this.groupBox1.Controls.Add(this.FechaDeInscripcionDateTime);
            this.groupBox1.Controls.Add(this.FechaDeInscripcionLabel);
            this.groupBox1.Controls.Add(this.FechaDeNacimientoDateTime);
            this.groupBox1.Controls.Add(this.FechaDeNacimientoLabel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.DniTextbox);
            this.groupBox1.Controls.Add(this.DniLabel);
            this.groupBox1.Controls.Add(this.NombreTextbox);
            this.groupBox1.Controls.Add(this.ApellidoTextbox);
            this.groupBox1.Controls.Add(this.TelefonoTextbox);
            this.groupBox1.Controls.Add(this.NombreLabel);
            this.groupBox1.Controls.Add(this.ApellidoLabel);
            this.groupBox1.Controls.Add(this.TelefonoLabel);
            this.groupBox1.Location = new System.Drawing.Point(2, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 489);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // MateriaCursadaTextBox
            // 
            this.MateriaCursadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteEnEdicionBindingSource, "MateriaCursada", true));
            this.MateriaCursadaTextBox.Location = new System.Drawing.Point(206, 289);
            this.MateriaCursadaTextBox.Name = "MateriaCursadaTextBox";
            this.MateriaCursadaTextBox.Size = new System.Drawing.Size(200, 20);
            this.MateriaCursadaTextBox.TabIndex = 23;
            // 
            // MateriaCursadalabel
            // 
            this.MateriaCursadalabel.AutoSize = true;
            this.MateriaCursadalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MateriaCursadalabel.Location = new System.Drawing.Point(10, 289);
            this.MateriaCursadalabel.Name = "MateriaCursadalabel";
            this.MateriaCursadalabel.Size = new System.Drawing.Size(155, 16);
            this.MateriaCursadalabel.TabIndex = 22;
            this.MateriaCursadalabel.Text = "MATERIA CURSADA:";
            // 
            // AprobadoComboBox
            // 
            this.AprobadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EstudianteBindingSource, "MateriaAprobada", true));
            this.AprobadoComboBox.FormattingEnabled = true;
            this.AprobadoComboBox.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.AprobadoComboBox.Location = new System.Drawing.Point(330, 253);
            this.AprobadoComboBox.Name = "AprobadoComboBox";
            this.AprobadoComboBox.Size = new System.Drawing.Size(76, 21);
            this.AprobadoComboBox.TabIndex = 21;
            // 
            // AgregarBotton
            // 
            this.AgregarBotton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AgregarBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBotton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AgregarBotton.Location = new System.Drawing.Point(34, 442);
            this.AgregarBotton.Name = "AgregarBotton";
            this.AgregarBotton.Size = new System.Drawing.Size(90, 23);
            this.AgregarBotton.TabIndex = 20;
            this.AgregarBotton.Text = "AGREGAR";
            this.AgregarBotton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarBotton.UseVisualStyleBackColor = false;
            this.AgregarBotton.Click += new System.EventHandler(this.AgregarBotton_Click);
            // 
            // CancelarBotton
            // 
            this.CancelarBotton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelarBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarBotton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelarBotton.Location = new System.Drawing.Point(316, 441);
            this.CancelarBotton.Name = "CancelarBotton";
            this.CancelarBotton.Size = new System.Drawing.Size(90, 23);
            this.CancelarBotton.TabIndex = 19;
            this.CancelarBotton.Text = "CANCELAR";
            this.CancelarBotton.UseVisualStyleBackColor = false;
            this.CancelarBotton.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMateriaAprobado
            // 
            this.lblMateriaAprobado.AutoSize = true;
            this.lblMateriaAprobado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaAprobado.Location = new System.Drawing.Point(223, 258);
            this.lblMateriaAprobado.Name = "lblMateriaAprobado";
            this.lblMateriaAprobado.Size = new System.Drawing.Size(91, 16);
            this.lblMateriaAprobado.TabIndex = 18;
            this.lblMateriaAprobado.Text = "APROBADO";
            // 
            // MateriasComboBox
            // 
            this.MateriasComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "LENGUA",
            "MATEMATICA I",
            "MATEMATICA II"});
            this.MateriasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteEnEdicionBindingSource, "MateriaActual", true));
            this.MateriasComboBox.FormattingEnabled = true;
            this.MateriasComboBox.Items.AddRange(new object[] {
            "LENGUA",
            "MATEMATICA I",
            "MATEMATICA II"});
            this.MateriasComboBox.Location = new System.Drawing.Point(206, 226);
            this.MateriasComboBox.Name = "MateriasComboBox";
            this.MateriasComboBox.Size = new System.Drawing.Size(200, 21);
            this.MateriasComboBox.TabIndex = 16;
            // 
            // MateriasLabel
            // 
            this.MateriasLabel.AutoSize = true;
            this.MateriasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MateriasLabel.Location = new System.Drawing.Point(10, 231);
            this.MateriasLabel.Name = "MateriasLabel";
            this.MateriasLabel.Size = new System.Drawing.Size(141, 16);
            this.MateriasLabel.TabIndex = 15;
            this.MateriasLabel.Text = "MATERIA ACTUAL:";
            // 
            // ModificarBotton
            // 
            this.ModificarBotton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModificarBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarBotton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModificarBotton.Location = new System.Drawing.Point(206, 441);
            this.ModificarBotton.Name = "ModificarBotton";
            this.ModificarBotton.Size = new System.Drawing.Size(90, 23);
            this.ModificarBotton.TabIndex = 14;
            this.ModificarBotton.Text = "MODIFICAR";
            this.ModificarBotton.UseVisualStyleBackColor = false;
            this.ModificarBotton.Click += new System.EventHandler(this.BtnModificar_Click_1);
            // 
            // FechaDeInscripcionDateTime
            // 
            this.FechaDeInscripcionDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estudianteEnEdicionBindingSource, "FechaDeInscripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.FechaDeInscripcionDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteEnEdicionBindingSource, "FechaDeInscripcion", true));
            this.FechaDeInscripcionDateTime.Location = new System.Drawing.Point(206, 370);
            this.FechaDeInscripcionDateTime.Name = "FechaDeInscripcionDateTime";
            this.FechaDeInscripcionDateTime.Size = new System.Drawing.Size(200, 20);
            this.FechaDeInscripcionDateTime.TabIndex = 13;
            // 
            // FechaDeInscripcionLabel
            // 
            this.FechaDeInscripcionLabel.AutoSize = true;
            this.FechaDeInscripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeInscripcionLabel.Location = new System.Drawing.Point(6, 375);
            this.FechaDeInscripcionLabel.Name = "FechaDeInscripcionLabel";
            this.FechaDeInscripcionLabel.Size = new System.Drawing.Size(170, 15);
            this.FechaDeInscripcionLabel.TabIndex = 12;
            this.FechaDeInscripcionLabel.Text = "FECHA DE INSCRIPCION:";
            // 
            // FechaDeNacimientoDateTime
            // 
            this.FechaDeNacimientoDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estudianteEnEdicionBindingSource, "FechaDeNacimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.FechaDeNacimientoDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteEnEdicionBindingSource, "FechaDeNacimiento", true));
            this.FechaDeNacimientoDateTime.Location = new System.Drawing.Point(206, 326);
            this.FechaDeNacimientoDateTime.Name = "FechaDeNacimientoDateTime";
            this.FechaDeNacimientoDateTime.Size = new System.Drawing.Size(200, 20);
            this.FechaDeNacimientoDateTime.TabIndex = 11;
            // 
            // FechaDeNacimientoLabel
            // 
            this.FechaDeNacimientoLabel.AutoSize = true;
            this.FechaDeNacimientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeNacimientoLabel.Location = new System.Drawing.Point(10, 331);
            this.FechaDeNacimientoLabel.Name = "FechaDeNacimientoLabel";
            this.FechaDeNacimientoLabel.Size = new System.Drawing.Size(166, 15);
            this.FechaDeNacimientoLabel.TabIndex = 10;
            this.FechaDeNacimientoLabel.Text = "FECHA DE NACIMIENTO:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 57);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(48, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "COMPLETAR EL FORMULARIO";
            // 
            // bindingNavigatorEstudiante
            // 
            this.bindingNavigatorEstudiante.AddNewItem = null;
            this.bindingNavigatorEstudiante.BindingSource = this.EstudianteBindingSource;
            this.bindingNavigatorEstudiante.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorEstudiante.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorEstudiante.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorEstudiante.GripMargin = new System.Windows.Forms.Padding(50);
            this.bindingNavigatorEstudiante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorEstudiante.Location = new System.Drawing.Point(649, 515);
            this.bindingNavigatorEstudiante.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorEstudiante.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorEstudiante.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorEstudiante.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorEstudiante.Name = "bindingNavigatorEstudiante";
            this.bindingNavigatorEstudiante.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorEstudiante.Size = new System.Drawing.Size(330, 25);
            this.bindingNavigatorEstudiante.TabIndex = 16;
            this.bindingNavigatorEstudiante.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 549);
            this.Controls.Add(this.bindingNavigatorEstudiante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.estudianteGridView);
            this.Controls.Add(this.btnSalir);
            this.Name = "Formulario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estudianteEnEdicionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteBindingSource)).EndInit();
            this.Logo.ResumeLayout(false);
            this.Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEstudiante)).EndInit();
            this.bindingNavigatorEstudiante.ResumeLayout(false);
            this.bindingNavigatorEstudiante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DniTextbox;
        private System.Windows.Forms.TextBox NombreTextbox;
        private System.Windows.Forms.TextBox ApellidoTextbox;
        private System.Windows.Forms.TextBox TelefonoTextbox;
        private System.Windows.Forms.Label DniLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label ApellidoLabel;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView estudianteGridView;
        private System.Windows.Forms.GroupBox Logo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label FechaDeNacimientoLabel;
        private System.Windows.Forms.BindingSource EstudianteBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigatorEstudiante;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DateTimePicker FechaDeNacimientoDateTime;
        private System.Windows.Forms.DateTimePicker FechaDeInscripcionDateTime;
        private System.Windows.Forms.Label FechaDeInscripcionLabel;
        private System.Windows.Forms.BindingSource estudianteEnEdicionBindingSource;
        private System.Windows.Forms.Button ModificarBotton;
        private System.Windows.Forms.Label MateriasLabel;
        private System.Windows.Forms.ComboBox MateriasComboBox;
        private System.Windows.Forms.Label lblMateriaAprobado;
        private System.Windows.Forms.Button CancelarBotton;
        private System.Windows.Forms.Button AgregarBotton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeInscripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaCursada;
        private System.Windows.Forms.ComboBox AprobadoComboBox;
        private System.Windows.Forms.TextBox MateriaCursadaTextBox;
        private System.Windows.Forms.Label MateriaCursadalabel;
    }
}


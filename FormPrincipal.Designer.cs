namespace dbAccess_v1
{
    partial class FormPrincipal
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
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label tlfLabel;
            System.Windows.Forms.Label fecha_nacimientoLabel;
            System.Windows.Forms.Label dniLabel1;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel2;
            System.Windows.Forms.Label dni_profesorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tlfTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarAlum = new System.Windows.Forms.Button();
            this.btnGuardarAlum = new System.Windows.Forms.Button();
            this.btnElimAlum = new System.Windows.Forms.Button();
            this.btnModifAlum = new System.Windows.Forms.Button();
            this.btnAddAlum = new System.Windows.Forms.Button();
            this.btnAlumSalir = new System.Windows.Forms.Button();
            this.alumnosDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dniProfesorTb = new System.Windows.Forms.TextBox();
            this.nombreProfesorTextBox = new System.Windows.Forms.TextBox();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelProfe = new System.Windows.Forms.Button();
            this.btnGuardarProfe = new System.Windows.Forms.Button();
            this.btnElimProf = new System.Windows.Forms.Button();
            this.btnModifProf = new System.Windows.Forms.Button();
            this.btnAddProf = new System.Windows.Forms.Button();
            this.btnProfSalir = new System.Windows.Forms.Button();
            this.profesoresDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.idAsigTextBox = new System.Windows.Forms.TextBox();
            this.nombreAsigtb = new System.Windows.Forms.TextBox();
            this.dni_profesorAsigTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCacelAsig = new System.Windows.Forms.Button();
            this.btnGuardarAsig = new System.Windows.Forms.Button();
            this.btnElimAsig = new System.Windows.Forms.Button();
            this.btnModifAsig = new System.Windows.Forms.Button();
            this.btnAddAsig = new System.Windows.Forms.Button();
            this.btnAsigSalir = new System.Windows.Forms.Button();
            this.asignaturaDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewAlumnosFecha = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewProfesDep = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institutoDataSet = new dbAccess_v1.InstitutoDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosTableAdapter = new dbAccess_v1.InstitutoDataSetTableAdapters.AlumnosTableAdapter();
            this.tableAdapterManager = new dbAccess_v1.InstitutoDataSetTableAdapters.TableAdapterManager();
            this.asignaturaTableAdapter = new dbAccess_v1.InstitutoDataSetTableAdapters.AsignaturaTableAdapter();
            this.profesoresTableAdapter = new dbAccess_v1.InstitutoDataSetTableAdapters.ProfesoresTableAdapter();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            tlfLabel = new System.Windows.Forms.Label();
            fecha_nacimientoLabel = new System.Windows.Forms.Label();
            dniLabel1 = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel2 = new System.Windows.Forms.Label();
            dni_profesorLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnosFecha)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(25, 47);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(43, 19);
            dniLabel.TabIndex = 2;
            dniLabel.Text = "DNI:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(25, 80);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(76, 19);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(25, 113);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(84, 19);
            direccionLabel.TabIndex = 6;
            direccionLabel.Text = "Dirección:";
            // 
            // tlfLabel
            // 
            tlfLabel.AutoSize = true;
            tlfLabel.Location = new System.Drawing.Point(25, 146);
            tlfLabel.Name = "tlfLabel";
            tlfLabel.Size = new System.Drawing.Size(81, 19);
            tlfLabel.TabIndex = 8;
            tlfLabel.Text = "Tlf/Móvil:";
            // 
            // fecha_nacimientoLabel
            // 
            fecha_nacimientoLabel.AutoSize = true;
            fecha_nacimientoLabel.Location = new System.Drawing.Point(25, 180);
            fecha_nacimientoLabel.Name = "fecha_nacimientoLabel";
            fecha_nacimientoLabel.Size = new System.Drawing.Size(172, 19);
            fecha_nacimientoLabel.TabIndex = 10;
            fecha_nacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // dniLabel1
            // 
            dniLabel1.AutoSize = true;
            dniLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dniLabel1.Location = new System.Drawing.Point(19, 42);
            dniLabel1.Name = "dniLabel1";
            dniLabel1.Size = new System.Drawing.Size(43, 19);
            dniLabel1.TabIndex = 0;
            dniLabel1.Text = "DNI:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel1.Location = new System.Drawing.Point(19, 84);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(76, 19);
            nombreLabel1.TabIndex = 2;
            nombreLabel1.Text = "Nombre:";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departamentoLabel.Location = new System.Drawing.Point(19, 129);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(124, 19);
            departamentoLabel.TabIndex = 4;
            departamentoLabel.Text = "Departamento:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(16, 25);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 19);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // nombreLabel2
            // 
            nombreLabel2.AutoSize = true;
            nombreLabel2.Location = new System.Drawing.Point(16, 69);
            nombreLabel2.Name = "nombreLabel2";
            nombreLabel2.Size = new System.Drawing.Size(69, 19);
            nombreLabel2.TabIndex = 2;
            nombreLabel2.Text = "Nombre:";
            // 
            // dni_profesorLabel
            // 
            dni_profesorLabel.AutoSize = true;
            dni_profesorLabel.Location = new System.Drawing.Point(16, 113);
            dni_profesorLabel.Name = "dni_profesorLabel";
            dni_profesorLabel.Size = new System.Drawing.Size(100, 19);
            dni_profesorLabel.TabIndex = 4;
            dni_profesorLabel.Text = "DNI Profesor:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 673);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnCancelarAlum);
            this.tabPage1.Controls.Add(this.btnGuardarAlum);
            this.tabPage1.Controls.Add(this.btnElimAlum);
            this.tabPage1.Controls.Add(this.btnModifAlum);
            this.tabPage1.Controls.Add(this.btnAddAlum);
            this.tabPage1.Controls.Add(this.btnAlumSalir);
            this.tabPage1.Controls.Add(this.alumnosDataGridView);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Size = new System.Drawing.Size(1191, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ALUMNOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(719, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 342);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dniTextBox);
            this.panel1.Controls.Add(dniLabel);
            this.panel1.Controls.Add(this.direccionTextBox);
            this.panel1.Controls.Add(this.fecha_nacimientoDateTimePicker);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(fecha_nacimientoLabel);
            this.panel1.Controls.Add(tlfLabel);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(this.tlfTextBox);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 310);
            this.panel1.TabIndex = 13;
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(115, 39);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(201, 27);
            this.dniTextBox.TabIndex = 3;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(115, 105);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(201, 27);
            this.direccionTextBox.TabIndex = 7;
            // 
            // fecha_nacimientoDateTimePicker
            // 
            this.fecha_nacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alumnosBindingSource, "fecha_nacimiento", true));
            this.fecha_nacimientoDateTimePicker.Location = new System.Drawing.Point(207, 175);
            this.fecha_nacimientoDateTimePicker.Name = "fecha_nacimientoDateTimePicker";
            this.fecha_nacimientoDateTimePicker.Size = new System.Drawing.Size(201, 27);
            this.fecha_nacimientoDateTimePicker.TabIndex = 11;
            this.fecha_nacimientoDateTimePicker.Value = new System.DateTime(2018, 11, 15, 0, 0, 0, 0);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(115, 72);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(201, 27);
            this.nombreTextBox.TabIndex = 5;
            // 
            // tlfTextBox
            // 
            this.tlfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "tlf", true));
            this.tlfTextBox.Location = new System.Drawing.Point(115, 143);
            this.tlfTextBox.Name = "tlfTextBox";
            this.tlfTextBox.Size = new System.Drawing.Size(201, 27);
            this.tlfTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(24, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 64);
            this.label3.TabIndex = 30;
            this.label3.Text = "DATOS ALUMNOS";
            // 
            // btnCancelarAlum
            // 
            this.btnCancelarAlum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAlum.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCancelarAlum.Location = new System.Drawing.Point(955, 493);
            this.btnCancelarAlum.Name = "btnCancelarAlum";
            this.btnCancelarAlum.Size = new System.Drawing.Size(105, 36);
            this.btnCancelarAlum.TabIndex = 18;
            this.btnCancelarAlum.Text = "CANCELAR";
            this.btnCancelarAlum.UseVisualStyleBackColor = true;
            this.btnCancelarAlum.Visible = false;
            this.btnCancelarAlum.Click += new System.EventHandler(this.btnCancelarAlum_Click);
            // 
            // btnGuardarAlum
            // 
            this.btnGuardarAlum.Enabled = false;
            this.btnGuardarAlum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAlum.ForeColor = System.Drawing.Color.Chocolate;
            this.btnGuardarAlum.Location = new System.Drawing.Point(1077, 493);
            this.btnGuardarAlum.Name = "btnGuardarAlum";
            this.btnGuardarAlum.Size = new System.Drawing.Size(105, 36);
            this.btnGuardarAlum.TabIndex = 17;
            this.btnGuardarAlum.Text = "GUARDAR";
            this.btnGuardarAlum.UseVisualStyleBackColor = true;
            this.btnGuardarAlum.Click += new System.EventHandler(this.btnGuardarAlum_Click);
            // 
            // btnElimAlum
            // 
            this.btnElimAlum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimAlum.ForeColor = System.Drawing.Color.Chocolate;
            this.btnElimAlum.Location = new System.Drawing.Point(281, 504);
            this.btnElimAlum.Name = "btnElimAlum";
            this.btnElimAlum.Size = new System.Drawing.Size(105, 36);
            this.btnElimAlum.TabIndex = 16;
            this.btnElimAlum.Text = "ELIMINAR";
            this.btnElimAlum.UseVisualStyleBackColor = true;
            this.btnElimAlum.Click += new System.EventHandler(this.btnElimAlum_Click);
            // 
            // btnModifAlum
            // 
            this.btnModifAlum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifAlum.ForeColor = System.Drawing.Color.Chocolate;
            this.btnModifAlum.Location = new System.Drawing.Point(161, 504);
            this.btnModifAlum.Name = "btnModifAlum";
            this.btnModifAlum.Size = new System.Drawing.Size(105, 36);
            this.btnModifAlum.TabIndex = 15;
            this.btnModifAlum.Text = "MODIFICAR";
            this.btnModifAlum.UseVisualStyleBackColor = true;
            this.btnModifAlum.Click += new System.EventHandler(this.btnModifAlum_Click);
            // 
            // btnAddAlum
            // 
            this.btnAddAlum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlum.ForeColor = System.Drawing.Color.Chocolate;
            this.btnAddAlum.Location = new System.Drawing.Point(35, 504);
            this.btnAddAlum.Name = "btnAddAlum";
            this.btnAddAlum.Size = new System.Drawing.Size(105, 36);
            this.btnAddAlum.TabIndex = 14;
            this.btnAddAlum.Text = "AÑADIR";
            this.btnAddAlum.UseVisualStyleBackColor = true;
            this.btnAddAlum.Click += new System.EventHandler(this.btnAddAlum_Click);
            // 
            // btnAlumSalir
            // 
            this.btnAlumSalir.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAlumSalir.Location = new System.Drawing.Point(1063, 583);
            this.btnAlumSalir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAlumSalir.Name = "btnAlumSalir";
            this.btnAlumSalir.Size = new System.Drawing.Size(119, 49);
            this.btnAlumSalir.TabIndex = 1;
            this.btnAlumSalir.Text = "SALIR";
            this.btnAlumSalir.UseVisualStyleBackColor = true;
            this.btnAlumSalir.Click += new System.EventHandler(this.btnAlumSalir_Click);
            // 
            // alumnosDataGridView
            // 
            this.alumnosDataGridView.AutoGenerateColumns = false;
            this.alumnosDataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.alumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.alumnosDataGridView.DataSource = this.alumnosBindingSource;
            this.alumnosDataGridView.Location = new System.Drawing.Point(22, 145);
            this.alumnosDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.alumnosDataGridView.Name = "alumnosDataGridView";
            this.alumnosDataGridView.Size = new System.Drawing.Size(661, 342);
            this.alumnosDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnCancelProfe);
            this.tabPage2.Controls.Add(this.btnGuardarProfe);
            this.tabPage2.Controls.Add(this.btnElimProf);
            this.tabPage2.Controls.Add(this.btnModifProf);
            this.tabPage2.Controls.Add(this.btnAddProf);
            this.tabPage2.Controls.Add(this.btnProfSalir);
            this.tabPage2.Controls.Add(this.profesoresDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Size = new System.Drawing.Size(1191, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PROFESORES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(584, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 312);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profesor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(dniLabel1);
            this.panel2.Controls.Add(this.dniProfesorTb);
            this.panel2.Controls.Add(nombreLabel1);
            this.panel2.Controls.Add(this.nombreProfesorTextBox);
            this.panel2.Controls.Add(departamentoLabel);
            this.panel2.Controls.Add(this.departamentoTextBox);
            this.panel2.Location = new System.Drawing.Point(6, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 282);
            this.panel2.TabIndex = 3;
            // 
            // dniProfesorTb
            // 
            this.dniProfesorTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "dni", true));
            this.dniProfesorTb.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniProfesorTb.Location = new System.Drawing.Point(105, 35);
            this.dniProfesorTb.Name = "dniProfesorTb";
            this.dniProfesorTb.Size = new System.Drawing.Size(100, 27);
            this.dniProfesorTb.TabIndex = 1;
            // 
            // nombreProfesorTextBox
            // 
            this.nombreProfesorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "nombre", true));
            this.nombreProfesorTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProfesorTextBox.Location = new System.Drawing.Point(105, 80);
            this.nombreProfesorTextBox.Name = "nombreProfesorTextBox";
            this.nombreProfesorTextBox.Size = new System.Drawing.Size(100, 27);
            this.nombreProfesorTextBox.TabIndex = 3;
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "departamento", true));
            this.departamentoTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamentoTextBox.Location = new System.Drawing.Point(160, 126);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(127, 27);
            this.departamentoTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 64);
            this.label2.TabIndex = 30;
            this.label2.Text = "DATOS PROFESORES";
            // 
            // btnCancelProfe
            // 
            this.btnCancelProfe.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProfe.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelProfe.Location = new System.Drawing.Point(927, 483);
            this.btnCancelProfe.Name = "btnCancelProfe";
            this.btnCancelProfe.Size = new System.Drawing.Size(105, 36);
            this.btnCancelProfe.TabIndex = 23;
            this.btnCancelProfe.Text = "CANCELAR";
            this.btnCancelProfe.UseVisualStyleBackColor = true;
            this.btnCancelProfe.Visible = false;
            this.btnCancelProfe.Click += new System.EventHandler(this.btnCancelProfe_Click_1);
            // 
            // btnGuardarProfe
            // 
            this.btnGuardarProfe.Enabled = false;
            this.btnGuardarProfe.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProfe.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnGuardarProfe.Location = new System.Drawing.Point(1048, 483);
            this.btnGuardarProfe.Name = "btnGuardarProfe";
            this.btnGuardarProfe.Size = new System.Drawing.Size(105, 36);
            this.btnGuardarProfe.TabIndex = 22;
            this.btnGuardarProfe.Text = "GUARDAR";
            this.btnGuardarProfe.UseVisualStyleBackColor = true;
            this.btnGuardarProfe.Click += new System.EventHandler(this.btnGuardarProfe_Click);
            // 
            // btnElimProf
            // 
            this.btnElimProf.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimProf.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnElimProf.Location = new System.Drawing.Point(266, 483);
            this.btnElimProf.Name = "btnElimProf";
            this.btnElimProf.Size = new System.Drawing.Size(105, 36);
            this.btnElimProf.TabIndex = 21;
            this.btnElimProf.Text = "ELIMINAR";
            this.btnElimProf.UseVisualStyleBackColor = true;
            this.btnElimProf.Click += new System.EventHandler(this.btnElimProf_Click);
            // 
            // btnModifProf
            // 
            this.btnModifProf.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifProf.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnModifProf.Location = new System.Drawing.Point(146, 483);
            this.btnModifProf.Name = "btnModifProf";
            this.btnModifProf.Size = new System.Drawing.Size(105, 36);
            this.btnModifProf.TabIndex = 20;
            this.btnModifProf.Text = "MODIFICAR";
            this.btnModifProf.UseVisualStyleBackColor = true;
            this.btnModifProf.Click += new System.EventHandler(this.btnModifProf_Click);
            // 
            // btnAddProf
            // 
            this.btnAddProf.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProf.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnAddProf.Location = new System.Drawing.Point(24, 483);
            this.btnAddProf.Name = "btnAddProf";
            this.btnAddProf.Size = new System.Drawing.Size(105, 36);
            this.btnAddProf.TabIndex = 19;
            this.btnAddProf.Text = "AÑADIR";
            this.btnAddProf.UseVisualStyleBackColor = true;
            this.btnAddProf.Click += new System.EventHandler(this.btnAddProf_Click);
            // 
            // btnProfSalir
            // 
            this.btnProfSalir.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnProfSalir.Location = new System.Drawing.Point(1066, 583);
            this.btnProfSalir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnProfSalir.Name = "btnProfSalir";
            this.btnProfSalir.Size = new System.Drawing.Size(117, 49);
            this.btnProfSalir.TabIndex = 2;
            this.btnProfSalir.Text = "SALIR";
            this.btnProfSalir.UseVisualStyleBackColor = true;
            this.btnProfSalir.Click += new System.EventHandler(this.btnProfSalir_Click);
            // 
            // profesoresDataGridView
            // 
            this.profesoresDataGridView.AutoGenerateColumns = false;
            this.profesoresDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.profesoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profesoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.profesoresDataGridView.DataSource = this.profesoresBindingSource;
            this.profesoresDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.profesoresDataGridView.Location = new System.Drawing.Point(23, 152);
            this.profesoresDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.profesoresDataGridView.Name = "profesoresDataGridView";
            this.profesoresDataGridView.Size = new System.Drawing.Size(489, 310);
            this.profesoresDataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnCacelAsig);
            this.tabPage3.Controls.Add(this.btnGuardarAsig);
            this.tabPage3.Controls.Add(this.btnElimAsig);
            this.tabPage3.Controls.Add(this.btnModifAsig);
            this.tabPage3.Controls.Add(this.btnAddAsig);
            this.tabPage3.Controls.Add(this.btnAsigSalir);
            this.tabPage3.Controls.Add(this.asignaturaDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage3.Size = new System.Drawing.Size(1191, 641);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ASIGNATURAS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(535, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 270);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignatura";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(idLabel);
            this.panel3.Controls.Add(this.idAsigTextBox);
            this.panel3.Controls.Add(nombreLabel2);
            this.panel3.Controls.Add(this.nombreAsigtb);
            this.panel3.Controls.Add(dni_profesorLabel);
            this.panel3.Controls.Add(this.dni_profesorAsigTb);
            this.panel3.Location = new System.Drawing.Point(16, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 229);
            this.panel3.TabIndex = 3;
            // 
            // idAsigTextBox
            // 
            this.idAsigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asignaturaBindingSource, "Id", true));
            this.idAsigTextBox.Location = new System.Drawing.Point(122, 22);
            this.idAsigTextBox.Name = "idAsigTextBox";
            this.idAsigTextBox.Size = new System.Drawing.Size(57, 25);
            this.idAsigTextBox.TabIndex = 1;
            // 
            // nombreAsigtb
            // 
            this.nombreAsigtb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asignaturaBindingSource, "nombre", true));
            this.nombreAsigtb.Location = new System.Drawing.Point(122, 69);
            this.nombreAsigtb.Name = "nombreAsigtb";
            this.nombreAsigtb.Size = new System.Drawing.Size(137, 25);
            this.nombreAsigtb.TabIndex = 3;
            // 
            // dni_profesorAsigTb
            // 
            this.dni_profesorAsigTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asignaturaBindingSource, "dni_profesor", true));
            this.dni_profesorAsigTb.Location = new System.Drawing.Point(122, 107);
            this.dni_profesorAsigTb.Name = "dni_profesorAsigTb";
            this.dni_profesorAsigTb.Size = new System.Drawing.Size(137, 25);
            this.dni_profesorAsigTb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 64);
            this.label1.TabIndex = 29;
            this.label1.Text = "DATOS ASIGNATURAS";
            // 
            // btnCacelAsig
            // 
            this.btnCacelAsig.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCacelAsig.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCacelAsig.Location = new System.Drawing.Point(904, 446);
            this.btnCacelAsig.Name = "btnCacelAsig";
            this.btnCacelAsig.Size = new System.Drawing.Size(105, 36);
            this.btnCacelAsig.TabIndex = 28;
            this.btnCacelAsig.Text = "CANCELAR";
            this.btnCacelAsig.UseVisualStyleBackColor = true;
            this.btnCacelAsig.Visible = false;
            this.btnCacelAsig.Click += new System.EventHandler(this.btnCacelAsig_Click);
            // 
            // btnGuardarAsig
            // 
            this.btnGuardarAsig.Enabled = false;
            this.btnGuardarAsig.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsig.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarAsig.Location = new System.Drawing.Point(1033, 446);
            this.btnGuardarAsig.Name = "btnGuardarAsig";
            this.btnGuardarAsig.Size = new System.Drawing.Size(105, 36);
            this.btnGuardarAsig.TabIndex = 27;
            this.btnGuardarAsig.Text = "GUARDAR";
            this.btnGuardarAsig.UseVisualStyleBackColor = true;
            this.btnGuardarAsig.Click += new System.EventHandler(this.btnGuardarAsig_Click);
            // 
            // btnElimAsig
            // 
            this.btnElimAsig.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimAsig.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnElimAsig.Location = new System.Drawing.Point(352, 456);
            this.btnElimAsig.Name = "btnElimAsig";
            this.btnElimAsig.Size = new System.Drawing.Size(126, 36);
            this.btnElimAsig.TabIndex = 26;
            this.btnElimAsig.Text = "ELIMINAR";
            this.btnElimAsig.UseVisualStyleBackColor = true;
            this.btnElimAsig.Click += new System.EventHandler(this.btnElimAsig_Click);
            // 
            // btnModifAsig
            // 
            this.btnModifAsig.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifAsig.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModifAsig.Location = new System.Drawing.Point(201, 456);
            this.btnModifAsig.Name = "btnModifAsig";
            this.btnModifAsig.Size = new System.Drawing.Size(125, 36);
            this.btnModifAsig.TabIndex = 25;
            this.btnModifAsig.Text = "MODIFICAR";
            this.btnModifAsig.UseVisualStyleBackColor = true;
            // 
            // btnAddAsig
            // 
            this.btnAddAsig.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAsig.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddAsig.Location = new System.Drawing.Point(51, 456);
            this.btnAddAsig.Name = "btnAddAsig";
            this.btnAddAsig.Size = new System.Drawing.Size(131, 36);
            this.btnAddAsig.TabIndex = 24;
            this.btnAddAsig.Text = "AÑADIR";
            this.btnAddAsig.UseVisualStyleBackColor = true;
            this.btnAddAsig.Click += new System.EventHandler(this.btnAddAsig_Click);
            // 
            // btnAsigSalir
            // 
            this.btnAsigSalir.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsigSalir.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAsigSalir.Location = new System.Drawing.Point(1086, 582);
            this.btnAsigSalir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAsigSalir.Name = "btnAsigSalir";
            this.btnAsigSalir.Size = new System.Drawing.Size(96, 50);
            this.btnAsigSalir.TabIndex = 2;
            this.btnAsigSalir.Text = "SALIR";
            this.btnAsigSalir.UseVisualStyleBackColor = true;
            this.btnAsigSalir.Click += new System.EventHandler(this.btnAsigSalir_Click);
            // 
            // asignaturaDataGridView
            // 
            this.asignaturaDataGridView.AutoGenerateColumns = false;
            this.asignaturaDataGridView.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.asignaturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asignaturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.asignaturaDataGridView.DataSource = this.asignaturaBindingSource;
            this.asignaturaDataGridView.Location = new System.Drawing.Point(37, 170);
            this.asignaturaDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.asignaturaDataGridView.Name = "asignaturaDataGridView";
            this.asignaturaDataGridView.Size = new System.Drawing.Size(441, 270);
            this.asignaturaDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1191, 641);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CONSULTA1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView2);
            this.groupBox7.Location = new System.Drawing.Point(24, 336);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1083, 280);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Profesores del departamento de Lengua";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.departamentoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.profesoresBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(27, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(692, 193);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Location = new System.Drawing.Point(24, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1083, 280);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Alumnos mayores de 21 años";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alumnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(963, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1191, 641);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "CONSULTA2";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuscar);
            this.groupBox5.Controls.Add(this.dtpFecha2);
            this.groupBox5.Controls.Add(this.dtpFecha1);
            this.groupBox5.Controls.Add(this.dataGridViewAlumnosFecha);
            this.groupBox5.Location = new System.Drawing.Point(26, 346);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1124, 278);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alumnos fecha";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Location = new System.Drawing.Point(39, 134);
            this.dtpFecha2.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(252, 25);
            this.dtpFecha2.TabIndex = 5;
            this.dtpFecha2.Value = new System.DateTime(2019, 12, 16, 0, 0, 0, 0);
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Location = new System.Drawing.Point(39, 81);
            this.dtpFecha1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(252, 25);
            this.dtpFecha1.TabIndex = 4;
            this.dtpFecha1.Value = new System.DateTime(2019, 12, 16, 0, 0, 0, 0);
            // 
            // dataGridViewAlumnosFecha
            // 
            this.dataGridViewAlumnosFecha.AllowUserToAddRows = false;
            this.dataGridViewAlumnosFecha.AllowUserToDeleteRows = false;
            this.dataGridViewAlumnosFecha.AutoGenerateColumns = false;
            this.dataGridViewAlumnosFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnosFecha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn3,
            this.direccionDataGridViewTextBoxColumn1});
            this.dataGridViewAlumnosFecha.DataSource = this.alumnosBindingSource;
            this.dataGridViewAlumnosFecha.Location = new System.Drawing.Point(353, 50);
            this.dataGridViewAlumnosFecha.Name = "dataGridViewAlumnosFecha";
            this.dataGridViewAlumnosFecha.ReadOnly = true;
            this.dataGridViewAlumnosFecha.Size = new System.Drawing.Size(542, 190);
            this.dataGridViewAlumnosFecha.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewProfesDep);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.comboBoxDepartamento);
            this.groupBox4.Location = new System.Drawing.Point(26, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1124, 286);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Profesor por Departamento";
            // 
            // dataGridViewProfesDep
            // 
            this.dataGridViewProfesDep.AllowUserToAddRows = false;
            this.dataGridViewProfesDep.AllowUserToDeleteRows = false;
            this.dataGridViewProfesDep.AutoGenerateColumns = false;
            this.dataGridViewProfesDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfesDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn2,
            this.departamentoDataGridViewTextBoxColumn1});
            this.dataGridViewProfesDep.DataSource = this.profesoresBindingSource;
            this.dataGridViewProfesDep.Location = new System.Drawing.Point(353, 24);
            this.dataGridViewProfesDep.Name = "dataGridViewProfesDep";
            this.dataGridViewProfesDep.ReadOnly = true;
            this.dataGridViewProfesDep.Size = new System.Drawing.Size(394, 233);
            this.dataGridViewProfesDep.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Asignaturas";
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Items.AddRange(new object[] {
            "Lengua",
            "Matemáticas",
            "Informática"});
            this.comboBoxDepartamento.Location = new System.Drawing.Point(24, 79);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(230, 27);
            this.comboBoxDepartamento.TabIndex = 0;
            this.comboBoxDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartamento_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(39, 204);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.institutoDataSet;
            // 
            // institutoDataSet
            // 
            this.institutoDataSet.DataSetName = "InstitutoDataSet";
            this.institutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn1.HeaderText = "dni";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tlf";
            this.dataGridViewTextBoxColumn4.HeaderText = "tlf";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_nacimiento";
            this.dataGridViewTextBoxColumn5.HeaderText = "fecha_nacimiento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // profesoresBindingSource
            // 
            this.profesoresBindingSource.DataMember = "Profesores";
            this.profesoresBindingSource.DataSource = this.institutoDataSet;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn6.HeaderText = "dni";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "departamento";
            this.dataGridViewTextBoxColumn8.HeaderText = "departamento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // asignaturaBindingSource
            // 
            this.asignaturaBindingSource.DataMember = "Asignatura";
            this.asignaturaBindingSource.DataSource = this.institutoDataSet;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn10.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "dni_profesor";
            this.dataGridViewTextBoxColumn11.HeaderText = "dni_profesor";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dniDataGridViewTextBoxColumn1
            // 
            this.dniDataGridViewTextBoxColumn1.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn1.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn1.Name = "dniDataGridViewTextBoxColumn1";
            this.dniDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dniDataGridViewTextBoxColumn1.Width = 200;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn1.Width = 250;
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "departamento";
            this.departamentoDataGridViewTextBoxColumn.HeaderText = "departamento";
            this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            this.departamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.departamentoDataGridViewTextBoxColumn.Width = 200;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 250;
            // 
            // tlfDataGridViewTextBoxColumn
            // 
            this.tlfDataGridViewTextBoxColumn.DataPropertyName = "tlf";
            this.tlfDataGridViewTextBoxColumn.HeaderText = "tlf";
            this.tlfDataGridViewTextBoxColumn.Name = "tlfDataGridViewTextBoxColumn";
            this.tlfDataGridViewTextBoxColumn.ReadOnly = true;
            this.tlfDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            this.fechanacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechanacimientoDataGridViewTextBoxColumn.Width = 170;
            // 
            // nombreDataGridViewTextBoxColumn3
            // 
            this.nombreDataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn3.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn3.Name = "nombreDataGridViewTextBoxColumn3";
            this.nombreDataGridViewTextBoxColumn3.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn3.Width = 200;
            // 
            // direccionDataGridViewTextBoxColumn1
            // 
            this.direccionDataGridViewTextBoxColumn1.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn1.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn1.Name = "direccionDataGridViewTextBoxColumn1";
            this.direccionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn1.Width = 300;
            // 
            // nombreDataGridViewTextBoxColumn2
            // 
            this.nombreDataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn2.Name = "nombreDataGridViewTextBoxColumn2";
            this.nombreDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn2.Width = 150;
            // 
            // departamentoDataGridViewTextBoxColumn1
            // 
            this.departamentoDataGridViewTextBoxColumn1.DataPropertyName = "departamento";
            this.departamentoDataGridViewTextBoxColumn1.HeaderText = "departamento";
            this.departamentoDataGridViewTextBoxColumn1.Name = "departamentoDataGridViewTextBoxColumn1";
            this.departamentoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.departamentoDataGridViewTextBoxColumn1.Width = 200;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = this.alumnosTableAdapter;
            this.tableAdapterManager.AsignaturaTableAdapter = this.asignaturaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProfesoresTableAdapter = this.profesoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = dbAccess_v1.InstitutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // asignaturaTableAdapter
            // 
            this.asignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // profesoresTableAdapter
            // 
            this.profesoresTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 673);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSTITUTO ALMUNIER";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnosFecha)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private InstitutoDataSet institutoDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private InstitutoDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private InstitutoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView alumnosDataGridView;
        private InstitutoDataSetTableAdapters.ProfesoresTableAdapter profesoresTableAdapter;
        private System.Windows.Forms.BindingSource profesoresBindingSource;
        private System.Windows.Forms.DataGridView profesoresDataGridView;
        private InstitutoDataSetTableAdapters.AsignaturaTableAdapter asignaturaTableAdapter;
        private System.Windows.Forms.BindingSource asignaturaBindingSource;
        private System.Windows.Forms.Button btnAlumSalir;
        private System.Windows.Forms.Button btnProfSalir;
        private System.Windows.Forms.Button btnAsigSalir;
        private System.Windows.Forms.DataGridView asignaturaDataGridView;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacimientoDateTimePicker;
        private System.Windows.Forms.TextBox tlfTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Button btnCancelarAlum;
        private System.Windows.Forms.Button btnGuardarAlum;
        private System.Windows.Forms.Button btnElimAlum;
        private System.Windows.Forms.Button btnModifAlum;
        private System.Windows.Forms.Button btnAddAlum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelProfe;
        private System.Windows.Forms.Button btnGuardarProfe;
        private System.Windows.Forms.Button btnElimProf;
        private System.Windows.Forms.Button btnModifProf;
        private System.Windows.Forms.Button btnAddProf;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox dniProfesorTb;
        private System.Windows.Forms.TextBox nombreProfesorTextBox;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCacelAsig;
        private System.Windows.Forms.Button btnGuardarAsig;
        private System.Windows.Forms.Button btnElimAsig;
        private System.Windows.Forms.Button btnModifAsig;
        private System.Windows.Forms.Button btnAddAsig;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox idAsigTextBox;
        private System.Windows.Forms.TextBox nombreAsigtb;
        private System.Windows.Forms.TextBox dni_profesorAsigTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DataGridView dataGridViewAlumnosFecha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewProfesDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnBuscar;
    }
}


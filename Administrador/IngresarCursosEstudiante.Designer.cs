namespace CyberU.Administrador
{
    partial class IngresarCursosEstudiante
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarCursosEstudiante));
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.Cedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblCursosDisponibles = new System.Windows.Forms.Label();
            this.lblCursosInscritos = new System.Windows.Forms.Label();
            this.dataGridViewDisponibles = new System.Windows.Forms.DataGridView();
            this.pKIDCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matricula3DataSet = new CyberU.matricula3DataSet();
            this.dataGridViewInscritos = new System.Windows.Forms.DataGridView();
            this.fKCedulaEstudianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKIDCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estudiantesCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matricula3DataSetEstudiantesCursos = new CyberU.matricula3DataSetEstudiantesCursos();
            this.cursosTableAdapter = new CyberU.matricula3DataSetTableAdapters.CursosTableAdapter();
            this.estudiantes_CursosTableAdapter = new CyberU.matricula3DataSetEstudiantesCursosTableAdapters.Estudiantes_CursosTableAdapter();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.btnSalirApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetEstudiantesCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(67, 10);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 0;
            // 
            // Cedula
            // 
            this.Cedula.AutoSize = true;
            this.Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cedula.Location = new System.Drawing.Point(2, 10);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(59, 20);
            this.Cedula.TabIndex = 1;
            this.Cedula.Text = "Cédula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombre.Location = new System.Drawing.Point(173, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblcorreo.Location = new System.Drawing.Point(338, 11);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(55, 18);
            this.lblcorreo.TabIndex = 3;
            this.lblcorreo.Text = "Correo";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(232, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(399, 11);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(505, 9);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(765, 364);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblCursosDisponibles
            // 
            this.lblCursosDisponibles.AutoSize = true;
            this.lblCursosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCursosDisponibles.Location = new System.Drawing.Point(64, 72);
            this.lblCursosDisponibles.Name = "lblCursosDisponibles";
            this.lblCursosDisponibles.Size = new System.Drawing.Size(138, 18);
            this.lblCursosDisponibles.TabIndex = 10;
            this.lblCursosDisponibles.Text = "Cursos Disponibles";
            // 
            // lblCursosInscritos
            // 
            this.lblCursosInscritos.AutoSize = true;
            this.lblCursosInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCursosInscritos.Location = new System.Drawing.Point(641, 72);
            this.lblCursosInscritos.Name = "lblCursosInscritos";
            this.lblCursosInscritos.Size = new System.Drawing.Size(117, 18);
            this.lblCursosInscritos.TabIndex = 11;
            this.lblCursosInscritos.Text = "Cursos Inscritos";
            // 
            // dataGridViewDisponibles
            // 
            this.dataGridViewDisponibles.AutoGenerateColumns = false;
            this.dataGridViewDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKIDCursoDataGridViewTextBoxColumn,
            this.nombreCursoDataGridViewTextBoxColumn,
            this.precioCursoDataGridViewTextBoxColumn,
            this.inicioCursoDataGridViewTextBoxColumn,
            this.finalCursoDataGridViewTextBoxColumn,
            this.fKIDHorarioDataGridViewTextBoxColumn});
            this.dataGridViewDisponibles.DataSource = this.cursosBindingSource;
            this.dataGridViewDisponibles.Location = new System.Drawing.Point(6, 93);
            this.dataGridViewDisponibles.Name = "dataGridViewDisponibles";
            this.dataGridViewDisponibles.Size = new System.Drawing.Size(544, 182);
            this.dataGridViewDisponibles.TabIndex = 12;
            this.dataGridViewDisponibles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisponibles_CellDoubleClick);
            // 
            // pKIDCursoDataGridViewTextBoxColumn
            // 
            this.pKIDCursoDataGridViewTextBoxColumn.DataPropertyName = "PK_ID_Curso";
            this.pKIDCursoDataGridViewTextBoxColumn.HeaderText = "PK_ID_Curso";
            this.pKIDCursoDataGridViewTextBoxColumn.Name = "pKIDCursoDataGridViewTextBoxColumn";
            this.pKIDCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCursoDataGridViewTextBoxColumn
            // 
            this.nombreCursoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Curso";
            this.nombreCursoDataGridViewTextBoxColumn.HeaderText = "Nombre_Curso";
            this.nombreCursoDataGridViewTextBoxColumn.Name = "nombreCursoDataGridViewTextBoxColumn";
            // 
            // precioCursoDataGridViewTextBoxColumn
            // 
            this.precioCursoDataGridViewTextBoxColumn.DataPropertyName = "Precio_Curso";
            this.precioCursoDataGridViewTextBoxColumn.HeaderText = "Precio_Curso";
            this.precioCursoDataGridViewTextBoxColumn.Name = "precioCursoDataGridViewTextBoxColumn";
            // 
            // inicioCursoDataGridViewTextBoxColumn
            // 
            this.inicioCursoDataGridViewTextBoxColumn.DataPropertyName = "Inicio_Curso";
            this.inicioCursoDataGridViewTextBoxColumn.HeaderText = "Inicio_Curso";
            this.inicioCursoDataGridViewTextBoxColumn.Name = "inicioCursoDataGridViewTextBoxColumn";
            // 
            // finalCursoDataGridViewTextBoxColumn
            // 
            this.finalCursoDataGridViewTextBoxColumn.DataPropertyName = "Final_Curso";
            this.finalCursoDataGridViewTextBoxColumn.HeaderText = "Final_Curso";
            this.finalCursoDataGridViewTextBoxColumn.Name = "finalCursoDataGridViewTextBoxColumn";
            // 
            // fKIDHorarioDataGridViewTextBoxColumn
            // 
            this.fKIDHorarioDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_Horario";
            this.fKIDHorarioDataGridViewTextBoxColumn.HeaderText = "FK_ID_Horario";
            this.fKIDHorarioDataGridViewTextBoxColumn.Name = "fKIDHorarioDataGridViewTextBoxColumn";
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.matricula3DataSet;
            // 
            // matricula3DataSet
            // 
            this.matricula3DataSet.DataSetName = "matricula3DataSet";
            this.matricula3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewInscritos
            // 
            this.dataGridViewInscritos.AutoGenerateColumns = false;
            this.dataGridViewInscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fKCedulaEstudianteDataGridViewTextBoxColumn,
            this.fKIDCursoDataGridViewTextBoxColumn});
            this.dataGridViewInscritos.DataSource = this.estudiantesCursosBindingSource;
            this.dataGridViewInscritos.Location = new System.Drawing.Point(573, 93);
            this.dataGridViewInscritos.Name = "dataGridViewInscritos";
            this.dataGridViewInscritos.Size = new System.Drawing.Size(243, 182);
            this.dataGridViewInscritos.TabIndex = 13;
            // 
            // fKCedulaEstudianteDataGridViewTextBoxColumn
            // 
            this.fKCedulaEstudianteDataGridViewTextBoxColumn.DataPropertyName = "FK_Cedula_Estudiante";
            this.fKCedulaEstudianteDataGridViewTextBoxColumn.HeaderText = "FK_Cedula_Estudiante";
            this.fKCedulaEstudianteDataGridViewTextBoxColumn.Name = "fKCedulaEstudianteDataGridViewTextBoxColumn";
            // 
            // fKIDCursoDataGridViewTextBoxColumn
            // 
            this.fKIDCursoDataGridViewTextBoxColumn.DataPropertyName = "FK_ID_Curso";
            this.fKIDCursoDataGridViewTextBoxColumn.HeaderText = "FK_ID_Curso";
            this.fKIDCursoDataGridViewTextBoxColumn.Name = "fKIDCursoDataGridViewTextBoxColumn";
            // 
            // estudiantesCursosBindingSource
            // 
            this.estudiantesCursosBindingSource.DataMember = "Estudiantes_Cursos";
            this.estudiantesCursosBindingSource.DataSource = this.matricula3DataSetEstudiantesCursos;
            // 
            // matricula3DataSetEstudiantesCursos
            // 
            this.matricula3DataSetEstudiantesCursos.DataSetName = "matricula3DataSetEstudiantesCursos";
            this.matricula3DataSetEstudiantesCursos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // estudiantes_CursosTableAdapter
            // 
            this.estudiantes_CursosTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotal.Location = new System.Drawing.Point(694, 308);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPrecioTotal.Location = new System.Drawing.Point(762, 308);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(20, 24);
            this.lblPrecioTotal.TabIndex = 15;
            this.lblPrecioTotal.Text = "0";
            // 
            // btnSalirApp
            // 
            this.btnSalirApp.FlatAppearance.BorderSize = 0;
            this.btnSalirApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.btnSalirApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnSalirApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirApp.Location = new System.Drawing.Point(821, 4);
            this.btnSalirApp.Name = "btnSalirApp";
            this.btnSalirApp.Size = new System.Drawing.Size(28, 23);
            this.btnSalirApp.TabIndex = 41;
            this.btnSalirApp.Text = "X";
            this.btnSalirApp.UseVisualStyleBackColor = true;
            this.btnSalirApp.Click += new System.EventHandler(this.btnSalirApp_Click);
            // 
            // IngresarCursosEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(852, 389);
            this.Controls.Add(this.btnSalirApp);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridViewInscritos);
            this.Controls.Add(this.dataGridViewDisponibles);
            this.Controls.Add(this.lblCursosInscritos);
            this.Controls.Add(this.lblCursosDisponibles);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.txtCedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresarCursosEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarCursosEstudiante";
            this.Load += new System.EventHandler(this.IngresarCursosEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetEstudiantesCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label Cedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblCursosDisponibles;
        private System.Windows.Forms.Label lblCursosInscritos;
        private System.Windows.Forms.DataGridView dataGridViewDisponibles;
        private System.Windows.Forms.DataGridView dataGridViewInscritos;
        private matricula3DataSet matricula3DataSet;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private matricula3DataSetTableAdapters.CursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKIDCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDHorarioDataGridViewTextBoxColumn;
        private matricula3DataSetEstudiantesCursos matricula3DataSetEstudiantesCursos;
        private System.Windows.Forms.BindingSource estudiantesCursosBindingSource;
        private matricula3DataSetEstudiantesCursosTableAdapters.Estudiantes_CursosTableAdapter estudiantes_CursosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKCedulaEstudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKIDCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Button btnSalirApp;
    }
}
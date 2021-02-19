namespace CyberU.Administrador
{
    partial class Frm_ListaCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaCursos));
            this.btnSalirApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.matricula3DataSetCursos = new CyberU.matricula3DataSetCursos();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new CyberU.matricula3DataSetCursosTableAdapters.CursosTableAdapter();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.pKIDCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirApp
            // 
            this.btnSalirApp.FlatAppearance.BorderSize = 0;
            this.btnSalirApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.btnSalirApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnSalirApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirApp.Location = new System.Drawing.Point(393, 12);
            this.btnSalirApp.Name = "btnSalirApp";
            this.btnSalirApp.Size = new System.Drawing.Size(28, 23);
            this.btnSalirApp.TabIndex = 39;
            this.btnSalirApp.Text = "X";
            this.btnSalirApp.UseVisualStyleBackColor = true;
            this.btnSalirApp.Click += new System.EventHandler(this.btnSalirApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Aqui va lista de cursos con los horarios";
            // 
            // matricula3DataSetCursos
            // 
            this.matricula3DataSetCursos.DataSetName = "matricula3DataSetCursos";
            this.matricula3DataSetCursos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.matricula3DataSetCursos;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(269, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.AutoGenerateColumns = false;
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKIDCursoDataGridViewTextBoxColumn,
            this.nombreCursoDataGridViewTextBoxColumn,
            this.precioCursoDataGridViewTextBoxColumn,
            this.inicioCursoDataGridViewTextBoxColumn,
            this.finalCursoDataGridViewTextBoxColumn});
            this.dataGridViewCursos.DataSource = this.cursosBindingSource;
            this.dataGridViewCursos.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCursos.TabIndex = 43;
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
            // Frm_ListaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(429, 241);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListaCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ListaCursos";
            this.Load += new System.EventHandler(this.Frm_ListaCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirApp;
        private System.Windows.Forms.Label label1;
        private matricula3DataSetCursos matricula3DataSetCursos;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private matricula3DataSetCursosTableAdapters.CursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKIDCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalCursoDataGridViewTextBoxColumn;
    }
}
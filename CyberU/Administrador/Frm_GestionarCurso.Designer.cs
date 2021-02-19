namespace CyberU.Administrador
{
    partial class Frm_GestionarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionarCurso));
            this.btnSalirApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombreCurso = new System.Windows.Forms.TextBox();
            this.btnIngresarCurso = new System.Windows.Forms.Button();
            this.txtcodigoCurso = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.dateInicioCurso = new System.Windows.Forms.DateTimePicker();
            this.dateFinCurso = new System.Windows.Forms.DateTimePicker();
            this.matricula3DataSetHorarios = new CyberU.matricula3DataSetHorarios();
            this.horariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horariosTableAdapter = new CyberU.matricula3DataSetHorariosTableAdapters.HorariosTableAdapter();
            this.matricula3DataSetHorariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHorario = new System.Windows.Forms.Button();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.checkboxnuevo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetHorariosBindingSource)).BeginInit();
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
            this.btnSalirApp.Location = new System.Drawing.Point(482, 12);
            this.btnSalirApp.Name = "btnSalirApp";
            this.btnSalirApp.Size = new System.Drawing.Size(28, 23);
            this.btnSalirApp.TabIndex = 40;
            this.btnSalirApp.Text = "X";
            this.btnSalirApp.UseVisualStyleBackColor = true;
            this.btnSalirApp.Click += new System.EventHandler(this.btnSalirApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Código del curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre del curso";
            // 
            // txtnombreCurso
            // 
            this.txtnombreCurso.Location = new System.Drawing.Point(217, 84);
            this.txtnombreCurso.Name = "txtnombreCurso";
            this.txtnombreCurso.Size = new System.Drawing.Size(112, 20);
            this.txtnombreCurso.TabIndex = 46;
            // 
            // btnIngresarCurso
            // 
            this.btnIngresarCurso.BackColor = System.Drawing.Color.OldLace;
            this.btnIngresarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCurso.Location = new System.Drawing.Point(217, 251);
            this.btnIngresarCurso.Name = "btnIngresarCurso";
            this.btnIngresarCurso.Size = new System.Drawing.Size(112, 29);
            this.btnIngresarCurso.TabIndex = 47;
            this.btnIngresarCurso.Text = "Ingresar curso";
            this.btnIngresarCurso.UseVisualStyleBackColor = false;
            this.btnIngresarCurso.Click += new System.EventHandler(this.btnIngresarCurso_Click);
            // 
            // txtcodigoCurso
            // 
            this.txtcodigoCurso.Location = new System.Drawing.Point(217, 17);
            this.txtcodigoCurso.Name = "txtcodigoCurso";
            this.txtcodigoCurso.Size = new System.Drawing.Size(71, 20);
            this.txtcodigoCurso.TabIndex = 44;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrecio.Location = new System.Drawing.Point(30, 50);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 48;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(217, 52);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(71, 20);
            this.txtPrecio.TabIndex = 49;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInicio.Location = new System.Drawing.Point(30, 118);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(46, 20);
            this.lblInicio.TabIndex = 50;
            this.lblInicio.Text = "Inicio";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFin.Location = new System.Drawing.Point(30, 153);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(31, 20);
            this.lblFin.TabIndex = 51;
            this.lblFin.Text = "Fin";
            // 
            // dateInicioCurso
            // 
            this.dateInicioCurso.Location = new System.Drawing.Point(217, 117);
            this.dateInicioCurso.Name = "dateInicioCurso";
            this.dateInicioCurso.Size = new System.Drawing.Size(200, 20);
            this.dateInicioCurso.TabIndex = 52;
            // 
            // dateFinCurso
            // 
            this.dateFinCurso.Location = new System.Drawing.Point(217, 152);
            this.dateFinCurso.Name = "dateFinCurso";
            this.dateFinCurso.Size = new System.Drawing.Size(200, 20);
            this.dateFinCurso.TabIndex = 53;
            // 
            // matricula3DataSetHorarios
            // 
            this.matricula3DataSetHorarios.DataSetName = "matricula3DataSetHorarios";
            this.matricula3DataSetHorarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horariosBindingSource
            // 
            this.horariosBindingSource.DataMember = "Horarios";
            this.horariosBindingSource.DataSource = this.matricula3DataSetHorarios;
            // 
            // horariosTableAdapter
            // 
            this.horariosTableAdapter.ClearBeforeFill = true;
            // 
            // matricula3DataSetHorariosBindingSource
            // 
            this.matricula3DataSetHorariosBindingSource.DataSource = this.matricula3DataSetHorarios;
            this.matricula3DataSetHorariosBindingSource.Position = 0;
            // 
            // btnHorario
            // 
            this.btnHorario.BackColor = System.Drawing.Color.OldLace;
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.Location = new System.Drawing.Point(31, 186);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(65, 28);
            this.btnHorario.TabIndex = 47;
            this.btnHorario.Text = "Horario";
            this.btnHorario.UseVisualStyleBackColor = false;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(217, 194);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(71, 20);
            this.txtHorario.TabIndex = 44;
            // 
            // checkboxnuevo
            // 
            this.checkboxnuevo.AutoSize = true;
            this.checkboxnuevo.Location = new System.Drawing.Point(305, 18);
            this.checkboxnuevo.Name = "checkboxnuevo";
            this.checkboxnuevo.Size = new System.Drawing.Size(56, 17);
            this.checkboxnuevo.TabIndex = 54;
            this.checkboxnuevo.Text = "nuevo";
            this.checkboxnuevo.UseVisualStyleBackColor = true;
            this.checkboxnuevo.CheckedChanged += new System.EventHandler(this.checkboxnuevo_CheckedChanged);
            // 
            // Frm_GestionarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 305);
            this.Controls.Add(this.checkboxnuevo);
            this.Controls.Add(this.dateFinCurso);
            this.Controls.Add(this.dateInicioCurso);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnHorario);
            this.Controls.Add(this.btnIngresarCurso);
            this.Controls.Add(this.txtnombreCurso);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtcodigoCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_GestionarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_IngresoCurso";
            this.Load += new System.EventHandler(this.Frm_GestionarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetHorariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombreCurso;
        private System.Windows.Forms.Button btnIngresarCurso;
        private System.Windows.Forms.TextBox txtcodigoCurso;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dateInicioCurso;
        private System.Windows.Forms.DateTimePicker dateFinCurso;
        private matricula3DataSetHorarios matricula3DataSetHorarios;
        private System.Windows.Forms.BindingSource horariosBindingSource;
        private matricula3DataSetHorariosTableAdapters.HorariosTableAdapter horariosTableAdapter;
        private System.Windows.Forms.BindingSource matricula3DataSetHorariosBindingSource;
        private System.Windows.Forms.Button btnHorario;
        public System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.CheckBox checkboxnuevo;
    }
}
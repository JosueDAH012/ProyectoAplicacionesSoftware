namespace CyberU.Administrador
{
    partial class Horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horarios));
            this.gridviewHorarios = new System.Windows.Forms.DataGridView();
            this.pKIDHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula3DataSetHorariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matricula3DataSetHorarios = new CyberU.matricula3DataSetHorarios();
            this.matricula3DataSetHorariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.horariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horariosTableAdapter = new CyberU.matricula3DataSetHorariosTableAdapters.HorariosTableAdapter();
            this.btnSalirApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetHorariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetHorariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewHorarios
            // 
            this.gridviewHorarios.AutoGenerateColumns = false;
            this.gridviewHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKIDHorarioDataGridViewTextBoxColumn,
            this.inicioHorarioDataGridViewTextBoxColumn,
            this.finalHorarioDataGridViewTextBoxColumn});
            this.gridviewHorarios.DataMember = "Horarios";
            this.gridviewHorarios.DataSource = this.matricula3DataSetHorariosBindingSource;
            this.gridviewHorarios.Location = new System.Drawing.Point(12, 29);
            this.gridviewHorarios.Name = "gridviewHorarios";
            this.gridviewHorarios.Size = new System.Drawing.Size(342, 172);
            this.gridviewHorarios.TabIndex = 0;
            this.gridviewHorarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewHorarios_CellDoubleClick);
            // 
            // pKIDHorarioDataGridViewTextBoxColumn
            // 
            this.pKIDHorarioDataGridViewTextBoxColumn.DataPropertyName = "PK_ID_Horario";
            this.pKIDHorarioDataGridViewTextBoxColumn.HeaderText = "PK_ID_Horario";
            this.pKIDHorarioDataGridViewTextBoxColumn.Name = "pKIDHorarioDataGridViewTextBoxColumn";
            this.pKIDHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inicioHorarioDataGridViewTextBoxColumn
            // 
            this.inicioHorarioDataGridViewTextBoxColumn.DataPropertyName = "Inicio_Horario";
            this.inicioHorarioDataGridViewTextBoxColumn.HeaderText = "Inicio_Horario";
            this.inicioHorarioDataGridViewTextBoxColumn.Name = "inicioHorarioDataGridViewTextBoxColumn";
            // 
            // finalHorarioDataGridViewTextBoxColumn
            // 
            this.finalHorarioDataGridViewTextBoxColumn.DataPropertyName = "Final_Horario";
            this.finalHorarioDataGridViewTextBoxColumn.HeaderText = "Final_Horario";
            this.finalHorarioDataGridViewTextBoxColumn.Name = "finalHorarioDataGridViewTextBoxColumn";
            // 
            // matricula3DataSetHorariosBindingSource
            // 
            this.matricula3DataSetHorariosBindingSource.DataSource = this.matricula3DataSetHorarios;
            this.matricula3DataSetHorariosBindingSource.Position = 0;
            // 
            // matricula3DataSetHorarios
            // 
            this.matricula3DataSetHorarios.DataSetName = "matricula3DataSetHorarios";
            this.matricula3DataSetHorarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matricula3DataSetHorariosBindingSource1
            // 
            this.matricula3DataSetHorariosBindingSource1.DataSource = this.matricula3DataSetHorarios;
            this.matricula3DataSetHorariosBindingSource1.Position = 0;
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
            // btnSalirApp
            // 
            this.btnSalirApp.FlatAppearance.BorderSize = 0;
            this.btnSalirApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.btnSalirApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnSalirApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirApp.Location = new System.Drawing.Point(393, 2);
            this.btnSalirApp.Name = "btnSalirApp";
            this.btnSalirApp.Size = new System.Drawing.Size(28, 23);
            this.btnSalirApp.TabIndex = 40;
            this.btnSalirApp.Text = "X";
            this.btnSalirApp.UseVisualStyleBackColor = true;
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(422, 213);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalirApp);
            this.Controls.Add(this.gridviewHorarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetHorariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matricula3DataSetHorariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewHorarios;
        private System.Windows.Forms.BindingSource matricula3DataSetHorariosBindingSource;
        private matricula3DataSetHorarios matricula3DataSetHorarios;
        private System.Windows.Forms.BindingSource matricula3DataSetHorariosBindingSource1;
        private System.Windows.Forms.BindingSource horariosBindingSource;
        private matricula3DataSetHorariosTableAdapters.HorariosTableAdapter horariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKIDHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSalirApp;
    }
}
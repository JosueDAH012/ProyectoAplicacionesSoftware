namespace CyberU.Administrador
{
    partial class Frm_RegistroProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistroProfesor));
            this.btnSalirApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateFechaNacProf = new System.Windows.Forms.DateTimePicker();
            this.txtIdentificaProf = new System.Windows.Forms.TextBox();
            this.nombreProf = new System.Windows.Forms.TextBox();
            this.apellidoProf = new System.Windows.Forms.TextBox();
            this.CorreoProf = new System.Windows.Forms.TextBox();
            this.telefonoProf = new System.Windows.Forms.TextBox();
            this.usuarioProf = new System.Windows.Forms.TextBox();
            this.passwordProf = new System.Windows.Forms.TextBox();
            this.btnRegistarProf = new System.Windows.Forms.Button();
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
            this.btnSalirApp.Location = new System.Drawing.Point(458, 3);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Número de teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Contraseña";
            // 
            // dateFechaNacProf
            // 
            this.dateFechaNacProf.Location = new System.Drawing.Point(196, 162);
            this.dateFechaNacProf.Name = "dateFechaNacProf";
            this.dateFechaNacProf.Size = new System.Drawing.Size(200, 20);
            this.dateFechaNacProf.TabIndex = 48;
            // 
            // txtIdentificaProf
            // 
            this.txtIdentificaProf.Location = new System.Drawing.Point(196, 52);
            this.txtIdentificaProf.Name = "txtIdentificaProf";
            this.txtIdentificaProf.Size = new System.Drawing.Size(200, 20);
            this.txtIdentificaProf.TabIndex = 49;
            // 
            // nombreProf
            // 
            this.nombreProf.Location = new System.Drawing.Point(196, 89);
            this.nombreProf.Name = "nombreProf";
            this.nombreProf.Size = new System.Drawing.Size(200, 20);
            this.nombreProf.TabIndex = 50;
            // 
            // apellidoProf
            // 
            this.apellidoProf.Location = new System.Drawing.Point(196, 120);
            this.apellidoProf.Name = "apellidoProf";
            this.apellidoProf.Size = new System.Drawing.Size(200, 20);
            this.apellidoProf.TabIndex = 51;
            // 
            // CorreoProf
            // 
            this.CorreoProf.Location = new System.Drawing.Point(196, 201);
            this.CorreoProf.Name = "CorreoProf";
            this.CorreoProf.Size = new System.Drawing.Size(200, 20);
            this.CorreoProf.TabIndex = 52;
            // 
            // telefonoProf
            // 
            this.telefonoProf.Location = new System.Drawing.Point(196, 233);
            this.telefonoProf.Name = "telefonoProf";
            this.telefonoProf.Size = new System.Drawing.Size(200, 20);
            this.telefonoProf.TabIndex = 53;
            // 
            // usuarioProf
            // 
            this.usuarioProf.Location = new System.Drawing.Point(196, 275);
            this.usuarioProf.Name = "usuarioProf";
            this.usuarioProf.Size = new System.Drawing.Size(200, 20);
            this.usuarioProf.TabIndex = 54;
            // 
            // passwordProf
            // 
            this.passwordProf.Location = new System.Drawing.Point(196, 309);
            this.passwordProf.Name = "passwordProf";
            this.passwordProf.Size = new System.Drawing.Size(200, 20);
            this.passwordProf.TabIndex = 55;
            // 
            // btnRegistarProf
            // 
            this.btnRegistarProf.BackColor = System.Drawing.Color.OldLace;
            this.btnRegistarProf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistarProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarProf.Location = new System.Drawing.Point(317, 335);
            this.btnRegistarProf.Name = "btnRegistarProf";
            this.btnRegistarProf.Size = new System.Drawing.Size(79, 26);
            this.btnRegistarProf.TabIndex = 56;
            this.btnRegistarProf.Text = "Registrar";
            this.btnRegistarProf.UseVisualStyleBackColor = false;
            this.btnRegistarProf.Click += new System.EventHandler(this.btnRegistarProf_Click);
            // 
            // Frm_RegistroProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(489, 366);
            this.Controls.Add(this.btnRegistarProf);
            this.Controls.Add(this.passwordProf);
            this.Controls.Add(this.usuarioProf);
            this.Controls.Add(this.telefonoProf);
            this.Controls.Add(this.CorreoProf);
            this.Controls.Add(this.apellidoProf);
            this.Controls.Add(this.nombreProf);
            this.Controls.Add(this.txtIdentificaProf);
            this.Controls.Add(this.dateFechaNacProf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_RegistroProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_RegistroProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateFechaNacProf;
        private System.Windows.Forms.TextBox txtIdentificaProf;
        private System.Windows.Forms.TextBox nombreProf;
        private System.Windows.Forms.TextBox apellidoProf;
        private System.Windows.Forms.TextBox CorreoProf;
        private System.Windows.Forms.TextBox telefonoProf;
        private System.Windows.Forms.TextBox usuarioProf;
        private System.Windows.Forms.TextBox passwordProf;
        private System.Windows.Forms.Button btnRegistarProf;
    }
}
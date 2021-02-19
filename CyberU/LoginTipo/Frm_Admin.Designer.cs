namespace CyberU.LoginTipo
{
    partial class Frm_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Salir = new System.Windows.Forms.Button();
            this.button_Ingresar = new System.Windows.Forms.Button();
            this.txt_ingresa_contra = new System.Windows.Forms.TextBox();
            this.txt_ingresa_usuario = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salir.Location = new System.Drawing.Point(505, 188);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(69, 25);
            this.button_Salir.TabIndex = 15;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // button_Ingresar
            // 
            this.button_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ingresar.Location = new System.Drawing.Point(412, 188);
            this.button_Ingresar.Name = "button_Ingresar";
            this.button_Ingresar.Size = new System.Drawing.Size(87, 25);
            this.button_Ingresar.TabIndex = 14;
            this.button_Ingresar.Text = "Ingresar";
            this.button_Ingresar.UseVisualStyleBackColor = true;
            this.button_Ingresar.Click += new System.EventHandler(this.button_Ingresar_Click);
            // 
            // txt_ingresa_contra
            // 
            this.txt_ingresa_contra.Location = new System.Drawing.Point(412, 152);
            this.txt_ingresa_contra.Name = "txt_ingresa_contra";
            this.txt_ingresa_contra.PasswordChar = '*';
            this.txt_ingresa_contra.Size = new System.Drawing.Size(162, 20);
            this.txt_ingresa_contra.TabIndex = 13;
            this.txt_ingresa_contra.TextChanged += new System.EventHandler(this.txt_ingresa_contra_TextChanged);
            // 
            // txt_ingresa_usuario
            // 
            this.txt_ingresa_usuario.Location = new System.Drawing.Point(412, 107);
            this.txt_ingresa_usuario.Name = "txt_ingresa_usuario";
            this.txt_ingresa_usuario.Size = new System.Drawing.Size(162, 20);
            this.txt_ingresa_usuario.TabIndex = 12;
            this.txt_ingresa_usuario.TextChanged += new System.EventHandler(this.txt_ingresa_usuario_TextChanged);
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(279, 150);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(89, 21);
            this.lblContra.TabIndex = 11;
            this.lblContra.Text = "Contraseña";
            this.lblContra.Click += new System.EventHandler(this.lblContra_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(279, 107);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(113, 21);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Nombre Admin";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 231);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Ingresar);
            this.Controls.Add(this.txt_ingresa_contra);
            this.Controls.Add(this.txt_ingresa_usuario);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button button_Ingresar;
        private System.Windows.Forms.TextBox txt_ingresa_contra;
        private System.Windows.Forms.TextBox txt_ingresa_usuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblUsuario;
    }
}
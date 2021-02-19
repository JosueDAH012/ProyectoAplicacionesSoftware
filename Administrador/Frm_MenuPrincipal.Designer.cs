namespace CyberU.Administrador
{
    partial class Frm_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuPrincipal));
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.PanelmenuLateral = new System.Windows.Forms.Panel();
            this.btnSalirApp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelmenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.buttonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.Location = new System.Drawing.Point(444, 99);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(119, 33);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.Text = "Login";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // PanelmenuLateral
            // 
            this.PanelmenuLateral.AutoScroll = true;
            this.PanelmenuLateral.BackColor = System.Drawing.Color.White;
            this.PanelmenuLateral.Controls.Add(this.btnSalirApp);
            this.PanelmenuLateral.Controls.Add(this.pictureBox2);
            this.PanelmenuLateral.Controls.Add(this.buttonAdmin);
            this.PanelmenuLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelmenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelmenuLateral.Name = "PanelmenuLateral";
            this.PanelmenuLateral.Size = new System.Drawing.Size(588, 219);
            this.PanelmenuLateral.TabIndex = 2;
            // 
            // btnSalirApp
            // 
            this.btnSalirApp.FlatAppearance.BorderSize = 0;
            this.btnSalirApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnSalirApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSalirApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirApp.Location = new System.Drawing.Point(560, 1);
            this.btnSalirApp.Name = "btnSalirApp";
            this.btnSalirApp.Size = new System.Drawing.Size(28, 23);
            this.btnSalirApp.TabIndex = 9;
            this.btnSalirApp.Text = "X";
            this.btnSalirApp.UseVisualStyleBackColor = true;
            this.btnSalirApp.Click += new System.EventHandler(this.btnSalirApp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(414, 219);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 219);
            this.ControlBox = false;
            this.Controls.Add(this.PanelmenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.PanelmenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Panel PanelmenuLateral;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalirApp;
    }
}
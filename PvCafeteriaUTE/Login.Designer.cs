namespace PvCafeteriaUTE
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxlogin = new System.Windows.Forms.GroupBox();
            this.imgpass = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.imgpres2 = new System.Windows.Forms.PictureBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtbcontrasena = new System.Windows.Forms.TextBox();
            this.txtbusuario = new System.Windows.Forms.TextBox();
            this.imgpresentacion = new System.Windows.Forms.PictureBox();
            this.gboxlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpres2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxlogin
            // 
            this.gboxlogin.Controls.Add(this.imgpass);
            this.gboxlogin.Controls.Add(this.imguser);
            this.gboxlogin.Controls.Add(this.imgpres2);
            this.gboxlogin.Controls.Add(this.btncancelar);
            this.gboxlogin.Controls.Add(this.btnEntrar);
            this.gboxlogin.Controls.Add(this.txtbcontrasena);
            this.gboxlogin.Controls.Add(this.txtbusuario);
            this.gboxlogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxlogin.Location = new System.Drawing.Point(37, 147);
            this.gboxlogin.Name = "gboxlogin";
            this.gboxlogin.Size = new System.Drawing.Size(774, 339);
            this.gboxlogin.TabIndex = 0;
            this.gboxlogin.TabStop = false;
            this.gboxlogin.Text = "Login";
            this.gboxlogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // imgpass
            // 
            this.imgpass.BackColor = System.Drawing.Color.White;
            this.imgpass.BackgroundImage = global::PvCafeteria.Modelo.Properties.Resources.imgtxtpass;
            this.imgpass.ErrorImage = global::PvCafeteria.Modelo.Properties.Resources.imgtxtpass;
            this.imgpass.InitialImage = global::PvCafeteria.Modelo.Properties.Resources.imgtxtpass;
            this.imgpass.Location = new System.Drawing.Point(292, 105);
            this.imgpass.Name = "imgpass";
            this.imgpass.Size = new System.Drawing.Size(36, 36);
            this.imgpass.TabIndex = 6;
            this.imgpass.TabStop = false;
            // 
            // imguser
            // 
            this.imguser.BackColor = System.Drawing.Color.White;
            this.imguser.BackgroundImage = global::PvCafeteria.Modelo.Properties.Resources.imgtxtusuario;
            this.imguser.ErrorImage = global::PvCafeteria.Modelo.Properties.Resources.imgtxtusuario;
            this.imguser.InitialImage = global::PvCafeteria.Modelo.Properties.Resources.imgtxtusuario;
            this.imguser.Location = new System.Drawing.Point(292, 47);
            this.imguser.Name = "imguser";
            this.imguser.Size = new System.Drawing.Size(36, 36);
            this.imguser.TabIndex = 5;
            this.imguser.TabStop = false;
            // 
            // imgpres2
            // 
            this.imgpres2.Image = global::PvCafeteria.Modelo.Properties.Resources.sfsgsg;
            this.imgpres2.InitialImage = null;
            this.imgpres2.Location = new System.Drawing.Point(370, 16);
            this.imgpres2.Name = "imgpres2";
            this.imgpres2.Size = new System.Drawing.Size(398, 261);
            this.imgpres2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgpres2.TabIndex = 4;
            this.imgpres2.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::PvCafeteria.Modelo.Properties.Resources.cancelar1;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(192, 182);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(136, 38);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Image = global::PvCafeteria.Modelo.Properties.Resources.imgentrar1;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrar.Location = new System.Drawing.Point(53, 182);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(133, 38);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtbcontrasena
            // 
            this.txtbcontrasena.Location = new System.Drawing.Point(53, 105);
            this.txtbcontrasena.Multiline = true;
            this.txtbcontrasena.Name = "txtbcontrasena";
            this.txtbcontrasena.PasswordChar = '*';
            this.txtbcontrasena.Size = new System.Drawing.Size(275, 38);
            this.txtbcontrasena.TabIndex = 1;
            // 
            // txtbusuario
            // 
            this.txtbusuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbusuario.Location = new System.Drawing.Point(53, 47);
            this.txtbusuario.Multiline = true;
            this.txtbusuario.Name = "txtbusuario";
            this.txtbusuario.Size = new System.Drawing.Size(275, 38);
            this.txtbusuario.TabIndex = 0;
            // 
            // imgpresentacion
            // 
            this.imgpresentacion.Location = new System.Drawing.Point(37, 24);
            this.imgpresentacion.Name = "imgpresentacion";
            this.imgpresentacion.Size = new System.Drawing.Size(774, 105);
            this.imgpresentacion.TabIndex = 1;
            this.imgpresentacion.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(848, 516);
            this.ControlBox = false;
            this.Controls.Add(this.imgpresentacion);
            this.Controls.Add(this.gboxlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxlogin.ResumeLayout(false);
            this.gboxlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpres2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpresentacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtbcontrasena;
        private System.Windows.Forms.TextBox txtbusuario;
        private System.Windows.Forms.PictureBox imgpresentacion;
        private System.Windows.Forms.PictureBox imgpres2;
        private System.Windows.Forms.GroupBox gboxlogin;
        private System.Windows.Forms.PictureBox imgpass;
        private System.Windows.Forms.PictureBox imguser;
    }
}


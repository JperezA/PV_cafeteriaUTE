namespace PvCafeteria.Modelo
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.gboxDatos = new System.Windows.Forms.GroupBox();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.labefeccha = new System.Windows.Forms.Label();
            this.gboxModulos = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.menu1 = new System.Windows.Forms.Button();
            this.menu6 = new System.Windows.Forms.Button();
            this.menu5 = new System.Windows.Forms.Button();
            this.menu4 = new System.Windows.Forms.Button();
            this.menu3 = new System.Windows.Forms.Button();
            this.menu2 = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnayuda = new System.Windows.Forms.Button();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.gboxDatos.SuspendLayout();
            this.gboxModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxDatos
            // 
            this.gboxDatos.Controls.Add(this.label2);
            this.gboxDatos.Controls.Add(this.lbfecha);
            this.gboxDatos.Controls.Add(this.lbHora);
            this.gboxDatos.Controls.Add(this.label1);
            this.gboxDatos.Controls.Add(this.lbNombre);
            this.gboxDatos.Controls.Add(this.labefeccha);
            this.gboxDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDatos.Location = new System.Drawing.Point(386, 5);
            this.gboxDatos.Name = "gboxDatos";
            this.gboxDatos.Size = new System.Drawing.Size(476, 66);
            this.gboxDatos.TabIndex = 0;
            this.gboxDatos.TabStop = false;
            this.gboxDatos.Text = "Datos";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(158, 22);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(60, 20);
            this.lbfecha.TabIndex = 4;
            this.lbfecha.Text = "label2";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(354, 22);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(65, 20);
            this.lbHora.TabIndex = 3;
            this.lbHora.Text = "lbHora";
            this.lbHora.Click += new System.EventHandler(this.lbHora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(68, 42);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(84, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre: ";
            // 
            // labefeccha
            // 
            this.labefeccha.AutoSize = true;
            this.labefeccha.Location = new System.Drawing.Point(84, 22);
            this.labefeccha.Name = "labefeccha";
            this.labefeccha.Size = new System.Drawing.Size(68, 20);
            this.labefeccha.TabIndex = 0;
            this.labefeccha.Text = "Fecha: ";
            // 
            // gboxModulos
            // 
            this.gboxModulos.Controls.Add(this.btnsalir);
            this.gboxModulos.Controls.Add(this.menu1);
            this.gboxModulos.Controls.Add(this.menu6);
            this.gboxModulos.Controls.Add(this.menu5);
            this.gboxModulos.Controls.Add(this.menu4);
            this.gboxModulos.Controls.Add(this.menu3);
            this.gboxModulos.Controls.Add(this.menu2);
            this.gboxModulos.Location = new System.Drawing.Point(12, 70);
            this.gboxModulos.Name = "gboxModulos";
            this.gboxModulos.Size = new System.Drawing.Size(1254, 73);
            this.gboxModulos.TabIndex = 1;
            this.gboxModulos.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = global::PvCafeteria.Modelo.Properties.Resources.salir;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(1111, 7);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(143, 60);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.Transparent;
            this.menu1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menu1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.ForeColor = System.Drawing.Color.White;
            this.menu1.Image = ((System.Drawing.Image)(resources.GetObject("menu1.Image")));
            this.menu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu1.Location = new System.Drawing.Point(0, 7);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(178, 60);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "Ventas";
            this.menu1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu1.UseVisualStyleBackColor = false;
            this.menu1.Click += new System.EventHandler(this.menu1_Click);
            // 
            // menu6
            // 
            this.menu6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menu6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu6.Image = global::PvCafeteria.Modelo.Properties.Resources.config;
            this.menu6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu6.Location = new System.Drawing.Point(916, 7);
            this.menu6.Name = "menu6";
            this.menu6.Size = new System.Drawing.Size(178, 60);
            this.menu6.TabIndex = 5;
            this.menu6.Text = "Herramientas";
            this.menu6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu6.UseVisualStyleBackColor = true;
            this.menu6.Click += new System.EventHandler(this.menu6_Click);
            // 
            // menu5
            // 
            this.menu5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menu5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu5.Image = global::PvCafeteria.Modelo.Properties.Resources.f5invetario1;
            this.menu5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu5.Location = new System.Drawing.Point(732, 7);
            this.menu5.Name = "menu5";
            this.menu5.Size = new System.Drawing.Size(178, 60);
            this.menu5.TabIndex = 4;
            this.menu5.Text = "Inventario";
            this.menu5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu5.UseVisualStyleBackColor = true;
            // 
            // menu4
            // 
            this.menu4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menu4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu4.Image = global::PvCafeteria.Modelo.Properties.Resources.f4corte1;
            this.menu4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu4.Location = new System.Drawing.Point(548, 7);
            this.menu4.Name = "menu4";
            this.menu4.Size = new System.Drawing.Size(178, 60);
            this.menu4.TabIndex = 3;
            this.menu4.Text = "Corte";
            this.menu4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu4.UseVisualStyleBackColor = true;
            this.menu4.Click += new System.EventHandler(this.menu4_Click);
            // 
            // menu3
            // 
            this.menu3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menu3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu3.Image = global::PvCafeteria.Modelo.Properties.Resources.f3pedidos1;
            this.menu3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu3.Location = new System.Drawing.Point(364, 7);
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(178, 60);
            this.menu3.TabIndex = 2;
            this.menu3.Text = "Pedidos";
            this.menu3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu3.UseVisualStyleBackColor = true;
            this.menu3.Click += new System.EventHandler(this.menu3_Click);
            // 
            // menu2
            // 
            this.menu2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menu2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2.Image = global::PvCafeteria.Modelo.Properties.Resources.f2producto1;
            this.menu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2.Location = new System.Drawing.Point(180, 7);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(178, 60);
            this.menu2.TabIndex = 1;
            this.menu2.Text = "Productos";
            this.menu2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu2.UseVisualStyleBackColor = true;
            this.menu2.Click += new System.EventHandler(this.menu2_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(12, 140);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelContenedor.Size = new System.Drawing.Size(1265, 511);
            this.panelContenedor.TabIndex = 2;
            // 
            // logo
            // 
            this.logo.Image = global::PvCafeteria.Modelo.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(367, 66);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // btnayuda
            // 
            this.btnayuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnayuda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayuda.Image = global::PvCafeteria.Modelo.Properties.Resources.ayuda;
            this.btnayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnayuda.Location = new System.Drawing.Point(1123, 12);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnayuda.Size = new System.Drawing.Size(143, 60);
            this.btnayuda.TabIndex = 3;
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnayuda.UseVisualStyleBackColor = true;
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 663);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnayuda);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.gboxModulos);
            this.Controls.Add(this.gboxDatos);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.gboxDatos.ResumeLayout(false);
            this.gboxDatos.PerformLayout();
            this.gboxModulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDatos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label labefeccha;
        private System.Windows.Forms.GroupBox gboxModulos;
        private System.Windows.Forms.Button menu4;
        private System.Windows.Forms.Button menu3;
        private System.Windows.Forms.Button menu2;
        private System.Windows.Forms.Button menu1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button menu6;
        private System.Windows.Forms.Button menu5;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label label2;
    }
}
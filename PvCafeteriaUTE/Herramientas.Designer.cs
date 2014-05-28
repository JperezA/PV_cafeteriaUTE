namespace PvCafeteria.Modelo
{
    partial class Herramientas
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
            this.btnmod10 = new System.Windows.Forms.Button();
            this.btnmod9 = new System.Windows.Forms.Button();
            this.btnmod8 = new System.Windows.Forms.Button();
            this.btnmod7 = new System.Windows.Forms.Button();
            this.btnmod6 = new System.Windows.Forms.Button();
            this.panelherra = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnmod10
            // 
            this.btnmod10.Image = global::PvCafeteria.Modelo.Properties.Resources.pantalla;
            this.btnmod10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmod10.Location = new System.Drawing.Point(2, 254);
            this.btnmod10.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnmod10.Name = "btnmod10";
            this.btnmod10.Size = new System.Drawing.Size(178, 60);
            this.btnmod10.TabIndex = 9;
            this.btnmod10.Text = "Pantalla Cocina";
            this.btnmod10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmod10.UseVisualStyleBackColor = true;
            // 
            // btnmod9
            // 
            this.btnmod9.Image = global::PvCafeteria.Modelo.Properties.Resources.herramientas;
            this.btnmod9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmod9.Location = new System.Drawing.Point(2, 195);
            this.btnmod9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnmod9.Name = "btnmod9";
            this.btnmod9.Size = new System.Drawing.Size(178, 60);
            this.btnmod9.TabIndex = 8;
            this.btnmod9.Text = "Configuración";
            this.btnmod9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmod9.UseVisualStyleBackColor = true;
            this.btnmod9.Click += new System.EventHandler(this.btnmod9_Click);
            // 
            // btnmod8
            // 
            this.btnmod8.Image = global::PvCafeteria.Modelo.Properties.Resources.empleados;
            this.btnmod8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmod8.Location = new System.Drawing.Point(2, 135);
            this.btnmod8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnmod8.Name = "btnmod8";
            this.btnmod8.Size = new System.Drawing.Size(178, 60);
            this.btnmod8.TabIndex = 7;
            this.btnmod8.Text = "Empleados";
            this.btnmod8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmod8.UseVisualStyleBackColor = true;
            this.btnmod8.Click += new System.EventHandler(this.btnmod8_Click);
            // 
            // btnmod7
            // 
            this.btnmod7.Image = global::PvCafeteria.Modelo.Properties.Resources.clientes;
            this.btnmod7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmod7.Location = new System.Drawing.Point(2, 75);
            this.btnmod7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnmod7.Name = "btnmod7";
            this.btnmod7.Size = new System.Drawing.Size(178, 60);
            this.btnmod7.TabIndex = 6;
            this.btnmod7.Text = "Clientes";
            this.btnmod7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmod7.UseVisualStyleBackColor = true;
            this.btnmod7.Click += new System.EventHandler(this.btnmod7_Click);
            // 
            // btnmod6
            // 
            this.btnmod6.Image = global::PvCafeteria.Modelo.Properties.Resources.provee;
            this.btnmod6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmod6.Location = new System.Drawing.Point(2, 14);
            this.btnmod6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnmod6.Name = "btnmod6";
            this.btnmod6.Size = new System.Drawing.Size(178, 60);
            this.btnmod6.TabIndex = 5;
            this.btnmod6.Text = "Proveedores";
            this.btnmod6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmod6.UseVisualStyleBackColor = true;
            this.btnmod6.Click += new System.EventHandler(this.btnmod6_Click);
            // 
            // panelherra
            // 
            this.panelherra.Location = new System.Drawing.Point(189, 12);
            this.panelherra.Name = "panelherra";
            this.panelherra.Size = new System.Drawing.Size(1068, 646);
            this.panelherra.TabIndex = 10;
            // 
            // Herramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 670);
            this.Controls.Add(this.panelherra);
            this.Controls.Add(this.btnmod10);
            this.Controls.Add(this.btnmod9);
            this.Controls.Add(this.btnmod8);
            this.Controls.Add(this.btnmod7);
            this.Controls.Add(this.btnmod6);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Herramientas";
            this.Text = "Herramientas";
            this.Load += new System.EventHandler(this.Herramientas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelherra;
        private System.Windows.Forms.Button btnmod6;
        private System.Windows.Forms.Button btnmod7;
        private System.Windows.Forms.Button btnmod8;
        private System.Windows.Forms.Button btnmod9;
        private System.Windows.Forms.Button btnmod10;
    }
}
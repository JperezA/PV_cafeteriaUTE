namespace PvCafeteria.Modelo
{
    partial class nProducto
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
            this.btnNproducto = new System.Windows.Forms.Button();
            this.btnEproducto = new System.Windows.Forms.Button();
            this.btnRproductos = new System.Windows.Forms.Button();
            this.btnMproducto = new System.Windows.Forms.Button();
            this.panelPro = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNproducto
            // 
            this.btnNproducto.Image = global::PvCafeteria.Modelo.Properties.Resources.nuevo;
            this.btnNproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNproducto.Location = new System.Drawing.Point(3, 14);
            this.btnNproducto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNproducto.Name = "btnNproducto";
            this.btnNproducto.Size = new System.Drawing.Size(143, 40);
            this.btnNproducto.TabIndex = 0;
            this.btnNproducto.Text = "Nuevo";
            this.btnNproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNproducto.UseVisualStyleBackColor = true;
            this.btnNproducto.Click += new System.EventHandler(this.btnNproducto_Click);
            // 
            // btnEproducto
            // 
            this.btnEproducto.Image = global::PvCafeteria.Modelo.Properties.Resources.eliminar;
            this.btnEproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEproducto.Location = new System.Drawing.Point(3, 114);
            this.btnEproducto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEproducto.Name = "btnEproducto";
            this.btnEproducto.Size = new System.Drawing.Size(143, 40);
            this.btnEproducto.TabIndex = 2;
            this.btnEproducto.Text = "Eliminar";
            this.btnEproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEproducto.UseVisualStyleBackColor = true;
            // 
            // btnRproductos
            // 
            this.btnRproductos.Image = global::PvCafeteria.Modelo.Properties.Resources.reporte;
            this.btnRproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRproductos.Location = new System.Drawing.Point(3, 164);
            this.btnRproductos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRproductos.Name = "btnRproductos";
            this.btnRproductos.Size = new System.Drawing.Size(143, 40);
            this.btnRproductos.TabIndex = 3;
            this.btnRproductos.Text = "Reporte";
            this.btnRproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRproductos.UseVisualStyleBackColor = true;
            // 
            // btnMproducto
            // 
            this.btnMproducto.Image = global::PvCafeteria.Modelo.Properties.Resources.modificar;
            this.btnMproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMproducto.Location = new System.Drawing.Point(3, 64);
            this.btnMproducto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMproducto.Name = "btnMproducto";
            this.btnMproducto.Size = new System.Drawing.Size(143, 40);
            this.btnMproducto.TabIndex = 1;
            this.btnMproducto.Text = "Modificar";
            this.btnMproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMproducto.UseVisualStyleBackColor = true;
            // 
            // panelPro
            // 
            this.panelPro.Location = new System.Drawing.Point(155, 14);
            this.panelPro.Name = "panelPro";
            this.panelPro.Size = new System.Drawing.Size(1103, 666);
            this.panelPro.TabIndex = 4;
            // 
            // nProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 714);
            this.Controls.Add(this.panelPro);
            this.Controls.Add(this.btnRproductos);
            this.Controls.Add(this.btnEproducto);
            this.Controls.Add(this.btnMproducto);
            this.Controls.Add(this.btnNproducto);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "nProducto";
            this.Text = "nProducto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNproducto;
        private System.Windows.Forms.Button btnMproducto;
        private System.Windows.Forms.Button btnEproducto;
        private System.Windows.Forms.Button btnRproductos;
        private System.Windows.Forms.Panel panelPro;
    }
}
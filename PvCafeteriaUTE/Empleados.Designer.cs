namespace PvCafeteria.Modelo
{
    partial class Empleados
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
            this.panelCon = new System.Windows.Forms.Panel();
            this.btnNempl = new System.Windows.Forms.Button();
            this.btnMempl = new System.Windows.Forms.Button();
            this.btnEempl = new System.Windows.Forms.Button();
            this.btnRempl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelCon
            // 
            this.panelCon.Location = new System.Drawing.Point(1, 40);
            this.panelCon.Name = "panelCon";
            this.panelCon.Size = new System.Drawing.Size(1051, 671);
            this.panelCon.TabIndex = 0;
            // 
            // btnNempl
            // 
            this.btnNempl.Image = global::PvCafeteria.Modelo.Properties.Resources.nuevo;
            this.btnNempl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNempl.Location = new System.Drawing.Point(1, 0);
            this.btnNempl.Name = "btnNempl";
            this.btnNempl.Size = new System.Drawing.Size(143, 40);
            this.btnNempl.TabIndex = 1;
            this.btnNempl.Text = "Nuevo";
            this.btnNempl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNempl.UseVisualStyleBackColor = true;
            this.btnNempl.Click += new System.EventHandler(this.btnNuevoEmpl_Click);
            // 
            // btnMempl
            // 
            this.btnMempl.Image = global::PvCafeteria.Modelo.Properties.Resources.modificar;
            this.btnMempl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMempl.Location = new System.Drawing.Point(150, 0);
            this.btnMempl.Name = "btnMempl";
            this.btnMempl.Size = new System.Drawing.Size(143, 40);
            this.btnMempl.TabIndex = 2;
            this.btnMempl.Text = "Modificar";
            this.btnMempl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMempl.UseVisualStyleBackColor = true;
            this.btnMempl.Click += new System.EventHandler(this.btnMempl_Click);
            // 
            // btnEempl
            // 
            this.btnEempl.Image = global::PvCafeteria.Modelo.Properties.Resources.eliminar;
            this.btnEempl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEempl.Location = new System.Drawing.Point(299, 0);
            this.btnEempl.Name = "btnEempl";
            this.btnEempl.Size = new System.Drawing.Size(143, 40);
            this.btnEempl.TabIndex = 3;
            this.btnEempl.Text = "Eliminar";
            this.btnEempl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEempl.UseVisualStyleBackColor = true;
            this.btnEempl.Click += new System.EventHandler(this.btnEempl_Click);
            // 
            // btnRempl
            // 
            this.btnRempl.Image = global::PvCafeteria.Modelo.Properties.Resources.reporte;
            this.btnRempl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRempl.Location = new System.Drawing.Point(448, 0);
            this.btnRempl.Name = "btnRempl";
            this.btnRempl.Size = new System.Drawing.Size(143, 40);
            this.btnRempl.TabIndex = 4;
            this.btnRempl.Text = "Reporte";
            this.btnRempl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRempl.UseVisualStyleBackColor = true;
            this.btnRempl.Click += new System.EventHandler(this.btnRempl_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 723);
            this.Controls.Add(this.btnRempl);
            this.Controls.Add(this.btnEempl);
            this.Controls.Add(this.btnMempl);
            this.Controls.Add(this.btnNempl);
            this.Controls.Add(this.panelCon);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCon;
        private System.Windows.Forms.Button btnNempl;
        private System.Windows.Forms.Button btnMempl;
        private System.Windows.Forms.Button btnEempl;
        private System.Windows.Forms.Button btnRempl;
    }
}
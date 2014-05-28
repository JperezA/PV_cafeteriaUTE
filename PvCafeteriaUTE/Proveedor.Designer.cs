namespace PvCafeteria.Modelo
{
    partial class Proveedor
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
            this.paneCproveedor = new System.Windows.Forms.Panel();
            this.btnRproveedor = new System.Windows.Forms.Button();
            this.btnEproveedor = new System.Windows.Forms.Button();
            this.btnMproveedor = new System.Windows.Forms.Button();
            this.btnNproveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paneCproveedor
            // 
            this.paneCproveedor.Location = new System.Drawing.Point(1, 41);
            this.paneCproveedor.Name = "paneCproveedor";
            this.paneCproveedor.Size = new System.Drawing.Size(1091, 668);
            this.paneCproveedor.TabIndex = 4;
            this.paneCproveedor.Visible = false;
            // 
            // btnRproveedor
            // 
            this.btnRproveedor.Image = global::PvCafeteria.Modelo.Properties.Resources.reporte;
            this.btnRproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRproveedor.Location = new System.Drawing.Point(448, 1);
            this.btnRproveedor.Name = "btnRproveedor";
            this.btnRproveedor.Size = new System.Drawing.Size(143, 40);
            this.btnRproveedor.TabIndex = 3;
            this.btnRproveedor.Text = "Reporte";
            this.btnRproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRproveedor.UseVisualStyleBackColor = true;
            this.btnRproveedor.Click += new System.EventHandler(this.btnRproveedor_Click);
            // 
            // btnEproveedor
            // 
            this.btnEproveedor.Image = global::PvCafeteria.Modelo.Properties.Resources.eliminar;
            this.btnEproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEproveedor.Location = new System.Drawing.Point(299, 1);
            this.btnEproveedor.Name = "btnEproveedor";
            this.btnEproveedor.Size = new System.Drawing.Size(143, 40);
            this.btnEproveedor.TabIndex = 2;
            this.btnEproveedor.Text = "Eliminar";
            this.btnEproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEproveedor.UseVisualStyleBackColor = true;
            this.btnEproveedor.Click += new System.EventHandler(this.btnEproveedor_Click);
            // 
            // btnMproveedor
            // 
            this.btnMproveedor.Image = global::PvCafeteria.Modelo.Properties.Resources.modificar;
            this.btnMproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMproveedor.Location = new System.Drawing.Point(150, 1);
            this.btnMproveedor.Name = "btnMproveedor";
            this.btnMproveedor.Size = new System.Drawing.Size(143, 40);
            this.btnMproveedor.TabIndex = 1;
            this.btnMproveedor.Text = "Modificar";
            this.btnMproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMproveedor.UseVisualStyleBackColor = true;
            this.btnMproveedor.Click += new System.EventHandler(this.btnMproveedor_Click);
            // 
            // btnNproveedor
            // 
            this.btnNproveedor.Image = global::PvCafeteria.Modelo.Properties.Resources.nuevo;
            this.btnNproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNproveedor.Location = new System.Drawing.Point(1, 1);
            this.btnNproveedor.Name = "btnNproveedor";
            this.btnNproveedor.Size = new System.Drawing.Size(143, 40);
            this.btnNproveedor.TabIndex = 0;
            this.btnNproveedor.Text = "Nuevo";
            this.btnNproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNproveedor.UseVisualStyleBackColor = true;
            this.btnNproveedor.Click += new System.EventHandler(this.btnNproveedor_Click);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 709);
            this.Controls.Add(this.paneCproveedor);
            this.Controls.Add(this.btnRproveedor);
            this.Controls.Add(this.btnEproveedor);
            this.Controls.Add(this.btnMproveedor);
            this.Controls.Add(this.btnNproveedor);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMproveedor;
        private System.Windows.Forms.Button btnEproveedor;
        private System.Windows.Forms.Button btnRproveedor;
        public System.Windows.Forms.Button btnNproveedor;
        private System.Windows.Forms.Panel paneCproveedor;
    }
}
namespace PvCafeteria.Modelo
{
    partial class Pedidos
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
            this.btnMpedido = new System.Windows.Forms.Button();
            this.btnEpedidos = new System.Windows.Forms.Button();
            this.btnRpedidos = new System.Windows.Forms.Button();
            this.panelPedidos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMpedido
            // 
            this.btnMpedido.Image = global::PvCafeteria.Modelo.Properties.Resources.modificar;
            this.btnMpedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMpedido.Location = new System.Drawing.Point(2, 12);
            this.btnMpedido.Name = "btnMpedido";
            this.btnMpedido.Size = new System.Drawing.Size(143, 40);
            this.btnMpedido.TabIndex = 0;
            this.btnMpedido.Text = "Modificar";
            this.btnMpedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMpedido.UseVisualStyleBackColor = true;
            this.btnMpedido.Click += new System.EventHandler(this.btnMpedido_Click);
            // 
            // btnEpedidos
            // 
            this.btnEpedidos.Image = global::PvCafeteria.Modelo.Properties.Resources.eliminar;
            this.btnEpedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEpedidos.Location = new System.Drawing.Point(2, 58);
            this.btnEpedidos.Name = "btnEpedidos";
            this.btnEpedidos.Size = new System.Drawing.Size(143, 40);
            this.btnEpedidos.TabIndex = 1;
            this.btnEpedidos.Text = "Eliminar";
            this.btnEpedidos.UseVisualStyleBackColor = true;
            // 
            // btnRpedidos
            // 
            this.btnRpedidos.Image = global::PvCafeteria.Modelo.Properties.Resources.reporte;
            this.btnRpedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRpedidos.Location = new System.Drawing.Point(2, 104);
            this.btnRpedidos.Name = "btnRpedidos";
            this.btnRpedidos.Size = new System.Drawing.Size(143, 40);
            this.btnRpedidos.TabIndex = 2;
            this.btnRpedidos.Text = "Reporte";
            this.btnRpedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRpedidos.UseVisualStyleBackColor = true;
            // 
            // panelPedidos
            // 
            this.panelPedidos.Location = new System.Drawing.Point(152, 13);
            this.panelPedidos.Name = "panelPedidos";
            this.panelPedidos.Size = new System.Drawing.Size(1109, 511);
            this.panelPedidos.TabIndex = 3;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 525);
            this.Controls.Add(this.panelPedidos);
            this.Controls.Add(this.btnRpedidos);
            this.Controls.Add(this.btnEpedidos);
            this.Controls.Add(this.btnMpedido);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMpedido;
        private System.Windows.Forms.Button btnEpedidos;
        private System.Windows.Forms.Button btnRpedidos;
        private System.Windows.Forms.Panel panelPedidos;
    }
}
namespace PvCafeteria.Modelo
{
    partial class nPedidos
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
            this.lbmodificarpedido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbmodificarpedido
            // 
            this.lbmodificarpedido.AutoSize = true;
            this.lbmodificarpedido.Location = new System.Drawing.Point(1, 0);
            this.lbmodificarpedido.Name = "lbmodificarpedido";
            this.lbmodificarpedido.Size = new System.Drawing.Size(149, 20);
            this.lbmodificarpedido.TabIndex = 0;
            this.lbmodificarpedido.Text = "Modificar pedido";
            // 
            // nPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 472);
            this.Controls.Add(this.lbmodificarpedido);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "nPedidos";
            this.Text = "nPedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmodificarpedido;
    }
}
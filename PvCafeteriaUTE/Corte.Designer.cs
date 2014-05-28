namespace PvCafeteria.Modelo
{
    partial class Corte
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
            this.btnDcaja = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVcorte = new System.Windows.Forms.Button();
            this.btnGcorte = new System.Windows.Forms.Button();
            this.panelCorte = new System.Windows.Forms.Panel();
            this.btnRepCorte = new System.Windows.Forms.Button();
            this.btnRcorte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDcaja
            // 
            this.btnDcaja.Location = new System.Drawing.Point(3, 58);
            this.btnDcaja.Name = "btnDcaja";
            this.btnDcaja.Size = new System.Drawing.Size(143, 40);
            this.btnDcaja.TabIndex = 1;
            this.btnDcaja.Text = "Dienero Caja";
            this.btnDcaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDcaja.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pagos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnVcorte
            // 
            this.btnVcorte.Location = new System.Drawing.Point(3, 151);
            this.btnVcorte.Name = "btnVcorte";
            this.btnVcorte.Size = new System.Drawing.Size(143, 40);
            this.btnVcorte.TabIndex = 3;
            this.btnVcorte.Text = "Ventas Totales";
            this.btnVcorte.UseVisualStyleBackColor = true;
            // 
            // btnGcorte
            // 
            this.btnGcorte.Location = new System.Drawing.Point(3, 198);
            this.btnGcorte.Name = "btnGcorte";
            this.btnGcorte.Size = new System.Drawing.Size(143, 40);
            this.btnGcorte.TabIndex = 4;
            this.btnGcorte.Text = "Ganacias";
            this.btnGcorte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGcorte.UseVisualStyleBackColor = true;
            // 
            // panelCorte
            // 
            this.panelCorte.Location = new System.Drawing.Point(153, 13);
            this.panelCorte.Name = "panelCorte";
            this.panelCorte.Size = new System.Drawing.Size(1096, 458);
            this.panelCorte.TabIndex = 6;
            // 
            // btnRepCorte
            // 
            this.btnRepCorte.Image = global::PvCafeteria.Modelo.Properties.Resources.reporte;
            this.btnRepCorte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepCorte.Location = new System.Drawing.Point(3, 244);
            this.btnRepCorte.Name = "btnRepCorte";
            this.btnRepCorte.Size = new System.Drawing.Size(143, 40);
            this.btnRepCorte.TabIndex = 5;
            this.btnRepCorte.Text = "Reporte";
            this.btnRepCorte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRepCorte.UseVisualStyleBackColor = true;
            // 
            // btnRcorte
            // 
            this.btnRcorte.Image = global::PvCafeteria.Modelo.Properties.Resources.nuevo;
            this.btnRcorte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRcorte.Location = new System.Drawing.Point(3, 12);
            this.btnRcorte.Name = "btnRcorte";
            this.btnRcorte.Size = new System.Drawing.Size(143, 40);
            this.btnRcorte.TabIndex = 0;
            this.btnRcorte.Text = "Nuevo";
            this.btnRcorte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRcorte.UseVisualStyleBackColor = true;
            this.btnRcorte.Click += new System.EventHandler(this.btnRcorte_Click);
            // 
            // Corte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 472);
            this.Controls.Add(this.panelCorte);
            this.Controls.Add(this.btnRepCorte);
            this.Controls.Add(this.btnGcorte);
            this.Controls.Add(this.btnVcorte);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDcaja);
            this.Controls.Add(this.btnRcorte);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Corte";
            this.Text = "Corte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRcorte;
        private System.Windows.Forms.Button btnDcaja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnVcorte;
        private System.Windows.Forms.Button btnGcorte;
        private System.Windows.Forms.Button btnRepCorte;
        private System.Windows.Forms.Panel panelCorte;
    }
}
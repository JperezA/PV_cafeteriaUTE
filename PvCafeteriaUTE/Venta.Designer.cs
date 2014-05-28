namespace PvCafeteria.Modelo
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.lbproducto = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lbcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.TablaVenta = new System.Windows.Forms.DataGridView();
            this.blnota = new System.Windows.Forms.Label();
            this.txtnotanum = new System.Windows.Forms.TextBox();
            this.lbcliente = new System.Windows.Forms.Label();
            this.rbtnCliefijo = new System.Windows.Forms.RadioButton();
            this.rbtnclieeventual = new System.Windows.Forms.RadioButton();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.tntcliente = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnAgregarpro = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncobrar = new System.Windows.Forms.Button();
            this.TvenCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TvenDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TvenPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TvenCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TvenImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbproducto
            // 
            this.lbproducto.AutoSize = true;
            this.lbproducto.Location = new System.Drawing.Point(28, 20);
            this.lbproducto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbproducto.Name = "lbproducto";
            this.lbproducto.Size = new System.Drawing.Size(132, 20);
            this.lbproducto.TabIndex = 0;
            this.lbproducto.Text = "Cód. Producto:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(172, 14);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(233, 38);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            
            // 
            // lbcantidad
            // 
            this.lbcantidad.AutoSize = true;
            this.lbcantidad.Location = new System.Drawing.Point(70, 88);
            this.lbcantidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbcantidad.Name = "lbcantidad";
            this.lbcantidad.Size = new System.Drawing.Size(90, 20);
            this.lbcantidad.TabIndex = 2;
            this.lbcantidad.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(172, 72);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(233, 38);
            this.txtcantidad.TabIndex = 3;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // TablaVenta
            // 
            this.TablaVenta.AllowUserToAddRows = false;
            this.TablaVenta.AllowUserToDeleteRows = false;
            this.TablaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TvenCodigo,
            this.TvenDescripcion,
            this.TvenPrecio,
            this.TvenCantidad,
            this.TvenImporte});
            this.TablaVenta.Location = new System.Drawing.Point(5, 113);
            this.TablaVenta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TablaVenta.Name = "TablaVenta";
            this.TablaVenta.ReadOnly = true;
            this.TablaVenta.Size = new System.Drawing.Size(995, 348);
            this.TablaVenta.TabIndex = 7;
            this.TablaVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaVenta_CellContentClick);
            // 
            // blnota
            // 
            this.blnota.AutoSize = true;
            this.blnota.Location = new System.Drawing.Point(1018, 7);
            this.blnota.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.blnota.Name = "blnota";
            this.blnota.Size = new System.Drawing.Size(72, 20);
            this.blnota.TabIndex = 8;
            this.blnota.Text = "Nota N°";
            this.blnota.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnotanum
            // 
            this.txtnotanum.Location = new System.Drawing.Point(1022, 32);
            this.txtnotanum.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtnotanum.Multiline = true;
            this.txtnotanum.Name = "txtnotanum";
            this.txtnotanum.ReadOnly = true;
            this.txtnotanum.Size = new System.Drawing.Size(233, 38);
            this.txtnotanum.TabIndex = 9;
            this.txtnotanum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnotanum.TextChanged += new System.EventHandler(this.txtnotanum_TextChanged);
            // 
            // lbcliente
            // 
            this.lbcliente.AutoSize = true;
            this.lbcliente.Location = new System.Drawing.Point(1018, 75);
            this.lbcliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbcliente.Name = "lbcliente";
            this.lbcliente.Size = new System.Drawing.Size(68, 20);
            this.lbcliente.TabIndex = 10;
            this.lbcliente.Text = "Cliente";
            // 
            // rbtnCliefijo
            // 
            this.rbtnCliefijo.AutoSize = true;
            this.rbtnCliefijo.Location = new System.Drawing.Point(1022, 173);
            this.rbtnCliefijo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnCliefijo.Name = "rbtnCliefijo";
            this.rbtnCliefijo.Size = new System.Drawing.Size(120, 24);
            this.rbtnCliefijo.TabIndex = 12;
            this.rbtnCliefijo.TabStop = true;
            this.rbtnCliefijo.Text = "Cliente Fijo";
            this.rbtnCliefijo.UseVisualStyleBackColor = true;
            // 
            // rbtnclieeventual
            // 
            this.rbtnclieeventual.AutoSize = true;
            this.rbtnclieeventual.Location = new System.Drawing.Point(1022, 207);
            this.rbtnclieeventual.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnclieeventual.Name = "rbtnclieeventual";
            this.rbtnclieeventual.Size = new System.Drawing.Size(161, 24);
            this.rbtnclieeventual.TabIndex = 13;
            this.rbtnclieeventual.TabStop = true;
            this.rbtnclieeventual.Text = "Cliente Eventual";
            this.rbtnclieeventual.UseVisualStyleBackColor = true;
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(1022, 326);
            this.txtimporte.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtimporte.Multiline = true;
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.ReadOnly = true;
            this.txtimporte.Size = new System.Drawing.Size(233, 38);
            this.txtimporte.TabIndex = 14;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Location = new System.Drawing.Point(1018, 301);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(51, 20);
            this.lbtotal.TabIndex = 17;
            this.lbtotal.Text = "Total";
            // 
            // tntcliente
            // 
            this.tntcliente.Image = global::PvCafeteria.Modelo.Properties.Resources.cambio;
            this.tntcliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tntcliente.Location = new System.Drawing.Point(1022, 95);
            this.tntcliente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tntcliente.Name = "tntcliente";
            this.tntcliente.Size = new System.Drawing.Size(233, 68);
            this.tntcliente.TabIndex = 11;
            this.tntcliente.Text = "Cliente Eventual";
            this.tntcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tntcliente.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            this.btnborrar.Image = global::PvCafeteria.Modelo.Properties.Resources.eliminarpro;
            this.btnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrar.Location = new System.Drawing.Point(712, 70);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(143, 40);
            this.btnborrar.TabIndex = 6;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::PvCafeteria.Modelo.Properties.Resources.buscarf6;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(712, 17);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(143, 40);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarpro
            // 
            this.btnAgregarpro.Image = global::PvCafeteria.Modelo.Properties.Resources.agregarpro;
            this.btnAgregarpro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarpro.Location = new System.Drawing.Point(417, 14);
            this.btnAgregarpro.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAgregarpro.Name = "btnAgregarpro";
            this.btnAgregarpro.Size = new System.Drawing.Size(254, 96);
            this.btnAgregarpro.TabIndex = 4;
            this.btnAgregarpro.Text = "Agregar Producto";
            this.btnAgregarpro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarpro.UseVisualStyleBackColor = true;
            this.btnAgregarpro.Click += new System.EventHandler(this.btnAgregarpro_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(712, 471);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(143, 40);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncobrar
            // 
            this.btncobrar.Image = ((System.Drawing.Image)(resources.GetObject("btncobrar.Image")));
            this.btncobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncobrar.Location = new System.Drawing.Point(857, 471);
            this.btncobrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(143, 40);
            this.btncobrar.TabIndex = 15;
            this.btncobrar.Text = "Cobrar";
            this.btncobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // TvenCodigo
            // 
            this.TvenCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TvenCodigo.DataPropertyName = "Ven_prod_codigo";
            this.TvenCodigo.HeaderText = "Códido";
            this.TvenCodigo.MaxInputLength = 10;
            this.TvenCodigo.Name = "TvenCodigo";
            this.TvenCodigo.ReadOnly = true;
            this.TvenCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TvenCodigo.Width = 200;
            // 
            // TvenDescripcion
            // 
            this.TvenDescripcion.DataPropertyName = "Ven_prod_descrip";
            this.TvenDescripcion.HeaderText = "Descripción del Producto";
            this.TvenDescripcion.Name = "TvenDescripcion";
            this.TvenDescripcion.ReadOnly = true;
            this.TvenDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TvenDescripcion.Width = 301;
            // 
            // TvenPrecio
            // 
            this.TvenPrecio.DataPropertyName = "Ven_pro_precvent";
            this.TvenPrecio.HeaderText = "Precio";
            this.TvenPrecio.Name = "TvenPrecio";
            this.TvenPrecio.ReadOnly = true;
            this.TvenPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TvenPrecio.Width = 200;
            // 
            // TvenCantidad
            // 
            this.TvenCantidad.DataPropertyName = "Ven_cantidad";
            this.TvenCantidad.HeaderText = "Cantidad";
            this.TvenCantidad.Name = "TvenCantidad";
            this.TvenCantidad.ReadOnly = true;
            this.TvenCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TvenCantidad.Width = 140;
            // 
            // TvenImporte
            // 
            this.TvenImporte.DataPropertyName = "Importe";
            this.TvenImporte.HeaderText = "Importe";
            this.TvenImporte.Name = "TvenImporte";
            this.TvenImporte.ReadOnly = true;
            this.TvenImporte.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TvenImporte.Width = 150;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 525);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.rbtnclieeventual);
            this.Controls.Add(this.rbtnCliefijo);
            this.Controls.Add(this.tntcliente);
            this.Controls.Add(this.lbcliente);
            this.Controls.Add(this.txtnotanum);
            this.Controls.Add(this.blnota);
            this.Controls.Add(this.TablaVenta);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnAgregarpro);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lbcantidad);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lbproducto);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbproducto;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lbcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnAgregarpro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.DataGridView TablaVenta;
        private System.Windows.Forms.Label blnota;
        private System.Windows.Forms.TextBox txtnotanum;
        private System.Windows.Forms.Label lbcliente;
        private System.Windows.Forms.Button tntcliente;
        private System.Windows.Forms.RadioButton rbtnCliefijo;
        private System.Windows.Forms.RadioButton rbtnclieeventual;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TvenCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TvenDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TvenPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TvenCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TvenImporte;
    }
}
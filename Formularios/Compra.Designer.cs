namespace TP_Farmacia_Compras.Formularios
{
    partial class Compra
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
            this.OK = new System.Windows.Forms.Button();
            this.cbArticulos = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.lblNumeroCOmpra = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.cbTransporte = new System.Windows.Forms.ComboBox();
            this.ColIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBonificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.Blue;
            this.OK.Location = new System.Drawing.Point(12, 414);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(381, 28);
            this.OK.TabIndex = 0;
            this.OK.Text = "Cerrar Compra";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // cbArticulos
            // 
            this.cbArticulos.FormattingEnabled = true;
            this.cbArticulos.Location = new System.Drawing.Point(12, 124);
            this.cbArticulos.Name = "cbArticulos";
            this.cbArticulos.Size = new System.Drawing.Size(394, 21);
            this.cbArticulos.TabIndex = 1;
            this.cbArticulos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbArticulos_KeyPress);
            // 
            // Grilla
            // 
            this.Grilla.BackgroundColor = System.Drawing.SystemColors.Info;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIDProducto,
            this.ColProducto,
            this.ColPrecioCompra,
            this.ColCantidad,
            this.ColBonificacion,
            this.ColPrecioTotal});
            this.Grilla.Location = new System.Drawing.Point(12, 151);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(689, 257);
            this.Grilla.TabIndex = 2;
            // 
            // lblNumeroCOmpra
            // 
            this.lblNumeroCOmpra.AutoSize = true;
            this.lblNumeroCOmpra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCOmpra.Location = new System.Drawing.Point(24, 20);
            this.lblNumeroCOmpra.Name = "lblNumeroCOmpra";
            this.lblNumeroCOmpra.Size = new System.Drawing.Size(104, 20);
            this.lblNumeroCOmpra.TabIndex = 3;
            this.lblNumeroCOmpra.Text = "Compra N°: ";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(9, 108);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(47, 13);
            this.lblArticulo.TabIndex = 4;
            this.lblArticulo.Text = "Articulos";
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(12, 84);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(394, 21);
            this.cbProveedor.TabIndex = 5;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(12, 68);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 6;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(412, 125);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            this.txtCantidad.Validated += new System.EventHandler(this.txtCantidad_Validated);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(413, 108);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(52, 13);
            this.lblcantidad.TabIndex = 8;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // mskFecha
            // 
            this.mskFecha.Enabled = false;
            this.mskFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFecha.Location = new System.Drawing.Point(624, 8);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.Size = new System.Drawing.Size(77, 23);
            this.mskFecha.TabIndex = 11;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(571, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Fecha";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(574, 81);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 65);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(256, 18);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(82, 13);
            this.lblFormaPago.TabIndex = 14;
            this.lblFormaPago.Text = "Forma de Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Transporte:";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Location = new System.Drawing.Point(344, 15);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(215, 21);
            this.cbFormaPago.TabIndex = 16;
            this.cbFormaPago.SelectedValueChanged += new System.EventHandler(this.cbFormaPago_SelectedValueChanged);
            // 
            // cbTransporte
            // 
            this.cbTransporte.FormattingEnabled = true;
            this.cbTransporte.Location = new System.Drawing.Point(344, 44);
            this.cbTransporte.Name = "cbTransporte";
            this.cbTransporte.Size = new System.Drawing.Size(215, 21);
            this.cbTransporte.TabIndex = 17;
            this.cbTransporte.SelectedValueChanged += new System.EventHandler(this.cbTransporte_SelectedValueChanged);
            // 
            // ColIDProducto
            // 
            this.ColIDProducto.HeaderText = "ID";
            this.ColIDProducto.Name = "ColIDProducto";
            this.ColIDProducto.ReadOnly = true;
            this.ColIDProducto.Width = 40;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Descricpion";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 180;
            // 
            // ColPrecioCompra
            // 
            this.ColPrecioCompra.HeaderText = "Precio Unitario";
            this.ColPrecioCompra.Name = "ColPrecioCompra";
            this.ColPrecioCompra.ReadOnly = true;
            this.ColPrecioCompra.Width = 150;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            // 
            // ColBonificacion
            // 
            this.ColBonificacion.HeaderText = "Boni %";
            this.ColBonificacion.Name = "ColBonificacion";
            this.ColBonificacion.Width = 50;
            // 
            // ColPrecioTotal
            // 
            this.ColPrecioTotal.HeaderText = "Total";
            this.ColPrecioTotal.Name = "ColPrecioTotal";
            this.ColPrecioTotal.ReadOnly = true;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 449);
            this.Controls.Add(this.cbTransporte);
            this.Controls.Add(this.cbFormaPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.lblNumeroCOmpra);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.cbArticulos);
            this.Controls.Add(this.OK);
            this.Name = "Compra";
            this.Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ComboBox cbArticulos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Label lblNumeroCOmpra;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.ComboBox cbTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioTotal;
    }
}
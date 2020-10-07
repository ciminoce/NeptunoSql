namespace NeptunoSql.Windows
{
    partial class FrmVentas
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
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.DescuentosTextBox = new System.Windows.Forms.TextBox();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BarraPrincipalToolStrip = new System.Windows.Forms.ToolStrip();
            this.VentasToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FinalizarVentaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ConsultarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BuscarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DescuentoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PagarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CerrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CodigoBarraTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSuperiorDerecho = new System.Windows.Forms.Panel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VentasDataGridView = new System.Windows.Forms.DataGridView();
            this.cmnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnBorrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelInferior.SuspendLayout();
            this.BarraPrincipalToolStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSuperiorDerecho.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelInferior
            // 
            this.PanelInferior.Controls.Add(this.TotalTextBox);
            this.PanelInferior.Controls.Add(this.DescuentosTextBox);
            this.PanelInferior.Controls.Add(this.SubtotalTextBox);
            this.PanelInferior.Controls.Add(this.label4);
            this.PanelInferior.Controls.Add(this.label3);
            this.PanelInferior.Controls.Add(this.label2);
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(0, 624);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(1184, 137);
            this.PanelInferior.TabIndex = 11;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(984, 110);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(129, 20);
            this.TotalTextBox.TabIndex = 1;
            // 
            // DescuentosTextBox
            // 
            this.DescuentosTextBox.Enabled = false;
            this.DescuentosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentosTextBox.Location = new System.Drawing.Point(984, 44);
            this.DescuentosTextBox.Name = "DescuentosTextBox";
            this.DescuentosTextBox.Size = new System.Drawing.Size(129, 20);
            this.DescuentosTextBox.TabIndex = 1;
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Enabled = false;
            this.SubtotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalTextBox.Location = new System.Drawing.Point(984, 12);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.Size = new System.Drawing.Size(129, 20);
            this.SubtotalTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(935, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(900, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descuentos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(917, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subtotal:";
            // 
            // BarraPrincipalToolStrip
            // 
            this.BarraPrincipalToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.BarraPrincipalToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentasToolStripButton,
            this.CancelarToolStripButton,
            this.FinalizarVentaToolStripButton,
            this.toolStripSeparator1,
            this.ConsultarToolStripButton,
            this.toolStripSeparator4,
            this.BuscarToolStripButton,
            this.toolStripSeparator2,
            this.DescuentoToolStripButton,
            this.PagarToolStripButton,
            this.toolStripSeparator3,
            this.CerrarToolStripButton});
            this.BarraPrincipalToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.BarraPrincipalToolStrip.Location = new System.Drawing.Point(1116, 80);
            this.BarraPrincipalToolStrip.Name = "BarraPrincipalToolStrip";
            this.BarraPrincipalToolStrip.Size = new System.Drawing.Size(68, 550);
            this.BarraPrincipalToolStrip.TabIndex = 7;
            this.BarraPrincipalToolStrip.Text = "toolStrip1";
            // 
            // VentasToolStripButton
            // 
            this.VentasToolStripButton.Image = global::NeptunoSql.Windows.Properties.Resources.buy_40px;
            this.VentasToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VentasToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VentasToolStripButton.Name = "VentasToolStripButton";
            this.VentasToolStripButton.Size = new System.Drawing.Size(66, 59);
            this.VentasToolStripButton.Text = "Venta";
            this.VentasToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VentasToolStripButton.ToolTipText = "Nueva Venta";
            this.VentasToolStripButton.Click += new System.EventHandler(this.VentasToolStripButton_Click);
            // 
            // CancelarToolStripButton
            // 
            this.CancelarToolStripButton.Image = global::NeptunoSql.Windows.Properties.Resources.return_purchase_40px1;
            this.CancelarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarToolStripButton.Name = "CancelarToolStripButton";
            this.CancelarToolStripButton.Size = new System.Drawing.Size(66, 59);
            this.CancelarToolStripButton.Text = "Cancelar";
            this.CancelarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarToolStripButton.ToolTipText = "Cancelar toda la venta";
            // 
            // FinalizarVentaToolStripButton
            // 
            this.FinalizarVentaToolStripButton.Image = global::NeptunoSql.Windows.Properties.Resources.add_shopping_cart_40px;
            this.FinalizarVentaToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FinalizarVentaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FinalizarVentaToolStripButton.Name = "FinalizarVentaToolStripButton";
            this.FinalizarVentaToolStripButton.Size = new System.Drawing.Size(66, 59);
            this.FinalizarVentaToolStripButton.Text = "Finalizar";
            this.FinalizarVentaToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FinalizarVentaToolStripButton.ToolTipText = "Finalizar la Venta";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(66, 6);
            // 
            // ConsultarToolStripButton
            // 
            this.ConsultarToolStripButton.Image = global::NeptunoSql.Windows.Properties.Resources.buying_40px;
            this.ConsultarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ConsultarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConsultarToolStripButton.Name = "ConsultarToolStripButton";
            this.ConsultarToolStripButton.Size = new System.Drawing.Size(66, 59);
            this.ConsultarToolStripButton.Text = "Consultar";
            this.ConsultarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ConsultarToolStripButton.ToolTipText = "Consultar Ventas";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(66, 6);
            // 
            // BuscarToolStripButton
            // 
            this.BuscarToolStripButton.Image = global::NeptunoSql.Windows.Properties.Resources.search_40px;
            this.BuscarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarToolStripButton.Name = "BuscarToolStripButton";
            this.BuscarToolStripButton.Size = new System.Drawing.Size(66, 59);
            this.BuscarToolStripButton.Text = "Buscar";
            this.BuscarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarToolStripButton.Click += new System.EventHandler(this.BuscarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(66, 6);
            // 
            // DescuentoToolStripButton
            // 
            this.DescuentoToolStripButton.Image = global::NeptunoSql.Windows.Properties.Resources.get_a_discount_40px;
            this.DescuentoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DescuentoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DescuentoToolStripButton.Name = "DescuentoToolStripButton";
            this.DescuentoToolStripButton.Size = new System.Drawing.Size(66, 59);
            this.DescuentoToolStripButton.Text = "Descuento";
            this.DescuentoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DescuentoToolStripButton.ToolTipText = "Descuento a un item";
            // 
            // PagarToolStripButton
            // 
            this.PagarToolStripButton.Image = global::NeptunoSql.Windows.Properties.Resources.receive_cash_40px;
            this.PagarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PagarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PagarToolStripButton.Name = "PagarToolStripButton";
            this.PagarToolStripButton.Size = new System.Drawing.Size(66, 59);
            this.PagarToolStripButton.Text = "Pagar";
            this.PagarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PagarToolStripButton.ToolTipText = "Obtener pago de la venta";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(66, 6);
            // 
            // CerrarToolStripButton
            // 
            this.CerrarToolStripButton.Image = global::NeptunoSql.Windows.Properties.Resources.close_window_40px;
            this.CerrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CerrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CerrarToolStripButton.Name = "CerrarToolStripButton";
            this.CerrarToolStripButton.Size = new System.Drawing.Size(66, 59);
            this.CerrarToolStripButton.Text = "Cerrar";
            this.CerrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CerrarToolStripButton.ToolTipText = "Cerrar el formulario";
            this.CerrarToolStripButton.Click += new System.EventHandler(this.CerrarToolStripButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CodigoBarraTextBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 73);
            this.panel4.TabIndex = 10;
            // 
            // CodigoBarraTextBox
            // 
            this.CodigoBarraTextBox.Enabled = false;
            this.CodigoBarraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoBarraTextBox.Location = new System.Drawing.Point(146, 22);
            this.CodigoBarraTextBox.Name = "CodigoBarraTextBox";
            this.CodigoBarraTextBox.Size = new System.Drawing.Size(270, 23);
            this.CodigoBarraTextBox.TabIndex = 122;
            this.CodigoBarraTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoBarraTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "Cod. Barra:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeptunoSql.Windows.Properties.Resources.search_20px;
            this.pictureBox1.Location = new System.Drawing.Point(112, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // PanelSuperiorDerecho
            // 
            this.PanelSuperiorDerecho.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelSuperiorDerecho.Controls.Add(this.TotalLabel);
            this.PanelSuperiorDerecho.Location = new System.Drawing.Point(469, 1);
            this.PanelSuperiorDerecho.Name = "PanelSuperiorDerecho";
            this.PanelSuperiorDerecho.Size = new System.Drawing.Size(715, 73);
            this.PanelSuperiorDerecho.TabIndex = 9;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Location = new System.Drawing.Point(524, 22);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(71, 31);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VentasDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 531);
            this.panel1.TabIndex = 8;
            // 
            // VentasDataGridView
            // 
            this.VentasDataGridView.AllowUserToAddRows = false;
            this.VentasDataGridView.AllowUserToDeleteRows = false;
            this.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnProducto,
            this.cmnPrecioUnitario,
            this.cmnCantidad,
            this.cmnDescuento,
            this.cmnPrecioTotal,
            this.cmnBorrar});
            this.VentasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VentasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.VentasDataGridView.MultiSelect = false;
            this.VentasDataGridView.Name = "VentasDataGridView";
            this.VentasDataGridView.ReadOnly = true;
            this.VentasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VentasDataGridView.Size = new System.Drawing.Size(1113, 531);
            this.VentasDataGridView.TabIndex = 0;
            this.VentasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VentasDataGridView_CellClick);
            // 
            // cmnProducto
            // 
            this.cmnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnProducto.HeaderText = "Producto";
            this.cmnProducto.Name = "cmnProducto";
            this.cmnProducto.ReadOnly = true;
            // 
            // cmnPrecioUnitario
            // 
            this.cmnPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnPrecioUnitario.HeaderText = "P. Unit";
            this.cmnPrecioUnitario.Name = "cmnPrecioUnitario";
            this.cmnPrecioUnitario.ReadOnly = true;
            this.cmnPrecioUnitario.Width = 64;
            // 
            // cmnCantidad
            // 
            this.cmnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnCantidad.HeaderText = "Cantidad";
            this.cmnCantidad.Name = "cmnCantidad";
            this.cmnCantidad.ReadOnly = true;
            this.cmnCantidad.Width = 74;
            // 
            // cmnDescuento
            // 
            this.cmnDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnDescuento.HeaderText = "Desc.";
            this.cmnDescuento.Name = "cmnDescuento";
            this.cmnDescuento.ReadOnly = true;
            this.cmnDescuento.Width = 60;
            // 
            // cmnPrecioTotal
            // 
            this.cmnPrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnPrecioTotal.HeaderText = "P. Total";
            this.cmnPrecioTotal.Name = "cmnPrecioTotal";
            this.cmnPrecioTotal.ReadOnly = true;
            this.cmnPrecioTotal.Width = 69;
            // 
            // cmnBorrar
            // 
            this.cmnBorrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnBorrar.HeaderText = "";
            this.cmnBorrar.Image = global::NeptunoSql.Windows.Properties.Resources.trash_15px;
            this.cmnBorrar.Name = "cmnBorrar";
            this.cmnBorrar.ReadOnly = true;
            this.cmnBorrar.Width = 5;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.BarraPrincipalToolStrip);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PanelSuperiorDerecho);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.PanelInferior.ResumeLayout(false);
            this.PanelInferior.PerformLayout();
            this.BarraPrincipalToolStrip.ResumeLayout(false);
            this.BarraPrincipalToolStrip.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSuperiorDerecho.ResumeLayout(false);
            this.PanelSuperiorDerecho.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox DescuentosTextBox;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip BarraPrincipalToolStrip;
        private System.Windows.Forms.ToolStripButton VentasToolStripButton;
        private System.Windows.Forms.ToolStripButton CancelarToolStripButton;
        private System.Windows.Forms.ToolStripButton FinalizarVentaToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ConsultarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BuscarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DescuentoToolStripButton;
        private System.Windows.Forms.ToolStripButton PagarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton CerrarToolStripButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox CodigoBarraTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelSuperiorDerecho;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView VentasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPrecioTotal;
        private System.Windows.Forms.DataGridViewImageColumn cmnBorrar;
    }
}
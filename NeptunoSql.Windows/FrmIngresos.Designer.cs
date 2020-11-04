namespace NeptunoSql.Windows
{
    partial class FrmIngresos
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
            this.components = new System.ComponentModel.Container();
            this.StockTabControl = new System.Windows.Forms.TabControl();
            this.StockInTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ProductosLinkLabel = new System.Windows.Forms.LinkLabel();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReferenciaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StockInProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.cmnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnBorrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.HistoricoTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BuscarIngresosButton = new System.Windows.Forms.Button();
            this.FechaFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaInicialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.IngresosDataGridView = new System.Windows.Forms.DataGridView();
            this.colIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleDdataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KardexTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CategoriaTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IngresosLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.KardexDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colMovNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaKardex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockTabControl.SuspendLayout();
            this.StockInTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockInProductosDataGridView)).BeginInit();
            this.HistoricoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDdataGridView)).BeginInit();
            this.KardexTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KardexDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // StockTabControl
            // 
            this.StockTabControl.Controls.Add(this.StockInTabPage);
            this.StockTabControl.Controls.Add(this.HistoricoTabPage);
            this.StockTabControl.Controls.Add(this.KardexTabPage);
            this.StockTabControl.Location = new System.Drawing.Point(20, 40);
            this.StockTabControl.Name = "StockTabControl";
            this.StockTabControl.SelectedIndex = 0;
            this.StockTabControl.Size = new System.Drawing.Size(1164, 655);
            this.StockTabControl.TabIndex = 1;
            // 
            // StockInTabPage
            // 
            this.StockInTabPage.Controls.Add(this.splitContainer1);
            this.StockInTabPage.Location = new System.Drawing.Point(4, 22);
            this.StockInTabPage.Name = "StockInTabPage";
            this.StockInTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StockInTabPage.Size = new System.Drawing.Size(1156, 629);
            this.StockInTabPage.TabIndex = 0;
            this.StockInTabPage.Text = "Ingreso de Stock";
            this.StockInTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CancelarButton);
            this.splitContainer1.Panel1.Controls.Add(this.GuardarButton);
            this.splitContainer1.Panel1.Controls.Add(this.ProductosLinkLabel);
            this.splitContainer1.Panel1.Controls.Add(this.FechaDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.EmpleadoTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.ReferenciaTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.StockInProductosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1150, 623);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Image = global::NeptunoSql.Windows.Properties.Resources.Cancelar;
            this.CancelarButton.Location = new System.Drawing.Point(986, 94);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(135, 63);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::NeptunoSql.Windows.Properties.Resources.Aceptar;
            this.GuardarButton.Location = new System.Drawing.Point(986, 21);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(135, 63);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ProductosLinkLabel
            // 
            this.ProductosLinkLabel.AutoSize = true;
            this.ProductosLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosLinkLabel.Location = new System.Drawing.Point(534, 21);
            this.ProductosLinkLabel.Name = "ProductosLinkLabel";
            this.ProductosLinkLabel.Size = new System.Drawing.Size(229, 18);
            this.ProductosLinkLabel.TabIndex = 3;
            this.ProductosLinkLabel.TabStop = true;
            this.ProductosLinkLabel.Text = "[Click acá para ver los productos]";
            this.ProductosLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProductosLinkLabel_LinkClicked);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(100, 76);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.FechaDateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha:";
            // 
            // EmpleadoTextBox
            // 
            this.EmpleadoTextBox.Location = new System.Drawing.Point(100, 47);
            this.EmpleadoTextBox.Name = "EmpleadoTextBox";
            this.EmpleadoTextBox.Size = new System.Drawing.Size(339, 20);
            this.EmpleadoTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empleado:";
            // 
            // ReferenciaTextBox
            // 
            this.ReferenciaTextBox.Location = new System.Drawing.Point(100, 21);
            this.ReferenciaTextBox.Name = "ReferenciaTextBox";
            this.ReferenciaTextBox.Size = new System.Drawing.Size(202, 20);
            this.ReferenciaTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referencia:";
            // 
            // StockInProductosDataGridView
            // 
            this.StockInProductosDataGridView.AllowUserToAddRows = false;
            this.StockInProductosDataGridView.AllowUserToDeleteRows = false;
            this.StockInProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockInProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnMarca,
            this.cmnDescripcion,
            this.cmnCantidad,
            this.cmnBorrar});
            this.StockInProductosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockInProductosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StockInProductosDataGridView.MultiSelect = false;
            this.StockInProductosDataGridView.Name = "StockInProductosDataGridView";
            this.StockInProductosDataGridView.ReadOnly = true;
            this.StockInProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockInProductosDataGridView.Size = new System.Drawing.Size(1150, 447);
            this.StockInProductosDataGridView.TabIndex = 0;
            this.StockInProductosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockInProductosDataGridView_CellClick);
            // 
            // cmnMarca
            // 
            this.cmnMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnMarca.HeaderText = "Marca";
            this.cmnMarca.Name = "cmnMarca";
            this.cmnMarca.ReadOnly = true;
            // 
            // cmnDescripcion
            // 
            this.cmnDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnDescripcion.HeaderText = "Descripción";
            this.cmnDescripcion.Name = "cmnDescripcion";
            this.cmnDescripcion.ReadOnly = true;
            // 
            // cmnCantidad
            // 
            this.cmnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnCantidad.HeaderText = "Cantidad";
            this.cmnCantidad.Name = "cmnCantidad";
            this.cmnCantidad.ReadOnly = true;
            this.cmnCantidad.Width = 74;
            // 
            // cmnBorrar
            // 
            this.cmnBorrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnBorrar.HeaderText = "Borrar";
            this.cmnBorrar.Image = global::NeptunoSql.Windows.Properties.Resources.trash_15px;
            this.cmnBorrar.Name = "cmnBorrar";
            this.cmnBorrar.ReadOnly = true;
            this.cmnBorrar.Width = 41;
            // 
            // HistoricoTabPage
            // 
            this.HistoricoTabPage.Controls.Add(this.splitContainer2);
            this.HistoricoTabPage.Location = new System.Drawing.Point(4, 22);
            this.HistoricoTabPage.Name = "HistoricoTabPage";
            this.HistoricoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HistoricoTabPage.Size = new System.Drawing.Size(1156, 629);
            this.HistoricoTabPage.TabIndex = 1;
            this.HistoricoTabPage.Text = "Historico de Movimientos";
            this.HistoricoTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.BuscarIngresosButton);
            this.splitContainer2.Panel1.Controls.Add(this.FechaFinalDateTimePicker);
            this.splitContainer2.Panel1.Controls.Add(this.FechaInicialDateTimePicker);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1150, 623);
            this.splitContainer2.SplitterDistance = 104;
            this.splitContainer2.TabIndex = 0;
            // 
            // BuscarIngresosButton
            // 
            this.BuscarIngresosButton.Image = global::NeptunoSql.Windows.Properties.Resources.BuscarAE;
            this.BuscarIngresosButton.Location = new System.Drawing.Point(557, 9);
            this.BuscarIngresosButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarIngresosButton.Name = "BuscarIngresosButton";
            this.BuscarIngresosButton.Size = new System.Drawing.Size(105, 37);
            this.BuscarIngresosButton.TabIndex = 117;
            this.BuscarIngresosButton.Text = "Buscar";
            this.BuscarIngresosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarIngresosButton.UseVisualStyleBackColor = true;
            this.BuscarIngresosButton.Click += new System.EventHandler(this.BuscarIngresosButton_Click);
            // 
            // FechaFinalDateTimePicker
            // 
            this.FechaFinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFinalDateTimePicker.Location = new System.Drawing.Point(339, 14);
            this.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker";
            this.FechaFinalDateTimePicker.Size = new System.Drawing.Size(116, 20);
            this.FechaFinalDateTimePicker.TabIndex = 4;
            // 
            // FechaInicialDateTimePicker
            // 
            this.FechaInicialDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicialDateTimePicker.Location = new System.Drawing.Point(123, 15);
            this.FechaInicialDateTimePicker.Name = "FechaInicialDateTimePicker";
            this.FechaInicialDateTimePicker.Size = new System.Drawing.Size(116, 20);
            this.FechaInicialDateTimePicker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filtrar por fechas:";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.IngresosDataGridView);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.DetalleDdataGridView);
            this.splitContainer4.Size = new System.Drawing.Size(1150, 515);
            this.splitContainer4.SplitterDistance = 404;
            this.splitContainer4.TabIndex = 0;
            // 
            // IngresosDataGridView
            // 
            this.IngresosDataGridView.AllowUserToAddRows = false;
            this.IngresosDataGridView.AllowUserToDeleteRows = false;
            this.IngresosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngresosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIngreso,
            this.colReferencia,
            this.colFecha,
            this.colDetalle});
            this.IngresosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IngresosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.IngresosDataGridView.Name = "IngresosDataGridView";
            this.IngresosDataGridView.ReadOnly = true;
            this.IngresosDataGridView.Size = new System.Drawing.Size(404, 515);
            this.IngresosDataGridView.TabIndex = 0;
            // 
            // colIngreso
            // 
            this.colIngreso.HeaderText = "Nro. Ing.";
            this.colIngreso.Name = "colIngreso";
            this.colIngreso.ReadOnly = true;
            // 
            // colReferencia
            // 
            this.colReferencia.HeaderText = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colDetalle
            // 
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.ReadOnly = true;
            // 
            // DetalleDdataGridView
            // 
            this.DetalleDdataGridView.AllowUserToAddRows = false;
            this.DetalleDdataGridView.AllowUserToDeleteRows = false;
            this.DetalleDdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DetalleDdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetalleDdataGridView.Location = new System.Drawing.Point(0, 0);
            this.DetalleDdataGridView.MultiSelect = false;
            this.DetalleDdataGridView.Name = "DetalleDdataGridView";
            this.DetalleDdataGridView.ReadOnly = true;
            this.DetalleDdataGridView.RowHeadersVisible = false;
            this.DetalleDdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetalleDdataGridView.Size = new System.Drawing.Size(742, 515);
            this.DetalleDdataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // KardexTabPage
            // 
            this.KardexTabPage.Controls.Add(this.splitContainer3);
            this.KardexTabPage.Location = new System.Drawing.Point(4, 22);
            this.KardexTabPage.Name = "KardexTabPage";
            this.KardexTabPage.Size = new System.Drawing.Size(1156, 629);
            this.KardexTabPage.TabIndex = 2;
            this.KardexTabPage.Text = "Kardex";
            this.KardexTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.BuscarButton);
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            this.splitContainer3.Panel1.Controls.Add(this.IngresosLinkLabel);
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.KardexDataGridView);
            this.splitContainer3.Size = new System.Drawing.Size(1156, 629);
            this.splitContainer3.SplitterDistance = 385;
            this.splitContainer3.TabIndex = 0;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::NeptunoSql.Windows.Properties.Resources.BuscarAE;
            this.BuscarButton.Location = new System.Drawing.Point(25, 285);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(325, 55);
            this.BuscarButton.TabIndex = 117;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DescripcionTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CategoriaTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.MarcaTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(23, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 100);
            this.panel1.TabIndex = 5;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Location = new System.Drawing.Point(66, 63);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(261, 20);
            this.DescripcionTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Desc:";
            // 
            // CategoriaTextBox
            // 
            this.CategoriaTextBox.Enabled = false;
            this.CategoriaTextBox.Location = new System.Drawing.Point(66, 37);
            this.CategoriaTextBox.Name = "CategoriaTextBox";
            this.CategoriaTextBox.Size = new System.Drawing.Size(261, 20);
            this.CategoriaTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Categoría:";
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.Enabled = false;
            this.MarcaTextBox.Location = new System.Drawing.Point(66, 11);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(261, 20);
            this.MarcaTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Marca:";
            // 
            // IngresosLinkLabel
            // 
            this.IngresosLinkLabel.AutoSize = true;
            this.IngresosLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresosLinkLabel.Location = new System.Drawing.Point(86, 23);
            this.IngresosLinkLabel.Name = "IngresosLinkLabel";
            this.IngresosLinkLabel.Size = new System.Drawing.Size(218, 17);
            this.IngresosLinkLabel.TabIndex = 4;
            this.IngresosLinkLabel.TabStop = true;
            this.IngresosLinkLabel.Text = "[Click acá para ver los productos]";
            this.IngresosLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IngresosLinkLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Producto";
            // 
            // KardexDataGridView
            // 
            this.KardexDataGridView.AllowUserToAddRows = false;
            this.KardexDataGridView.AllowUserToDeleteRows = false;
            this.KardexDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KardexDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMovNro,
            this.colFechaKardex,
            this.colMovimiento,
            this.colEntrada,
            this.colSalida,
            this.colSaldo});
            this.KardexDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KardexDataGridView.Location = new System.Drawing.Point(0, 0);
            this.KardexDataGridView.Name = "KardexDataGridView";
            this.KardexDataGridView.ReadOnly = true;
            this.KardexDataGridView.Size = new System.Drawing.Size(767, 629);
            this.KardexDataGridView.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // colMovNro
            // 
            this.colMovNro.HeaderText = "Mov. Nro.";
            this.colMovNro.Name = "colMovNro";
            this.colMovNro.ReadOnly = true;
            // 
            // colFechaKardex
            // 
            this.colFechaKardex.HeaderText = "Fecha";
            this.colFechaKardex.Name = "colFechaKardex";
            this.colFechaKardex.ReadOnly = true;
            // 
            // colMovimiento
            // 
            this.colMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMovimiento.HeaderText = "Movimiento";
            this.colMovimiento.Name = "colMovimiento";
            this.colMovimiento.ReadOnly = true;
            // 
            // colEntrada
            // 
            this.colEntrada.HeaderText = "Entrada";
            this.colEntrada.Name = "colEntrada";
            this.colEntrada.ReadOnly = true;
            // 
            // colSalida
            // 
            this.colSalida.HeaderText = "Salida";
            this.colSalida.Name = "colSalida";
            this.colSalida.ReadOnly = true;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            // 
            // FrmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 734);
            this.Controls.Add(this.StockTabControl);
            this.Name = "FrmIngresos";
            this.Text = "FrmStockIn";
            this.Load += new System.EventHandler(this.FrmIngresos_Load);
            this.StockTabControl.ResumeLayout(false);
            this.StockInTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockInProductosDataGridView)).EndInit();
            this.HistoricoTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IngresosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDdataGridView)).EndInit();
            this.KardexTabPage.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KardexDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl StockTabControl;
        private System.Windows.Forms.TabPage StockInTabPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.LinkLabel ProductosLinkLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpleadoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReferenciaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StockInProductosDataGridView;
        private System.Windows.Forms.TabPage HistoricoTabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button BuscarIngresosButton;
        private System.Windows.Forms.DateTimePicker FechaFinalDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaInicialDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage KardexTabPage;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CategoriaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView KardexDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCantidad;
        private System.Windows.Forms.DataGridViewImageColumn cmnBorrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView IngresosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridView DetalleDdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.LinkLabel IngresosLinkLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaKardex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
    }
}
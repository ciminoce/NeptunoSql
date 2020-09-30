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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KardexTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.KardexTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePicker3);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(1150, 623);
            this.splitContainer2.SplitterDistance = 104;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = global::NeptunoSql.Windows.Properties.Resources.BuscarAE;
            this.button1.Location = new System.Drawing.Point(557, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 37);
            this.button1.TabIndex = 117;
            this.button1.Text = "Buscar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(339, 14);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(123, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 515);
            this.dataGridView1.TabIndex = 0;
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
            this.splitContainer3.Panel1.Controls.Add(this.dateTimePicker4);
            this.splitContainer3.Panel1.Controls.Add(this.dateTimePicker5);
            this.splitContainer3.Panel1.Controls.Add(this.label10);
            this.splitContainer3.Panel1.Controls.Add(this.label9);
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            this.splitContainer3.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView2);
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
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(150, 243);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 7;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(150, 208);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker5.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Fecha Final:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Fecha Inicial:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(23, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 100);
            this.panel1.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(66, 63);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(261, 20);
            this.textBox5.TabIndex = 1;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(66, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(261, 20);
            this.textBox4.TabIndex = 1;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(66, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 20);
            this.textBox3.TabIndex = 1;
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(86, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(218, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[Click acá para ver los productos]";
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(767, 629);
            this.dataGridView2.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.KardexTabPage.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage KardexTabPage;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCantidad;
        private System.Windows.Forms.DataGridViewImageColumn cmnBorrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
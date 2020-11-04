namespace NeptunoSql.Windows
{
    partial class FrmBuscarProductoConsulta
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
            this.ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSeleccionar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosDataGridView
            // 
            this.ProductosDataGridView.AllowUserToAddRows = false;
            this.ProductosDataGridView.AllowUserToDeleteRows = false;
            this.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnProducto,
            this.cmnSeleccionar});
            this.ProductosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ProductosDataGridView.MultiSelect = false;
            this.ProductosDataGridView.Name = "ProductosDataGridView";
            this.ProductosDataGridView.ReadOnly = true;
            this.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductosDataGridView.Size = new System.Drawing.Size(640, 561);
            this.ProductosDataGridView.TabIndex = 125;
            this.ProductosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductosDataGridView_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Agregar";
            this.dataGridViewImageColumn1.Image = global::NeptunoSql.Windows.Properties.Resources.ok_15px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // cmnProducto
            // 
            this.cmnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnProducto.HeaderText = "Producto";
            this.cmnProducto.Name = "cmnProducto";
            this.cmnProducto.ReadOnly = true;
            // 
            // cmnSeleccionar
            // 
            this.cmnSeleccionar.HeaderText = "Seleccionar";
            this.cmnSeleccionar.Image = global::NeptunoSql.Windows.Properties.Resources.ok_15px;
            this.cmnSeleccionar.Name = "cmnSeleccionar";
            this.cmnSeleccionar.ReadOnly = true;
            // 
            // FrmBuscarProductoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 601);
            this.Controls.Add(this.ProductosDataGridView);
            this.Name = "FrmBuscarProductoConsulta";
            this.Text = "FrmBuscarProductoConsulta";
            this.Load += new System.EventHandler(this.FrmBuscarProductoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnProducto;
        private System.Windows.Forms.DataGridViewImageColumn cmnSeleccionar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
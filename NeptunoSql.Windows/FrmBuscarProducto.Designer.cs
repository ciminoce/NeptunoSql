namespace NeptunoSql.Windows
{
    partial class FrmBuscarProducto
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
            this.ComboBoxMarcas = new System.Windows.Forms.ComboBox();
            this.ComboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.cmnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PasarTodosButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxMarcas
            // 
            this.ComboBoxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMarcas.FormattingEnabled = true;
            this.ComboBoxMarcas.Location = new System.Drawing.Point(93, 54);
            this.ComboBoxMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxMarcas.Name = "ComboBoxMarcas";
            this.ComboBoxMarcas.Size = new System.Drawing.Size(269, 21);
            this.ComboBoxMarcas.TabIndex = 121;
            // 
            // ComboBoxCategorias
            // 
            this.ComboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategorias.FormattingEnabled = true;
            this.ComboBoxCategorias.Location = new System.Drawing.Point(95, 23);
            this.ComboBoxCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxCategorias.Name = "ComboBoxCategorias";
            this.ComboBoxCategorias.Size = new System.Drawing.Size(267, 21);
            this.ComboBoxCategorias.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 118;
            this.label3.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 119;
            this.label2.Text = "Categoría:";
            // 
            // ProductosDataGridView
            // 
            this.ProductosDataGridView.AllowUserToAddRows = false;
            this.ProductosDataGridView.AllowUserToDeleteRows = false;
            this.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnProducto,
            this.cmnAgregar});
            this.ProductosDataGridView.Location = new System.Drawing.Point(20, 100);
            this.ProductosDataGridView.MultiSelect = false;
            this.ProductosDataGridView.Name = "ProductosDataGridView";
            this.ProductosDataGridView.ReadOnly = true;
            this.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductosDataGridView.Size = new System.Drawing.Size(640, 561);
            this.ProductosDataGridView.TabIndex = 117;
            this.ProductosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductosDataGridView_CellClick);
            // 
            // cmnProducto
            // 
            this.cmnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnProducto.HeaderText = "Producto";
            this.cmnProducto.Name = "cmnProducto";
            this.cmnProducto.ReadOnly = true;
            // 
            // cmnAgregar
            // 
            this.cmnAgregar.HeaderText = "Agregar";
            this.cmnAgregar.Image = global::NeptunoSql.Windows.Properties.Resources.ok_15px;
            this.cmnAgregar.Name = "cmnAgregar";
            this.cmnAgregar.ReadOnly = true;
            // 
            // PasarTodosButton
            // 
            this.PasarTodosButton.Image = global::NeptunoSql.Windows.Properties.Resources.advance_24px;
            this.PasarTodosButton.Location = new System.Drawing.Point(676, 223);
            this.PasarTodosButton.Margin = new System.Windows.Forms.Padding(4);
            this.PasarTodosButton.Name = "PasarTodosButton";
            this.PasarTodosButton.Size = new System.Drawing.Size(105, 55);
            this.PasarTodosButton.TabIndex = 122;
            this.PasarTodosButton.Text = "Pasar todo";
            this.PasarTodosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PasarTodosButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::NeptunoSql.Windows.Properties.Resources.BuscarAE;
            this.BuscarButton.Location = new System.Drawing.Point(379, 20);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(105, 55);
            this.BuscarButton.TabIndex = 123;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // FrmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 681);
            this.Controls.Add(this.PasarTodosButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ComboBoxMarcas);
            this.Controls.Add(this.ComboBoxCategorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductosDataGridView);
            this.Name = "FrmBuscarProducto";
            this.Text = "FrmBuscarProducto";
            this.Load += new System.EventHandler(this.FrmBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PasarTodosButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ComboBox ComboBoxMarcas;
        private System.Windows.Forms.ComboBox ComboBoxCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnProducto;
        private System.Windows.Forms.DataGridViewImageColumn cmnAgregar;
    }
}
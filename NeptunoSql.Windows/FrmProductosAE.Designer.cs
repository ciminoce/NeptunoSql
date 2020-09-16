namespace NeptunoSql.Windows
{
    partial class FrmProductosAE
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
            this.CheckBoxSuspendido = new System.Windows.Forms.CheckBox();
            this.TextBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBoxMarcas = new System.Windows.Forms.ComboBox();
            this.ComboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.TextBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxMedidas = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.btnAgregarMedida = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxSuspendido
            // 
            this.CheckBoxSuspendido.AutoSize = true;
            this.CheckBoxSuspendido.Location = new System.Drawing.Point(484, 288);
            this.CheckBoxSuspendido.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxSuspendido.Name = "CheckBoxSuspendido";
            this.CheckBoxSuspendido.Size = new System.Drawing.Size(100, 20);
            this.CheckBoxSuspendido.TabIndex = 94;
            this.CheckBoxSuspendido.Text = "Suspendido";
            this.CheckBoxSuspendido.UseVisualStyleBackColor = true;
            // 
            // TextBoxPrecioVenta
            // 
            this.TextBoxPrecioVenta.Location = new System.Drawing.Point(146, 285);
            this.TextBoxPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPrecioVenta.Name = "TextBoxPrecioVenta";
            this.TextBoxPrecioVenta.Size = new System.Drawing.Size(132, 22);
            this.TextBoxPrecioVenta.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Precio Venta:";
            // 
            // ComboBoxMarcas
            // 
            this.ComboBoxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMarcas.FormattingEnabled = true;
            this.ComboBoxMarcas.Location = new System.Drawing.Point(146, 88);
            this.ComboBoxMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxMarcas.Name = "ComboBoxMarcas";
            this.ComboBoxMarcas.Size = new System.Drawing.Size(447, 24);
            this.ComboBoxMarcas.TabIndex = 90;
            // 
            // ComboBoxCategorias
            // 
            this.ComboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategorias.FormattingEnabled = true;
            this.ComboBoxCategorias.Location = new System.Drawing.Point(146, 25);
            this.ComboBoxCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxCategorias.Name = "ComboBoxCategorias";
            this.ComboBoxCategorias.Size = new System.Drawing.Size(447, 24);
            this.ComboBoxCategorias.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "Marca:";
            // 
            // TextBoxCodigoDeBarras
            // 
            this.TextBoxCodigoDeBarras.Location = new System.Drawing.Point(146, 243);
            this.TextBoxCodigoDeBarras.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCodigoDeBarras.MaxLength = 20;
            this.TextBoxCodigoDeBarras.Name = "TextBoxCodigoDeBarras";
            this.TextBoxCodigoDeBarras.Size = new System.Drawing.Size(447, 22);
            this.TextBoxCodigoDeBarras.TabIndex = 92;
            // 
            // TextBoxDescripcion
            // 
            this.TextBoxDescripcion.Location = new System.Drawing.Point(146, 137);
            this.TextBoxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxDescripcion.MaxLength = 150;
            this.TextBoxDescripcion.Multiline = true;
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.Size = new System.Drawing.Size(544, 83);
            this.TextBoxDescripcion.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 81;
            this.label5.Text = "Código de Barras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Medida:";
            // 
            // ComboBoxMedidas
            // 
            this.ComboBoxMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMedidas.FormattingEnabled = true;
            this.ComboBoxMedidas.Location = new System.Drawing.Point(146, 339);
            this.ComboBoxMedidas.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxMedidas.Name = "ComboBoxMedidas";
            this.ComboBoxMedidas.Size = new System.Drawing.Size(447, 24);
            this.ComboBoxMedidas.TabIndex = 90;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::NeptunoSql.Windows.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(759, 425);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 63);
            this.btnCancelar.TabIndex = 100;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::NeptunoSql.Windows.Properties.Resources.Aceptar;
            this.btnGuardar.Location = new System.Drawing.Point(347, 425);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 63);
            this.btnGuardar.TabIndex = 101;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Image = global::NeptunoSql.Windows.Properties.Resources.BuscarAE;
            this.btnBuscarImagen.Location = new System.Drawing.Point(842, 329);
            this.btnBuscarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(201, 73);
            this.btnBuscarImagen.TabIndex = 99;
            this.btnBuscarImagen.Text = "Buscar Imagen";
            this.btnBuscarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // picProducto
            // 
            this.picProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProducto.Location = new System.Drawing.Point(719, 8);
            this.picProducto.Margin = new System.Windows.Forms.Padding(4);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(423, 313);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProducto.TabIndex = 98;
            this.picProducto.TabStop = false;
            // 
            // btnAgregarMedida
            // 
            this.btnAgregarMedida.Image = global::NeptunoSql.Windows.Properties.Resources.AgregarAE;
            this.btnAgregarMedida.Location = new System.Drawing.Point(616, 321);
            this.btnAgregarMedida.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMedida.Name = "btnAgregarMedida";
            this.btnAgregarMedida.Size = new System.Drawing.Size(75, 58);
            this.btnAgregarMedida.TabIndex = 96;
            this.btnAgregarMedida.Text = "Agregar";
            this.btnAgregarMedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarMedida.UseVisualStyleBackColor = true;
            this.btnAgregarMedida.Click += new System.EventHandler(this.btnAgregarMedida_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Image = global::NeptunoSql.Windows.Properties.Resources.AgregarAE;
            this.btnAgregarMarca.Location = new System.Drawing.Point(616, 70);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 58);
            this.btnAgregarMarca.TabIndex = 96;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Image = global::NeptunoSql.Windows.Properties.Resources.AgregarAE;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(616, 8);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 58);
            this.btnAgregarCategoria.TabIndex = 95;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // FrmProductosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 501);
            this.ControlBox = false;
            this.Controls.Add(this.TextBoxPrecioVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(this.picProducto);
            this.Controls.Add(this.btnAgregarMedida);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.CheckBoxSuspendido);
            this.Controls.Add(this.ComboBoxMedidas);
            this.Controls.Add(this.ComboBoxMarcas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxCategorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxCodigoDeBarras);
            this.Controls.Add(this.TextBoxDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1168, 540);
            this.MinimumSize = new System.Drawing.Size(1168, 540);
            this.Name = "FrmProductosAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductosAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarImagen;
        private System.Windows.Forms.PictureBox picProducto;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.CheckBox CheckBoxSuspendido;
        private System.Windows.Forms.TextBox TextBoxPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBoxMarcas;
        private System.Windows.Forms.ComboBox ComboBoxCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxCodigoDeBarras;
        private System.Windows.Forms.TextBox TextBoxDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxMedidas;
        private System.Windows.Forms.Button btnAgregarMedida;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
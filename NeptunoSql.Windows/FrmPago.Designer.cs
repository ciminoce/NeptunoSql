namespace NeptunoSql.Windows
{
    partial class FrmPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.ImporteTotalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VentaNroTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VueltoTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe a Pagar:";
            // 
            // ImporteTotalTextBox
            // 
            this.ImporteTotalTextBox.Enabled = false;
            this.ImporteTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteTotalTextBox.Location = new System.Drawing.Point(226, 75);
            this.ImporteTotalTextBox.Name = "ImporteTotalTextBox";
            this.ImporteTotalTextBox.Size = new System.Drawing.Size(193, 26);
            this.ImporteTotalTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Venta Nro:";
            // 
            // VentaNroTextBox
            // 
            this.VentaNroTextBox.Enabled = false;
            this.VentaNroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentaNroTextBox.Location = new System.Drawing.Point(226, 43);
            this.VentaNroTextBox.Name = "VentaNroTextBox";
            this.VentaNroTextBox.Size = new System.Drawing.Size(193, 26);
            this.VentaNroTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingrese el Importe Pagado:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(226, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Su vuelto::";
            // 
            // VueltoTextBox
            // 
            this.VueltoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VueltoTextBox.Location = new System.Drawing.Point(226, 139);
            this.VueltoTextBox.Name = "VueltoTextBox";
            this.VueltoTextBox.Size = new System.Drawing.Size(193, 26);
            this.VueltoTextBox.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Image = global::NeptunoSql.Windows.Properties.Resources.Aceptar;
            this.OKButton.Location = new System.Drawing.Point(177, 202);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(166, 65);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 279);
            this.ControlBox = false;
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.VentaNroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VueltoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImporteTotalTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(560, 318);
            this.MinimumSize = new System.Drawing.Size(560, 318);
            this.Name = "FrmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago de Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImporteTotalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VentaNroTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VueltoTextBox;
        private System.Windows.Forms.Button OKButton;
    }
}
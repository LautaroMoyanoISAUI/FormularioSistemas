namespace ProyectoIsaui
{
    partial class FrmProducto
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
            this.GbProducto = new System.Windows.Forms.GroupBox();
            this.lblstock = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GbProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbProducto
            // 
            this.GbProducto.Controls.Add(this.lblstock);
            this.GbProducto.Controls.Add(this.txtstock);
            this.GbProducto.Controls.Add(this.txtCodProducto);
            this.GbProducto.Controls.Add(this.label1);
            this.GbProducto.Controls.Add(this.txtCodBarra);
            this.GbProducto.Controls.Add(this.btncancelar);
            this.GbProducto.Controls.Add(this.btnguardar);
            this.GbProducto.Controls.Add(this.txtprecio);
            this.GbProducto.Controls.Add(this.lblprecio);
            this.GbProducto.Controls.Add(this.txtNombre);
            this.GbProducto.Controls.Add(this.LblNombre);
            this.GbProducto.Location = new System.Drawing.Point(40, 15);
            this.GbProducto.Margin = new System.Windows.Forms.Padding(4);
            this.GbProducto.Name = "GbProducto";
            this.GbProducto.Padding = new System.Windows.Forms.Padding(4);
            this.GbProducto.Size = new System.Drawing.Size(514, 531);
            this.GbProducto.TabIndex = 0;
            this.GbProducto.TabStop = false;
            this.GbProducto.Text = "Informacion del producto";
            this.GbProducto.Enter += new System.EventHandler(this.GbProducto_Enter);
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Location = new System.Drawing.Point(57, 254);
            this.lblstock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(41, 16);
            this.lblstock.TabIndex = 9;
            this.lblstock.Text = "Stock";
            this.lblstock.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(143, 251);
            this.txtstock.Margin = new System.Windows.Forms.Padding(4);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(321, 22);
            this.txtstock.TabIndex = 8;
            this.txtstock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(374, 501);
            this.txtCodProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(132, 22);
            this.txtCodProducto.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo de Barra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(144, 192);
            this.txtCodBarra.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(321, 22);
            this.txtCodBarra.TabIndex = 4;
            this.txtCodBarra.TextChanged += new System.EventHandler(this.txtCodBarra_TextChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(345, 421);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 28);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(87, 421);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 28);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(144, 127);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(321, 22);
            this.txtprecio.TabIndex = 3;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(52, 130);
            this.lblprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(46, 16);
            this.lblprecio.TabIndex = 2;
            this.lblprecio.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(321, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(52, 67);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 16);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 559);
            this.Controls.Add(this.GbProducto);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmProducto";
            this.Text = "Formulario de Producto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.GbProducto.ResumeLayout(false);
            this.GbProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbProducto;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.TextBox txtstock;
    }
}
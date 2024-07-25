namespace InventoryApp
{
    partial class FormSalidaProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(100, 30);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(200, 20);
            this.txtProductId.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(100, 70);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 20);
            this.txtCantidad.TabIndex = 1;
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Location = new System.Drawing.Point(100, 110);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarSalida.TabIndex = 2;
            this.btnRegistrarSalida.Text = "Registrar Salida";
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(30, 33);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(58, 13);
            this.lblProductId.TabIndex = 3;
            this.lblProductId.Text = "ID Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(30, 73);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // FormSalidaProducto
            // 
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.btnRegistrarSalida);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProductId);
            this.Name = "FormSalidaProducto";
            this.Text = "Salida de Producto";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnRegistrarSalida;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblCantidad;
    }
}

namespace InventoryApp
{
    partial class FormKardex
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
            this.dataGridViewKardex = new System.Windows.Forms.DataGridView();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.lblKardex = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKardex
            // 
            this.dataGridViewKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKardex.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewKardex.Name = "dataGridViewKardex";
            this.dataGridViewKardex.Size = new System.Drawing.Size(760, 200);
            this.dataGridViewKardex.TabIndex = 0;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 255);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(760, 200);
            this.dataGridViewProducts.TabIndex = 1;
            // 
            // lblKardex
            // 
            this.lblKardex.AutoSize = true;
            this.lblKardex.Location = new System.Drawing.Point(12, 9);
            this.lblKardex.Name = "lblKardex";
            this.lblKardex.Size = new System.Drawing.Size(41, 13);
            this.lblKardex.TabIndex = 2;
            this.lblKardex.Text = "Kardex";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(12, 239);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(55, 13);
            this.lblProducts.TabIndex = 3;
            this.lblProducts.Text = "Productos";
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Location = new System.Drawing.Point(12, 480);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrarSalida.TabIndex = 4;
            this.btnRegistrarSalida.Text = "Registrar Salida";
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(130, 485);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 20);
            this.txtProductId.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(250, 485);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(370, 480);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(490, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormKardex
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.btnRegistrarSalida);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblKardex);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.dataGridViewKardex);
            this.Name = "FormKardex";
            this.Text = "Kardex y Stock";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewKardex;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label lblKardex;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnRegistrarSalida;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

namespace InventoryApp
{
    partial class MainForm
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
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.btnSalidaProducto = new System.Windows.Forms.Button();
            this.btnKardex = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(12, 12);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(260, 40);
            this.btnCreateProduct.TabIndex = 0;
            this.btnCreateProduct.Text = "Crear Producto";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // btnSalidaProducto
            // 
            this.btnSalidaProducto.Location = new System.Drawing.Point(12, 58);
            this.btnSalidaProducto.Name = "btnSalidaProducto";
            this.btnSalidaProducto.Size = new System.Drawing.Size(260, 40);
            this.btnSalidaProducto.TabIndex = 1;
            this.btnSalidaProducto.Text = "Salida de Producto";
            this.btnSalidaProducto.UseVisualStyleBackColor = true;
            this.btnSalidaProducto.Click += new System.EventHandler(this.btnSalidaProducto_Click);
            // 
            // btnKardex
            // 
            this.btnKardex.Location = new System.Drawing.Point(12, 104);
            this.btnKardex.Name = "btnKardex";
            this.btnKardex.Size = new System.Drawing.Size(260, 40);
            this.btnKardex.TabIndex = 2;
            this.btnKardex.Text = "Kardex y Stock";
            this.btnKardex.UseVisualStyleBackColor = true;
            this.btnKardex.Click += new System.EventHandler(this.btnKardex_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(12, 150);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(260, 40);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Text = "Editar Producto";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(12, 196);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(260, 40);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Eliminar Producto";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(300, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewProducts.TabIndex = 5;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(914, 361);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnKardex);
            this.Controls.Add(this.btnSalidaProducto);
            this.Controls.Add(this.btnCreateProduct);
            this.Name = "MainForm";
            this.Text = "Inventario de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Button btnSalidaProducto;
        private System.Windows.Forms.Button btnKardex;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
    }
}

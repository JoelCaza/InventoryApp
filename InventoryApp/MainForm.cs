using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using InventoryApp.Models;

namespace InventoryApp
{
    public partial class MainForm : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7206/api/") };
        private List<Product> products;

        public MainForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private async void LoadProducts()
        {
            products = await client.GetFromJsonAsync<List<Product>>("products");
            dataGridViewProducts.DataSource = products;
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            FormCreateProduct formCreateProduct = new FormCreateProduct();
            formCreateProduct.ShowDialog();
            LoadProducts();
        }

        private void btnSalidaProducto_Click(object sender, EventArgs e)
        {
            FormSalidaProducto formSalidaProducto = new FormSalidaProducto();
            formSalidaProducto.ShowDialog();
            LoadProducts();
        }

        private void btnKardex_Click(object sender, EventArgs e)
        {
            FormKardex formKardex = new FormKardex();
            formKardex.ShowDialog();
            LoadProducts();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productId = (int)dataGridViewProducts.SelectedRows[0].Cells["Id"].Value;
                Product selectedProduct = GetProductById(productId);
                if (selectedProduct != null)
                {
                    FormEditProduct formEditProduct = new FormEditProduct(selectedProduct);
                    formEditProduct.ShowDialog();
                    LoadProducts();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productId = (int)dataGridViewProducts.SelectedRows[0].Cells["Id"].Value;
                Product selectedProduct = GetProductById(productId);
                if (selectedProduct != null)
                {
                    FormDeleteProduct formDeleteProduct = new FormDeleteProduct(selectedProduct);
                    formDeleteProduct.ShowDialog();
                    LoadProducts();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }
        }

        private Product GetProductById(int productId)
        {
            return products.Find(p => p.Id == productId);
        }
    }
}

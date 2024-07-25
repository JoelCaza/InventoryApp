using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryApp.Models;

namespace InventoryApp
{
    public partial class FormKardex : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7206/api/") };

        public FormKardex()
        {
            InitializeComponent();
            LoadKardexData();
        }

        private async void LoadKardexData()
        {
            var kardexData = await client.GetFromJsonAsync<Kardex[]>("kardex");
            dataGridViewKardex.DataSource = kardexData;

            var productData = await client.GetFromJsonAsync<Product[]>("products");
            dataGridViewProducts.DataSource = productData;
        }

        private async void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductId.Text, out int productId) && int.TryParse(txtCantidad.Text, out int quantity))
            {
                var kardexEntry = new Kardex
                {
                    ProductId = productId,
                    Quantity = quantity,
                    Type = "Salida",
                    Date = DateTime.Now
                };

                var response = await client.PostAsJsonAsync("kardex", kardexEntry);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Salida registrada con éxito.");
                    LoadKardexData();
                }
                else
                {
                    MessageBox.Show("Error al registrar la salida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para el ID de Producto y la Cantidad.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productId = (int)dataGridViewProducts.SelectedRows[0].Cells["Id"].Value;
                var selectedProduct = GetProductById(productId);
                if (selectedProduct != null)
                {
                    var formEditProduct = new FormEditProduct(selectedProduct);
                    formEditProduct.ShowDialog();
                    LoadKardexData();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productId = (int)dataGridViewProducts.SelectedRows[0].Cells["Id"].Value;
                var selectedProduct = GetProductById(productId);
                if (selectedProduct != null)
                {
                    var formDeleteProduct = new FormDeleteProduct(selectedProduct);
                    formDeleteProduct.ShowDialog();
                    LoadKardexData();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }

        private Product GetProductById(int productId)
        {
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                var product = row.DataBoundItem as Product;
                if (product != null && product.Id == productId)
                {
                    return product;
                }
            }
            return null;
        }
    }
}

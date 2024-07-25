using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using InventoryApp.Models;

namespace InventoryApp
{
    public partial class FormEditProduct : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7206/api/") };
        private Product product;

        public FormEditProduct(Product selectedProduct)
        {
            InitializeComponent();
            product = selectedProduct;
            LoadProductData();
        }

        private void LoadProductData()
        {
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtStock.Text = product.Stock.ToString();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            product.Name = txtName.Text;
            product.Price = price;
            product.Stock = int.Parse(txtStock.Text);

            try
            {
                var response = await client.PutAsJsonAsync($"products/{product.Id}", product);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto actualizado con éxito.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto.");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer la conexión con el servidor: " + ex.Message);
            }
        }
    }
}

using System;
using System.Net.Http;
using System.Windows.Forms;
using InventoryApp.Models;

namespace InventoryApp
{
    public partial class FormDeleteProduct : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7206/api/") };
        private Product product;

        public FormDeleteProduct(Product selectedProduct)
        {
            InitializeComponent();
            product = selectedProduct;
            DisplayProductData();
        }

        private void DisplayProductData()
        {
            lblProductName.Text = $"Nombre: {product.Name}";
            lblProductPrice.Text = $"Precio: {product.Price:C}";
            lblProductStock.Text = $"Stock: {product.Stock}";
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?",
                                     "Confirmar Eliminación",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var response = await client.DeleteAsync($"products/{product.Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto eliminado con éxito.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto.");
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("No se pudo establecer la conexión con el servidor: " + ex.Message);
                }
            }
        }
    }
}

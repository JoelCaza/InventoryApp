using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using InventoryApp.Models;

namespace InventoryApp
{
    public partial class FormCreateProduct : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7206/api/") };

        public FormCreateProduct()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            var product = new Product
            {
                Name = txtName.Text,
                Price = price,
                Stock = int.Parse(txtStock.Text)
            };

            try
            {
                var response = await client.PostAsJsonAsync("products", product);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto guardado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al guardar el producto.");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer la conexión con el servidor: " + ex.Message);
            }
        }
    }
}

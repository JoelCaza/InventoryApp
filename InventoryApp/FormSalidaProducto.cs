using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using InventoryApp.Models;

namespace InventoryApp
{
    public partial class FormSalidaProducto : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7206/api/") };

        public FormSalidaProducto()
        {
            InitializeComponent();
        }

        private async void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            var kardex = new Kardex
            {
                ProductId = int.Parse(txtProductId.Text),
                Quantity = int.Parse(txtCantidad.Text),
                Type = "Salida",
                Date = DateTime.Now
            };

            try
            {
                var response = await client.PostAsJsonAsync("kardex", kardex);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Salida registrada con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al registrar la salida.");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer la conexión con el servidor: " + ex.Message);
            }
        }
    }
}

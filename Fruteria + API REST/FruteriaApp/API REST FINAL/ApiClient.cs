using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API_REST_FINAL
{
    // --- MODELOS DE DATOS ---
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public float preciokg { get; set; }
        public float stockkg { get; set; }
    }

    public class Venta
    {
        public int producto_id { get; set; }
        public float kilos { get; set; }
    }

    // --- CLIENTE API (LÓGICA PURA) ---
    public class ApiClient
    {
        private readonly HttpClient _client;
        private string _baseUrl = "http://127.0.0.1:8000"; // Asegúrate que tu Python corre aquí

        public ApiClient()
        {
            _client = new HttpClient();
        }

        // 1. GET: Obtener lista de productos
        public async Task<List<Producto>> GetProductosAsync()
        {
            var json = await _client.GetStringAsync($"{_baseUrl}/productos");
            return JsonConvert.DeserializeObject<List<Producto>>(json);
        }

        // 2. POST: Crear nuevo producto
        public async Task CrearProductoAsync(Producto p)
        {
            var json = JsonConvert.SerializeObject(p);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/productos", content);
            if (!response.IsSuccessStatusCode) throw new Exception("Error al crear producto");
        }

        // 3. PUT: Actualizar producto (Lo tenías pendiente)
        public async Task ActualizarProductoAsync(int id, Producto p)
        {
            var json = JsonConvert.SerializeObject(p);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/productos/{id}", content);
            if (!response.IsSuccessStatusCode) throw new Exception("Error al actualizar producto");
        }

        // 4. DELETE: Borrar producto (Lo tenías pendiente)
        public async Task EliminarProductoAsync(int id)
        {
            var response = await _client.DeleteAsync($"{_baseUrl}/productos/{id}");
            if (!response.IsSuccessStatusCode) throw new Exception("Error al eliminar producto");
        }

        // 5. POST: Registrar Venta
        public async Task RegistrarVentaAsync(Venta v)
        {
            var json = JsonConvert.SerializeObject(v);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/ventas", content);
            if (!response.IsSuccessStatusCode) throw new Exception("Error en venta (quizás falta stock)");
        }

        // 6. GET: Obtener historial de ventas (Para los informes)
        public async Task<List<Venta>> GetVentasAsync()
        {
            var json = await _client.GetStringAsync($"{_baseUrl}/ventas");
            return JsonConvert.DeserializeObject<List<Venta>>(json);
        }
    }
}
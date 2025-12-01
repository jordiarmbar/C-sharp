using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_REST_FINAL
{
    public partial class FormVentas : Form
    {
        private ApiClient _api;
        private List<Producto> _catalogo; // Lista completa de productos (para precios)
        private List<ItemCarrito> _carrito; // Lo que el usuario va añadiendo

        // Constructor
        public FormVentas(ApiClient client)
        {
            InitializeComponent();
            _api = client;
            _carrito = new List<ItemCarrito>();
            _catalogo = new List<Producto>();
        }

        // Carga inicial
        private async void FormVentas_Load(object sender, EventArgs e)
        {
            await CargarProductos();
        }

        // --- LÓGICA AUXILIAR ---

        private async Task CargarProductos()
        {
            try
            {
                _catalogo = await _api.GetProductosAsync();

                // Configuramos el ComboBox
                cmbProductos.DataSource = _catalogo;
                cmbProductos.DisplayMember = "nombre";
                cmbProductos.ValueMember = "id";

                cmbProductos.SelectedIndex = -1; // Que empiece vacío
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void ActualizarInterfazCarrito()
        {
            // Refrescar tabla visualmente
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = _carrito;

            // Ocultar columnas feas (opcional)
            if (dgvCarrito.Columns["IdProducto"] != null)
                dgvCarrito.Columns["IdProducto"].Visible = false;

            // Calcular Total 
            float total = _carrito.Sum(x => x.Subtotal);
            lblTotal.Text = $"Total: {total:F2} €";
        }

        // --- EVENTOS DE BOTONES (Los que terminan en _1 funcionan) ---

        // Botón AÑADIR (Evento Activo)
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Validaciones
            if (cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }
            if (numKilos.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.");
                return;
            }

            // Recuperar datos del producto seleccionado
            Producto productoSeleccionado = (Producto)cmbProductos.SelectedItem;

            // Crear item del carrito
            ItemCarrito item = new ItemCarrito
            {
                IdProducto = productoSeleccionado.id,
                Nombre = productoSeleccionado.nombre,
                PrecioKg = productoSeleccionado.preciokg,
                Kilos = (float)numKilos.Value,
                Subtotal = productoSeleccionado.preciokg * (float)numKilos.Value
            };

            // Guardar y refrescar
            _carrito.Add(item);
            ActualizarInterfazCarrito();
        }

        // Botón CONFIRMAR (Evento Activo)
        private async void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (_carrito.Count == 0) return;

            try
            {
                // Enviar ventas una a una a la API
                foreach (var item in _carrito)
                {
                    Venta ventaApi = new Venta
                    {
                        producto_id = item.IdProducto,
                        kilos = item.Kilos
                    };
                    await _api.RegistrarVentaAsync(ventaApi);
                }

                MessageBox.Show("¡Venta realizada con éxito!");

                // Resetear formulario
                _carrito.Clear();
                ActualizarInterfazCarrito();
                numKilos.Value = 0;
                cmbProductos.SelectedIndex = -1;

                // Recargar catálogo para tener stock actualizado
                await CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error (posiblemente falta stock): " + ex.Message);
            }
        }

        // Botón VOLVER (Si lo tienes)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- EVENTOS VACÍOS (Para que no falle el diseñador) ---
        // (Déjalos aquí abajo tal cual)

        private void btnAgregar_Click(object sender, EventArgs e) { } // Antiguo
        private void btnConfirmar_Click(object sender, EventArgs e) { } // Antiguo
        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numKilos_ValueChanged(object sender, EventArgs e) { }
        private void lblTotal_Click(object sender, EventArgs e) { }
    }

    // Clase para mostrar datos bonitos en la tabla
    public class ItemCarrito
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public float PrecioKg { get; set; }
        public float Kilos { get; set; }
        public float Subtotal { get; set; }
    }
}
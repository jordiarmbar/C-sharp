using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_REST_FINAL
{
    public partial class FormCatalogo : Form
    {
        private ApiClient _api;

        // Constructor
        public FormCatalogo(ApiClient client)
        {
            InitializeComponent();
            _api = client;
        }

        // Evento Load (Al abrir la ventana)
        private async void FormCatalogo_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        // --- FUNCIONES AUXILIARES (Lógica pura) ---

        private async Task CargarDatos()
        {
            try
            {
                List<Producto> lista = await _api.GetProductosAsync();
                dgvProductos.DataSource = lista;
                dgvProductos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la API: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtCategoria.Text = "";
            numPrecio.Value = 0;
            numStock.Value = 0;
            dgvProductos.ClearSelection();
            txtId.Enabled = true;
        }

        // --- EVENTOS ACTIVOS (Los que tienen el _1 son los que estás usando ahora) ---

        // Botón CARGAR
        private async void btnCargar_Click_1(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        // Botón GUARDAR
        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Por favor, escribe un ID.");
                return;
            }

            try
            {
                var nuevoProd = new Producto
                {
                    id = int.Parse(txtId.Text),
                    nombre = txtNombre.Text,
                    categoria = txtCategoria.Text,
                    preciokg = (float)numPrecio.Value,
                    stockkg = (float)numStock.Value
                };

                await _api.CrearProductoAsync(nuevoProd);
                MessageBox.Show("Producto creado correctamente");

                LimpiarCampos();
                await CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // Botón ELIMINAR
        private async void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                var producto = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show($"¿Borrar {producto.nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        await _api.EliminarProductoAsync(producto.id);
                        LimpiarCampos();
                        await CargarDatos();
                    }
                    catch (Exception ex) { MessageBox.Show("Error al eliminar: " + ex.Message); }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila primero.");
            }
        }

        // Botón LIMPIAR
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Evento de Selección de Tabla (Este no suele tener _1 a menos que lo borraras antes)
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                var producto = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;

                txtId.Text = producto.id.ToString();
                txtNombre.Text = producto.nombre;
                txtCategoria.Text = producto.categoria;
                numPrecio.Value = (decimal)producto.preciokg;
                numStock.Value = (decimal)producto.stockkg;

                // Bloqueamos el ID para que no lo cambien al editar (opcional)
                txtId.Enabled = false;
            }
        }

        // --- EVENTOS VACÍOS ---
        // (Visual Studio los necesita porque hiciste doble clic en ellos, 
        //  si los borras el diseñador dará error, así que déjalos vacíos aquí)

        private void txtId_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtCategoria_TextChanged(object sender, EventArgs e) { }
        private void numStock_ValueChanged(object sender, EventArgs e) { }
        private void numPrecio_ValueChanged(object sender, EventArgs e) { }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // Si tienes un botón EDITAR, usa este código (asegúrate de conectarlo en el rayo)
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            // Pega aquí la lógica de editar si creas ese botón
        }

        private void FormCatalogo_Load_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
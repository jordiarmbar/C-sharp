using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_REST_FINAL
{
    public partial class FormInformes : Form
    {
        private ApiClient _api;

        public FormInformes(ApiClient client)
        {
            InitializeComponent();
            _api = client;
        }

        private async void FormInformes_Load(object sender, EventArgs e)
        {
            await GenerarInforme();
        }

        private async Task GenerarInforme()
        {
            try
            {
                List<Venta> ventas = await _api.GetVentasAsync();
                List<Producto> productos = await _api.GetProductosAsync();

                if (ventas == null || ventas.Count == 0)
                {
                    lblIngresos.Text = "Total Ingresos: 0,00 €";
                    lblNumVentas.Text = "Nº Ventas: 0";
                    lblTotalKilos.Text = "Total Kilos: 0 kg";
                    lblProductoEstrella.Text = "Producto Estrella: -";
                    AlinearTodo(); // Centramos aunque esté vacío
                    return;
                }

                float totalDinero = 0;
                float totalKilos = 0;
                Dictionary<int, float> ranking = new Dictionary<int, float>();

                foreach (var venta in ventas)
                {
                    var producto = productos.FirstOrDefault(p => p.id == venta.producto_id);
                    if (producto != null)
                    {
                        totalDinero += producto.preciokg * venta.kilos;
                        totalKilos += venta.kilos;

                        if (ranking.ContainsKey(producto.id))
                            ranking[producto.id] += venta.kilos;
                        else
                            ranking[producto.id] = venta.kilos;
                    }
                }

                var idGanador = ranking.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                var nombreGanador = productos.First(p => p.id == idGanador).nombre;
                float kilosGanador = ranking[idGanador];

                // Asignamos los textos
                lblIngresos.Text = $"Total Ingresos: {totalDinero:F2} €";
                lblNumVentas.Text = $"Nº Ventas: {ventas.Count}";
                lblTotalKilos.Text = $"Total Kilos: {totalKilos:F2} kg";
                lblProductoEstrella.Text = $"Producto Estrella: {nombreGanador} ({kilosGanador} kg)";

                // TRUCO VISUAL: Alineamos todo perfectamente al centro
                AlinearTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar informe: " + ex.Message);
            }
        }

        // --- MÉTODO NUEVO PARA CENTRAR VISUALMENTE ---
        private void AlinearTodo()
        {
            CentrarControl(lblIngresos);
            CentrarControl(lblNumVentas);
            CentrarControl(lblTotalKilos);
            CentrarControl(lblProductoEstrella);

            // Opcional: Centrar también el título si tienes uno
            // CentrarControl(labelTitulo); 
        }

        private void CentrarControl(Control c)
        {
            // Calcula la posición X exacta para que quede en el medio de la ventana
            c.Left = (this.ClientSize.Width - c.Width) / 2;
        }

        // Botones
        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await GenerarInforme();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Eventos vacíos
        private void label2_Click(object sender, EventArgs e) { }
        private void lblProductoEstrella_Click(object sender, EventArgs e) { }
        private void lblTotalKilos_Click(object sender, EventArgs e) { }
        private void lblIngresos_Click(object sender, EventArgs e) { }
    }
}
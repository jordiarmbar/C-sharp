using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_REST_FINAL
{
    public partial class FormStock : Form
    {
        private ApiClient _api;
        // Guardamos la lista completa en memoria para poder filtrar sin llamar a la API cada vez
        private List<Producto> listaCompleta = new List<Producto>();

        public FormStock(ApiClient client)
        {
            InitializeComponent();
            _api = client;
        }

        private async void FormStock_Load(object sender, EventArgs e)
        {
            await CargarStock();
        }

        // Función auxiliar para cargar y refrescar
        private async Task CargarStock()
        {
            try
            {
                listaCompleta = await _api.GetProductosAsync();

                // Al cargar, aplicamos el filtro si la casilla ya estaba marcada
                AplicarFiltro();

                dgvStock.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar stock: " + ex.Message);
            }
        }

        // Función que decide qué mostrar en la tabla según el CheckBox
        private void AplicarFiltro()
        {
            if (listaCompleta == null) return;

            if (chkBajoStock.Checked)
            {
                //Filtro: Solo productos con menos de 10kg
                dgvStock.DataSource = listaCompleta.Where(p => p.stockkg < 10).ToList();
            }
            else
            {
                // Mostrar todo
                dgvStock.DataSource = listaCompleta;
            }
        }

        // --- EVENTOS ACTIVOS ---

        // Evento del CheckBox (El _1 es el que creó el diseñador al hacer doble clic)
        private void chkBajoStock_CheckedChanged_1(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        // Evento para pintar de ROJO las filas con poco stock
        private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStock.Rows[e.RowIndex].DataBoundItem is Producto p)
            {
                if (p.stockkg < 10) // Umbral crítico
                {
                    e.CellStyle.BackColor = Color.Salmon;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.SelectionBackColor = Color.DarkRed; // Para que se vea bien al seleccionarlo
                }
            }
        }

        // --- EVENTOS DE RELLENO (NO BORRAR) ---
        // Visual Studio los necesita para no dar error de diseño

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // Este es el antiguo que tenías, lo dejo vacío por si acaso sigue enlazado en algún sitio
        private void chkBajoStock_CheckedChanged(object sender, EventArgs e) { }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
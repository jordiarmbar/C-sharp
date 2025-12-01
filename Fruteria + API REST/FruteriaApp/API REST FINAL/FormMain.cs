using System;
using System.Windows.Forms;

namespace API_REST_FINAL
{
    public partial class FormMain : Form
    {
        // 1. IMPORTANTE: Creamos el cliente AQUÍ para compartirlo con todos
        private ApiClient globalClient = new ApiClient();

        public FormMain()
        {
            InitializeComponent();
        }

        // --- BOTÓN CATÁLOGO ---
        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            // Creamos la ventana pasándole el cliente y la mostramos
            FormCatalogo ventana = new FormCatalogo(globalClient);
            ventana.ShowDialog();
        }

        // --- BOTÓN STOCK ---
        // (Asegúrate de que tu botón se llame 'btnStock' y haz doble clic en él si este código no se activa)

        private void BtnStock_Click_1(object sender, EventArgs e)
        {
            FormStock ventana = new FormStock(globalClient);
            ventana.ShowDialog();
        }

        // --- BOTÓN VENTAS ---
        private void BtnVentas_Click_1(object sender, EventArgs e)
        {
            FormVentas ventana = new FormVentas(globalClient);
            ventana.ShowDialog();
        }

        // --- BOTÓN INFORMES ---
        private void BtnInformes_Click_1(object sender, EventArgs e)
        {
            FormInformes ventana = new FormInformes(globalClient);
            ventana.ShowDialog();
        }


    }
}
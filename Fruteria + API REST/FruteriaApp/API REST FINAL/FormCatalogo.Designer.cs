namespace API_REST_FINAL
{
    partial class FormCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            txtNombre = new TextBox();
            numPrecio = new NumericUpDown();
            numStock = new NumericUpDown();
            txtId = new TextBox();
            txtCategoria = new TextBox();
            btnCargar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnVolver = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(28, 84);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(841, 200);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(248, 439);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Location = new Point(599, 413);
            numPrecio.Margin = new Padding(3, 4, 3, 4);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(137, 27);
            numPrecio.TabIndex = 2;
            numPrecio.ValueChanged += numPrecio_ValueChanged;
            // 
            // numStock
            // 
            numStock.DecimalPlaces = 2;
            numStock.Location = new Point(599, 341);
            numStock.Margin = new Padding(3, 4, 3, 4);
            numStock.Name = "numStock";
            numStock.Size = new Size(137, 27);
            numStock.TabIndex = 3;
            numStock.ValueChanged += numStock_ValueChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(248, 356);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 4;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(248, 517);
            txtCategoria.Margin = new Padding(3, 4, 3, 4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(114, 27);
            txtCategoria.TabIndex = 5;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(455, 517);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(86, 31);
            btnCargar.TabIndex = 6;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(570, 517);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(685, 517);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(803, 517);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 359);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 10;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 442);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 11;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 520);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 12;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 343);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 13;
            label4.Text = "Nº Stock:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 420);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 14;
            label5.Text = "Nº Precio:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(642, 559);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 32);
            label6.Name = "label6";
            label6.Size = new Size(193, 20);
            label6.TabIndex = 16;
            label6.Text = "CATÁLOGO DE PRODUCTOS";
            // 
            // FormCatalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label6);
            Controls.Add(btnVolver);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargar);
            Controls.Add(txtCategoria);
            Controls.Add(txtId);
            Controls.Add(numStock);
            Controls.Add(numPrecio);
            Controls.Add(txtNombre);
            Controls.Add(dgvProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCatalogo";
            Text = "Form1";
            Load += FormCatalogo_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private TextBox txtNombre;
        private NumericUpDown numPrecio;
        private NumericUpDown numStock;
        private TextBox txtId;
        private TextBox txtCategoria;
        private Button btnCargar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnVolver;
        private Label label6;
    }
}
namespace API_REST_FINAL
{
    partial class FormVentas
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
            cmbProductos = new ComboBox();
            numKilos = new NumericUpDown();
            dgvCarrito = new DataGridView();
            lblTotal = new Label();
            btnAgregar = new Button();
            btnConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            btnVolver = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numKilos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // cmbProductos
            // 
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(235, 401);
            cmbProductos.Margin = new Padding(3, 4, 3, 4);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(138, 28);
            cmbProductos.TabIndex = 0;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // numKilos
            // 
            numKilos.DecimalPlaces = 2;
            numKilos.Location = new Point(438, 401);
            numKilos.Margin = new Padding(3, 4, 3, 4);
            numKilos.Name = "numKilos";
            numKilos.Size = new Size(137, 27);
            numKilos.TabIndex = 1;
            numKilos.ValueChanged += numKilos_ValueChanged;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(12, 59);
            dgvCarrito.Margin = new Padding(3, 4, 3, 4);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(890, 288);
            dgvCarrito.TabIndex = 2;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(375, 480);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(88, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: 0.00 €";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(168, 516);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(169, 31);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Añadir al Carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(397, 518);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(86, 31);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar Venta";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 361);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 361);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Nº quilos";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(559, 518);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 19);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 9;
            label3.Text = "REGISTRAR VENTA";
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTotal);
            Controls.Add(dgvCarrito);
            Controls.Add(numKilos);
            Controls.Add(cmbProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVentas";
            Text = "FormVentas";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)numKilos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProductos;
        private NumericUpDown numKilos;
        private DataGridView dgvCarrito;
        private Label lblTotal;
        private Button btnAgregar;
        private Button btnConfirmar;
        private Label label1;
        private Label label2;
        private Button btnVolver;
        private Label label3;
    }
}
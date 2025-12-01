namespace API_REST_FINAL
{
    partial class FormInformes
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
            label1 = new Label();
            lblIngresos = new Label();
            lblNumVentas = new Label();
            lblTotalKilos = new Label();
            lblProductoEstrella = new Label();
            btnVolver = new Button();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 24);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "RESUMEN DE VENTAS";
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(336, 132);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(110, 20);
            lblIngresos.TabIndex = 1;
            lblIngresos.Text = "Ingresos: 0.00 €";
            lblIngresos.Click += lblIngresos_Click;
            // 
            // lblNumVentas
            // 
            lblNumVentas.AutoSize = true;
            lblNumVentas.Location = new Point(318, 170);
            lblNumVentas.Name = "lblNumVentas";
            lblNumVentas.Size = new Size(138, 20);
            lblNumVentas.TabIndex = 2;
            lblNumVentas.Text = "Ventas realizadas: 0";
            lblNumVentas.Click += label2_Click;
            // 
            // lblTotalKilos
            // 
            lblTotalKilos.AutoSize = true;
            lblTotalKilos.Location = new Point(326, 208);
            lblTotalKilos.Name = "lblTotalKilos";
            lblTotalKilos.Size = new Size(120, 20);
            lblTotalKilos.TabIndex = 3;
            lblTotalKilos.Text = "Kilos vendidos: 0";
            lblTotalKilos.Click += lblTotalKilos_Click;
            // 
            // lblProductoEstrella
            // 
            lblProductoEstrella.AutoSize = true;
            lblProductoEstrella.Location = new Point(308, 243);
            lblProductoEstrella.Name = "lblProductoEstrella";
            lblProductoEstrella.Size = new Size(171, 20);
            lblProductoEstrella.TabIndex = 4;
            lblProductoEstrella.Text = "Producto más vendido: -";
            lblProductoEstrella.Click += lblProductoEstrella_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(260, 384);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(427, 384);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Recalcular";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(btnVolver);
            Controls.Add(lblProductoEstrella);
            Controls.Add(lblTotalKilos);
            Controls.Add(lblNumVentas);
            Controls.Add(lblIngresos);
            Controls.Add(label1);
            Name = "FormInformes";
            Text = "FormInformes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblIngresos;
        private Label lblNumVentas;
        private Label lblTotalKilos;
        private Label lblProductoEstrella;
        private Button btnVolver;
        private Button btnActualizar;
    }
}
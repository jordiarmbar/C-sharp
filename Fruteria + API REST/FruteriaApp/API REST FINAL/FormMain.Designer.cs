namespace API_REST_FINAL
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCatalogo = new Button();
            BtnStock = new Button();
            BtnVentas = new Button();
            BtnInformes = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnCatalogo
            // 
            BtnCatalogo.Location = new Point(11, 207);
            BtnCatalogo.Name = "BtnCatalogo";
            BtnCatalogo.Size = new Size(197, 29);
            BtnCatalogo.TabIndex = 0;
            BtnCatalogo.Text = "Catálogo de Productos";
            BtnCatalogo.UseVisualStyleBackColor = true;
            BtnCatalogo.Click += BtnCatalogo_Click;
            // 
            // BtnStock
            // 
            BtnStock.Location = new Point(257, 207);
            BtnStock.Name = "BtnStock";
            BtnStock.Size = new Size(145, 29);
            BtnStock.TabIndex = 1;
            BtnStock.Text = "Control de Stock";
            BtnStock.UseVisualStyleBackColor = true;
            BtnStock.Click += BtnStock_Click_1;
            // 
            // BtnVentas
            // 
            BtnVentas.Location = new Point(442, 207);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(136, 29);
            BtnVentas.TabIndex = 2;
            BtnVentas.Text = "Registrar Venta";
            BtnVentas.UseVisualStyleBackColor = true;
            BtnVentas.Click += BtnVentas_Click_1;
            // 
            // BtnInformes
            // 
            BtnInformes.Location = new Point(633, 207);
            BtnInformes.Name = "BtnInformes";
            BtnInformes.Size = new Size(94, 29);
            BtnInformes.TabIndex = 3;
            BtnInformes.Text = "Informes";
            BtnInformes.TextAlign = ContentAlignment.TopCenter;
            BtnInformes.UseVisualStyleBackColor = true;
            BtnInformes.Click += BtnInformes_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 37);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 4;
            label1.Text = "FRUTERÍA VIRTUAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 86);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 5;
            label2.Text = "Elige cualquier opción";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnInformes);
            Controls.Add(BtnVentas);
            Controls.Add(BtnStock);
            Controls.Add(BtnCatalogo);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCatalogo;
        private Button BtnStock;
        private Button BtnVentas;
        private Button BtnInformes;
        private Label label1;
        private Label label2;
    }
}

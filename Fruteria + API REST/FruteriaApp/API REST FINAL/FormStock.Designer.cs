namespace API_REST_FINAL
{
    partial class FormStock
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
            dgvStock = new DataGridView();
            chkBajoStock = new CheckBox();
            btnVolver = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(12, 69);
            dgvStock.Margin = new Padding(3, 4, 3, 4);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(882, 410);
            dgvStock.TabIndex = 0;
            dgvStock.CellContentClick += dgvStock_CellContentClick;
            // 
            // chkBajoStock
            // 
            chkBajoStock.AutoSize = true;
            chkBajoStock.Location = new Point(49, 542);
            chkBajoStock.Margin = new Padding(3, 4, 3, 4);
            chkBajoStock.Name = "chkBajoStock";
            chkBajoStock.Size = new Size(156, 24);
            chkBajoStock.TabIndex = 1;
            chkBajoStock.Text = "Ver solo stock bajo";
            chkBajoStock.UseVisualStyleBackColor = true;
            chkBajoStock.CheckedChanged += chkBajoStock_CheckedChanged_1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(701, 537);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 24);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 5;
            label1.Text = "CONTROL DE STOCK";
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(chkBajoStock);
            Controls.Add(dgvStock);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormStock";
            Text = "FormStock";
            Load += FormStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStock;
        private CheckBox chkBajoStock;
        private Button btnVolver;
        private Label label1;
    }
}
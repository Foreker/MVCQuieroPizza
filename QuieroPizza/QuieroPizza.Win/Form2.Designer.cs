namespace QuieroPizza.Win
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.listadeVentasPorProdcutosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listadeVentasPorProdcutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProdcutosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProdcutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listadeVentasPorProdcutosDataGridView
            // 
            this.listadeVentasPorProdcutosDataGridView.AutoGenerateColumns = false;
            this.listadeVentasPorProdcutosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeVentasPorProdcutosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.listadeVentasPorProdcutosDataGridView.DataSource = this.listadeVentasPorProdcutosBindingSource;
            this.listadeVentasPorProdcutosDataGridView.Location = new System.Drawing.Point(12, 58);
            this.listadeVentasPorProdcutosDataGridView.Name = "listadeVentasPorProdcutosDataGridView";
            this.listadeVentasPorProdcutosDataGridView.RowTemplate.Height = 24;
            this.listadeVentasPorProdcutosDataGridView.Size = new System.Drawing.Size(548, 253);
            this.listadeVentasPorProdcutosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // listadeVentasPorProdcutosBindingSource
            // 
            this.listadeVentasPorProdcutosBindingSource.DataSource = typeof(QuieroPizza.BL.ReporteVentasPorProducto);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(470, 12);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(90, 29);
            this.btnRefrescar.TabIndex = 2;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 323);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.listadeVentasPorProdcutosDataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProdcutosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProdcutosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource listadeVentasPorProdcutosBindingSource;
        private System.Windows.Forms.DataGridView listadeVentasPorProdcutosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnRefrescar;
    }
}
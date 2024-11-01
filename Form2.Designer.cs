namespace WinFormsApp5
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnSimularPedidos = new System.Windows.Forms.Button();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(401, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(323, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Simulación de Pedidos";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(506, 102);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(125, 27);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnSimularPedidos
            // 
            this.btnSimularPedidos.Location = new System.Drawing.Point(517, 152);
            this.btnSimularPedidos.Name = "btnSimularPedidos";
            this.btnSimularPedidos.Size = new System.Drawing.Size(94, 29);
            this.btnSimularPedidos.TabIndex = 2;
            this.btnSimularPedidos.Text = "Simular Pedidos";
            this.btnSimularPedidos.UseVisualStyleBackColor = true;
            this.btnSimularPedidos.Click += new System.EventHandler(this.btnSimularPedidos_Click);
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre,
            this.ColumnaContenido,
            this.ColumnaPrecio,
            this.ColumnaEstado});
            this.dataGridViewPedidos.Location = new System.Drawing.Point(286, 232);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowHeadersWidth = 51;
            this.dataGridViewPedidos.RowTemplate.Height = 29;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(553, 188);
            this.dataGridViewPedidos.TabIndex = 3;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.MinimumWidth = 6;
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.Width = 125;
            // 
            // ColumnaContenido
            // 
            this.ColumnaContenido.HeaderText = "Contenido";
            this.ColumnaContenido.MinimumWidth = 6;
            this.ColumnaContenido.Name = "ColumnaContenido";
            this.ColumnaContenido.Width = 125;
            // 
            // ColumnaPrecio
            // 
            this.ColumnaPrecio.HeaderText = "Precio";
            this.ColumnaPrecio.MinimumWidth = 6;
            this.ColumnaPrecio.Name = "ColumnaPrecio";
            this.ColumnaPrecio.Width = 125;
            // 
            // ColumnaEstado
            // 
            this.ColumnaEstado.HeaderText = "Estado";
            this.ColumnaEstado.MinimumWidth = 6;
            this.ColumnaEstado.Name = "ColumnaEstado";
            this.ColumnaEstado.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 501);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.btnSimularPedidos);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form2";
            this.Text = "Simulación de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtFiltro;
        private Button btnSimularPedidos;
        private DataGridView dataGridViewPedidos;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaContenido;
        private DataGridViewTextBoxColumn ColumnaPrecio;
        private DataGridViewTextBoxColumn ColumnaEstado;
    }
}

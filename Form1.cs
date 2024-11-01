namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            string nombre = txtNombre.Text;
            string contenido = txtContenido.Text;
            string precioText = txtPrecio.Text;

            
            if (!decimal.TryParse(precioText, out decimal precio))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            dataGridViewPedidos.Rows.Add(nombre, contenido, precio);

            
            txtNombre.Clear();
            txtContenido.Clear();
            txtPrecio.Clear();
        }

        private void dataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


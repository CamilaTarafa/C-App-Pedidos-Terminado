using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        private void btnSimularPedidos_Click(object sender, EventArgs e)
        {
            // Simulación de pedidos. Aquí puedes agregar lógica según lo que necesites.
            var nombre = "Pedido " + (dataGridViewPedidos.Rows.Count + 1);
            var contenido = "Contenido del " + nombre;
            var precio = (dataGridViewPedidos.Rows.Count + 1) * 10; // Ejemplo de precio
            var estado = "Pendiente";

            // Agregar una nueva fila al DataGridView
            dataGridViewPedidos.Rows.Add(nombre, contenido, precio, estado);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar lógica para filtrar los pedidos según el texto ingresado
        }
    }
}

    


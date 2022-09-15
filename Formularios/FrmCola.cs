using Pilas_Y_Colas.Clases;
using Pilas_Y_Colas.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_Y_Colas
{
    public partial class FrmCola : Form
    {
        private ICollection collection;
        public FrmCola()
        {
            InitializeComponent();
            collection = new Cola(20);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtColas.Text))
            {
                object cola = txtColas.Text;
                if (collection.Añadir(cola))
                {
                    lstcolas.Items.Add(cola);
                    MessageBox.Show("Se agrego la cola a la collecion", "Pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lista Llena", "cola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtColas.Text = "";
            txtColas.Focus();
        }


        private void FrmCola_Load(object sender, EventArgs e)
        {


        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (!collection.EstaVacia())
            {
                MessageBox.Show("Primer Elemento " + collection.Primero());
            }
        }

        private void btnVacia_Click(object sender, EventArgs e)
        {
            string Mensaje = collection.EstaVacia() ? "Cola Vacia" : "Cola Con Elementos";
            MessageBox.Show(Mensaje, "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            object cola = collection.Extraer();
            lstcolas.Items.Remove(cola);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Grafos
{
    public partial class FormDialogArista : Form
    {
        private List<Vertice> vertice1 = new List<Vertice>();
        private List<Vertice> vertice2 = new List<Vertice>();


        public FormDialogArista(List<Vertice> listArista)
        {
            InitializeComponent();
            // Clonar la lista para que cada ComboBox tenga su propia instancia de la lista
            vertice1 = new List<Vertice>(listArista);
            vertice2 = new List<Vertice>(listArista);
            comboBox1.DataSource = vertice1;
            comboBox1.DisplayMember ="Texto"; 
            comboBox2.DataSource = vertice2;
            comboBox2.DisplayMember = "Texto";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUnir_Click(object sender, EventArgs e)
        {
            // Obtener las aristas seleccionadas en los ComboBox
            Vertice v1 = comboBox1.SelectedItem as Vertice;
            Vertice v2 = comboBox2.SelectedItem as Vertice;

            // Verificar que ambas aristas no sean nulas
            if (v1 != null && v2 != null)
            {
                // Realizar alguna acción con los vértices (por ejemplo, unirlos)
                Form1 xd = new Form1("", v1, v2);
                MessageBox.Show("Union Exitosa");
                this.Close();
            }
        }

    }
}


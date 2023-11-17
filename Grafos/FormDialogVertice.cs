using System;
using System.Windows.Forms;

namespace Grafos
{
    public partial class FormDialogVertice : Form
    {
        public FormDialogVertice()
        {
            InitializeComponent();
        }  
        private void BtnAgregarVertice_Click(object sender, EventArgs e)
        {
            Form1 xd = new Form1(TextNombreVertice.Text,null,null);
            MessageBox.Show("Vertice Agregado Exitosamente");
            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

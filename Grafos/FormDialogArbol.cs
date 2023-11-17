using System;
using System.Windows.Forms;

namespace Grafos
{
    public partial class FormDialogArbol : Form
    {
        public FormDialogArbol()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnElementoArbol_Click(object sender, EventArgs e)
        {
            ArbolB xd = new ArbolB(TextNodo.Text);
            MessageBox.Show("Elemento Agregado Exitosamente");
            this.Close();
        }
    }
}

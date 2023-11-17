using System;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Principal : Form
    {
        private Form1 xd = new Form1("",null,null);
        private ArbolB xdd = new ArbolB("");
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnOptiones_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            panel2.Visible = true;

        }
        private void AbrirFormEnPanel(Form form)
        {
            if (panelChildForm != null)
            {
                if (panelChildForm.Controls.Count > 0)
                {
                    panelChildForm.Controls.RemoveAt(0);
                }

                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(form);
                panelChildForm.Tag = form;
                form.Show();
            }
        }

        private void BtnArboles_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(xdd);
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            panel2.Visible = false;
                
        }

        private void BtnGrafos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(xd);
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            panel2.Visible = false;

        }

        private void BtnOptiones_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panelChildForm_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            panel2.Visible = true;

        }
    }
}

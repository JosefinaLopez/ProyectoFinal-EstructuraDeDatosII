using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Grafos
{
    public partial class ArbolB : Form
    {
        private List<NodoArbol> nodo = new List<NodoArbol>();
        private Point puntoInicial;
        private NodoArbol raiz;
        private bool band = false;
        private Vertice circuloArrastrado;
        private NodoArbol nodoSeleccionado;
        public static string textox;
        public ArbolB(string texto)
        {
            textox = texto;

            InitializeComponent();
            this.Paint += Arbol_Paint;
            this.MouseDown += Arbol_MouseDown;
            this.MouseMove += Arbol_MouseMove;
            this.MouseUp += Arbol_MouseUp;
        }

        private void AgregarArbol_Click(object sender, EventArgs e)
        {
           FormDialogArbol xd = new FormDialogArbol();
            xd.ShowDialog();

            if (!string.IsNullOrEmpty(textox))
            {
                NodoArbol nuevoNodo = new NodoArbol(textox);

                if (nodoSeleccionado != null)
                {
                    InsertarNodo(nodoSeleccionado, nuevoNodo);
                }
                else if (raiz == null)
                {
                    raiz = nuevoNodo;
                }

                nodo.Add(nuevoNodo);
                textox = ""; // Limpiar el texto después de usarlo
                this.Invalidate(); // Vuelve a dibujar el formulario
            }
        }

        private void BtnRecorridoPreorden_Click(object sender, EventArgs e)
        {
           MessageBox.Show("La Cantidad de Hojas en el Arbol es de : " +  ContarHoja(raiz, 0));
            List<NodoArbol> hojas = ObtenerHojas(raiz);
            foreach (NodoArbol hoja in hojas)
            {
                // Realizar operaciones con cada nodo hoja
                MessageBox.Show("Valor de Hoja: " + hoja.Texto);
            }
        }
        private List<NodoArbol> ObtenerHojas(NodoArbol nodo)
        {
            List<NodoArbol> hojas = new List<NodoArbol>();

            if (nodo == null)
            {
                return hojas;
            }
            else
            {
                if (nodo.Izquierdo == null && nodo.Derecho == null)
                {
                    hojas.Add(nodo);
                }

                hojas.AddRange(ObtenerHojas(nodo.Izquierdo));
                hojas.AddRange(ObtenerHojas(nodo.Derecho));
            }

            return hojas;
        }


        private int ContarHoja(NodoArbol nodo, int cont)
        {
            if (nodo == null)
            {
                return 0;
            }
            else
            {
                if (nodo.Izquierdo == null && nodo.Derecho == null)
                {
                    cont += 1;
                }

                cont += ContarHoja(nodo.Izquierdo, 0);
                cont += ContarHoja(nodo.Derecho, 0);
            }
            return cont;
        }
        private void InsertarNodo(NodoArbol padre, NodoArbol nuevoNodo)
        {
            if (padre.Texto.Length > nuevoNodo.Texto.Length)
            {
                if (padre.Izquierdo == null)
                {
                    padre.Izquierdo = nuevoNodo;
                }
                else
                {
                    InsertarNodo(padre.Izquierdo, nuevoNodo);
                }
            }
            else
            {
                if (padre.Derecho == null)
                {
                    padre.Derecho = nuevoNodo;
                }
                else
                {
                    InsertarNodo(padre.Derecho, nuevoNodo);
                }
            }
        }

        private void BtnEliminarArbol_Click(object sender, EventArgs e)
        {
            nodo.Clear();
            raiz = null;
            this.Invalidate();
            MessageBox.Show("Elimidado Exitosamente");
            this.Close();
        }

        private void Arbol_Paint(object sender, PaintEventArgs e)
        {
            DibujarArbol(e.Graphics, raiz, ClientSize.Width / 2, 220, 1);
        }

        private void Arbol_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var n in nodo)
            {
                Rectangle rectangle = new Rectangle(e.X - 40, e.Y - 40, 60, 60);
                if (rectangle.Contains(n.Posicion))
                {
                    band = true;
                    nodoSeleccionado = n;
                    puntoInicial = e.Location;
                    break;
                }
            }
        }

        private void Arbol_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var n in nodo)
            {
                Rectangle rectangle = new Rectangle(e.X - 40, e.Y - 40, 60, 60);
                if (rectangle.Contains(n.Posicion))
                {
                    band = true;
                    nodoSeleccionado = n;
                    puntoInicial = e.Location;
                    break;
                }
            }
        }

        private void Arbol_MouseUp(object sender, MouseEventArgs e)
        {
            band = false;
        }
        private void DibujarArbol(Graphics g, NodoArbol nodo, int x, int y, int nivel)
        {
            if (nodo == null)
                return;

            g.FillEllipse(Brushes.Indigo, x - 40, y - 40, 60, 60);
            g.DrawString(nodo.Texto, Font, Brushes.Black, x, y, StringFormat.GenericDefault);
            nodo.Posicion = new Point(x, y);

            int separacion = 50 * nivel;

            if (nodo.Izquierdo != null)
            {
                int xIzq = x - separacion;
                int yIzq = y + 100;
                g.DrawLine(Pens.Black, x, y + 40, xIzq, yIzq - 40);
                DibujarArbol(g, nodo.Izquierdo, xIzq, yIzq, nivel + 1);
            }

            if (nodo.Derecho != null)
            {
                int xDer = x + separacion;
                int yDer = y + 100;
                g.DrawLine(Pens.Black, x, y + 40, xDer, yDer - 40);
                DibujarArbol(g, nodo.Derecho, xDer, yDer, nivel + 1);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class NodoArbol
    {
        public string Texto { get; set; }
        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }
        public Point Posicion { get; set; }

        public NodoArbol(string texto)
        {
            Texto = texto;
            Izquierdo = null;
            Derecho = null;
        }
    }

}

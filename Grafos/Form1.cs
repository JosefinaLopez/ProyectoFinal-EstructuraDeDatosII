using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Form1 : Form
    {
        //Elementos de mi grafo
        private List<Arista> arista = new List<Arista>();
        private List<Vertice> vertice = new List<Vertice>();
        private HashSet<Vertice> nodosVisitados = new HashSet<Vertice>();


        //XD
        private bool band = false;
        private Vertice circuloArrastrado;
        private Point puntoInicial;
        public static string texto;
        public static Vertice vertx1, vertx2;
        public Form1(string text,Vertice vert1, Vertice ver2)
        {

            //Validacion xd
            texto = text;
            vertx1 = vert1;
            vertx2 = ver2;

            InitializeComponent();
            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            // Agregar un círculo de ejemplo al inicio
            //AgregarVertice("PROBANDO");

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            foreach (var xd in vertice)
            {
                Rectangle rectangle = new Rectangle(xd.Posicion.X - 40, xd.Posicion.Y - 20, 40, 40);
                if(rectangle.Contains(e.Location))
                {
                    band = true;
                    circuloArrastrado = xd;
                    puntoInicial = e.Location;
                    break;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var xd in vertice)
            {
                Brush color = nodosVisitados.Contains(xd) ? Brushes.Red : Brushes.Indigo;
                e.Graphics.FillEllipse(color, xd.Posicion.X - 50, xd.Posicion.Y - 40, 50, 50);
                e.Graphics.DrawString(xd.Texto, Font, Brushes.Black, xd.Posicion);
            }

            foreach (var uwu in arista)
            {
                e.Graphics.DrawLine(Pens.Black, uwu.Vertice1.Posicion, uwu.Vertice2.Posicion);
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(band  && circuloArrastrado != null)
            {  
                //Mueve el puntero
                int LocX = e.X - puntoInicial.X;
                int LocY = e.Y - puntoInicial.Y;
                circuloArrastrado.Posicion = new Point(circuloArrastrado.Posicion.X + LocX, circuloArrastrado.Posicion.Y + LocY);
                puntoInicial = e.Location;
                this.Invalidate(); // Vuelve a dibujar el formulario

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            band = false;

        }

        private void BtnAgregarVertice_Click(object sender, EventArgs e)
        {
            FormDialogVertice dv = new FormDialogVertice();
            dv.ShowDialog();
            //AgregarVertice("AWAAA", new Point(400, 400));
            if(texto != null)
            {
                AgregarVertice(texto);
                // Conectar el nuevo vértice con todos los vértices existentes
                if (vertice.Count > 1)
                {
                
                        foreach (var xd in vertice)
                        {
                            AgregarArista(xd, vertice.Last());
                        }
                   
                }
                this.Invalidate();
            }
        }
        public void AgregarVertice(string texto)
        {   
            if (texto != null) 
            {
                 Vertice nuevoCirculo = new Vertice
                 {
                    Texto = texto,
                    Posicion = new Point(400,400)
                 };

                vertice.Add(nuevoCirculo);
                this.Invalidate(); // Vuelve a dibujar el formulario

            }
        }
        public void AgregarArista(Vertice v1, Vertice v2)
        {
            if(vertx1 != null && vertx2 != null)
            {
                Arista nuevaArista = new Arista
                {
                    Vertice1 = v1,
                    Vertice2 = v2
                };

                arista.Add(nuevaArista);
                this.Invalidate(); // Vuelve a dibujar el formulario

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            arista.Clear();
            vertice.Clear();
            this.Invalidate();
            MessageBox.Show("Grafico Eliminado Exitosa");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {  
          
            nodosVisitados.Clear(); 
            DFS(vertice.First()); // Iniciara DFS desde el primer verticexd
            this.Invalidate(); // Vuelve a dibujar el formulario luego de la busqued
            button1.Visible = true;
            button2.Visible = true;
            //MessageBox.Show("Busqueda Finalizada");
        }
        private void DFS(Vertice inicio)
        {
            nodosVisitados.Clear(); // Limpiara xd nodos visitados antes de la búsqueda
            DFSUtil(inicio);
        }

        private void DFSUtil(Vertice v)
        {
            nodosVisitados.Add(v); // Marcara el vertice como visitadoxd
            this.Invalidate(); // Vuelve a dibujar el formulario para reflejar el cambio de color

            foreach (var vecino in vertice.Where(x => !nodosVisitados.Contains(x) && ExisteArista(x, v)))
            {
                DFSUtil(vecino);
               
            }
        }

        private bool ExisteArista(Vertice v1, Vertice v2)
        {
            return arista.Any(a => (a.Vertice1 == v1 && a.Vertice2 == v2) || (a.Vertice1 == v2 && a.Vertice2 == v1));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
        }

        private void BtnAgregarArista_Click(object sender, EventArgs e)
        {
            FormDialogArista ar = new FormDialogArista(vertice);
            ar.ShowDialog();
            //MessageBox.Show(arista.ToString());
            if (vertx1 != null && vertx2 != null)
            {
                AgregarArista(vertx1, vertx2);
                //MessageBox.Show(vertx1.Texto);
            }
        }
    }
    public class Vertice
    {
        public Point Posicion { get; set; }
        public string Texto { get; set; }
    }
  
    public class Arista
    {
        public Vertice Vertice1 { get; set; }
        public Vertice Vertice2 { get; set; }
    }

}

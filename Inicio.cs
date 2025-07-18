using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicioo
{
    using System.Drawing.Imaging;
    using System.Drawing.Drawing2D;
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Personalizar botones
            PersonalizarBoton(btnFotos);
            PersonalizarBoton(btnVideos);
            PersonalizarBoton(btnTendencias);
            PersonalizarBoton(btnSubir);

            // Mensajes de prueba para navegación
            btnFotos.Click += (s, ev) => MessageBox.Show("Sección Fotos en construcción");
            btnVideos.Click += (s, ev) => MessageBox.Show("Sección Videos en construcción");
            btnTendencias.Click += (s, ev) => MessageBox.Show("Sección Tendencias en construcción");
        }

        private void PersonalizarBoton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 220, 255);

            // Bordes redondeados suaves
            btn.Region = new Region(new GraphicsPath(
                new[] {
            new Point(10, 0),
            new Point(btn.Width - 10, 0),
            new Point(btn.Width, 10),
            new Point(btn.Width, btn.Height - 10),
            new Point(btn.Width - 10, btn.Height),
            new Point(10, btn.Height),
            new Point(0, btn.Height - 10),
            new Point(0, 10)
                },
                new byte[] {
            1, 1, 1, 1, 1, 1, 1, 1
                }));
        }

        private void btnSubir_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string archivo in ofd.FileNames)
                {
                    AgregarPublicacionAlFeed(archivo);
                }
            }
        }

        private void AgregarPublicacionAlFeed(string rutaImagen)
        {
            int ancho = 250;
            int alto = 250;

            // Panel contenedor
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(ancho, alto);
            tarjeta.Margin = new Padding(5);
            tarjeta.BackColor = Color.Transparent;
            tarjeta.Cursor = Cursors.Hand;

            // Recorte centrado
            Bitmap original = new Bitmap(rutaImagen);
            Rectangle cropRect;

            if (original.Width / (float)original.Height > ancho / (float)alto)
            {
                int nuevoAncho = (int)(original.Height * (ancho / (float)alto));
                int x = (original.Width - nuevoAncho) / 2;
                cropRect = new Rectangle(x, 0, nuevoAncho, original.Height);
            }
            else
            {
                int nuevoAlto = (int)(original.Width * (alto / (float)ancho));
                int y = (original.Height - nuevoAlto) / 2;
                cropRect = new Rectangle(0, y, original.Width, nuevoAlto);
            }

            Bitmap recortada = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(recortada))
            {
                g.DrawImage(original, new Rectangle(0, 0, ancho, alto), cropRect, GraphicsUnit.Pixel);
            }

            // Crear PictureBox con la imagen recortada
            PictureBox imagen = new PictureBox();
            imagen.Image = recortada;
            imagen.Size = new Size(ancho, alto);
            imagen.SizeMode = PictureBoxSizeMode.Zoom;
            imagen.Dock = DockStyle.Fill;
            imagen.Cursor = Cursors.Hand;

            // Evento para abrir en nueva ventana
            imagen.Click += (s, e) =>
            {
                frmImagen ventana = new frmImagen(recortada);
                ventana.ShowDialog();
            };

            // Agregar imagen al panel
            tarjeta.Controls.Add(imagen);

            // Agregar la tarjeta al panel principal del feed
            feedPanel.Controls.Add(tarjeta); // ← Asegurate de que "feedPanel" exista
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Simula una lista de historias (imágenes temporales en memoria)
        List<Image> historias = new List<Image>();
        int historiaActual = 0;


        private void btnGlimpseNow_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png";
             if (ofd.ShowDialog() == DialogResult.OK)
             {
                 Image img = Image.FromFile(ofd.FileName);
                 historias.Insert(0, img); // Tu historia va al inicio
                 MessageBox.Show("Historia subida. Ve a verla en tu perfil");
             }

        }

        private void btnhistoria1_Click(object sender, EventArgs e)
        {
            if (historias.Count > 0)
            {
                GlimpsNowViewer viewer = new GlimpsNowViewer(historias);
                viewer.Show();
            }
            else
            {
                MessageBox.Show("Aún no has subido una historia 🥲");
            }
        }

        private void btnhistoria2_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

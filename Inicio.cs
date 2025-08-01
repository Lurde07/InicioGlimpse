﻿using System;
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
            feedPanel.Controls.Add(tarjeta);
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // GLIMPSE NOW ---------------------------------------------------------------------------------------------------

        // Simula una lista de historias (imágenes temporales en memoria)
        List<Image> historias = new List<Image>();
        private Image historiaUsuario = null;



        private void btnGlimpseNow_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png";
            ofd.Title = "Selecciona tu glimps";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                historiaUsuario = img;
                MessageBox.Show("¡Subiste un nuevo Glimpse!");
            }

        }

        private void btnhistoria1_Click(object sender, EventArgs e)
        {
            if (historiaUsuario != null)
            {
                List<Image> listaUnica = new List<Image> { historiaUsuario };
                List<Image> perfilUsuario = new List<Image> { Properties.Resources.perfilUsuario }; // o algo default
                List<string> nombreUsuario = new List<string> { "tú <3" };

                GlimpsNowViewer viewer = new GlimpsNowViewer(listaUnica, perfilUsuario, nombreUsuario, 0, true);
                viewer.Show();
            }
            else
            {
                MessageBox.Show("No has subido ningún glimpse. Ve a ver los de las demás <3.");
            }
        }

        private void btnhistoria2_Click(object sender, EventArgs e)
        {
            List<Image> historias = new List<Image>
            {
                Properties.Resources.fake1,
                Properties.Resources.fake2,
                Properties.Resources.fake3,
                Properties.Resources.fake4,
                Properties.Resources.fake5,
                Properties.Resources.fake6,
                Properties.Resources.fake7
            };

            List<string> nombres = new List<string>
            {
                "madisonbeer",
                "sabrinacarpenter",
                "lilyrose_depp",
                "arianagrande",
                "kendalljenner",
                "haileybieber",
                "jennierubyjane"
            };

            List<Image> perfiles = new List<Image>
            {
                Properties.Resources.perfil1,
                Properties.Resources.perfil2,
                Properties.Resources.perfil3,
                Properties.Resources.perfil4,
                Properties.Resources.perfil5,
                Properties.Resources.perfil6,
                Properties.Resources.perfil7
            };

            GlimpsNowViewer viewer = new GlimpsNowViewer(historias, perfiles, nombres);
            viewer.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        // NAVEGACIÓN---------------------------------------------------------------------------------------------------
        private void label3_Click(object sender, EventArgs e)
        {
            GlimpseNow paginaHistorias = new GlimpseNow();
            paginaHistorias.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            GlimpseNow paginaHistorias = new GlimpseNow();
            paginaHistorias.Show();
            this.Hide();
        }

        private void btnVideosMenu_Click(object sender, EventArgs e)
        {
            Videos videos = new Videos();
            videos.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            Videos videos = new Videos();
            videos.Show();
            this.Hide();
        }

        private void btnFotos_Click(object sender, EventArgs e)
        {
            FotosScroll fotos = new FotosScroll();
            fotos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FotosScroll fotos = new FotosScroll();
            fotos.Show();
            this.Hide();
        }

        private void btnTendencias_Click(object sender, EventArgs e)
        {
            Tendencias tendencias = new Tendencias();
            tendencias.Show();
            this.Hide();
        }

        private void btnTendenciasMenu_Click(object sender, EventArgs e)
        {
            Tendencias tendencias = new Tendencias();
            tendencias.Show();
            this.Hide();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            Contactos contactos = new Contactos();
            contactos.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inicioo
{
    public partial class Videos : Form
    {
        // Lista donde se guardarán todos los videos subidos
        List<string> listaVideos = new List<string>();

        // Índice del video actual
        int indiceActual = 0;

        public Videos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            GlimpseNow paginaHistorias = new GlimpseNow();
            paginaHistorias.Show();
            this.Hide();

        }

        private void btnsalirdevideos_Click(object sender, EventArgs e)
        {
            Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
            this.Close();
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
        }

        private void btnhistoria1_Click_1(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        //VIDEOOOSSS ----------------------------------------------------------------------------------------------

        private void btnglimpse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de video|*.mp4;*.avi;*.mov";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string rutaVideo = ofd.FileName;
                listaVideos.Add(rutaVideo); // lo agregamos a la lista

                indiceActual = listaVideos.Count - 1; // Nos posicionamos en el último video
                playervideo.URL = rutaVideo;
                playervideo.settings.setMode("loop", true);
                playervideo.Ctlcontrols.play();

                MessageBox.Show("¡Subiste un video! 🎥");
            }
        }

        List<string> videos = new List<string>() {
            "video1.mp4",
            "video2.mp4",
            "video3.mp4"
        };

        private void btncambiar1_Click(object sender, EventArgs e)
        {
            if (listaVideos.Count == 0) return;

            indiceActual++;
            if (indiceActual >= listaVideos.Count)
                indiceActual = 0;

            ReproducirVideo(listaVideos[indiceActual]);
        }
        int currentVideoIndex = 0;

        private void btncambiar2_Click(object sender, EventArgs e)
        {
            if (listaVideos.Count == 0) return;

            indiceActual--;
            if (indiceActual < 0)
                indiceActual = listaVideos.Count - 1;

            ReproducirVideo(listaVideos[indiceActual]);
        }

        private void Videos_Load(object sender, EventArgs e)
        {
            // Ruta base (donde están los videos dentro del proyecto)
            string rutaBase = Path.Combine(Application.StartupPath, "Videos");

            // Cargar 10 videos predefinidos
            for (int i = 1; i <= 10; i++)
            {
                string rutaVideo = Path.Combine(rutaBase, $"video{i}.mp4");

                if (File.Exists(rutaVideo))
                {
                    listaVideos.Add(rutaVideo);
                }
            }

            // Reproducir el primer video automáticamente si hay alguno
            if (listaVideos.Count > 0)
            {
                indiceActual = 0;
                ReproducirVideo(listaVideos[0]); // usar función para reproducir en loop
            }
        }

        private void ReproducirVideo(string ruta)
        {
            playervideo.URL = ruta;
            playervideo.settings.setMode("loop", true);
            playervideo.Ctlcontrols.play();
        }

        private void btnicono_Click(object sender, EventArgs e)
        {
            Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FotosScroll fotos = new FotosScroll();
            fotos.Show();
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            GlimpseNow paginaHistorias = new GlimpseNow();
            paginaHistorias.Show();
            this.Close();
        }

        private void btnVideosMenu_Click(object sender, EventArgs e)
        {}

        private void btnTendenciasMenu_Click(object sender, EventArgs e)
        {
            Tendencias tendencias = new Tendencias();
            tendencias.Show();
            this.Close();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            Contactos contactos = new Contactos();
            contactos.Show();
            this.Close();
        }

        private void btnlike_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Le diste like al video!");
        }

        private void btnshare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Reposteaste este video!");
        }
    }
}

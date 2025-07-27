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
    public partial class GlimpseNow : Form
    {
        public GlimpseNow()
        {
            InitializeComponent();
        }

        Image historiaUsuario = null; // global
        Image perfilUsuario = Properties.Resources.perfilUsuario; // o el que estés usando
        string nombreUsuario = "tú"; // nombre de usuario o el del login

        private void AbrirHistoriasFakeDesdeIndice(int indiceInicio)
        {
            List<Image> historiasFake = new List<Image>
            {
                Properties.Resources.fake1,
                Properties.Resources.fake2,
                Properties.Resources.fake3,
                Properties.Resources.fake4,
                Properties.Resources.fake5,
                Properties.Resources.fake6,
                Properties.Resources.fake7
            };

            List<Image> perfilesFake = new List<Image>
            {
                Properties.Resources.perfil1,
                Properties.Resources.perfil2,
                Properties.Resources.perfil3,
                Properties.Resources.perfil4,
                Properties.Resources.perfil5,
                Properties.Resources.perfil6,
                Properties.Resources.perfil7
            };

            List<string> nombresFake = new List<string>
            {
                "madisonbeer",
                "sabrinacarpenter",
                "lilyrose_depp",
                "arianagrande",
                "kendalljenner",
                "haileybieber",
                "jennierubyjane"
            };

            // Recorta las listas desde el índice
            List<Image> subHistorias = historiasFake.Skip(indiceInicio).ToList();
            List<Image> subPerfiles = perfilesFake.Skip(indiceInicio).ToList();
            List<string> subNombres = nombresFake.Skip(indiceInicio).ToList();

            GlimpsNowViewer viewer = new GlimpsNowViewer(subHistorias, subPerfiles, subNombres);
            viewer.Show();
        }
        private void btnhistoria1_Click(object sender, EventArgs e)
        {
            if (historiaUsuario != null)
            {
                var historias = new List<Image> { historiaUsuario };
                var perfiles = new List<Image> { perfilUsuario };
                var nombres = new List<string> { nombreUsuario };

                // Indicamos que es historia única del usuario
                GlimpsNowViewer viewer = new GlimpsNowViewer(historias, perfiles, nombres, 0, true);
                viewer.Show();
            }
            else
            {
                MessageBox.Show("No has subido ningún glimpse.Ve a ver los de las demás <3.");
            }
        }
        private void btnhistoria2_Click(object sender, EventArgs e)
        {
            AbrirHistoriasFakeDesdeIndice(0); // madisonbeer
        }

        private void btnhistoria3_Click(object sender, EventArgs e)
        {
            AbrirHistoriasFakeDesdeIndice(1); // sabrinacarpenter
        }

        private void btnhistoria4_Click(object sender, EventArgs e)
        {
            AbrirHistoriasFakeDesdeIndice(2); // lilyrose_depp
        }

        private void btnhistoria5_Click(object sender, EventArgs e)
        {
            AbrirHistoriasFakeDesdeIndice(3); // 
        }

        private void btnhistoria6_Click(object sender, EventArgs e)
        {
            AbrirHistoriasFakeDesdeIndice(4); 
        }

        private void btnhistoria7_Click(object sender, EventArgs e)
        {
            AbrirHistoriasFakeDesdeIndice(5);
        }

        private void btnhistoria8_Click(object sender, EventArgs e)
        {
            AbrirHistoriasFakeDesdeIndice(6); 
        }

        private void btnGlimpseNow_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png";
            ofd.Title = "Selecciona tu glimps";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                historiaUsuario = Image.FromFile(ofd.FileName);
                MessageBox.Show("¡Subiste un nuevo Glimpse!");
            }
        }



        // NAGEVACIÓN---------------------------------------------------------------------------------------------------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
            this.Close();
        }

        private void btnLogo_Click(object sender, EventArgs e)
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

        private void btnVideosMenu_Click(object sender, EventArgs e)
        {
            Videos videos = new Videos();
            videos.Show();
            this.Close();
        }

        private void btnTendenciasMenu_Click(object sender, EventArgs e)
        {
            Tendencias tendencias = new Tendencias();
            tendencias.Show();
            this.Close();
        }
    }
}

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
    public partial class GlimpsNowViewer : Form
    {
        public GlimpsNowViewer()
        {
            InitializeComponent();
        }

        private void GlimpsNowViewer_Load(object sender, EventArgs e)
        {

        }
        //HISTORIAS DEL INICIO---------------------------------------------------------------------------------------------------
        private List<Image> historias;
        private List<Image> perfiles;
        private List<string> nombres;
        private int indiceActual;

        private bool esHistoriaUsuarioUnica;
        public GlimpsNowViewer(List<Image> historiasFake, List<Image> perfilesFake, List<string> nombresFake, int indiceInicio = 0, bool soloHistoriaUsuario = false)
        {
            InitializeComponent();
            historias = historiasFake;
            perfiles = perfilesFake;
            nombres = nombresFake;
            indiceActual = indiceInicio;
            esHistoriaUsuarioUnica = soloHistoriaUsuario;
            MostrarHistoria();
        }

        private void MostrarHistoria()
        {
            if (indiceActual >= 0 && indiceActual < historias.Count)
            {
                pictureBox1.Image = historias[indiceActual];
                pictureBoxPerfil.Image = perfiles[indiceActual];
                lblNombreUsuario.Text = nombres[indiceActual];
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                MostrarHistoria();
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (indiceActual < historias.Count - 1)
            {
                indiceActual++;
                MostrarHistoria();
            }
            else
            {
                if (esHistoriaUsuarioUnica)
                {
                    // Cierra esta ventana
                    this.Close();

                    // Abre el nuevo viewer con las historias fake
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

                    GlimpsNowViewer viewer = new GlimpsNowViewer(historiasFake, perfilesFake, nombresFake);
                    viewer.Show();
                }
                else
                {
                    DialogResult resultado = MessageBox.Show(
                        "No hay más glimpeses.\n¿Quieres cerrar esta ventana?",
                        "Último Glimpse",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
        }
        
    }
}


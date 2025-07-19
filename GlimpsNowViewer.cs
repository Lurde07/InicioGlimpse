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

        private List<Image> historias;
        private List<Image> perfiles;
        private List<string> nombres;
        private int indiceActual;

        public GlimpsNowViewer(List<Image> historiasFake, List<Image> perfilesFake, List<string> nombresFake)
        {
            InitializeComponent();
            historias = historiasFake;
            perfiles = perfilesFake;
            nombres = nombresFake;
            indiceActual = 0;
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
                pictureBox1.Image = historias[indiceActual];
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
                DialogResult resultado = MessageBox.Show(
                    "No hay más historias por ver.\n¿Quieres cerrar esta ventana?",
                    "Fin de historias",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
                // Si elige No, simplemente se queda viendo la historia actual.
            }
        }
    }
}

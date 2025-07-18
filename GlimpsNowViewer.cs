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
        private int indiceActual = 0;

        public GlimpsNowViewer(List<Image> imagenes)
        {
            historias = imagenes;
            MostrarHistoria();
        }

        private void MostrarHistoria()
        {
            if (indiceActual < historias.Count)
            {
                pictureBox1.Image = historias[indiceActual];
            }
            else
            {
                this.Close(); // o MessageBox y cerrar después
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indiceActual++;
            MostrarHistoria();
        }

    }
}

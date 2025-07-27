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
    public partial class Tendencias : Form
    {
        public Tendencias()
        {
            InitializeComponent();
        }

        List<Image> imagenes = new List<Image>();
        int indiceActual = 0;
        int siguiente = 3;

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            siguiente--;
            if (siguiente == 0)
            {
                siguiente = 5;
            }
            switch (siguiente)
            {
                case 1:
                    pictureBoxOutfit.Image = Properties.Resources._1;
                    pictureblusa.Image = Properties.Resources.top1;
                    picturepantalon.Image = Properties.Resources.pantalon1;
                    picturezapatos.Image = Properties.Resources.sandalia1;
                    picturebolso.Image = Properties.Resources.bolso1;
                    pictureaccesorios.Image = Properties.Resources.cinturon1;
                    picturelentes.Image = Properties.Resources.Glimpse_App__grupo_5;


                    break;
                case 2:
                    pictureBoxOutfit.Image = Properties.Resources._2;
                    pictureblusa.Image = Properties.Resources.top2;
                    picturepantalon.Image = Properties.Resources.bermuda2;
                    picturezapatos.Image = Properties.Resources.Glimpse_App__grupo_5;
                    picturebolso.Image = Properties.Resources.bolso2;
                    picturelentes.Image = Properties.Resources.Glimpse_App__grupo_5;
                    pictureaccesorios.Image = Properties.Resources.Glimpse_App__grupo_5;
                    break;
                case 3:
                    pictureBoxOutfit.Image = Properties.Resources._3;
                    pictureblusa.Image = Properties.Resources.top3;
                    picturepantalon.Image = Properties.Resources.pantalon3;
                    picturezapatos.Image = Properties.Resources.sandalia3;
                    picturebolso.Image = Properties.Resources.bolso3;
                    picturelentes.Image = Properties.Resources.gafas3;
                    pictureaccesorios.Image = Properties.Resources.Glimpse_App__grupo_5;
                    break;
                case 4:
                    pictureBoxOutfit.Image = Properties.Resources._4;
                    pictureblusa.Image = Properties.Resources.vestido4;
                    picturepantalon.Image = Properties.Resources.Glimpse_App__grupo_5;
                    picturezapatos.Image = Properties.Resources.sandalia4;
                    picturebolso.Image = Properties.Resources.bolso4;
                    picturelentes.Image = Properties.Resources.Glimpse_App__grupo_5;
                    pictureaccesorios.Image = Properties.Resources.Glimpse_App__grupo_5;
                    break;
                case 5:
                    pictureBoxOutfit.Image = Properties.Resources._5;
                    pictureblusa.Image = Properties.Resources.vestido5;
                    picturepantalon.Image = Properties.Resources.Glimpse_App__grupo_5;
                    picturezapatos.Image = Properties.Resources.Glimpse_App__grupo_5;
                    picturebolso.Image = Properties.Resources.Glimpse_App__grupo_5;
                    picturelentes.Image = Properties.Resources.gafas5;
                    pictureaccesorios.Image = Properties.Resources.pulseras5;
                    break;
                default:
                    break;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            siguiente++;
            if (siguiente == 6)
            {
                siguiente = 1;
            }
            switch (siguiente)
            {
                case 1:
                    pictureBoxOutfit.Image = Properties.Resources._1;
                    pictureblusa.Image = Properties.Resources.top1;
                    picturepantalon.Image = Properties.Resources.pantalon1;
                    picturezapatos.Image = Properties.Resources.sandalia1;
                    picturebolso.Image = Properties.Resources.bolso1;
                    pictureaccesorios.Image = Properties.Resources.cinturon1;
                    picturelentes.Image = Properties.Resources.blanco;


                    break;
                case 2:
                    pictureBoxOutfit.Image = Properties.Resources._2;
                    pictureblusa.Image = Properties.Resources.top2;
                    picturepantalon.Image = Properties.Resources.bermuda2;
                    picturezapatos.Image = Properties.Resources.blanco;
                    picturebolso.Image = Properties.Resources.bolso2;
                    picturelentes.Image = Properties.Resources.blanco;
                    pictureaccesorios.Image = Properties.Resources.blanco;
                    break;
                case 3:
                    pictureBoxOutfit.Image = Properties.Resources._3;
                    pictureblusa.Image = Properties.Resources.top3;
                    picturepantalon.Image = Properties.Resources.pantalon3;
                    picturezapatos.Image = Properties.Resources.sandalia3;
                    picturebolso.Image = Properties.Resources.bolso3;
                    picturelentes.Image = Properties.Resources.gafas3;
                    pictureaccesorios.Image = Properties.Resources.blanco;
                    break;
                case 4:
                    pictureBoxOutfit.Image = Properties.Resources._4;
                    pictureblusa.Image = Properties.Resources.vestido4;
                    picturepantalon.Image = Properties.Resources.blanco;
                    picturezapatos.Image = Properties.Resources.sandalia4;
                    picturebolso.Image = Properties.Resources.bolso4;
                    picturelentes.Image = Properties.Resources.blanco;
                    pictureaccesorios.Image = Properties.Resources.blanco;
                    break;
                case 5:
                    pictureBoxOutfit.Image = Properties.Resources._5;
                    pictureblusa.Image = Properties.Resources.vestido5;
                    picturepantalon.Image = Properties.Resources.blanco;
                    picturezapatos.Image = Properties.Resources.blanco;
                    picturebolso.Image = Properties.Resources.blanco;
                    picturelentes.Image = Properties.Resources.gafas5;
                    pictureaccesorios.Image = Properties.Resources.pulseras5;
                    break;
                default:
                    break;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
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
        {
            Videos videos = new Videos();
            videos.Show();
            this.Close();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            Contactos contactos = new Contactos();
            contactos.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Me gusta!");
        }

        private void btnTendenciasMenu_Click(object sender, EventArgs e)
        {}
    }
}

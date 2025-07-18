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
    public partial class ImgFeed : Form
    {
        public ImgFeed()
        {
            InitializeComponent();
        }
    }

    public partial class frmImagen : Form
    {
        private PictureBox picCorazonVacio;
        private PictureBox picCorazonLleno;

        public frmImagen(Image imagen)
        {
            this.Size = new Size(600, 700); // Tamaño fijo
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Publicación";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Panel principal
            Panel contenedor = new Panel();
            contenedor.Dock = DockStyle.Fill;
            contenedor.BackColor = Color.White;
            contenedor.Padding = new Padding(0, 20, 0, 20);
            contenedor.AutoScroll = true;

            // Imagen centrada y con tamaño fijo
            PictureBox imgGrande = new PictureBox();
            imgGrande.Image = imagen;
            imgGrande.SizeMode = PictureBoxSizeMode.Zoom;
            imgGrande.Size = new Size(400, 500); // Aquí definís el tamaño exacto
            imgGrande.Location = new Point((contenedor.Width - imgGrande.Width) / 2, 0);
            imgGrande.Anchor = AnchorStyles.Top;
            imgGrande.Margin = new Padding(0, 0, 0, 10);

            // Corazón vacío
            picCorazonVacio = new PictureBox();
            picCorazonVacio.Image = Properties.Resources.corazon_vacio;
            picCorazonVacio.Size = new Size(50, 50);
            picCorazonVacio.SizeMode = PictureBoxSizeMode.Zoom;
            picCorazonVacio.Cursor = Cursors.Hand;
            picCorazonVacio.Location = new Point((this.ClientSize.Width - 50) / 2, imgGrande.Bottom + 20);
            picCorazonVacio.Anchor = AnchorStyles.None;

            // Corazón lleno
            picCorazonLleno = new PictureBox();
            picCorazonLleno.Image = Properties.Resources.corazon_lleno;
            picCorazonLleno.Size = new Size(50, 50);
            picCorazonLleno.SizeMode = PictureBoxSizeMode.Zoom;
            picCorazonLleno.Cursor = Cursors.Hand;
            picCorazonLleno.Location = picCorazonVacio.Location;
            picCorazonLleno.Visible = false;

            // Eventos de like
            picCorazonVacio.Click += (s, e) =>
            {
                picCorazonVacio.Visible = false;
                picCorazonLleno.Visible = true;
                MessageBox.Show("Me gusta!");
            };

            picCorazonLleno.Click += (s, e) =>
            {
                picCorazonLleno.Visible = false;
                picCorazonVacio.Visible = true;
                
            };

            // Agregar controles
            contenedor.Controls.Add(imgGrande);
            contenedor.Controls.Add(picCorazonVacio);
            contenedor.Controls.Add(picCorazonLleno);
            this.Controls.Add(contenedor);

            // Mover el corazón después de que el panel esté cargado
            this.Load += (s, e) =>
            {
                picCorazonVacio.Location = new Point((this.ClientSize.Width - 50) / 2, imgGrande.Bottom + 20);
                picCorazonLleno.Location = picCorazonVacio.Location;
            };
        }
    }



}

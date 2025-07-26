using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Inicioo
{
    public partial class FotosScroll : Form
    {
        public FotosScroll()
        {
            //Fondo y tamaño del form
            this.BackgroundImage = Image.FromFile("fondo .jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.Text = "Galería Glimpse";
            this.Size = new Size(1200, 800); 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Imagenes
            PictureBox imgSuperiorIzquierda = new PictureBox();
            imgSuperiorIzquierda.Image = Image.FromFile("Fotos.jpg"); // Cambia el nombre
            imgSuperiorIzquierda.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSuperiorIzquierda.Size = new Size(100, 25); // Ajusta tamaño como desees
            imgSuperiorIzquierda.Location = new Point(90, 116);
            imgSuperiorIzquierda.BackColor = Color.Transparent;
            imgSuperiorIzquierda.Click += (s, e) =>
            {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Close();
            };
            this.Controls.Add(imgSuperiorIzquierda);

            PictureBox img2 = new PictureBox();
            img2.Image = Image.FromFile("Inicio.jpg"); 
            img2.SizeMode = PictureBoxSizeMode.StretchImage;
            img2.Size = new Size(26, 26); 
            img2.Location = new Point(37, 255); 
            img2.BackColor = Color.Transparent;
            img2.Click += (s, e) =>
            {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Close();
            };
            this.Controls.Add(img2);

            PictureBox img3 = new PictureBox();
            img3.Image = Image.FromFile("Boton2.jpg");
            img3.SizeMode = PictureBoxSizeMode.StretchImage;
            img3.Size = new Size(26, 26);
            img3.Location = new Point(37, 307);
            img3.BackColor = Color.Transparent;
            img3.Click += (s, e) =>
            {
                Videos videos = new Videos();
                videos.Show();
                this.Close();
            };
            this.Controls.Add(img3);

            PictureBox img4 = new PictureBox();
            img4.Image = Image.FromFile("Boton3.jpg");
            img4.SizeMode = PictureBoxSizeMode.StretchImage;
            img4.Size = new Size(26, 26);
            img4.Location = new Point(38, 357);
            img4.BackColor = Color.Transparent;
            this.Controls.Add(img4);

            PictureBox img5 = new PictureBox();
            img5.Image = Image.FromFile("Boton4.jpg");
            img5.SizeMode = PictureBoxSizeMode.StretchImage;
            img5.Size = new Size(26, 26);
            img5.Location = new Point(40, 407);
            img5.BackColor = Color.Transparent;
            img5.Click += (s, e) =>
             {
                 GlimpseNow glimpse = new GlimpseNow();
                 glimpse.Show();
                 this.Close();
             };
            this.Controls.Add(img5);

            PictureBox img6 = new PictureBox();
            img6.Image = Image.FromFile("Usuarios.jpg");
            img6.SizeMode = PictureBoxSizeMode.StretchImage;
            img6.Size = new Size(42, 150);
            img6.Location = new Point(28, 580);
            img6.BackColor = Color.Transparent;
            this.Controls.Add(img6);

            PictureBox img7 = new PictureBox();
            img7.Image = Image.FromFile("Logo.jpg");
            img7.SizeMode = PictureBoxSizeMode.StretchImage;
            img7.Size = new Size(80, 65);
            img7.Location = new Point(10, 20);
            img7.BackColor = Color.Transparent;
            this.Controls.Add(img7);

            PictureBox img8 = new PictureBox();
            img8.Image = Image.FromFile("Calendario.jpg");
            img8.SizeMode = PictureBoxSizeMode.StretchImage;
            img8.Size = new Size(450, 255);
            img8.Location = new Point(720, 189);
            img8.BackColor = Color.Transparent;
            this.Controls.Add(img8);

            PictureBox img9 = new PictureBox();
            img9.Image = Image.FromFile("GlimpseNow.jpg");
            img9.SizeMode = PictureBoxSizeMode.StretchImage;
            img9.Size = new Size(190, 32);
            img9.Location = new Point(710, 150);
            img9.BackColor = Color.Transparent;
            img9.Click += (s, e) =>
            {
                GlimpseNow glimpse = new GlimpseNow();
                glimpse.Show();
                this.Close();
            };
            this.Controls.Add(img9);

            PictureBox img10 = new PictureBox();
            img10.Image = Image.FromFile("Boton1GlimpseNow.jpg");
            img10.SizeMode = PictureBoxSizeMode.StretchImage;
            img10.Size = new Size(310, 50);
            img10.Location = new Point(848, 460);
            img10.BackColor = Color.Transparent;
            this.Controls.Add(img10);

            PictureBox img11 = new PictureBox();
            img11.Image = Image.FromFile("Boton2GlimpseNow.JPG");
            img11.SizeMode = PictureBoxSizeMode.StretchImage;
            img11.Size = new Size(310, 208);
            img11.Location = new Point(848, 510);
            img11.BackColor = Color.Transparent;
            this.Controls.Add(img11);

            PictureBox img12 = new PictureBox();
            img12.Image = Image.FromFile("Megusta.jpg");
            img12.SizeMode = PictureBoxSizeMode.StretchImage;
            img12.Size = new Size(50, 49);
            img12.Location = new Point(751, 540);
            img12.BackColor = Color.Transparent;
            this.Controls.Add(img12);

            img12.Cursor = Cursors.Hand;
            img12.Click += (s, e) =>
            {
                FormMeGusta formMeGusta = new FormMeGusta();
                formMeGusta.Show(); // Usa ShowDialog() si quieres que sea modal
            };


            PictureBox img13 = new PictureBox();
            img13.Image = Image.FromFile("Guardados.jpg");
            img13.SizeMode = PictureBoxSizeMode.StretchImage;
            img13.Size = new Size(40, 59);
            img13.Location = new Point(756, 610);
            img13.BackColor = Color.Transparent;
            this.Controls.Add(img13);

            img13.Cursor = Cursors.Hand;
            img13.Click += (s, e) =>
            {
                FormGuardados formGuardados = new FormGuardados();
                formGuardados.Show();
            };


            PictureBox img14 = new PictureBox();
            img14.Image = Image.FromFile("Perfil.JPG");
            img14.SizeMode = PictureBoxSizeMode.StretchImage;
            img14.Size = new Size(45, 45);
            img14.Location = new Point(1098, 20);
            img14.BackColor = Color.Transparent;
            this.Controls.Add(img14);

            PictureBox img15 = new PictureBox();
            img15.Image = Image.FromFile("Notificaciones.jpg");
            img15.SizeMode = PictureBoxSizeMode.StretchImage;
            img15.Size = new Size(40, 40);
            img15.Location = new Point(1035, 20);
            img15.BackColor = Color.Transparent;
            this.Controls.Add(img15);

            PictureBox img16 = new PictureBox();
            img16.Image = Image.FromFile("Tablero.jpg");
            img16.SizeMode = PictureBoxSizeMode.StretchImage;
            img16.Size = new Size(120, 46);
            img16.Location = new Point(720, 462);
            img16.BackColor = Color.Transparent;
            this.Controls.Add(img16);

            PictureBox img17 = new PictureBox();
            img17.Image = Image.FromFile("Boton5.jpg");
            img17.SizeMode = PictureBoxSizeMode.StretchImage;
            img17.Size = new Size(28, 26);
            img17.Location = new Point(40, 456);
            img17.BackColor = Color.Transparent;
            this.Controls.Add(img17);


            // Panel contenedor (marco para el scroll de imágenes)
            Panel contenedor = new Panel()
            {
                Size = new Size(525, 580), // Solo ocupa parte del formulario
                Location = new Point(130, 150), // Posición: puedes ajustarla
                BackColor = Color.White,
                Padding = new Padding(0),
                Margin = new Padding(0)
            };

            // FlowLayoutPanel con scroll vertical dentro del contenedor
            FlowLayoutPanel panelScroll = new FlowLayoutPanel()
            {
                Size = new Size(600, this.Height -100), // Tamaño del panel de scroll
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight,
                Margin = new Padding(0),
                Padding = new Padding(0),
                BackColor = this.BackColor,
                BorderStyle = BorderStyle.None,
            };
            this.Controls.Add(panelScroll);

            Panel lineaScroll = new Panel()
            {
                BackColor = Color.FromArgb(216,191,216),// Rosado claro bonito
                Width = 5, // Grosor medio
                Height = panelScroll.Height -300,
                Location = new Point(panelScroll.Right + 80, panelScroll.Top + 250) // 3 cm ≈ 30px a la derecha
            };
            this.Controls.Add(lineaScroll);
            lineaScroll.BringToFront();

            // Cargar imágenes desde carpeta "imagenes"
            string rutaImagenes = Path.Combine(Application.StartupPath, @"..\..\imagenes");
            rutaImagenes = Path.GetFullPath(rutaImagenes);

            if (Directory.Exists(rutaImagenes))
            {
                string[] archivos = Directory.GetFiles(rutaImagenes, "*.jpg");

                //Diccionario de lo que dice cada foto
                Dictionary<string, string> textosPorImagen = new Dictionary<string, string>()
                {
                    { "img1", "Suetercito rosa sobre una camisa blaca. Vibes de 2021 - Adriana" },
                    { "img2", "Combinación de colores calidos - Kendra" },
                    { "img3", "Blanco y rosa, op top.- Alejandra" },
                    { "img4", "Combinación de texturas para invierno - Lourdes" },
                    { "img5", "Conjunto rosita para un trip - Fátima" },
                    { "img6", "Para la fiesta con las girls - Adriana" },
                    { "img7", "Eleva tu outfit con muchos accesorios - Kendra" },
                    { "img8", "Un bolso cruzado nunca está de más - Alejandra" },
                    { "img9", "Tendencia de las camisas de Brasil - Lourdes" },
                    { "img10", "Una paleta de color para todo el outfit, top - Fátima" },
                    { "img11", "Tacones + jeans = top - Adriana" },
                    { "img12", "Para una date con las girls - Kendra" },
                    { "img13", "Una paleta de color para todo el outfit, top - Alejandra" },
                    { "img14", "Una gorra siempre es un accesorio perfecto - Lourdes" },
                    { "img15", "Accesorio en el pelo = tendencia - Fátima" },
                    { "img16", "Eleva tus outfits con unos lentes - Adriana" },
                    { "img17", "Todo de blanco para marcar tendencia - Kendra" },
                    { "img18", "Un escote para mostrar los hombros es cute - Alejandra" },
                    { "img19", "Un escote para mostrar los hombros es cute - Lourdes" },
                    { "img20", "Vibes de The Vampire Diaries - Fátima" },
                    { "img21", "Outfit para otoño - Adriana" },
                    { "img22", "Un moño siempre eleva las vibes - Kendra" },
                    { "img23", "Vibes de Francia en cualquier lado del mundo - Alejandra" },
                    { "img24", "Sueter a los hombros = top - Lourdes" },
                    { "img25", "Los converses nunca pasarán de moda - Fátima" },
                    { "img26", "Casual, pero siempre con una bolsa cute - Adriana" },
                    { "img27", "Casual, pero siempre con una bolsa cute - Kendra" },
                    { "img28", "Un color distinto siempre es buena opción - Alejandra" },
                    { "img29", "Chaqueta + lentes = on top - Lourdes" },
                    { "img30", "Los estampados siempre son buena opción - Fátima" },
                    { "img31", "Una faldita para vernos cute - Adriana" },
                    { "img32", "Mocasines + calcetas = tendencia - Kendra" },
                    { "img33", "Para una date perfecta en verano - Alejandra" },
                    { "img34", "Las corbatas son un accesorio perfecto - Lourdes" },
                    { "img35", "Algo distinto, pero que vale la pena usar - Fátima" },
                    { "img36", "La vieja confiable (botas) - Adriana" },
                    { "img37", "El rojo oscuro siempre estará en tendencia - Alejandra" },
                    { "img38", "Ni tan formal, ni tan informal - Kendra" },
                    { "img39", "Una conbinación distinta, pero que vale la pena - Lourdes" }
                };
                foreach (string archivo in archivos)
                {
                    string nombreArchivo = Path.GetFileNameWithoutExtension(archivo);
                    string textoPersonalizado = textosPorImagen.ContainsKey(nombreArchivo)
                        ? textosPorImagen[nombreArchivo]
                        : "Comparte tu historia\nCada día\n#glimpse";

                    // Panel para contener la imagen y el overlay
                    Panel panelImagen = new Panel()
                    {
                        Size = new Size(250, 270),
                        Margin = new Padding(7),
                        BackColor = Color.Transparent
                    };

                    void MostrarMensajeTemporal(string texto)
                    {
                        Label mensaje = new Label()
                        {
                            Text = texto,
                            BackColor = Color.FromArgb(200, 0, 0, 0),  // negro semitransparente
                            ForeColor = Color.White,
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            AutoSize = false,
                            Size = new Size(panelImagen.Width - 40, 80),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Location = new Point(20, (panelImagen.Height - 80) / 2),
                            Visible = true,
                            BorderStyle = BorderStyle.FixedSingle,
                            Padding = new Padding(10),
                        };

                        panelImagen.Controls.Add(mensaje);
                        mensaje.BringToFront();

                        Timer timer = new Timer();
                        timer.Interval = 3000;
                        timer.Tick += (s, e) =>
                        {
                            timer.Stop();
                            panelImagen.Controls.Remove(mensaje);
                            mensaje.Dispose();
                            timer.Dispose();
                        };
                        timer.Start();
                    }

                    // Imagen
                    PictureBox pic = new PictureBox()
                    {
                        Image = Image.FromFile(archivo),
                        Dock = DockStyle.Fill,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    // Overlay
                    Panel overlay = new Panel()
                    {
                        BackColor = Color.FromArgb(120, 247, 225, 255),
                        Dock = DockStyle.Fill,
                        Visible = false,
                    };

                    // Descripción
                    Label descripcion = new Label()
                    {
                        Text = textoPersonalizado,
                        ForeColor = Color.DarkMagenta,
                        BackColor = Color.Transparent,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        MaximumSize = new Size(panelImagen.Width - 20, 0), // ancho un poco menor que el panel para evitar corte
                        Size = new Size(panelImagen.Width - 20, 60), // alto suficiente para varias líneas
                        Location = new Point(10, (panelImagen.Height - 60) / 2), // posición centrada vertical y con margen horizontal
                    };

                    // Botón Me gusta
                    Label btnLike = new Label()
                    {
                        Text = "❤️ Me gusta",
                        ForeColor = Color.HotPink,
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Bottom,
                        Height = 25,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand
                    };
                    btnLike.Click += (s, e) => {
                        MostrarMensajeTemporal("Esta opción está en construcción. Gracias por usar Glimpse. ❤️");
                    };

                    // Botón Guardar
                    Label btnGuardar = new Label()
                    {
                        Text = "📌 Guardar",
                        ForeColor = Color.HotPink,
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Bottom,
                        Height = 25,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand

                    };
                    btnGuardar.Click += (s, e) => {
                        MostrarMensajeTemporal("Esta opción está en construcción. Gracias por usar Glimpse. ❤️");
                    };

                    overlay.Controls.Add(descripcion);
                    overlay.Controls.Add(btnGuardar);
                    overlay.Controls.Add(btnLike);

                    overlay.BringToFront();
                    btnLike.BringToFront();
                    btnGuardar.BringToFront();

                    void MostrarOverlay(object s, EventArgs e) => overlay.Visible = true;

                    void OcultarOverlay(object s, EventArgs e)
                    {
                        Point cursorPos = overlay.PointToClient(Cursor.Position);
                        if (!overlay.ClientRectangle.Contains(cursorPos) &&
                            !btnLike.Bounds.Contains(cursorPos) &&
                            !btnGuardar.Bounds.Contains(cursorPos))
                        {
                            overlay.Visible = false;
                        }
                    }

                    panelImagen.MouseEnter += MostrarOverlay;
                    panelImagen.MouseLeave += OcultarOverlay;
                    pic.MouseEnter += MostrarOverlay;
                    pic.MouseLeave += OcultarOverlay;
                    overlay.MouseEnter += MostrarOverlay;
                    overlay.MouseLeave += OcultarOverlay;

                    panelImagen.Controls.Add(pic);
                    panelImagen.Controls.Add(overlay);
                    overlay.BringToFront();

                    panelScroll.Controls.Add(panelImagen);

                }
            }
            else
            {
                MessageBox.Show("No se encontró la carpeta 'imagenes'.");
            }
            // Agregar el panel de scroll dentro del contenedor
            contenedor.Controls.Add(panelScroll);
            this.Controls.Add(contenedor);
        }
    }
}

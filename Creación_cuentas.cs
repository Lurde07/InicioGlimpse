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
    public partial class Creación_cuentas : Form
    {
        public Creación_cuentas()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            string user, pass, correo, correct_pass, correct_user, correct_correo;
            user = txt_user.Text;
            pass = txt_password.Text;
            correo = txt_correo.Text;
            correct_user = txt_user.Text;
            correct_pass = txt_password.Text;
            correct_correo = txt_correo.Text;

            if (user == correct_user & pass == correct_pass)
            {


                Inicio_de_sesión datos = new Inicio_de_sesión();
                datos.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario, correo o contraseña incorrecto ");
                txt_user.Clear();
                txt_password.Clear();
                txt_user.Focus();
            }

            this.Close();
        }

        private void Creación_cuentas_Load(object sender, EventArgs e)
        {

        }
    }
}

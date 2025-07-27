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
    public partial class Inicio_de_sesión : Form
    {
        public Inicio_de_sesión()
        {
            InitializeComponent();
        }

        private void Inicio_de_sesión_Load(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass, correo, correct_pass, correct_user, correct_correo;
            user = txt_Usuario.Text;
            pass = txt_pass.Text;
            correo = txt_correoelectronico.Text;
            correct_user = txt_Usuario.Text;
            correct_pass = txt_pass.Text;
            correct_correo = txt_correoelectronico.Text;

            if (user == correct_user & pass == correct_pass & correo == correct_correo)
            {


                Inicio Inicio = new Inicio();
                Inicio.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario ,correo o contraseña incorrecto ");
                txt_Usuario.Clear();
                txt_pass.Clear();
                txt_correoelectronico.Clear();
                txt_Usuario.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creación_cuentas Creación_cuentas = new Creación_cuentas();
            Creación_cuentas.Show();
            this.Hide();
        }
    }
}

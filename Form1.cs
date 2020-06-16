using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMécanicoProgra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Nuevo_Empleado Registrarse;
        Menu_Principal Catalogo;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Registrarse = new Nuevo_Empleado();
            Registrarse.Show();
        }
        //Me equivoqué y puse al textbox como btn y txt 
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (Usuario.Autentificar(btnusuario.Text, btncontrasena.Text) > 0) 
            {
                Catalogo = new Menu_Principal();
                Catalogo.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}

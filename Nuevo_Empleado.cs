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
    public partial class Nuevo_Empleado : Form
    {
        public Nuevo_Empleado()
        {
            InitializeComponent();
        }

        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                if(Usuario.CrearCuenta(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    MessageBox.Show("Se ha creado una cuenta correctamente ");
                }
                else
                {
                    MessageBox.Show("Error: No se ha podido crear la cuenta");
                }
            }
        }
    }
}

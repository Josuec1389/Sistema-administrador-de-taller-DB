using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMécanicoProgra
{
    class Usuario
    {
        public static int CrearCuenta(string usuario, string contrasena)
        {
            int resultado = 0;
            SqlConnection Conn = Conexion_DB.HacerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuario (Nombre, Contraseña) values ('{0}', PwdEncrypt('{1}'))", usuario, contrasena), Conn);
            resultado = Comando.ExecuteNonQuery();
            Conn.Close();
            return resultado;
        }
        public static int Autentificar(string usuario, string contrasena)
        {
            int resultado = -1;
            SqlConnection Conn = Conexion_DB.HacerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("Select * From Usuario Where Nombre = '{0}' and PwdCompare('{1}', Contraseña) =1", usuario, contrasena), Conn);
            SqlDataReader Lector = Comando.ExecuteReader();

            while (Lector.Read())
            {
                resultado = 50;
            }

            Conn.Close();
            return resultado;
        }
    }
}

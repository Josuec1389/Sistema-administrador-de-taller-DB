using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Configuration;

namespace TallerMécanicoProgra
{
    class Conexion_DB
    {
        private string conexion = string.Empty;
        private SqlConnection conectar;
        private SqlCommand comando;
        private SqlDataAdapter dataA;
        private DataTable dataT;
        private DataSet dataS;

        public static SqlConnection HacerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Taller Mécanico; Integrated Security=True");
            Conn.Open();
            return Conn;
        }
    }
}

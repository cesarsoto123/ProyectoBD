using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miproyecto2
{
    internal class ClaseConexion
    {
        private readonly string connectionString;

        public ClaseConexion()
        {
            string nombre_servidor = Dns.GetHostName();
            connectionString = $"Data Source={nombre_servidor};Initial Catalog=TIENDITAP9;Integrated Security=True;";
        }

        public string Cadena()
        {
            return connectionString; // Devuelve la cadena de conexión
        }
    }
}

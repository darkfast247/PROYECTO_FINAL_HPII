using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    internal class Conexion
    {
        SqlConnection SqlCon;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public void open()
        {
            try
            {
                string nombre_servidor = Dns.GetHostName();
                SqlCon = new SqlConnection("Data Source=DESKTOP-AI45HF9\\SQLEXPRESS;Initial Catalog=PASCUALMENTOR;Integrated Security=True");
                SqlCon.Open();
            }
            catch (Exception)
            { }
        }
        public void close()
        {
            SqlCon.Close();
        }
        public string Cadena()
        {
            return SqlCon.ConnectionString;
        }

    }
}

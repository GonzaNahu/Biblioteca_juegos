using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteca_juegos
{
    class Global
    {
        public static MySqlConnection Conexion = new MySqlConnection("server=localhost; database=biblioteca; Uid=root; password=; SslMode=none; Allow Zero Datetime=False;Convert Zero Datetime=True;Persist Security Info=True");
        public static int id_user = 0;
        public static string user;
        public static int ind = 0;
    }
}

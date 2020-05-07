using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Universidad
{
    class Conn
    {
        public static SqlConnection sqlconeccion = new SqlConnection(@"workstation id=BDUniversidad.mssql.somee.com;packet size=4096;user id=Plietez09_SQLLogin_1;pwd=rdhrj2tcgm;data source=BDUniversidad.mssql.somee.com;persist security info=False;initial catalog=BDUniversidad");
        public static SqlCommand com = new SqlCommand();
    }
}

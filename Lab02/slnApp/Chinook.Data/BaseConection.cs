using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class BaseConection
    {
        public  string getConection()
        {
            string cadenaConexion = "Server=S000-00;DataBase=ChinookSabado;User ID=sa;Password=sql;";
            return cadenaConexion;
        }
    }
}

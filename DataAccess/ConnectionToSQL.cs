using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSQL
    {
        private readonly string ConnectionString;
        public ConnectionToSQL()
        {//Nombre del servidor de la computadora y base de datos
            ConnectionString = "Server=DESKTOP-1JFS3GR; DataBase = Restaurante; integrated security = true";
        }

        //ENCAPSULAMIENTO DE LA OBTENCIÓN DE LA CONEXION 

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString); //PRIVADA para que solo pueda ser modificada y accedida por la misma clase 
        }
    }
}

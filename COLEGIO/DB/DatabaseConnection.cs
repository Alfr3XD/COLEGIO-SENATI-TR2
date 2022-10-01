using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace COLEGIO.DB
{
    class DatabaseConnection
    {
        protected SqlConnection Connection =
            new SqlConnection(
            "Server=ALFR3XD-PC;DataBase=Colegio;Integrated Security=true"
            );

        public SqlConnection GetConnection()
        {
            return Connection;
        }
    }
}

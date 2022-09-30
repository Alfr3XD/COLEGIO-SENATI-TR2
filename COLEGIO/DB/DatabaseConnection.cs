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
            "Server=07-LAB112PC05;DataBase=Colegio;Integrated Security=true"
            );

        public SqlConnection GetConnection()
        {
            return Connection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql() {
            connectionString = "Data Source=THEDARKSARCO;Initial Catalog=BIT_ADCON;Integrated Security=True";
        }

        protected SqlConnection GetConnection() {
            return new SqlConnection( connectionString );
        }
    }
}

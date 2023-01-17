using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO
{
    public class AddressBookOperations
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBookSystem;Integrated Security=true;";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}

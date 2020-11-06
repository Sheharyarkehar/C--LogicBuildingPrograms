using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checking
{
    class Connection
    {
       static SqlConnection con = null;
        public static SqlConnection connection() {
           String connectionString=@"Data Source=SHERY\SQLEXPRESS;Initial Catalog=SchoolManagement;Integrated Security=True";
            con=new SqlConnection(connectionString);

            return con;
        
        } 


    }
}

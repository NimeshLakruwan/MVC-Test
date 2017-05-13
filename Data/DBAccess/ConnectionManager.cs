using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DBAccess
{
    public class ConnectionManager
    {
        internal static SqlConnection con;

        internal SqlConnection getConnection() {

            try
            {
                con = new SqlConnection("Data Source=NIMESHPC\\SQLEXPRESS; Initial Catalog=Customer;Integrated Security=True");
            }
            catch (Exception)
            {

                throw;
            }
            return con;
        }

        //internal static SqlConnection con;
        //internal SqlConnection getConnection()
        //{
        //    try
        //    {
        //        con = new SqlConnection("Data Source=NIMESHPC\\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=SSPI;");
        //    }
        //    catch (Exception)
        //    {

        //    }

        //    return con;
        //}
    }
}

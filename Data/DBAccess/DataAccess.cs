using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DBAccess
{
    public class DataAccess
    {
        internal static SqlConnection con;
        ConnectionManager man = new ConnectionManager();


        private void connect()
        {
            con = man.getConnection();
        }

        public DataTable loadData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                connect();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter ad = new SqlDataAdapter(com);
                ad.Fill(dt);
                con.Close();
                return dt;
            }
            catch (SqlException)
            {
              
                return dt;
            }
            catch (Exception)
            {
               
                return dt;
            }
        }
        public bool setData(string query)
        {
            bool updated = false;
            int affectRows = 0;
            connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = con;
                affectRows = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                if (affectRows > 0)
                {
                    updated = true;
                }


            }
            catch (SqlException)
            {
               
                if (con.State == ConnectionState.Open) con.Close();

            }
            catch (Exception)
            {
             
                if (con.State == ConnectionState.Open) con.Close();

            }

            return updated;

        }
    }
}

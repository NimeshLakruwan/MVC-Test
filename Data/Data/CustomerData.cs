using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DataDetails;
using Data.DBAccess;
using System.Data;

namespace Data.Data
{
    public class CustomerData
    {
        public static bool insertCustomer(CustomerDetails cus)
        {
            bool inserted = false;
            //hgfjdkghdkjgfdjg

            string queary = "INSERT INTO CustomerDetails(CustomerId,CustomerName,CustomerAddress,CustomerTelephone) VALUES('" + cus.CustomerId + "','" + cus.CustomerName + "','" + cus.CustomerAddress + "','" + cus.CustomerTelephone + "')";
            DataAccess da = new DataAccess();
            inserted = da.setData(queary);
            return inserted;
        }

        public static bool updateCustomer(CustomerDetails cus)
        {
            bool inserted = false;

            string queary = "UPDATE CustomerDetails SET CustomerName='" + cus.CustomerName + "', CustomerAddress='" + cus.CustomerAddress + "', CustomerTelephone='" + cus.CustomerTelephone + "' WHERE CustomerId='"+cus.CustomerId+"'";
            DataAccess da = new DataAccess();
            inserted = da.setData(queary);
            return inserted;
        }

        public static bool deleteCustomer(int id)
        {
            bool delete = false;

            string queary = "DELETE FROM CustomerDetails WHERE CustomerId='" + id + "'";
            DataAccess da = new DataAccess();
            delete = da.setData(queary);
            return delete;
        }

    }
}

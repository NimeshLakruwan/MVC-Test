using Data.DataDetails;
using Data.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class CustomerPrefData
    {
        public static bool insertCustomerPref(CusPrefDetails cus)
        {
            bool inserted = false;

            string queary = "INSERT INTO CustomerPreference(CustomerSerial,CustomerLike,CustomerDisLike,CustomerFeedBack) VALUES('"+cus.CustomerSerial+"','" + cus.CustomerLike + "','" + cus.CustomerDisLike + "','" + cus.CustomerFeedBack + "')";
            DataAccess da = new DataAccess();
            inserted = da.setData(queary);
            return inserted;
        }

        public static bool updateCustomerPref(CusPrefDetails cus)
        {
            bool inserted = false;

            //string queary = "UPDATE CustomerPreference SET CustomerId='" + cus.CustomerId + "', CustomerLike='" + cus.CustomerLike + "', CustomerDisLike='" + cus.CustomerDisLike + "', CustomerFeedBack='" + cus.CustomerFeedBack + "' WHERE CustomerPreferenceSerial='" + cus.CustomerPreferenceSerial + "'";
            //DataAccess da = new DataAccess();
            //inserted = da.setData(queary);
            return inserted;
        }
    }
}

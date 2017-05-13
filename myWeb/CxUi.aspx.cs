using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.DataDetails;
using Data.Data;

namespace myWeb
{
    public partial class CxUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            if (txtAddress.Text!=null && txtId.Text!=null && txtName.Text!=null && txtTelephone.Text!=null)
            {
                CustomerDetails cusDetails = new CustomerDetails();

                cusDetails.CustomerId = Convert.ToInt16(txtId.Text);
                cusDetails.CustomerName = txtName.Text;
                cusDetails.CustomerAddress = txtAddress.Text;
                cusDetails.CustomerTelephone = txtTelephone.Text;

                CustomerData.insertCustomer(cusDetails);
                Clear();
            }
            else
            {

            }
         
        }

        protected void Clear() {

            txtTelephone.Text = string.Empty;
            txtName.Text = string.Empty;
            txtId.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtId.Text!=null)
            {
                CustomerDetails cusDetails = new CustomerDetails();

                cusDetails.CustomerId = Convert.ToInt16(txtId.Text);
                cusDetails.CustomerName = txtName.Text;
                cusDetails.CustomerAddress = txtAddress.Text;
                cusDetails.CustomerTelephone = txtTelephone.Text;

                CustomerData.updateCustomer(cusDetails);
                Clear();
            }
          
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtId.Text!=string.Empty)
            {
                int CustomerId = Convert.ToInt16(txtId.Text);
                CustomerData.deleteCustomer(CustomerId);
                Clear();
            }
            else
            {
               
            }
          
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Report.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myWeb
{
    public partial class CustomerMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CxPeferenceUi.aspx");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CxUi.aspx");
        }
    }
}
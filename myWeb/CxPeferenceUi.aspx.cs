using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.DataDetails;
using Data.View;
using Data.Data;

namespace myWeb
{
    public partial class CxPeferenceUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["CxFeedBack"] = new List<CusPrefView>();
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            if (drpID.SelectedIndex!=0 && txtDisLike.Text!=null && txtFeedBack.Text!=null && txtLike.Text!=null)
            {
                List<CusPrefView> domain = new List<CusPrefView>();
                domain = (List<CusPrefView>)Session["CxFeedBack"];

                CusPrefView cx = new CusPrefView();
                cx.CustomerPreferenceSerial = 0;
                cx.CustomerSerial = Convert.ToInt32(drpID.SelectedValue);
                cx.CustomerLike = txtLike.Text;
                cx.CustomerDisLike = txtDisLike.Text;
                cx.CustomerFeedBack = txtFeedBack.Text;

                domain.Add(cx);
                Session["CxFeedBack"] = domain;
                dgvCxLike.DataSource = domain;
                dgvCxLike.DataBind();
            }        
            else
            {

            }
            txtDisLike.Text = null;
            txtFeedBack.Text = null;
            txtLike.Text = null;
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            CusPrefDetails details = new CusPrefDetails();

            if (drpID.SelectedIndex!=0)
            {
                details.CustomerSerial = Convert.ToInt16(drpID.SelectedValue);
      

                if (dgvCxLike.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvCxLike.Rows.Count; i++)
                    {
                        details.CustomerLike = dgvCxLike.Rows[i].Cells[2].Text;
                        details.CustomerDisLike = dgvCxLike.Rows[i].Cells[3].Text;
                        details.CustomerFeedBack = dgvCxLike.Rows[i].Cells[4].Text;

                        CustomerPrefData.insertCustomerPref(details);                    
                    }
                   
                }
                Clear();
            }
            else
            {

            }
    
        }
        protected void Clear() {

            drpID.SelectedIndex = 0;
            txtLike.Text = null;
            txtFeedBack.Text = null;
            txtDisLike.Text = null;

            Session["CxFeedBack"] = null;
            dgvCxLike.DataSource = null;
            dgvCxLike.DataBind();

        }
    }
}
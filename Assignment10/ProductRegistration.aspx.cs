using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment10
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblInfo.Visible = false;
                PCateg.Items.Add("Mobiles");
                PCateg.Items.Add("Watches");
                PCateg.Items.Add("Tv");
                PCateg.Items.Add("Books");
            }
            
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblInfo.Visible = true;
            LblInfo.Text = "Registration Success";
            LblInfo.Text += "<br> Name :" + TxtName.Text;
            LblInfo.Text += "<br> Category :" + PCateg.Text;
            LblInfo.Text += "<br> Price :" + TxtPrice.Text;
            LblInfo.Text += "<br> Description :" + TxtDesc.Text;
            LblInfo.Text += "<br> Release Date :" + Calendar1.SelectedDate;
        }
    }
}
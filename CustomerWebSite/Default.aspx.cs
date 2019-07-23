using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private customerwebservice.WebService webservice;
    protected void page_Load(object sender, EventArgs e)
    {
        webservice = new customerwebservice.WebService();

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        int id = webservice.Authenticate(txtUsername.Text, txtPassword.Text);
        if (id > 0)
        {
            Session["id"] = id;
            Response.Redirect("projectDetails.aspx");
        }
        else
        {
            lblMessage.Text = "Incorrect login details, please try again";
        }
    }
}
            
        
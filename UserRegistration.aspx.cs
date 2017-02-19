using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Admin objAdmin = new Admin();
            objAdmin.SaveUserRegistration(Convert.ToInt32(txtuserid.Text), Convert.ToString(txtusername.Text), Convert.ToString(txtpassword.Text), Convert.ToString(txtrole.Text));
            Response.Redirect("Login.aspx");
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
}
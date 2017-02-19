using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Admin objAdmin = new Admin();

        Int64 UserID = objAdmin.GetUserDetails(txtUserName.Text, txtPassword.Text);
        if (UserID > 0)
        {
            Session["UserID"] = UserID;
            Response.Redirect("StudentMaster.aspx");
        }
        else
        {
            lblErrorMessage.Text = "Invalid username or password";
            this.lblErrorMessage.ForeColor = Color.Red;
        }

    }
}
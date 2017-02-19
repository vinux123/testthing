using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class StudentMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Admin objAdmin = new Admin();
            DataTable dt = objAdmin.BindStudentsList();
            grid1.DataSource = dt;
            grid1.DataBind();
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Admin objAdmin = new Admin();
        // If both the search terms on student master form is empty, then load all the records from general_register.
        if ((String.IsNullOrEmpty(txtRegNo.Text)) && (String.IsNullOrEmpty(txtName.Text)))
        {
            DataTable dt = objAdmin.BindStudentsList();
            grid1.DataSource = dt;
            grid1.DataBind();
        }
        else
        {
            if (txtRegNo.Text.Length > 0)
            {
                DataTable dt = objAdmin.GetStudentsList(Convert.ToInt32(txtRegNo.Text));
                grid1.DataSource = dt;
                grid1.DataBind();
            }
            else if (txtName.Text.Length > 0)
            {
                DataTable dt = objAdmin.GetStudentsList(Convert.ToString(txtName.Text));
                grid1.DataSource = dt;
                grid1.DataBind();
            }
        }
    }
    protected void grid1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void grid1_RowCommand(object sender,
  GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Show")
        {
            // Retrieve the row index stored in the 
            // CommandArgument property.
            int index = Convert.ToInt32(e.CommandArgument);

            Response.Redirect("StudentMasterEntry.aspx?RegID=" + e.CommandArgument);
        }

    }

    protected void btnExport_Click(object sender, EventArgs e)
    {
         
    }
}
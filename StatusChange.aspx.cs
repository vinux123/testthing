using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StatusChange : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtcstatus.Enabled = false;
        txtnstatus.Enabled = false;
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            Admin objAdmin = new Admin();
            txtcstatus.Text = Convert.ToString(objAdmin.GetStudStatus(txtRegNo.Text));
            txtcstatus.Enabled = false;
            txtnstatus.Enabled = true;
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Admin objAdmin = new Admin();
            objAdmin.SetStudStatus(Convert.ToString(txtRegNo.Text), Convert.ToString(txtnstatus.Text));
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            txtnstatus.Text = String.Empty;
            txtcstatus.Text = String.Empty;
            txtcstatus.Enabled = false;
            txtnstatus.Enabled = false;
        }
    }
}
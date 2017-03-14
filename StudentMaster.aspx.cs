using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;


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
                DataTable dt = objAdmin.GetStudentsList(Convert.ToString(txtRegNo.Text));
                grid1.DataSource = dt;
                grid1.DataBind();
            }
            else if (txtName.Text.Length > 0)
            {
                DataTable dt = objAdmin.GetStudentsList1(Convert.ToString(txtName.Text));
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
            Response.Redirect("StudentMasterEntry.aspx?RegID=" + e.CommandArgument);
        }

    }

    protected void btnExport_Click(object sender, EventArgs e)
    {
        Admin objAdmin = new Admin();
        DataTable dt = objAdmin.ExportToExcel();

        string path = Server.MapPath("ExportedData") + "/ExportedStudentData_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") +".csv";
        File.WriteAllText(path, table_to_csv(dt));

        if (File.Exists(path))
        {
            string message = string.Empty;
            message = "File Generated Successfully";

            string alert_redirect_Script = string.Format(@"<script type=""text/javascript"">
                                       alert('{0}');
                                        window.location = 'StudentMaster.aspx';
                                       </script>", message);
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alertredirectscript", alert_redirect_Script, false);
        }
    }

    public static string table_to_csv(DataTable table)
    {
        string file = "";

        foreach (DataColumn col in table.Columns)
            file = string.Concat(file, col.ColumnName, ",");

        file = file.Remove(file.LastIndexOf(','), 1);
        file = string.Concat(file, "\r\n");

        foreach (DataRow row in table.Rows)
        {
            foreach (object item in row.ItemArray)
                file = string.Concat(file, item.ToString(), ",");

            file = file.Remove(file.LastIndexOf(','), 1);
            file = string.Concat(file, "\r\n");
        }
        return file;
    }
}
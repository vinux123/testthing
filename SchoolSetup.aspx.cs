using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using iTextSharp.text;
using System.Web.Services;

public partial class SchoolSetup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Admin objAdmin = new Admin();
            DataTable dt = objAdmin.GetSchoolSetup(1);

            if (dt.Rows.Count > 0)
            {
                txtorg.Text = dt.Rows[0]["orgname"].ToString();
                txtschool.Text = dt.Rows[0]["schoolname"].ToString();
                txtaddress.Text = dt.Rows[0]["line1"].ToString();
                txtemailphn.Text = dt.Rows[0]["line2"].ToString();
                txtIndexUdise.Text = dt.Rows[0]["line3"].ToString();
                txtregistration.Text = dt.Rows[0]["line4"].ToString();
            }
        }   

        txtorg.Enabled = false;
        txtschool.Enabled = false;
        txtaddress.Enabled = false;
        txtaddress.Enabled = false;
        txtemailphn.Enabled = false;
        txtIndexUdise.Enabled = false;
        txtregistration.Enabled = false;
        btnEdit.Enabled = true;
        btnSubmit.Enabled = false;
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        txtorg.Enabled = true;
        txtschool.Enabled = true;
        txtaddress.Enabled = true;
        txtaddress.Enabled = true;
        txtemailphn.Enabled = true;
        txtIndexUdise.Enabled = true;
        txtregistration.Enabled = true;
        btnEdit.Enabled = false;
        btnSubmit.Enabled = true;

        
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Admin objAdmin = new Admin();
            objAdmin.SaveSchoolSetup(1, Convert.ToString(txtorg.Text), Convert.ToString(txtschool.Text), Convert.ToString(txtaddress.Text), Convert.ToString(txtemailphn.Text), Convert.ToString(txtIndexUdise.Text), Convert.ToString(txtregistration.Text));
        }

        catch (Exception ex)
        {
            throw ex;
        }

        txtorg.Enabled = false;
        txtschool.Enabled = false;
        txtaddress.Enabled = false;
        txtaddress.Enabled = false;
        txtemailphn.Enabled = false;
        txtIndexUdise.Enabled = false;
        txtregistration.Enabled = false;
        btnEdit.Enabled = true;
        btnSubmit.Enabled = false;

    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (ImageUpload.HasFile)
        {
            // create the path to save file to
            //string fileName = Server.MapPath("Assets/Images/" + ImageUpload.FileName);

            string fileName = Server.MapPath("Assets/Images/" + "vplogo.png");

            if (File.Exists(fileName))
            {
                // Check file existance, if file exists delete file. 
                FileInfo fi = new FileInfo(fileName);
                if (fi.Exists)
                {
                    fi.Delete();
                    //save newly uploaded file. 
                    ImageUpload.SaveAs(fileName);
                }
            }
        }
    }
}
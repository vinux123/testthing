using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using iTextSharp;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;

public partial class StudentMasterEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Int32 ID = Convert.ToInt32(Request.QueryString["RegID"]);
            String ID = Convert.ToString(Request.QueryString["RegID"]);
            //if (ID.Length > 0)
            if(!String.IsNullOrEmpty(ID))
            {
                Admin objAdmin = new Admin();
                DataTable dt=objAdmin.GetStudentsList(ID);
                if (dt.Rows.Count > 0)
                {
                    txtStatus.Text = dt.Rows[0]["stud_status"].ToString();  
                    txtRegNo.Text = dt.Rows[0]["stud_regno"].ToString().Substring(2, dt.Rows[0]["stud_regno"].ToString().Length - 2);
                    txtGroup.SelectedValue = dt.Rows[0]["stud_regno"].ToString().Substring(0, 2);
                    txtIDNo.Text = dt.Rows[0]["stud_idno"].ToString();
                    txtUID.Text = dt.Rows[0]["stud_uid"].ToString();
                    
                    txtFName.Text = dt.Rows[0]["stud_fname"].ToString();
                    txtMName.Text = dt.Rows[0]["stud_mname"].ToString();
                    txtSName.Text = dt.Rows[0]["stud_lname"].ToString();
                    txtMotherName.Text = dt.Rows[0]["stud_mothers_name"].ToString();

                    txtReligion.Text = dt.Rows[0]["stud_religion"].ToString();
                    txtCaste.Text = dt.Rows[0]["stud_caste"].ToString();
                    txtSubcast.Text = dt.Rows[0]["stud_subcaste"].ToString();
                    txtNationality.Text = dt.Rows[0]["stud_nationality"].ToString();
                    txtMothertongue.Text = dt.Rows[0]["stud_mothertongue"].ToString();

                    txtVillage.Text = dt.Rows[0]["stud_pob_village"].ToString();
                    txtTaluka.Text = dt.Rows[0]["stud_pob_taluka"].ToString();
                    txtDist.Text = dt.Rows[0]["stud_pob_dist"].ToString();
                    txtState.Text = dt.Rows[0]["stud_pob_state"].ToString();
                    txtCountry.Text = dt.Rows[0]["stud_pob_country"].ToString();

                    calDOB.Text = Convert.ToDateTime(dt.Rows[0]["stud_dob"]).ToString("yyyy-MM-dd");
                    txtPrevSchoolName.Text = dt.Rows[0]["stud_last_school"].ToString();
                    txtPrevStandard.Text = dt.Rows[0]["stud_last_standard"].ToString();
                    CalAdmissionDate.Text = Convert.ToDateTime(dt.Rows[0]["stud_admission_date"]).ToString("yyyy-MM-dd");
                    txtClass.Text = dt.Rows[0]["stud_admission_standard"].ToString();
                    
                    txtProgress.Text = dt.Rows[0]["stud_progress"].ToString();
                    txtConduct.Text = dt.Rows[0]["stud_conduct"].ToString();
                    txtDOL.Text = Convert.ToDateTime(dt.Rows[0]["stud_dol"]).ToString("yyyy-MM-dd");
                    txtStandard.Text = dt.Rows[0]["stud_admission_standard"].ToString();
                    txtReasonLeaving.Text = dt.Rows[0]["stud_reasonofleaving"].ToString();
                    txtRemarks.Text = dt.Rows[0]["stud_remarks"].ToString();
                    
                    // disable all the textboxes since this is view mode. 
                    // in order to get into update mode and enable textboxes, one needs to click on update button

                    txtRegNo.Enabled = false;
                    txtGroup.Enabled = false;
                    txtUID.Enabled = false;
                    txtIDNo.Enabled = false;
                    txtStatus.Enabled = false;
                    txtFName.Enabled = false;
                    txtMName.Enabled = false;
                    txtSName.Enabled = false;
                    txtMotherName.Enabled = false;
                    txtReligion.Enabled = false;
                    txtCaste.Enabled = false;
                    txtSubcast.Enabled = false;
                    txtNationality.Enabled = false;
                    txtMothertongue.Enabled = false;
                    txtVillage.Enabled = false;
                    txtTaluka.Enabled = false;
                    txtDist.Enabled = false;
                    txtState.Enabled = false;
                    txtCountry.Enabled = false;
                    calDOB.Enabled = false;
                    txtStandard.Enabled = false;
                    txtPrevSchoolName.Enabled = false;
                    txtPrevStandard.Enabled = false;
                    CalAdmissionDate.Enabled = false;
                    txtClass.Enabled = false;
                    txtPendingDocs.Enabled = false;
                    txtConduct.Enabled = false;
                    txtProgress.Enabled = false;
                    txtDOL.Enabled = false;
                    txtStandard.Enabled = false;
                    txtReasonLeaving.Enabled = false;
                    txtRemarks.Enabled = false;
                    
                    // disable Submit button, as this is view only mode.
                    btnSubmit.Visible = false;
                }
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Admin objAdmin = new Admin();

            objAdmin.SaveStudentDetails(Convert.ToString(txtGroup.Text) + Convert.ToString(txtRegNo.Text), Convert.ToString(txtIDNo.Text), Convert.ToString(txtUID.Text), Convert.ToString(txtFName.Text),
                                        Convert.ToString(txtMName.Text), Convert.ToString(txtSName.Text), Convert.ToString(txtMotherName.Text), Convert.ToString(txtReligion.Text),
                                        Convert.ToString(txtCaste.Text), Convert.ToString(txtSubcast.Text), Convert.ToString(txtNationality.Text), Convert.ToString(txtMothertongue.Text),
                                        Convert.ToString(txtVillage.Text), Convert.ToString(txtTaluka.Text), Convert.ToString(txtDist.Text), Convert.ToString(txtState.Text), Convert.ToString(txtCountry.Text),
                                        Convert.ToString(calDOB.Text), Convert.ToString(txtPrevSchoolName.Text), Convert.ToString(txtPrevStandard.Text), Convert.ToString(CalAdmissionDate.Text), Convert.ToString(txtClass.Text), Convert.ToString(txtProgress.Text),
                                        Convert.ToString(txtConduct.Text), Convert.ToString(txtDOL.Text), Convert.ToString(txtStandard.Text), Convert.ToString(txtReasonLeaving.Text), Convert.ToString(txtRemarks.Text), Convert.ToString(txtStatus.Text));
            
            string message = string.Empty;
            if (btnSubmit.Text.ToLower() == "update")
            {
                message = "Record updated successfully";
            }
            else
            {
                message = "Record inserted successfully";
            }
     
            string alert_redirect_Script = string.Format(@"<script type=""text/javascript"">
                                       alert('{0}');
                                        window.location = 'StudentMaster.aspx';
                                       </script>", message);
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alertredirectscript", alert_redirect_Script, false);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    
    protected void btnGenerateLC_Click(object sender, EventArgs e)
    {
        String ID = Convert.ToString(txtGroup.SelectedValue) + Convert.ToString(txtRegNo.Text);
        string pdfregno;
        string pdfsid;
        string pdfsuid;
        string pdffname;
        string pdfmname;
        string pdflname;
        //string pdfstudname;
        string pdfmothernm;
        string pdfreligion;
        string pdfsubcaste;
        string pdfcaste;
        string pdfnationality;
        string pdfmothertongue;
        string pdfvillage;
        string pdftaluka;
        string pdfdist;
        string pdfstate;
        string pdfcountry;
        string pdfdob;
        string pdflastschool;
        string pdfadmissiondate;
        string pdfprogress;
        string pdfconduct;
        string pdfdol;
        string pdfstandard;
        string pdfreason;
        string pdfremarks;
        string pdfstdstudying;
        //string pdfstdstudyingw;
        string pdfadmstandard;

        Admin objAdmin = new Admin();
        DataTable dt = objAdmin.GetStudentsList(Convert.ToString(ID));

        pdfregno = dt.Rows[0]["stud_regno"].ToString();
        pdfsid = dt.Rows[0]["stud_idno"].ToString();
        pdfsuid = dt.Rows[0]["stud_uid"].ToString();
        pdffname = dt.Rows[0]["stud_fname"].ToString();
        pdfmname = dt.Rows[0]["stud_mname"].ToString();
        pdflname = dt.Rows[0]["stud_lname"].ToString();
        pdfmothernm = dt.Rows[0]["stud_mothers_name"].ToString();
        pdfreligion = dt.Rows[0]["stud_religion"].ToString();
        pdfcaste = dt.Rows[0]["stud_caste"].ToString();
        pdfsubcaste = dt.Rows[0]["stud_subcaste"].ToString();
        pdfnationality = dt.Rows[0]["stud_nationality"].ToString();
        pdfmothertongue = dt.Rows[0]["stud_mothertongue"].ToString();
        pdfvillage = dt.Rows[0]["stud_pob_village"].ToString();
        pdftaluka = dt.Rows[0]["stud_pob_taluka"].ToString();
        pdfdist = dt.Rows[0]["stud_pob_dist"].ToString();
        pdfstate = dt.Rows[0]["stud_pob_state"].ToString();
        pdfcountry = dt.Rows[0]["stud_pob_country"].ToString();
        pdfdob = dt.Rows[0]["stud_dob"].ToString();
        pdflastschool = dt.Rows[0]["stud_last_school"].ToString();
        pdfstandard = dt.Rows[0]["stud_last_standard"].ToString();
        pdfadmissiondate = dt.Rows[0]["stud_admission_date"].ToString();
        pdfadmstandard = dt.Rows[0]["stud_admission_standard"].ToString();
        pdfprogress = dt.Rows[0]["stud_progress"].ToString();
        pdfconduct = dt.Rows[0]["stud_conduct"].ToString();
        pdfdol = dt.Rows[0]["stud_dol"].ToString();
        pdfstdstudying = dt.Rows[0]["stud_standard_studying"].ToString();
        pdfreason = dt.Rows[0]["stud_reasonofleaving"].ToString();
        pdfremarks = dt.Rows[0]["stud_remarks"].ToString();

                   
        //server folder path which is stored your PDF documents
        string path = Server.MapPath("PDF-Files");
        string filename = path + "/LC_" + txtFName.Text + ".pdf";
        string imageURL = Server.MapPath("Assets/Images") + "/vplogo.png";
        iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);
        
        //Create new PDF document
        Document document = new Document(PageSize.A4, 50f, 7.5f, 12.7f, 12.7f); 
        //Declare Fonts. 
        BaseFont marathi = iTextSharp.text.pdf.BaseFont.CreateFont("C:\\WINDOWS\\Fonts\\SHIV01.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); // --> CHANGED
        BaseFont timesnew = iTextSharp.text.pdf.BaseFont.CreateFont("C:\\windows\\fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        BaseFont timesnewbd = iTextSharp.text.pdf.BaseFont.CreateFont("C:\\windows\\fonts\\timesbd.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        BaseFont header = iTextSharp.text.pdf.BaseFont.CreateFont("C:\\windows\\fonts\\timesbd.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        BaseFont header1 = iTextSharp.text.pdf.BaseFont.CreateFont("C:\\windows\\fonts\\timesbd.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

        iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(marathi, 18, iTextSharp.text.Font.BOLD);
        iTextSharp.text.Font fontTimes = new iTextSharp.text.Font(timesnew, 12, iTextSharp.text.Font.NORMAL);
        iTextSharp.text.Font fontTimesbd = new iTextSharp.text.Font(timesnew, 12, iTextSharp.text.Font.BOLD);
        iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(header, 18, iTextSharp.text.Font.BOLD);
        iTextSharp.text.Font fontHeader1 = new iTextSharp.text.Font(header1, 21, iTextSharp.text.Font.BOLD);

        try
        {
            PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create));

            //Open document. 
            document.Open();

            // Note Line goes directly into paragraph and added to document. 
            Paragraph paragraph = new Paragraph(@"Note: No change in any entry in this certificate shall be made except by the authority issuing it and any infringement of this requirement is liable to invoice the imposition of penalty such as the rustication.", fontTimes);
            document.Add(paragraph);

            //Resize image depend upon your need
            jpg.ScaleToFit(50f, 50f);
            jpg.Alignment = iTextSharp.text.Image.TEXTWRAP | iTextSharp.text.Image.ALIGN_LEFT;
            jpg.SpacingBefore = 10f;
            jpg.SpacingAfter = 10f;

            Paragraph paragraph1 = new Paragraph();
            Chunk p1c1 = new Chunk(jpg, 0f, -65f);
            Paragraph paragraph3 = new Paragraph("VIDYA PRATISHTHAN'S", fontHeader);
            paragraph3.Alignment = Element.ALIGN_CENTER;

            Paragraph paragraph4 = new Paragraph(new Phrase("SOMESHWAR ENGLISH MEDIUM SCHOOL", fontHeader1));
            paragraph4.Alignment = Element.ALIGN_CENTER;
            paragraph4.SpacingBefore = -10f;

            document.Add(p1c1);
            document.Add(paragraph3);
            document.Add(paragraph4);

            Paragraph paragraph5 = new Paragraph("Waghalwadi - Someshwarnagar Tal - Baramati Dist - Pune - 412306", fontTimes);
            paragraph5.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph5);

            Chunk p6c1 = new Chunk("Web site: ", fontTimesbd);
            Chunk p6c2 = new Chunk("www.vpsomeshwar.org", fontTimes);
            Chunk p6c3 = new Chunk("     ", fontTimes);
            Chunk p6c4 = new Chunk("Email id: ", fontTimesbd);
            Chunk p6c5 = new Chunk("someshwar.vpsems@gmail.com", fontTimes);

            Paragraph paragraph6 = new Paragraph();
            paragraph6.Add(p6c1);
            paragraph6.Add(p6c2);
            paragraph6.Add(p6c3);
            paragraph6.Add(p6c4);
            paragraph6.Add(p6c5);
            paragraph6.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph6);

            Chunk p7c1 = new Chunk("SSC Index No. ", fontTimesbd);
            Chunk p7c2 = new Chunk("11.02.061", fontTimes);
            Chunk p7c3 = new Chunk("    ", fontTimes);
            Chunk p7c4 = new Chunk("School Udise No.: ", fontTimesbd);
            Chunk p7c5 = new Chunk("27250207610", fontTimes);

            Paragraph paragraph7 = new Paragraph();
            paragraph7.Add(p7c1);
            paragraph7.Add(p7c2);
            paragraph7.Add(p7c3);
            paragraph7.Add(p7c4);
            paragraph7.Add(p7c5);
            paragraph7.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph7);

            // Marathi Line is divided into chunks and then merged to paragraph and added to document. 
            Chunk c1 = new Chunk("nap`aSaaÀ2008", fontNormal);
            Chunk c2 = new Chunk("-");
            Chunk c3 = new Chunk("09", fontNormal);
            Chunk c4 = new Chunk("À[Mg`ajaIÀmaanyataÀ D 512", fontNormal);
            Chunk c5 = new Chunk("(");
            Chunk c6 = new Chunk("ba", fontNormal);
            Chunk c7 = new Chunk(") ");
            Chunk c8 = new Chunk("3728id.8À10À2009", fontNormal);

            Paragraph paragraph2 = new Paragraph();
            paragraph2.Add(c1);
            paragraph2.Add(c2);
            paragraph2.Add(c3);
            paragraph2.Add(c4);
            paragraph2.Add(c5);
            paragraph2.Add(c6);
            paragraph2.Add(c7);
            paragraph2.Add(c8);
            paragraph2.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph2);

            Paragraph paragraph9 = new Paragraph("LEAVING CERTIFICATE", fontHeader1);
            paragraph9.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph9);

            Chunk p10c1 = new Chunk("Regd. No. of Pupil: ", fontTimes);
            Chunk p10c4 = new Chunk(pdfregno.ToUpper(), fontTimesbd);
            Chunk p10c2 = new Chunk("                                                                                     ", fontTimes);
            Chunk p10c3 = new Chunk("Serial No.: ", fontTimes);

            //put Auto generated serial number here.

            Paragraph paragraph10 = new Paragraph();
            paragraph10.Add(p10c3);
            paragraph10.Add(p10c2);
            paragraph10.Add(p10c1);
            paragraph10.Add(p10c4);
            paragraph10.Alignment = Element.ALIGN_JUSTIFIED;
            paragraph10.SpacingBefore = 5f;
            document.Add(paragraph10);

            //Line seperator.
            Paragraph paragraph8 = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0f, 90.0f, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(paragraph8);

            Chunk p11c1 = new Chunk("Student ID : ", fontTimes);
            Chunk p11c2 = new Chunk(pdfsid.ToUpper(), fontTimesbd);
            Paragraph paragraph11 = new Paragraph();
            paragraph11.Add(p11c1);
            paragraph11.Add(p11c2);
            paragraph11.Alignment = Element.ALIGN_JUSTIFIED;
            paragraph11.SpacingBefore = 5f;
            document.Add(paragraph11);

            Chunk p12c1 = new Chunk("UID No. (Aadhaar Card No.) : ", fontTimes);
            Chunk p12c2 = new Chunk(pdfsuid, fontTimesbd);
            Paragraph paragraph12 = new Paragraph();
            paragraph12.Add(p12c1);
            paragraph12.Add(p12c2);
            paragraph12.Alignment = Element.ALIGN_JUSTIFIED;
            paragraph12.SpacingBefore = 5f;
            document.Add(paragraph12);

            //Line seperator.
            Paragraph paragraph12a = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0f, 90.0f, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(paragraph12a);

            Chunk p13c1 = new Chunk("1] Name of Pupil : (Name)  ", fontTimes);
            Chunk p13c2 = new Chunk(pdffname.ToUpper(), fontTimesbd);
            Chunk p13c3 = new Chunk("        (Middle Name)  ", fontTimes);
            Chunk p13c4 = new Chunk(pdfmname.ToUpper(), fontTimesbd);
            Chunk p13ac5 = new Chunk("        (Surname)  ", fontTimes);
            Chunk p13ac6 = new Chunk(pdflname.ToUpper(), fontTimesbd);
            Paragraph paragraph13 = new Paragraph();
            paragraph13.Add(p13c1);
            paragraph13.Add(p13c2);
            paragraph13.Add(p13c3);
            paragraph13.Add(p13c4);
            paragraph13.Alignment = Element.ALIGN_JUSTIFIED;
            paragraph13.SpacingBefore = 5f;
            document.Add(paragraph13);
            Paragraph paragraph13a = new Paragraph();
            paragraph13a.Add(p13ac5);
            paragraph13a.Add(p13ac6);
            document.Add(paragraph13a);

            Chunk p14c1 = new Chunk("2] Mother's Name :  ", fontTimes);
            Chunk p14c2 = new Chunk(pdfmothernm.ToUpper(), fontTimesbd);
            Paragraph paragraph14 = new Paragraph();
            paragraph14.Add(p14c1);
            paragraph14.Add(p14c2);
            paragraph14.SpacingBefore = 5f;
            document.Add(paragraph14);

            Chunk p15c1 = new Chunk("3] Religion :  ", fontTimes);
            Chunk p15c2 = new Chunk(pdfreligion.ToUpper(), fontTimesbd);
            Chunk p15c3 = new Chunk("    Caste :  ", fontTimes);
            Chunk p15c4 = new Chunk(pdfcaste.ToUpper(), fontTimesbd);
            Chunk p15c5 = new Chunk("    Subcaste :  ", fontTimes);
            Chunk p15c6 = new Chunk(pdfsubcaste.ToUpper(), fontTimesbd);
            Paragraph paragraph15 = new Paragraph();
            paragraph15.Add(p15c1);
            paragraph15.Add(p15c2);
            paragraph15.Add(p15c3);
            paragraph15.Add(p15c4);
            paragraph15.Add(p15c5);
            paragraph15.SpacingBefore = 5f;
            document.Add(paragraph15);

            Chunk p16c1 = new Chunk("4] Nationality :  ", fontTimes);
            Chunk p16c2 = new Chunk(pdfnationality.ToUpper(), fontTimesbd);
            Chunk p16c3 = new Chunk("    Mothertongue :  ", fontTimes);
            Chunk p16c4 = new Chunk(pdfmothertongue.ToUpper(), fontTimesbd);
            Paragraph paragraph16 = new Paragraph();
            paragraph16.Add(p16c1);
            paragraph16.Add(p16c2);
            paragraph16.Add(p16c3);
            paragraph16.Add(p16c4);
            paragraph16.SpacingBefore = 5f;
            document.Add(paragraph16);

            Chunk p17c1 = new Chunk("5] Place of Birth : (Village/City)  ", fontTimes);
            Chunk p17c2 = new Chunk(pdfvillage.ToUpper(), fontTimesbd);
            Chunk p17c3 = new Chunk("    (Tal.)  ", fontTimes);
            Chunk p17c4 = new Chunk(pdftaluka.ToUpper(), fontTimesbd);
            Chunk p17c5 = new Chunk("    (Dist.)  ", fontTimes);
            Chunk p17c6 = new Chunk(pdfdist.ToUpper(), fontTimesbd);
            Paragraph paragraph17 = new Paragraph();
            paragraph17.Add(p17c1);
            paragraph17.Add(p17c2);
            paragraph17.Add(p17c3);
            paragraph17.Add(p17c4);
            paragraph17.Add(p17c5);
            paragraph17.Add(p17c6);
            paragraph17.SpacingBefore = 5f;
            document.Add(paragraph17);

            Chunk p18c1 = new Chunk("(State)  ", fontTimes);
            Chunk p18c2 = new Chunk(pdfstate.ToUpper(), fontTimesbd);
            Chunk p18c3 = new Chunk("    (Country)  ", fontTimes);
            Chunk p18c4 = new Chunk(pdfcountry.ToUpper(), fontTimesbd);
            Paragraph paragraph18 = new Paragraph();
            paragraph18.Add(p18c1);
            paragraph18.Add(p18c2);
            paragraph18.Add(p18c3);
            paragraph18.Add(p18c4);
            document.Add(paragraph18);

            string dob = pdfdob.Substring(0, 10);
            Chunk p19c1 = new Chunk("6] Date of Birth a) in Figure ", fontTimes);
            Chunk p19c2 = new Chunk(pdfdob.Substring(0, 10).ToUpper(), fontTimesbd);
            Paragraph paragraph19 = new Paragraph();
            paragraph19.Add(p19c1);
            paragraph19.Add(p19c2);
            paragraph19.SpacingBefore = 5f;
            document.Add(paragraph19);

            DateTime dob1 = DateTime.Parse(dob);
            var doboutput = WrittenNumerics.DateToWritten(dob1);

            Chunk p20c1 = new Chunk(" b) Date of Birth in Words ", fontTimes);
            Chunk p20c2 = new Chunk(doboutput.ToUpper(), fontTimesbd);
            Paragraph paragraph20 = new Paragraph();
            paragraph20.Add(p20c1);
            paragraph20.Add(p20c2);
            document.Add(paragraph20);

            Chunk p21c1 = new Chunk("7] Last School attended and Standard ", fontTimes);
            Chunk p21c2 = new Chunk(pdflastschool.ToUpper(), fontTimesbd);
            Paragraph paragraph21 = new Paragraph();
            paragraph21.Add(p21c1);
            paragraph21.Add(p21c2);
            paragraph21.SpacingBefore = 5f;
            document.Add(paragraph21);

            Chunk p22c1 = new Chunk("8] Date of Admission in the School : ", fontTimes);
            Chunk p22c2 = new Chunk(pdfadmissiondate.Substring(0, 10).ToUpper(), fontTimesbd);
            Chunk p22c3 = new Chunk("     Standard  ", fontTimes);
            Chunk p22c4 = new Chunk(pdfadmstandard.ToUpper(), fontTimesbd);
            Paragraph paragraph22 = new Paragraph();
            paragraph22.Add(p22c1);
            paragraph22.Add(p22c2);
            paragraph22.Add(p22c3);
            paragraph22.Add(p22c4);
            paragraph22.SpacingBefore = 5f;
            document.Add(paragraph22);

            Chunk p23c1 = new Chunk("9] Progress : ", fontTimes);
            Chunk p23c2 = new Chunk(pdfprogress.ToUpper(), fontTimesbd);
            Chunk p23c3 = new Chunk("            Conduct : ", fontTimes);
            Chunk p23c4 = new Chunk(pdfconduct.ToUpper(), fontTimesbd);
            Paragraph paragraph23 = new Paragraph();
            paragraph23.Add(p23c1);
            paragraph23.Add(p23c2);
            paragraph23.Add(p23c3);
            paragraph23.Add(p23c4);
            paragraph23.SpacingBefore = 5f;
            document.Add(paragraph23);

            Chunk p24c1 = new Chunk("10] Date of Leaving the School : ", fontTimes);
            Chunk p24c2 = new Chunk(pdfdol.Substring(0, 10).ToUpper(), fontTimesbd);
            Paragraph paragraph24 = new Paragraph();
            paragraph24.Add(p24c1);
            paragraph24.Add(p24c2);
            paragraph24.SpacingBefore = 5f;
            document.Add(paragraph24);

            string pdfstd1 = " ";
            switch (pdfstdstudying)
            {
                case "1":
                    pdfstd1 = pdfstdstudying + "st";
                    break;
                case "2":
                    pdfstd1 = pdfstdstudying + "nd";
                    break;
                case "3":
                    pdfstd1 = pdfstdstudying + "rd";
                    break;
                default:
                    pdfstd1 = pdfstdstudying + "th";
                    break;
            }

            Chunk p25c1 = new Chunk("11] Standard in which studying and since when : a) In Figure  ", fontTimes);
            Chunk p25c2 = new Chunk(pdfstd1, fontTimesbd);
            Paragraph paragraph25 = new Paragraph();
            paragraph25.Add(p25c1);
            paragraph25.Add(p25c2);
            paragraph25.SpacingBefore = 5f;
            document.Add(paragraph25);

            string pdfstdstudyingw = "     ";
            switch (pdfstdstudying)
            {
                case "1":
                    pdfstdstudyingw = "First";
                    break;
                case "2":
                    pdfstdstudyingw = "Second";
                    break;
                case "3":
                    pdfstdstudyingw = "Third";
                    break;
                case "4":
                    pdfstdstudyingw = "Fourth";
                    break;
                case "5":
                    pdfstdstudyingw = "Fifth";
                    break;
                case "6":
                    pdfstdstudyingw = "Sixth";
                    break;
                case "7":
                    pdfstdstudyingw = "Seventh";
                    break;
                case "8":
                    pdfstdstudyingw = "Eighth";
                    break;
                case "9":
                    pdfstdstudyingw = "Ninth";
                    break;
                case "10":
                    pdfstdstudyingw = "Tenth";
                    break;
                case "11":
                    pdfstdstudyingw = "Eleventh";
                    break;
                case "12":
                    pdfstdstudyingw = "Twealth";
                    break;
            }
            Chunk p25ac1 = new Chunk("  b) In Words :  ", fontTimes);
            Chunk p25ac2 = new Chunk(pdfstdstudyingw.ToUpper(), fontTimesbd);
            Paragraph paragraph25a = new Paragraph();
            paragraph25a.Add(p25ac1);
            paragraph25a.Add(p25ac2);
            paragraph25a.SpacingBefore = 5f;
            document.Add(paragraph25a);


            Chunk p26c1 = new Chunk("12] Reason of leaving the school : ", fontTimes);
            Chunk p26c2 = new Chunk(pdfreason.ToUpper(), fontTimesbd);
            Paragraph paragraph26 = new Paragraph();
            paragraph26.Add(p26c1);
            paragraph26.Add(p26c2);
            paragraph26.SpacingBefore = 5f;
            document.Add(paragraph26);

            Chunk p27c1 = new Chunk("13] Remarks : ", fontTimes);
            Chunk p27c2 = new Chunk(pdfremarks.ToUpper(), fontTimesbd);
            Paragraph paragraph27 = new Paragraph();
            paragraph27.Add(p27c1);
            paragraph27.Add(p27c2);
            paragraph27.SpacingBefore = 5f;
            document.Add(paragraph27);

            Paragraph paragraph28 = new Paragraph("Certified that above information is in accordance with the School Register No. 1", fontTimes);
            paragraph28.Alignment = Element.ALIGN_CENTER;
            paragraph28.SpacingBefore = 5f;
            document.Add(paragraph28);

            Paragraph paragraph29 = new Paragraph("Date:     /     / 2017", fontTimes);
            paragraph29.Alignment = Element.ALIGN_LEFT;
            document.Add(paragraph29);

            Paragraph paragraph30 = new Paragraph("Clerk                              Class Teacher                             In-Charge                                Principal", fontTimes);
            paragraph30.Alignment = Element.ALIGN_JUSTIFIED;
            paragraph30.SpacingBefore = 50f;
            document.Add(paragraph30);

            ////table item. 
            //PdfPTable table = new PdfPTable(2);
            //table.SpacingBefore = 10f;
            //table.DefaultCell.FixedHeight = 25f;
            //table.HorizontalAlignment = Element.ALIGN_CENTER;

            //table.AddCell(new Paragraph("1] Name of Pupil in full",fontTimes));
            //table.AddCell(new Paragraph(pdfstudname,fontTimes));
            //table.AddCell(new Paragraph("2] Caste and Sub Caste",fontTimes));
            //table.AddCell(new Paragraph(pdfcaste,fontTimes));
            //table.AddCell(new Paragraph("3] Mother's Name",fontTimes));
            //table.AddCell(new Paragraph(pdfmothernm,fontTimes));
            //table.AddCell(new Paragraph("4] Nationality",fontTimes));
            //table.AddCell("");
            //table.AddCell(new Paragraph("5] Place of Birth",fontTimes));
            //table.AddCell(new Paragraph(pdfpob,fontTimes));

            //PdfPTable innertable = new PdfPTable(1);
            //innertable.DefaultCell.PaddingTop = 0;
            //innertable.DefaultCell.Border = Rectangle.NO_BORDER;
            //innertable.AddCell(new Paragraph("6] Date of Birth",fontTimes));
            //innertable.AddCell(new Paragraph("a) In Figure",fontTimes));
            //innertable.AddCell(new Paragraph("b) In Words",fontTimes));
            //innertable.AddCell(new Paragraph("(According to Christian era)",fontTimes));
            //PdfPCell pdfpcell1 = new PdfPCell(innertable);
            //table.AddCell(pdfpcell1);

            //// innertable created for rowspan. 
            //PdfPTable innertable1 = new PdfPTable(1);
            //innertable1.DefaultCell.PaddingTop = 0;
            //innertable1.DefaultCell.Border = Rectangle.NO_BORDER;
            //innertable1.AddCell("");

            //string dob = pdfdob.Substring(0, 10);
            //innertable1.AddCell(new Paragraph(dob,fontTimes));

            //DateTime dob1 = DateTime.Parse(dob);
            //var doboutput = WrittenNumerics.DateToWritten(dob1);
            //innertable1.AddCell("");
            //innertable1.AddCell(new Paragraph(doboutput,fontTimes));

            //PdfPCell pdfpcell2 = new PdfPCell(innertable1);
            //table.AddCell(pdfpcell2);

            //table.AddCell(new Paragraph("7] Last School attended and Standard",fontTimes));
            //table.AddCell(new Paragraph(pdflastschool,fontTimes));
            //table.AddCell(new Paragraph("8] Date of Admission",fontTimes));
            //string pdfadmissiondate1 = pdfadmissiondate.Substring(0, 10);
            //table.AddCell(new Paragraph(pdfadmissiondate1,fontTimes));
            //table.AddCell(new Paragraph("9] Progress",fontTimes));
            //table.AddCell(new Paragraph(pdfprogress,fontTimes));
            //table.AddCell(new Paragraph("10] Conduct",fontTimes));
            //table.AddCell(new Paragraph(pdfconduct,fontTimes));
            //table.AddCell(new Paragraph("11] Date of Leaving the School",fontTimes));
            //string pdfdol1 = pdfdol.Substring(0, 10);
            //table.AddCell(new Paragraph(pdfdol1,fontTimes));
            //table.AddCell(new Paragraph("12] Standard in which studying and since when",fontTimes));
            //table.AddCell(new Paragraph(pdfstandard, fontTimes));
            //table.AddCell(new Paragraph("13] Reason of Leaving the School",fontTimes));
            //table.AddCell(new Paragraph(pdfreason,fontTimes));
            //table.AddCell(new Paragraph("14] Remarks",fontTimes));
            //table.AddCell(new Paragraph(pdfremarks,fontTimes));
            //Paragraph paragraph11 = new Paragraph();
            //paragraph11.Add(table);
            //paragraph11.Alignment = Element.ALIGN_CENTER;

            //document.Add(table);

            //Paragraph paragraph12 = new Paragraph("Certified that above information is in accordance with the School Register.", fontTimes);
            //paragraph12.Alignment = Element.ALIGN_CENTER;
            //document.Add(paragraph12);

            //Paragraph paragraph13 = new Paragraph("Date:     /     / 2017", fontTimes);
            //paragraph13.Alignment = Element.ALIGN_LEFT;
            //document.Add(paragraph13);

            //Paragraph paragraph14 = new Paragraph("Clerk                                   Class Teacher                                    Principal", fontTimes);
            //paragraph14.Alignment = Element.ALIGN_CENTER;
            //paragraph14.SpacingBefore = 50f;
            //document.Add(paragraph14);

            Admin objAdmin1 = new Admin();
            objAdmin1.UpdateStudentStatus(Convert.ToString(txtGroup.SelectedValue) + Convert.ToString(txtRegNo.Text));
            
            string message = string.Empty;
            message = "LC Generated Successfully";
            string alert_redirect_Script = string.Format(@"<script type=""text/javascript"">
                                       alert('{0}');
                                        window.location = 'StudentMaster.aspx';
                                       </script>", message);
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alertredirectscript", alert_redirect_Script, false);
            //ShowPdf(filename);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        
        finally
        {
            document.Close();
        }      
    }

    public void ShowPdf(string filename)
    {
        //Clears all content output from Buffer Stream
        Response.ClearContent();

        //Clears all headers from Buffer Stream
        Response.ClearHeaders();

        //Adds an HTTP header to the output stream
        Response.AddHeader("Content-Disposition", "inline;filename=" + filename);

        //Gets or Sets the HTTP MIME type of the output stream
        Response.ContentType = "application/pdf";

        //Writes the content of the specified file directory to an HTTP response output stream as a file block
        Response.WriteFile(filename);

        //sends all currently buffered output to the client
        Response.Flush();

        //Clears all content output from Buffer Stream
        Response.Clear(); 
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        
        txtRegNo.Enabled = false;
        txtStatus.Enabled = false;
        txtUID.Enabled = true;
        txtIDNo.Enabled = true;
        txtFName.Enabled = true;
        txtMName.Enabled = true;
        txtSName.Enabled = true;
        txtMotherName.Enabled = true;
        txtReligion.Enabled = true;
        txtCaste.Enabled = true;
        txtSubcast.Enabled = true;
        txtNationality.Enabled = true;
        txtMothertongue.Enabled = true;
        txtVillage.Enabled = true;
        txtTaluka.Enabled = true;
        txtDist.Enabled = true;
        txtState.Enabled = true;
        txtCountry.Enabled = true;
        
        calDOB.Enabled = true;

        txtStandard.Enabled = true;
        txtPrevSchoolName.Enabled = true;
        txtPrevStandard.Enabled = true;
        CalAdmissionDate.Enabled = true;
        txtClass.Enabled = true;
        txtPendingDocs.Enabled = true;
        txtProgress.Enabled = true;
        txtConduct.Enabled = true;
        txtDOL.Enabled = true;
        txtStandard.Enabled = true;
        txtReasonLeaving.Enabled = true;
        txtRemarks.Enabled = true;
             
        btnSubmit.Text = "Update";
        btnSubmit.Visible = true;
        btnEdit.Visible = false;
     }
}
  

// Class to convert numeric date to word format. 

public static class WrittenNumerics
{
    static readonly string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    static readonly string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    static readonly string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    static readonly string[] thousandsGroups = { "", " Thousand", " Million", " Billion" };

    private static string FriendlyInteger(int n, string leftDigits, int thousands)
    {
        if (n == 0)
            return leftDigits;

        string friendlyInt = leftDigits;
        if (friendlyInt.Length > 0)
            friendlyInt += " ";

        if (n < 10)
            friendlyInt += ones[n];
        else if (n < 20)
            friendlyInt += teens[n - 10];
        else if (n < 100)
            friendlyInt += FriendlyInteger(n % 10, tens[n / 10 - 2], 0);
        else if (n < 1000)
            friendlyInt += FriendlyInteger(n % 100, (ones[n / 100] + " Hundred"), 0);
        else
            friendlyInt += FriendlyInteger(n % 1000, FriendlyInteger(n / 1000, "", thousands + 1), 0);

        return friendlyInt + thousandsGroups[thousands];
    }

    public static string DateToWritten(DateTime date)
    {
        return string.Format("{0} {1} {2}", IntegerToWritten(date.Day), date.ToString("MMMM"), IntegerToWritten(date.Year));
    }

    public static string IntegerToWritten(int n)
    {
        if (n == 0)
            return "Zero";
        else if (n < 0)
            return "Negative " + IntegerToWritten(-n);

        return FriendlyInteger(n, "", 0);
    }
}
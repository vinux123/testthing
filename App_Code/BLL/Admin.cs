using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Collections.Specialized;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Admin
/// </summary>
public class Admin
{
    public DataSet ds;
    public SqlDataReader MyReader;
    public string SqlCmd, SqlCon;
    DBHelper objDBHelper = new DBHelper();
    public Admin()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void SaveUserRegistration(Int32 user_uid, String user_username, String user_password, String user_role)
    {
        MySqlConnection conn;
        try
        {
            string connectionstring = objDBHelper.GetSQLConnectionString();
            conn = new MySqlConnection(connectionstring);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("User_Registration", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_uid", user_uid);
                cmd.Parameters.AddWithValue("@user_username", user_username);
                cmd.Parameters.AddWithValue("@user_password", user_password);
                cmd.Parameters.AddWithValue("@user_role", user_role);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        finally
        {
         
        }

    }

    public void SaveSchoolSetup(Int32 school_srno, String school_orgname, String school_schoolname, String school_line1, String school_line2, String school_line3, String school_line4)
    {
        MySqlConnection conn;
        try
        {
            string connectionstring = objDBHelper.GetSQLConnectionString();
            conn = new MySqlConnection(connectionstring);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("school_setup", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@school_srno", school_srno);
                cmd.Parameters.AddWithValue("@school_orgname", school_orgname);
                cmd.Parameters.AddWithValue("@school_schoolname", school_schoolname);
                cmd.Parameters.AddWithValue("@school_line1", school_line1);
                cmd.Parameters.AddWithValue("@school_line2", school_line2);
                cmd.Parameters.AddWithValue("@school_line3", school_line3);
                cmd.Parameters.AddWithValue("@school_line4", school_line4);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        finally
        {

        }

    }

    public DataTable GetSchoolSetup(Int32 school_srno)
    {
        DataTable dt = new DataTable();
        MySqlConnection Connection;
        String UserName = string.Empty;
        string connectionstring = objDBHelper.GetSQLConnectionString();
        Connection = new MySqlConnection(connectionstring);
        Connection.Open();

        string query = "Select * from school_setup where srno = " + school_srno ;
        MySqlCommand cmd = new MySqlCommand(query, Connection);
        MySqlDataReader dr = cmd.ExecuteReader();
        dt.Load(dr);
        Connection.Close();
        return dt;
    }
    
    public void SaveStudentDetails(String Reg_No, String Student_ID, String Student_UID, String Student_Fname, String Student_Mname, String Student_lname, String Student_mothers_name, String student_Religion, String Student_Caste,
        String Student_Subcaste, String Student_Nationality, String Student_MotherTongue, String Student_POB_Village, String Student_POB_taluka, String Student_POB_dist, String Student_POB_state, String Student_POB_country, String Student_DOB,
        String Student_last_school, String Student_last_Standard, String Student_admission_date, String Student_admission_Standard, String Student_progress, String Student_conduct, String Student_DOL, String Student_standard_studying, String Student_reasonofleaving, String Student_remarks, String Student_status)
    {
        MySqlConnection conn;
        
        try
        {   
            string connectionstring = objDBHelper.GetSQLConnectionString();
            conn = new MySqlConnection(connectionstring);
            conn.Open();
            
            using (MySqlCommand cmd = new MySqlCommand("Stud_Details", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Reg_No", Reg_No);
                cmd.Parameters.AddWithValue("@Student_ID", Student_ID);
                cmd.Parameters.AddWithValue("@Student_UID", Student_UID);
                cmd.Parameters.AddWithValue("@Student_Fname", Student_Fname);
                cmd.Parameters.AddWithValue("@Student_Mname", Student_Mname);
                cmd.Parameters.AddWithValue("@Student_lname", Student_lname);
                cmd.Parameters.AddWithValue("@Student_mothers_name", Student_mothers_name);
                cmd.Parameters.AddWithValue("@Student_Religion", student_Religion);
                cmd.Parameters.AddWithValue("@Student_Caste", Student_Caste);
                cmd.Parameters.AddWithValue("@Student_Subcaste", Student_Subcaste);
                cmd.Parameters.AddWithValue("@Student_Nationality", Student_Nationality);
                cmd.Parameters.AddWithValue("@Student_MotherTongue", Student_MotherTongue);
                cmd.Parameters.AddWithValue("@Student_POB_Village", Student_POB_Village);
                cmd.Parameters.AddWithValue("@Student_POB_taluka", Student_POB_taluka);
                cmd.Parameters.AddWithValue("@Student_POB_dist", Student_POB_dist);
                cmd.Parameters.AddWithValue("@Student_POB_state", Student_POB_state);
                cmd.Parameters.AddWithValue("@Student_POB_country", Student_POB_country);
                cmd.Parameters.AddWithValue("@Student_DOB", Student_DOB);
                cmd.Parameters.AddWithValue("@Student_last_school", Student_last_school);
                cmd.Parameters.AddWithValue("@Student_last_Standard", Student_last_Standard);
                cmd.Parameters.AddWithValue("@Student_admission_date", Student_admission_date);
                cmd.Parameters.AddWithValue("@Student_admission_Standard", Student_admission_Standard);
                cmd.Parameters.AddWithValue("@Student_progress", Student_progress);
                cmd.Parameters.AddWithValue("@Student_conduct", Student_conduct);
                cmd.Parameters.AddWithValue("@Student_DOL", Student_DOL);
                cmd.Parameters.AddWithValue("@Student_standard_studying", Student_standard_studying);
                cmd.Parameters.AddWithValue("@Student_reasonofleaving", Student_reasonofleaving);
                cmd.Parameters.AddWithValue("@Student_remarks", Student_remarks);
                cmd.Parameters.AddWithValue("@Student_status", Student_status);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        finally
        {
         
        }
    }

    public DataTable BindStudentsList()
    {
        DataTable dt=new DataTable();
        MySqlConnection Connection;
        String UserName = string.Empty;
        string connectionstring = objDBHelper.GetSQLConnectionString();
        Connection = new MySqlConnection(connectionstring);
        Connection.Open();
        
        string query = "Select * from vpems_gen_reg where stud_status = 'Active'";
        MySqlCommand cmd = new MySqlCommand(query, Connection);
        MySqlDataReader dr = cmd.ExecuteReader();
        dt.Load(dr);
        Connection.Close();
        return dt;
    }

    public DataTable ExportToExcel()
    {
        DataTable dt = new DataTable();
        MySqlConnection Connection;
        String UserName = string.Empty;
        string connectionstring = objDBHelper.GetSQLConnectionString();
        Connection = new MySqlConnection(connectionstring);
        Connection.Open();

        string query = "Select * from vpems_gen_reg";
        MySqlCommand cmd = new MySqlCommand(query, Connection);
        MySqlDataReader dr = cmd.ExecuteReader();
        dt.Load(dr);
        Connection.Close();
        return dt;          
    }

    public DataTable GetStudentsList(String RegNo)
    {
        DataTable dt = new DataTable();
        MySqlConnection Connection;
        String UserName = string.Empty;
        string connectionstring = objDBHelper.GetSQLConnectionString();
        Connection = new MySqlConnection(connectionstring);
        Connection.Open();
        
        string query = "Select * from vpems_gen_reg where stud_regno = '" + RegNo +"' and stud_status = 'Active'";
        MySqlCommand cmd = new MySqlCommand(query, Connection);
        MySqlDataReader dr = cmd.ExecuteReader();
        dt.Load(dr);
        Connection.Close();
        return dt;
    }

    public DataTable GetStudentsList1(String StudentName)
    {
        DataTable dt = new DataTable();
        MySqlConnection Connection;
        String UserName = string.Empty;
        string connectionstring = objDBHelper.GetSQLConnectionString();
        Connection = new MySqlConnection(connectionstring);
        Connection.Open();
        
        string query = "Select * from vpems_gen_reg where stud_fname like '%" + StudentName + "%' and stud_status = 'Active'";
        MySqlCommand cmd = new MySqlCommand(query, Connection);
        MySqlDataReader dr = cmd.ExecuteReader();
        dt.Load(dr);
        Connection.Close();
        return dt;
    }

    public void UpdateStudentStatus(String RegNo)
    {
        MySqlConnection Connection;
        String UserName = string.Empty;
        string connectionstring = objDBHelper.GetSQLConnectionString();
        Connection = new MySqlConnection(connectionstring);
        Connection.Open();
        
        string query = "update vpems_gen_reg set stud_status = 'Alumni' where stud_regno = '" + RegNo + "'" ;
        MySqlCommand cmd = new MySqlCommand(query, Connection);
        MySqlDataReader dr = cmd.ExecuteReader();
        Connection.Close();
    }

    public Int64 GetUserDetails(String UserName, String Password)
    {
        MySqlConnection Connection;
        Int64 uid;
        string connectionstring = objDBHelper.GetSQLConnectionString();
        Connection = new MySqlConnection(connectionstring);
        Connection.Open();

        string query = "select uid FROM tblUserLogin WHERE username='" + UserName + "' and password='" + Password + "'";
        MySqlCommand cmd = new MySqlCommand(query, Connection);
        uid = Convert.ToInt64(cmd.ExecuteScalar());
        Connection.Close();
        return uid;
    }

    public String GetAadhaarNo(String parm1)
    {
        MySqlConnection Connection;
        String aadhaar = String.Empty;
        string connectionstring = objDBHelper.GetSQLConnectionString();
        Connection = new MySqlConnection(connectionstring);
        Connection.Open();

        string query = "select stud_uid FROM vpems_gen_reg WHERE stud_uid='" + parm1 + "'";
        MySqlCommand cmd = new MySqlCommand(query, Connection);
        aadhaar = Convert.ToString(cmd.ExecuteScalar());
        Connection.Close();
        return aadhaar;
    }


    public String GetStudStatus(String Regno)
    {
        MySqlConnection Connection;
        String status;
        string connectionstring = objDBHelper.GetSQLConnectionString();
        Connection = new MySqlConnection(connectionstring);
        Connection.Open();

        string query = "select stud_status FROM vpems_gen_reg WHERE stud_regno='" + Regno + "'";
        MySqlCommand cmd = new MySqlCommand(query, Connection);
        status = Convert.ToString(cmd.ExecuteScalar());
        Connection.Close();
        return status;
    }

    public void SetStudStatus(String RegNo, String NewStatus)
    {
        MySqlConnection Connection;
        String UserName = string.Empty;
        string connectionstring = objDBHelper.GetSQLConnectionString();
        Connection = new MySqlConnection(connectionstring);
        Connection.Open();

        string query = "update vpems_gen_reg set stud_status = '" + NewStatus + "' where stud_regno = '" + RegNo + "'";
        MySqlCommand cmd = new MySqlCommand(query, Connection);
        MySqlDataReader dr = cmd.ExecuteReader();
        Connection.Close();
    }
}

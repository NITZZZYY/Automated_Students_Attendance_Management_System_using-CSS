﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Automated_Students_Attendance_Management_System.User
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            con.Open();

            try
            {
                string str = "insert into  TblRegistration values('"+txtName.Text+"','"+DropDownListCourse.SelectedValue.ToString()+"','"+DropDownListYear.SelectedValue.ToString()+"',"+txtMobile.Text+",'"+txtEmail.Text+"','"+txtPass.Text+"')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Student Registration Sucessfully')</script>");
            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
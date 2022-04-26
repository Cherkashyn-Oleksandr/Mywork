using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace DatabaseConnectivity
{
    public partial class loginpage : System.Web.UI.Page  
    {  
        protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from RegisterDataBase where StudentName='" + TextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (temp == 1)
            {
                Response.Write("Student Already Exist");
            }

            conn.Close();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into RegisterDataBase(StudentName,Passwords,EmailId,Department,College)values (@studentname,@passwords,@emailid,@department,@college)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@studentname", TextBox1.Text);
            cmd.Parameters.AddWithValue("@passwords", TextBox2.Text);
            cmd.Parameters.AddWithValue("@emailid", TextBox3.Text);
            cmd.Parameters.AddWithValue("@department", TextBox4.Text);
            cmd.Parameters.AddWithValue("@college", TextBox5.Text);
            cmd.ExecuteNonQuery();

            Response.Write("Student registration Successfully!!!thank you");

            conn.Close();

        }
        catch (Exception ex)
        {
            Response.Write("error" + ex.ToString());
        }
    }
}  
} 
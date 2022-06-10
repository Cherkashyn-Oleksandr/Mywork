using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;


namespace WebApplication1
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LoginForm.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
                conn.Open();
                string insertQuery = "insert into UsersDataBase(Login,Password,Email,Salt)values (@Login,@Password,@Email,@Salt)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                string pwd = TextBox2.Text;
                Security security = Security.GenerateSaltedHash(20, TextBox2.Text);
                cmd.Parameters.AddWithValue("@Login", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Password",security.Pwdhashed );
                cmd.Parameters.AddWithValue("@Email", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Salt", security.Salt);
             

                cmd.ExecuteNonQuery();

                Label4.Text = "Registration Success......!!";

                conn.Close();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }

    }
}
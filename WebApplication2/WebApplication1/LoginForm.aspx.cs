using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RegisterForm.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
                con.Open();
                string pwd = TextBox2.Text;
                

                
                
                string Login = TextBox1.Text;
                
                string command = "select Login  from UsersDataBase where Login='" + Login + "'";
                SqlCommand cmd = new SqlCommand(command, con);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    reader.Close();
                    string commands = "select *  from UsersDataBase where Login='" + Login + "'";
                    SqlCommand comd = new SqlCommand(commands, con);
                    SqlDataReader preader = comd.ExecuteReader();
                    while (preader.Read())
                    {
                        string password = preader["Password"].ToString();
                        string salt = preader["Salt"].ToString();
                        Label4.Text = salt;
                        bool isPasswordMatched = Security.VerifyPassword(pwd, password, salt); 

                        if (isPasswordMatched)
                        {
                            Label4.Text = "Login Success......!!";
                            Response.Redirect("~/HomePage.aspx");
                        }
                        else
                        {
                            Label4.Text = "Login & Password Is not correct Try again..!!";
                        }
                    }
                    
                }
                else
                {
                    Label4.Text = "Login & Password Is not correct Try again..!!";

                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}
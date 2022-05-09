using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Price
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PriceConnectionString"].ConnectionString);
                con.Open();
                string Login = TextBox1.Text;
                string password = TextBox2.Text;
                string command = "select * from PriceDataBase where Login='" + Login + "' and Password='" + password + "'";
                SqlCommand cmd = new SqlCommand(command,con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    Label4.Text = "Login Sucess......!!";
                    Response.Redirect("~/WebForm2.aspx");
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
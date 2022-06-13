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
    public partial class HomePage : System.Web.UI.Page
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
            Response.Redirect("~/AddItemPage.aspx");
        }

       

        protected void Button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ItemsConnectionString"].ConnectionString);
                con.Open();
                string Name = TextBox1.Text;
                string command = "select *  from ItemsDataBase where Name='" + Name + "'";
                SqlCommand cmd = new SqlCommand(command, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TextBox2.Text = reader["Price"].ToString();
                    int price = reader.GetInt32(1);
                    Label4.Text = Convert.ToString(price);
                   
                }
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }

        
    }
}

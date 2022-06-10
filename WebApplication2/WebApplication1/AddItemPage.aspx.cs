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
    public partial class AddItemPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                try
                {

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ItemsConnectionString"].ConnectionString);
                    conn.Open();
                    string insertQuery = "insert into ItemsDataBase(Name,Price)values (@Name,@Price)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                   
                    cmd.Parameters.AddWithValue("@Price", TextBox2.Text);
                    cmd.ExecuteNonQuery();
                    
                    

                    Response.Write("Data has been Added");

                    cmd.ExecuteNonQuery();

                    

                    conn.Close();

                }
                catch (Exception ex)
                {
                    Response.Write("error" + ex.ToString());
                }
            }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HomePage.aspx");
        }
    }
    }

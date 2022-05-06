using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace Weather
{
    public partial class WeatherPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WeatherConnectionString"].ConnectionString);
                conn.Open();
                string insertQuery = "insert into WeatherDataBase(City,Day,Daytempmax,Daytempmin,Nighttempmax,Nighttempmin)values (@city,@day,@daytempmax,@daytempmin,@nighttempmax,@nighttempmin)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@city", TextBox1.Text);
                cmd.Parameters.AddWithValue("@day", TextBox6.Text);
                cmd.Parameters.AddWithValue("@daytempmax", TextBox2.Text);
                cmd.Parameters.AddWithValue("@nighttempmax", TextBox3.Text);
                cmd.Parameters.AddWithValue("@daytempmin", TextBox4.Text);
                cmd.Parameters.AddWithValue("@nighttempmin", TextBox5.Text);
                cmd.ExecuteNonQuery();

                Response.Write("Weather registration Successfully!!!thank you");

                conn.Close();
                
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }
        
        

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WeatherConnectionString"].ConnectionString);
            
            string sql = "select * from WeatherDataBase where city ='" + ListBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            SqlDataReader Reader;
            try
            {
                conn.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    string city = Reader.GetString(0);
                    string Day = Reader.GetString(1);
                    string daytempmax = Reader.GetInt32(2).ToString();
                    string daytempmin = Reader.GetInt32(3).ToString();
                    string nighttempmax = Reader.GetInt32(4).ToString();
                    string nighttempmin = Reader.GetInt32(5).ToString();
                    TextBox1.Text = city;
                    TextBox2.Text = daytempmax;
                    TextBox3.Text = nighttempmax;
                    TextBox4.Text = daytempmin;
                    TextBox5.Text = nighttempmin;
                    TextBox6.Text = Day;
                    
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }
    }
}


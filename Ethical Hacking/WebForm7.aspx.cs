using System;
using System.Data.SqlClient;
using System.Web;
namespace Ethical_Hacking
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Comments.mdf;Integrated Security=True";
        public SqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string sql;
            conn = new SqlConnection(constr);

            string username = TextBox1.Text;
            string password = TextBox2.Text;
            conn.Open();
            sql = "SELECT * FROM Staff WHERE Username = @username AND Password = @password";
            command = new SqlCommand(sql, conn);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            // Execute the command.
            SqlDataReader reader = command.ExecuteReader();

            // Check if the user exists in the database.
            if (reader.Read())
            {
                // The user exists, so the credentials are correct.

                HttpCookie _userCookie = new HttpCookie("Staff");
                _userCookie["Valid"] = "True";
                Response.Cookies.Add(_userCookie);
                _userCookie.Expires = DateTime.Now.AddDays(7);
                Response.Redirect("WebForm6.aspx");
            }
            else
            {
                // The user does not exist, so the credentials are incorrect.

            }
            conn.Close();
            // Get the username and password from the text boxes.











        }
    }
}
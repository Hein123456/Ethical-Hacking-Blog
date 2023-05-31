using System;
using System.Data;
using System.Data.SqlClient;

namespace Ethical_Hacking
{
    public partial class WebForm5 : System.Web.UI.Page
    {

        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Comments.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlDataAdapter adapter;
        public DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loadindex"] != null)
            {
                // Set the value of "loadindex" session variable to 1
                Session["loadindex"] = 1;
            }

            // Call the method to populate comments with index 1
            PopulateComments(1);
        }
        protected void ClearComments()
        {
            // Clear the text in TextBoxes
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";

            // Clear the text in Labels
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            Label10.Text = "";
        }
        protected void PopulateComments(int state)
        {
            // Call method to clear all textboxes
            ClearComments();
            if (state == 1)// initial state load first 5 comments
            {
                SqlCommand command;
                string sql;
                conn = new SqlConnection(constr);
                SqlDataReader dataReader;

                conn.Open();
                sql = @"SELECT * FROM UserComments";
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();
                int index = 0; // index used to refer to comment number
                while (dataReader.Read())
                {
                    if (index == 0)
                    {
                        Label1.Text = dataReader.GetString(1);
                        Label2.Text = dataReader.GetValue(3).ToString();
                        TextBox3.Text = dataReader.GetString(2);
                    }
                    else if (index == 1)
                    {
                        Label3.Text = dataReader.GetString(1);
                        Label4.Text = dataReader.GetDateTime(3).ToString();
                        TextBox4.Text = dataReader.GetString(2);
                    }
                    else if (index == 2)
                    {
                        Label5.Text = dataReader.GetString(1);
                        Label6.Text = dataReader.GetDateTime(3).ToString();
                        TextBox5.Text = dataReader.GetString(2);
                    }
                    else if (index == 3)
                    {
                        Label7.Text = dataReader.GetString(1);
                        Label8.Text = dataReader.GetDateTime(3).ToString();
                        TextBox6.Text = dataReader.GetString(2);
                    }
                    else if (index == 4)
                    {
                        Label9.Text = dataReader.GetString(1);
                        Label10.Text = dataReader.GetDateTime(3).ToString();
                        TextBox7.Text = dataReader.GetString(2);
                    }
                    index++;
                }

                conn.Close();
                Session["loadindex"] = 1; // loadindex used to keep track of current page
            }
            else if ((state == 0)) //back state loade prevoius 5 comments
            {
                if (int.Parse(Session["loadindex"].ToString()) <= 2) // check if current page is page 2 or more (check if there is a prevoius page to load else load page 1)
                {
                    PopulateComments(1);
                }
                else
                {
                    SqlCommand command;
                    string sql;
                    conn = new SqlConnection(constr);
                    SqlDataReader dataReader;

                    conn.Open();
                    sql = @"SELECT * FROM UserComments";
                    command = new SqlCommand(sql, conn);
                    dataReader = command.ExecuteReader();
                    Session["loadindex"] = int.Parse(Session["loadindex"].ToString()) - 1; // decrease page number
                    int loadindex = int.Parse(Session["loadindex"].ToString());

                    int index = 0;
                    while (dataReader.Read())
                    {
                        if (index == (5 * loadindex) - 4)            // Tn = (5*n)-4 formula used to get next set of comments to load
                        {
                            Label1.Text = dataReader.GetString(1);
                            Label2.Text = dataReader.GetDateTime(3).ToString();
                            TextBox3.Text = dataReader.GetString(2);
                        }
                        else if (index == (5 * loadindex) - 3)
                        {
                            Label3.Text = dataReader.GetString(1);
                            Label4.Text = dataReader.GetDateTime(3).ToString();
                            TextBox4.Text = dataReader.GetString(2);
                        }
                        else if (index == (5 * loadindex) - 2)
                        {
                            Label5.Text = dataReader.GetString(1);
                            Label6.Text = dataReader.GetDateTime(3).ToString();
                            TextBox5.Text = dataReader.GetString(2);
                        }
                        else if (index == (5 * loadindex) - 1)
                        {
                            Label7.Text = dataReader.GetString(1);
                            Label8.Text = dataReader.GetDateTime(3).ToString();
                            TextBox6.Text = dataReader.GetString(2);
                        }
                        else if (index == (5 * loadindex))
                        {
                            Label9.Text = dataReader.GetString(1);
                            Label10.Text = dataReader.GetDateTime(3).ToString();
                            TextBox7.Text = dataReader.GetString(2);
                        }
                        index++;
                    }

                    conn.Close();
                }
            }
            else if ((state == 2)) // next state load next 5 comments
            {
                SqlCommand command;
                string sql;
                conn = new SqlConnection(constr);
                SqlDataReader dataReader;

                conn.Open();
                sql = @"SELECT * FROM UserComments";
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();
                Session["loadindex"] = int.Parse(Session["loadindex"].ToString()) + 1;
                int loadindex = int.Parse(Session["loadindex"].ToString());
                int index = 0;
                while (dataReader.Read())
                {
                    if (index == (5 * loadindex) - 4)
                    {
                        Label1.Text = dataReader.GetString(1);
                        Label2.Text = dataReader.GetValue(3).ToString();
                        TextBox3.Text = dataReader.GetString(2);
                    }
                    else if (index == (5 * loadindex) - 3)
                    {
                        Label3.Text = dataReader.GetString(1);
                        Label4.Text = dataReader.GetDateTime(3).ToString();
                        TextBox4.Text = dataReader.GetString(2);
                    }
                    else if (index == (5 * loadindex) - 2)
                    {
                        Label5.Text = dataReader.GetString(1);
                        Label6.Text = dataReader.GetDateTime(3).ToString();
                        TextBox5.Text = dataReader.GetString(2);
                    }
                    else if (index == (5 * loadindex) - 1)
                    {
                        Label7.Text = dataReader.GetString(1);
                        Label8.Text = dataReader.GetDateTime(3).ToString();
                        TextBox6.Text = dataReader.GetString(2);
                    }
                    else if (index == (5 * loadindex))
                    {
                        Label9.Text = dataReader.GetString(1);
                        Label10.Text = dataReader.GetDateTime(3).ToString();
                        TextBox7.Text = dataReader.GetString(2);
                    }
                    index++;
                }

                conn.Close();
            }
            Label11.Text = Session["loadindex"].ToString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string sql = "";
            SqlDataReader dataReader;
            conn = new SqlConnection(constr);

            Int32 Output = 0;

            conn.Open();

            sql = "SELECT MAX(ID) FROM UserComments"; // get the number of comments in the table
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = dataReader.GetInt32(0);

            }
            dataReader.Close();
            command.Dispose();

            ProfanityFilter.ProfanityFilter detector = new ProfanityFilter.ProfanityFilter();
            string username = detector.CensorString(TextBox1.Text);
            string Comment = detector.CensorString(TextBox2.Text);

            Output++; //increase the number of comments to get the next ID
            sql = "INSERT INTO UserComments VALUES (" + Output + ",'" + username + "','" + Comment + "','" + DateTime.Now.ToString() + "')";

            adapter = new SqlDataAdapter();


            command = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            adapter.Dispose();


            // show all comments
            sql = @"SELECT * FROM UserComments";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            int index = 0;
            while (dataReader.Read())
            {
                if (index == 0)
                {
                    Label1.Text = dataReader.GetString(1);
                    Label2.Text = dataReader.GetValue(3).ToString();
                    TextBox3.Text = dataReader.GetString(2);
                }
                else if (index == 1)
                {
                    Label3.Text = dataReader.GetString(1);
                    Label4.Text = dataReader.GetDateTime(3).ToString();
                    TextBox4.Text = dataReader.GetString(2);
                }
                else if (index == 2)
                {
                    Label5.Text = dataReader.GetString(1);
                    Label6.Text = dataReader.GetDateTime(3).ToString();
                    TextBox5.Text = dataReader.GetString(2);
                }
                else if (index == 3)
                {
                    Label7.Text = dataReader.GetString(1);
                    Label8.Text = dataReader.GetDateTime(3).ToString();
                    TextBox6.Text = dataReader.GetString(2);
                }
                else if (index == 4)
                {
                    Label9.Text = dataReader.GetString(1);
                    Label10.Text = dataReader.GetDateTime(3).ToString();
                    TextBox7.Text = dataReader.GetString(2);
                }
                index++;
            }

            conn.Close();
            Session["loadindex"] = 1;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            PopulateComments(0);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            PopulateComments(2);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Ethical_Hacking
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Comments.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlDataAdapter adapter;
        public DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["loadindex2"] = 1;
            HttpCookie _userCookieRetreive = Request.Cookies["Staff"];
            if (_userCookieRetreive != null)                   //if the cookie is not empty
            {
                if (_userCookieRetreive["Valid"] != "True")
                {
                    Response.Redirect("WebForm7.aspx");
                }

            }
            else
            {
                Response.Redirect("WebForm7.aspx");
            }
            SqlCommand command;
            string sql;
            conn = new SqlConnection(constr);
            adapter = new SqlDataAdapter();
            ds = new DataSet();

            conn.Open();
            sql = @"SELECT * FROM UserComments";
            command = new SqlCommand(sql, conn);
            adapter.SelectCommand = command;
            adapter.Fill(ds);


            GridView1.DataSource = ds;
            GridView1.DataBind(); //Binding is required for web apps
            conn.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command;
            string sql;
            conn = new SqlConnection(constr);
            SqlDataReader dataReader;

            conn.Open();
            sql = @"SELECT * FROM UserComments WHERE Id = " + TextBox1.Text + "";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                TextBox2.Text = dataReader.GetInt32(0).ToString();
                TextBox3.Text = dataReader.GetString(1);
                TextBox4.Text = dataReader.GetString(2);
                try
                {
                    TextBox5.Text = dataReader.GetDateTime(3).ToString();
                }
                catch { }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string sql = "";
            
            conn = new SqlConnection(constr);

           

            conn.Open();

            sql = "INSERT INTO UserComments VALUES (" + Int32.Parse(TextBox2.Text) + ",'" + TextBox3.Text + "','" + TextBox4.Text + "'," + DateTime.Parse(TextBox5.Text) + ")";

            adapter = new SqlDataAdapter();


            command = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            adapter.Dispose();
            
            sql = @"SELECT * FROM UserComments";
            command = new SqlCommand(sql, conn);
            adapter.SelectCommand = command;
            adapter.Fill(ds);


            GridView1.DataSource = ds;
            GridView1.DataBind(); //Binding is required for web apps
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string sql = "";

            conn = new SqlConnection(constr);



            conn.Open();

            sql = "UPDATE UserComments SET Username ='" + TextBox3.Text + "', Comment = '" + TextBox4.Text + "', Date =" + DateTime.Parse(TextBox5.Text) + " WHERE Id = "+(TextBox2.Text);

            adapter = new SqlDataAdapter();


            command = new SqlCommand(sql, conn);
            adapter.UpdateCommand = new SqlCommand(sql, conn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            adapter.Dispose();

            sql = @"SELECT * FROM UserComments";
            command = new SqlCommand(sql, conn);
            adapter.SelectCommand = command;
            adapter.Fill(ds);


            GridView1.DataSource = ds;
            GridView1.DataBind(); //Binding is required for web apps
            conn.Close();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            string delete_query = "DELETE FROM UserComments WHERE Id =" + TextBox1.Text ;
            SqlCommand command;
          

            conn = new SqlConnection(constr);



            conn.Open();
            command = new SqlCommand(delete_query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();

            conn.Close();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            PopulateComments(0);
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            PopulateComments(2);
        }
        public void PopulateComments(int State)
        {
            
                
                if (State == 1)// initial state load first 5
                {
                SqlCommand command;
                string sql;
                conn = new SqlConnection(constr);
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                conn.Open();
                sql = @"SELECT * FROM UserComments";
                command = new SqlCommand(sql, conn);
                adapter.SelectCommand = command;
                adapter.Fill(ds);


                GridView1.DataSource = ds;
                GridView1.DataBind(); //Binding is required for web apps
                conn.Close();
                Session["loadindex2"] = 1;
                }
                else if ((State == 0)) //back state loade prevoius 5
                {
                    if (int.Parse(Session["loadindex2"].ToString()) <= 2) { PopulateComments(1); }
                    else
                    {
                    SqlCommand command;
                    string sql;
                    conn = new SqlConnection(constr);
                    adapter = new SqlDataAdapter();
                    ds = new DataSet();
                    Session["loadindex2"] = int.Parse(Session["loadindex2"].ToString()) - 1;
                    int loadindex = int.Parse(Session["loadindex2"].ToString());
                    loadindex = (5 * loadindex) - 4;
                    conn.Open();
                    sql = @"SELECT * FROM UserComments WHERE Id >= " + loadindex;
                    command = new SqlCommand(sql, conn);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);


                    GridView1.DataSource = ds;
                    GridView1.DataBind(); //Binding is required for web apps
                    conn.Close();
                   

                        

                       
                    }
                }
                else if ((State == 2)) // next state load next 5
                {
                SqlCommand command;
                string sql;
                conn = new SqlConnection(constr);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                Session["loadindex2"] = int.Parse(Session["loadindex2"].ToString()) + 1;
                int loadindex = int.Parse(Session["loadindex2"].ToString());
                loadindex = (5 * loadindex) - 4;
                conn.Open();
                sql = @"SELECT * FROM UserComments WHERE Id >= " + loadindex;
                command = new SqlCommand(sql, conn);
                adapter.SelectCommand = command;
                adapter.Fill(ds);


                GridView1.DataSource = ds;
                GridView1.DataBind(); //Binding is required for web apps
                conn.Close();
                
                   
                   

                    
                }
            Label11.Text = Session["loadindex2"].ToString();


            }
        }
    }

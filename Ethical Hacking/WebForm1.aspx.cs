using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ethical_Hacking
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Retrieve the "Visited" cookie from the request
            HttpCookie _userCookieRetreive = Request.Cookies["Visited"];

            if (_userCookieRetreive != null) // Check if the cookie is not empty
            {
                if (_userCookieRetreive["Over18"] == "True") // Check if the "Over18" value in the cookie is set to "True"
                {
                    // Redirect the user to "WebFrom2.aspx"
                    Response.Redirect("WebForm2.aspx");
                }
            }

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            // Get the year from the text box.
            int year = Convert.ToInt32(TextBox3.Text);

            // Set the year of the calendar.


            // Set the calendar to the first of Jan of that year.
            Calendar1.SelectedDate = new DateTime(year, 1, 1);
            Calendar1.VisibleDate = new DateTime(year, 1, 1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Get the year from the text box.
            int year = Convert.ToInt32(TextBox3.Text);

            // Set the year of the calendar.


            // Set the calendar to the first of Jan of that year.
            Calendar1.SelectedDate = new DateTime(year, 1, 1);
            Calendar1.VisibleDate = new DateTime(year, 1, 1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Get the date from the calendar.
            DateTime selectedDate = Calendar1.SelectedDate;

            // Get today's date.
            DateTime today = DateTime.Now;

            // Calculate the difference between the two dates.
            TimeSpan difference = today - selectedDate;

            // Check if the difference is more than 18 years.
            if ((difference.TotalDays) / 365 > 18)
            {
                // The difference is more than 18 years.
                Label1.Text = "Enter birthdate:";

                // Create a new "Visited" cookie
                HttpCookie _userCookie = new HttpCookie("Visited");

                // Set the value of the "Over18" key in the cookie to "True"
                _userCookie["Over18"] = "True";

                // Add the cookie to the response
                Response.Cookies.Add(_userCookie);

                // Set the expiration date of the cookie to 7 days from the current date and time
                _userCookie.Expires = DateTime.Now.AddDays(7);

                // Redirect the user to "WebForm2.aspx"
                Response.Redirect("WebForm2.aspx");

            }
            else
            {
                // The difference is less than 18 years.
                Label1.Text = "Valid Birth date";
            }
        }
    }
}
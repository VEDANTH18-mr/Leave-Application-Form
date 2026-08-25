using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class Calender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;
            lblselctedDate.Text = "Selected Date: " + selectedDate.ToString("yyyy-MM-dd");


            Session["LeaveDate"] = selectedDate;
        }

        protected void btnApplyLeave_Click(object sender, EventArgs e)
        {
            Response.Redirect("Leaveapply.aspx");

        }
    }
}
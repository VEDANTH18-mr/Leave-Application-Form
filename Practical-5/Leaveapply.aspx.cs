using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class Leaveapply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Request.Cookies["EmpName"] != null)
                {
                    Txttemp.Text = Request.Cookies["EmpName"].Value;
                }

                
                if (Session["LeaveDate"] != null)
                {
                    DateTime leaveDate = (DateTime)Session["LeaveDate"];
                    lblLeaveDate.Text = "Selected Leave Date: " +
                                        leaveDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    lblLeaveDate.Text = "No leave date selected.";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ename = Txttemp.Text;
            string reason = txtReason.Text;

            
            if (Session["LeaveDate"] == null)
            {
                lblMessage.Text = "Please select a leave date.";
                return;
            }

            DateTime leaveDate = (DateTime)Session["LeaveDate"];

      
            Session["EmpName"] = ename;
            Session["LeaveDate"] = leaveDate;
            Session["Reason"] = reason;

            
            if (chkRememberName.Checked)
            {
                Response.Cookies["EmpName"].Value = ename;
                Response.Cookies["EmpName"].Expires =
                    DateTime.Now.AddDays(30);
            }

           
            lblMessage.Text =
                "<b>Leave application submitted successfully!</b><br/>" +
                "Employee Name: " + ename + "<br/>" +
                "Leave Date: " + leaveDate.ToString("yyyy-MM-dd") + "<br/>" +
                "Reason: " + reason;
        }
    }
}
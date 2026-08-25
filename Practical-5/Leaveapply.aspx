<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Leaveapply.aspx.cs" Inherits="Practical_5.Leaveapply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Leave Application</h3>

            Employee Name:
            <asp:TextBox ID="Txttemp" runat="server"></asp:TextBox>
            <br />
            <br />

            Leave Date:
            <asp:Label ID="lblLeaveDate" runat="server"></asp:Label>
            <br />
             <br />


            Leave Type:
            <asp:DropDownList ID="ddlLeaveType" runat="server" >
                    <asp:ListItem Text="Select Leave Type" Value="" />
                <asp:ListItem Text="Sick Leave" Value="Sick Leave" />
                <asp:ListItem Text="Casual Leave" Value="Casual Leave" />
                <asp:ListItem Text="Earned Leave" Value="Earned Leave" />
            </asp:DropDownList>   
            <br />
            <br />

            Reason:
            <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine" Rows="4" Columns="20"></asp:TextBox>
            <br />
            <br />  

            Remember Name:
            <asp:CheckBox ID="chkRememberName" runat="server" Text="Remember my Name......" />
            <br />
            <br />

            <asp:Button ID="Button1" runat="server" Text="Submit Leave" OnClick="Button1_Click" />
            <br />
            <br />

            <asp:Label ID="lblMessage" runat="server"></asp:Label>



        </div>
        </form>
</body>
</html>

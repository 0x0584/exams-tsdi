<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConnectionPage.aspx.cs"
    Inherits="SiteWeb.ConnectionPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:TextBox ID="tbusrname" runat="server"> </asp:TextBox>
            Username
            <br />
            <asp:TextBox ID="tbpasswd" runat="server"> </asp:TextBox>
            Password
            <br />
            
            <asp:Button ID="btnsignin" runat="server" Text="Sign in" />
            <asp:CheckBox ID="chkguest" runat="server" Text="Guest" 
                oncheckedchanged="CheckBox1_CheckedChanged"/>
        </p>
    </div>
    </form>
</body>
</html>

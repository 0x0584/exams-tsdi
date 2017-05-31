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
        <i>For a guest session just type click </i>Sign in <i>button</i>
        <br />
        <asp:Label ID="lblerr" runat="server" Text="" Style="color: Red;" />
        <p>
            <asp:TextBox ID="tbusrname" runat="server"> </asp:TextBox><i>E-mail</i>
            <br />
           
            <asp:TextBox ID="tbpasswd" runat="server"> </asp:TextBox> <i>Password</i>
            <br />
            <asp:Button ID="btnsignin" runat="server" Text="Sign in" OnClick="btnsignin_Click"
                Style="margin: 0px 0px 0px 40px;" />
            <asp:CheckBox ID="chkguest" runat="server" Text="Guest" Style="margin: 0px 0px 0px 15px;" />
        
        </p>
    </div>
    </form>
</body>
</html>

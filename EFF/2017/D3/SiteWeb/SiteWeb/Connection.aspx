<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connection.aspx.cs" Inherits="SiteWeb.Connection" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="tbid" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="id"></asp:Label>
        <br />
        <asp:TextBox ID="tbpass" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
        <br />
        <asp:Button ID="btnsignin" runat="server" onclick="Button1_Click" Text="Sign-In" />
    
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
